namespace AssessmentEngine.Domain
{
    public abstract class LookupEntityBase : EntityBase
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}