
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
    public class StaffSalaryViewComponent : ViewComponent
    {
        private readonly UserManager<Profile> _userManager;

        private readonly ApplicationDbContext _context;


        public StaffSalaryViewComponent(
            UserManager<Profile> userManager,
            ApplicationDbContext context
           
            /*IEmailSender emailSender*/)
        {
            _userManager = userManager;
            _context = context;
        }

        public string UserInfo{ get; set; }

        public async Task<IViewComponentResult> InvokeAsync(long? id)
        {
            if(id != null)
            {
                var item = await _context.LgaStaffs.Where(x => x.LocalGovernmentId == id).CountAsync();
                TempData["item"] = item;
                return View();
            }
          
            return View();
        }
    }
}
