using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;

namespace EXWHYZEE.LGT.Areas.Identity.Pages.Roles
{
    public class SeedAccountModel : PageModel
    {
        private readonly UserManager<Profile> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public SeedAccountModel(
            UserManager<Profile> userManager,
            RoleManager<AppRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public string ReturnUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            try
            {
                var user = new Profile { UserName = "jinmcever@gmail.com", Email = "jinmcever@gmail.com", PhoneNumber = "070000000000000", LockoutEnabled = false, Surname = "Major", Firstname = "Admin", Middlename = "Account" };

                user.Id = Guid.NewGuid().ToString();
                var result = await _userManager.CreateAsync(user, "jinmcever@2022");
                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, "mSuperAdmin");




                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }catch(Exception d) { }

            try
            {
                var user = new Profile { UserName = "nipssadmin@gmail.com", Email = "nipssadmin@gmail.com", PhoneNumber = "070000000000000", LockoutEnabled = false, Surname = "Major", Firstname = "Admin", Middlename = "Account" };

                user.Id = Guid.NewGuid().ToString();
                var result = await _userManager.CreateAsync(user, "NIPSS@2022");
                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, "Admin");




                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            catch (Exception d) { }
            return LocalRedirect(Url.Content("~/"));
        }


    }

}
