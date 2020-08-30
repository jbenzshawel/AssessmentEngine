using System.Collections.Generic;

namespace AssessmentEngine.Domain.Identity
{
    public class ApplicationUserAuditType : LookupEntityBase
    {
        public IEnumerable<ApplicationUserAudit> Users { get; set; }
    }
}