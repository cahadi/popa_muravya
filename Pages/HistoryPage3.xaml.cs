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
    /// Логика взаимодействия для HistoryPage3.xaml
    /// </summary>
    public partial class HistoryPage3 : Page
    {
        public HistoryPage3()
        {
            InitializeComponent();
        }

        private void HistoryPag2_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new HistoryPage2();
        }

        private void HistoryPage4_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new HistoryPage4();
        }
    }
}
