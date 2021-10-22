using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
{
    public class ParticipantTypeConfig : LookupEntityConfigBase<ParticipantType>
    {
        public override void Configure(EntityTypeBuilder<ParticipantType> builder)
        {
            base.Configure(builder);
            
            SetLookupData<ParticipantTypes>(builder);
        }
    }
}