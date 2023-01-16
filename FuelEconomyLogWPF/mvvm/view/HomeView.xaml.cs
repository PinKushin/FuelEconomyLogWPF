using System;
using System.Windows.Controls;
using System.IO;
using FuelEconomyLogWPF.mvvm.viewmodel;
using FuelEconomyLogWPF.mvvm.model;
using FuelEconomyLogWPF.core;

namespace FuelEconomyLogWPF.mvvm.view;

public partial class HomeView : UserControl
{
    //File Path Desktop for testing
    // Todo: change file save location
    readonly string csvFullFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FuelEconomy.csv");
    public HomeView()
    {
        InitializeComponent();
        DataContext = MpgLogService.ReadFile(csvFullFilename);
    }
    string sep = ",";
    private void submit_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        
        //Concatenate the text of All TextBoxes
        string csvFileContents = "\n" +
            PurchaseDate.Text + sep 
            + Gallons.Text + sep 
            + Miles.Text + sep 
            + Price.Text + sep
            + Notes.Text;

        //Write the file to folder
        File.AppendAllText(csvFullFilename, csvFileContents);
        ((MainWindow)System.Windows.Application.Current.MainWindow).UpdateLayout();
    }

}