using Assessment.Domain.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.EntityConfigs.Application
{
    public class AssessmentConfig : EntityConfigBase<Domain.Application.Assessment>
    {
        public override void Configure(EntityTypeBuilder<Domain.Application.Assessment> builder)
        {
            base.Configure(builder);

            builder.HasOne<AssessmentType>(x => x.AssessmentType)
                .WithMany(x => x.Assessments)
                .HasForeignKey(x => x.AssessmentTypeId);
        }
    }
}