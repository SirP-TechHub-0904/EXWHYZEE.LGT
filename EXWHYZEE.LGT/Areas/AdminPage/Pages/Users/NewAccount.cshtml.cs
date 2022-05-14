using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using Microsoft.EntityFrameworkCore;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.Users
{
    public class CumDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    [AllowAnonymous]
    public class NewAccountModel : PageModel
    {
        private readonly SignInManager<Profile> _signInManager;
        private readonly UserManager<Profile> _userManager;
        private readonly ILogger<NewAccountModel> _logger;
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;


        public NewAccountModel(
            UserManager<Profile> userManager,
            SignInManager<Profile> signInManager,
            ILogger<NewAccountModel> logger, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public string PhoneNumber { get; set; }

            public string Role { get; set; }
            public decimal Salary { get; set; }
            public DateTime DOB { get; set; }
            public DateTime EmploymentDate { get; set; }
            public DateTime RetirementDate { get; set; }
            public string Position { get; set; }
            public string Rank { get; set; }
            public string Level { get; set; }
            public string Surname { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public string AltPoneNumber { get; set; }
            public string FullContactAdress { get; set; }
            public long? StateId { get; set; }
            public State State { get; set; }
            public long? LocalGovernmentId { get; set; }
            public LocalGovernment LocalGovernment { get; set; }
            public long? CommunitytId { get; set; }
            public Community Communities { get; set; }
            public string PermanentHomeAddress { get; set; }
            public string ValidIdCard { get; set; }
            public string CV { get; set; }
            public string AppointmentLetter { get; set; }
            public string Passport { get; set; }
            public string SalaryAccountNumber { get; set; }
            public string SalaryAccountBank { get; set; }
            public string SalaryAccountName { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string BodyStructure { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {

            var item = await _context.Communities.Include(x=>x.LocalGovernment).ToListAsync();
            var output = item.Select(x => new CumDto
            {

                Id = x.Id,
                Name = x.LocalGovernment.Name
            });
            ViewData["LocalGovernmentId"] = new SelectList(_context.LocalGovernments, "Id", "Name");
            ViewData["StateId"] = new SelectList(_context.States, "Id", "Title");
            ViewData["CommunityId"] = new SelectList(output, "Id", "Name");
            ViewData["Roles"] = new SelectList(_context.Roles, "Name", "Name");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                var user = new Profile
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    Surname = Input.Surname,
                    Firstname = Input.Firstname,
                    Middlename = Input.Middlename,
                    StateId = Input.StateId,
                    LocalGovernmentId = Input.LocalGovernmentId,
                    CommunitytId = Input.CommunitytId,
                   Role = Input.Role
                };

                user.Id = Guid.NewGuid().ToString();
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, Input.Role);


                    await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
