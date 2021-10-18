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
                string link = "C:/Users/User/Source/Repos/Game/ver2/GameCharacterEditor/Resourse/knight.jpg";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                Warrior war = new Warrior();
                GetUnitInfo(war);
            }

            if (radBtn_Witch.IsChecked == true)
            {
                string link = "C:/Users/User/Source/Repos/Game/ver2/GameCharacterEditor/Resourse/witch.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                Witch witch = new Witch();
                GetUnitInfo(witch);
            }

            if (radBtn_Rogue.IsChecked == true)
            {
                string link = "C:/Users/User/Source/Repos/Game/ver2/GameCharacterEditor/Resourse/rogue.jpg";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                Rogue rogue = new Rogue();
                GetUnitInfo(rogue);
            }

            if (radBtn_Rogue.IsChecked == false & radBtn_Warrior.IsChecked == false & radBtn_Witch.IsChecked == false)
            {
                MessageBox.Show("Выберите класс персонажа");
            }
        }
        private void GetUnitInfo(Unit unit)
        {
            textb_name_character.Text = unit.Name;
            textb_constitution.Text = unit.Constitution.ToString();
            textb_dexterity.Text = unit.Dexterity.ToString();
            textb_intelligent.Text = unit.Intelligence.ToString();
            textb_strenght.Text = unit.Strenght.ToString();
            textb_pResist.Text = unit.PResist.ToString();
            textb_mResist.Text = unit.MResist.ToString();
            textb_hp.Text = unit.Health.ToString();
            textb_attack_speed.Text = unit.AttackSpeed.ToString();
            textb_walk_speed.Text = unit.WalkSpeed.ToString();
            textb_mana.Text = unit.Mana.ToString();
            textb_attack_magic.Text = unit.MAttack.ToString();
            textb_attack.Text = unit.PAttack.ToString();
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