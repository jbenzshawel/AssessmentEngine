using System.Collections.Generic;

namespace AssessmentEngine.Domain.Validation
{
    public interface IValidatable
    {
        bool IsValid { get; }
        ICollection<string> ValidationErrors { get; set; }
    }
}