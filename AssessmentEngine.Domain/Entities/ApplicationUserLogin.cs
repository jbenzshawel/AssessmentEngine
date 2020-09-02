using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
