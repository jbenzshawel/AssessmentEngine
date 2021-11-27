using System;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.Database.EntityConfigs
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
                    NormalizedName = ApplicationRoles.Administrator.ToUpper(),
                    ConcurrencyStamp = "0c04b308-160b-4bfa-8ac7-431ff3ec1675",
                },
                new ApplicationRole
                {
                    Id = ApplicationRoleIds.Participant,
                    Name = ApplicationRoles.Participant,
                    NormalizedName = ApplicationRoles.Participant.ToUpper(),
                    ConcurrencyStamp = "8fd51b8e-fdf3-4250-8bfb-59f42aefd6b8"
                });
        }
    }
}