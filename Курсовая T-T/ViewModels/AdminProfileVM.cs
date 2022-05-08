using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;

namespace Курсовая_T_T.ViewModels
{
    public class AdminProfileVM : BaseVM
    {
        public Admin AdminEnter { get; set; }
        public CommandVM EnterAdmin { get; set; }

        private CurrentPageControl currentPageControl;
        public AdminProfileVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AdminEnter = new Admin();
            Init();
        }
        public AdminProfileVM(Admin adminEnter, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AdminEnter = adminEnter;
            Init();
        }

        private void Init()
        {
            EnterAdmin = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (AdminEnter.ID == 0)
                    model.Insert(AdminEnter);
                else
                    model.Update(AdminEnter);
                currentPageControl.SetPage(new AdminPage());
            });
        }
    }
}
