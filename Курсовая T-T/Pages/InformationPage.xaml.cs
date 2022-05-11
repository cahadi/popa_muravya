using System.Windows;
using System.Windows.Controls;
using System;

namespace Курсовая_T_T.Pages
{
    public partial class InformationPage : Page
    {
        public InformationPage()
        {
            InitializeComponent();
        }

        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/TeaPage.xaml", UriKind.Relative));
        }

        private void Custom_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/CustomPage.xaml", UriKind.Relative));
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/HistoryPage.xaml", UriKind.Relative));
        }

    }
}
