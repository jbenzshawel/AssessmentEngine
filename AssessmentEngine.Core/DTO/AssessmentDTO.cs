using System;
using System.Collections.Generic;
using AssessmentEngine.Core.Services.Implementation;
using AssessmentEngine.Domain.Entities;

namespace AssessmentEngine.Core.DTO
{
    public class AssessmentDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public int AssessmentVersionId { get; set; }
        public virtual LookupTypeDTO AssessmentBlocks { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}