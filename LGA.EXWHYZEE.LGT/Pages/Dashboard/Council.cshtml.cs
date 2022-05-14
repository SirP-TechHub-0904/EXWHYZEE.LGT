using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LGA.EXWHYZEE.LGT.Pages.Dashboard
{
    [Authorize]
    public class CouncilModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;


        public CouncilModel(ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public LocalGovernment LocalGovernment { get; set; }
        public LocalGovtExecutive LocalGovtExecutive { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            var user = await _userManager.GetUserAsync(User);

            // get lga by user state
            LocalGovernment = await _context.LocalGovernments
               .Include(l => l.State)
               .Include(l => l.LocalGovtExecutives)
               .Include(l => l.LgaStaff)
               .Include(l => l.Categories)
               .Include(l => l.Communities)
               .FirstOrDefaultAsync(m => m.Id == user.LocalGovernmentId);


            LocalGovtExecutive = await _context.LocalGovtExecutives.Include(x => x.User).FirstOrDefaultAsync(x => x.Position == "Chairman");

            if (LocalGovernment == null)
            {
                TempData["alert"] = "Unable to Access LGA";
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
