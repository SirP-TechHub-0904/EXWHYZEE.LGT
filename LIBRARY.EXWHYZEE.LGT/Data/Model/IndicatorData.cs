using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
   public class IndicatorData
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
        public string Year { get; set; }
        public string PeriodInYear { get; set; }
        public string IndicatorSymbol { get; set; }
        public Decimal IndicatorValue { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }

        public long LocalGovernmentId { get; set; }
        public LocalGovernment LocalGovernment { get; set; }
        public string DataSource { get; set; }

        public long IndicatorId { get; set; }
        public Indicator Indicator { get; set; }

    }
}
