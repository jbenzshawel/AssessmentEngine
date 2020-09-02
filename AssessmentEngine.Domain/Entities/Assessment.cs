using System;
using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class Assessment : EntityBase
    {
        public int AssessmentTypeId { get; set; }
        public AssessmentType AssessmentType { get; set; }
        public Guid AssessmentUserUID { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        
        public virtual ICollection<AssessmentBlock> AssessmentBlocks { get; set; }
        public virtual ICollection<AssessmentParticipant> AssessmentParticipants { get; set; }
    }
}