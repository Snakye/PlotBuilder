using System.Collections.Generic;
using ScottPlot;

namespace PlotBuilder.UI.Models;

/// <summary> Данные для набора графиков, у которого общая ось Y </summary>
public class SinglePlotData
{
    public SinglePlotData(List<List<double>> yPoints, string yLabel, List<string> graphNames, List<MarkerShape> markerShapes = null)
    {
        YPoints = yPoints;
        YLabel = yLabel;
        GraphNames = graphNames;
        MarkerShapes = markerShapes ?? new List<MarkerShape>();
    }
    
    /// <summary>
    /// Точки по оси Y
    /// <remarks> Каждый список соответствует своему графику </remarks>
    /// </summary>
    public List<List<double>> YPoints { get; set; } = new();
    
    /// <summary>
    /// Название оси Y
    /// </summary>
    public string YLabel { get; set; }
    
    /// <summary>
    /// Названия графиков
    /// </summary>
    public List<string> GraphNames { get; set; }
    
    /// <summary>
    /// Вид точек графиков
    /// </summary>
    public List<MarkerShape> MarkerShapes { get; set; }
}