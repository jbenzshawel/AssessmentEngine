using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO.Identity;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task SetAudit(string userName, ApplicationUserAuditTypes auditType);
    }
}