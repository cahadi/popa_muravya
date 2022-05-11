using System.Windows;
using Курсовая_T_T.Tools;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using System.Windows.Controls;
using Курсовая_T_T.Pages;
using System.Media;
using System;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomPage.xaml
    /// </summary>
    public partial class CustomPage : Page
    {
        public CustomPage()
        {
            InitializeComponent();
        }

        private void ViewInfo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/InformationPage.xaml", UriKind.Relative));
        }

        private void CustomT(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/CustomPage2.xaml", UriKind.Relative));
        }
    }
}
