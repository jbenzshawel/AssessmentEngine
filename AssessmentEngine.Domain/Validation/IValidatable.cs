using System.Collections.Generic;

namespace AssessmentEngine.Domain.Validation
{
    public interface IValidatable
    {
        bool IsValid { get; }
        List<string> ValidationErrors { get; set; }
    }
}