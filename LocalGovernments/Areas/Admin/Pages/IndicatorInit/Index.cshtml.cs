using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace LocalGovernments.Areas.Admin.Pages.IndicatorInit
{
    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Indicator> Indicator { get;set; }

        public async Task OnGetAsync()
        {
            Indicator = await _context.Indicators
                .Include(i => i.SubIndicator).Include(i => i.IndicatorDatas).ToListAsync();
        }
    }
}
