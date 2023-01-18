using System;
using CsvHelper.Configuration.Attributes;

namespace FuelEconomyLogWPF.mvvm.model;

public class MpgLog
{
    [Name("Purchase Date")]
    public DateTime PurchaseDate { get; set;  }
    [Name("Gallons")]
    public decimal Gallons { get; set; }
    [Name("Miles")]
    public decimal Miles { get; set; }
    [Name("Cost")]
    public decimal Cost { get; set; }
    [Name("Notes")]
    public string? Notes { get; set; }
    [Name("Mpg")]
    public decimal Mpg { get; set; }

}