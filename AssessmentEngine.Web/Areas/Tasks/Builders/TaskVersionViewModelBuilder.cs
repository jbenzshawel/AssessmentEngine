using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;
using AssessmentEngine.Web.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class TaskVersionViewModelBuilder
    {
        private readonly ILookupService _lookupService;
        private readonly IAssessmentService _assessmentService;
        private readonly IUserService _userService;

        public TaskVersionViewModelBuilder(
            IAssessmentService assessmentService,
            ILookupService lookupService, 
            IUserService userService)
        {
            _assessmentService = assessmentService;
            _lookupService = lookupService;
            _userService = userService;
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

            if (dto == null) return null;
            
            var viewModel = MapToViewModel(dto);

            await SetLookups(viewModel);

            return viewModel;
        }

        private async Task SetLookups(TaskVersionViewModel viewModel)
        {
            viewModel.AssessmentTypesLookup = await LookupHelper.GetSelectList(_lookupService.AssessmentTypes);
            viewModel.Participants = await GetParticipantLookup();
        }

        private async Task<List<SelectListItem>> GetParticipantLookup()
        {
            var lookup = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Select",
                    Value = ""
                }
            };

            lookup.AddRange((await _userService.GetParticipants()).Select(x => new SelectListItem
            {
                Text = x.ParticipantId,
                Value = x.UserId.ToString()
            }));
            return lookup;
        }

        private static TaskVersionViewModel MapToViewModel(AssessmentVersionDTO dto)
        {
            var viewModel = new TaskVersionViewModel();
            MapToViewModel(dto, viewModel);
            return viewModel;
        }
        
        public static void MapToViewModel(AssessmentVersionDTO dto, TaskVersionViewModel viewModel)
        {
            viewModel.TaskVersionId = dto.Id;
            viewModel.VersionName = dto.VersionName;
            viewModel.AssessmentTypeId = dto.AssessmentTypeId;
            viewModel.ParticipantUid = dto.ParticipantUid;
            viewModel.ParticipantId = dto.ParticipantId;
            viewModel.BlockVersions = dto.BlockVersions;
        }
    }
}