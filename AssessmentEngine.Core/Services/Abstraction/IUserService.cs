using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetParticipants();
        Task SetAudit(string userName, ApplicationUserAuditTypes auditType);
        Task<bool> ValidateParticipant(ApplicationUser participant);
        Task DeleteUser(string userId);
        Task DisableUser(string userName);
        Task ToggleLockout(string userId);
    }
}