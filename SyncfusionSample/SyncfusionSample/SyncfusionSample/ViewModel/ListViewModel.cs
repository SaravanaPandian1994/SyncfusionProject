using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionSample
{
    public class ListViewModel
    {
        public ObservableCollection<ListModel> ListData { get; set; }

        public ListViewModel()
        {
            ListData = new ObservableCollection<ListModel>();

            ListData.Add(new ListModel() { Page = "Chart" });

            ListData.Add(new ListModel() { Page = "Sparkline" });

            ListData.Add(new ListModel() { Page = "RangeNavigator" });

            ListData.Add(new ListModel() { Page = "Kanban" });

            ListData.Add(new ListModel() { Page = "SunburstChart" });
        }
    }
}
