using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
