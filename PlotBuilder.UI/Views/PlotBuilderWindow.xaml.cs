namespace PlotBuilder.UI.Views;

using System.Windows;

/// <summary>
/// Главное окно
/// </summary>
public partial class PlotBuilderWindow : Window
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlotBuilderWindow"/> class.
    /// </summary>
    public PlotBuilderWindow()
    {
        InitializeComponent();

        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        Plot.Plot.AddScatter(dataX, dataY);
        Plot.Refresh();
    }
}