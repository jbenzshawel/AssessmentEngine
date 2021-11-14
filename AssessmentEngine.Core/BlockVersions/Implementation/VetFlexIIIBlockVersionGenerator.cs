using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class VetFlexIIIBlockVersionGenerator : IBlockVersionGenerator
    {
        public AssessmentTypes AssessmentType => AssessmentTypes.VetFlexIII;
        
        public Task<ICollection<BlockVersion>> Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}