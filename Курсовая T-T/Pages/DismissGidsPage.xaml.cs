using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для DismissGidsPage.xaml
    /// </summary>
    public partial class DismissGidsPage : Page
    {
        public DismissGidsPage(DismissGidsVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
