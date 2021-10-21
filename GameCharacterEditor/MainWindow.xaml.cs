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

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Hero> herolist = new List<Hero>();
        double ex = 0;
        double level = 0;
        double exstr = 0;
        double exdox = 0;
        double exint = 0;
        double exconst = 0;
        bool create = false;
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
            if (ex > 0 && exstr < 20 && create == true && level !=14 )
            {
                int str = Convert.ToInt32(strlab.Content) + 1;
                strlab.Content = str;
                ex--;
                exstr++;
                Change_val();
                if (level == 14)
                {
                    ex = 0;
                    extralab.Content = 0;
                }
            }
            else if (level == 14 && create == true && ex > 0)
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
            if (ex > 0 && exdox < 20 && create == true && level != 14)
            {
                int dox = Convert.ToInt32(doxlab.Content) + 1;
                doxlab.Content = dox;
                ex--;
                exdox++;
                Change_val();
                if (level == 14)
                {
                    ex = 0;
                    extralab.Content = 0;
                }
            }
            else if (level == 14 && create == true && ex > 0)
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
            if (ex > 0 && exint < 20 && create == true && level != 14)
            {
                int intel = Convert.ToInt32(intelab.Content) + 1;
                intelab.Content = intel;
                ex--;
                exint++;
                Change_val();
                if (level == 14)
                {
                    ex = 0;
                    extralab.Content = 0;
                }
            }
            else if (level == 14 && create == true && ex > 0)
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
            if (ex > 0 && exconst < 20 && create == true && level != 14)
            {
                int con = Convert.ToInt32(conslab.Content) + 1;
                conslab.Content = con;
                ex--;
                exconst++;
                Change_val();
                if (level == 14)
                {
                    ex = 0;
                    extralab.Content = 0;
                }
            }
            else if (level == 14 && create == true && ex > 0)
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
                Warrior warior = new Warrior(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()));
                herolist.Add(warior);
                MessageBox.Show("Hero is created");
            }
            else if (typepers.SelectedIndex == 1)
            {
                Sorcerer sork = new Sorcerer(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()));
                herolist.Add(sork);
                MessageBox.Show("Hero is created");
            }
            else if (typepers.SelectedIndex == 2)
            {
                Rogue rogue = new Rogue(int.Parse(strlab.Content.ToString()), int.Parse(doxlab.Content.ToString()), int.Parse(intelab.Content.ToString()), int.Parse(conslab.Content.ToString()), namepers.Text, int.Parse(levelb.Content.ToString()));
                herolist.Add(rogue);
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
            level = war.Level;
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
            atslab.Content = sor.AttackSpeed;
            wslab.Content = sor.WalkingSpeed;
            palab.Content = sor.PAttack;
            pdlab.Content = sor.PDefence;
            malab.Content = sor.MAttack;
            mdlab.Content = sor.MDefence;
            levelb.Content = sor.Level;
            level = sor.Level;
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
            atslab.Content = rog.AttackSpeed;
            wslab.Content = rog.WalkingSpeed;
            palab.Content = rog.PAttack;
            pdlab.Content = rog.PDefence;
            malab.Content = rog.MAttack;
            mdlab.Content = rog.MDefence;
            levelb.Content = rog.Level;
            level = rog.Level;
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
            if (ex == 0 && level != 14)
            {
                level++;
                levelb.Content = level;
                ex = ex + 5;
            }
            extralab.Content = ex;
            return 0;
        }
    }
}
