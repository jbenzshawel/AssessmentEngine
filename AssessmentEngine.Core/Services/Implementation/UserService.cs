using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO.Identity;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class UserService : CrudServiceBase<ApplicationDbContext>, IUserService
    {
        public UserService(ApplicationDbContext dbContext, IMapperAdapter mapper) : base(dbContext, mapper)
        {
        }
        
        public async Task<IEnumerable<User>> GetAll()
        {
            var query = await DbContext.Users
                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                .Include(x => x.ApplicationUserAudits)
                .Select(x => new 
                {
                    UserName = x.UserName,
                    RoleName = x.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault(),
                    ApplicationUserAudits = x.ApplicationUserAudits
                        .Where(y => y.ApplicationUserAuditTypeId == (int)ApplicationUserAuditTypes.Login)
                        .Select(y => y.ActionDate)
                }).ToListAsync();

            return query.Select(x => new User
            {
                UserName = x.UserName,
                RoleName = x.RoleName,
                LastLoginDate = x.ApplicationUserAudits.Any() 
                    ? x.ApplicationUserAudits.Last() 
                    : (DateTime?)null
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
    }
}