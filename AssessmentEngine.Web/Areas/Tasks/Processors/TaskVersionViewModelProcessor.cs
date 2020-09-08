using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;

namespace AssessmentEngine.Web.Areas.Tasks.Processors
{
    public class TaskVersionViewModelProcessor
    {
        private readonly IAssessmentService _assessmentService;

        public TaskVersionViewModelProcessor(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }

        public async Task Process(TaskVersionViewModel viewModel)
        {
            var dto = new AssessmentVersionDTO
            {
                Id = viewModel.TaskVersionId,
                VersionName = viewModel.VersionName,
                AssessmentTypeId = viewModel.AssessmentTypeId ?? 0,
                BlockVersions = viewModel.BlockVersions
            };

            await _assessmentService.SaveAssessmentVersion(dto);
        }
    }
}