using AssessmentEngine.Domain.Abstraction;

namespace AssessmentEngine.Domain.Entities
{
    public class TaskVersionGroupBlock : EntityBase
    {
        public int TaskVersionGroupId { get; set; }
        public virtual TaskVersionGroup TaskVersionGroup { get; set; }
        public int BlockTypeId { get; set; }
        public virtual BlockType BlockType { get; set; }
        public int SortOrder { get; set; }
    }
}