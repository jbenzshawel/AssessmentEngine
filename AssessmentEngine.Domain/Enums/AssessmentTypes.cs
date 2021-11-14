using System.Diagnostics.CodeAnalysis;

namespace AssessmentEngine.Domain.Enums
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum AssessmentTypes
    {
        Unknown = 0,
        EFT = 2,
        VetFlexII = 3,
        VetFlexIII = 4
    }
}