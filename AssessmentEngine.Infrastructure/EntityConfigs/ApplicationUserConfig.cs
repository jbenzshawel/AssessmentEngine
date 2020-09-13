using System;
using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUsers");

            // Each User can have many UserClaims
            builder.HasMany(e => e.Claims)
                .WithOne(e => e.User)
                .HasForeignKey(uc => uc.UserId)
                .IsRequired();

            // Each User can have many UserLogins
            builder.HasMany(e => e.Logins)
                .WithOne(e => e.User)
                .HasForeignKey(ul => ul.UserId)
                .IsRequired();

            // Each User can have many UserTokens
            builder.HasMany(e => e.Tokens)
                .WithOne(e => e.User)
                .HasForeignKey(ut => ut.UserId)
                .IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            builder.HasOne(e => e.ParticipantType)
                .WithMany(e => e.ApplicationUsers)
                .HasForeignKey(x => x.ParticipantTypeId);
            
            builder.HasData(
                new ApplicationUser
                {
                    Id = Guid.Parse("61479990-B62A-40E4-8973-F6D6EB1AB9B8"),
                    UserName = "admin@assessment.com",
                    NormalizedUserName = "ADMIN@ASSESSMENT.COM",
                    Email = "admin@assessment.com",
                    NormalizedEmail = "ADMIN@ASSESSMENT.COM",
                    PasswordHash =
                        "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", // Test123#
                    SecurityStamp = "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF",
                    ConcurrencyStamp = "66046443-f6a0-4c4a-beed-902dc49f1903",
                    LockoutEnabled = false,
                });
        }
    }
}