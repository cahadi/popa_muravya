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
using System.Media;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        private void Information(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/InformationPage.xaml", UriKind.Relative));
        }

        private void History2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/HistoryPage2.xaml", UriKind.Relative));
        }
    }
}
