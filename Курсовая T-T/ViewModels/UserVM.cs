using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Pages;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class UserVM : BaseVM
    {
        public User Registration { get; }
        public CommandVM SaveUser { get; set; }


        private CurrentPageControl currentPageControl;

        public UserVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            Registration = new User();
            Init();
        }

        public UserVM(User registration, CurrentPageControl currentPageControl)
        {
            Registration = registration;
            this.currentPageControl = currentPageControl;
            Init();
        }

        private void Init()
        {
            SaveUser = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (Registration.ID == 0)
                    model.Insert(Registration);
                currentPageControl.SetPage(new UserProfilePage());
            });
        }
    }
}
