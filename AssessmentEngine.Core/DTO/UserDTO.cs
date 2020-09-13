using System;
using System.Collections.Generic;

namespace AssessmentEngine.Core.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string ParticipantId { get; set; }
        public int? ParticipantTypeId { get; set; }
        public LookupTypeDTO ParticipantType { get; set; }
        public bool Enabled { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}