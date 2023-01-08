namespace PlotBuilder.UI.Models;

using System;
using ScottPlot.Plottable;

/// <summary>Description</summary>
internal class SingleScatter
{
    private bool _isVisible = true;

    /// <summary>
    /// ы
    /// </summary>
    public event EventHandler VisibilityChanged;

    /// <summary>
    /// График
    /// </summary>
    public ScatterPlot ScatterPlot { get; set; }

    /// <summary>
    /// Имя графика
    /// </summary>
    public string ScatterName { get; set; }

    /// <summary>
    /// Видимость графика
    /// </summary>
    public bool IsVisible
    {
        get => _isVisible;
        set
        {
            _isVisible = value;
            ScatterPlot.IsVisible = value;
            VisibilityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}