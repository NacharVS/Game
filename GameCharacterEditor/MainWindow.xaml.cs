using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_character_Click(object sender, RoutedEventArgs e)
        {
            if (radBtn_Warrior.IsChecked == true)
            {
                string link = "C:/Users/User/source/repos/Game/GameCharacterEditor/Resourse/knights_m.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                textb_attack.Text = "200";
                textb_attack_magic.Text = "150";
                textb_damage.Text = "105";
                textb_hp.Text = "1000";
                textb_protection.Text = "75";
                textb_speed.Text = "30";
            }

            if (radBtn_Witch.IsChecked == true)
            {
                string link = "C:/Users/User/source/repos/Characters/Characters/Resourse/knights_m.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                textb_attack.Text = "150";
                textb_attack_magic.Text = "200";
                textb_damage.Text = "105";
                textb_hp.Text = "1000";
                textb_protection.Text = "90";
                textb_speed.Text = "20";
            }

            if (radBtn_Rogue.IsChecked == true)
            {
                string link = "C:/Users/User/source/repos/Characters/Characters/Resourse/knights_m.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                textb_attack.Text = "200";
                textb_attack_magic.Text = "120";
                textb_damage.Text = "105";
                textb_hp.Text = "1000";
                textb_protection.Text = "60";
                textb_speed.Text = "40";
            }

            MessageBox.Show("Персонаж создан");
        }
    }

    public static class Extensions
    {
        public static BitmapImage BitmapToImageSource(this Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}
