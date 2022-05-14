using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaDisburse.Breakdown
{
    public class DetailsModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public DetailsModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
