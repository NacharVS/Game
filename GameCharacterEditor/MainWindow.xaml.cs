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
            int str = Convert.ToInt32(strlab.Content) + 1;
            strlab.Content = str;
            Change_val();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(strlab.Content) != 20)
            {
                int str = Convert.ToInt32(strlab.Content) - 1;
                strlab.Content = str;
                Change_val();
            }
        }

        private void plusdox_Click(object sender, RoutedEventArgs e)
        {
            int dox = Convert.ToInt32(doxlab.Content) + 1;
            doxlab.Content = dox;
            Change_val();
        }

        private void mindox_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(doxlab.Content) != 20)
            {
                int dox = Convert.ToInt32(doxlab.Content) - 1;
                doxlab.Content = dox;
                Change_val();
            }
        }

        private void minint_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(intelab.Content) != 20)
            {
                int intel = Convert.ToInt32(intelab.Content) - 1;
                intelab.Content = intel;
                Change_val();
            }
        }

        private void plusint_Click(object sender, RoutedEventArgs e)
        {
            int intel = Convert.ToInt32(intelab.Content) + 1;
            intelab.Content = intel;
            Change_val();
        }

        private void plusconst_Click(object sender, RoutedEventArgs e)
        {
            int con = Convert.ToInt32(conslab.Content) + 1;
            conslab.Content = con;
            Change_val();
        }

        private void minconst_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(conslab.Content) != 20)
            {
                int con = Convert.ToInt32(conslab.Content) - 1;
                conslab.Content = con;
                Change_val();
            }
        }

        private void createpers_Click(object sender, RoutedEventArgs e)
        {

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
            return 0;
        }
    }
}
