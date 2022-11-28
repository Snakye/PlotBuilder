using System.Collections.Generic;
using ScottPlot;

namespace PlotBuilder.UI.Models;

/// <summary> Данные для набора графиков, у которого общая ось Y </summary>
public class SinglePlotData
{
    public SinglePlotData(List<double> yPoints, string yLabel, string graphName, MarkerShape markerShape = MarkerShape.none)
    {
        YPoints = yPoints;
        YLabel = yLabel;
        GraphName = graphName;
        MarkerShape = markerShape;
    }
    
    /// <summary>
    /// Точки по оси Y
    /// <remarks> Каждый список соответствует своему графику </remarks>
    /// </summary>
    public List<double> YPoints { get; set; } = new();
    
    /// <summary>
    /// Название оси Y
    /// </summary>
    public string YLabel { get; set; }
    
    /// <summary>
    /// Названия графиков
    /// </summary>
    public string GraphName { get; set; }
    
    /// <summary>
    /// Вид точек графиков
    /// </summary>
    public MarkerShape MarkerShape { get; set; }
}