using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class HireGidsVM : BaseVM
    {
        public Gids RegistrationGids { get; set; }
        public CommandVM SaveGids { get; set; }

        private CurrentPageControl currentPageControl;

        public HireGidsVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            RegistrationGids = new Gids();
            Init();
        }
        public HireGidsVM(Gids registrationGids, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            RegistrationGids = registrationGids;
            Init();
        }

        private void Init()
        {
            SaveGids = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (RegistrationGids.ID == 0)
                    model.Insert(RegistrationGids);
                currentPageControl.Back();
            });
        }
    }
}
