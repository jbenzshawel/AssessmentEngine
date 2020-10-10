using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Extensions;
using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class AssessmentService : CrudServiceBase<ApplicationDbContext>, IAssessmentService
    {
        private readonly ILookupService _lookupService;
        private readonly EFTSettings _eftSettings;
        
        public AssessmentService(
            ApplicationDbContext dbContext, 
            IMapperAdapter mapper,
            IOptions<EFTSettings> eftSettings, 
            ILookupService lookupService) : base(dbContext, mapper)
        {
            _lookupService = lookupService;
            _eftSettings = eftSettings.Value;
        }

        public string GetRandomSeries()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 1; i <= _eftSettings.SeriesSize; i++)
            {
                stringBuilder.Append(new Random().Next(1, 10));
            }

            return stringBuilder.ToString();
        }

        public EFTSettings GetEFTSettings()
            => _eftSettings;

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
                .Select(x => Mapper.Map<AssessmentVersion, AssessmentVersionDTO>(x));

        private IIncludableQueryable<AssessmentVersion, BlockType> AssessmentVersions() 
            => DbContext.AssessmentVersions
                .Include(x => x.ApplicationUser)
                .Include(x => x.Assessments)
                .Include(x => x.AssessmentType)
                .Include(x => x.BlockVersions).ThenInclude(x => x.BlockType);

        public async Task<AssessmentVersionDTO> GetAssessmentVersion(int id)
            => (await AssessmentVersions()
                    .Where(x => x.Id == id)
                    .ToListAsync())
                .Select(x => Mapper.Map<AssessmentVersion, AssessmentVersionDTO>(x))
                .SingleOrDefault();

        public async Task<AssessmentVersionDTO> GetAssessmentVersion(Guid uid)
        {
            var dto = (await AssessmentVersions()
                    .Where(x => x.Uid == uid)
                    .ToListAsync())
                .Select(x => Mapper.Map<AssessmentVersion, AssessmentVersionDTO>(x))
                .Single();

            var blockVersions = dto.BlockVersions
                .Where(x => x.CompletedDate == null)
                .OrderBy(x => x.SortOrder)
                .Take(2);

            dto.CurrentBlockVersion = blockVersions.FirstOrDefault();
            dto.NextBlockVersion = blockVersions.LastOrDefault();
            
            return dto;
        }
        
        public async Task SaveAssessmentVersion(AssessmentVersionDTO dto)
        {
            AssessmentVersion entity;
            if (dto.Id == 0)
            {
                entity = await CreateAssessmentVersion(dto);
            }
            else
            {
                entity = await DbContext.AssessmentVersions.SingleAsync(x => x.Id == dto.Id);
                Mapper.Map(dto, entity);
            }
            
            SaveEntity(entity);
            SaveBlockVersions(entity.BlockVersions);
            
            await SaveChangesAsync();
            
            Mapper.Map(entity, dto);
        }

        private async Task<AssessmentVersion> CreateAssessmentVersion(AssessmentVersionDTO dto)
        {
            var assessmentVersion = new AssessmentVersion
            {
                VersionName = dto.VersionName, 
                AssessmentTypeId = dto.AssessmentTypeId,
                ApplicationUserId = dto.ParticipantUid         
            };

            // Requirements changed to only need EFT so default to EFT for now
            //if ((AssessmentTypes) dto.AssessmentTypeId != AssessmentTypes.EFT) return assessmentVersion;
            assessmentVersion.AssessmentTypeId = (int) AssessmentTypes.EFT;
            
            assessmentVersion.ImageViewingTime = _eftSettings.ImageViewTimeSeconds;
            assessmentVersion.CognitiveLoadViewingTime = _eftSettings.CognitiveLoadViewTimeSeconds;
            assessmentVersion.FixationCrossViewingTime = _eftSettings.FixationCrossTimeSeconds;
            assessmentVersion.BlockVersions = await GenerateBlockVersions();

            return assessmentVersion;
        }

        private async Task<ICollection<BlockVersion>> GenerateBlockVersions()
        {
            var blockVersions = new List<BlockVersion>();
            var blockTypes = await _lookupService.BlockTypes();

            foreach (var blockType in blockTypes)
            {
                var cognitiveLoad = blockType.SortOrder % 2 == 0;
                
                blockVersions.Add(new BlockVersion
                {
                    BlockTypeId = blockType.Id,
                    CognitiveLoad = cognitiveLoad,
                    Series = cognitiveLoad ? GetRandomSeries() : null,
                    Uid = Guid.NewGuid()
                });
            }

            blockVersions.Shuffle();
            
            return blockVersions.Select((v, i) =>
            {
                 v.SortOrder = i + 1;
                 return v;
            }).OrderBy(v => v.SortOrder).ToList();;
        }

        private void SaveBlockVersions(ICollection<BlockVersion> blockVersions)
        {
            foreach (var blockVersion in blockVersions)
                SaveEntity(blockVersion);
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

        public async Task SaveSeriesRecall(Guid blockVersionUid, string seriesRecall)
        {
            var blockVersion = await DbContext.BlockVersions.SingleAsync(x => x.Uid == blockVersionUid);

            blockVersion.SeriesRecall = seriesRecall;
            
            await SaveEntityAsync(blockVersion);
        }
        
        public async Task SaveEmotionRating(Guid blockVersionUid, string emotionRating)
        {
            var blockVersion = await DbContext.BlockVersions.SingleAsync(x => x.Uid == blockVersionUid);

            blockVersion.EmotionalRating = emotionRating;
            blockVersion.CompletedDate = DateTime.Now;

            await SaveEntityAsync(blockVersion);
        }
    }
}