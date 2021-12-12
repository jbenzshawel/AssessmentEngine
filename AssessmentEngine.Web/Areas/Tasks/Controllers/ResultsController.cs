using System;
using System.IO;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Tasks.Controllers
{
    [Area("Tasks")]
    [Authorize(Roles = ApplicationRoles.Administrator)]
    public class ResultsController : Controller
    {
        private readonly IAssessmentService _assessmentService;

        public ResultsController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }

        [HttpGet("/{assessmentType}")]
        public async Task<IActionResult> Download(AssessmentTypes assessmentType)
        {
            var csvText = await _assessmentService.GetAssessmentResultsCsvText(assessmentType);
            
            var result = BuildCsvFileResult(csvText, assessmentType);

            return result;
        }

        private static FileContentResult BuildCsvFileResult(string csvText, AssessmentTypes assessmentType)
        {
            using var ms = new MemoryStream();
            TextWriter tw = new StreamWriter(ms);
            tw.Write(csvText);
            tw.Flush();
            ms.Position = 0;
            var bytes = ms.ToArray();
            var result = new FileContentResult(bytes, "application/octet-stream")
            {
                FileDownloadName = $"{assessmentType}-Task-Results-{DateTime.Now:u}.csv"
            };

            return result;
        }
    }
}