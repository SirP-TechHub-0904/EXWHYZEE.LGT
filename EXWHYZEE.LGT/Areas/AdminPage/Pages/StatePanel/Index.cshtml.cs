using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.AspNetCore.Authorization;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.StatePanel
{
    //[Authorize]
    //[Authorize(Roles = "Participant")]

    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<State> State { get;set; }

        public async Task OnGetAsync()
        {
            State = await _context.States.Include(x=>x.LocalGovernments).ToListAsync();
        }
    }
}
