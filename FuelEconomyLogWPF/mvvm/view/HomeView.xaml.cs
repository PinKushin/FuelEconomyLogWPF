using System;
using System.Windows.Controls;
using System.IO;
using FuelEconomyLogWPF.mvvm.model;
using System.Windows;
using System.Globalization;

namespace FuelEconomyLogWPF.mvvm.view;

public partial class HomeView : UserControl
{
    // file save location: User path\MyDocuments so User can backup and restore easily
    readonly string csvFullFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FuelEconomy.csv");
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
        DateOnly tmp;
        decimal dec;
        if (!DateOnly.TryParse(PurchaseDate.Text, out tmp)
            || !decimal.TryParse(Gallons.Text, out dec)
            || !decimal.TryParse(Miles.Text, out dec)
            || !decimal.TryParse(Price.Text, out dec))
        {
            return;
        }
        //Calculate Miles Per Gallon
        decimal Mpg = decimal.Parse(Miles.Text.Normalize())
            / decimal.Parse(Gallons.Text.Normalize());
        //Concatenate the text of All TextBoxes and Mpg      
        string csvFileContents = "\n" +
            PurchaseDate.Text.Normalize() + sep 
            + Gallons.Text.Normalize() + sep 
            + Miles.Text.Normalize() + sep 
            + Price.Text.Normalize() + sep
            + Notes.Text.Normalize() + sep
            + Mpg.ToString("F2", CultureInfo.InvariantCulture);

        //append the mpg log to file
        File.AppendAllText(csvFullFilename, csvFileContents);

        //Clear Input Text
        PurchaseDate.Text = string.Empty;
        Gallons.Text = string.Empty;
        Miles.Text = string.Empty;
        Price.Text = string.Empty;
        Notes.Text = string.Empty;

        //update DataTable by updating file at DataContext
        DataContext = MpgLogService.ReadFile(csvFullFilename);
    }

}