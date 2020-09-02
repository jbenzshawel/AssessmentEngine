using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentType : LookupEntityBase
    {
        public ICollection<Assessment> Assessments { get; set; }
    }
}