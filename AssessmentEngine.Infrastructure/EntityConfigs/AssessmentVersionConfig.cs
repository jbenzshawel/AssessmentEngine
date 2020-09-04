using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class AssessmentVersionConfig : EntityConfigBase<AssessmentVersion>
    {
        public override void Configure(EntityTypeBuilder<AssessmentVersion> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x => x.AssessmentType)
                .WithMany(x => x.AssessmentVersions)
                .HasForeignKey(x => x.AssessmentTypeId);

        }
    }
}