using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
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

        public EFTViewModel Build()
        {
            var viewModel = new EFTViewModel
            {
                Settings = _assessmentService.GetEFTSettings()
            };
            
            // TODO: update builder to populate task version info with additional configurations
            
            return viewModel;
        }
    }
}