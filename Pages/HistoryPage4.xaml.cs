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
    /// Логика взаимодействия для HistoryPage4.xaml
    /// </summary>
    public partial class HistoryPage4 : Page
    {
        public HistoryPage4()
        {
            InitializeComponent();
        }

        private void HistoryPag3_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new HistoryPage3();
        }

        private void InformationPage_Click(object sender, RoutedEventArgs e)
        {
            FrameHistory.Content = new InformationPage();
        }
    }
}
