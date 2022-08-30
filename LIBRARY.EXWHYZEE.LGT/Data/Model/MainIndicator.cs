using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
   public class MainIndicator
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public ICollection<SubIndicator> SubIndicators { get; set; }
    }
}
