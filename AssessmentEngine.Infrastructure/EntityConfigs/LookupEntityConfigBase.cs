using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AssessmentEngine.Domain;

namespace AssessmentEngine.Infrastructure.EntityConfigs
{
    public class LookupEntityConfigBase<TEntityBase> : EntityConfigBase<TEntityBase> where TEntityBase : LookupEntityBase, new()
    {
        public override void Configure(EntityTypeBuilder<TEntityBase> builder)
        {
            base.Configure(builder);
            
            builder.Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();
        }
        
        protected void SetLookupData<TEnum>(EntityTypeBuilder<TEntityBase> builder) where TEnum : System.Enum
        {
            var lookups = Enum.GetValues(typeof(TEnum)).Cast<object>()
                .Where(enumVal => enumVal != null && (int)enumVal != 0)
                .Select(enumVal => new TEntityBase
                {
                    Id = (int)enumVal,
                    Uid = Guid.NewGuid(),
                    Name = ((TEnum)enumVal).ToString(),
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                }).ToList();

            builder.HasData(lookups);
        }
    }
}