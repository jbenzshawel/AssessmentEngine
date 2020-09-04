using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class AssessmentBlockConfig : EntityConfigBase<AssessmentBlock>
    {
        public override void Configure(EntityTypeBuilder<AssessmentBlock> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Assessment)
                .WithMany(x => x.AssessmentBlocks)
                .HasForeignKey(x => x.BlockTypeId);
            
            builder.HasOne(x => x.BlockType)
                .WithMany(x => x.AssessmentBlocks)
                .HasForeignKey(x => x.BlockTypeId);
        }
    }
}