using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class SectionExecutive
    {

        public long Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public long SectionId { get; set; }
        public Section Section { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
