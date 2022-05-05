﻿using System.Collections.Generic;
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
        private Tour selectTours;
        public Tour SelectTours
        {
            get => selectTours;
            set
            {
                selectTours = value;
                Signal();
            }
        }


        public List<Tour> Tours { get; set; }
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
            SelectTours = Tours.FirstOrDefault(t => t.TypeOfTour == registration.TypeOfTour);
        }

        private void Init()
        {
            Tours = SqlModel.GetInstance().SelectTourRange(0, 100);
            SaveUser = new CommandVM(() => {
                if (SelectTours == null)
                {
                    System.Windows.MessageBox.Show("Нужно выбрать тип тура для продолжения");
                    return;
                }
                Registration.TypeOfTour = SelectTours.TypeOfTour;
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
