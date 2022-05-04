using System;
using System.Windows.Controls;
using System.Collections.Generic;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;

namespace Курсовая_T_T.ViewModels
{
    public class DismissGidsVM : BaseVM
    {
        public CommandVM Back;

        private List<Gids> dismissGids;
        public List<Gids> DismissGids
        {
            get => dismissGids;
            set
            {
                dismissGids = value;
                Signal();
            }
        }

        private CurrentPageControl currentPageControl;
        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public DismissGidsVM()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;

            Back = new CommandVM(() =>
            {
                currentPageControl.SetPage(new AdminPage(new AdminVM()));
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
