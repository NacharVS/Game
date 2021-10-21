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
        Sorcerer sorc = new Sorcerer();
        Archer arc = new Archer();
        Warrior war = new Warrior();

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

            inte.Clear();
            inte.Text = war.InteligenceParameter.ToString();
            dext.Clear();
            dext.Text = war.DexterityParameter.ToString();
            stre.Clear();
            stre.Text = war.StrengthParameter.ToString();
            cons.Clear();
            cons.Text = war.ConstitutionParameter.ToString();
            HealtPoints.Text = war.HealtPoints.ToString();
            PhysicalAttack.Text = war.PhysicalAttack.ToString();
            PhysicalDefence.Text = war.PhysicalDefence.ToString();
            MagicalAttack.Text = war.MagicalAttack.ToString();
            MagicalDefence.Text = war.MagicalDefence.ToString();
            WalkingSpeed.Text = war.WalkingSpeed.ToString();
            AttackSpeed.Text = war.AttackSpeed.ToString();
            ManaPoints.Text = war.ManaPoints.ToString();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            inte.Clear();
            inte.Text = sorc.InteligenceParameter.ToString();
            dext.Clear();
            dext.Text = sorc.DexterityParameter.ToString();
            stre.Clear();
            stre.Text = sorc.StrengthParameter.ToString();
            cons.Clear();
            cons.Text = sorc.ConstitutionParameter.ToString();
            HealtPoints.Text = sorc.HealtPoints.ToString();
            PhysicalAttack.Text = sorc.PhysicalAttack.ToString();
            PhysicalDefence.Text = sorc.PhysicalDefence.ToString();
            MagicalAttack.Text = sorc.MagicalAttack.ToString();
            MagicalDefence.Text = sorc.MagicalDefence.ToString();
            WalkingSpeed.Text = sorc.WalkingSpeed.ToString();
            AttackSpeed.Text = sorc.AttackSpeed.ToString();
            ManaPoints.Text = sorc.ManaPoints.ToString();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            inte.Clear();
            inte.Text = arc.InteligenceParameter.ToString();
            dext.Clear();
            dext.Text = arc.DexterityParameter.ToString();
            stre.Clear();
            stre.Text = arc.StrengthParameter.ToString();
            cons.Clear();
            cons.Text = arc.ConstitutionParameter.ToString();
            HealtPoints.Text = arc.HealtPoints.ToString();
            PhysicalAttack.Text = arc.PhysicalAttack.ToString();
            PhysicalDefence.Text = arc.PhysicalDefence.ToString();
            MagicalAttack.Text = arc.MagicalAttack.ToString();
            MagicalDefence.Text = arc.MagicalDefence.ToString();
            WalkingSpeed.Text = arc.WalkingSpeed.ToString();
            AttackSpeed.Text = arc.AttackSpeed.ToString();
            ManaPoints.Text = arc.ManaPoints.ToString();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(points.Text) > 0)
            {
                arc.StrengthParameter += 1;
                war.StrengthParameter += 1;
                sorc.StrengthParameter += 1;
                stre.Text = sorc.StrengthParameter.ToString();
                stre.Text = war.StrengthParameter.ToString();
                points.Text = (Convert.ToDouble(points.Text) - 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(points.Text) > 0)
            {
                dext.Text = (Convert.ToDouble(dext.Text) + 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) - 1).ToString();
            }
            else
                MessageBox.Show("no");

          
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(points.Text) > 0)
            {
                cons.Text = (Convert.ToDouble(cons.Text) + 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) - 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(points.Text) > 0)
            {
                inte.Text = (Convert.ToDouble(inte.Text) + 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) - 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(stre.Text) > 0)
            {
                stre.Text = (Convert.ToDouble(stre.Text) - 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) + 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(cons.Text) > 0) 
            { 
                cons.Text = (Convert.ToDouble(cons.Text) - 1).ToString();
            points.Text = (Convert.ToDouble(points.Text) + 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(dext.Text) > 0)
            {
                dext.Text = (Convert.ToDouble(dext.Text) - 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) + 1).ToString();
            }
            else
                MessageBox.Show("no");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(inte.Text) > 0)
            {
                inte.Text = (Convert.ToDouble(inte.Text) - 1).ToString();
                points.Text = (Convert.ToDouble(points.Text) + 1).ToString();
            }
            else
                MessageBox.Show("no");
        }
    }
}