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
    public class CommunityPageModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CommunityPageModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Community> Community { get;set; }

        public LocalGovernment LGA { get; set; }

        public async Task OnGetAsync(long id)
        {
            Community = await _context.Communities
                .Include(c => c.LocalGovernment)
                .Include(c => c.MineralResources)
                .Where(x=>x.LocalGovernmentId == id).ToListAsync();

            LGA = await _context.LocalGovernments.FirstOrDefaultAsync(x => x.Id == id);

        }
    }
}
