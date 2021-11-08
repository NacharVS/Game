using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // дефолтное значение message box
    public partial class MainWindow : Window
    {
        private List<Unit> unitLst = new List<Unit>();
        private double str = 0;
        private double intel = 0;
        private double dex = 0;
        private double cons = 0;
        private double extra;
        private bool bodyArmor;
        private bool helmet;
        private bool weapon;
        private int maxExp = 1000;
        private int currentExp = 0;
        private int x = 0;

        public MainWindow()
        {
            InitializeComponent();
            btnHiiden();
            //unitLst = Unit.TakeList();
            GetAllItems();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].PhysAttack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{unitLst[x].Name} {ex.Message}");
            }
            GetUnitInfo(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].PhysDefence();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{unitLst[x].Name} {ex.Message}");
            }
            GetUnitInfo(x);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].MagicAttack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{unitLst[x].Name} {ex.Message}");
            }
            GetUnitInfo(x);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                unitLst[x].MagicDefence();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{unitLst[x].Name} {ex.Message}");
            }
            GetUnitInfo(x);
        }

        private void CheckStats()
        {

        }

        private void btnVisibility()
        {
            btnAddExp500.Visibility = Visibility.Visible;
            btnAddExp1000.Visibility = Visibility.Visible;
            btnAddExp250.Visibility = Visibility.Visible;
            btnPAttack.Visibility = Visibility.Visible;
            btnMAttack.Visibility = Visibility.Visible;
            btnPDefence.Visibility = Visibility.Visible;
            btnMDefence.Visibility = Visibility.Visible;
            //btnConsPls.Visibility = Visibility.Visible;
            //btnconsmns.Visibility = Visibility.Visible;
            //btndexmns.Visibility = Visibility.Visible;
            //btndexpls.Visibility = Visibility.Visible;
            //btnstrmns.Visibility = Visibility.Visible;
            //btnstrpls.Visibility = Visibility.Visible;
            //btnintelmns.Visibility = Visibility.Visible;
            //btnIntelpls.Visibility = Visibility.Visible;
        }

        private void btnHiiden()
        {
            btnAddExp500.Visibility = Visibility.Hidden;
            btnAddExp1000.Visibility = Visibility.Hidden;
            btnAddExp250.Visibility = Visibility.Hidden;
            btnPAttack.Visibility = Visibility.Hidden;
            btnMAttack.Visibility = Visibility.Hidden;
            btnPDefence.Visibility = Visibility.Hidden;
            btnMDefence.Visibility = Visibility.Hidden;
            //btnConsPls.Visibility = Visibility.Hidden;
            //btnconsmns.Visibility = Visibility.Hidden;
            //btndexmns.Visibility = Visibility.Hidden;
            //btndexpls.Visibility = Visibility.Hidden;
            //btnstrmns.Visibility = Visibility.Hidden;
            //btnstrpls.Visibility = Visibility.Hidden;
            //btnintelmns.Visibility = Visibility.Hidden;
            //btnIntelpls.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warior = new Warrior();
                    GetUnitInfo(warior);
                    maxExp = 1000;
                    currentExp = 0;
                    break;
                case 1:
                    Rogue rogue = new Rogue(); //
                    GetUnitInfo(rogue);
                    maxExp = 1000;
                    currentExp = 0;
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer();
                    GetUnitInfo(sorcerer);
                    maxExp = 1000;
                    currentExp = 0;
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
            txtExp.Text = unitLst[index].Experience.ToString();
            txtLvl.Text = unitLst[index].Lvl.ToString();
            extra = double.Parse(txtExtra.Text);
            cons = unitLst[x].Cons;
            intel = unitLst[x].Intel;
            dex = unitLst[x].Dex;
            str = unitLst[x].Str;
            extra = unitLst[x].Extra;
            txtExtra.Text = extra.ToString();
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
            extra = double.Parse(txtExtra.Text);
            txtExp.Text = unit.Experience.ToString();
            txtLvl.Text = unit.Lvl.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (cmbbox.SelectedIndex)
            {
                case 0:
                    Warrior warrior = new Warrior(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    Unit.Add(warrior);
                    MessageBox.Show($"Unit is created and added to database {warrior.Name}");
                    //unitLst = Unit.TakeList();
                    unitLst.Add(warrior);
                    x = unitLst.Count - 1;
                    GetUnitInfo(unitLst.Count - 1);
                    btnVisibility();
                    Render(x);
                    break;
                case 1:
                    Rogue rogue = new Rogue(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    Unit.Add(rogue);
                    MessageBox.Show($"Unit is created and added to database {rogue.Name}");
                    //unitLst = Unit.TakeList();
                    unitLst.Add(rogue);
                    x = unitLst.Count - 1;
                    GetUnitInfo(unitLst.Count - 1);
                    btnVisibility();
                    Render(x);
                    break;
                case 2:
                    Sorcerer sorcerer = new Sorcerer(Double.Parse(txtStrength.Text), Double.Parse(txtDexterity.Text), Double.Parse(txtConstitution.Text), Double.Parse(txtIntelegence.Text), txtName.Text, int.Parse(txtLvl.Text));
                    Unit.Add(sorcerer);
                    MessageBox.Show($"Unit is created and added to database {sorcerer.Name}");
                    //unitLst = Unit.TakeList();
                    unitLst.Add(sorcerer);
                    x = unitLst.Count - 1;
                    GetUnitInfo(unitLst.Count - 1);
                    btnVisibility();
                    Render(x);
                    break;
            }
        }

        private void Render(int index)
        {
            //List<string> itemLst = new List<string>();
            //try
            //{
            //    foreach (var item in unitLst[index].Inventar.ExistItem)
            //    {
            //        itemLst.Add(item.ToString().Substring(20) + "\n");
            //    }

            //    cmbBoxItem.ItemsSource = itemLst;
            //    GetUnitInfo(x);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Не удается отрендерить\n{ex.Message}");
            //}
        }

        private void GetAllItems()
        {
            Inventar inventar = new Inventar();
            List<string> lst = new List<string>();

            inventar.AllItems.ForEach(item =>
            {
                lst.Add(item.ToString().Substring(20) + "\n");
            });

            //cmbBoxInventar.ItemsSource = lst;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (x + 1 <= unitLst.Count - 1)
            {
                x++;
            }
            else
            {
                x = 0;
            }
            Render(x);
            //Update();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (x - 1 >= 0)
            {
                x--;
            }
            else
            {
                x = unitLst.Count - 1;
            }
            Render(x);
            //Update();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = cmbBoxInventar.SelectedItem.ToString().Replace("\n", "").Substring(38);
                unitLst[x].Inventar.Add(name, unitLst[x]);
                if (name == "Robe" || name == "Leather")
                    cmbBoxItem.Items.Add(unitLst[x].Inventar.bodyArmor.ToString().Substring(20));
                else if (name == "RobeHelmet")
                    cmbBoxItem.Items.Add(unitLst[x].Inventar.helmet.ToString().Substring(20));
                else if (name == "Axe" || name == "One Handed Sword" || name == "Two Handed Sword")
                    cmbBoxItem.Items.Add(unitLst[x].Inventar.weapon.ToString().Substring(20));
                //unitLst = Unit.TakeList();
                Render(x);
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
                //Thread.Sleep(2000);
                //Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update()
        {
            try
            {
                MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
                IMongoDatabase db = client.GetDatabase("Units");
                IMongoCollection<Unit> data = db.GetCollection<Unit>("unit_collection");
                var UpdateDef = Builders<Unit>.Update.Set("Lvl", int.Parse(txtLvl.Text)).Set("Hp", double.Parse(txthp.Text)).Set("Mp", unitLst[x].Mp).Set("Name", txtName.Text).Set("Extra", double.Parse(txtExtra.Text)).Set("Strength", double.Parse(txtStrength.Text)).Set("Dexterity", double.Parse(txtDexterity.Text)).Set("Intelegence", double.Parse(txtIntelegence.Text)).Set("AttackSpeed", unitLst[x].AttackSpeed).Set("Constitution", double.Parse(txtConstitution.Text)).Set("WalkingSpeed", unitLst[x].WalkingSpeed).Set("PDefence", unitLst[x].PDefence).Set("MDefence", unitLst[x].MDefence).Set("PAttack", unitLst[x].PAttack).Set("MAttack", unitLst[x].MAttack).Set("Experience", double.Parse(txtExp.Text)).Set("Cons", cons).Set("Dex", dex).Set("Str", str).Set("Intel", intel).Set("Extra", extra);
                data.UpdateOne(basa => basa._id == unitLst[x]._id, UpdateDef);
                unitLst = Unit.TakeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить данные персонажа в базе\n" + ex.Message);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                //unitLst[x].Inventar.Delete(cmbBoxItem.SelectedIndex);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetExp(int k)
        {
            txtExp.Text = (int.Parse(txtExp.Text) + k).ToString();
            currentExp += k;
            if (currentExp >= maxExp && int.Parse(txtLvl.Text) < 9)
            {
                currentExp = maxExp;
                txtLvl.Text = (int.Parse(txtLvl.Text) + 1).ToString();
                maxExp = currentExp + 1000 * int.Parse(txtLvl.Text);
                LvlUpdate();
            }

            //FillInfo();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (extra > 0 && (int.Parse(txtStrength.Text) < unitLst[x].MaxStr))
            {
                txtStrength.Text = (int.Parse(txtStrength.Text) + 1).ToString();
                extra--;
                str++;
            }

            Refresh();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (extra > 0 && (int.Parse(txtDexterity.Text) < unitLst[x].MaxDex))
            {
                txtDexterity.Text = (int.Parse(txtDexterity.Text) + 1).ToString();
                extra--;
                dex++;
            }
            Refresh();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (extra > 0 && (int.Parse(txtIntelegence.Text) < unitLst[x].MaxIntel))
            {
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) + 1).ToString();
                extra--;
                intel++;
            }
            Refresh();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (extra > 0 && (int.Parse(txtConstitution.Text) < unitLst[x].MaxCons))
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) + 1).ToString();
                extra--;
                cons++;
            }
            Refresh();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //
        {
            if (int.Parse(txtDexterity.Text) - 1 >= extra && dex > 0)
            {
                txtDexterity.Text = (int.Parse(txtDexterity.Text) - 1).ToString();
                extra++;
                dex--;
            }
            Refresh();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtIntelegence.Text) - 1 >= extra && intel > 0)
            {
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) - 1).ToString();
                extra++;
                intel--;
            }
            Refresh();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtConstitution.Text) - 1 >= extra && cons > 0)
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) - 1).ToString();
                extra++;
                cons--;
            }
            Refresh();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtStrength.Text) - 1 >= extra && str > 0)
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
            txtExtra.Text = extra.ToString(); // добавлен
            FillInfo();
            //Update();
            //pDefence += dexterity * 3 + constitution * 5;
            //mAttack += intelegence * 10;
            //mp += intelegence * 5;
            //mDefence += intelegence * 5;
            //pAttack = strength * 5;
        }

        private void FillInfo()
        {
            try
            {
                unitLst[x].AttackSpeed = double.Parse(txtAttackSpeed.Text);
                unitLst[x].Constitution = double.Parse(txtConstitution.Text);
                unitLst[x].Dexterity = double.Parse(txtDexterity.Text);
                unitLst[x].Intelegence = double.Parse(txtIntelegence.Text);
                unitLst[x].Strength = double.Parse(txtStrength.Text);
                unitLst[x].Experience = double.Parse(txtExp.Text);
                unitLst[x].Extra = double.Parse(txtExtra.Text);
                unitLst[x].Hp = double.Parse(txthp.Text);
                unitLst[x].Lvl = int.Parse(txtLvl.Text);
                unitLst[x].Cons = cons;
                unitLst[x].Dex = dex;
                unitLst[x].Intel = intel;
                unitLst[x].Str = str;
                unitLst[x].Name = txtName.Text;
                unitLst[x].WalkingSpeed = double.Parse(txtWalkingSpeed.Text);
            }
            catch { }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtLvl.Text) < 9 || !Check())
            {
                txtExp.Text = (int.Parse(txtExp.Text) + 500).ToString();
                currentExp += 500;
            }
        }

        private void LvlUpdate()
        {
            if (int.Parse(txtLvl.Text) > 1 && int.Parse(txtLvl.Text) < 9 && !Check())
            {
                txtConstitution.Text = (int.Parse(txtConstitution.Text) + 10).ToString();
                txtStrength.Text = (int.Parse(txtStrength.Text) + 10).ToString();
                txtDexterity.Text = (int.Parse(txtDexterity.Text) + 10).ToString();
                txtIntelegence.Text = (int.Parse(txtIntelegence.Text) + 10).ToString();
                txtExtra.Text = (int.Parse(txtExtra.Text) + 5).ToString();
                extra += 5;
                unitLst[x].Extra = extra;
                Refresh();
            }
            else if (int.Parse(txtLvl.Text) > 1 || Check())
            {
                MessageBox.Show("Достигнут максимальный уровень");
                btnAddExp500.Visibility = Visibility.Hidden;
                btnAddExp1000.Visibility = Visibility.Hidden;
                btnAddExp250.Visibility = Visibility.Hidden;
            }
            try
            {
                if (int.Parse(txtConstitution.Text) >= unitLst[x].MaxCons)
                {
                    txtConstitution.Text = unitLst[x].MaxCons.ToString();
                }
                if (int.Parse(txtDexterity.Text) >= unitLst[x].MaxDex)
                {
                    txtDexterity.Text = unitLst[x].MaxDex.ToString();
                }
                if (int.Parse(txtIntelegence.Text) >= unitLst[x].MaxIntel)
                {
                    txtIntelegence.Text = unitLst[x].MaxIntel.ToString();
                }
                if (int.Parse(txtStrength.Text) >= unitLst[x].MaxStr)
                {
                    txtStrength.Text = unitLst[x].MaxStr.ToString();
                }
            }
            catch { }
        }

        private bool Check()
        {
            try
            {
                if (int.Parse(txtConstitution.Text) >= unitLst[x].MaxCons && int.Parse(txtDexterity.Text) >= unitLst[x].MaxDex && int.Parse(txtIntelegence.Text) >= unitLst[x].MaxIntel && int.Parse(txtStrength.Text) >= unitLst[x].MaxStr)
                    return true;
            }
            catch
            {
                throw new Exception("Стата достигла максимального кол-ва");
            }

            return false;
        }

        private void btnAddExp1000_Click(object sender, RoutedEventArgs e)
        {
            GetExp(1000);
        }

        private void btnAddExp250_Click(object sender, RoutedEventArgs e)
        {
            GetExp(250);
        }

        private void btnAddExp500_Click(object sender, RoutedEventArgs e)
        {
            GetExp(500);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (bodyArmor)
            {
                string name = cmbBoxBodyArmor.SelectedItem.ToString().Replace("\n", "").Substring(38);
                unitLst[x].Inventar.Add(name, unitLst[x]);
                lstView.Items.Add(name);
                bodyArmor = false;
            }
        }

        private void cmbBoxBodyArmor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bodyArmor = true;
        }

        private void cmbBoxHelmet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            helmet = true;
        }

        private void cmbBoxWeapon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            weapon = true;
        }
    }
}