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
    }
}