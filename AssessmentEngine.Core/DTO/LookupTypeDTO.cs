using System;

namespace AssessmentEngine.Core.DTO
{
    public class LookupTypeDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}