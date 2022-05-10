using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class ListLobbyVM : BaseVM
    {
        private Tour selectedTour;
        private List<User> userBySelectedTour;

        public List<Tour> Tour { get; set; }
        public Tour SelectedTour
        {
            get => selectedTour;
            set
            {
                selectedTour = value;
                UserBySelectedTour = SqlModel.GetInstance().SelectUserByTour(selectedTour);
                Signal();
            }
        }
        public List<User> UserBySelectedTour
        {
            get => userBySelectedTour;
            set
            {
                userBySelectedTour = value;
                Signal();
            }
        }
        public User SelectedUser { get; set; }

        public ListLobbyVM(Tour selectedTour)
        {
            SqlModel sqlModel = SqlModel.GetInstance();
            Tour = sqlModel.SelectTourRange(0, 100);
            SelectedTour = Tour.FirstOrDefault(u => u.ID == selectedTour?.ID);
        }
    }
}
