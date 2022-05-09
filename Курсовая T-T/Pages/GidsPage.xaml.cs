using System.Windows.Controls;
using Курсовая_T_T.ViewModels;
using Курсовая_T_T.Tools;
using Курсовая_T_T.DTO;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для GidsPage.xaml
    /// </summary>
    public partial class GidsPage : Page
    {
        public GidsPage()
        {
            InitializeComponent();
        }
        CurrentPageControl currentPageControl;
        private void ListL_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new ListLobbyPage(null);
        }

        private void Group_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new GroupPage(new GroupVM(currentPageControl));
        }
    }
}
