using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Identity
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
