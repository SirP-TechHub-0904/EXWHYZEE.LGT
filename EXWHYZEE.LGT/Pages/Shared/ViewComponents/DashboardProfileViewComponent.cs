
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using LIBRARY.EXWHYZEE.LGT.Data;

namespace EXWHYZEE.LGT.Pages.Shared.ViewComponents
{
    public class DashboardProfileViewComponent : ViewComponent
    {
        private readonly UserManager<Profile> _userManager;

        private readonly ApplicationDbContext _context;


        public DashboardProfileViewComponent(
            UserManager<Profile> userManager,
            ApplicationDbContext context
           
            /*IEmailSender emailSender*/)
        {
            _userManager = userManager;
            _context = context;
        }

        public string UserInfo{ get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                var profile = await _context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);


                if (profile != null)
                {
                    TempData["data"] = profile.Surname + " " + profile.Firstname + " " + profile.Middlename;
                    //TempData["sponsor"] = profile.Sponsor;
                    //    TempData["img"] = profile.ParticipanPicture;
                }

            }
            return View();
        }
    }
}
