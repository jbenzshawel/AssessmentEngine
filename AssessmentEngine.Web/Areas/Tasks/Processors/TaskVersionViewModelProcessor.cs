using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
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

        public async Task Process(RandomizedTaskVersionViewModel viewModel)
        {
            var dto = new AssessmentVersionDTO
            {
                Id = viewModel.TaskVersionId,
                VersionName = viewModel.VersionName,
                AssessmentTypeId = viewModel.AssessmentTypeId ?? 0,
                ParticipantUid = viewModel.ParticipantUid,
                BlockVersions = viewModel.BlockVersions
            };

            await _assessmentService.SaveAssessmentVersion(dto);

            TaskVersionViewModelBuilder.MapToViewModel(dto, viewModel);
        }
    }
}