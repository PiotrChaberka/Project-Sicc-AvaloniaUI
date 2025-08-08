using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Project_SICC.Views;


namespace Project_SICC.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    
    // Tracks whether the left pane is open
    [ObservableProperty]
    private bool _isPaneOpen = true;
    
    // Holds the currently displayed page/viewmodel
    [ObservableProperty]
    private ViewModelBase _currentPage = new HomePageViewModel();
    
    // Used for holding the selected page on the left side menu
    [ObservableProperty]
    private ListItemTemplate? _selectedListItem;

    // It should hold the current page viewmodel instance making it so you can call upon it to update the right side panel
    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;

        var instance = Activator.CreateInstance(value.ModelType);
        if (instance is null) return;

        CurrentPage = (ViewModelBase)instance;
    }


    // Something used for checking the name of a page for the left pane panel
    public ObservableCollection<ListItemTemplate> Items { get; } = new()
    {
        new ListItemTemplate(typeof(HomePageViewModel), ("HomeRegular")),
        new ListItemTemplate(typeof(ClientsPageViewModel), ("ClientsRegular")),
        new ListItemTemplate(typeof(ContractorsPageViewModel), ("ClientsRegular")),
    };

    // Command to toggle the pane
    [RelayCommand]
    public void TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
    
}
public class ListItemTemplate
{
    public ListItemTemplate(Type type, string iconKey)
    {
        ModelType = type;
        Label = type.Name.Replace("PageViewModel", "");
        
        Application.Current!.TryFindResource(iconKey, out var res);
        ListItemIcon = (StreamGeometry)res!;
    }

    public string Label { get; }
    public Type ModelType { get; }
    public StreamGeometry ListItemIcon { get; }
}