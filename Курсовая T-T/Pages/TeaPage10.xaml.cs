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
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeaPage10.xaml
    /// </summary>
    public partial class TeaPage10 : Page
    {
        public TeaPage10()
        {
            InitializeComponent();
            DataContext = new ViewTeaVM();
        }

        private void Tea9(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/TeaPage9.xaml", UriKind.Relative));
        }

        private void Information(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/InformationPage.xaml", UriKind.Relative));
        }
    }
}
