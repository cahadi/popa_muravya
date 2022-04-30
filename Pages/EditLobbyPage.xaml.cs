using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    public partial class EditLobbyPage : Page
    {
        public EditLobbyPage(EditLobbyVM vm)
        {
            DataContext = vm;
        }
    }
}
