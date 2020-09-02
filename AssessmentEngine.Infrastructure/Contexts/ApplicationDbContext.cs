using System;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Infrastructure.EntityConfigs.Application;
using AssessmentEngine.Infrastructure.EntityConfigs.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Infrastructure.Contexts
{
    public class ApplicationDbContext : 
        IdentityDbContext<ApplicationUser, ApplicationRole, Guid,
            ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
            ApplicationRoleClaim, ApplicationUserToken>
    {
        public DbSet<ApplicationUserAudit> ApplicationUserAudits { get; set; }
        public DbSet<ApplicationUserAuditType> ApplicationUserAuditTypes { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentBlock> AssessmentBlocks { get; set; }
        public DbSet<AssessmentParticipant> AssessmentParticipants { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        public DbSet<BlockType> BlockTypes { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ConfigureIdentity(builder);
            ConfigureAssessments(builder);
        }

        private static void ConfigureIdentity(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new ApplicationRoleConfig());
            builder.ApplyConfiguration(new ApplicationUserClaimConfig());
            builder.ApplyConfiguration(new ApplicationUserRoleConfig());
            builder.ApplyConfiguration(new ApplicationUserLoginConfig());
            builder.ApplyConfiguration(new ApplicationRoleClaimConfig());
            builder.ApplyConfiguration(new ApplicationUserTokenConfig());
            builder.ApplyConfiguration(new ApplicationUserAuditTypeConfig());
        }
        
        private static void ConfigureAssessments(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AssessmentBlockConfig());
            builder.ApplyConfiguration(new AssessmentConfig());
            builder.ApplyConfiguration(new AssessmentParticipantConfig());
            builder.ApplyConfiguration(new AssessmentTypeConfig());
            builder.ApplyConfiguration(new BlockTypeConfig());
        }
    }
}