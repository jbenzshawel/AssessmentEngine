using System;

namespace AssessmentEngine.Domain.Application
{
    public class Assessment : EntityBase
    {
        public int AssessmentTypeId { get; set; }
        public AssessmentType AssessmentType { get; set; }
        public Guid AssessmentUserUID { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}