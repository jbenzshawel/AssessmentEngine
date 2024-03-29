using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentEngine.Core.Abstraction;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class AssessmentService : CrudServiceBase<IApplicationDbContext>, IAssessmentService
    {
        private readonly IConfiguration _configuration;
        private readonly EFTSettings _eftSettings;
        private readonly IBlockVersionGenerator _blockVersionGenerator;

        public AssessmentService(
            IApplicationDbContext dbContext, 
            IMapperAdapter mapper,
            IOptions<EFTSettings> eftSettings, 
            IConfiguration configuration, 
            IBlockVersionGenerator blockVersionGenerator) : base(dbContext, mapper)
        {
            _configuration = configuration;
            _blockVersionGenerator = blockVersionGenerator;
            _eftSettings = eftSettings.Value;
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
        
        public async Task<IEnumerable<AssessmentVersionDTO>> GetAssessmentVersions(IEnumerable<AssessmentTypes> assessmentTypes)
        {
            var assessmentTypeIds = assessmentTypes.Select(x => (int)x);
            
            return (await AssessmentVersions()
                    .Where(x => assessmentTypeIds.Contains(x.AssessmentTypeId))
                    .ToListAsync())
                .Select(MapToAssessmentVersionDto);
        }

        private AssessmentVersionDTO MapToAssessmentVersionDto(AssessmentVersion entity)
        {
            var dto = Mapper.Map<AssessmentVersion, AssessmentVersionDTO>(entity);
            
            dto.ParticipantUrl = _configuration["SiteUrl"] + "/tasks/task/index/" + entity.Uid;

            return dto;
        }

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
                .Take(2)
                .ToList();

            dto.CurrentBlockVersion = blockVersions.FirstOrDefault();
            dto.NextBlockVersion = blockVersions.LastOrDefault();
            dto.IsCompleted = dto.BlockVersions.All(x => x.CompletedDate.HasValue);
            
            return dto;
        }
        
        public async Task SaveAssessmentVersion(AssessmentVersionDTO dto)
        {
            AssessmentVersion entity;
            if (dto.Id == 0)
            {
                entity = await BuildAssessmentVersionEntity(dto);
            }
            else
            {
                entity = await DbContext.AssessmentVersions.SingleAsync(x => x.Id == dto.Id);
                MapToEntity(dto, entity);
            }
            
            await PersistAssessmentVersion(entity, dto);
        }

        public async Task PersistAssessmentVersion(AssessmentVersion entity, AssessmentVersionDTO dto)
        {
            SaveEntity(entity);
            SaveBlockVersions(entity.BlockVersions);

            await SaveChangesAsync();

            Mapper.Map(entity, dto);
        }

        private void MapToEntity(AssessmentVersionDTO dto, AssessmentVersion entity)
        {
            Mapper.Map(dto, entity);
        }

        public async Task<AssessmentVersion> BuildAssessmentVersionEntity(AssessmentVersionDTO dto)
        {
            var assessmentVersion = new AssessmentVersion
            {
                VersionName = dto.VersionName, 
                AssessmentTypeId = dto.AssessmentTypeId,
                ApplicationUserId = dto.ParticipantUid         
            };
            
            assessmentVersion.AssessmentTypeId = dto.AssessmentTypeId;
            
            assessmentVersion.ImageViewingTime = _eftSettings.ImageViewTimeSeconds;
            assessmentVersion.CognitiveLoadViewingTime = _eftSettings.CognitiveLoadViewTimeSeconds;
            assessmentVersion.FixationCrossViewingTime = _eftSettings.FixationCrossTimeSeconds;
            assessmentVersion.BlockVersions = await _blockVersionGenerator.Generate((AssessmentTypes) dto.AssessmentTypeId);

            return assessmentVersion;
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

            if (entity.BlockVersions.Any(x => x.CompletedDate.HasValue))
            {
                throw new Exception("Assessment versions with completed blocks cannot be deleted");
            }
            
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
            
            SetBlockDateType(blockVersion, BlockDateTypes.TaskCompleteDateTime);
            
            await SaveEntityAsync(blockVersion);
        }

        public async Task SaveBlockDateType(Guid blockVersionUid, BlockDateTypes dateType)
        {
            var blockVersion = await DbContext.BlockVersions.SingleAsync(x => x.Uid == blockVersionUid);
            
            SetBlockDateType(blockVersion, dateType);

            await SaveEntityAsync(blockVersion);
        }
        
        private void SetBlockDateType(BlockVersion blockVersion, BlockDateTypes dateType)
        {
            switch (dateType)
            {
                case BlockDateTypes.StartTaskDateTime:
                    blockVersion.BlockStartDateTime = DateTime.Now;
                    break;
                case BlockDateTypes.EndTaskDateTime:
                    blockVersion.BlockEndDateTime = DateTime.Now;
                    break;
                case BlockDateTypes.TaskCompleteDateTime:
                    blockVersion.CompletedDate = DateTime.Now;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dateType), dateType, null);
            }
        }

        public async Task<IEnumerable<TaskResultDTO>> GetAssessmentResults(AssessmentTypes assessmentType)
        {
            var assessmentTypeId = (int)assessmentType;
            
            var results = await DbContext.AssessmentVersions
                .Include(x => x.ApplicationUser)
                .AsNoTracking()
                .Join(DbContext.BlockVersions.Include(x => x.BlockType)
                .Where(y => y.CompletedDate.HasValue &&
                            y.AssessmentVersion.AssessmentTypeId == assessmentTypeId),
                    av => av.Id,
                    bv => bv.AssessmentVersionId,
                    (assessmentVersion, blockVersion) => new TaskResultDTO
                    {
                        Uid = assessmentVersion.Uid.ToString(),
                        ParticipantId = assessmentVersion.ApplicationUser.ParticipantId,
                        BlockType = blockVersion.BlockType.Name,
                        TaskVersion = assessmentVersion.VersionName,
                        EmotionRating = blockVersion.EmotionalRating,
                        CognitiveLoad = blockVersion.CognitiveLoad,
                        Series = blockVersion.Series,
                        SeriesRecall = blockVersion.SeriesRecall,
                        BlockStartDateTime = blockVersion.BlockStartDateTime,
                        BlockEndDateTime = blockVersion.BlockEndDateTime,
                        CompletedDateTime = blockVersion.CompletedDate.Value
                    })
                .OrderBy(x => x.Uid).ThenBy(x => x.CompletedDateTime)
                .ToListAsync();

            return results;
        }

        public async Task<string> GetAssessmentResultsCsvText(AssessmentTypes assessmentType)
        {
            var results = await GetAssessmentResults(assessmentType);
            
            var csv = new StringBuilder();
            
            csv.Append("UID,Participant Id,Task Version,Images Start Time, Images End Time,Block Completed Date,Block Type,Emotion Rating,Cognitive Load,Series,Series Recall");
            csv.Append(Environment.NewLine);
            
            foreach (var item in results)
            {
                csv.Append($"{item.Uid},{item.ParticipantId},{item.TaskVersion},{item.BlockStartDateTime:G},{item.BlockEndDateTime:G},{item.CompletedDateTime:G},{item.BlockType},{item.EmotionRating},{item.CognitiveLoad},{item.Series},{item.SeriesRecall}");
                csv.Append(Environment.NewLine);
            }

            return csv.ToString();
        }
    }
}