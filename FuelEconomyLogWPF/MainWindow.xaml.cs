using System.Windows;
using System.Windows.Input;

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

        private void closeButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Minimize Window
            this.WindowState = WindowState.Minimized;
        }

        private void MoveButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Move Window
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void maximizeButton_Click(object sender, RoutedEventArgs e)
        {
            //Toggle fullscreen
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                return;
            }
            this.WindowState = WindowState.Maximized;
        }
    }
}
