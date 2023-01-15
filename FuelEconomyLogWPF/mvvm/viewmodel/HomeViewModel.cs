using System;
using System.ComponentModel;
using FuelEconomyLogWPF.core;

namespace FuelEconomyLogWPF.mvvm.viewmodel;

public class HomeViewModel : ObservableObject
{
    private DateTime _purchasedate;
    private int _gallons;
    private int _miles;
    private int _cost;

    public DateTime PurchaseDate
    {
        get => _purchasedate;
        set => _purchasedate = value;
    }

    public event PropertyChangedEventHandler PropertyChanged;
}