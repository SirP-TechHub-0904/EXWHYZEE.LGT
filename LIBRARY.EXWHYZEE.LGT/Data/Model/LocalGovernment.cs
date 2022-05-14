using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class LocalGovernment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Populations { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public string SelfEmployed { get; set; }
        public string Employed { get; set; }
        public string UnEmployed { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LandMass { get; set; }
        public long StateId { get; set; }
        public State State { get; set; }
        public ICollection<LocalGovtExecutive> LocalGovtExecutives { get; set; }
        public ICollection<LgaStaff> LgaStaff { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Community> Communities { get; set; }

        public string Color { get; set; }
    }
}
