using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Unit> unitLst = new List<Unit>();
        private double str = 0;
        private double intel = 0;
        private double dex = 0;
        private double cons = 0;
        private double extra;
        private int x = 0;

        public MainWindow()
        {
            InitializeComponent();
            GetAllItems();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            unitLst[x].PhysAttack();
            GetUnitInfo(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unitLst[x].PhysDefence();
            GetUnitInfo(x);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unitLst[x].MagicAttack();
            GetUnitInfo(x);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            unitLst[x].MagicDefence();
            GetUnitInfo(x);
        }

        private void Zeroing()
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warior = new Warrior();
                    GetUnitInfo(warior);
                    Zeroing();
                    break;
                case 1:
                    Rogue rogue = new Rogue(); //
                    GetUnitInfo(rogue);
                    Zeroing();
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer();
                    GetUnitInfo(sorcerer);
                    Zeroing();
                    break;
            }
        }

        private void GetUnitInfo(int index)
        {
            txthp.Text = unitLst[index].Hp.ToString();
            txtName.Text = unitLst[index].Name.ToString();
            txtExtra.Text = unitLst[index].Extra.ToString();
            txtStrength.Text = unitLst[index].Strength.ToString();
            txtDexterity.Text = unitLst[index].Dexterity.ToString();
            txtIntelegence.Text = unitLst[index].Intelegence.ToString();
            txtAttackSpeed.Text = unitLst[index].AttackSpeed.ToString();
            txtConstitution.Text = unitLst[index].Constitution.ToString();
            txtWalkingSpeed.Text = unitLst[index].WalkingSpeed.ToString();
            txtLvl.Text = unitLst[index].Lvl.ToString();
            txtExp.Text = unitLst[index].Experience.ToString();
            extra = Double.Parse(txtExtra.Text);

        }

        private void GetUnitInfo(Unit unit)
        {
            txthp.Text = unit.Hp.ToString();
            txtName.Text = unit.Name.ToString();
            txtExtra.Text = unit.Extra.ToString();
            txtStrength.Text = unit.Strength.ToString();
            txtDexterity.Text = unit.Dexterity.ToString();
            txtIntelegence.Text = unit.Intelegence.ToString();
            txtAttackSpeed.Text = unit.AttackSpeed.ToString();
            txtConstitution.Text = unit.Constitution.ToString();
            txtWalkingSpeed.Text = unit.WalkingSpeed.ToString();
            txtLvl.Text = unit.Lvl.ToString();
            extra = Double.Parse(txtExtra.Text);
            txtExp.Text = unit.Experience.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warrior = new Warrior(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    MessageBox.Show($"Unit is created {warrior.Name}");
                    unitLst.Add(warrior);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count - 1;
                    break;
                case 1:
                    Rogue rogue = new Rogue(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    MessageBox.Show($"Unit is created {rogue.Name}");
                    unitLst.Add(rogue);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count - 1;
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    MessageBox.Show($"Unit is created {sorcerer.Name}");
                    unitLst.Add(sorcerer);
                    GetUnitInfo(unitLst.Count - 1);
                    x = unitLst.Count - 1;
                    break;
            }
        }

        private void Render(int index)
        {
            List<string> itemLst = new List<string>();
            try
            {
                unitLst[index].Inventar.ExistItem.ForEach(item =>
                {
                    itemLst.Add(item.ToString().Substring(20) + "\n");
                });

                cmbBoxItem.ItemsSource = itemLst;
                GetUnitInfo(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удается отрендерить\n{ex.Message}");
            }
        }

        private void GetAllItems()
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
            }
            else
            {
                x = 0;
                Render(x);
            }
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (x - 1 >= 0)
            {
                x--;
                Render(x);
            }
            else
            {
                x = unitLst.Count - 1;
                Render(x);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].Inventar.Add(cmbBoxInventar.SelectedIndex, unitLst[x].Strength, unitLst[x].Dexterity, unitLst[x].Constitution, unitLst[x].Intelegence, unitLst[x].Lvl);
                unitLst[x].Hp += unitLst[x].Inventar.AllItems[x].Hp;
                unitLst[x].PAttack += unitLst[x].Inventar.AllItems[x].PDamage;
                unitLst[x].MAttack += unitLst[x].Inventar.AllItems[x].MDamage;
                unitLst[x].PDefence += unitLst[x].Inventar.AllItems[x].PDefence;
                unitLst[x].MDefence += unitLst[x].Inventar.AllItems[x].MDefence;
                unitLst[x].Strength += unitLst[x].Inventar.AllItems[x].Strength;
                unitLst[x].Dexterity += unitLst[x].Inventar.AllItems[x].Dexterity;
                unitLst[x].Intelegence += unitLst[x].Inventar.AllItems[x].Intelegence;
                unitLst[x].Intelegence += unitLst[x].Inventar.AllItems[x].Intelegence;
                unitLst[x].Constitution += unitLst[x].Inventar.AllItems[x].Constitution;
                Render(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            unitLst[x].Dexterity -= unitLst[x].Inventar.AllItems[x].Dexterity;
            unitLst[x].Intelegence -= unitLst[x].Inventar.AllItems[x].Intelegence;
            unitLst[x].Intelegence -= unitLst[x].Inventar.AllItems[x].Intelegence;
            unitLst[x].Constitution -= unitLst[x].Inventar.AllItems[x].Constitution;
            Render(x);
        }

        private void txtExp_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.Parse(txtExp.Text) != 0)
                txtLvl.Text = (int.Parse(txtExp.Text) / 1000).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (extra > 0)
            {
                txtStrength.Text = (int.Parse(txtStrength.Text) + 1).ToString();
                extra--;
                str++;
            }

            Refresh();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (extra > 0)
            {
                txtDexterity.Text = (int.Parse(txtDexterity.Text) + 1).ToString();
                extra--;
                dex++;
            }
            Refresh();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (extra > 0)
            {
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) + 1).ToString();
                extra--;
                intel++;
            }
            Refresh();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (extra > 0)
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) + 1).ToString();
                extra--;
                cons++;
            }
            Refresh();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //
        {
            if (int.Parse(txtDexterity.Text) - 1 >= 20 && dex > 0)
            {
                txtDexterity.Text = (int.Parse(txtDexterity.Text) - 1).ToString();
                extra++;
                dex--;
            }

            Refresh();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtIntelegence.Text) - 1 >= 20 && intel > 0)
            {
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) - 1).ToString();
                extra++;
                intel--;
            }
            Refresh();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtConstitution.Text) - 1 >= 20 && cons > 0)
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) - 1).ToString();
                extra++;
                cons--;
            }
            Refresh();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtStrength.Text) - 1 >= 20 && str > 0)
            {
                txtStrength.Text = (int.Parse(txtStrength.Text) - 1).ToString();
                extra++;
                str--;
            }
            Refresh();
        }

        private void Refresh()
        {
            txthp.Text = (int.Parse(txtStrength.Text) * 5 + int.Parse(txtConstitution.Text) * 10).ToString();
            txtAttackSpeed.Text = (int.Parse(txtDexterity.Text) * 5).ToString();
            txtWalkingSpeed.Text = (int.Parse(txtDexterity.Text) * 2).ToString();
            //pDefence += dexterity * 3 + constitution * 5;
            //mAttack += intelegence * 10;
            //mp += intelegence * 5;
            //mDefence += intelegence * 5;
            //pAttack = strength * 5;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtExp.Text = (int.Parse(txtExp.Text) + 1000).ToString();
        }

        private void txtLvl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.Parse(txtLvl.Text) > 1)
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) + 10).ToString();
                txtStrength.Text = (int.Parse(txtStrength.Text) + 10).ToString();
                txtDexterity.Text = (int.Parse(txtDexterity.Text) + 10).ToString();
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) + 10).ToString();
                txtExtra.Text = (int.Parse(txtExtra.Text) + 5).ToString();
                extra += 5;
            }
        }
    }
}