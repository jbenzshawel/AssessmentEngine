using Assessment.Domain.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.EntityConfigs.Identity
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder .HasData(
                new IdentityRole
                {
                    Id = ApplicationRoleIds.Administrator.ToString(),
                    Name = ApplicationRoles.Administrator,
                    NormalizedName = ApplicationRoles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = ApplicationRoleIds.Participant.ToString(),
                    Name = ApplicationRoles.Participant,
                    NormalizedName = ApplicationRoles.Participant.ToUpper()
                });
        }
    }
}