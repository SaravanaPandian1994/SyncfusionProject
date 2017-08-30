using Syncfusion.RangeNavigator.XForms.UWP;
using Syncfusion.SfChart.XForms.UWP;
using Syncfusion.SfKanban.XForms.UWP;
using Syncfusion.SfSparkline.XForms.UWP;
using Syncfusion.SfSunburstChart.XForms.UWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace SyncfusionSample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            new SfChartRenderer();
            new SfRangeNavigatorRenderer();
            new SfSparklineRenderer();
            new SfSunburstChartRenderer();
            new SfKanbanRenderer();

            LoadApplication(new SyncfusionSample.App());
        }
    }
}
