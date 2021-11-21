namespace AssessmentEngine.Domain.Entities
{
    public class AssessmentTypeBlockType
    {
        public int AssessmentTypeId { get; set; }
        public virtual AssessmentType AssessmentType { get; set; }
        public int BlockTypeId { get; set; }
        public virtual BlockType BlockType { get; set; }
        public int SortOrder { get; set; }
    }
}