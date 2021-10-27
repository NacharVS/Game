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
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

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
                textb_name_character.Text = war.Name;
                textb_constitution.Text = war.Constitution.ToString();
                textb_dexterity.Text = war.Dexterity.ToString();
                textb_intelligent.Text = war.Intelligence.ToString();
                textb_strenght.Text = war.Strenght.ToString();
                textb_hp.Text = (war.Strenght * 5 + war.Constitution * 10).ToString();
                textb_mana.Text = (war.Intelligence * 5).ToString();
                textb_attack.Text = (war.Strenght * 5).ToString();
                textb_attack_magic.Text = (war.Intelligence * 10).ToString();
                textb_pResist.Text = (war.Constitution * 5 + war.Dexterity * 3).ToString();
                textb_mResist.Text = (war.Intelligence * 5).ToString();
                textb_attack_speed.Text = (war.Dexterity * 5).ToString();
                textb_walk_speed.Text = (war.Dexterity * 2).ToString();
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
                textb_name_character.Text = witch.Name;
                textb_constitution.Text = witch.Constitution.ToString();
                textb_dexterity.Text = witch.Dexterity.ToString();
                textb_intelligent.Text = witch.Intelligence.ToString();
                textb_strenght.Text = witch.Strenght.ToString();
                textb_hp.Text = (witch.Strenght * 5 + witch.Constitution * 10).ToString();
                textb_mana.Text = (witch.Intelligence * 5).ToString();
                textb_attack.Text = (witch.Strenght * 5).ToString();
                textb_attack_magic.Text = (witch.Intelligence * 10).ToString();
                textb_pResist.Text = (witch.Constitution * 5 + witch.Dexterity * 3).ToString();
                textb_mResist.Text = (witch.Intelligence * 5).ToString();
                textb_attack_speed.Text = (witch.Dexterity * 5).ToString();
                textb_walk_speed.Text = (witch.Dexterity * 2).ToString();
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
                textb_name_character.Text = rogue.Name;
                textb_constitution.Text = rogue.Constitution.ToString();
                textb_dexterity.Text = rogue.Dexterity.ToString();
                textb_intelligent.Text = rogue.Intelligence.ToString();
                textb_strenght.Text = rogue.Strenght.ToString();
                textb_hp.Text = (rogue.Strenght * 5 + rogue.Constitution * 10).ToString();
                textb_mana.Text = (rogue.Intelligence * 5).ToString();
                textb_attack.Text = (rogue.Strenght * 5).ToString();
                textb_attack_magic.Text = (rogue.Intelligence * 10).ToString();
                textb_pResist.Text = (rogue.Constitution * 5 + rogue.Dexterity * 3).ToString();
                textb_mResist.Text = (rogue.Intelligence * 5).ToString();
                textb_attack_speed.Text = (rogue.Dexterity * 5).ToString();
                textb_walk_speed.Text = (rogue.Dexterity * 2).ToString();
            }

            if (radBtn_Rogue.IsChecked == false && radBtn_Warrior.IsChecked == false && radBtn_Witch.IsChecked == false)
            {
                MessageBox.Show("Выберите класс персонажа");
            }
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
            if ((radBtn_Warrior.IsChecked == true && point_str + 1 <= 850) || (radBtn_Witch.IsChecked == true && point_str + 1 <= 650) || (radBtn_Rogue.IsChecked == true && point_str + 1 <= 660))
            {
                point_str += 1;
                textb_strenght.Text = point_str.ToString();
                CountExtraPlus();
                Update();
            }
            else
            {
                plus_str.Visibility = Visibility.Hidden;
            }
        }
        private void plus_int_Click(object sender, RoutedEventArgs e)
        {
            point_int = Convert.ToInt32(textb_intelligent.Text);
            if ((radBtn_Warrior.IsChecked == true && point_int + 1 <= 650) || (radBtn_Witch.IsChecked == true && point_int + 1 <= 850) || (radBtn_Rogue.IsChecked == true && point_int + 1 <= 700))
            {
                point_int += 1;
                textb_intelligent.Text = point_int.ToString();
                CountExtraPlus();
                Update();
            }
            else
            {
                plus_int.Visibility = Visibility.Hidden;
            }
        }

        private void plus_dex_Click(object sender, RoutedEventArgs e)
        {
            point_dex = Convert.ToInt32(textb_dexterity.Text);
            if ((radBtn_Warrior.IsChecked == true && point_dex + 1 <= 670) || (radBtn_Witch.IsChecked == true && point_dex + 1 <= 650) || (radBtn_Rogue.IsChecked == true && point_dex + 1 <= 850))
            {
                point_dex += 1;
                textb_dexterity.Text = point_dex.ToString();
                CountExtraPlus();
                Update();
            }
            else
            {
                plus_dex.Visibility = Visibility.Hidden;
            }
        }

        private void plus_const_Click(object sender, RoutedEventArgs e)
        {
            point_const = Convert.ToInt32(textb_constitution.Text);
            if ((radBtn_Warrior.IsChecked == true && point_const + 1 <= 850) || (radBtn_Witch.IsChecked == true && point_const + 1 <= 650) || (radBtn_Rogue.IsChecked == true && point_const + 1 <= 660))
            {
                point_const += 1;
                textb_constitution.Text = point_const.ToString();
                CountExtraPlus();
                Update();
            }
            else
            {
                plus_const.Visibility = Visibility.Hidden;
            }
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
            if ((radBtn_Warrior.IsChecked == true && point_str - 1 >= 250) || (radBtn_Witch.IsChecked == true && point_str - 1 >= 50) || (radBtn_Rogue.IsChecked == true && point_str - 1 >= 60))
            {
                MinChar();
                if (point < 20)
                {
                    point_str -= 1;
                    if (point_str == 0)
                        minus_str.Visibility = Visibility.Hidden;
                    textb_strenght.Text = point_str.ToString();
                    CountExtraMinus();
                }
                Update();
            }
            else
            {
                minus_str.Visibility = Visibility.Hidden;
            }
        }

        private void Update()
        {
            int point_str = Convert.ToInt32(textb_strenght.Text);
            int point_int = Convert.ToInt32(textb_intelligent.Text);
            int point_dex = Convert.ToInt32(textb_dexterity.Text);
            int point_const = Convert.ToInt32(textb_constitution.Text);

            textb_pResist.Text = (point_const * 5 + point_dex * 3).ToString();
            textb_mResist.Text = (point_int * 5).ToString();
            textb_hp.Text = (point_str * 5 + point_const * 10).ToString();
            textb_attack_speed.Text = (point_dex * 5).ToString();
            textb_walk_speed.Text = (point_dex * 2).ToString();
            textb_mana.Text = (point_int * 5).ToString();
            textb_attack_magic.Text = (point_int * 10).ToString();
            textb_attack.Text = (point_str * 5).ToString();
        }

        private void Save_character_Click(object sender, RoutedEventArgs e)
        {
            if (radBtn_Warrior.IsChecked == true)
            {
                Warrior war = new Warrior();
                war.Add(war);
            }
            if (radBtn_Witch.IsChecked == true)
            {
                Witch witch = new Witch();
                witch.Add(witch);
            }
            if (radBtn_Rogue.IsChecked == true)
            {
                Rogue rogue = new Rogue();
                rogue.Add(rogue);
            }
            MessageBox.Show("Персонаж сохранен");
        }

        private void up_lvl_Click(object sender, RoutedEventArgs e)
        {
            int point_str = Convert.ToInt32(textb_strenght.Text);
            int point_int = Convert.ToInt32(textb_intelligent.Text);
            int point_dex = Convert.ToInt32(textb_dexterity.Text);
            int point_const = Convert.ToInt32(textb_constitution.Text);
            int point = Convert.ToInt32(extra.Text);
            lvl = Convert.ToInt32(textb_lvl.Text);
            if (point == 0)
            {
                lvl += 1;
                textb_lvl.Text = lvl.ToString();
                point_str += 100;
                point_int += 100;
                point_dex += 100;
                point_const += 100;
                textb_strenght.Text = point_str.ToString();
                textb_intelligent.Text = point_int.ToString();
                textb_dexterity.Text = point_dex.ToString();
                textb_constitution.Text = point_const.ToString();

                point = +20;
                extra.Text = point.ToString();
                plus_str.Visibility = Visibility.Visible;
                plus_const.Visibility = Visibility.Visible;
                plus_dex.Visibility = Visibility.Visible;
                plus_int.Visibility = Visibility.Visible;
                Update();
                MessageBox.Show("Уровень повышен");
            }
            else
            {
                MessageBox.Show("Повысьте характеристики");
            }
        }

        private void minus_int_Click(object sender, RoutedEventArgs e)
        {
            point_int = Convert.ToInt32(textb_intelligent.Text);
            if ((radBtn_Warrior.IsChecked == true && point_int - 1 >= 100) || (radBtn_Witch.IsChecked == true && point_int - 1 >= 250) || (radBtn_Rogue.IsChecked == true && point_int - 1 >= 100))
            {
                MinChar();
                if (point < 20)
                {
                    point_int -= 1;
                    if (point_int == 0)
                        minus_int.Visibility = Visibility.Hidden;
                    textb_intelligent.Text = point_int.ToString();
                    CountExtraMinus();
                }
                Update();
            }
            else
            {
                minus_int.Visibility = Visibility.Hidden;
            }   
        }

        private void minus_dex_Click(object sender, RoutedEventArgs e)
        {
            point_dex = Convert.ToInt32(textb_dexterity.Text);
            if ((radBtn_Warrior.IsChecked == true && point_dex - 1 >= 70) || (radBtn_Witch.IsChecked == true && point_dex - 1 >= 50) || (radBtn_Rogue.IsChecked == true && point_dex - 1 >= 250))
            {
                MinChar();
                if (point < 20)
                {
                    point_dex -= 1;
                    if (point_dex == 0)
                        minus_dex.Visibility = Visibility.Hidden;
                    textb_dexterity.Text = point_dex.ToString();
                    CountExtraMinus();
                }
                Update();
            }
            else
            {
                minus_dex.Visibility = Visibility.Hidden;
            }
        }

        private void minus_const_Click(object sender, RoutedEventArgs e)
        {
            point_const = Convert.ToInt32(textb_constitution.Text);
            if ((radBtn_Warrior.IsChecked == true && point_const-1 >= 100) || (radBtn_Witch.IsChecked == true && point_const-1 >= 50) || (radBtn_Rogue.IsChecked == true && point_const-1 >= 60))
            {
                MinChar();
                if (point < 20)
                {
                    point_const -= 1;
                    if (point_const == 0)
                        minus_const.Visibility = Visibility.Hidden;
                    textb_constitution.Text = point_const.ToString();
                    CountExtraMinus();
                }
                Update();
            }
            else
            {
                minus_const.Visibility = Visibility.Hidden;
            }
        }
        private void MinChar()
        {
            point = Convert.ToInt32(extra.Text);
            if (point == 20)
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