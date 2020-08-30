using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO.Identity;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
    }
}