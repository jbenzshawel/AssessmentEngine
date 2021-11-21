using System;
using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentVersion : EntityBase
    {
        public string VersionName { get; set; }
        public int AssessmentTypeId { get; set; }
        public AssessmentType AssessmentType { get; set; }
        public int? ImageViewingTime { get; set; }
        public int? CognitiveLoadViewingTime { get; set; }
        public int? FixationCrossViewingTime { get; set; }
        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<BlockVersion> BlockVersions { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}