using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class BlockVersionGenerator : IBlockVersionGenerator
    {
        private readonly IEnumerable<IBlockVersionStrategy> _strategies;

        public BlockVersionGenerator(IEnumerable<IBlockVersionStrategy> strategies)
        {
            _strategies = strategies;
        }

        public async Task<ICollection<BlockVersion>> Generate(AssessmentTypes assessmentType)
        {
            var strategy = _strategies.SingleOrDefault(x => x.AssessmentType == assessmentType);

            if (strategy is null)
            {
                throw new ArgumentOutOfRangeException(nameof(assessmentType),
                    $"Assessment Type {assessmentType} is not supported");
            }

            return await strategy.Generate();
        }
    }
}