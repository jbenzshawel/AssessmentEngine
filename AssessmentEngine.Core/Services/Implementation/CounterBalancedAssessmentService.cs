using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.Abstraction;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Abstraction;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class CounterBalancedAssessmentService : CrudServiceBase<IApplicationDbContext>, ICounterBalancedAssessmentService
    {
        private readonly IBlockVersionGenerator _blockVersionGenerator;
        private readonly IAssessmentService _assessmentService;

        public CounterBalancedAssessmentService(
            IApplicationDbContext dbContext, 
            IMapperAdapter mapper, 
            IBlockVersionGenerator blockVersionGenerator, IAssessmentService assessmentService) : base(dbContext, mapper)
        {
            _blockVersionGenerator = blockVersionGenerator;
            _assessmentService = assessmentService;
        }

        public async Task CreateAssessmentVersion(AssessmentVersionDTO dto)
        {
            if (dto.CounterBalanceType == CounterBalanceTypes.Unknown)
            {
                throw new ApplicationException(
                    $"{nameof(dto.CounterBalanceType)} must be when creating Counter-Balanced Assessment Version");
            }
            
            var entity = await _assessmentService.BuildAssessmentVersionEntity(dto);

            entity.BlockVersions = await BuildCounterBalanceBlockVersions(dto);

            await _assessmentService.PersistAssessmentVersion(entity, dto);
        }

        private async Task<ICollection<BlockVersion>> BuildCounterBalanceBlockVersions(AssessmentVersionDTO dto)
        {
            var groupBlocks = (await GetById(dto.TaskVersionGroupId))
                .TaskVersionGroupBlocks
                .OrderBy(x => x.SortOrder)
                .ToList();

            if (dto.CounterBalanceType == CounterBalanceTypes.VersionA)
            {
                return groupBlocks.Select(x => new BlockVersion
                {
                    Uid = Guid.NewGuid(),
                    BlockTypeId = x.BlockTypeId,
                    SortOrder = x.SortOrder,
                    Series = null,
                    CognitiveLoad = false
                }).ToList();
            }

            var counterBalanced = groupBlocks.Skip(6).Take(6).ToList();
            counterBalanced.AddRange(groupBlocks.Take(6));
            
            return counterBalanced.Select((entity, i) => new BlockVersion
            {
                Uid = Guid.NewGuid(),
                BlockTypeId = entity.BlockTypeId,
                SortOrder = i + 1,
                Series = null,
                CognitiveLoad = false
            }).ToList();
        }

        public async Task CreateGroup(TaskVersionGroupDTO dto)
        {
            var entity = await MapToTaskVersionGroupEntity(dto);

            await CreateEntityAsync(entity);

            Mapper.Map(entity, dto);
        }

        private async Task CreateEntityAsync(TaskVersionGroup entity)
        {
            SaveEntity(entity);
            await DbContext.TaskVersionGroupBlocks.AddRangeAsync(entity.TaskVersionGroupBlocks);
            await SaveChangesAsync();
        }

        private async Task<TaskVersionGroup> MapToTaskVersionGroupEntity(TaskVersionGroupDTO dto)
        {
            var entity = new TaskVersionGroup
            {
                Id = 0,
                Uid = Guid.NewGuid(),
                TaskVersionName = dto.TaskVersionName,
                AssessmentTypeId = dto.AssessmentTypeId
            };

            var versionGroups = (await _blockVersionGenerator
                    .Generate((AssessmentTypes)dto.AssessmentTypeId))
                .Select(x => new TaskVersionGroupBlock
                {
                    TaskVersionGroupId = entity.Id,
                    Uid = Guid.NewGuid(),
                    TaskVersionGroup = entity,
                    BlockTypeId = x.BlockTypeId,
                    SortOrder = x.SortOrder
                }).ToList();

            entity.TaskVersionGroupBlocks = versionGroups;
            
            return entity;
        }

        public async Task<IEnumerable<TaskVersionGroupDTO>> GetVersionsByAssessmentType(AssessmentTypes assessmentType)
        {
            var assessmentTypeId = (int)assessmentType;

            return (await DbContext.TaskVersionGroups
                    .Include(x => x.TaskVersionGroupBlocks)
                    .AsNoTracking()
                    .Where(x => x.AssessmentTypeId == assessmentTypeId)
                    .ToListAsync())
                .Select(x => Mapper.Map<TaskVersionGroup, TaskVersionGroupDTO>(x));
        }
        
        public async Task<TaskVersionGroupDTO> GetById(int id)
            => (await DbContext.TaskVersionGroups
                    .Include(x => x.TaskVersionGroupBlocks)
                    .AsNoTracking()
                    .Where(x => x.Id == id)
                    .ToListAsync())
                .Select(x => Mapper.Map<TaskVersionGroup, TaskVersionGroupDTO>(x))
                .SingleOrDefault();
    }
}