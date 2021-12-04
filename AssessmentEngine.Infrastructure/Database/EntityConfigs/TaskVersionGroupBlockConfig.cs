using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    public class TaskVersionGroupBlockConfig : EntityConfigBase<TaskVersionGroupBlock>
    {
        public override void Configure(EntityTypeBuilder<TaskVersionGroupBlock> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.TaskVersionGroup)
                .WithMany(x => x.TaskVersionGroupBlocks)
                .HasForeignKey(x => x.TaskVersionGroupId);
            
            builder.HasOne(x => x.BlockType)
                .WithMany(x => x.TaskVersionGroupBlocks)
                .HasForeignKey(x => x.BlockTypeId);
        }
    }
}