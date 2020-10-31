using System;
using System.IO;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
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
    public class TaskVersionController : Controller
    {
        private readonly IAssessmentService _assessmentService;
        private readonly TaskVersionViewModelBuilder _builder;
        private readonly TaskVersionViewModelProcessor _processor;

        public TaskVersionController(
            IAssessmentService assessmentService,
            ILookupService lookupService, 
            IUserService userService)
        {
            _assessmentService = assessmentService;
            _builder = new TaskVersionViewModelBuilder(assessmentService, lookupService, userService);
            _processor = new TaskVersionViewModelProcessor(assessmentService);
        }
        
        public async Task<IActionResult> Index()
        {
            var assessmentVersions = await _assessmentService.GetAssessmentVersions();

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
        public async Task<IActionResult> Edit(TaskVersionViewModel viewModel)
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
            => Json(_assessmentService.GetRandomSeries());

        [HttpGet]
        public async Task<IActionResult> DownloadResults()
        {
            var csvText = await _assessmentService.GetAssessmentResultsCsvText();
            
            var result = BuildCsvFileResult(csvText);

            return result;
        }

        private static FileContentResult BuildCsvFileResult(string csvText)
        {
            FileContentResult result;

            using (var ms = new MemoryStream())
            {
                TextWriter tw = new StreamWriter(ms);
                tw.Write(csvText);
                tw.Flush();
                ms.Position = 0;
                var bytes = ms.ToArray();
                result = new FileContentResult(bytes, "application/octet-stream");
                result.FileDownloadName = $"eft-task-results-{DateTime.Now:u}.csv";
            }

            return result;
        }
    }
}