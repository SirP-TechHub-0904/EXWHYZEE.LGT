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

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.LgaPanel
{
    public class CreateMSModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public CreateMSModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Community Community { get; set; }
        public async Task<IActionResult> OnGet(long id)
        {
            Community = await _context.Communities.FirstOrDefaultAsync(x => x.Id == id);
            return Page();
        }

        [BindProperty]
        public MineralResource MineralResource { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MineralResources.Add(MineralResource);
            await _context.SaveChangesAsync();

            return RedirectToPage("./CommunityResources", new { id = MineralResource.CommunityId });
        }
    }
}
