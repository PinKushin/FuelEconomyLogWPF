﻿using System;
using System.Windows.Navigation;

namespace FuelEconomyLogWPF.mvvm.model;

public struct MpgLog
{
    public DateTime PurchaseDate { get; set;  }
    public decimal Gallons { get; set; }
    public decimal Miles { get; set; }
    public decimal Cost { get; set; }
    public decimal Mpg => Miles / Gallons;
}