namespace PlotBuilder.UI.ViewModels;

using System;
using System.Linq;
using System.Windows.Input;
using PlotBuilder.UI.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ScottPlot;

/// <summary>
/// Контекст окна <see cref="PlotBuilder"/>
/// </summary>
internal class PlotBuilderViewModel : ViewModelBase
{
    private GraphData _graphData;
    private Graph _graph;
    private ScatterGroup _selectedGroup;

    /// <summary>
    /// <see cref="GraphData"/>
    /// </summary>
    public GraphData GraphData
    {
        get => _graphData;
        set => Set(ref _graphData, value);
    }

    /// <summary>
    /// Ищменить стили
    /// </summary>
    public bool ChangeStyles
    {
        set => ChangeLineStyles(value ? MarkerShape.asterisk : MarkerShape.none);
    }

    /// <summary>
    /// Выбранный <see cref="GroupPlotData"/>
    /// </summary>
    public GroupPlotData SelectedGroupPlotData { get; set; }

    /// <summary>
    /// Набор
    /// </summary>
    public Graph Graph
    {
        get => _graph;
        set => Set(ref _graph, value);
    }

    /// <summary>
    /// Набор
    /// </summary>
    public ScatterGroup SelectedGroup
    {
        get => _selectedGroup;
        set => Set(ref _selectedGroup, value);
    }

    private void ChangeLineStyles(MarkerShape markers = MarkerShape.none)
    {
        var scatters = Graph.Groups.SelectMany(g => g.Scatters).ToList();
        foreach (var scatter in scatters)
        {
            scatter.ScatterPlot.MarkerShape = markers;
        }

        Graph.WpfPlot.Refresh();
    }
}