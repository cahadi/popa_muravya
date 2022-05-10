using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Pages;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class AddToursVM : BaseVM
    {
        public Tour AddTour { get; }
        public CommandVM SaveTour { get; set; }
        public Gids TourGid
        {
            get => tourGid;
            set
            {
                tourGid = value;
                Signal();
            }
        }

        public List<Gids> Gid { get; set; }

        private CurrentPageControl currentPageControl;
        private Gids tourGid;

        public AddToursVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddTour = new Tour();
            Init();
        }

        public AddToursVM(Tour addTour, CurrentPageControl currentPageControl)
        {
            AddTour = addTour;
            this.currentPageControl = currentPageControl;
            Init();
            TourGid = Gid.FirstOrDefault(t => t.ID == tourGid.IdGids);
        }

        private void Init()
        {
            Gid = SqlModel.GetInstance().SelectGidsRange(0, 100);
            SaveTour = new CommandVM(() => {
                if (TourGid == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать гида для продолжения");
                    return;
                }
                AddTour.IdGids = TourGid.ID;
                var model = SqlModel.GetInstance();
                if (AddTour.ID == 0)
                    model.Insert(AddTour);
                currentPageControl.SetPage(new AdminPage());
            });
        }
    }
}
