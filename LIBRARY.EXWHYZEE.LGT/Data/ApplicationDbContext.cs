using LIBRARY.EXWHYZEE.LGT.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data
{
    public class ApplicationDbContext : IdentityDbContext<Profile, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryExecutive> CategoryExecutives { get; set; }
        public DbSet<LocalGovernment> LocalGovernments { get; set; }
        public DbSet<LocalGovtExecutive> LocalGovtExecutives { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionExecutive> SectionExecutives { get; set; }
        public DbSet<SectionDocument> SectionDocuments { get; set; }
        public DbSet<LgaStaff> LgaStaffs { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityExecutive> CommunityExecutives { get; set; }
        public DbSet<MineralResource> MineralResources { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SpecialProject> SpecialProject { get; set; }
        public DbSet<SpecialProjectCategory> SpecialProjectCategory { get; set; }
        public DbSet<LgaDisbusement> LgaDisbusements { get; set; }
        public DbSet<LgaDisbusementBreakdown> LgaDisbusementBreakdowns { get; set; }


        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<SubIndicator> SubIndicators { get; set; }
        public DbSet<MainIndicator> MainIndicators { get; set; }
        public DbSet<IndicatorData> IndicatorDatas { get; set; }


    }
}
