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
            
            // TODO: update builder to populate task version info with additional configurations
            
            return viewModel;
        }
    }
}