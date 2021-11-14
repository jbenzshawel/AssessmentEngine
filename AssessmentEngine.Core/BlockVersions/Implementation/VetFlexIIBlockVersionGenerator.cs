using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class VetFlexIIBlockVersionGenerator : IBlockVersionGenerator
    {
        public AssessmentTypes AssessmentType => AssessmentTypes.VetFlexII;
        
        public Task<ICollection<BlockVersion>> Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}