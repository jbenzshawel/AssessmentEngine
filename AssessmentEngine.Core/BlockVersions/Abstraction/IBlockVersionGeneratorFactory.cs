using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.BlockVersions.Abstraction
{
    public interface IBlockVersionGeneratorFactory
    {
        IBlockVersionGenerator Create(AssessmentTypes assessmentType);
    }
}