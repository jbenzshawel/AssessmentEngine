
namespace AssessmentEngine.Domain.Abstraction
{
    public abstract class LookupEntityBase 
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}