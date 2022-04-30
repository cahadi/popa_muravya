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
    /// Логика взаимодействия для TeaPage9.xaml
    /// </summary>
    public partial class TeaPage9 : Page
    {
        public TeaPage9()
        {
            InitializeComponent();
        }

        private void TeaPage8_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage8();
        }

        private void TeaPage10_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage10();
        }
    }
}
