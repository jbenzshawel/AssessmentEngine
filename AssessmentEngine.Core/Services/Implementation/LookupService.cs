using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class LookupService : CrudServiceBase<ApplicationDbContext>, ILookupService
    {
        private readonly IMemoryCache _cache;
        
        public LookupService(ApplicationDbContext dbContext, IMapperAdapter mapper, IMemoryCache cache) : base(dbContext, mapper)
        {
            _cache = cache;
        }

        public async Task<IEnumerable<LookupTypeDTO>> AssessmentTypes()
            => await GetLookup<AssessmentType>();

        public async Task<IEnumerable<LookupTypeDTO>> BlockTypes()
            => await GetLookup<BlockType>();

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

        private async Task<List<LookupTypeDTO>> GetLookupEntity<TLookupType>() where TLookupType : LookupEntityBase 
            => (await DbContext.Set<TLookupType>()
                .OrderBy(x => x.SortOrder)
                .ToListAsync())
                .Select(x => Mapper.Map<TLookupType, LookupTypeDTO>(x))
                .ToList();
    }
}