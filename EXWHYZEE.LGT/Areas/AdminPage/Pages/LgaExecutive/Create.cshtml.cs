using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaExecutive
{
    public class CreateModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CreateModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LocalGovernmentId"] = new SelectList(_context.LocalGovernments, "Id", "Id");
        ViewData["UserId"] = new SelectList(_context.Set<Profile>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public LocalGovtExecutive LocalGovtExecutive { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LocalGovtExecutives.Add(LocalGovtExecutive);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
