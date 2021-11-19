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
    public class EFTBlockVersionStrategy : BlockVersionStrategyBase, IBlockVersionStrategy
    {
        private readonly IRandomService _randomService;

        public EFTBlockVersionStrategy(ILookupService lookupService, IRandomService randomService)
            : base(lookupService)
        {
            _randomService = randomService;
        }

        public AssessmentTypes AssessmentType => AssessmentTypes.EFT;
        
        public async Task<ICollection<BlockVersion>> Generate()
        {
            var blockTypes = await LookupService.BlockTypes();

            var blockVersions = (from blockType in blockTypes 
                let cognitiveLoad = blockType.SortOrder % 2 == 0 
                select new BlockVersion
                {
                    BlockTypeId = blockType.Id, 
                    CognitiveLoad = cognitiveLoad, 
                    Series = cognitiveLoad ? _randomService.GetRandomSeries() : null, 
                    Uid = Guid.NewGuid()
                }).ToList();

            return ShuffleAndSort(blockVersions);
        }
    }
}