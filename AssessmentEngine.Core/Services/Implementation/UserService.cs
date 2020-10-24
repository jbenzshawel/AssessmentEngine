using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class UserService : CrudServiceBase<ApplicationDbContext>, IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(ApplicationDbContext dbContext, IMapperAdapter mapper, UserManager<ApplicationUser> userManager) : base(dbContext, mapper)
        {
            _userManager = userManager;
        }
        
        public async Task<IEnumerable<UserDTO>> GetParticipants()
        {
            var query = await DbContext.Users
                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                .Include(x => x.ApplicationUserAudits)
                .Include(x => x.AssessmentVersions)
                .Where(x => x.UserRoles.Any(y => y.Role.Name == ApplicationRoles.Participant))
                .Select(x => new 
                {
                    x.Id,
                    x.UserName,
                    x.ParticipantId,
                    Enabled = !x.LockoutEnd.HasValue,
                    Roles = x.UserRoles.Select(ur => ur.Role.Name),
                    ApplicationUserAudits = x.ApplicationUserAudits
                        .Where(y => y.ApplicationUserAuditTypeId == (int)ApplicationUserAuditTypes.Login)
                        .Select(y => y.ActionDate),
                    AllowDelete = !x.AssessmentVersions.Any()
                })
                .OrderBy(x => x.UserName)
                .ToListAsync();

            return query.Select(x => new UserDTO
            {
                UserId = x.Id,
                UserName = x.UserName,
                ParticipantId = x.ParticipantId,
                Enabled = x.Enabled,
                Roles = x.Roles,
                LastLoginDate = x.ApplicationUserAudits.Any() 
                    ? x.ApplicationUserAudits.Last() 
                    : (DateTime?)null,
                AllowDelete = x.AllowDelete
            });
        }

        public async Task SetAudit(string userName, ApplicationUserAuditTypes auditType)
        {
            var userId = GetUserId(userName);

            CreateEntity(new ApplicationUserAudit
            {
                ApplicationUserId = userId,
                ApplicationUserAuditTypeId = (int)auditType,
                ActionDate = DateTime.Now
            });
            
            await SaveChangesAsync();
        }

        private Guid GetUserId(string userName)
        {
            var userId = DbContext
                .Users
                .Where(x => x.UserName.ToLower() == userName.ToLower())
                .Select(x => x.Id)
                .SingleOrDefault();

            if (userId == Guid.Empty)
                throw new Exception($"User with UserName {userName} does not exist");
            
            return userId;
        }

        public async Task<bool> ValidateParticipant(ApplicationUser participant)
        {
            var participantIdExists = await DbContext.Users.AnyAsync(x => 
                    x.ParticipantId.ToLower() == participant.ParticipantId.ToLower());
            
            if (participantIdExists)
            {
                participant.ValidationErrors.Add(
                    $"Participant Id {participant.ParticipantId} must be unique");
            }

            return participant.IsValid;
        }

        public async Task DeleteUser(string userId)
        {
            var parsedUserId = Guid.Parse(userId);
            
            using (var transaction = await DbContext.Database.BeginTransactionAsync())
            {
                var user = await _userManager.FindByIdAsync(userId);
                
                if (user == null)  return;
         
                await DeleteUserLogins(parsedUserId);

                await _userManager.DeleteAsync(user);
                
                await transaction.CommitAsync();
            }
        }

        private async Task DeleteUserLogins(Guid parsedUserId)
        {
            var userLogins = DbContext.UserLogins.Where(x => x.UserId == parsedUserId);
            DbContext.UserLogins.RemoveRange(userLogins);
            await DbContext.SaveChangesAsync();
        }
    }
}