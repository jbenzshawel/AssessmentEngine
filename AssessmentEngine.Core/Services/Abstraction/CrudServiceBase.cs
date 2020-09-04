using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Domain;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public abstract class CrudServiceBase<TDbContext> : ICrudServiceBase where TDbContext : DbContext
    {
        protected readonly TDbContext DbContext;
        protected readonly IMapperAdapter Mapper;

        protected CrudServiceBase(TDbContext dbContext, IMapperAdapter mapper) 
        {
            DbContext = dbContext;
            Mapper = mapper;
        }
        
        public virtual void DeleteEntity<TEntity>(TEntity entity)
            => DbContext.Entry(entity).State = EntityState.Deleted;
        
        public virtual void CreateEntity<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            if (entity.Uid == default)
                entity.Uid = Guid.NewGuid();

            DbContext.Entry(entity).State = EntityState.Added;
        }

        public virtual void UpdateEntity<TEntity>(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual async Task SaveEntityAsync<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            if (entity.Id == 0)
                CreateEntity(entity);
            else
                UpdateEntity(entity);

            await SaveChangesAsync();
        }
        public virtual void SaveChanges() => DbContext.SaveChanges();
        public virtual async Task SaveChangesAsync() => await DbContext.SaveChangesAsync();
        public virtual void SaveChanges(bool acceptAllChanges) => DbContext.SaveChanges(acceptAllChanges);
        public virtual async Task SaveChangesAsync(bool acceptAllChanges) => await DbContext.SaveChangesAsync(acceptAllChanges);
    }
}