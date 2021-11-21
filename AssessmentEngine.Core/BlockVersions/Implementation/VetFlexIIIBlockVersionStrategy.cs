using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class VetFlexIIIBlockVersionStrategy : BlockVersionStrategyBase, IBlockVersionStrategy
    {
        public VetFlexIIIBlockVersionStrategy(ILookupService lookupService)
            : base(lookupService) { }

        public AssessmentTypes AssessmentType => AssessmentTypes.VetFlexIII;
        
        public async Task<ICollection<BlockVersion>> Generate()
        {
            var blockTypes = await LookupService.BlockTypes(AssessmentType);

            var blockVersions= blockTypes.Select(blockType => new BlockVersion
            {
                BlockTypeId = blockType.Id, 
                CognitiveLoad = false, 
                Series = null, 
                Uid = Guid.NewGuid()
            }).ToList();

            return ShuffleAndSort(blockVersions);
        }
    }
}