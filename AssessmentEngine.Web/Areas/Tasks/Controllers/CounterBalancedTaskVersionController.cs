using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Enums;
using AssessmentEngine.Web.Areas.Tasks.Builders;
using AssessmentEngine.Web.Areas.Tasks.Processors;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;
using AssessmentEngine.Web.Common;
using AssessmentEngine.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Tasks.Controllers
{
    [Area("Tasks")]
    [Authorize(Roles = ApplicationRoles.Administrator)]
    public class CounterBalancedTaskVersionController : Controller
    {
        private readonly IAssessmentService _assessmentService;
        private readonly CounterBalanceViewModelBuilder _builder;
        private readonly CounterBalanceProcessor _processor;
        private readonly IRandomService _randomService;
        private readonly IEnumerable<AssessmentTypes> _assessmentTypes = new[]
        {
            AssessmentTypes.VetFlexII
        };

        public CounterBalancedTaskVersionController(
            IAssessmentService assessmentService,
            ILookupService lookupService, 
            IUserService userService, 
            IRandomService randomService,
            ICounterBalancedAssessmentService counterBalancedAssessmentService)
        {
            _assessmentService = assessmentService;
            _randomService = randomService;
            _builder = new CounterBalanceViewModelBuilder(lookupService, assessmentService, userService, 
            _assessmentTypes, counterBalancedAssessmentService);
            _processor = new CounterBalanceProcessor(counterBalancedAssessmentService);
        }

        public async Task<IActionResult> CreateGroup()
        {
            var viewModel = new CreateGroupViewModel
            {
                AssessmentTypesLookup = await _builder.GetAssessmentTypes()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup(CreateGroupViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _processor.Process(viewModel);
            }
            
            return Ok(new ApiResult(ModelState));
        }
        
        public async Task<IActionResult> Index()
        {
            var assessmentVersions = await _assessmentService.GetAssessmentVersions(_assessmentTypes);

            return View(assessmentVersions);
        }

        public async Task<IActionResult> Create() 
            => View(await _builder.Build());

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await _builder.Build(id);

            if (viewModel == null)
            {
                return NotFound();
            }
            
            viewModel.PageAction = PageActions.Edit;

            return View(viewModel);
        }
        
        public async Task<IActionResult> View(int id)
        {
            var viewModel = await _builder.Build(id);
            
            if (viewModel == null)
            {
                return NotFound();
            }
            
            viewModel.PageAction = PageActions.View;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CounterBalancedVersionViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _processor.Process(viewModel);
            }
            
            return Ok(new ApiResult(ModelState) { Data = viewModel});
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (id > 0)
            {
                await _assessmentService.DeleteAssessmentVersion(id);
            }
            
            return Ok(new ApiResult { IsValid = true});
        }

        [HttpGet]
        public IActionResult RandomSeries()
            => Json(_randomService.GetRandomSeries());
    }
}