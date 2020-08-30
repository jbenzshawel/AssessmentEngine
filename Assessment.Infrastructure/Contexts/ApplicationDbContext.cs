using Assessment.Domain.Application;
using Assessment.Infrastructure.EntityConfigs.Application;
using Assessment.Infrastructure.EntityConfigs.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Contexts
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Domain.Application.Assessment> Assessments { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ConfigureIdentityContext(builder);
            ConfigureAssessmentContext(builder);
        }

        private static void ConfigureIdentityContext(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IdentityRoleConfig());
        }
        
        private static void ConfigureAssessmentContext(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AssessmentTypeConfig());
            builder.ApplyConfiguration(new AssessmentConfig());
        }
    }
}