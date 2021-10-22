using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    internal class AssessmentTypeConfig : LookupEntityConfigBase<AssessmentType>
    {
        public override void Configure(EntityTypeBuilder<AssessmentType> builder)
        {
            base.Configure(builder);
            
            SetLookupData<AssessmentTypes>(builder);
        }
    }
}