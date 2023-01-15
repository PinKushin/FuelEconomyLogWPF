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

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
