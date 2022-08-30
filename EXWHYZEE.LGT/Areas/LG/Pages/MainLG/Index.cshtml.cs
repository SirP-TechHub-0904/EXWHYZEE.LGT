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
        public long LGID { get; set; }
        public long MID { get; set; }
        public long SID { get; set; }
        public IList<MainIndicator> MainIndicator { get; set; }
        public IList<SubIndicator> SubIndicator { get; set; }

        public IQueryable<Indicator> Indicators { get; set; }
        public IQueryable<IndicatorData> IndicatorDatas { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id, long? mId, long? sId)
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
            LGID = LocalGovernment.Id;
            var md = await _context.MainIndicators.FirstOrDefaultAsync(x => x.Id == mId);
            if (md != null)
            {
                MID = md.Id;
                TempData["available"] = "Availabale";

                IQueryable<SubIndicator> itemsSubIndicator = from s in _context.SubIndicators.Where(x => x.MainIndicatorId == md.Id)
                                                             select s;
                SubIndicator = await itemsSubIndicator.ToListAsync();
                if (sId > 0)
                {
                    var subdata = await _context.SubIndicators.FirstOrDefaultAsync(x => x.Id == sId);
                    if (subdata != null)
                    {
                        TempData["Subavailable"] = "Avaialable";



                        IQueryable<Indicator> Subitems = from s in _context.Indicators.Include(x => x.IndicatorDatas).Where(x => x.IndicatorDatas.Select(x => x.LocalGovernmentId).FirstOrDefault() == id)
                                                         select s;
                        Indicators = Subitems;

                        IQueryable<IndicatorData> items = from s in _context.IndicatorDatas.Where(x => x.LocalGovernmentId == id)
                                                          select s;
                        IndicatorDatas = items;

                    }
                    else
                    {
                        return RedirectToPage("./Index", new { id = LGID, mId = MID });
                    }
                }
            }
            else
            {
                IQueryable<MainIndicator> itemsMainIndicator = from s in _context.MainIndicators
                                                               select s;
                MainIndicator = await itemsMainIndicator.ToListAsync();
            }
            return Page();
        }
    }
}
