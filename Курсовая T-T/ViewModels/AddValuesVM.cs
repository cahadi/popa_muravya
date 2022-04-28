using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    class AddValuesVM: BaseVM
    {
        private Lobby selectedLobby;
        public List<User> UserArray { get; set; }
        public List<Tour> TourArray { get; set; }
        public List<Lobby> LobbyArray { get; set;}
        public Tour SelectedTour { get; set; }
        public Lobby SelectedLobby
        { get => selectedLobby;
            set
            {
                selectedLobby = value;
                UserArray = SqlModel.GetInstance().SelectUserByLobby(selectedLobby);
            }
        }
        public User SelectedUser { get; set; }
        public DateTime Day { get; set; }
        public string Value { get; set; }
        public CommandVM SaveValue { get; set; }
        public AddValuesVM()
        {
            var db = SqlModel.GetInstance();
            Day = DateTime.Now;
            TourArray = db.SelectTours();

            SaveValue = new CommandVM(() =>
            {
                if (SelectedTour == null || SelectedUser == null)
                {
                    MessageBox.Show("Данные не указаны");
                    return;
                }
                db.Insert(new Lobby
                {
                    Day = Day,
                    IdTour = SelectedTour.ID,
                    IdUser = SelectedUser.ID

                });
            });
        }
        
        
    }
}
