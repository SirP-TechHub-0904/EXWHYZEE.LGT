using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class Community
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LandMass { get; set; }

        public string Populations { get; set; }
        public string Male { get; set; }
        public string Female { get; set; }
        public string SelfEmployed { get; set; }
        public string Employed { get; set; }
        public string UnEmployed { get; set; }


        public long LocalGovernmentId { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
        public ICollection<CommunityExecutive> CommunityExecutives { get; set; }
        public ICollection<MineralResource> MineralResources { get; set; }
    }
}
