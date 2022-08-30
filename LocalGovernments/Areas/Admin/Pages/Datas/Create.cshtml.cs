using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LocalGovernments.Areas.Admin.Pages.Datas
{
    public class CreateModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CreateModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IndicatorData IndicatorData { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           // var inx = await _context.Indicators.FindAsync(IndicatorData.IndicatorId);

            IQueryable<IndicatorData> items = from s in _context.IndicatorDatas.Where(x => x.Year == "2021")
                                        select s;

           // var lga = await _context.IndicatorDatas.ToListAsync();
            foreach (var x in items) {

                Random random = new Random();
                decimal randomNumber1 = random.Next(10000, 500000);

                ////decimal randomNumber1 = System.Math.Round(Convert.ToDecimal(random.NextDouble() * (5 - 2) + 3), 1);

                //IndicatorData n = new IndicatorData();
                //n.IndicatorId = inx.Id;
                //n.Title = inx.Title;
                //n.Unit = "NILL";
                //n.Year = "2021";
                //n.PeriodInYear = "FIRST QUATER";
                //n.IndicatorSymbol = "NILL";
                //n.IndicatorValue = randomNumber1;
                //n.Date = DateTime.UtcNow.AddHours(1);
                //n.LocalGovernmentId = x.Id;
                //_context.IndicatorDatas.Add(n);

            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var inx = await _context.Indicators.FindAsync(IndicatorData.IndicatorId);

            var icc = await _context.IndicatorDatas.Where(x => x.PeriodInYear == "SECOND QUATER").ToListAsync();


            foreach (var x in icc)
            {
                //_context.IndicatorDatas.Remove(x);


            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }

        public async Task<IActionResult> OnPostCheck()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            IQueryable<IndicatorData> items = from s in _context.IndicatorDatas.Where(x => x.Year == "2021")
                                              select s;
            //int dxs = items.Count();
            //foreach (var x in items.AsQueryable())
            //{
            //    decimal xs = x.IndicatorValue / 2;
            //    decimal xsd = xs / 2;
            //    decimal ixsd = xsd / 2;
            //    decimal res = x.IndicatorValue + ixsd;


            //    IndicatorData n = new IndicatorData();
            //    n.IndicatorId = x.IndicatorId;
            //    n.Title = x.Title;
            //    n.Unit = x.Unit;
            //    n.Year = "2022";
            //    n.PeriodInYear = x.PeriodInYear;
            //    n.IndicatorSymbol = x.IndicatorSymbol;
            //    n.IndicatorValue = res;
            //    n.Date = DateTime.UtcNow.AddHours(1);
            //    n.LocalGovernmentId = x.LocalGovernmentId;
            //    _context.IndicatorDatas.Add(n);
            //}

            //await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }

    }
}
