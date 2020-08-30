using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Identity
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
