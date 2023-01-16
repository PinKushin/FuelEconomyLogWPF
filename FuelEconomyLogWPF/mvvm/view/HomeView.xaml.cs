using System;
using System.Windows.Controls;
using System.IO;
using FuelEconomyLogWPF.mvvm.viewmodel;
using static FuelEconomyLogWPF.App;
namespace FuelEconomyLogWPF.mvvm.view;

public partial class HomeView : UserControl
{
    //File Path Desktop for testing
    // Todo: change file save location
    readonly string csvFullFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.csv");
    public HomeView()
    {
        InitializeComponent();
    }
    string sep = ",";
    private void submit_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        
        //Concatenate the text of All TextBoxes
        string csvFileContents =
            PurchaseDate.Text + sep 
            + Gallons.Text + sep 
            + Miles.Text + sep 
            + Price.Text + sep
            + Notes.Text;

        //Write the file to folder
        File.AppendAllText(csvFullFilename, csvFileContents);
    }
    string[]? lines;
    private void userControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
    {
        if (!File.Exists(csvFullFilename)) 
        {
            string csvFileHeaders = "Purchase Date" + sep
                + "Gallons" + sep 
                + "Miles" + sep 
                + "Price" + sep 
                + "Notes";
            File.AppendAllText(csvFullFilename, csvFileHeaders);
        }


        try
        {
            lines = File.ReadAllLines(csvFullFilename);
            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Exception: ", ex.Message);
        }
    }
}