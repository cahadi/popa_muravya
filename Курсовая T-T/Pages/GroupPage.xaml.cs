using System.Windows.Controls;
using Курсовая_T_T.ViewModels;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для GroupPage.xaml
    /// </summary>
    public partial class GroupPage : Page
    {
        public GroupPage(GroupVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
