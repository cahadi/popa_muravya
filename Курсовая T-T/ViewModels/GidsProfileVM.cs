using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;

namespace Курсовая_T_T.ViewModels
{
    public class GidsProfileVM : BaseVM
    {
        public Gids GidsEnter { get; set; }
        public CommandVM EnterGids { get; set; }

        private CurrentPageControl currentPageControl;
        public GidsProfileVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            GidsEnter = new Gids();
            Init();
        }
        public GidsProfileVM(Gids gidsEnter, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            GidsEnter = gidsEnter;
            Init();
        }

        private void Init()
        {
            EnterGids = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (GidsEnter.ID == 0)
                    model.Insert(GidsEnter);
                else
                    model.Update(GidsEnter);
                currentPageControl.SetPage(new GidsPage());
            });
        }
    }
}
