using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaDisburse.Breakdown
{
    public class EditModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public EditModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LgaDisbusementBreakdown LgaDisbusementBreakdown { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LgaDisbusementBreakdown = await _context.LgaDisbusementBreakdowns
                .Include(l => l.LgaDisbusement).FirstOrDefaultAsync(m => m.Id == id);

            if (LgaDisbusementBreakdown == null)
            {
                return NotFound();
            }
           ViewData["LgaDisbusementId"] = new SelectList(_context.LgaDisbusements, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LgaDisbusementBreakdown).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LgaDisbusementBreakdownExists(LgaDisbusementBreakdown.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LgaDisbusementBreakdownExists(long id)
        {
            return _context.LgaDisbusementBreakdowns.Any(e => e.Id == id);
        }
    }
}
