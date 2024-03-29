﻿namespace PlotBuilder.UI.Models;

using System.Collections.Generic;
using ScottPlot;

/// <summary> Данные для набора графиков, у которого общая ось Y </summary>
public class SinglePlotData
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SinglePlotData"/> class.
    /// </summary>
    /// <param name="yPoints">Значения</param>
    /// <param name="yLabel">Название оси Y</param>
    /// <param name="graphName">Имя графика</param>
    public SinglePlotData(List<double> yPoints, string yLabel, string graphName)
    {
        YPoints = yPoints;
        YLabel = yLabel;
        GraphName = graphName;
    }

    /// <summary>
    /// Точки по оси Y
    /// <remarks> Каждый список соответствует своему графику </remarks>
    /// </summary>
    public List<double> YPoints { get; set; } = new ();

    /// <summary>
    /// Название оси Y
    /// </summary>
    public string YLabel { get; set; }

    /// <summary>
    /// Названия графиков
    /// </summary>
    public string GraphName { get; set; }
}