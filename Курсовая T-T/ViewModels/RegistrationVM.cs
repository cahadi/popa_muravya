using System;
using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;


namespace Курсовая_T_T.ViewModels
{
    public class RegistrationVM : BaseVM
    {
        public User RegistrUser { get; }
        public CommandVM SaveUser { get; set; }
        

        private CurrentPageControl currentPageControl;

        public RegistrationVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            RegistrUser = new User();
        }

        public RegistrationVM(User registrUser, CurrentPageControl currentPageControl)
        {
            RegistrUser = registrUser;
            this.currentPageControl = currentPageControl;
        }
        
    }
}
