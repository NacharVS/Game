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
        double strenghtt = 0;
        double dexterityy = 0;
        double intelegense = 0;
        double constribution = 0;
        double extraPoint = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseHero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ZeroZero()
        {
            double strenghtt = 0;
            double dexterityy = 0;
            double intelegense = 0;
            double constribution = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Hero.SelectedIndex)
            {
                case 0:
                    Warrior war = new Warrior();
                    Characters(war);
                    extraPoint = war.Extra;
                    Choosehero();
                    ZeroZero();
                    break;
                case 1:
                    Rogue rog = new Rogue();
                    Characters(rog);
                    Choosehero();
                    extraPoint = rog.Extra;
                    ZeroZero();
                    break;
                case 2:
                    Magic_dude mag = new Magic_dude();
                    Characters(mag);
                    extraPoint = mag.Extra;
                    Choosehero();
                    ZeroZero();
                    break;
                case 3:
                    Archer arch = new Archer();
                    Characters(arch);
                    extraPoint = arch.Extra;
                    Choosehero();
                    ZeroZero();
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
            }
          
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
        }

        private void bnt_clickm1_Click(object sender, RoutedEventArgs e)
        {
            labelstrenght.Text = (Convert.ToDouble(labelstrenght.Text) - 1).ToString();
        }

        private void bnt_clickp1_Click(object sender, RoutedEventArgs e)
        {
            labelstrenght.Text = (Convert.ToDouble(labelstrenght.Text) + 1).ToString();
        }

        private void bnt_clickm2_Click(object sender, RoutedEventArgs e)
        {
            labeldexterity.Text = (Convert.ToDouble(labeldexterity.Text) - 1).ToString();
        }

        private void bnt_clickp2_Click(object sender, RoutedEventArgs e)
        {
            labeldexterity.Text = (Convert.ToDouble(labeldexterity.Text) + 1).ToString();
        }

        private void bnt_clickm3_Click(object sender, RoutedEventArgs e)
        {
            labelintelegence.Text = (Convert.ToDouble(labelintelegence.Text) - 1).ToString();
        }

        private void bnt_clickp3_Click(object sender, RoutedEventArgs e)
        {
            labelintelegence.Text = (Convert.ToDouble(labelintelegence.Text) + 1).ToString();
        }

        private void bnt_clickm4_Click(object sender, RoutedEventArgs e)
        {
            constitutionlabel.Text = (Convert.ToDouble(constitutionlabel.Text) - 1).ToString();
        }

        private void bnt_clickp4_Click(object sender, RoutedEventArgs e)
        {
            if(constribution+1 <= extraPoint)
            {
                constitutionlabel.Text = (Convert.ToDouble(constitutionlabel.Text) + 1).ToString();
                constribution++;
            }
            else
            {
                MessageBox.Show("Дополнительные очки закончились!!!");
            }
        }

        private void labelstrenght_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
