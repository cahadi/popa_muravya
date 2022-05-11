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
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage4.xaml
    /// </summary>
    public partial class HistoryPage4 : Page
    {
        public HistoryPage4()
        {
            InitializeComponent();
        }

        private void History3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/HistoryPage3.xaml", UriKind.Relative));
        }

        private void Information(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/InformationPage.xaml", UriKind.Relative));
        }
    }
}
