using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using FuelEconomyLogWPF.mvvm.model;
using Microsoft.VisualBasic.FileIO;
using ScottPlot;

namespace FuelEconomyLogWPF.mvvm.view;

public partial class GraphView
{
    // file save location: User path\MyDocuments so User can backup and restore easily
    readonly string csvFullFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FuelEconomy.csv");
    

    public GraphView()
    {   
        InitializeComponent();
        //Create lists to hold data
        List<DateTime> DateRecords = new List<DateTime>();
        List<double> MpgRecords = new List<double>();
        //Open file and read data
        using (StreamReader reader = new StreamReader(csvFullFilename))
        using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                //Add data to date time and mpg records lists
                DateRecords.Add(csv.GetField<DateTime>("PurchaseDate"));
                MpgRecords.Add((double)csv.GetField<decimal>("Mpg"));
            }

        }

        //Label Plot and Axis
        FuelPlot.Plot.Title("Fuel Economy");
        FuelPlot.Plot.XLabel("Date");
        FuelPlot.Plot.YLabel("Miles Per Gallon");
        //Style Plot
        FuelPlot.Plot.Style(ScottPlot.Style.Black);
        FuelPlot.Plot.XAxis.DateTimeFormat(true);
        //Validate we have data
        if (DateRecords.Count <= 0 
            || MpgRecords.Count <= 0) 
        {
            return;
        }

        //Convert lists to an array of type double for plotting
        double[] Xaxis = DateRecords.Select( x => x.ToOADate()).ToArray();
        double[] Yaxis = MpgRecords.ToArray();
        //Plot Data then Refresh
        FuelPlot.Plot.AddScatter(Xaxis, Yaxis);
        FuelPlot.Refresh();
    }
}