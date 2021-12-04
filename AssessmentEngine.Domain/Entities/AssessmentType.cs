using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentType : LookupEntityBase
    {
        public ICollection<AssessmentVersion> AssessmentVersions { get; set; }
        public ICollection<AssessmentTypeBlockType> AssessmentTypeBlockTypes { get; set; }
        public ICollection<TaskVersionGroup> TaskVersionGroups { get; set; }
    }
}