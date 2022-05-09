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
        public Tour AddTour { get; set; }
        public CommandVM SaveTour { get; set; }
        private Gids gidsList;
        public Gids GidsList
        {
            get => gidsList;
            set
            {
                gidsList = value;
                Signal();
            }
        }

        private CurrentPageControl currentPageControl;
        public AddToursVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddTour = new Tour();
            InitCommand();
        }
        public AddToursVM(Tour editTour, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddTour = editTour;
            InitCommand();
            GidsList = Gid.FirstOrDefault(t => t.ID == editTour.GidsId);
        }


        public List<Gids> Gid { get; set; }

        private void InitCommand()
        {
            Gid = SqlModel.GetInstance().SelectGidsRange(0, 100);
            SaveTour = new CommandVM(() => {
                if (GidsList == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать гида для продолжения");
                    return;
                }
                AddTour.GidsId = GidsList.ID;
                var model = SqlModel.GetInstance();
                if (AddTour.ID == 0)
                    model.Insert(AddTour);
                else
                    model.Update(AddTour);
                currentPageControl.Back();
            });
        }
    }
}
