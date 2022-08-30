using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace LocalGovernments.Areas.Admin.Pages.IndicatorInit
{
    public class ICreateModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public ICreateModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(long id)
        {
            var x = _context.SubIndicators.Find(id);
            TempData["idd"] = x.Id;
            TempData["xx"] = x.Title;
            return Page();
        }

        [BindProperty]
        public Indicator Indicator { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Indicator.Date = DateTime.UtcNow.AddHours(1);
            _context.Indicators.Add(Indicator);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ICreate", new { id = Indicator.SubIndicatorId });
        }
    }
}
