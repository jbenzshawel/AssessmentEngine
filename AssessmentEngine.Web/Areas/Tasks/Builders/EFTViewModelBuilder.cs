using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class EFTViewModelBuilder
    {
        private readonly IAssessmentService _assessmentService;

        public EFTViewModelBuilder(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }
        
        public EFTViewModel Build(int? blockType)
        {
            var viewModel = new EFTViewModel
            {
                Settings = _assessmentService.GetEFTSettings(),
                BlockType = blockType.HasValue 
                    ? (BlockTypes)blockType.Value 
                    : BlockTypes.EP1
            };
            
            return viewModel;
        }

        public async Task<EFTViewModel> Build(Guid uid, int? blockType)
        {
            var assessment = await _assessmentService.GetAssessmentVersion(uid);
            
            var viewModel = new EFTViewModel
            {
                TaskVersionId = assessment.Id,
                TaskVersionUid = assessment.Uid,
                Settings = _assessmentService.GetEFTSettings(),
                BlockType = blockType.HasValue
                    ? (BlockTypes)blockType.Value
                    : (BlockTypes)assessment.CurrentBlockVersion.BlockTypeId,
                CurrentBlockVersion = assessment.CurrentBlockVersion,
                NextBlockVersion = assessment.NextBlockVersion,
                AssessmentTypeId = assessment.AssessmentTypeId,
                BlockVersions = assessment.BlockVersions,
                ParticipantUrl =  assessment.ParticipantUrl
            };

            return viewModel;
        }
    }
}