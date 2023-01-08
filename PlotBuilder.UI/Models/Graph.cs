namespace PlotBuilder.UI.Models;

using System.Collections.Generic;
using GalaSoft.MvvmLight;
using ScottPlot;

/// <summary>Description</summary>
internal class Graph : ObservableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Graph"/> class.
    /// </summary>
    /// <param name="wpfPlot"><see cref="WpfPlot"/></param>
    /// <param name="groups">Список <see cref="ScatterGroup"/></param>
    public Graph(WpfPlot wpfPlot, List<ScatterGroup> groups)
    {
        WpfPlot = wpfPlot;
        Groups = groups;
        Groups.ForEach(g =>
        {
            g.Scatters.ForEach(s =>
            {
                s.VisibilityChanged += (_, _) => WpfPlot.Refresh();
            });
        });
    }

    /// <summary>
    /// Группы графиков
    /// </summary>
    public List<ScatterGroup> Groups { get; }

    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// График
    /// </summary>
    public WpfPlot WpfPlot { get; }
}