using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class CommunityExecutive
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public long CommunityId { get; set; }
        public Community Community { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
