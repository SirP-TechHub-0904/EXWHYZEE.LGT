using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime DateStart { get; set; }
        public string CategoryProfile { get; set; }
        public string ContactAddress { get; set; }
        public ICollection<CategoryExecutive> CategoryExecutives { get; set; }
        public ICollection<Section> Sections { get; set; }
        public int SortOrder { get; set; }

        public long LocalGovernmentId { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
    }
}
