using Assessment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assessment.Infrastructure.EntityConfigs
{
    public class EntityConfigBase<TEntityBase> : IEntityTypeConfiguration<TEntityBase> where TEntityBase : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TEntityBase> builder)
        {
            var entityName = typeof(TEntityBase).Name;

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName($"{entityName}Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Uid)
                .HasColumnName($"{entityName}Uid")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate)
                .ValueGeneratedOnAdd();
        }
    }
}
