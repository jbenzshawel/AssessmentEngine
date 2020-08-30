using System;

namespace AssessmentEngine.Domain.Identity
{
    public class ApplicationUserAudit : EntityBase
    {
        public DateTime ActionDate { get; set; }
        public int ApplicationUserAuditTypeId { get; set; }
        public ApplicationUserAuditType ApplicationUserAuditType { get; set; }
    }
}