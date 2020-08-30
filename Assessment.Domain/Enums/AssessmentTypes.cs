using System.Diagnostics.CodeAnalysis;

namespace Assessment.Domain.Enums
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum AssessmentTypes
    {
        Unknown = 0,
        DualNBack,
        EFT
    }
}