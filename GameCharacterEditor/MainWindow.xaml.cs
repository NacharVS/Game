using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //switch (cmbbox.SelectedIndex)
            //{
            //    case 0:
            //        Warrior warior = new Warrior();
            //        GetUnitInfo(warior);
            //        break;
            //    case 1:
            //        Rogue rogue = new Rogue();
            //        GetUnitInfo(rogue);
            //        break;
            //    case 2:
            //        Sorcerer sorcerer = new Sorcerer();
            //        GetUnitInfo(sorcerer);
            //        break;
            //}
        }

        private void GetUnitInfo(Unit unit)
        {
            txtStrength.Text = unit.Strength.ToString();
            txtDexterity.Text = unit.Dexterity.ToString();
            txtConstitution.Text = unit.Constitution.ToString();
            txtIntelegence.Text = unit.Intelegence.ToString();
            txtExtra.Text = unit.Extra.ToString();
            txtAttackSpeed.Text = unit.AttackSpeed.ToString();
            txtWalkingSpeed.Text = unit.WalkingSpeed.ToString();
            txthp.Text = unit.Hp.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warrior = new Warrior(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {warrior.Name}");
                    GetUnitInfo(warrior);
                    break;
                case 1:
                    Rogue rogue = new Rogue(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {rogue.Name}");
                    GetUnitInfo(rogue);
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {sorcerer.Name}");
                    GetUnitInfo(sorcerer);
                    break;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Inventar inventar = new Inventar();
            inventar.FillAllItemsList();
            List<string> lst = new List<string>();
            foreach (var item in inventar.AllItems)
            {
                lst.Add(item.ToString().Substring(20) + "\n");
            }
            cmbBoxInventar.ItemsSource = lst;
        }
    }
}
