using System.Windows;
using System.Windows.Controls;
using System.Media;
using System;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomPage7.xaml
    /// </summary>
    public partial class CustomPage7 : Page
    {
        public CustomPage7()
        {
            InitializeComponent();
        }

        private void Custom6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/CustomPage6.xaml", UriKind.Relative));
        }

        private void Custom8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/CustomPage8.xaml", UriKind.Relative));
        }
    }
}
