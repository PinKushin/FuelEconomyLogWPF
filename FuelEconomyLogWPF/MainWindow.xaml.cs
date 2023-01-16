using System;
using System.Windows;

namespace FuelEconomyLogWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void icon_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            throw new NotSupportedException("Icon Missing");
        }

        private void closeButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Minimize Window
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Move Window
        }
    }
}
