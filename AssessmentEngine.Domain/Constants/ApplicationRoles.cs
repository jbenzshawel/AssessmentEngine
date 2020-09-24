using System;

namespace AssessmentEngine.Domain.Constants
{
    public static class ApplicationRoles
    {
        public const string Administrator = "Administrator";
        public const string Participant = "Participant";
    }
    
    public static class ApplicationRoleIds
    {
        public static readonly Guid Administrator = Guid.Parse("5d587953-2fb4-4198-9a5d-e64095439783");
        public static readonly Guid Participant = Guid.Parse("d8105d5f-3a2e-428b-8c57-36398b196379");
    }
}