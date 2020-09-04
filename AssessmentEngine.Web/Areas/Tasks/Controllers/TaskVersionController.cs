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
        private readonly TaskVersionViewModelBuilder _viewModelBuilder;
        private readonly TaskVersionViewModelProcessor _processor;

        public TaskVersionController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
            _viewModelBuilder = new TaskVersionViewModelBuilder(assessmentService);
            _processor = new TaskVersionViewModelProcessor(assessmentService);
        }
        
        public async Task<IActionResult> Index()
        {
            var assessmentVersions = await _assessmentService.GetAssessmentVersions();

            return View(assessmentVersions);
        }

        public IActionResult Create()
        {
            return View(new TaskVersionViewModel());
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await _viewModelBuilder.Build(id);
            
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TaskVersionViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _processor.Process(viewModel);
            }
            
            return View(viewModel);
        }
    }
}