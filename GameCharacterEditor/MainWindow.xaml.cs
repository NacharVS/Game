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
using System.IO;

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
        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            tb.Text = " You selected " + lbi.Content.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("person created!!!!!!!");
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
            inte.Text = new Warrior().InteligenceParameter.ToString(); 
            dext.Text = new Warrior().DexterityParameter.ToString();
            stre.Text = new Warrior().StrengthParameter.ToString();
            cons.Text = new Warrior().ConstitutionParameter.ToString();
            HealtPoints.Text = new Warrior().HealtPoints.ToString();
            PhysicalAttack.Text = new Warrior().PhysicalAttack.ToString();
            PhysicalDefence.Text = new Warrior().PhysicalDefence.ToString();
            MagicalAttack.Text = new Warrior().MagicalAttack.ToString();
            MagicalDefence.Text = new Warrior().MagicalDefence.ToString();
            WalkingSpeed.Text = new Warrior().WalkingSpeed.ToString();
            AttackSpeed.Text = new Warrior().AttackSpeed.ToString();
            ManaPoints.Text = new Warrior().ManaPoints.ToString();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            inte.Text = new Sorcerer().InteligenceParameter.ToString();
            dext.Text = new Sorcerer().DexterityParameter.ToString();
            stre.Text = new Sorcerer().StrengthParameter.ToString();
            cons.Text = new Sorcerer().ConstitutionParameter.ToString();
            HealtPoints.Text = new Sorcerer().HealtPoints.ToString();
            PhysicalAttack.Text = new Sorcerer().PhysicalAttack.ToString();
            PhysicalDefence.Text = new Sorcerer().PhysicalDefence.ToString();
            MagicalAttack.Text = new Sorcerer().MagicalAttack.ToString();
            MagicalDefence.Text = new Sorcerer().MagicalDefence.ToString();
            WalkingSpeed.Text = new Sorcerer().WalkingSpeed.ToString();
            AttackSpeed.Text = new Sorcerer().AttackSpeed.ToString();
            ManaPoints.Text = new Sorcerer().ManaPoints.ToString();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            inte.Text = new Archer().InteligenceParameter.ToString();
            dext.Text = new Archer().DexterityParameter.ToString();
            stre.Text = new Archer().StrengthParameter.ToString();
            cons.Text = new Archer().ConstitutionParameter.ToString();
            HealtPoints.Text = new Archer().HealtPoints.ToString();
            PhysicalAttack.Text = new Archer().PhysicalAttack.ToString();
            PhysicalDefence.Text = new Archer().PhysicalDefence.ToString();
            MagicalAttack.Text = new Archer().MagicalAttack.ToString();
            MagicalDefence.Text = new Archer().MagicalDefence.ToString();
            WalkingSpeed.Text = new Archer().WalkingSpeed.ToString();
            AttackSpeed.Text = new Archer().AttackSpeed.ToString();
            ManaPoints.Text = new Archer().ManaPoints.ToString();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Window1 win1 = new Window1();
        //    win1.Show();
        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}