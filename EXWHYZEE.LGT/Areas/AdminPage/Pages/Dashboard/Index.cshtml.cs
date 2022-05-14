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

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.Dashboard
{
    [Authorize(Roles = "mSuperAdmin,Admin")]

    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public int Staff { get;set; }
        public int State { get;set; }
        public int LGA { get;set; }
        public int Category { get;set; }
        public int Sections { get;set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Users.Where(x => x.Email != "jinmcever@gmail.com").CountAsync();
            State = await _context.States.CountAsync();
            LGA = await _context.LocalGovernments.CountAsync();
            Category = await _context.Categories.CountAsync();
            Sections = await _context.Sections.CountAsync();
        }
    }
}
