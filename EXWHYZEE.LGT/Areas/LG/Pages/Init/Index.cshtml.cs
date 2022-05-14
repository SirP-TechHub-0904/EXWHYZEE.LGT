using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.AspNetCore.Identity;

namespace EXWHYZEE.LGT.Areas.LG.Pages.Init
{
    public class IndexModel : PageModel
    {
        private readonly LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;

        public IndexModel(LIBRARY.EXWHYZEE.LGT.Data.ApplicationDbContext context, UserManager<Profile> userManager = null)
        {
            _context = context;
            _userManager = userManager;
        }

        public PaginatedList<LocalGovernment> LocalGovernment { get; set; }
        public LocalGovernment LocalGovernmentDemo { get; set; }
        public IQueryable<SpecialProjectCategory> SpecialProjectCategory { get; set; }

        public int Count { get; set; }

        public int PageSize { get; set; }
       

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public int? CurrentPage { get; set; }
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public bool ShowFirst => CurrentPage != 1;
        public bool ShowLast => CurrentPage != TotalPages;


        public int TotalLGA { get; set; }
        public int TotalCommunities { get; set; }
        public int TotalPrimaries { get; set; }
        public decimal TotalDisbursed { get; set; }
        public int TotalLgaStaff { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {

            //
            string uidsdata = _userManager.GetUserId(HttpContext.User);

            CurrentFilter = searchString;
            CurrentSort = sortOrder;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            IQueryable<LocalGovernment> LGAs = from s in _context.LocalGovernments
                                        .Include(x=>x.State)
                                               select s;

            LocalGovernmentDemo = await LGAs.FirstOrDefaultAsync(x => x.Name == "DEMO");
            if (!String.IsNullOrEmpty(searchString))
            {


                LGAs = LGAs.Where(s => (s.Name != null) && s.Name.ToUpper().Contains(searchString)
                        );

            }

            IQueryable<LocalGovernment> LGAsC = from s in _context.LocalGovernments
                                                .Include(x => x.State)
                                                .Include(x => x.Communities)
                                                select s;

            IQueryable<Community> Communities = from s in _context.Communities
                                                select s;

            IQueryable<LgaStaff> Lgas = from s in _context.LgaStaffs
                                                select s;

            IQueryable<LgaDisbusement> Disbuse = from s in _context.LgaDisbusements
                                            .Where(x=>x.Date.Month == DateTime.UtcNow.Month)
                                                select s;


            IQueryable<SpecialProjectCategory> xSpecialProjectCategory = from s in _context.SpecialProjectCategory
                                          .Include(x=>x.SpecialProject)
                                                 select s;

            SpecialProjectCategory = xSpecialProjectCategory;

            TotalLGA = LGAsC.Count();
            TotalCommunities = Communities.Count();
            TotalDisbursed = Disbuse.Sum(x => x.Amount);
            TotalLgaStaff = Lgas.Count();

            Count = LGAsC.Count();
            int pageSizes = 11;
            PageSize = pageSizes;

            LocalGovernment = await PaginatedList<LocalGovernment>.CreateAsync(
                LGAs.AsNoTracking(), pageIndex ?? 1, pageSizes);
            CurrentPage = pageIndex ?? 1;
            return Page();
        }

        public int CountString(string searchString)
        {
            int result = 0;

            searchString = searchString.Trim();

            if (searchString == "")
                return 0;

            while (searchString.Contains("  "))
                searchString = searchString.Replace("  ", " ");

            foreach (string y in searchString.Split(' '))

                result++;


            return result;
        }

    }
}
