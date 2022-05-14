using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class LgaStaff
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public Profile User { get; set; }
        public long LocalGovernmentId { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
        public string Position { get; set; }

        public DateTime EmploymentDate { get; set; }
        public DateTime RetirementDate { get; set; }
    }
}
