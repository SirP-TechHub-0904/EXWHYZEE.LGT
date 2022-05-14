using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIBRARY.EXWHYZEE.LGT.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EXWHYZEE.LGT.Areas.Identity.Pages.Roles
{
    public class IndexModel : PageModel
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {

            _roleManager = roleManager;
            _context = context;
        }
        [BindProperty]
        public IdentityRole Role { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var ux = await _context.LocalGovernments.Include(x=>x.State).ToListAsync();
            foreach (var i in ux)
            {
                var role = new IdentityRole(i.Name.Replace(" ", "_") + "_"+i.State.Title.Replace(" ", "").Replace("/", "").Replace("-", "").Replace(",", "").Replace(".", "").Replace("'", ""));
                await _roleManager.CreateAsync(role);
            }
            return Page();
        }



        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            //await _roleManager.CreateAsync(Role);

            return RedirectToPage("./Roles");
        }
    }
}
