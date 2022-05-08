using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Курсовая_T_T.ViewModels;
using Курсовая_T_T.Tools;

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
            Frame.Content = new ListLobbyPage();
        }

        private void Group_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new GroupPage(new GroupVM(currentPageControl));
        }
    }
}
