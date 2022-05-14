using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class SectionDocument
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IdNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiringDate { get; set; }

        public long SectionId { get; set; }
        public Section Section { get; set; }
    }
}
