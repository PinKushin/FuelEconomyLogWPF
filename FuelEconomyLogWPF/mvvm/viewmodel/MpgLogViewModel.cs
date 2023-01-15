
using System.Collections.ObjectModel;
using FuelEconomyLogWPF.mvvm.model;

namespace FuelEconomyLogWPF.mvvm.viewmodel;

public class MpgLogViewModel
{
    private ObservableCollection<MpgLog> _mpglog;
    public ObservableCollection<MpgLog> MpgLog => _mpglog;

    public MpgLogViewModel()
    {
        _mpglog = new ObservableCollection<MpgLog>();
    }
}