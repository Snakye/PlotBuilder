namespace PlotBuilder.UI.Abstractions;

using PlotBuilder.UI.Models;

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