using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LIBRARY.EXWHYZEE.LGT.Data.Model;
using LIBRARY.EXWHYZEE.LGT.Data;

namespace EXWHYZEE.LGT.Areas.AdminPage.Pages.Users
{

    [AllowAnonymous]
    public class UpdateParametersModel : PageModel
    {
        private readonly SignInManager<Profile> _signInManager;
        private readonly UserManager<Profile> _userManager;
        private readonly ILogger<NewAccountModel> _logger;
        private readonly ApplicationDbContext _context;


        public UpdateParametersModel(
            UserManager<Profile> userManager,
            SignInManager<Profile> signInManager,
            ILogger<NewAccountModel> logger, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }



        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<LocalGovernment> LGAsC = from s in _context.LocalGovernments
                                                .Include(x=>x.State)
                                                                  .OrderByDescending(x => x.Name)
                                                select s;
            foreach (var i in LGAsC)
            {
                i.Color = AddColor(i.Name);
                _context.Attach(i).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                Community Community = new Community();
                Community.Title = "COMMUNITY ONE";
                Community.LocalGovernmentId = i.Id;
                Community.Employed = "150";
                Community.UnEmployed = "200";
                Community.SelfEmployed = "300";
                Community.Longitude = "6.5244° N";
                Community.Latitude = "3.3792° E";
                Community.LandMass = "4,737,844 Square Meters";
                Community.Populations = "2.4 Million";
                Community.Female = "1.4 Million";
                Community.Male = "1 Million";
                _context.Communities.Add(Community);


                Community Community2 = new Community();
                Community2.Title = "COMMUNITY TWO";
                Community2.LocalGovernmentId = i.Id;
                Community2.Employed = "1500";
                Community2.UnEmployed = "2000";
                Community2.SelfEmployed = "3000";
                Community2.Longitude = "6.5244° N";
                Community2.Latitude = "3.3792° E";
                Community2.LandMass = "4,737,844 Square Meters";
                Community2.Populations = "2.4 Million";
                Community2.Female = "1.4 Million";
                Community2.Male = "1 Million";
                _context.Communities.Add(Community2);

                await _context.SaveChangesAsync();

                var comupdate = await _context.Communities.Where(x => x.LocalGovernmentId == i.Id).ToListAsync();
                foreach(var c in comupdate)
                {
                    MineralResource R = new MineralResource();
                    R.CommunityId = c.Id;
                    R.Title = "Gold";
                    R.Description = "Gold was our heritage in"+ i.Name;
                    R.StartDate = DateTime.UtcNow.AddYears(-70);
                    R.StartDate = DateTime.UtcNow.AddYears(70);
                    _context.MineralResources.Add(R);

                    MineralResource R2 = new MineralResource();
                    R2.CommunityId = c.Id;
                    R2.Title = "Silver";
                    R2.Description = "Silver was our heritage in" + i.Name;
                    R2.StartDate = DateTime.UtcNow.AddYears(-50);
                    R2.StartDate = DateTime.UtcNow.AddYears(70);
                    _context.MineralResources.Add(R2);

                    MineralResource R3 = new MineralResource();
                    R3.CommunityId = c.Id;
                    R3.Title = "Crude Oil";
                    R3.Description = "Crude Oil was our heritage in" + i.Name;
                    R3.StartDate = DateTime.UtcNow.AddYears(-70);
                    R3.StartDate = DateTime.UtcNow.AddYears(70);
                    _context.MineralResources.Add(R3);
                    await _context.SaveChangesAsync();

                }
                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "SECURITY";
                    C.Name = "SECURITY";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "SECURITY";
                    C.ContactAddress = "Central Area of" + i.Name+ "LGA";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "VIGILANTE GROUP ONE";
                    S.CategoryId = C.Id;
                    S.Description = "VIGILANTE GROUP ONE";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "VIGILANTE GROUP TWO";
                    S1.CategoryId = C.Id;
                    S1.Description = "VIGILANTE GROUP TWO";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    await _context.SaveChangesAsync();

                }catch(Exception d)
                {

                }

                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "TRADITIONAL INSTITUTION";
                    C.Name = "TRADITIONAL INSTITUTION";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "EMIR";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "OHANAEZE";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = "IGWE";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }


                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "POLICE STATIONS";
                    C.Name = "POLICE STATIONS";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "ZONE 9";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "ZONE 2";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = "ZONE 8";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }



                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "PRIMARY SCHOOLS";
                    C.Name = "PRIMARY SCHOOLS";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "NYANYA NURSERY AND PRIMARY SCHOOL";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "FEDERAL PRIMARY SCHOOL";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = "COMMUNITY PRIMARY SCHOOL";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }



                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "SECONDARY SCHOOLS";
                    C.Name = "";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "COMMUNITY SCONDARY SCHOOL";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "COMMUNITY TECHNICAL SCHOOL";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                   
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }



                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "OTHER GOVT INSTITUTES";
                    C.Name = "";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "MINISTRY OF HEALTH";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "MINISTRY OF EDUCATION";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = "MINISTRY OF YOUTH";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }



                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "HOSPITAL/CLINICS";
                    C.Name = "";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "FMC" + i.State.Title;
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = i.State.Title +" TEACHING HOSPITAL";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = i.State.Title + " DENTAL CLINIC";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }



                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "INDUSTRIES";
                    C.Name = "";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "COTTON INDUSTRY";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "MINING INDUSTRY";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                   
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }
                ///
                ///
                //
                //
                try
                {
                    Category C = new Category();
                    C.Title = "NGOS";
                    C.Name = "";
                    C.DateStart = DateTime.UtcNow.AddHours(-90);
                    C.CategoryProfile = "";
                    C.ContactAddress = "";
                    C.SortOrder = 99;
                    C.LocalGovernmentId = i.Id;
                    _context.Categories.Add(C);
                    await _context.SaveChangesAsync();

                    Section S = new Section();
                    S.Title = "JUNIOR CHAMBER INTERNATIONAL";
                    S.CategoryId = C.Id;
                    S.Description = "";
                    S.FullAddress = "";
                    S.DateStart = DateTime.UtcNow.AddYears(-20);
                    S.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S);

                    Section S1 = new Section();
                    S1.Title = "WOMEN IN GROWTH INITIATIVE";
                    S1.CategoryId = C.Id;
                    S1.Description = "";
                    S1.FullAddress = "";
                    S1.DateStart = DateTime.UtcNow.AddYears(-20);
                    S1.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S1);

                    Section S2 = new Section();
                    S2.Title = "LOCAL GOVERNMENT YOURTH EMPOWERMENT";
                    S2.CategoryId = C.Id;
                    S2.Description = "";
                    S2.FullAddress = "";
                    S2.DateStart = DateTime.UtcNow.AddYears(-20);
                    S2.DateEnd = DateTime.UtcNow.AddYears(90);
                    _context.Sections.Add(S2);
                    await _context.SaveChangesAsync();

                }
                catch (Exception d)
                {

                }


            }
            await _context.SaveChangesAsync();

            return Page();
        }

        public string AddColor(string name)
        {
            string a = "bg-success"; string b = "bg-danger"; string c = "bg-warning"; string d = "bg-info"; string e = "bg-primary"; string f = "bg-dark";
            string g = "bg-primary"; string h = "bg-success"; string i = "bg-danger"; string j = "bg-warning"; string k = "bg-info"; string l = "bg-dark";
            string m = "bg-secondary"; string n = "bg-primary"; string o = "bg-dark"; string p = "bg-danger"; string q = "bg-warning"; string r = "bg-info";
            string s = "bg-secondary"; string t = "bg-dark"; string u = "bg-info"; string v = "bg-success"; string w = "bg-danger"; string x = "bg-warning";
            string y = "bg-secondary"; string z = "bg-info";

            string color = "bg-primary";

            if (name.Substring(0, 1) == a)
            {
                return a;
            }
            else if (name.Substring(0, 1) == b)
            {
                return b;
            }
            else if (name.Substring(0, 1) == c)
            {
                return c;
            }
            else if (name.Substring(0, 1) == d)
            {
                return d;
            }
            else if (name.Substring(0, 1) == e)
            {
                return e;
            }
            else if (name.Substring(0, 1) == f)
            {
                return f;
            }
            else if (name.Substring(0, 1) == g)
            {
                return g;
            }
            else if (name.Substring(0, 1) == h)
            {
                return h;
            }
            else if (name.Substring(0, 1) == i)
            {
                return i;
            }
            else if (name.Substring(0, 1) == j)
            {
                return j;
            }
            else if (name.Substring(0, 1) == k)
            {
                return k;
            }
            else if (name.Substring(0, 1) == l)
            {
                return l;
            }
            else if (name.Substring(0, 1) == m)
            {
                return m;
            }
            else if (name.Substring(0, 1) == n)
            {
                return n;
            }
            else if (name.Substring(0, 1) == o)
            {
                return o;
            }
            else if (name.Substring(0, 1) == p)
            {
                return p;
            }
            else if (name.Substring(0, 1) == q)
            {
                return q;
            }
            else if (name.Substring(0, 1) == r)
            {
                return r;
            }
            else if (name.Substring(0, 1) == s)
            {
                return s;
            }
            else if (name.Substring(0, 1) == t)
            {
                return t;
            }
            else if (name.Substring(0, 1) == u)
            {
                return u;
            }
            else if (name.Substring(0, 1) == v)
            {
                return v;
            }
            else if (name.Substring(0, 1) == w)
            {
                return w;
            }
            else if (name.Substring(0, 1) == x)
            {
                return x;
            }
            else if (name.Substring(0, 1) == y)
            {
                return y;
            }
            else if (name.Substring(0, 1) == z)
            {
                return z;
            }

            else
            {
                return "bg-primary";
            }


        }

    }
}
