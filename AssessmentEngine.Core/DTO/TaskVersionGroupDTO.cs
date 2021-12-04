using System;
using System.Collections.Generic;

namespace AssessmentEngine.Core.DTO
{
    public class TaskVersionGroupDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public int AssessmentTypeId { get; set; }
        public LookupTypeDTO AssessmentType { get; set; }
        public string TaskVersionName { get; set; }
        public virtual IEnumerable<TaskVersionGroupBlockDTO> TaskVersionGroupBlocks { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}