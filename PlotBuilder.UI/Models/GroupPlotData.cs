namespace PlotBuilder.UI.Models;

using System.Collections.Generic;

/// <summary>
/// Набор <see cref="SinglePlotData"/> объединённый по общему признаку
/// <remarks>
/// Для понимания, представим квадракоптер, с каждого винта снимаются данные с датчика давления и
/// датчика скорости (предположим). Так вот <see cref="GroupPlotData"/> будет "Винт1", а
/// набор <see cref="SinglePlotData"/> будет состоять из графиков значений датчика скорости и
/// датчика давления
/// </remarks>
/// </summary>
public class GroupPlotData
{
    /// <summary>
    /// Графики
    /// </summary>
    public List<SinglePlotData> Graphs { get; set; }

    /// <summary>
    /// Имя группы
    /// </summary>
    public string GroupName { get; set; }
}