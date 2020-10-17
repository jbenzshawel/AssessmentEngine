using System;

namespace AssessmentEngine.Core.DTO
{
    public class TaskResultDTO
    {
        public string Uid { get; set; }
        public string ParticipantId { get; set; }
        public string BlockType { get; set; }
        public string TaskVersion { get; set; }
        public string EmotionRating { get; set; }
        public bool CognitiveLoad { get; set; }
        public string Series { get; set; }
        public string SeriesRecall { get; set; }
        public DateTime CompletedDateTime { get; set; }
    }
}