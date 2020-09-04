using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationUserClaimConfig : IEntityTypeConfiguration<ApplicationUserClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
        {
            builder.ToTable("ApplicationUserClaims");
        }
    }
}