using System.Threading;
using System.Threading.Tasks;
using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> Users { get; set; }
        DbSet<ApplicationUserLogin> UserLogins { get; set; }
        DbSet<ApplicationUserAudit> ApplicationUserAudits { get; set; }
        DbSet<ApplicationUserAuditType> ApplicationUserAuditTypes { get; set; }
        DbSet<Assessment> Assessments { get; set; }
        DbSet<AssessmentBlock> AssessmentBlocks { get; set; }
        DbSet<AssessmentParticipant> AssessmentParticipants { get; set; }
        DbSet<AssessmentVersion> AssessmentVersions { get; set; }
        DbSet<AssessmentType> AssessmentTypes { get; set; }
        DbSet<BlockType> BlockTypes { get; set; }
        DbSet<BlockVersion> BlockVersions { get; set; }
        DbSet<ParticipantType> ParticipantTypes { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}