using System.Windows;
using Курсовая_T_T.Tools;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using System.Windows.Controls;
using Курсовая_T_T.ViewModels;
using Курсовая_T_T.Pages;
using System.Media;

namespace Курсовая_T_T
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
        
    }
}
