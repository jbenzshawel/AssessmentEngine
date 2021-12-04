using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class TaskVersionGroup : EntityBase
    {
        public int AssessmentTypeId { get; set; }
        public virtual AssessmentType AssessmentType { get; set; }
        public string TaskVersionName { get; set; }
        
        public virtual ICollection<TaskVersionGroupBlock> TaskVersionGroupBlocks { get; set; }
    }
}