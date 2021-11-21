using System;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentParticipant : EntityBase
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
    }
}