using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Abstraction
{
    public interface IBlockVersionStrategy
    {
        AssessmentTypes AssessmentType { get; }
        Task<ICollection<BlockVersion>> Generate();
    }
}