using System.Collections.Generic;

namespace Assessment.Domain.Application
{
    public class AssessmentType : EntityBase
    {
        public string Name { get; set; }
        
        public IEnumerable<Assessment> Assessments { get; set; }
    }
}