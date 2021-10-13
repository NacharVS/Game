// сделать изменение и добавление имени юнита

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
using System.Windows.Shapes;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Unit> unitLst = new List<Unit>();
        int x = 0;

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

        private void GetUnitInfo(int index)
        {
            txtStrength.Text = unitLst[index].Strength.ToString();
            txtDexterity.Text = unitLst[index].Dexterity.ToString();
            txtConstitution.Text = unitLst[index].Constitution.ToString();
            txtIntelegence.Text = unitLst[index].Intelegence.ToString();
            txtExtra.Text = unitLst[index].Extra.ToString();
            txtAttackSpeed.Text = unitLst[index].AttackSpeed.ToString();
            txtWalkingSpeed.Text = unitLst[index].WalkingSpeed.ToString();
            txthp.Text = unitLst[index].Hp.ToString();
            txtName.Text = unitLst[index].Name.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warrior = new Warrior(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {warrior.Name}");
                    unitLst.Add(warrior);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count;
                    break;
                case 1:
                    Rogue rogue = new Rogue(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {rogue.Name}");
                    unitLst.Add(rogue);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count;
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text));
                    MessageBox.Show($"Unit is created {sorcerer.Name}");
                    unitLst.Add(sorcerer);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count;
                    break;
            }
        }

        private void Render(int index)
        {
            List<string> itemLst = new List<string>();
            foreach (var item in unitLst[index].Inventar.ExistItem)
            {
                itemLst.Add(item.ToString().Substring(20) + "\n");
            }

            cmbBoxItem.ItemsSource = itemLst;
            GetUnitInfo(x);
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

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (x + 1 <= unitLst.Count - 1)
            {
                x++;
                GetUnitInfo(x);
            }
            else
            {
                x = 0;
                GetUnitInfo(x);
            }
        }

        // индекс выходит за пределы, исправить
        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (x - 1 <= 0)
            {
                x--;
                GetUnitInfo(x);
            }
            else
            {
                x = unitLst.Count - 1;
                GetUnitInfo(x);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            unitLst[x].Inventar.Add(cmbBoxInventar.SelectedIndex);
            unitLst[x].Hp += unitLst[x].Inventar.AllItems[x].Hp;
            Render(x);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            unitLst[x].Inventar.Delete(cmbBoxItem.SelectedIndex);
            unitLst[x].Hp -= unitLst[x].Inventar.AllItems[x].Hp;
            Render(x);
        }
    }
}
