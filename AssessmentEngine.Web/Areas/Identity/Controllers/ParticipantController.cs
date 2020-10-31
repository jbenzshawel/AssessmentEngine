using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Web.Areas.Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEngine.Web.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize(Roles = ApplicationRoles.Administrator)]
    public class ParticipantController : Controller
    {
        private readonly IUserService _userService;
        
        public ParticipantController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Manage()
        {
            var viewModel = new ManageParticipantViewModel
            {
                Participants = await _userService.GetParticipants()
            } ;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ToggleLockout(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) 
                return BadRequest();
            
            await _userService.ToggleLockout(userId);

            return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) 
                return BadRequest();

            await _userService.DeleteUser(userId);
            
            return Ok();
        }
        
    }
}