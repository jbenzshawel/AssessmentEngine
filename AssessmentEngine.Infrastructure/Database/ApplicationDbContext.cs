﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AssessmentEngine.Domain.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Infrastructure.Database.EntityConfigs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AssessmentEngine.Infrastructure.Database
{
    public class ApplicationDbContext : 
        IdentityDbContext<ApplicationUser, ApplicationRole, Guid,
            ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
            ApplicationRoleClaim, ApplicationUserToken>, IApplicationDbContext
    {
        public DbSet<ApplicationUserAudit> ApplicationUserAudits { get; set; }
        public DbSet<ApplicationUserAuditType> ApplicationUserAuditTypes { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentBlock> AssessmentBlocks { get; set; }
        public DbSet<AssessmentParticipant> AssessmentParticipants { get; set; }
        public DbSet<AssessmentVersion> AssessmentVersions { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        public DbSet<AssessmentTypeBlockType> AssessmentTypeBlockTypes { get; set; }
        public DbSet<BlockType> BlockTypes { get; set; }
        public DbSet<BlockVersion> BlockVersions { get; set; }
        public DbSet<TaskVersionGroup> TaskVersionGroups { get; set; }
        public DbSet<TaskVersionGroupBlock> TaskVersionGroupBlocks { get; set; }
        public DbSet<ParticipantType> ParticipantTypes { get; set; }
        
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
            builder.ApplyConfiguration(new ApplicationRoleConfig());
            builder.ApplyConfiguration(new ApplicationRoleClaimConfig());
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new ApplicationUserAuditConfig());
            builder.ApplyConfiguration(new ApplicationUserAuditTypeConfig());
            builder.ApplyConfiguration(new ApplicationUserClaimConfig());
            builder.ApplyConfiguration(new ApplicationUserRoleConfig());
            builder.ApplyConfiguration(new ApplicationUserLoginConfig());
            builder.ApplyConfiguration(new ApplicationUserTokenConfig());

        }
        
        private static void ConfigureAssessments(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AssessmentBlockConfig());
            builder.ApplyConfiguration(new AssessmentConfig());
            builder.ApplyConfiguration(new AssessmentParticipantConfig());
            builder.ApplyConfiguration(new AssessmentVersionConfig());
            builder.ApplyConfiguration(new AssessmentTypeConfig());
            builder.ApplyConfiguration(new AssessmentTypeBlockTypeConfig());
            builder.ApplyConfiguration(new BlockTypeConfig());
            builder.ApplyConfiguration(new BlockVersionConfig());
            builder.ApplyConfiguration(new ParticipantTypeConfig());
            builder.ApplyConfiguration(new TaskVersionGroupConfig());
            builder.ApplyConfiguration(new TaskVersionGroupBlockConfig());
        }
        
        public override int SaveChanges()
        {
            SetAuditData();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditData();

            return base.SaveChangesAsync(cancellationToken);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SetAuditData();

            return await base.SaveChangesAsync(true, cancellationToken);
        }

        private void SetAuditData()
        {
            var changeSet = ChangeTracker.Entries<EntityBase>();

            if (changeSet == null)
                return;

            foreach (var entry in changeSet)
                SetEntryAuditData(entry);
            
        }

        private static void SetEntryAuditData(EntityEntry<EntityBase> entry)
        {
            if (entry.Entity.Id == 0)
                entry.Entity.CreatedDate = DateTime.Now;

            entry.Entity.UpdateDate = DateTime.Now;
        }
    }
}