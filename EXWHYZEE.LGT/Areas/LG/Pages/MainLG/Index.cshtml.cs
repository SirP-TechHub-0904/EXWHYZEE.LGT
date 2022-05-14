using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.LG.Pages.MainLG
{
    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public LocalGovernment LocalGovernment { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }


             LocalGovernment = await _context.LocalGovernments
                .Include(l => l.State)
                .Include(l => l.LocalGovtExecutives)
                .Include(l => l.LgaStaff)
                .Include(l => l.Categories)
                .Include(l => l.Communities)
                .FirstOrDefaultAsync(m => m.Id == id);



            if (LocalGovernment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
