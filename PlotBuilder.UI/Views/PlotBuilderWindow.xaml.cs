namespace PlotBuilder.UI.Views;

using System.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        Plot.Plot.AddScatter(dataX, dataY);
        Plot.Refresh();
    }
}