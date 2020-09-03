using System;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Web.Areas.Identity.Models;
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
        private readonly UserManager<ApplicationUser> _userManager;
        
        public ParticipantController(IUserService userService, UserManager<ApplicationUser> userManager)
        {
            _userService = userService;
            _userManager = userManager;
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
            
            var user = await _userManager.FindByIdAsync(userId);
            ToggleLockout(user);
            await _userManager.UpdateAsync(user);
            
            return Ok();
        }

        private static void ToggleLockout(ApplicationUser user)
        {
            user.LockoutEnabled = true;
            if (user.LockoutEnd.HasValue)
                user.LockoutEnd = null;
            else
                user.LockoutEnd = DateTimeOffset.MaxValue;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) 
                return BadRequest();
            
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.DeleteAsync(user);
            return Ok();
        }
        
    }
}