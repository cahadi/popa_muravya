using System.Windows;
using System.Windows.Controls;
using System.Media;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomPage7.xaml
    /// </summary>
    public partial class CustomPage7 : Page
    {
        public CustomPage7()
        {
            InitializeComponent();
        }

        private void CustomPage6_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage6();
        }

        private void CustomPage8_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage8();
        }
    }
}
