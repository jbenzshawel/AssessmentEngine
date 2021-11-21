using System.Diagnostics.CodeAnalysis;

namespace AssessmentEngine.Domain.Enums
{
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Block type abbreviations")]
    public enum BlockTypes
    {
        Unknown = 0,
        EP1,
        EP2,
        EN1,
        EN2,
        SP1,
        SP2,
        SN1,
        SN2,
        VP1,
        VP2,
        VN1,
        VN2
    }
}