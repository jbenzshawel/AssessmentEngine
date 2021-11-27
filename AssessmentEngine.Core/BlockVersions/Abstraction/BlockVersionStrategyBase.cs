using System.Collections.Generic;
using System.Linq;
using AssessmentEngine.Core.Extensions;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Entities;

namespace AssessmentEngine.Core.BlockVersions.Abstraction
{
    public abstract class BlockVersionStrategyBase
    {
        protected readonly ILookupService LookupService;

        protected BlockVersionStrategyBase(ILookupService lookupService)
        {
            LookupService = lookupService;
        }

        protected ICollection<BlockVersion> ShuffleAndSort(
            IList<BlockVersion> blockVersions,
            int sortOffset = 0)
        {
            blockVersions.Shuffle();
            
            return blockVersions.Select((v, i) =>
            {
                v.SortOrder = i + sortOffset + 1;
                return v;
            }).OrderBy(v => v.SortOrder).ToList();;
        }
    }
}