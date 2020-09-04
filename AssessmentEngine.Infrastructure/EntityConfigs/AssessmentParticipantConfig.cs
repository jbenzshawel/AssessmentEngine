using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class AssessmentParticipantConfig : EntityConfigBase<AssessmentParticipant>
    {
        public override void Configure(EntityTypeBuilder<AssessmentParticipant> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Assessment)
                .WithMany(x => x.AssessmentParticipants)
                .HasForeignKey(x => x.AssessmentId);
            
            builder.HasOne(x => x.ApplicationUser)
                .WithMany(x => x.AssessmentParticipants)
                .HasForeignKey(x => x.ApplicationUserId);
        }
    }
}