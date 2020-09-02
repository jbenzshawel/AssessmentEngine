using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs.Identity
{
    public class ApplicationUserAuditConfig : EntityConfigBase<ApplicationUserAudit>
    {
        public override void Configure(EntityTypeBuilder<ApplicationUserAudit> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.ApplicationUser)
                .WithMany(x => x.ApplicationUserAudits)
                .HasForeignKey(x => x.ApplicationUserId);
            
            builder.HasOne(x => x.ApplicationUserAuditType)
                .WithMany(x => x.ApplicationUserAudits)
                .HasForeignKey(x => x.ApplicationUserAuditTypeId);
        }
    }
}