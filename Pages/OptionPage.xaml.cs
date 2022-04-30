using System;
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
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    public partial class OptionPage : Page
    {
        public OptionPage()
        {
            InitializeComponent();
            DataContext = new SettingsVM(passwordBox);
        }
    }
}
