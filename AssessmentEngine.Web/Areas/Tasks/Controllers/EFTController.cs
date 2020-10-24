using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
using AssessmentEngine.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Tasks.Controllers
{
    // TODO: Create custom auth attribute that authenticates admin role or 
    //       participant assigned to task version 
    [Authorize]
    [Area("Tasks")]
    public class EFTController : Controller
    {
        private readonly IAssessmentService _assessmentService;
        private readonly EFTViewModelBuilder _builder;

        public EFTController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
            _builder = new EFTViewModelBuilder(assessmentService);
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id, int? blockType)
        {
            var viewModel = id == Guid.Empty
                ? _builder.Build(blockType)
                : await _builder.Build(id, blockType);

            if (viewModel == null)
            {
                return NotFound();
            }

            if (viewModel.IsCompleted)
            {
                return RedirectToAction("Completed");
            }
            
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Completed()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SeriesRecall(Guid blockVersionUid, string seriesRecall)
        {
            await _assessmentService.SaveSeriesRecall(blockVersionUid, seriesRecall);

            return Ok(ApiResult.Success());
        }
        
        [HttpPost]
        public async Task<IActionResult> EmotionRating(Guid blockVersionUid, string emotionRating)
        {
            await _assessmentService.SaveEmotionRating(blockVersionUid, emotionRating);

            return Ok(ApiResult.Success());
        }
    }
}