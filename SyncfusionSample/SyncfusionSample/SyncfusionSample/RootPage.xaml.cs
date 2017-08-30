using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SyncfusionSample
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
            listView.ItemSelected += ListView_ItemSelected; 
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((e.SelectedItem as ListModel).Page == "Chart")
            {
                Navigation.PushAsync(new ChartPage());
            }
            else if ((e.SelectedItem as ListModel).Page == "Sparkline")
            {
                Navigation.PushAsync(new SparklinePage());
            }
            else if ((e.SelectedItem as ListModel).Page == "RangeNavigator")
            {
                Navigation.PushAsync(new RangeNavigator());
            }
            if ((e.SelectedItem as ListModel).Page == "Kanban")
            {
                Navigation.PushAsync(new KanbanPage());
            }
            else if ((e.SelectedItem as ListModel).Page == "SunburstChart")
            {
                Navigation.PushAsync(new SunburstChartPage());
            }
        }
    }
}
