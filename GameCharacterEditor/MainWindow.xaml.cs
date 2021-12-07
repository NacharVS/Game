using Microsoft.Win32;
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
using System.Windows.Media;
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
        private List<string> Itemlist = new List<string>();
        double strenghtt = 0;
        double dexterityy = 0;
        double intelegense = 0;
        double constribution = 0;
        double extraPoint = 0;
        int x = 0;
        Unit unit1;
        List<Unit> lst;

        public MainWindow()
        {
            InitializeComponent();
            lst = Unit.TakeList();
            //GetInfo();
        }

        private void ChooseHero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Hero.SelectedIndex)
            {
                case 0:
                    unit1 = new Warrior();
                    Characters(unit1);
                    extraPoint = unit1.Extra;
                    Choosehero();
                    break;
                case 1:
                    unit1 = new Rogue();
                    Characters(unit1);
                    Choosehero();
                    extraPoint = unit1.Extra;
                    
                    break;
                case 2:
                    unit1 = new Magic_dude();
                    Characters(unit1);
                    extraPoint = unit1.Extra;
                    Choosehero();
                    
                    break;
                case 3:
                    unit1 = new Archer();
                    Characters(unit1);
                    extraPoint = unit1.Extra;
                    Choosehero();
                  
                    break;

            }
        }

        private void Choosehero()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofd.FileName);
                image.EndInit();
                ChooseHero.Source = image;
                unit1.Image = hetBytefromImage(ChooseHero.Source as BitmapImage);
            }

        }

        public byte[] hetBytefromImage(BitmapImage imageC)
        {
            MemoryStream ms = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(ms);
            return ms.ToArray();
        }
        private void Characters(Unit unit)
        {
            labelstrenght.Text = unit.Strenght.ToString();
            labeldexterity.Text = unit.Dexterity.ToString();
            labelintelegence.Text = unit.Intelegence.ToString();
            constitutionlabel.Text = unit.Constitution.ToString();
            Manatxt.Text = unit.MP_Unit.ToString();
            Healthtxt.Text = unit.HP_Unit.ToString();
            textpoint.Text = unit.Extra.ToString();
            Ph_Attack.Text = unit.Phusical_Attack.ToString();
            Ph_Deh.Text = unit.Phisical_Defence.ToString();
            At_Speed.Text = unit.AttackSpeed.ToString();
            Wol_Speed.Text = unit.Wooling_Speed.ToString();
            Mg_Def.Text = unit.Magic_Defence.ToString();
            Mg_Attack.Text = unit.Magic_Attack.ToString();

        }  
        private void GetInfo()
        {
            labelstrenght.Text = lst[x].Strenght.ToString();
            labeldexterity.Text = lst[x].Dexterity.ToString();
            labelintelegence.Text = lst[x].Intelegence.ToString();
            constitutionlabel.Text = lst[x].Constitution.ToString();
            Manatxt.Text = lst[x].MP_Unit.ToString();
            Healthtxt.Text = lst[x].HP_Unit.ToString();
            textpoint.Text = lst[x].Extra.ToString();
            Ph_Attack.Text = lst[x].Phusical_Attack.ToString();
            Ph_Deh.Text = lst[x].Phisical_Defence.ToString();
            At_Speed.Text = lst[x].AttackSpeed.ToString();
            Wol_Speed.Text = lst[x].Wooling_Speed.ToString();
            Mg_Def.Text = lst[x].Magic_Defence.ToString();
            Mg_Attack.Text = lst[x].Magic_Attack.ToString();
            try
            {

                MemoryStream memory = new MemoryStream(lst[x].Image);
                Bitmap bmp = new Bitmap(memory);
                ChooseHero.Source = bmp.BitmapToImageSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bnt_clickm1_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(labelstrenght.Text) - 1 >= extraPoint && strenghtt > 0)
            {
                labelstrenght.Text = (Convert.ToDouble(labelstrenght.Text) - 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) + 1).ToString();
                extraPoint++;
                strenghtt--;
            }
            else
            {
                MessageBox.Show("Значение меньше дефолта быть не может!");
            }
            refresh();
        }
        int count = 0;
        private void bnt_clickp1_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint>0 && int.Parse(labelstrenght.Text) < Unit.MaxStrenght)
            {
                labelstrenght.Text = (Convert.ToDouble(labelstrenght.Text) + 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) - 1).ToString();
                extraPoint--;
                strenghtt++;
            }
            else
            {
                if (count == 1)
                {
                    MessageBox.Show("Ты не понимаешь???");
                }

                else if (count >= 2)
                {
                    MessageBox.Show("Ну всё доигрался пока:)");
                    Environment.Exit(1);
                }
                else
                    MessageBox.Show("Дополнительные очки закончились!");
                count++;
            }
            refresh();
        }

        private void bnt_clickm2_Click(object sender, RoutedEventArgs e)
        {
            if ( int.Parse(labeldexterity.Text) - 1 >= extraPoint && dexterityy > 0)
            {
                labeldexterity.Text = (Convert.ToDouble(labeldexterity.Text) - 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) + 1).ToString();
                extraPoint++;
                dexterityy--;
            }
            else
            {
                MessageBox.Show("Значение меньше дефолта быть не может!");
            }
            refresh();
        }

        private void bnt_clickp2_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint > 0 && int.Parse(labeldexterity.Text) < Unit.MaxdDexterity)
            {
                labeldexterity.Text = (Convert.ToDouble(labeldexterity.Text) + 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) - 1).ToString();
                extraPoint--;
                dexterityy++;
            }
            else
            {
                MessageBox.Show("Дополнительные очки закончились!");
            }
            refresh();
        }

        private void bnt_clickm3_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(labelintelegence.Text) - 1 >= extraPoint && intelegense > 0)
            {
                labelintelegence.Text = (Convert.ToDouble(labelintelegence.Text) - 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) + 1).ToString();
                extraPoint++;
                intelegense--;
            }
            else
            {
                MessageBox.Show("Значение меньше дефолта быть не может!");
            }
            refresh();
        }

        private void bnt_clickp3_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint > 0 && int.Parse(labelintelegence.Text) < Unit.MaxIntelegence)
            {
                labelintelegence.Text = (Convert.ToDouble(labelintelegence.Text) + 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) - 1).ToString();
                extraPoint--;
                intelegense++;
            }
            else
            {
                MessageBox.Show("Дополнительные очки закончились!");
            }
            refresh();
        }

        private void bnt_clickm4_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(constitutionlabel.Text)- 1 >= extraPoint && constribution > 0)
            {
                constitutionlabel.Text = (Convert.ToDouble(constitutionlabel.Text) - 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) + 1).ToString();
                extraPoint++;
                constribution--;
            }
            else
            {
                MessageBox.Show("Значение меньше дефолта быть не может!");
            }
            refresh();
        }

        private void bnt_clickp4_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint > 0 && int.Parse(constitutionlabel.Text) < Unit.MaxConstitution)
            {
                constitutionlabel.Text = (Convert.ToDouble(constitutionlabel.Text) + 1).ToString();
                textpoint.Text = (int.Parse(textpoint.Text) - 1).ToString();
                extraPoint--;
                constribution++;
            }
            //new Sword(strenghtt);
            else
            {
                MessageBox.Show("Дополнительные очки закончились!");
            }
            refresh();
        }

        //private void btn_lvlup_Click(object sender, RoutedEventArgs e)
        //{

        //    lvltxt.Text = (int.Parse(lvltxt.Text) + 1).ToString();
        //    textpoint.Text = (int.Parse(textpoint.Text) + 5).ToString();
        //    extraPoint += 5;
        //    refresh();
        //}

        private void btn_click1000_Click(object sender, RoutedEventArgs e)
        {
            int lvlup1000 = Convert.ToInt32(_0lvl.Text);
            int lvlmax = Convert.ToInt32(makslvl.Text);
            lvlup1000 += 1000;
            _0lvl.Text = lvlup1000.ToString();
            if (lvlup1000 >= lvlmax)
            {
                lvlmax += 6000;
                makslvl.Text = lvlmax.ToString();
                MessageBox.Show("Уровень повышен!");
                lvltxt.Text = (int.Parse(lvltxt.Text) + 1).ToString();
                LvlUp();
            }
        }

        private void btn_click2000_Click(object sender, RoutedEventArgs e)
        {
            int lvlup1000 = Convert.ToInt32(_0lvl.Text);
            int lvlmax = Convert.ToInt32(makslvl.Text);
            lvlup1000 += 2000;
            _0lvl.Text = lvlup1000.ToString();
            if (lvlup1000 > lvlmax || lvlup1000 == lvlmax)
            {
                lvlmax += 6000;
                makslvl.Text = lvlmax.ToString();
                MessageBox.Show("Уровень повышен!");
                lvltxt.Text = (int.Parse(lvltxt.Text) + 1).ToString();
                LvlUp();
            }
        }

        private void _0lvl_TextChanged(object sender, TextChangedEventArgs e)
        {
            //PB_vlup.Value = int.Parse(_0lvl.Text);
        }

        private void makslvl_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //PB_vlup.Maximum = int.Parse(makslvl.Text);
            }
            catch { }
        }

        private void LvlUp()
        {
            textpoint.Text = (int.Parse(textpoint.Text) + 5).ToString();
            extraPoint += 5;
        }
        private void refresh()
        {
            Healthtxt.Text = ((double.Parse(labelstrenght.Text) * 5) + (double.Parse(constitutionlabel.Text) * 10)).ToString();
            Manatxt.Text = (double.Parse(labelintelegence.Text) * 5).ToString();
            Ph_Attack.Text = ((double.Parse(labelstrenght.Text) * 5) + (double.Parse(labeldexterity.Text) * 3)).ToString();
            At_Speed.Text = (double.Parse(labeldexterity.Text) * 5).ToString();
            Wol_Speed.Text = (double.Parse(labeldexterity.Text) * 2).ToString();
            Mg_Attack.Text = (double.Parse(labelintelegence.Text) * 10).ToString();
            Mg_Def.Text = (double.Parse(labelintelegence.Text) * 5).ToString();
            Ph_Deh.Text = (double.Parse(constitutionlabel.Text) * 5).ToString();

        }

        private void btn_bd_Click(object sender, RoutedEventArgs e)
        {
            Unit.Add(unit1);
            MessageBox.Show("Занесено в базу!");
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Itemlist.Add(cmb_boxraritem.SelectedItem.ToString().Substring(38)+"\n");
            lstView.Items.Add(cmb_boxraritem.SelectedItem.ToString().Substring(38));
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            lst = Unit.TakeList();
            if(x+1 <= lst.Count-1)
            {
                x++;
            }
            else
            {
                x = 0;
            }
            GetInfo();
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            lst = Unit.TakeList();
            if (x-1 >= 0)
            {
                x--;
            }
            else
            {
                x = lst.Count - 1;
            }
            GetInfo();
        }
    }

    public static class Extensions
    {
        public static BitmapImage BitmapToImageSource(this Bitmap bmp)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bmp.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
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
