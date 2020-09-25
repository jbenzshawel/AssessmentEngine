namespace AssessmentEngine.Domain.Entities
{
    public class BlockVersion : EntityBase
    {
        public bool CognitiveLoad { get; set; }
        public string Series { get; set; }
        public int BlockTypeId { get; set; }
        public BlockType BlockType { get; set; }
        public int SortOrder { get; set; }
    }
}