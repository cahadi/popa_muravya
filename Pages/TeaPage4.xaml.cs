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
    /// Логика взаимодействия для TeaPage4.xaml
    /// </summary>
    public partial class TeaPage4 : Page
    {
        public TeaPage4()
        {
            InitializeComponent();
        }

        private void TeaPage3_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage3();
        }

        private void TeaPage5_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage5();
        }
    }
}
