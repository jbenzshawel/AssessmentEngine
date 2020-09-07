using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class TaskVersionViewModelBuilder
    {
        private readonly ILookupService _lookupService;
        private readonly IAssessmentService _assessmentService;

        public TaskVersionViewModelBuilder(
            IAssessmentService assessmentService,
            ILookupService lookupService)
        {
            _assessmentService = assessmentService;
            _lookupService = lookupService;
        }

        public async Task<TaskVersionViewModel> Build()
        {
            var viewModel = new TaskVersionViewModel();

            viewModel.BlockVersions = (await _lookupService.BlockTypes())
                .Select(blockType => new BlockVersionDTO
                {
                    Uid = Guid.NewGuid(),
                    BlockTypeId = blockType.Id,
                    BlockType = blockType
                });

            await SetLookups(viewModel);

            return viewModel;
        }

        public async Task<TaskVersionViewModel> Build(int id)
        {
            var dto = await _assessmentService.GetAssessmentVersion(id);

            var viewModel = MapToViewModel(dto);

            await SetLookups(viewModel);

            return viewModel;
        }

        private async Task SetLookups(TaskVersionViewModel viewModel)
        {
            var assessmentTypes = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Select"}
            };
            
            assessmentTypes.AddRange((await _lookupService.AssessmentTypes())
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }));

            viewModel.AssessmentTypesLookup = assessmentTypes;
        }

        private static TaskVersionViewModel MapToViewModel(AssessmentVersionDTO dto)
            => new TaskVersionViewModel
            {
                TaskVersionId = dto.Id,
                VersionName = dto.VersionName,
                AssessmentTypeId = dto.AssessmentTypeId,
                BlockVersions = dto.BlockVersions
            };
    }
}