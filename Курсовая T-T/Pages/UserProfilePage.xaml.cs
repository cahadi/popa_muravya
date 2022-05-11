using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Курсовая_T_T.Tools;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        private CurrentPageControl currentPageControl;
        public UserProfilePage( )
        {
            InitializeComponent();
            DataContext = new UserProfileVM(currentPageControl);
        }
    }
}
