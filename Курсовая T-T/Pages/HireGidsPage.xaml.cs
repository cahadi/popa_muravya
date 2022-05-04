using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для HireGidsPage.xaml
    /// </summary>
    public partial class HireGidsPage : Page
    {
        public HireGidsPage(HireGidsVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
