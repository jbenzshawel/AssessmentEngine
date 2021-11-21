using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface ILookupService
    {
        Task<IEnumerable<LookupTypeDTO>> AssessmentTypes();
        Task<IEnumerable<LookupTypeDTO>> BlockTypes(AssessmentTypes assessmentType);
        Task<IEnumerable<LookupTypeDTO>> ParticipantTypes();
    }
}