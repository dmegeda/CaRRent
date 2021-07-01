using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaRRent.PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.NavigationService.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }

        private void ToHomePage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }

        private void ToAuthPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Uri("Pages/AuthPage.xaml", UriKind.Relative));
        }

        private void ToStatisticPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Uri("Pages/StatisticPage.xaml", UriKind.Relative));
        }

        private void ToUserRentals_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Uri("Pages/UserRentalsPage.xaml", UriKind.Relative));
        }
    }
}
