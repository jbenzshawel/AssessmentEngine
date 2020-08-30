using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO.Identity;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AssessmentEngine.Web.Areas.Identity.Pages.Admin
{
    [Authorize(Roles = ApplicationRoles.Administrator)]
    public class ListUsersModel : PageModel
    {
        private readonly ILogger<ListUsersModel> _logger;
        private readonly IUserService _userService;
        
        public ListUsersModel(
            IUserService userService,
            ILogger<ListUsersModel> logger)
        {
            _userService = userService;
            _logger = logger;
        }
        
        public IEnumerable<User> UserList { get; set; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            UserList = await _userService.GetAll();

            return Page();
        }
    }
}