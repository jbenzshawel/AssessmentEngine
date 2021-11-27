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
    public class VetFlexIIBlockVersionStrategy : BlockVersionStrategyBase, IBlockVersionStrategy
    {
        public VetFlexIIBlockVersionStrategy(ILookupService lookupService) 
            : base(lookupService) { }
        
        public AssessmentTypes AssessmentType => AssessmentTypes.VetFlexII;
        
        public async Task<ICollection<BlockVersion>> Generate()
        {
            var blockTypes = (await LookupService.BlockTypes(AssessmentType)).ToList();
            
            var firstSet = blockTypes.Where(x => x.SortOrder % 2 != 0)
                .Select(blockType => new BlockVersion
                {
                    BlockTypeId = blockType.Id, 
                    CognitiveLoad = false, 
                    Series = null, 
                    Uid = Guid.NewGuid()
                }).ToList();
            
            var secondSent = blockTypes.Where(x => x.SortOrder % 2 == 0)
                .Select(blockType => new BlockVersion
                {
                    BlockTypeId = blockType.Id, 
                    CognitiveLoad = false, 
                    Series = null, 
                    Uid = Guid.NewGuid()
                }).ToList();

            return ShuffleAndSort(firstSet)
                    .Concat(ShuffleAndSort(secondSent, sortOffset: 6))
                    .ToList();
        }
    }
}