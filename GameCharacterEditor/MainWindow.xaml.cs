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
        }

       
    }
}
