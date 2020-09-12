using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class BlockVersionConfig : EntityConfigBase<BlockVersion>
    {
        public override void Configure(EntityTypeBuilder<BlockVersion> builder)
        {
            base.Configure(builder);
        }
    }
}