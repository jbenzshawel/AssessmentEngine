using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class TaskViewModelBuilder
    {
        private readonly IAssessmentService _assessmentService;

        public TaskViewModelBuilder(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }
        
        public TaskViewModel Build(int? blockType)
        {
            var viewModel = new TaskViewModel
            {
                Settings = _assessmentService.GetEFTSettings(),
                BlockType = blockType.HasValue 
                    ? (BlockTypes)blockType.Value 
                    : BlockTypes.EP1
            };
            
            return viewModel;
        }

        public async Task<TaskViewModel> Build(Guid uid, int? blockType)
        {
            var assessment = await _assessmentService.GetAssessmentVersion(uid);

            if (assessment == null)
            {
                return null;
            }
            
            var viewModel = new TaskViewModel
            {
                TaskVersionId = assessment.Id,
                TaskVersionUid = assessment.Uid,
                Settings = _assessmentService.GetEFTSettings(),
                BlockType = blockType.HasValue
                    ? (BlockTypes)blockType.Value
                    : (BlockTypes)(assessment.CurrentBlockVersion?.BlockTypeId ?? 0),
                CurrentBlockVersion = assessment.CurrentBlockVersion,
                NextBlockVersion = assessment.NextBlockVersion,
                AssessmentTypeId = assessment.AssessmentTypeId,
                BlockVersions = assessment.BlockVersions,
                ParticipantUrl =  assessment.ParticipantUrl,
                IsCompleted = assessment.IsCompleted
            };

            return viewModel;
        }
    }
}