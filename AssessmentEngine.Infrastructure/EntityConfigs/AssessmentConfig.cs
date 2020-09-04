using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class AssessmentConfig : EntityConfigBase<Assessment>
    {
        public override void Configure(EntityTypeBuilder<Assessment> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x => x.AssessmentVersion)
                .WithMany(x => x.Assessments)
                .HasForeignKey(x => x.AssessmentVersionId);
        }
    }
}