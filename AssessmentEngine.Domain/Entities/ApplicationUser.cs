using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Entities
{
    public partial class ApplicationUser : IdentityUser<Guid>
    {
        public string ParticipantId { get; set; }
        public int? ParticipantTypeId { get; set; }
        public ParticipantType ParticipantType { get; set; }
        
        // Add custom user columns here
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<AssessmentParticipant> AssessmentParticipants { get; set; }
        public virtual ICollection<ApplicationUserAudit> ApplicationUserAudits { get; set; }
    }
}