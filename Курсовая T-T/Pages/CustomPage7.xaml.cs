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
        private void PlayMusic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "C:/Users/ap357/OneDrive/Рабочий стол/Курсовая/Курсовая T-T/Курсовая T-T/Озвучка страниц/Custom/CustomPage7.wav";
            sp.Load();
            sp.PlayLooping();
        }

        private void StopMusic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stop();
        }
    }
}
