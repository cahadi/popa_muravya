using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Media;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void InformationPage_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new InformationPage();
        }

        private void CustomPage2_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage2();
        }
    }
}
