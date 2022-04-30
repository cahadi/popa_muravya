using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    class UserProfileVM : BaseVM
    {
        private Lobby selectedLobby;
        private List<User> userBySelectedLobby;

        public List<Lobby> Lobby { get; set; }
        public Lobby SelectedLobby
        {
            get => selectedLobby;
            set
            {
                selectedLobby = value;
                userBySelectedLobby = SqlModel.GetInstance().SelectUser();
                Signal();
            }
        }
        public List<User> UserBySelectedLobby
        {
            get => userBySelectedLobby;
            set
            {
                userBySelectedLobby = value;
                Signal();
            }
        }
        public User SelectedUser { get; set; }
        public UserProfileVM(Lobby selectedLobby)
        {
            SqlModel sqlModel = SqlModel.GetInstance();
            SelectedLobby = Lobby.FirstOrDefault(s => s.ID == selectedLobby?.ID);
        }

    }
}
    
