using System;
using System.Collections.Generic;
using System.Linq;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Implementation
{
    public class BlockVersionGeneratorFactory : IBlockVersionGeneratorFactory
    {
        private IEnumerable<IBlockVersionGenerator> _generators;

        public BlockVersionGeneratorFactory(IEnumerable<IBlockVersionGenerator> generators)
        {
            _generators = generators;
        }

        public IBlockVersionGenerator Create(AssessmentTypes assessmentType)
        {
            var generator = _generators.SingleOrDefault(x => x.AssessmentType == assessmentType);

            if (generator is null)
            {
                throw new ArgumentOutOfRangeException(nameof(assessmentType),
                    $"Assessment Type {assessmentType} is not supported");
            }

            return generator;
        }
    }
}