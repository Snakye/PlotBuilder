namespace PlotBuilder.UI.Services;

using PlotBuilder.UI.Views;
using PlotBuilder.UI.Abstractions;
using PlotBuilder.UI.Models;
using PlotBuilder.UI.ViewModels;

/// <inheritdoc />
public class PlotBuilderExecutor : IPlotBuilderExecutor
{
    /// <inheritdoc/>
    public void ExecutePlotBuilder(GraphData graphData)
    {
        var viewModel = new PlotBuilderViewModel() { GraphData = graphData };
        var window = new PlotBuilderWindow(viewModel);
        window.Show();
    }
}