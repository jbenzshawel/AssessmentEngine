using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Core.Extensions;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class EFTBlockVersionGenerator : IBlockVersionGenerator
    {
        private readonly ILookupService _lookupService;
        private readonly IRandomService _randomService;

        public EFTBlockVersionGenerator(ILookupService lookupService, IRandomService randomService)
        {
            _lookupService = lookupService;
            _randomService = randomService;
        }

        public AssessmentTypes AssessmentType => AssessmentTypes.EFT;
        
        public async Task<ICollection<BlockVersion>> Generate()
        {
            var blockVersions = new List<BlockVersion>();
            var blockTypes = await _lookupService.BlockTypes();

            foreach (var blockType in blockTypes)
            {
                var cognitiveLoad = blockType.SortOrder % 2 == 0;
                
                blockVersions.Add(new BlockVersion
                {
                    BlockTypeId = blockType.Id,
                    CognitiveLoad = cognitiveLoad,
                    Series = cognitiveLoad ? _randomService.GetRandomSeries() : null,
                    Uid = Guid.NewGuid()
                });
            }

            blockVersions.Shuffle();
            
            return blockVersions.Select((v, i) =>
            {
                v.SortOrder = i + 1;
                return v;
            }).OrderBy(v => v.SortOrder).ToList();;
        }
    }
}