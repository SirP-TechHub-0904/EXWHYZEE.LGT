using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaPanel
{
    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<LocalGovernment> LocalGovernment { get;set; }

        public async Task OnGetAsync()
        {
            LocalGovernment = await _context.LocalGovernments
                .Include(l => l.State)
                .Include(l => l.LocalGovtExecutives)
                .Include(l => l.LgaStaff)
                .Include(l => l.State)
                .Include(l => l.Categories)
                .ToListAsync();
        }
    }
}
