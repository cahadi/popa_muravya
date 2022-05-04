﻿using System.Windows.Controls;
using Курсовая_T_T.ViewModels;


namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage(AdminVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
