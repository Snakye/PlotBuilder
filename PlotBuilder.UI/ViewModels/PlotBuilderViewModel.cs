namespace PlotBuilder.UI.ViewModels;

using PlotBuilder.UI.Models;
using GalaSoft.MvvmLight;

/// <summary>
/// Контекст окна <see cref="PlotBuilder"/>
/// </summary>
public class PlotBuilderViewModel : ViewModelBase
{
    private GraphData _graphData;

    /// <summary>
    /// <see cref="GraphData"/>
    /// </summary>
    public GraphData GraphData
    {
        get => _graphData;
        set => Set(ref _graphData, value);
    }

    /// <summary>
    /// Выбранный <see cref="GroupPlotData"/>
    /// </summary>
    public GroupPlotData SelectedGroupPlotData { get; set; }
}