using System;
using Microsoft.AspNetCore.Identity;

namespace AssessmentEngine.Domain.Entities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}
