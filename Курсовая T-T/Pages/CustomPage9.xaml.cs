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
    /// Логика взаимодействия для CustomPage9.xaml
    /// </summary>
    public partial class CustomPage9 : Page
    {
        public CustomPage9()
        {
            InitializeComponent();
        }

        private void InformationPage_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new InformationPage();
        }

        private void CustomPage8_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage8();
        }
    }
}
