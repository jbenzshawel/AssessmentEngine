using System;

namespace AssessmentEngine.Core.DTO.Identity
{
    public class User
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}