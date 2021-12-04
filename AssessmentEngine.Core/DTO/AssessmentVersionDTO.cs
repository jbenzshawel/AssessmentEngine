using System;
using System.Collections.Generic;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.DTO
{
    public class AssessmentVersionDTO
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string VersionName { get; set; }
        public Guid? ParticipantUid { get; set; }
        public string ParticipantId { get; set; }
        public int AssessmentTypeId { get; set; }
        public LookupTypeDTO AssessmentType { get; set; }
        public virtual IEnumerable<BlockVersionDTO> BlockVersions { get; set; }
        public int TaskVersionGroupId { get; set; }
        public CounterBalanceTypes CounterBalanceType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public BlockVersionDTO CurrentBlockVersion { get; set; }
        public BlockVersionDTO NextBlockVersion { get; set; }
        public string ParticipantUrl { get; set; }
        public bool AllowEdit { get; set; }
        public bool IsCompleted { get; set; }
    }
}