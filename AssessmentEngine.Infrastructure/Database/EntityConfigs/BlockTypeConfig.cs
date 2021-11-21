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
            
            SetLookupData<BlockTypes>(builder);
        }
    }
}