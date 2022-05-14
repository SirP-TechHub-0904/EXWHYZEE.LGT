using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaPanel
{
    public class CreateModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CreateModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public State State { get; set; }
        public async Task<IActionResult> OnGet(long id)
        {

            // ViewData["StateId"] = new SelectList(_context.States, "Id", "Id");
            State = await _context.States.FirstOrDefaultAsync(x => x.Id == id);
            if(State == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public LocalGovernment LocalGovernment { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LocalGovernments.Add(LocalGovernment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
