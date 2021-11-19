using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentType : LookupEntityBase
    {
        public ICollection<AssessmentVersion> AssessmentVersions { get; set; }
        public ICollection<BlockType> BlockTypes { get; set; }
    }
}