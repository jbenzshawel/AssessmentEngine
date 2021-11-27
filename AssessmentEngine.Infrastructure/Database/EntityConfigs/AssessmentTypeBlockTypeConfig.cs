using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    internal class AssessmentTypeBlockTypeConfig :  IEntityTypeConfiguration<AssessmentTypeBlockType>
    {
        public void Configure(EntityTypeBuilder<AssessmentTypeBlockType> builder)
        {
            builder.HasOne(x => x.AssessmentType)
                .WithMany(x => x.AssessmentTypeBlockTypes)
                .HasForeignKey(x => x.AssessmentTypeId);

            builder.HasOne(x => x.BlockType)
                .WithMany(x => x.AssessmentTypeBlockTypes)
                .HasForeignKey(x => x.BlockTypeId);

            builder.HasKey(x => new { x.AssessmentTypeId, x.BlockTypeId });
            
            builder.HasData(new[]
            {
                // EFT
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EP1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 1,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EP2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 2,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EN1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 3,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EN2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 4,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SP1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 5,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SP2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 6,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SN1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 7,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SN2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 8,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VP1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 9,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VP2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 10,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VN1,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 11,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VN2,
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 12,
                },
                // VetFlexIII
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 1,

                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 2,

                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 3,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 4,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 5,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexIII,
                    SortOrder = 6,
                },
                // VetFlexII
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 1,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EP2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 2,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 3,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.EN2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 4,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 5,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SP2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 6,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 7,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.SN2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 8,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VP1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 9,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VP2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 10,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VN1,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 11,
                },
                new AssessmentTypeBlockType
                {
                    BlockTypeId = (int)BlockTypes.VN2,
                    AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                    SortOrder = 12,
                },
            });
        }
    }
}