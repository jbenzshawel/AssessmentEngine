using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Tasks.Controllers
{
    [Area("Tasks")]
    [Authorize]
    public class EFTController : Controller
    {
        private readonly EFTViewModelBuilder _builder;
        private readonly IAssessmentService _assessmentService;

        public EFTController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
            _builder = new EFTViewModelBuilder(assessmentService);
        }

        // GET
        public IActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}