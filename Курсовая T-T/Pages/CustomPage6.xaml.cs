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
    /// Логика взаимодействия для CustomPage6.xaml
    /// </summary>
    public partial class CustomPage6 : Page
    {
        public CustomPage6()
        {
            InitializeComponent();
        }

        private void CustomPage5_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage5();
        }

        private void CustomPage7_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage7();
        }
        
    }
}
