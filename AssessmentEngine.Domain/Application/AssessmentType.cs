using System.Collections.Generic;

namespace AssessmentEngine.Domain.Application
{
    public class AssessmentType : LookupEntityBase
    {
        public IEnumerable<Assessment> Assessments { get; set; }
    }
}