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
        public CommandVM Dismiss { get; set; }
        public CommandVM Hire { get; set; }
        public CommandVM ListG { get; set; }
        public CommandVM ListL { get; set; }


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

            Dismiss = new CommandVM(() =>
            {
                currentPageControl.SetPage(new DismissGidsPage(new DismissGidsVM(currentPageControl)));
            });
            Hire = new CommandVM(() => {
                currentPageControl.SetPage(new HireGidsPage(new HireGidsVM(currentPageControl)));
            });
            ListG = new CommandVM(() => {
                currentPageControl.SetPage(new ListGidsPage(new ListGidsVM()));
            });
            ListL = new CommandVM(() => {
                currentPageControl.SetPage(new ListLobbyPage(new ListLobbyVM()));
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }

    }
}
