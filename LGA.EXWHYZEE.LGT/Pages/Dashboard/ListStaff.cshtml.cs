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
    public class ListStaffModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;


        public ListStaffModel(ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IQueryable<LgaStaff> LgaStaff { get; set; }
        public LocalGovernment LocalGovernment { get; set; }

        public async Task<IActionResult> OnGetAsync(string sort)
        {
            var user = await _userManager.GetUserAsync(User);
            LocalGovernment = await _context.LocalGovernments
              .Include(l => l.State)
              .Include(l => l.LocalGovtExecutives)
              .Include(l => l.LgaStaff)
              .Include(l => l.Categories)
              .Include(l => l.Communities)
              .FirstOrDefaultAsync(m => m.Id == user.LocalGovernmentId);
            // get lga by user state
            //LgaStaff = await _context.LgaStaffs
            //   .Include(l => l.User)
            //   .Where(m => m.LocalGovernmentId == user.LocalGovernmentId).ToListAsync();


            IQueryable<LgaStaff> iLgaList = from s in _context.LgaStaffs
                                            .Include(l => l.User)
               .Where(m => m.LocalGovernmentId == user.LocalGovernmentId)
                                            select s;

            LgaStaff = iLgaList;
            if (sort== "02bfbbf2-e626-4956-83ac-7051bd0e84cb")
            {
                TempData["title"] = "(MALE LIST)";
                LgaStaff = iLgaList.Where(m => m.User.Gender.ToUpper() == "MALE");
            }
            if(sort == "0a37dc2e-273f-43f6-8e4f-b2e29e0bc91a")
            {
                TempData["title"] = "(FEMALE LIST)";
                LgaStaff = iLgaList.Where(m => m.User.Gender.ToUpper() == "FEMALE");

            }

            if (LocalGovernment == null)
            {
                TempData["alert"] = "Unable to Access LGA";
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
