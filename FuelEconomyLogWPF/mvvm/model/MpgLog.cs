using System;
using System.Windows.Navigation;

namespace FuelEconomyLogWPF.mvvm.model;

public struct MpgLog
{
    public DateTime PurchaseDate { get; set;  }
    public decimal Gallons { get; set; }
    public decimal Miles { get; set; }
    public decimal Cost { get; set; }
    public decimal Mpg => Miles / Gallons;
    private const double Tax = 0.009;

    public MpgLog(DateTime purchasedate, 
        decimal gallons, 
        decimal miles, 
        decimal cost)
    {
        PurchaseDate = purchasedate;
        Gallons = gallons;
        Miles = miles;
        Cost = cost;
    }
}