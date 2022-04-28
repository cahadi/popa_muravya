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
using System.Media;

namespace Курсовая_T_T.Pages
{
    /// <summary>
    /// Логика взаимодействия для CustomPage4.xaml
    /// </summary>
    public partial class CustomPage4 : Page
    {
        public CustomPage4()
        {
            InitializeComponent();
        }

        private void CustomPage3_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage3();
        }

        private void CustomPage5_Click(object sender, RoutedEventArgs e)
        {
            FrameCustom.Content = new CustomPage5();
        }
        private void PlayMusic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "C:/Users/ap357/OneDrive/Рабочий стол/Курсовая/Курсовая T-T/Курсовая T-T/Озвучка страниц/Custom/CustomPage4.wav";
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
