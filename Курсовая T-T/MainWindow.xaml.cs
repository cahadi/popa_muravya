using System.Windows;
using Курсовая_T_T.Tools;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.ViewModels;
using Курсовая_T_T.Pages;
using System.Media;

namespace Курсовая_T_T
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CurrentPageControl currentPageControl;
        public MainWindow()
        {
            InitializeComponent();
            //SqlModel.GetInstance().Update(new User { ID = 2, Name = "Введите имя", LastName = "Введите фамилию" });
            DataContext = new MainVM();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new UserRegistrationPage(new RegistrationVM(currentPageControl)); 
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new InformationPage();
        }

        private void EnterLobby_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new EditLobbyPage(new EditLobbyVM(currentPageControl));
        }
    }
}
