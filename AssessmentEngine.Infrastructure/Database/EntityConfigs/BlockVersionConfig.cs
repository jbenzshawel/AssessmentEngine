using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    public class BlockVersionConfig : EntityConfigBase<BlockVersion>
    {
        public override void Configure(EntityTypeBuilder<BlockVersion> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x => x.AssessmentVersion)
                .WithMany(x => x.BlockVersions)
                .HasForeignKey(x => x.AssessmentVersionId);
        }
    }
}