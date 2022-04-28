using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Media;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomPage5.xaml
    /// </summary>
    public partial class CustomPage5 : Page
    {
        public CustomPage5()
        {
            InitializeComponent();
        }

        private void CustomPage4_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage4();
        }

        private void CustomPage6_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage6();
        }

        private void PlayMusic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "C:/Users/ap357/OneDrive/Рабочий стол/Курсовая/Курсовая T-T/Курсовая T-T/Media/Kitajskaya_muzyka_dlya_CHajnoj_ceremonii_-_._SongHouse.me_.wav";
            sp.Load();
            sp.PlayLooping();
        }

        private void StopMusic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stop();
        }
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "C:/Users/ap357/OneDrive/Рабочий стол/Курсовая/Курсовая T-T/Курсовая T-T/Озвучка страниц/Custom/CustomPage5.wav";
            sp.Load();
            sp.PlayLooping();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stop();
        }
    }
}
