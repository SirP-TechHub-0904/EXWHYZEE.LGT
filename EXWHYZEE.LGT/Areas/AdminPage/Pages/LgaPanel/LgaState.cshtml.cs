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
    public class LgaStateModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public LgaStateModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<LocalGovernment> LocalGovernment { get;set; }
        public State State { get; set; }
        public async Task OnGetAsync(long id)
        {
            LocalGovernment = await _context.LocalGovernments
                .Include(l => l.State)
                .Include(l => l.Communities)
                .Include(l => l.LgaStaff)
                .Include(l => l.Categories)
                .Include(l => l.LocalGovtExecutives)
                .Where(x => x.StateId == id).ToListAsync();

            State = await _context.States.FirstOrDefaultAsync(x => x.Id == id);

        }
    }
}
