using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
   public class SubIndicator
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public long MainIndicatorId { get; set; }
        public MainIndicator MainIndicator { get; set; }
        public ICollection<Indicator> Indicators { get; set; }
    }
}
