using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.Abstraction;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class LookupService : CrudServiceBase<IApplicationDbContext>, ILookupService
    {
        private readonly ICacheProvider _cache;
        
        public LookupService(IApplicationDbContext dbContext, IMapperAdapter mapper, ICacheProvider cache) : base(dbContext, mapper)
        {
            _cache = cache;
        }

        public async Task<IEnumerable<LookupTypeDTO>> AssessmentTypes()
            => await GetLookup<AssessmentType>();

        public async Task<IEnumerable<LookupTypeDTO>> BlockTypes(AssessmentTypes assessmentType)
        {
            var assessmentTypeId = (int)assessmentType;
            return await DbContext.AssessmentTypeBlockTypes
                    .Include(x => x.BlockType)
                    .AsNoTracking()
                    .Where(x => x.AssessmentTypeId == assessmentTypeId)
                    .Select(x => new LookupTypeDTO
                    {
                        Id = x.BlockTypeId,
                        Name = x.BlockType.Name,
                        SortOrder = x.SortOrder
                    })
                    .OrderBy(x => x.SortOrder)
                    .ToListAsync();
        }

        public async Task<IEnumerable<LookupTypeDTO>> ParticipantTypes()
            => await GetLookup<ParticipantType>();
        
        private async Task<IEnumerable<LookupTypeDTO>> GetLookup<TLookupType>() where TLookupType : LookupEntityBase
        {
            var cacheKey = typeof(TLookupType).FullName;

            if (_cache.TryGetValue(cacheKey, out IEnumerable<LookupTypeDTO> cacheEntry))
                return cacheEntry;

            var lookupEntity = await GetLookupEntity<TLookupType>();

            _cache.Set(cacheKey, lookupEntity);

            return lookupEntity;
        }
        
        private async Task<IEnumerable<LookupTypeDTO>> GetCachedLookup<TLookupEntity>() where TLookupEntity : LookupEntityBase
            => await GetCachedLookup<TLookupEntity, LookupTypeDTO>(GetLookupEntity<TLookupEntity>);

        private async Task<IEnumerable<TLookupDTO>> GetCachedLookup<TLookupDTO>(string cacheKey, Func<Task<IEnumerable<TLookupDTO>>> getLookup)
            => await _cache.GetCachedItem(cacheKey, getLookup);

        private async Task<IEnumerable<TLookupDTO>> GetCachedLookup<TLookupEntity, TLookupDTO>(
            Func<Task<List<TLookupDTO>>> getLookup) where TLookupEntity : class
            => await _cache.GetCachedItem(typeof(TLookupEntity).FullName, getLookup);

        private async Task<List<LookupTypeDTO>> GetLookupEntity<TLookupEntity>() where TLookupEntity : LookupEntityBase
            => (await DbContext.Set<TLookupEntity>().AsNoTracking()
                    .ToListAsync())
                .Select(x => new LookupTypeDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    SortOrder = x.SortOrder
                })
                .ToList();
    }
}