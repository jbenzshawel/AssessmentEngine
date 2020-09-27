using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Web.Areas.Tasks.Builders;
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
        private readonly EFTViewModelBuilder _builder;

        public EFTController(IAssessmentService assessmentService)
        {
            _builder = new EFTViewModelBuilder(assessmentService);
        }

        // GET
        public IActionResult Index(int? blockType)
        {
            return View(_builder.Build(blockType));
        }
    }
}