using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    internal class BlockTypeConfig : LookupEntityConfigBase<BlockType>
    {
        public override void Configure(EntityTypeBuilder<BlockType> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x => x.AssessmentType)
                .WithMany(x => x.BlockTypes)
                .HasForeignKey(x => x.AssessmentTypeId);

            builder.HasData(new[]
            {
                new BlockType
                {
                    Id = (int)BlockTypes.EP1,
                    Name = BlockTypes.EP1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 1,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.EP2,
                    Name = BlockTypes.EP2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 2,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.EN1,
                    Name = BlockTypes.EN1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 3,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.EN2,
                    Name = BlockTypes.EN2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 4,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.SP1,
                    Name = BlockTypes.SP1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 5,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.SP2,
                    Name = BlockTypes.SP2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 6,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.SN1,
                    Name = BlockTypes.SN1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 7,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.SN2,
                    Name = BlockTypes.SN2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 8,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.VP1,
                    Name = BlockTypes.VP1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 9,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.VP2,
                    Name = BlockTypes.VP2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 10,
                    CreatedBy = "SYSTEM"
                },
                new BlockType
                {
                    Id = (int)BlockTypes.VN1,
                    Name = BlockTypes.VN1.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 11,
                    CreatedBy = "SYSTEM"
                },
                
                new BlockType
                {
                    Id = (int)BlockTypes.VN2,
                    Name = BlockTypes.VN2.ToString(),
                    AssessmentTypeId = (int)AssessmentTypes.EFT,
                    SortOrder = 12,
                    CreatedBy = "SYSTEM"
                },
            });
        }
    }
}