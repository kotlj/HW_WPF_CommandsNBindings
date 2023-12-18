using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_WPF_CommandsNBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush brush = new SolidColorBrush();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ToGreen(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Green);
            TestBut.Background = brush;
            TestBut.Content = "Blue";
        }
        public void ToRed(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Red);
            TestBut.Background = brush;
            TestBut.Content = "Green";
        }
        public void ToBlue(object sender, RoutedEventArgs e)
        {
            brush = new SolidColorBrush(Colors.Blue);
            TestBut.Background = brush;
            TestBut.Content = "Red";
        }
    }
}