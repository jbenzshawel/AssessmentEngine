using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Web.Areas.Identity.ViewModels;
using AssessmentEngine.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace AssessmentEngine.Web.Areas.Identity.Pages.Account
{
    
    [Authorize(Roles = ApplicationRoles.Administrator)]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ILookupService _lookupService;
        private readonly IUserService _userService;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, 
            ILookupService lookupService, 
            IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _lookupService = lookupService;
            _userService = userService;
        }

        [BindProperty]
        public RegisterViewModel ViewModel { get; set; }
        public string ReturnUrl { get; set; }
        
        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            ViewModel = new RegisterViewModel();
            
            return await PageWithLookups();
        }

        private async Task<IActionResult> PageWithLookups()
        {
            await SetLookups();
            return Page();
        }

        private async Task SetLookups()
        {
            var lookup = await LookupHelper.GetSelectList(_lookupService.ParticipantTypes);

            ViewModel.ParticipantTypesLookup = lookup;
        }
        
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            var user = MapToApplicationUser();

            await _userService.ValidateParticipant(user);

            AddErrorsToModelState(user);
                    
            if (!ModelState.IsValid)
                return await PageWithLookups();
            
            await CreateUser(user);
            
            if (user.IsValid)
                return await SignInSuccessResult(returnUrl, user);
                
            AddErrorsToModelState(user);
         
            // If we got this far, something failed, redisplay form
            return await PageWithLookups();
        }

        private void AddErrorsToModelState(ApplicationUser user)
        {
            foreach (var error in user.ValidationErrors)
                ModelState.AddModelError(string.Empty, error);
        }

        private async Task CreateUser(ApplicationUser user)
        {
            var userResult = await _userManager.CreateAsync(user, ViewModel.Password);
            
            if (userResult.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, ApplicationRoles.Participant);
                user.ValidationErrors.AddRange(roleResult.Errors.Select(x => x.Description));
            }
            else
            {
                user.ValidationErrors.AddRange(userResult.Errors.Select(x => x.Description));
            }
        }

        private ApplicationUser MapToApplicationUser() 
            => new ApplicationUser
            {
                UserName = ViewModel.UserName, 
                Email = ViewModel.Email, 
                ParticipantId = ViewModel.ParticipantId,
                LockoutEnd = DateTimeOffset.MaxValue, // Users disabled by default
            };

        private async Task<IActionResult> SignInSuccessResult(string returnUrl, ApplicationUser user)
        {
            _logger.LogInformation("User created a new account with password.");

            if (_userManager.Options.SignIn.RequireConfirmedAccount)
            {
                await SendConfirmationEmail(returnUrl, user);
            }

            return RedirectToAction("Manage", "Participant", new { area = "Identity" });
        }

        private async Task SendConfirmationEmail(string returnUrl, ApplicationUser user)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new {area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl},
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(ViewModel.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
        }
    }
}
