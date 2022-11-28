using PlotBuilder.UI.Models;

namespace PlotBuilder.UI.Abstractions;

/// <summary>
/// Сервис запуска PlotBuilder
/// </summary>
public interface IPlotBuilderExecutor
{
    /// <summary>
    /// Запускает PlotBuilder
    /// </summary>
    /// <param name="graphData"><see cref="GraphData"/></param>
    public void ExecutePlotBuilder(GraphData graphData);
}