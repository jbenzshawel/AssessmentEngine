using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserAuditType : LookupEntityBase
    {
        public IEnumerable<ApplicationUserAudit> ApplicationUserAudits { get; set; }
    }
}