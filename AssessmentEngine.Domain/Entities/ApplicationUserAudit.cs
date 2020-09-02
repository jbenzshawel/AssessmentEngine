using System;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserAudit : EntityBase
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime ActionDate { get; set; }
        public int ApplicationUserAuditTypeId { get; set; }
        public ApplicationUserAuditType ApplicationUserAuditType { get; set; }
    }
}