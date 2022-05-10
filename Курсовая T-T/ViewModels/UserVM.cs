using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class UserVM : BaseVM
    {
        public User Registration { get; }
        public CommandVM SaveUser { get; set; }
        public Tour UserTour
        {
            get => userTour;
            set
            {
                userTour = value;
                Signal();
            }
        }

        public List<Tour> Tours { get; set; }

        private CurrentPageControl currentPageControl;
        private Tour userTour;

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
            UserTour = Tours.FirstOrDefault(s => s.ID == registration.IdTour);
        }

        private void Init()
        {
            Tours = SqlModel.GetInstance().SelectTourRange(0, 100);
            SaveUser = new CommandVM(() => {
                if (UserTour == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать тур для продолжения");
                    return;
                }
                Registration.IdTour = UserTour.ID;
                var model = SqlModel.GetInstance();
                if (UserTour.ID == 0)
                    model.Insert(UserTour);
                currentPageControl.Back();
            });
        }
    }
}
