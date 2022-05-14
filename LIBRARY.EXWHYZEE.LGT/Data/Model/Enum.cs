using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public enum CategoryType
    {
       
        [Description("NONE")]
        NONE = 0,
        [Description("Community")]
        Community = 2,
        [Description("Applied")]
        Applied = 3,
        [Description("Pending")]
        Pending = 4,
        [Description("Completed")]
        Completed = 5,
        [Description("Cancelled")]
        Cancelled = 6,




    }
  
}