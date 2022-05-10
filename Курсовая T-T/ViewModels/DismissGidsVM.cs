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
        public Gids DismissGids { get; set; }
        public CommandVM DismissG { get; set; }
        public CommandVM Back { get; set; }

        private CurrentPageControl currentPageControl;

        public DismissGidsVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            DismissGids = new Gids();
            Init();
        }
        public DismissGidsVM(Gids dismissGids, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            DismissGids = dismissGids;
            Init();
        }

        private void Init()
        {
            DismissG = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (DismissGids.ID == 0)
                    model.Insert(DismissGids);
                else
                    model.Update(DismissGids);
                currentPageControl.Back();
            });
        }
    }
}
