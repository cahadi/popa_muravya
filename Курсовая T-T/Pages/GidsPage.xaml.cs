using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для GidsPage.xaml
    /// </summary>
    public partial class GidsPage : Page
    {
        public GidsPage(GidsVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
