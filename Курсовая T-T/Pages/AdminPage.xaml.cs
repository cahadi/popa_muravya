using System.Windows.Controls;
using Курсовая_T_T.ViewModels;
using System;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;


namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            currentPageControl = new CurrentPageControl();
        }

        private CurrentPageControl currentPageControl;
        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }


        private void Dismiss_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new DismissGidsPage(new DismissGidsVM(currentPageControl));  
        }

        private void Hire_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new HireGidsPage(new HireGidsVM(currentPageControl));
        }

        private void ListG_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new ListGidsPage();
        }

        private void ListL_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Frame.Content = new ListLobbyPage(null);
        }
    }
}
