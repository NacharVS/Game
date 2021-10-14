// доделать инвентарь (шлем)
// не работает кнопка назад

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
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warior = new Warrior();
                    GetUnitInfo(warior);
                    break;
                case 1:
                    Rogue rogue = new Rogue();
                    GetUnitInfo(rogue);
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer();
                    GetUnitInfo(sorcerer);
                    break;
            }
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
            txtName.Text = unit.Name.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warrior = new Warrior(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text);
                    MessageBox.Show($"Unit is created {warrior.Name}");
                    unitLst.Add(warrior);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count;
                    break;
                case 1:
                    Rogue rogue = new Rogue(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text);
                    MessageBox.Show($"Unit is created {rogue.Name}");
                    unitLst.Add(rogue);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count;
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text);
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
            unitLst[index].Inventar.ExistItem.ForEach(item =>
            {
                itemLst.Add(item.ToString().Substring(20) + "\n");
            });

            cmbBoxItem.ItemsSource = itemLst;
            GetUnitInfo(x);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Inventar inventar = new Inventar();
            inventar.FillAllItemsList();
            List<string> lst = new List<string>();

            inventar.AllItems.ForEach(item =>
            {
                lst.Add(item.ToString().Substring(20) + "\n");
            });

            cmbBoxInventar.ItemsSource = lst;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (x + 1 <= unitLst.Count - 1)
            {
                x++;
                Render(x);
                GetUnitInfo(x);
            }
            else
            {
                x = 0;
                Render(x);
                GetUnitInfo(x);
            }
        }

        // индекс выходит за пределы, исправить
        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (x - 1 >= 0)
            {
                x--;
                Render(x);
                GetUnitInfo(x);
            }
            else
            {
                x = unitLst.Count - 1;
                Render(x);
                GetUnitInfo(x);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].Inventar.Add(cmbBoxInventar.SelectedIndex, unitLst[x].Strength, unitLst[x].Dexterity, unitLst[x].Constitution, unitLst[x].Intelegence, unitLst[x].Lvl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            unitLst[x].Hp += unitLst[x].Inventar.AllItems[x].Hp;
            unitLst[x].PAttack += unitLst[x].Inventar.AllItems[x].PDamage;
            unitLst[x].MAttack += unitLst[x].Inventar.AllItems[x].MDamage;
            unitLst[x].PDefence += unitLst[x].Inventar.AllItems[x].PDefence;
            unitLst[x].MDefence += unitLst[x].Inventar.AllItems[x].MDefence;
            unitLst[x].Strength += unitLst[x].Inventar.AllItems[x].Strength;
            unitLst[x].Intelegence += unitLst[x].Inventar.AllItems[x].Intelegence;
            unitLst[x].Constitution += unitLst[x].Inventar.AllItems[x].Constitution;
            unitLst[x].Dexterity += unitLst[x].Inventar.AllItems[x].Dexterity;
            unitLst[x].Intelegence += unitLst[x].Inventar.AllItems[x].Intelegence;
            Render(x);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            unitLst[x].Inventar.Delete(cmbBoxItem.SelectedIndex);
            unitLst[x].Hp -= unitLst[x].Inventar.AllItems[x].Hp;
            unitLst[x].PAttack -= unitLst[x].Inventar.AllItems[x].PDamage;
            unitLst[x].MAttack -= unitLst[x].Inventar.AllItems[x].MDamage;
            unitLst[x].PDefence -= unitLst[x].Inventar.AllItems[x].PDefence;
            unitLst[x].MDefence -= unitLst[x].Inventar.AllItems[x].MDefence;
            unitLst[x].Strength -= unitLst[x].Inventar.AllItems[x].Strength;
            unitLst[x].Intelegence -= unitLst[x].Inventar.AllItems[x].Intelegence;
            unitLst[x].Constitution -= unitLst[x].Inventar.AllItems[x].Constitution;
            unitLst[x].Dexterity -= unitLst[x].Inventar.AllItems[x].Dexterity;
            unitLst[x].Intelegence -= unitLst[x].Inventar.AllItems[x].Intelegence;
            Render(x);
        }

        private void txtExp_TextChanged(object sender, TextChangedEventArgs e)
        {
            unitLst[x].Lvl = int.Parse(txtExp.Text) / 1000;
            //txtExp.Text = 
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtStrength.Text = (int.Parse(txtStrength.Text) + 1).ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtDexterity.Text = (int.Parse(txtDexterity.Text) + 1).ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txtIntelegence.Text = (int.Parse(txtIntelegence.Text) + 1).ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txtConstitution.Text = (int.Parse(txtConstitution.Text) + 1).ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            txtDexterity.Text = (int.Parse(txtDexterity.Text) - 1).ToString();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            txtIntelegence.Text = (int.Parse(txtIntelegence.Text) - 1).ToString();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            txtConstitution.Text = (int.Parse(txtConstitution.Text) - 1).ToString();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            txtStrength.Text = (int.Parse(txtStrength.Text) - 1).ToString();
        }
    }
}
