using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class EditLobbyVM
    {
        public Lobby EditLobby{ get; set; }
        public CommandVM SaveLobby { get; set; }

        private CurrentPageControl currentPageControl;
        public EditLobbyVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditLobby = new Lobby();
            InitCommand();
        }
        public EditLobbyVM(Lobby editLobby, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditLobby = editLobby;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveLobby = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (EditLobby.ID == 0)
                    model.Insert(EditLobby);
                else
                    model.Update(EditLobby);
                currentPageControl.Back();
            });
        }
    }
}
