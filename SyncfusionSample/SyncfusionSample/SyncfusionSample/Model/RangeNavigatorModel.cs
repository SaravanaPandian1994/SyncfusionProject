using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionSample
{
    public class RangeNavigatorModel
    {
        public DateTime Date { get; set; }

        public double Value { get; set; }

        public RangeNavigatorModel(DateTime dateTime, double value)
        {
            Date = dateTime;
            Value = value;
        }
    }
}
