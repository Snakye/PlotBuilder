namespace PlotBuilder.UI.Models;

using System.Collections.Generic;

/// <summary>Description</summary>
internal class ScatterGroup
{
    /// <summary>
    /// Графики
    /// </summary>
    public List<SingleScatter> Scatters { get; set; } = new ();

    /// <summary>
    /// Имя набора графиков
    /// </summary>
    public string GroupName { get; set; }
}