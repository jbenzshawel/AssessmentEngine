using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class BlockType : LookupEntityBase
    {
        public int AssessmentTypeId { get; set; }
        
        public virtual AssessmentType AssessmentType { get; set; }
        public ICollection<AssessmentBlock> AssessmentBlocks { get; set; }
    }
}