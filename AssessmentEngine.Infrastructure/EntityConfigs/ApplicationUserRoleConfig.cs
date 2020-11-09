using System;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class ApplicationUserRoleConfig : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.ToTable("ApplicationUserRoles");

            builder.HasData(new ApplicationUserRole
            {
                RoleId = ApplicationRoleIds.Administrator,
                UserId = Guid.Parse("61479990-B62A-40E4-8973-F6D6EB1AB9B8")
            },
            new ApplicationUserRole
            {
                RoleId = ApplicationRoleIds.Administrator,
                UserId = Guid.Parse("b4c0ddd2-86e7-4193-9da2-9950abdb909c")
            });
        }
    }
}