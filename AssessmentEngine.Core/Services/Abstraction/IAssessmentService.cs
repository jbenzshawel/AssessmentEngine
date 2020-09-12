using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Entities;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IAssessmentService : ICrudServiceBase
    {
        string GetRandomSeries();
        Task<IEnumerable<AssessmentDTO>> GetAssessments();
        Task SaveAssessment(AssessmentDTO dto);
        Task<IEnumerable<AssessmentVersionDTO>> GetAssessmentVersions();
        Task DeleteAssessmentVersion(int assessmentVersionId);
        Task<AssessmentVersionDTO> GetAssessmentVersion(int id);
        Task SaveAssessmentVersion(AssessmentVersionDTO dto);
    }
}