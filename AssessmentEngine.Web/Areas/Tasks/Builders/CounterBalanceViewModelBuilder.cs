using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;
using AssessmentEngine.Web.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.Builders
{
    public class CounterBalanceViewModelBuilder : TaskVersionViewModelBuilder
    {
        private readonly ICounterBalancedAssessmentService _counterBalancedService;
        
        public CounterBalanceViewModelBuilder(
            ILookupService lookupService, 
            IAssessmentService assessmentService, 
            IUserService userService, 
            IEnumerable<AssessmentTypes> assessmentTypes, 
            ICounterBalancedAssessmentService counterBalancedService)
        : base (assessmentService, lookupService, userService,assessmentTypes)
        {
            _counterBalancedService = counterBalancedService;
        }
        
        public new async Task<CounterBalancedVersionViewModel> Build()
        {
            var viewModel = new CounterBalancedVersionViewModel
            {
                PageAction = PageActions.Edit,
                AssessmentTypeId = (int)AssessmentTypes.VetFlexII,
                BlockVersions = Enumerable.Empty<BlockVersionDTO>()
            };

            await SetLookups(viewModel);

            viewModel.CounterBalanceTypes = new List<SelectListItem>
            {
                new() { Text = "Select" },
                new() { Text = "Version A", Value = CounterBalanceTypes.VersionA.ToString() },
                new() { Text = "Version B", Value = CounterBalanceTypes.VersionB.ToString() },
            };

            viewModel.VersionGroups = await GetVersionGroups();
            
            return viewModel;
        }

        private async Task<List<SelectListItem>> GetVersionGroups()
        {
            var versionGroups = new List<SelectListItem>
            {
                new() { Text = "Select" }
            };

            versionGroups.AddRange(
                (await _counterBalancedService.GetVersionsByAssessmentType(AssessmentTypes.VetFlexII))
                .Select(x => new SelectListItem { Text = x.TaskVersionName, Value = x.Id.ToString() }));
            
            return versionGroups;
        }

        public new async Task<CounterBalancedVersionViewModel> Build(int id)
        {
            var dto = await _assessmentService.GetAssessmentVersion(id);

            if (dto == null) return null;
            
            var viewModel = MapToCounterBalanceViewModel(dto);

            await SetLookups(viewModel);

            return viewModel;
        }

        private CounterBalancedVersionViewModel MapToCounterBalanceViewModel(AssessmentVersionDTO dto)
        {
            var viewModel = new CounterBalancedVersionViewModel();
            
            MapToViewModel(dto, viewModel);
            
            return viewModel;
        }
    }
}