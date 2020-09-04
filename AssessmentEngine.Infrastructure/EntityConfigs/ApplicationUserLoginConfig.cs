using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationUserLoginConfig : IEntityTypeConfiguration<ApplicationUserLogin>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserLogin> builder)
        {
            builder.ToTable("ApplicationUserLogins");
        }
    }
}