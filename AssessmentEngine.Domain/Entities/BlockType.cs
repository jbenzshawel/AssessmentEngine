using System.Collections.Generic;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class BlockType : LookupEntityBase
    { 
        public ICollection<AssessmentBlock> AssessmentBlocks { get; set; }
        public ICollection<AssessmentTypeBlockType> AssessmentTypeBlockTypes { get; set; }
        public ICollection<TaskVersionGroupBlock> TaskVersionGroupBlocks { get; set; }
    }
}