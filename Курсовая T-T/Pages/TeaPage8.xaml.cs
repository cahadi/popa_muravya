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
    /// Логика взаимодействия для TeaPage8.xaml
    /// </summary>
    public partial class TeaPage8 : Page
    {
        public TeaPage8()
        {
            InitializeComponent();
        }

        private void TeaPage7_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage7();
        }

        private void TeaPage9_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage9();
        }
    }
}
