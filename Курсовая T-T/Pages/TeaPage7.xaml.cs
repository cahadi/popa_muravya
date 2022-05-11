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
    /// Логика взаимодействия для TeaPage7.xaml
    /// </summary>
    public partial class TeaPage7 : Page
    {
        public TeaPage7()
        {
            InitializeComponent();
            DataContext = new PageVM();
        }

        private void Tea6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/TeaPage6.xaml", UriKind.Relative));
        }

        private void Tea8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/TeaPage8.xaml", UriKind.Relative));
        }
    }
}
