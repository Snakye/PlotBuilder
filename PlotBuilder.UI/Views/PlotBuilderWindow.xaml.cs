namespace PlotBuilder.UI.Views;

using System.Collections.Generic;
using System.Linq;
using PlotBuilder.UI.ViewModels;
using System.Windows;
using Models;

/// <summary>
/// Главное окно
/// </summary>
public partial class PlotBuilderWindow : Window
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlotBuilderWindow"/> class.
    /// </summary>
    /// <param name="plotBuilderViewModel"><see cref="PlotBuilderViewModel"/></param>
    internal PlotBuilderWindow(PlotBuilderViewModel plotBuilderViewModel)
    {
        InitializeComponent();
        DataContext = plotBuilderViewModel;

        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        var gr = plotBuilderViewModel.GraphData;
        var x = gr.XPoints;
        var y = gr.Groups.First().Graphs.First().YPoints;
        var single = new SingleScatter
        {
            ScatterPlot = Plot.Plot.AddScatter(x.ToArray(), y.ToArray()),
            ScatterName = "График 1"
        };

        var group = new ScatterGroup() { GroupName = "Группа 1" };
        group.Scatters.Add(single);

        var graph = new Graph(Plot, new List<ScatterGroup>() { group });
        plotBuilderViewModel.Graph = graph;

        graph.WpfPlot.Refresh();
    }
}