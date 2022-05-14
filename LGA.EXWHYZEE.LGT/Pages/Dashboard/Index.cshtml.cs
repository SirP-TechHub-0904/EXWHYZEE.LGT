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
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;


        public IndexModel(ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public LocalGovernment LocalGovernment { get; set; }

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

            if(LocalGovernment == null)
            {
                TempData["alert"] = "Unable to Access LGA";
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
