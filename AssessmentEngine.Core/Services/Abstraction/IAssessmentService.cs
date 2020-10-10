using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Entities;

namespace AssessmentEngine.Core.Services.Abstraction
{
    public interface IAssessmentService : ICrudServiceBase
    {
        string GetRandomSeries();
        EFTSettings GetEFTSettings();
        Task<IEnumerable<AssessmentDTO>> GetAssessments();
        Task SaveAssessment(AssessmentDTO dto);
        Task<IEnumerable<AssessmentVersionDTO>> GetAssessmentVersions();
        Task DeleteAssessmentVersion(int assessmentVersionId);
        Task<AssessmentVersionDTO> GetAssessmentVersion(int id);
        Task<AssessmentVersionDTO> GetAssessmentVersion(Guid uid);
        Task SaveAssessmentVersion(AssessmentVersionDTO dto);
        Task SaveSeriesRecall(Guid blockVersionUid, string seriesRecall);
        Task SaveEmotionRating(Guid blockVersionUid, string emotionRating);
    }
}