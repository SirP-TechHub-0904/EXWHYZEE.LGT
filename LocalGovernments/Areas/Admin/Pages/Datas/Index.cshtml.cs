using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace LocalGovernments.Areas.Admin.Pages.Datas
{
    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<IndicatorData> IndicatorData { get;set; }

        public async Task OnGetAsync()
        {
            IndicatorData = await _context.IndicatorDatas
                .Include(i => i.Indicator)
                .Include(i => i.LocalGovernment).OrderByDescending(x=>x.Id).Take(1000).ToListAsync();

            var xc = await _context.IndicatorDatas.CountAsync();
            TempData["re"] = xc;
        }
    }
}
