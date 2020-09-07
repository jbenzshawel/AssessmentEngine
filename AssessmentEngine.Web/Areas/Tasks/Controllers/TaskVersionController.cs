using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
using AssessmentEngine.Web.Areas.Tasks.Processor;
using AssessmentEngine.Web.Areas.Tasks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Tasks.Controllers
{
    [Area("Tasks")]
    public class TaskVersionController : Controller
    {
        private readonly IAssessmentService _assessmentService;
        private readonly TaskVersionViewModelBuilder _builder;
        private readonly TaskVersionViewModelProcessor _processor;

        public TaskVersionController(
            IAssessmentService assessmentService,
            ILookupService lookupService)
        {
            _assessmentService = assessmentService;
            _builder = new TaskVersionViewModelBuilder(assessmentService, lookupService);
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
            => View(await _builder.Build(id));

        [HttpPost]
        public async Task<IActionResult> Edit(TaskVersionViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _processor.Process(viewModel);
            }
            
            return Ok(new
            {
                Success = ModelState.IsValid,
                Errors = ModelState.Select(x => x.Value.Errors)
                    .Where(y=>y.Count>0)
            });
        }
    }
}