using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class BlockVersionGeneratorFactory : IBlockVersionGeneratorFactory
    {
        private readonly IEnumerable<IBlockVersionGenerator> _generators;

        public BlockVersionGeneratorFactory(IEnumerable<IBlockVersionGenerator> generators)
        {
            _generators = generators;
        }

        public async Task<ICollection<BlockVersion>> Generate(AssessmentTypes assessmentType)
        {
            var generator = _generators.SingleOrDefault(x => x.AssessmentType == assessmentType);

            if (generator is null)
            {
                throw new ArgumentOutOfRangeException(nameof(assessmentType),
                    $"Assessment Type {assessmentType} is not supported");
            }

            return await generator.Generate();
        }
    }
}