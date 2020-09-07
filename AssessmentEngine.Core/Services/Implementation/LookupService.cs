using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class LookupService : CrudServiceBase<ApplicationDbContext>, ILookupService
    {
        // TODO: Implement lookup cache
        
        public LookupService(ApplicationDbContext dbContext, IMapperAdapter mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<AssessmentTypeDTO>> AssessmentTypes()
            => (await DbContext.AssessmentTypes
                    .ToListAsync())
                .Select(x => Mapper.Map<AssessmentType, AssessmentTypeDTO>(x));

        public async Task<IEnumerable<BlockTypeDTO>> BlockTypes()
            => (await DbContext.BlockTypes
                    .ToListAsync())
                .Select(x => Mapper.Map<BlockType, BlockTypeDTO>(x));
    }
}