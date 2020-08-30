using System;
using Assessment.Domain.Application;
using Assessment.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.EntityConfigs.Application
{
    internal class AssessmentTypeConfig : EntityConfigBase<AssessmentType>
    {
        public override void Configure(EntityTypeBuilder<AssessmentType> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();

            SetLookupData(builder);
        }

        private static void SetLookupData(EntityTypeBuilder<AssessmentType> builder)
        {
            builder.HasData(
                new AssessmentType
                {
                    Id = (int) AssessmentTypes.DualNBack,
                    Uid = Guid.NewGuid(),
                    Name = nameof(AssessmentTypes.DualNBack),
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new AssessmentType
                {
                    Id = (int) AssessmentTypes.EFT,
                    Uid = Guid.NewGuid(),
                    Name = nameof(AssessmentTypes.EFT),
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                });
        }
    }
}