using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class ParticipantType : LookupEntityBase
    {
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}