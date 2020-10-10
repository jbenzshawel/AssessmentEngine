using System;

namespace AssessmentEngine.Domain.Entities
{
    public class BlockVersion : EntityBase
    {
        public int AssessmentVersionId { get; set; }
        public AssessmentVersion AssessmentVersion { get; set; }
        public bool CognitiveLoad { get; set; }
        public string Series { get; set; }
        public int BlockTypeId { get; set; }
        public BlockType BlockType { get; set; }
        public string SeriesRecall { get; set; }
        public string EmotionalRating { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int SortOrder { get; set; }
    }
}