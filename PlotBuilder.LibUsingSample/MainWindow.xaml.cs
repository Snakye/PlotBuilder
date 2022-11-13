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

namespace PlotBuilder.LibUsingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            double[] dataY1 = new double[] { 1, 4, 9, 16, 23 };
            WpfPlot1.Plot.Title("Заголовок");
            WpfPlot1.Plot.AddScatterList(label: "1").AddRange(dataX, dataY);
            WpfPlot1.Plot.AddScatterList(label: "2").AddRange(dataX, dataY1);
            WpfPlot1.Plot.Legend();
            WpfPlot1.Plot.XAxis.Label("Ось Х");
            WpfPlot1.Refresh();
        }
    }
}