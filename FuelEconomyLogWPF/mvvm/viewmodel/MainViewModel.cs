using FuelEconomyLogWPF.core;

namespace FuelEconomyLogWPF.mvvm.viewmodel;

public class MainViewModel : ObservableObject
{
    public HomeViewModel HomeVm { get; set; }
    public GraphViewModel GraphVm { get; set; }
    public AboutViewModel AboutVm { get; set; }
    private object? _currentView;
    
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand GraphViewCommand { get; set; }
    public RelayCommand AboutViewCommand { get; set; }
    public object CurrentView
    {
        get => _currentView!;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        HomeVm = new HomeViewModel();
        GraphVm = new GraphViewModel();
        AboutVm = new AboutViewModel();
        CurrentView = HomeVm;
        HomeViewCommand = new RelayCommand(_ =>
        {
            CurrentView = HomeVm;
        });
        GraphViewCommand = new RelayCommand(_ =>
        {
            CurrentView = GraphVm;
        });
        AboutViewCommand = new RelayCommand(_ =>
        {
            CurrentView = AboutVm;
        });
    }
}