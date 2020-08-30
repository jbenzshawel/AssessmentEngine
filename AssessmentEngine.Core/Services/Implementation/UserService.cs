using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO.Identity;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
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
            => await DbContext.Users
                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                .Select(x => new User
                {
                    UserName = x.UserName,
                    RoleName = x.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault(),
                    LastLoginDate = DateTime.Now // todo: pull from audit table
                }).ToListAsync();
    }
}