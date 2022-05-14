using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.SectionDocPanel
{
    public class DetailsModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public DetailsModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SectionDocument SectionDocument { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SectionDocument = await _context.SectionDocuments
                .Include(s => s.Section).FirstOrDefaultAsync(m => m.Id == id);

            if (SectionDocument == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
