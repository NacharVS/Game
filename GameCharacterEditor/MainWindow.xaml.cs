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
        int point_str, point_dex, point_int, point_const, point, lvl;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_character_Click(object sender, RoutedEventArgs e)
        {
            if (radBtn_Warrior.IsChecked == true)
            {
                string link = "C:/Users/User/Source/Repos/Game/ver2/GameCharacterEditor/Resourse/knight.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                Warrior war = new Warrior();
                GetUnitInfo(war, textb_name_character, textb_hp, textb_mana, textb_attack, textb_attack_magic, textb_walk_speed,
                    textb_attack_speed, textb_pResist, textb_mResist);
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
                GetUnitInfo(witch, textb_name_character, textb_hp, textb_mana, textb_attack, textb_attack_magic, textb_walk_speed,
                    textb_attack_speed, textb_pResist, textb_mResist);
            }

            if (radBtn_Rogue.IsChecked == true)
            {
                string link = "C:/Users/User/Source/Repos/Game/ver2/GameCharacterEditor/Resourse/rogue.png";

                using (Stream fs = new FileStream(link, FileMode.Open))
                {
                    Bitmap bmp = new Bitmap(fs);
                    image_character.Source = bmp.BitmapToImageSource();
                }

                Rogue rogue = new Rogue();
                GetUnitInfo(rogue, textb_name_character, textb_hp, textb_mana, textb_attack, textb_attack_magic, textb_walk_speed,
                    textb_attack_speed, textb_pResist, textb_mResist);
            }

            if (radBtn_Rogue.IsChecked == false & radBtn_Warrior.IsChecked == false & radBtn_Witch.IsChecked == false)
            {
                MessageBox.Show("Выберите класс персонажа");
            }
        }
        private void GetUnitInfo(Unit unit,TextBox textb_name_character, TextBox textb_hp, TextBox textb_mana, TextBox textb_attack,
            TextBox textb_attack_magic, TextBox textb_walk_speed,
            TextBox textb_attack_speed, TextBox textb_pResist, TextBox textb_mResist)
        {
            textb_name_character.Text = unit.Name;
            textb_constitution.Text = unit.Constitution.ToString();
            textb_dexterity.Text = unit.Dexterity.ToString();
            textb_intelligent.Text = unit.Intelligence.ToString();
            textb_strenght.Text = unit.Strenght.ToString();
            textb_pResist.Text = (unit.Constitution*5+unit.Dexterity*3).ToString();
            textb_mResist.Text = (unit.Intelligence*5).ToString();
            textb_hp.Text = (unit.Strenght * 5 + unit.Constitution * 10).ToString();
            textb_attack_speed.Text = (unit.Dexterity*5).ToString();
            textb_walk_speed.Text = (unit.Dexterity*2).ToString();
            textb_mana.Text = (unit.Intelligence * 5).ToString();
            textb_attack_magic.Text = (unit.Intelligence*10).ToString();
            textb_attack.Text = (unit.Strenght *5).ToString();
        }

        private void CountExtraPlus()
        {
            point = Convert.ToInt32(extra.Text);
            point -= 1;
            if (point == 0)
            {
                extra.Text = point.ToString();
                plus_str.Visibility = Visibility.Hidden;
                plus_const.Visibility = Visibility.Hidden;
                plus_dex.Visibility = Visibility.Hidden;
                plus_int.Visibility = Visibility.Hidden;
            }
            else if (point > 0)
            {
                minus_str.Visibility = Visibility.Visible;
                minus_const.Visibility = Visibility.Visible;
                minus_dex.Visibility = Visibility.Visible;
                minus_int.Visibility = Visibility.Visible;
                extra.Text = point.ToString();
            }
        }
        private void plus_str_Click(object sender, RoutedEventArgs e)
        {
            point_str = Convert.ToInt32(textb_strenght.Text);
            point_str += 1;
            textb_strenght.Text = point_str.ToString();
            CountExtraPlus();
        }
        private void plus_int_Click(object sender, RoutedEventArgs e)
        {
            point_int = Convert.ToInt32(textb_intelligent.Text);
            point_int += 1;
            textb_intelligent.Text = point_int.ToString();
            CountExtraPlus();
        }

        private void plus_dex_Click(object sender, RoutedEventArgs e)
        {
            point_dex = Convert.ToInt32(textb_dexterity.Text);
            point_dex += 1;
            textb_dexterity.Text = point_dex.ToString();
            CountExtraPlus();
        }

        private void plus_const_Click(object sender, RoutedEventArgs e)
        {
            point_const = Convert.ToInt32(textb_constitution.Text);
            point_const += 1;
            textb_constitution.Text = point_const.ToString();
            CountExtraPlus();
        }

        private void CountExtraMinus()
        {
            point = Convert.ToInt32(extra.Text);
            if (point == Unit.extra-1)
            {
                
                extra.Text = point.ToString();
                minus_str.Visibility = Visibility.Hidden;
                minus_const.Visibility = Visibility.Hidden;
                minus_dex.Visibility = Visibility.Hidden;
                minus_int.Visibility = Visibility.Hidden;
            }
            else if (point > 0)
            {
                plus_str.Visibility = Visibility.Visible;
                plus_const.Visibility = Visibility.Visible;
                plus_dex.Visibility = Visibility.Visible;
                plus_int.Visibility = Visibility.Visible;
                extra.Text = point.ToString();
            }
            point = Convert.ToInt32(extra.Text);
            point += 1;
            extra.Text = point.ToString();
        }

        private void minus_str_Click(object sender, RoutedEventArgs e)
        {
            point_str = Convert.ToInt32(textb_strenght.Text);
            point_str -= 1;
            if (point_str == 0)
                minus_str.Visibility = Visibility.Hidden;
            MinChar();
            textb_strenght.Text = point_str.ToString();
            CountExtraMinus();
        }

        private void add_point_Click(object sender, RoutedEventArgs e)
        {
            point = Convert.ToInt32(extra.Text);
            if (point == 0)
            {
                point = +20;
                extra.Text = point.ToString();
                plus_str.Visibility = Visibility.Visible;
                plus_const.Visibility = Visibility.Visible;
                plus_dex.Visibility = Visibility.Visible;
                plus_int.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Не все очки были использованы");
            }
        }

        private void up_lvl_Click(object sender, RoutedEventArgs e)
        {
            point_str = Convert.ToInt32(textb_strenght.Text);
            point_int = Convert.ToInt32(textb_intelligent.Text);
            point_dex = Convert.ToInt32(textb_dexterity.Text);
            point_const = Convert.ToInt32(textb_constitution.Text);
            lvl = Convert.ToInt32(textb_lvl.Text);
            if (point_str >= point_str + 20 && point_int >= point_int + 20 && point_dex >= point_dex + 20 && point_const >= point_const + 20)
            {
                lvl += 1;
                textb_lvl.Text = lvl.ToString();
            }
            else
            {
                MessageBox.Show("Повысьте характеристики");
            }
        }

        private void minus_int_Click(object sender, RoutedEventArgs e)
        {
            point_int = Convert.ToInt32(textb_intelligent.Text);
            point_int -= 1;
            if (point_int == 0)
                minus_int.Visibility = Visibility.Hidden;
            MinChar();
            textb_intelligent.Text = point_int.ToString();
            CountExtraMinus();
        }

        private void minus_dex_Click(object sender, RoutedEventArgs e)
        {
            point_dex = Convert.ToInt32(textb_dexterity.Text);
            point_dex -= 1;
            if (point_dex == 0)
                minus_dex.Visibility = Visibility.Hidden;
            MinChar();
            textb_dexterity.Text = point_dex.ToString();
            CountExtraMinus();
        }

        private void minus_const_Click(object sender, RoutedEventArgs e)
        {
            point_const = Convert.ToInt32(textb_constitution.Text);
            point_const -= 1;
            if(point_const == 0)
                minus_const.Visibility = Visibility.Hidden;
            MinChar();
            textb_constitution.Text = point_const.ToString();
            CountExtraMinus();
        }
        private void MinChar()
        {
            point = Convert.ToInt32(extra.Text);
            if (point >= 20)
            {
                minus_const.Visibility = Visibility.Hidden;
                minus_dex.Visibility = Visibility.Hidden;
                minus_int.Visibility = Visibility.Hidden;
                minus_str.Visibility = Visibility.Hidden;
            }
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