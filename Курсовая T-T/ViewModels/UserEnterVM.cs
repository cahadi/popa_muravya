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
    public class UserEnterVM : BaseVM
    {
        public User EnterUser { get; set; }
        public CommandVM Enter { get; set; }


        private CurrentPageControl currentPageControl;
        public UserEnterVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EnterUser = new User();
            InitCommand();
        }
        public UserEnterVM(User enterUser, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EnterUser = enterUser;
            InitCommand();
        }

        private void InitCommand()
        {
            Enter = new CommandVM(() =>
            {
                var model = SqlModel.GetInstance();
                if (EnterUser.ID == 0)
                    model.Insert(EnterUser);
                else
                    model.Update(EnterUser);
                currentPageControl.Back();
            });
        }
    }
}