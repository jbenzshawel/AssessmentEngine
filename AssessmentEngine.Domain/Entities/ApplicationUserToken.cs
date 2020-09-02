using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
