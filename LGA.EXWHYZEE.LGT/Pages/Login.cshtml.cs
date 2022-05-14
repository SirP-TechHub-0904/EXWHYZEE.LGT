using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LGA.EXWHYZEE.LGT.Pages
{

    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<Profile> _userManager;
        private readonly SignInManager<Profile> _signInManager;
        private readonly ILogger<IndexModel> _logger;
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;


        public LoginModel(SignInManager<Profile> signInManager,
            ILogger<IndexModel> logger,
            UserManager<Profile> userManager, LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //  returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user != null)
                {

                    var passcheck = await _userManager.CheckPasswordAsync(user, Input.Password);
                    if (passcheck == true && user.TwoFactorEnabled == true)
                    {
                        await _userManager.UpdateAsync(user);
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                        if (result.Succeeded)
                        {

                            _logger.LogInformation("User logged in.");
                            var xAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                            var xSuper = await _userManager.IsInRoleAsync(user, "mSuperAdmin");
                            var xContent = await _userManager.IsInRoleAsync(user, "Content");
                            if (xAdmin.Equals(true))
                            {
                                return RedirectToPage("/Init/Index", new { area = "LG" });
                            }

                            else if (xSuper.Equals(true))
                            {
                                return RedirectToPage("/Dashboard/Index", new { area = "AdminPage" });
                            }
                            else if (xContent.Equals(true))
                            {
                                return RedirectToPage("/Dashboard/Index", new { area = "AdminPage" });
                            }

                            else
                            {
                                return Redirect(returnUrl);
                            }
                        }
                        if (result.RequiresTwoFactor)
                        {
                            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return RedirectToPage("./Lockout");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                            return Page();
                        }
                    }
                    else if (passcheck == true)
                    {
                        var xlg = await _context.LocalGovernments.Include(x => x.State).FirstOrDefaultAsync(x => x.Id == user.LocalGovernmentId);
                        var role = xlg.Name.Replace(" ", "_") + "_" + xlg.State.Title.Replace(" ", "").Replace("/", "").Replace("-", "").Replace(",", "").Replace(".", "").Replace("'", "");

                        await _signInManager.SignInAsync(user, isPersistent: false);

                        var Admin = await _userManager.IsInRoleAsync(user, role);

                        if (Admin.Equals(true))
                        {
                            return RedirectToPage("/Dashboard/Index");
                        }

                        else
                        {
                            return Redirect(returnUrl);
                        }

                    }

                }

            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}

