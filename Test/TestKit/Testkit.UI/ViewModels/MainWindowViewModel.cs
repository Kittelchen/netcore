using System;
using System.Collections.ObjectModel;
using System.Net.Mime;
using System.Reflection;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using Common.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace Testkit.UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly IServiceProvider _serviceProvider;

    [ObservableProperty] private bool _isPaneOpen = true;
    [ObservableProperty] private ViewModelBase _currentViewModel;
    [ObservableProperty] private ListItemTemplate _selectedListItem;
    public ObservableCollection<ListItemTemplate> ListItems { get; } = new()
    {
        new ListItemTemplate(typeof(HomePageViewModel), "Home"),
        new ListItemTemplate(typeof(ButtonViewModel), "Settings")
    };
    
    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;
        var instance = _serviceProvider.GetRequiredService(value.ModelType);
        if (instance is null) return;
        CurrentViewModel =  (ViewModelBase) instance;
    }
        
    public MainWindowViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    [RelayCommand]
    private async Task TogglePane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
}

public class ListItemTemplate
{
    public ListItemTemplate(Type type, string iconKey)
    {
        ModelType = type;
        Label = type.Name.Replace("ViewModel", "");
        
        Application.Current!.TryFindResource(iconKey, out var resource);
        Icon = (StreamGeometry) resource!;
    }
    
    public Type ModelType { get; }
    public string Label { get; }
    public StreamGeometry Icon { get; set; }
}