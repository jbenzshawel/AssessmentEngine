using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;

namespace AssessmentEngine.Web.Areas.Tasks.Processors
{
    public class CounterBalanceProcessor
    {
        private readonly ICounterBalancedAssessmentService _counterBalancedAssessmentService;

        public CounterBalanceProcessor(ICounterBalancedAssessmentService counterBalancedAssessmentService)
        {
            _counterBalancedAssessmentService = counterBalancedAssessmentService;
        }

        public async Task Process(CreateGroupViewModel viewModel)
        {
            var dto = new TaskVersionGroupDTO
            {
                AssessmentTypeId = viewModel.AssessmentTypeId,
                TaskVersionName = viewModel.TaskVersionName
            };

            await _counterBalancedAssessmentService.CreateGroup(dto);
        }
        
        public async Task Process(CounterBalancedVersionViewModel viewModel)
        {
            var dto = new AssessmentVersionDTO
            {
                Id = viewModel.TaskVersionId,
                VersionName = viewModel.VersionName,
                AssessmentTypeId = viewModel.AssessmentTypeId ?? 0,
                ParticipantUid = viewModel.ParticipantUid,
                BlockVersions = viewModel.BlockVersions,
                TaskVersionGroupId = viewModel.TaskVersionGroupId,
                CounterBalanceType = viewModel.CounterBalanceType
            };

            await _counterBalancedAssessmentService.CreateAssessmentVersion(dto);

            TaskVersionViewModelBuilder.MapToViewModel(dto, viewModel);
        }
    }
}