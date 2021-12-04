using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    public class TaskVersionGroupConfig : EntityConfigBase<TaskVersionGroup>
    {
        public override void Configure(EntityTypeBuilder<TaskVersionGroup> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.AssessmentType)
                .WithMany(x => x.TaskVersionGroups)
                .HasForeignKey(x => x.AssessmentTypeId);
            
            builder.Property(x => x.TaskVersionName)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}