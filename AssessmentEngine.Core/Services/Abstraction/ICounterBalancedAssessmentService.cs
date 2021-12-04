using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface ICounterBalancedAssessmentService
    {
        Task CreateAssessmentVersion(AssessmentVersionDTO dto);
        Task CreateGroup(TaskVersionGroupDTO dto);
        Task<IEnumerable<TaskVersionGroupDTO>> GetVersionsByAssessmentType(AssessmentTypes assessmentType);
        Task<TaskVersionGroupDTO> GetById(int id);
    }
}