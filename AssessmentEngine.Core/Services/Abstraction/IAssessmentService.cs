using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IAssessmentService : ICrudServiceBase
    {
        Task<AssessmentVersion> BuildAssessmentVersionEntity(AssessmentVersionDTO dto);
        EFTSettings GetEFTSettings();
        Task<IEnumerable<AssessmentDTO>> GetAssessments();
        Task PersistAssessmentVersion(AssessmentVersion entity, AssessmentVersionDTO dto);
        Task SaveAssessment(AssessmentDTO dto);
        Task<IEnumerable<AssessmentVersionDTO>> GetAssessmentVersions(IEnumerable<AssessmentTypes> assessmentTypes);
        Task DeleteAssessmentVersion(int assessmentVersionId);
        Task<AssessmentVersionDTO> GetAssessmentVersion(int id);
        Task<AssessmentVersionDTO> GetAssessmentVersion(Guid uid);
        Task SaveAssessmentVersion(AssessmentVersionDTO dto);
        Task SaveSeriesRecall(Guid blockVersionUid, string seriesRecall);
        Task SaveEmotionRating(Guid blockVersionUid, string emotionRating);
        Task SaveBlockDateType(Guid blockVersionUid, BlockDateTypes dateType);
        Task<IEnumerable<TaskResultDTO>> GetAssessmentResults(AssessmentTypes assessmentType);
        Task<string> GetAssessmentResultsCsvText(AssessmentTypes assessmentType);
    }
}