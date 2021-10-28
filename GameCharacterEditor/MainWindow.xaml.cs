using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using GameCharacterEditor.Classes;
using GameCharacterEditor.Models;
using GameCharacterEditor.Logic;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoModel> _todoData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseWarrior_Click(object sender, RoutedEventArgs e)
        {
            PickButton.IsEnabled = Strenght_down.IsEnabled = Strenght_up.IsEnabled = Constitution_down.IsEnabled = Constitution_up.IsEnabled =
            Dexterity_down.IsEnabled = Dexterity_up.IsEnabled = Intelligence_down.IsEnabled = Intelligence_up.IsEnabled = ExpButton.IsEnabled = true;

            if (ChooseWarriorRB.IsChecked == true)
            {
                var warrior = new Warrior();

                HP_TB.Text = warrior.HealthPoint.ToString();
                MP_TB.Text = warrior.ManaPoint.ToString();
                Strenght_TB.Text = warrior.Strenght.ToString();
                Dexterity_TB.Text = warrior.Dexterity.ToString();
                Intelligence_TB.Text = warrior.Intelligence.ToString();
                Constitution_TB.Text = warrior.Constitution.ToString();
                Extra_TB.Text = warrior.Extra.ToString();
                PA_TB.Text = warrior.PAttack.ToString();
                MA_TB.Text = warrior.MAttack.ToString();
                PR_TB.Text = warrior.PResist.ToString();
                MR_TB.Text = warrior.MResist.ToString();
                AS_TB.Text = warrior.AttackSpeed.ToString();
                MS_TB.Text = warrior.WalkSpeed.ToString();
                LevelBlock.Text = warrior.Level.ToString();
            }

            else if (ChooseRogueRB.IsChecked == true)
            {
                var rogue = new Rogue();

                HP_TB.Text = rogue.HealthPoint.ToString();
                MP_TB.Text = rogue.ManaPoint.ToString();
                Strenght_TB.Text = rogue.Strenght.ToString();
                Dexterity_TB.Text = rogue.Dexterity.ToString();
                Intelligence_TB.Text = rogue.Intelligence.ToString();
                Constitution_TB.Text = rogue.Constitution.ToString();
                Extra_TB.Text = rogue.Extra.ToString();
                PA_TB.Text = rogue.PAttack.ToString();
                MA_TB.Text = rogue.MAttack.ToString();
                PR_TB.Text = rogue.PResist.ToString();
                MR_TB.Text = rogue.MResist.ToString();
                AS_TB.Text = rogue.AttackSpeed.ToString();
                MS_TB.Text = rogue.WalkSpeed.ToString();
                LevelBlock.Text = rogue.Level.ToString();
            }
            else if (ChooseSorcererRB.IsChecked == true)
            {
                var sorcerer = new Sorcerer();

                HP_TB.Text = sorcerer.HealthPoint.ToString();
                MP_TB.Text = sorcerer.ManaPoint.ToString();
                Strenght_TB.Text = sorcerer.Strenght.ToString();
                Dexterity_TB.Text = sorcerer.Dexterity.ToString();
                Intelligence_TB.Text = sorcerer.Intelligence.ToString();
                Constitution_TB.Text = sorcerer.Constitution.ToString();
                Extra_TB.Text = sorcerer.Extra.ToString();
                PA_TB.Text = sorcerer.PAttack.ToString();
                MA_TB.Text = sorcerer.MAttack.ToString();
                PR_TB.Text = sorcerer.PResist.ToString();
                MR_TB.Text = sorcerer.MResist.ToString();
                AS_TB.Text = sorcerer.AttackSpeed.ToString();
                MS_TB.Text = sorcerer.WalkSpeed.ToString();
                LevelBlock.Text = sorcerer.Level.ToString();
            }
            else
            {
                MessageBox.Show("Something goes wrong...");
            }
        }

        private void ExtraBuff_Click(object sender, RoutedEventArgs e)
        {
            int ex = int.Parse(Extra_TB.Text);

            if (ex > 0)
            {
                --ex;
                Extra_TB.Text = ex.ToString();
            }
            else
            {
                MessageBox.Show("It's not enough extra points!");
                return;
            }

            string bttn = (string)((Button)sender).Name;

            switch(bttn)
            {
                case "Strenght_up":
                    Strenght_TB.Text = (Convert.ToInt32(Strenght_TB.Text) + 1).ToString();
                    break;
                case "Constitution_up":
                    Constitution_TB.Text = (Convert.ToInt32(Constitution_TB.Text) + 1).ToString();
                    break;
                case "Dexterity_up":
                    Dexterity_TB.Text = (Convert.ToInt32(Dexterity_TB.Text) + 1).ToString();
                    break;
                case "Intelligence_up":
                    Intelligence_TB.Text = (Convert.ToInt32(Intelligence_TB.Text) + 1).ToString();
                    break;
            }

            StatsChanger();          
        }

        private void ExtraDebuff_Click(object sender, RoutedEventArgs e)
        {
            int ex = Convert.ToInt32(Extra_TB.Text);
            string bttn = (string)((Button)sender).Name;

            if(ex < 5)
            {
                ex++;
                Extra_TB.Text = ex.ToString();

                switch (bttn)
                {
                    case "Strenght_down":
                        Strenght_TB.Text = (Convert.ToInt32(Strenght_TB.Text) - 1).ToString();
                        break;
                    case "Constitution_down":
                        Constitution_TB.Text = (Convert.ToInt32(Constitution_TB.Text) - 1).ToString();
                        break;
                    case "Dexterity_down":
                        Dexterity_TB.Text = (Convert.ToInt32(Dexterity_TB.Text) - 1).ToString();
                        break;
                    case "Intelligence_down":
                        Intelligence_TB.Text = (Convert.ToInt32(Intelligence_TB.Text) - 1).ToString();
                        break;
                }

            }
        }

        private void PickButton_Click(object sender, RoutedEventArgs e)
        {
            string name;

            if (ChooseWarriorRB.IsChecked == true)
            {
                Warrior war = new Warrior();
                war.Strenght = Convert.ToInt32(Strenght_TB.Text);
                war.Constitution = Convert.ToInt32(Constitution_TB.Text);
                war.Dexterity = Convert.ToInt32(Dexterity_TB.Text);
                war.Intelligence = Convert.ToInt32(Intelligence_TB.Text);
                war.Extra = Convert.ToInt32(Extra_TB.Text);
                war.Level = Convert.ToInt32(LevelBlock.Text);
                name = "Warrior";
                war.AddToDataBase(war);
            }

            else if (ChooseRogueRB.IsChecked == true)
            {
                Rogue rogue = new Rogue();
                rogue.Strenght = Convert.ToInt32(Strenght_TB.Text);
                rogue.Constitution = Convert.ToInt32(Constitution_TB.Text);
                rogue.Dexterity = Convert.ToInt32(Dexterity_TB.Text);
                rogue.Intelligence = Convert.ToInt32(Intelligence_TB.Text);
                rogue.Extra = Convert.ToInt32(Extra_TB.Text);
                rogue.Level = Convert.ToInt32(LevelBlock.Text);
                name = "Rogue";
                rogue.AddToDataBase(rogue);
            }
            else
            {
                Sorcerer sorc = new Sorcerer();
                sorc.Strenght = Convert.ToInt32(Strenght_TB.Text);
                sorc.Constitution = Convert.ToInt32(Constitution_TB.Text);
                sorc.Dexterity = Convert.ToInt32(Dexterity_TB.Text);
                sorc.Intelligence = Convert.ToInt32(Intelligence_TB.Text);
                sorc.Extra = Convert.ToInt32(Extra_TB.Text);
                sorc.Level = Convert.ToInt32(LevelBlock.Text);
                name = "Sorcerer";
                sorc.AddToDataBase(sorc);
            }

            //_todoData = new BindingList<TodoModel>()
            //{
            //    new TodoModel()
            //    {
            //        Character = name, HP = int.Parse(HP_TB.Text), MP = int.Parse(MP_TB.Text),
            //        Strenght = int.Parse(Strenght_TB.Text), Dexterity = int.Parse(Dexterity_TB.Text), Intelligence = int.Parse(Intelligence_TB.Text),
            //        Constitution = int.Parse(Constitution_TB.Text), PAttack = int.Parse(PA_TB.Text), MAttack = int.Parse(MA_TB.Text),
            //        PResist = int.Parse(PR_TB.Text), MResist = int.Parse(MR_TB.Text), ASpeed = int.Parse(AS_TB.Text), MSpeed = int.Parse(MS_TB.Text)
            //    }
            //};

            //CharacterList.Items.Add(_todoData);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PickButton.IsEnabled = Strenght_down.IsEnabled = Strenght_up.IsEnabled = Constitution_down.IsEnabled = Constitution_up.IsEnabled =
            Dexterity_down.IsEnabled = Dexterity_up.IsEnabled = Intelligence_down.IsEnabled = Intelligence_up.IsEnabled = ExpButton.IsEnabled = false;
            
            Experience_TB.Text = "0";
            //LevelBlock.Text = "1";
        }

        private void ExpButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(Experience_TB.Text) >= 45000)
                MessageBox.Show("You got highest level");
            else
                Experience_TB.Text = ((Convert.ToInt32(Experience_TB.Text)) + 1000).ToString();    
        }

        private void Experience_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            int exp = Convert.ToInt32(Experience_TB.Text);
            int level = Convert.ToInt32(LevelBlock.Text);

            level = Mechanics.LevelUpLogic(exp, level);

            LevelBlock.Text = level.ToString();
        }

        private void LevelBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ChooseWarriorRB.IsChecked == true || ChooseRogueRB.IsChecked == true || ChooseSorcererRB.IsChecked == true)
                Extra_TB.Text = (Convert.ToInt32(Extra_TB.Text) + 5).ToString();
            
            Strenght_down.Visibility = Constitution_down.Visibility = Dexterity_down.Visibility = Intelligence_down.Visibility = Visibility.Collapsed;
        }

        private void StatsChanger()
        {
            PA_TB.Text = (Convert.ToInt32(Strenght_TB.Text) * 5).ToString();
            MA_TB.Text = (Convert.ToInt32(Intelligence_TB.Text) * 5).ToString();
            PR_TB.Text = Math.Round(Convert.ToDouble(Constitution_TB.Text) * 0.8, 3).ToString();
            MR_TB.Text = Math.Round(Convert.ToDouble(Intelligence_TB.Text) * 0.5, 3).ToString();
            HP_TB.Text = (Convert.ToInt32(Constitution_TB.Text) * 10).ToString();
            MP_TB.Text = (Convert.ToInt32(Intelligence_TB.Text) * 8).ToString();
            AS_TB.Text = (Convert.ToInt32(Dexterity_TB.Text) * 5).ToString();
            MS_TB.Text = (Convert.ToInt32(Dexterity_TB.Text) * 2 + 50).ToString();
        }
    }
}
