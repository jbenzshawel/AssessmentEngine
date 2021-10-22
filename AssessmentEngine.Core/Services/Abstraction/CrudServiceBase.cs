using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Domain;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public abstract class CrudServiceBase<TDbContext> : ICrudServiceBase where TDbContext : IApplicationDbContext
    {
        protected readonly TDbContext DbContext;
        protected readonly IMapperAdapter Mapper;

        protected CrudServiceBase(TDbContext dbContext, IMapperAdapter mapper) 
        {
            DbContext = dbContext;
            Mapper = mapper;
        }
        
        protected virtual void DeleteEntity<TEntity>(TEntity entity) where TEntity : class
            => DbContext.Entry(entity).State = EntityState.Deleted;
        
        protected virtual void CreateEntity<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            if (entity.Uid == default)
                entity.Uid = Guid.NewGuid();

            DbContext.Entry(entity).State = EntityState.Added;
        }

        protected virtual void UpdateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        protected virtual async Task SaveEntityAsync<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            if (entity.Id == 0)
                CreateEntity(entity);
            else
                UpdateEntity(entity);

            await SaveChangesAsync();
        }
        
        protected virtual void SaveEntity<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            if (entity.Id == 0)
                CreateEntity(entity);
            else
                UpdateEntity(entity);
        }
        
        protected virtual void SaveChanges() => DbContext.SaveChanges();
        protected virtual async Task SaveChangesAsync() => await DbContext.SaveChangesAsync();
        protected virtual void SaveChanges(bool acceptAllChanges) => DbContext.SaveChanges(acceptAllChanges);
        protected virtual async Task SaveChangesAsync(bool acceptAllChanges) => await DbContext.SaveChangesAsync(acceptAllChanges);
    }
}