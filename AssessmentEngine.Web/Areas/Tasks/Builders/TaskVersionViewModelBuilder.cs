using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class TaskVersionViewModelBuilder
    {
        private readonly IAssessmentService _assessmentService;
        
        public TaskVersionViewModelBuilder(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }
        
        public async Task<TaskVersionViewModel> Build(int id)
        {
            var dto = await _assessmentService.GetAssessmentVersion(id);

            return MapToViewModel(dto);
        }

        public static TaskVersionViewModel MapToViewModel(AssessmentVersionDTO dto)
        {
            return new TaskVersionViewModel
            {
                TaskVersionId = dto.Id,
                VersionName = dto.VersionName,
                AssessmentTypeId = dto.AssessmentTypeId,
                BlockVersions = dto.BlockVersions
            };
        }
    }
}