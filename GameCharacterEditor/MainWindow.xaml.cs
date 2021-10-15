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
        double Strenghtt = 0;
        double Dexterityy = 0;
        double Intelegense = 0;
        double Constribution = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseHero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Hero.SelectedIndex)
            {
                case 0:
                    Characters(new Warrior());
                    Choosehero();
                    break;
                case 1:
                    Characters(new Rogue());
                    Choosehero();
                    break;
                case 2:
                    Characters(new Magic_dude());
                    Choosehero();
                    break;
                case 3:
                    Characters(new Archer());
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
            constitutionlabel.Text = (Convert.ToDouble(constitutionlabel.Text) + 1).ToString();
        }

        private void labelstrenght_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textpoint_TextChanged(object sender, TextChangedEventArgs e)
        {  
            Convert.ToDouble(textpoint.Text).ToString();
             a -= 1;
        }
    }
}
