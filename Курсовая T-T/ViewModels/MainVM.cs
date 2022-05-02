using System;
using System.Windows.Controls;
using Курсовая_T_T.Model;
using Курсовая_T_T.Pages;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    internal class MainVM : BaseVM
    {
        CurrentPageControl currentPageControl;

        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }
        public CommandVM Registration { get; set; }
        public CommandVM EnterLobby { get; set; }
        public CommandVM ViewLobby { get; set; }
        public CommandVM ViewInfo { get; set; }

        public MainVM()
        {
            var test = MySqlDB.GetDB();

             currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;
            Registration = new CommandVM(() =>
            {
                currentPageControl.SetPage(new UserPage(new UserVM(currentPageControl)));
            });
            EnterLobby = new CommandVM(() => {
                currentPageControl.SetPage(new EditLobbyPage(new EditLobbyVM(currentPageControl)));
            });
            ViewLobby = new CommandVM(() => {
                currentPageControl.SetPage(new ViewLobbyPage());
            });
            ViewInfo = new CommandVM(() => {
                currentPageControl.SetPage(new InformationPage());
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
