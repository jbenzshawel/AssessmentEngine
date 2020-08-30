using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs.Identity
{
    public class ApplicationRoleConfig : IEntityTypeConfiguration<ApplicationRole>

    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.ToTable("ApplicationRoles");

            // Each Role can have many entries in the UserRole join table
            builder.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany(e => e.RoleClaims)
                .WithOne(e => e.Role)
                .HasForeignKey(rc => rc.RoleId)
                .IsRequired();

            SetLookupData(builder);
        }
        
        private static void SetLookupData(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder .HasData(
                new ApplicationRole
                {
                    Id = ApplicationRoleIds.Administrator,
                    Name = ApplicationRoles.Administrator,
                    NormalizedName = ApplicationRoles.Administrator.ToUpper()
                },
                new ApplicationRole
                {
                    Id = ApplicationRoleIds.Participant,
                    Name = ApplicationRoles.Participant,
                    NormalizedName = ApplicationRoles.Participant.ToUpper()
                });
        }
    }
}