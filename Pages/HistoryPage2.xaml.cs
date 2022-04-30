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
    /// Логика взаимодействия для HistoryPage2.xaml
    /// </summary>
    public partial class HistoryPage2 : Page
    {
        public HistoryPage2()
        {
            InitializeComponent();
        }

        private void HistoryPage_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new HistoryPage();
        }

        private void HistoryPage3_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new HistoryPage3();
        }
    }
}

