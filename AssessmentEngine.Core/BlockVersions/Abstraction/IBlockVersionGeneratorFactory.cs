using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Abstraction
{
    public interface IBlockVersionGeneratorFactory
    {
        Task<ICollection<BlockVersion>> Generate(AssessmentTypes assessmentType);
    }
}