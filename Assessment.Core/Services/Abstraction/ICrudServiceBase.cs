using System.Threading.Tasks;
using Assessment.Domain;

namespace Assessment.Core.Services.Abstraction
{
    public interface ICrudServiceBase
    {
        void DeleteEntity<TEntity>(TEntity entity);
        void SaveEntity<TEntity>(TEntity entity) where TEntity : EntityBase;
        void CreateEntity<TEntity>(TEntity entity, bool saveChanges = true) where TEntity : EntityBase;
        void UpdateEntity<TEntity>(TEntity entity);
        void SaveChanges();
        Task SaveChangesAsync();
        void SaveChanges(bool acceptAllChanges);
        Task SaveChangesAsync(bool acceptAllChanges);
    }
}