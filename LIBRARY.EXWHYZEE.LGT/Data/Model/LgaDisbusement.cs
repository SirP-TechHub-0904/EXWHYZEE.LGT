using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class LgaDisbusement
    {
        public long Id { get; set; }
        public long LocalGovernmentId { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
        public ICollection<LgaDisbusementBreakdown> LgaDisbusementBreakdowns { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string DateReceived { get; set; }
        public int Duration { get; set; }

        public string ApprovalNote { get; set; }
        public bool ApprovalStatus { get; set; }
    }
}
