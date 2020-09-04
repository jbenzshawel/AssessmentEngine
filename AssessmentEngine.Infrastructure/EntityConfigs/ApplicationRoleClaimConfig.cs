using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationRoleClaimConfig : IEntityTypeConfiguration<ApplicationRoleClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
        {
            builder.ToTable("ApplicationRoleClaims");
        }
    }
}