using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionSample
{
    public class RangeNavigatorViewModel
    {
        public ObservableCollection<RangeNavigatorModel> DateTimeData;

        public RangeNavigatorViewModel()
        {
            DateTimeData = new ObservableCollection<RangeNavigatorModel>()
            {

            new RangeNavigatorModel (new DateTime(2015, 01, 01), 14),
            new RangeNavigatorModel (new DateTime(2015, 02, 01), 54),
            new RangeNavigatorModel (new DateTime(2015, 03, 01), 23),
            new RangeNavigatorModel (new DateTime(2015, 04, 01), 53),
            new RangeNavigatorModel (new DateTime(2015, 05, 01), 25),
            new RangeNavigatorModel (new DateTime(2015, 06, 01), 32),
            new RangeNavigatorModel (new DateTime(2015, 07, 01), 78),
            new RangeNavigatorModel (new DateTime(2015, 08, 01), 100),
            new RangeNavigatorModel (new DateTime(2015, 09, 01), 55),
            new RangeNavigatorModel (new DateTime(2015, 10, 01), 38),
            new RangeNavigatorModel (new DateTime(2015, 11, 01), 27),
            new RangeNavigatorModel (new DateTime(2015, 12, 01), 56),
            new RangeNavigatorModel (new DateTime(2016, 01, 01), 33)

            };
        }
    }
}
