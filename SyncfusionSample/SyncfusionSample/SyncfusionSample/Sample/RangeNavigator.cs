using Syncfusion.RangeNavigator.XForms;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncfusionSample
{
    public class RangeNavigator : ContentPage
    {
        SfDateTimeRangeNavigator rangeNavigator;

        RangeNavigatorViewModel viewModel;
        public RangeNavigator()
        {
            viewModel = new RangeNavigatorViewModel();

            this.BindingContext = viewModel;

            rangeNavigator = new SfDateTimeRangeNavigator();
            rangeNavigator.Minimum = new DateTime(2015, 01, 01);
            rangeNavigator.Maximum = new DateTime(2065, 01, 01);
            rangeNavigator.ViewRangeStart = new DateTime(2015, 05, 01);
            rangeNavigator.ViewRangeEnd = new DateTime(2015, 08, 01);
            rangeNavigator.ItemsSource = viewModel.DateTimeData;
            rangeNavigator.XBindingPath = "Date";
            rangeNavigator.YBindingPath = "Value";
            (rangeNavigator.Content as SfChart).Series.Clear();
            this.Content = rangeNavigator;
        }
    }
}
