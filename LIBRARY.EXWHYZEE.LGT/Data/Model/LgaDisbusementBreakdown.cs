using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
   public class LgaDisbusementBreakdown
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ApprovalNote { get; set; }
        public bool ApprovalStatus { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string DateReceived { get; set; }
        public int Duration { get; set; }

        public long LgaDisbusementId { get; set; }
        public LgaDisbusement LgaDisbusement { get; set; }
    }
}
