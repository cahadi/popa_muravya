﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeaPage6.xaml
    /// </summary>
    public partial class TeaPage6 : Page
    {
        public TeaPage6()
        {
            InitializeComponent();
        }

        private void TeaPage5_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage5();
        }

        private void TeaPage7_Click(object sender, RoutedEventArgs e)
        {
            FrameTea.Content = new TeaPage7();
        }
    }
}
