using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class UserVM : BaseVM
    {
        public User Registration { get; set; }
        public CommandVM SaveUser { get; set; }
        private Tour userTour;
        public Tour UserTour
        {
            get => userTour;
            set
            {
                userTour = value;
                Signal();
            }
        }


        public List<Tour> Tour { get; set; }
        private CurrentPageControl currentPageControl;

        public UserVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            Registration = new User();
            Init();
        }
        public UserVM(User registration, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            Registration = registration;
            Init();
            UserTour = Tour.FirstOrDefault(t => t.IdTour == registration.IdTour);
        }

        private void Init()
        {
            Tour = SqlModel.GetInstance().SelectTourRange(0, 100);
            SaveUser = new CommandVM(() => {
                if (UserTour == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать тур для продолжения");
                    return;
                }
                Registration.IdTour = UserTour.ID;
                var model = SqlModel.GetInstance();
                if (Registration.ID == 0)
                    model.Insert(Registration);
                else
                    model.Update(Registration);
                currentPageControl.Back();
            });
        }
    }
}
