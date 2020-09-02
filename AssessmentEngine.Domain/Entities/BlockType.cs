using System.Collections.Generic;

namespace AssessmentEngine.Domain.Entities
{
    public class BlockType : LookupEntityBase
    {
        public ICollection<AssessmentBlock> AssessmentBlocks { get; set; }
    }
}