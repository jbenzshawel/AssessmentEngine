using System;
using AssessmentEngine.Core.Services.Implementation;

namespace AssessmentEngine.Core.DTO
{
    public class BlockVersionDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public bool CognitiveLoad { get; set; }
        public string Series { get; set; }
        public int BlockTypeId { get; set; }
        public LookupTypeDTO BlockType { get; set; }
        public int SortOrder { get; set; }
        public string SeriesRecall { get; set; }
        public string EmotionalRating { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? BlockStartDateTime { get; set; }
        public DateTime? BlockEndDateTime { get; set; }
    }
}