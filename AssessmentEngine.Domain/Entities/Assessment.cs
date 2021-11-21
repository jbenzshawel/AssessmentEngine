using System;
using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class Assessment : EntityBase
    {
        public int AssessmentVersionId { get; set; }
        public AssessmentVersion AssessmentVersion { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual ICollection<AssessmentBlock> AssessmentBlocks { get; set; }
        public virtual ICollection<AssessmentParticipant> AssessmentParticipants { get; set; }
    }
}