using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationUserTokenConfig : IEntityTypeConfiguration<ApplicationUserToken>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
        {
            builder.ToTable("ApplicationUserTokens");
        }
    }
}