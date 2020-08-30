namespace AssessmentEngine.Domain.Enums
{
    public enum ApplicationUserAuditTypes
    {
        Unknown = 0,
        Login,
        Logout,
        Lockout,
        PasswordReset
    }
}