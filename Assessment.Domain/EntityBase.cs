using System;

namespace Assessment.Domain
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual Guid Uid { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
    }
}
