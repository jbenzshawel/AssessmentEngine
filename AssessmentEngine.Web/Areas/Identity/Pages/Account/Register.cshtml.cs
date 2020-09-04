using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AssessmentEngine.Domain.Constants;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Web.Areas.Identity.ViewModels;
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

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public RegisterViewModel ViewModel { get; set; }
        public string ReturnUrl { get; set; }
        
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ViewModel = new RegisterViewModel();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (!ModelState.IsValid) return Page();
            
            var user = MapToApplicationUser();
            var errors = await CreateUser(user);
            
            if (!errors.Any())
                return await SignInSuccessResult(returnUrl, user);
                
            foreach (var error in errors)
                ModelState.AddModelError(string.Empty, error.Description);

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task<IList<IdentityError>> CreateUser(ApplicationUser user)
        {
            var userResult = await _userManager.CreateAsync(user, ViewModel.Password);
            
            var errors = new List<IdentityError>();
            
            if (userResult.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, ApplicationRoles.Participant);
                errors.AddRange(roleResult.Errors);
            }
            else
            {
                errors.AddRange(userResult.Errors);
            }

            return errors;
        }

        private ApplicationUser MapToApplicationUser() 
            => new ApplicationUser { UserName = ViewModel.UserName, Email = ViewModel.Email, ParticipantId = ViewModel.ParticipantId};

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
