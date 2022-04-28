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
        }

        private void TeaPage6_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage6();
        }

        private void TeaPage8_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage8();
        }
    }
}
