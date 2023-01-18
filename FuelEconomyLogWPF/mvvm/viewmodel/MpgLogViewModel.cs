using System.Collections.ObjectModel;
using FuelEconomyLogWPF.core;
using FuelEconomyLogWPF.mvvm.model;


namespace FuelEconomyLogWPF.mvvm.viewmodel;

public class MpgLogViewModel : ObservableObject 
{
    private readonly ObservableCollection<MpgLog> _mpglog;
    public ObservableCollection<MpgLog> MpgLog => _mpglog;

    public MpgLogViewModel()
    {
        _mpglog = new ObservableCollection<MpgLog>();
    }
}