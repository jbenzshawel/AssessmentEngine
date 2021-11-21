using System;

namespace AssessmentEngine.Domain.Abstraction
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
