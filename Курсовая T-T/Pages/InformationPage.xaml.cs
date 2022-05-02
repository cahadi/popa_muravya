using System.Windows;
using System.Windows.Controls;

namespace Курсовая_T_T.Pages
{
    public partial class InformationPage : Page
    {
        public InformationPage()
        {
            InitializeComponent();
        }

        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            FrameInfo.Content = new TeaPage();
        }

        private void Custom_Click(object sender, RoutedEventArgs e)
        {
            FrameInfo.Content = new CustomPage();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            FrameInfo.Content = new HistoryPage();
        }

    }
}
