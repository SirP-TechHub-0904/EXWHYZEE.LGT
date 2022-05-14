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
    public class CommunityResourcesModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CommunityResourcesModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MineralResource> MineralResource { get;set; }

        public Community Community { get; set; }

        public async Task OnGetAsync(long id)
        {
            MineralResource = await _context.MineralResources
                .Include(m => m.Community)
                .Where(x=>x.CommunityId == id).ToListAsync();
            Community = await _context.Communities.FirstOrDefaultAsync(x => x.Id == id);
            
        }
    }
}
