namespace FuelEconomyLogWPF.mvvm.view;

public partial class GraphView
{
    public GraphView()
    {
        InitializeComponent();
        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        FuelPlot.Plot.Title("Fuel Economy");
        FuelPlot.Plot.XLabel("Date");
        FuelPlot.Plot.YLabel("Miles Per Gallon");
        FuelPlot.Plot.AddScatter(dataX, dataY);
        FuelPlot.Plot.Style(ScottPlot.Style.Black);
        FuelPlot.Refresh();
    }
}