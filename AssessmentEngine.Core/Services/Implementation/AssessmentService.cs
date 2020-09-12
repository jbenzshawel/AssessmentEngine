using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using AssessmentEngine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class AssessmentService : CrudServiceBase<ApplicationDbContext>, IAssessmentService
    {
        public AssessmentService(ApplicationDbContext dbContext, IMapperAdapter mapper) : base(dbContext, mapper)
        {
        }

        public string GetRandomSeries()
        {
            var stringBuilder = new StringBuilder();

            // todo: pull from config
            for (var i = 1; i <= 7; i++)
            {
                stringBuilder.Append(new Random().Next(1, 10));
            }

            return stringBuilder.ToString();
        }
        
        public async Task<IEnumerable<AssessmentDTO>> GetAssessments() 
            => (await DbContext.Assessments
                .Include(x => x.AssessmentBlocks).ThenInclude(x => x.BlockType)
                .ToListAsync())
            .Select(x => Mapper.Map<Assessment, AssessmentDTO>(x));

        public async Task SaveAssessment(AssessmentDTO dto)
        {
            var entity = dto.Id == 0
                ? new Assessment()
                : await DbContext.Assessments.SingleAsync(x => x.Id == dto.Id);

            Mapper.Map(dto, entity);
            
            await SaveEntityAsync(entity);

            Mapper.Map(entity, dto);
        }
        
        public async Task<IEnumerable<AssessmentVersionDTO>> GetAssessmentVersions()
            => (await AssessmentVersions()
                    .ToListAsync())
                .Select(x => Mapper.Map <AssessmentVersion, AssessmentVersionDTO>(x));

        private IIncludableQueryable<AssessmentVersion, BlockType> AssessmentVersions() 
            => DbContext.AssessmentVersions
                .Include(x => x.Assessments)
                .Include(x => x.AssessmentType)
                .Include(x => x.BlockVersions).ThenInclude(x => x.BlockType);

        public async Task<AssessmentVersionDTO> GetAssessmentVersion(int id)
            => (await AssessmentVersions()
                    .Where(x => x.Id == id)
                    .ToListAsync())
                .Select(x => Mapper.Map <AssessmentVersion, AssessmentVersionDTO>(x))
                .SingleOrDefault();
        
        public async Task SaveAssessmentVersion(AssessmentVersionDTO dto)
        {
            var entity = dto.Id == 0
                ? new AssessmentVersion()
                : await DbContext.AssessmentVersions.SingleAsync(x => x.Id == dto.Id);

            Mapper.Map(dto, entity);
            
            SaveEntity(entity);
            foreach (var blockVersion in entity.BlockVersions)
                SaveEntity(blockVersion);
            
            await SaveChangesAsync();
            
            Mapper.Map(entity, dto);
        }

        public async Task DeleteAssessmentVersion(int assessmentVersionId)
        {
            var entity = await DbContext.AssessmentVersions
                .Include(x => x.BlockVersions)
                .SingleAsync(x => x.Id == assessmentVersionId);

            DbContext.BlockVersions.RemoveRange(entity.BlockVersions);
            
            DeleteEntity(entity);

            await SaveChangesAsync();
        }
    }
}