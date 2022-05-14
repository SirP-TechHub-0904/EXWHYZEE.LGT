using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class State
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public ICollection<LocalGovernment> LocalGovernments { get; set; }
    }
}
