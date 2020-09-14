using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AssessmentEngine.Domain.Validation;

namespace AssessmentEngine.Domain.Entities
{
    public partial class ApplicationUser : IValidatable
    {
        [NotMapped]
        public bool IsValid => ValidationErrors.Count == 0;
        
        [NotMapped]
        public List<string> ValidationErrors { get; set; } = new List<string>();
    }
}