using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Identity
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
