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
        public CommandVM ViewInfo { get; set; }
        public CommandVM GidsProf { get; set; }
        public CommandVM AdminProf { get; set; }

        public MainVM()
        {
            var test = MySqlDB.GetDB();

             currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;
            Registration = new CommandVM(() =>
            {
                currentPageControl.SetPage(new UserPage(new UserVM(currentPageControl)));
            });
            ViewInfo = new CommandVM(() => {
                currentPageControl.SetPage(new InformationPage());
            });
            GidsProf = new CommandVM(() => {
                currentPageControl.SetPage(new GidsProfilePage(new GidsProfileVM(currentPageControl)));
            });
            AdminProf = new CommandVM(() => {
                currentPageControl.SetPage(new AdminProfilePage(new AdminProfileVM(currentPageControl)));
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
