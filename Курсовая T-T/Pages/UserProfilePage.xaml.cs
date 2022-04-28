using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Курсовая_T_T.DTO;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    
    public partial class UserProfilePage : Page
    {
        public UserProfilePage(Lobby selectedLobby)
        {
            DataContext = new UserProfileVM(selectedLobby);
        }
    }
}
