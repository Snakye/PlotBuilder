using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScottPlot;
using ScottPlot.Plottable;
using ScottPlot.Renderable;

namespace PlotBuilder.LibUsingSample
{
    using UI.Models;
    using UI.Services;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SignalPlot? sig1 = null;
        private Axis? axis1 = null;
        
        public MainWindow()
        {
            InitializeComponent();
            
            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            double[] dataY1 = new double[] { 1, 4, 9, 16, 23 };

            /*var spd = new SinglePlotData(dataY.ToList(), "123", "sss");
            var grp = new GroupPlotData() { Graphs = new List<SinglePlotData>() { spd } };
            var gr = new GraphData() { Groups = new List<GroupPlotData>() { grp } };
            gr.XPoints = dataX.ToList();
            var service = new PlotBuilderExecutor();
            service.ExecutePlotBuilder(gr);*/
            WpfPlot1.Plot.Title("Заголовок");
            var sig = WpfPlot1.Plot.AddSignal(dataY, label: "1");
            sig.YAxisIndex = 0;
            WpfPlot1.Plot.YAxis.Label("Primary Axis");
            
            sig1 = WpfPlot1.Plot.AddSignal(dataY1, label: "2");
            axis1 = WpfPlot1.Plot.AddAxis(Edge.Left);
            sig1.YAxisIndex = axis1.AxisIndex;
            axis1.Label("Additional Axis");
            /*WpfPlot1.Plot.YAxis.Label("Primary Axis");
            
            WpfPlot1.Plot.AddScatterList(label: "1").AddRange(dataX, dataY);
            WpfPlot1.Plot.AddScatterList(label: "2").AddRange(dataX, dataY1);
            WpfPlot1.Plot.Legend();
            WpfPlot1.Plot.XAxis.Label("Ось Х");*/
            WpfPlot1.Refresh();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            sig1.IsVisible = !sig1.IsVisible;
            axis1.IsVisible = !axis1.IsVisible;
            WpfPlot1.Refresh();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            sig1.MarkerShape = MarkerShape.hashTag;
            sig1.MarkerSize = 15;
            WpfPlot1.Refresh();
        }
    }
}