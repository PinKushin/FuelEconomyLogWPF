using System;
using System.Windows.Controls;
using System.IO;
using FuelEconomyLogWPF.mvvm.viewmodel;
using FuelEconomyLogWPF.mvvm.model;
using FuelEconomyLogWPF.core;
using System.Windows;
using System.ComponentModel;

namespace FuelEconomyLogWPF.mvvm.view;

public partial class HomeView : UserControl
{
    // file save location / On desktop for testing Todo: Change path for production
    readonly string csvFullFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FuelEconomy.csv");
    public HomeView()
    {
        InitializeComponent();
        DataContext = MpgLogService.ReadFile(csvFullFilename);
    }
    string sep = ",";
    private void submit_Click(object sender, RoutedEventArgs e)
    {
        //Check we have input
        if (PurchaseDate.Text == null
            || Gallons.Text == null
            || Miles.Text == null
            || Price.Text == null)
        {
            return;
        }
        //Validate Input
        DateTime tmp;
        decimal dec;
        var text = PurchaseDate.Text;
        if (!DateTime.TryParse(text, out tmp)
            || !decimal.TryParse(Gallons.Text, out dec)
            || !decimal.TryParse(Miles.Text, out dec)
            || !decimal.TryParse(Price.Text, out dec))
        {
            return;
        }

        //Concatenate the text of All TextBoxes
        string csvFileContents = "\n" +
            PurchaseDate.Text.Normalize() + sep 
            + Gallons.Text.Normalize() + sep 
            + Miles.Text.Normalize() + sep 
            + Price.Text.Normalize() + sep
            + Notes.Text.Normalize();

        //Write the file to folder
        File.AppendAllText(csvFullFilename, csvFileContents);

        //Clear Input Text
        PurchaseDate.Text = string.Empty;
        Gallons.Text = string.Empty;
        Miles.Text = string.Empty;
        Price.Text = string.Empty;
        Notes.Text = string.Empty;

        //update DataContext to update UI
        DataContext = MpgLogService.ReadFile(csvFullFilename);
    }

}