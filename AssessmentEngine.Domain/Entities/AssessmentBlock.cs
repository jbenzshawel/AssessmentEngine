using System;
using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentBlock : EntityBase
    {
        public int AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public int BlockTypeId { get; set; }
        public BlockType BlockType { get; set; }
        public string SeriesRecall { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}