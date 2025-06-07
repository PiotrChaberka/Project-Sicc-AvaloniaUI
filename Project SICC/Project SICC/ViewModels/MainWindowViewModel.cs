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

    // Command to toggle the pane
    [RelayCommand]
    private void TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }


}