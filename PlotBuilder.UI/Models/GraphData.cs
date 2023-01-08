namespace PlotBuilder.UI.Models;

using System.Collections.Generic;
using ScottPlot;

/// <summary>Полная информация, для построения графиков</summary>
public class GraphData
{
    /// <summary>
    /// Набор <see cref="Groups"/>
    /// </summary>
    public List<GroupPlotData> Groups { get; set; }

    /// <summary>
    /// Точки по оси X
    /// </summary>
    public List<double> XPoints { get; set; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }
}