using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class AppRole : IdentityRole<string>
    {
       public string Description { get; set; }
    }
}
