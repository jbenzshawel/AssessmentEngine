namespace AssessmentEngine.Core.Common
{
    public class EFTSettings
    {
        public const string EFT = "EFT";
        public int SeriesSize { get; set; }
        public int ImageViewTimeSeconds { get; set; }
        public int CognitiveLoadViewTimeSeconds { get; set; }
        public int BlankScreenViewTimeSeconds { get; set; }
    }
}