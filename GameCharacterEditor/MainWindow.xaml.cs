using Microsoft.Win32;
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
        double ex = 0;
        double level = 0;
        double lvlex = 0;
        double exstr = 0;
        double exdox = 0;
        double exint = 0;
        double exconst = 0;
        bool create = false;
        bool arm = false;
        bool hel = false;
        bool weap = false;
        int aind;
        int hind;
        int wind;
        double maxstr = 0;
        double maxdox = 0;
        double maxint = 0;
        double maxconst = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonim_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;
            if (ofdPicture.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdPicture.FileName);
                image.EndInit();
                persim.Source = image;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ex > 0 && create == true && int.Parse(strlab.Content.ToString()) != maxstr)
            {
                int str = Convert.ToInt32(strlab.Content) + 1;
                strlab.Content = str;
                ex--;
                exstr++;
                Change_val();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ex != 20 && create == true && exstr > 0)
            {
                int str = Convert.ToInt32(strlab.Content) - 1;
                strlab.Content = str;
                ex++;
                exstr--;
                Change_val();
            }
        }

        private void plusdox_Click(object sender, RoutedEventArgs e)
        {
            if (ex > 0 && create == true && int.Parse(doxlab.Content.ToString()) != maxdox)
            {
                int dox = Convert.ToInt32(doxlab.Content) + 1;
                doxlab.Content = dox;
                ex--;
                exdox++;
                Change_val();
            }
        }

        private void mindox_Click(object sender, RoutedEventArgs e)
        {
            if (ex != 20 && create == true && exdox > 0)
            {
                int dox = Convert.ToInt32(doxlab.Content) - 1;
                doxlab.Content = dox;
                ex++;
                exdox--;
                Change_val();
            }
        }

        private void minint_Click(object sender, RoutedEventArgs e)
        {
            if (ex != 20 && create == true && exint > 0)
            {
                int intel = Convert.ToInt32(intelab.Content) - 1;
                intelab.Content = intel;
                ex++;
                exint--;
                Change_val();
            }
        }

        private void plusint_Click(object sender, RoutedEventArgs e)
        {
            if (ex > 0  && create == true && int.Parse(intelab.Content.ToString()) != maxint)
            {
                int intel = Convert.ToInt32(intelab.Content) + 1;
                intelab.Content = intel;
                ex--;
                exint++;
                Change_val();
            }
        }

        private void plusconst_Click(object sender, RoutedEventArgs e)
        {
            if (ex > 0  && create == true && int.Parse(conslab.Content.ToString()) != maxconst)
            {
                int con = Convert.ToInt32(conslab.Content) + 1;
                conslab.Content = con;
                ex--;
                exconst++;
                Change_val();
            }
        }

        private void minconst_Click(object sender, RoutedEventArgs e)
        {
            if (ex != 20 && create == true && exconst > 0)
            {
                int con = Convert.ToInt32(conslab.Content) - 1;
                conslab.Content = con;
                ex++;
                exconst--;
                Change_val();
            }
        }

        private void createpers_Click(object sender, RoutedEventArgs e)
        {
            if (typepers.SelectedIndex == 0)
            {
                Warrior warior = new Warrior(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()), int.Parse(extralab.Content.ToString()));
                warior.Add(warior);
                //var lst = Hero.TakeList();
                MessageBox.Show("Hero is created");
            }
            else if (typepers.SelectedIndex == 1)
            {
                Sorcerer sork = new Sorcerer(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()), int.Parse(extralab.Content.ToString()));
                sork.Add(sork);
                //var lst = Hero.TakeList();
                MessageBox.Show("Hero is created");
            }
            else if (typepers.SelectedIndex == 2)
            {
                Rogue rogue = new Rogue(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()), int.Parse(extralab.Content.ToString()));
                rogue.Add(rogue);
                //var lst = Hero.TakeList();
                MessageBox.Show("Hero is created");
            }
            else
            {
                MessageBox.Show("Choose type of hero");
            }
        }

        private void War_Selected(object sender, RoutedEventArgs e)
        {
            Warrior war = new Warrior();
            strlab.Content = war.Strength;
            doxlab.Content = war.Doxterity;
            intelab.Content = war.Intelegence;
            conslab.Content = war.Constitution;
            hp.Content = war.HP;
            mp.Content = war.MP;
            atslab.Content = war.AttackSpeed;
            wslab.Content = war.WalkingSpeed;
            palab.Content = war.PAttack;
            pdlab.Content = war.PDefence;
            malab.Content = war.MAttack;
            mdlab.Content = war.MDefence;
            levelb.Content = war.Level;
            maxstr = war.MaxStr;
            maxdox = war.MaxDox;
            maxint = war.MaxInt;
            maxconst = war.MaxConst;
            level = war.Level;
            lvlex = 0;
            ex = war.Extra;
            create = true;
            extralab.Content = ex;
            exstr = 0;
            exdox = 0;
            exint = 0;
            exconst = 0;
        }

        private void Sor_Selected(object sender, RoutedEventArgs e)
        {
            Sorcerer sor = new Sorcerer();
            strlab.Content = sor.Strength;
            doxlab.Content = sor.Doxterity;
            intelab.Content = sor.Intelegence;
            conslab.Content = sor.Constitution;
            hp.Content = sor.HP;
            mp.Content = sor.MP;
            maxstr = sor.MaxStr;
            maxdox = sor.MaxDox;
            maxint = sor.MaxInt;
            maxconst = sor.MaxConst;
            atslab.Content = sor.AttackSpeed;
            wslab.Content = sor.WalkingSpeed;
            palab.Content = sor.PAttack;
            pdlab.Content = sor.PDefence;
            malab.Content = sor.MAttack;
            mdlab.Content = sor.MDefence;
            levelb.Content = sor.Level;
            level = sor.Level;
            lvlex = 0;
            ex = sor.Extra;
            create = true;
            extralab.Content = ex;
            exstr = 0;
            exdox = 0;
            exint = 0;
            exconst = 0;
        }

        private void Rog_Selected(object sender, RoutedEventArgs e)
        {
            Rogue rog = new Rogue();
            strlab.Content = rog.Strength;
            doxlab.Content = rog.Doxterity;
            intelab.Content = rog.Intelegence;
            conslab.Content = rog.Constitution;
            hp.Content = rog.HP;
            mp.Content = rog.MP;
            maxstr = rog.MaxStr;
            maxdox = rog.MaxDox;
            maxint = rog.MaxInt;
            maxconst = rog.MaxConst;
            atslab.Content = rog.AttackSpeed;
            wslab.Content = rog.WalkingSpeed;
            palab.Content = rog.PAttack;
            pdlab.Content = rog.PDefence;
            malab.Content = rog.MAttack;
            mdlab.Content = rog.MDefence;
            levelb.Content = rog.Level;
            level = rog.Level;
            lvlex = 0;
            ex = rog.Extra;
            create = true;
            extralab.Content = ex;
            exstr = 0;
            exdox = 0;
            exint = 0;
            exconst = 0;
        }

        private int Change_val()
        {
            hp.Content = int.Parse(strlab.Content.ToString()) * 5 + int.Parse(conslab.Content.ToString()) * 10;
            mp.Content = int.Parse(intelab.Content.ToString()) * 5;
            atslab.Content = int.Parse(doxlab.Content.ToString()) * 5;
            wslab.Content = int.Parse(doxlab.Content.ToString()) * 2;
            palab.Content = int.Parse(strlab.Content.ToString()) * 5;
            pdlab.Content = int.Parse(doxlab.Content.ToString()) * 3 + int.Parse(conslab.Content.ToString()) * 5;
            malab.Content = int.Parse(intelab.Content.ToString()) * 10;
            mdlab.Content = int.Parse(intelab.Content.ToString()) * 5;
            levelb.Content = level;
            extralab.Content = ex;
            return 0;
        }

        private void add_ba_Click(object sender, RoutedEventArgs e)
        {
            if (arm == false && create == true)
            {
                if (bodyarmorbox.SelectedIndex == 0)
                {
                    inventlist.Items.Add("Robe armor");
                    aind = inventlist.Items.IndexOf("Robe armor");
                    RobeArmor rarm = new RobeArmor();
                    intelab.Content = int.Parse(intelab.Content.ToString()) + rarm.Intelegence;
                    mp.Content = int.Parse(mp.Content.ToString()) + rarm.MP;
                    malab.Content = int.Parse(malab.Content.ToString()) + rarm.MAttack;
                    pdlab.Content = int.Parse(pdlab.Content.ToString()) + rarm.PDefence;
                    mdlab.Content = int.Parse(pdlab.Content.ToString()) + rarm.MDefence;
                    Change_val();
                    arm = true;
                }
                else if (bodyarmorbox.SelectedIndex == 1)
                {
                    inventlist.Items.Add("Leather armor");
                    aind = inventlist.Items.IndexOf("Leather armor");
                    LeatherArmor larm = new LeatherArmor();
                    doxlab.Content = int.Parse(doxlab.Content.ToString()) + larm.Doxterity;
                    arm = true;
                }
                else if (bodyarmorbox.SelectedIndex == 2)
                {
                    inventlist.Items.Add("Iron armor");
                    aind = inventlist.Items.IndexOf("Iron armor");
                    arm = true;
                }
            }
            else if (arm == true && create == true)
            {
                if (bodyarmorbox.SelectedIndex == 0)
                {
                    inventlist.Items[aind] = "Robe armor";
                }
                else if (bodyarmorbox.SelectedIndex == 1)
                {
                    inventlist.Items[aind] = "Leather armor";
                }
                else if (bodyarmorbox.SelectedIndex == 2)
                {
                    inventlist.Items[aind] = "Iron armor";
                }
            }

        }

        private void add_hel_Click(object sender, RoutedEventArgs e)
        {
            if (hel == false && create == true)
            {
                if (helmetbox.SelectedIndex == 0)
                {
                    inventlist.Items.Add("Robe helmet");
                    hind = inventlist.Items.IndexOf("Robe helmet");
                    hel = true;
                }
                else if (helmetbox.SelectedIndex == 1)
                {
                    inventlist.Items.Add("Leather helmet");
                    hind = inventlist.Items.IndexOf("Leather helmet");
                    hel = true;
                }
                else if (helmetbox.SelectedIndex == 2)
                {
                    inventlist.Items.Add("Iron helmet");
                    hind = inventlist.Items.IndexOf("Iron helmet");
                    hel = true;
                }
            }
            else if (hel == true && create == true)
            {
                if (helmetbox.SelectedIndex == 0)
                {
                    inventlist.Items[hind] = "Robe helmet";
                }
                else if (helmetbox.SelectedIndex == 1)
                {
                    inventlist.Items[hind] = "Leather helmet";
                }
                else if (helmetbox.SelectedIndex == 2)
                {
                    inventlist.Items[hind] = "Iron helmet";
                }
            }
        }

        private void add_weap_Click(object sender, RoutedEventArgs e)
        {
            if (weap == false && create == true)
            {
                if (weaponbox.SelectedIndex == 0)
                {
                    inventlist.Items.Add("Truncheon");
                    wind = inventlist.Items.IndexOf("Truncheon");
                    weap = true;
                }
                else if (weaponbox.SelectedIndex == 1)
                {
                    inventlist.Items.Add("Dagger");
                    wind = inventlist.Items.IndexOf("Dagger");
                    weap = true;
                }
                else if (weaponbox.SelectedIndex == 2)
                {
                    inventlist.Items.Add("Sword");
                    wind = inventlist.Items.IndexOf("Sword");
                    weap = true;
                }
            }
            else if (weap == true && create == true)
            {
                if (weaponbox.SelectedIndex == 0)
                {
                    inventlist.Items[wind] = "Truncheon";
                }
                else if (weaponbox.SelectedIndex == 1)
                {
                    inventlist.Items[wind] = "Dagger";
                }
                else if (weaponbox.SelectedIndex == 2)
                {
                    inventlist.Items[wind] = "Sword";
                }
            }
        }

        private void levelplus_Click(object sender, RoutedEventArgs e)
        {
            if (create == true)
            {
                lvlex += 1000;
                if (lvlex == 1000) { level = 2; ex += 5; }
                else if (lvlex == 3000) { level = 3; ex += 5; }
                else if (lvlex == 6000) { level = 4; ex += 5; }
                else if (lvlex == 10000) { level = 5; ex += 5; }
                else if (lvlex == 15000) { level = 6; ex += 5; }
                else if (lvlex == 21000) { level = 7; ex += 5; }
                else if (lvlex == 28000) { level = 8; ex += 5; }
                else if (lvlex == 36000) { level = 9; ex += 5; }
                else if (lvlex == 45000) { level = 10; ex += 5; }
                else if (lvlex == 55000) { level = 11; ex += 5; }
                else if (lvlex == 66000) { level = 12; ex += 5; }
                else if (lvlex == 78000) { level = 13; ex += 5; }
                else if (lvlex == 91000) { level = 14; ex += 5; }
                else if (lvlex == 105000) { level = 15; ex += 5; }
                else if (lvlex == 120000) { level = 16; ex += 5; }
                else if (lvlex == 136000) { level = 17; ex += 5; }
                else if (lvlex == 153000) { level = 18; ex += 5; }
                else if (lvlex == 171000) { level = 19; ex += 5; }
                else if (lvlex == 190000) { level = 20; ex += 5; }
                Change_val();
            }
        }
    }
}
