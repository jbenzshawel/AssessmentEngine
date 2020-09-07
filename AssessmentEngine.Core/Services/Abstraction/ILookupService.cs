using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Implementation;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface ILookupService
    {
        Task<IEnumerable<AssessmentTypeDTO>> AssessmentTypes();
        Task<IEnumerable<BlockTypeDTO>> BlockTypes();
    }
}