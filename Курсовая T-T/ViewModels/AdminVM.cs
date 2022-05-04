using System;
using System.Windows.Controls;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;

namespace Курсовая_T_T.ViewModels
{
    public class AdminVM : BaseVM
    {
        public CommandVM DismissGids { get; set; }
        public CommandVM HireGids { get; set; }
        public CommandVM ListGids { get; set; }
        public CommandVM ListLobby { get; set; }


        private CurrentPageControl currentPageControl;
        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public AdminVM()
        {
            var test = MySqlDB.GetDB();

            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;

            DismissGids = new CommandVM(() =>
            {
                currentPageControl.SetPage(new DismissGidsPage(new DismissGidsVM()));
            });
            HireGids = new CommandVM(() => {
                currentPageControl.SetPage(new HireGidsPage(new HireGidsVM(currentPageControl)));
            });
            ListGids = new CommandVM(() => {
                currentPageControl.SetPage(new ListGidsPage(new ListGidsVM()));
            });
            ListLobby = new CommandVM(() => {
                currentPageControl.SetPage(new ListLobbyPage(new ListLobbyVM()));
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }

    }
}
