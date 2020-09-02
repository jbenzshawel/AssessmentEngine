using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserAuditType : LookupEntityBase
    {
        public IEnumerable<ApplicationUserAudit> ApplicationUserAudits { get; set; }
    }
}