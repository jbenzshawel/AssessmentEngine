using System;
using System.Collections.Generic;

namespace AssessmentEngine.Core.DTO
{
    public class AssessmentVersionDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string VersionName { get; set; }
        public int AssessmentTypeId { get; set; }
        public LookupTypeDTO AssessmentType { get; set; }
        public virtual IEnumerable<BlockVersionDTO> BlockVersions { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool AllowDelete { get; set; }
    }
}