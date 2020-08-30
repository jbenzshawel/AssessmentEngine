using AssessmentEngine.Domain.Application;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs.Application
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