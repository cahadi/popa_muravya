using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;

namespace Курсовая_T_T.ViewModels
{
    public class UserVM : BaseVM
    {
        public User Registration { get; set; }
        public CommandVM SaveUser { get; set; }
        public CommandVM EnterUser { get; set; }


        private CurrentPageControl currentPageControl;
        public UserVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            Registration = new User();
            InitCommand();
        }
        public UserVM(User enterUser, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            Registration = enterUser;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveUser = new CommandVM(() =>
            {
                var model = SqlModel.GetInstance();
                if (Registration.ID == 0)
                    model.Insert(Registration);
                else
                    model.Update(Registration);
                currentPageControl.Back();
            });
            EnterUser = new CommandVM(() =>
            {
                currentPageControl.SetPage(new UserEnterPage(new UserEnterVM(currentPageControl)));
            });
        }
    }
}
