using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class ParticipantType : LookupEntityBase
    {
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}