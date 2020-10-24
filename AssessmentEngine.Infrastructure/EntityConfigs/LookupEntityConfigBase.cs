using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AssessmentEngine.Domain;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class LookupEntityConfigBase<TEntityBase> :  IEntityTypeConfiguration<TEntityBase> where TEntityBase : LookupEntityBase, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntityBase> builder)
        {
            var entityName = typeof(TEntityBase).Name;

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName($"{entityName}Id")
                .ValueGeneratedOnAdd();
            
            builder.Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();
        }
        
        protected void SetLookupData<TEnum>(EntityTypeBuilder<TEntityBase> builder) where TEnum : System.Enum
        {
            var lookups = LookupEntity.LookupValues<TEnum>()
                .Select((enumVal, index) => new TEntityBase
                {
                    Id = (int)enumVal,
                    Name = ((TEnum)enumVal).ToString(),
                    SortOrder = index + 1
                }).ToList();

            builder.HasData(lookups);
        }
    }

    public static class LookupEntity
    {
        public static IEnumerable<object> LookupValues<TEnum>() where TEnum : System.Enum
        {
            return Enum.GetValues(typeof(TEnum)).Cast<object>()
                .Where(enumVal => enumVal != null && (int)enumVal != 0);
        }
    }
}