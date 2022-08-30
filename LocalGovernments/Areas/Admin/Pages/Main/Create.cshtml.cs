﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;

namespace LocalGovernments.Areas.Admin.Pages.Main
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
        public MainIndicator MainIndicator { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            MainIndicator.Date = DateTime.UtcNow.AddHours(1);
            _context.MainIndicators.Add(MainIndicator);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
