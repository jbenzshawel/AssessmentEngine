using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
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