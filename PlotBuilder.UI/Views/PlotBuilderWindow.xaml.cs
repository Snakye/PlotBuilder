namespace PlotBuilder.UI.Views;

using System.Linq;
using PlotBuilder.UI.ViewModels;
using System.Windows;

/// <summary>
/// Главное окно
/// </summary>
public partial class PlotBuilderWindow : Window
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlotBuilderWindow"/> class.
    /// </summary>
    /// <param name="plotBuilderViewModel"><see cref="PlotBuilderViewModel"/></param>
    public PlotBuilderWindow(PlotBuilderViewModel plotBuilderViewModel)
    {
        InitializeComponent();

        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        var gr = plotBuilderViewModel.GraphData;
        var x = gr.XPoints;
        var y = gr.Groups.First().Graphs.First().YPoints;
        Plot.Plot.AddScatter(x.ToArray(), y.ToArray());
        Plot.Refresh();
    }
}