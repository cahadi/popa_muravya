using System.Windows;
using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    public partial class UserRegistrationPage : Page
    {
        public UserRegistrationPage(RegistrationVM vm)
        {
            DataContext = vm;
        }

    }
}
