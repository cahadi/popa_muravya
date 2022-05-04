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
        public CommandVM GidsProfile { get; set; }
        public CommandVM AdminProfile { get; set; }

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
            GidsProfile = new CommandVM(() => {
                currentPageControl.SetPage(new GidsProfilePage(new GidsProfileVM(currentPageControl)));
            });
            AdminProfile = new CommandVM(() => {
                currentPageControl.SetPage(new AdminProfilePage(new AdminProfileVM(currentPageControl)));
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
