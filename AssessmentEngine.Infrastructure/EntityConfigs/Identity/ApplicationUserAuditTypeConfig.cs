using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Domain.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs.Identity
{
    public class ApplicationUserAuditTypeConfig : LookupEntityConfigBase<ApplicationUserAuditType>
    {
        public override void Configure(EntityTypeBuilder<ApplicationUserAuditType> builder)
        {
            base.Configure(builder);

            SetLookupData<ApplicationUserAuditTypes>(builder);
        }
    }
}