using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs.Application
{
    public class AssessmentConfig : EntityConfigBase<Assessment>
    {
        public override void Configure(EntityTypeBuilder<Assessment> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.AssessmentType)
                .WithMany(x => x.Assessments)
                .HasForeignKey(x => x.AssessmentTypeId);
        }
    }
}