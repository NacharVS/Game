﻿using System;
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
using GameCharacterEditor.Models;
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
            Dexterity_down.IsEnabled = Dexterity_up.IsEnabled = Intelligence_down.IsEnabled = Intelligence_up.IsEnabled = true;

            if (ChooseWarriorRB.IsChecked == true)
            {
                var warrior = new Warrior();

                LevelText.Text = warrior.Level.ToString();
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
            }

            else if (ChooseRogueRB.IsChecked == true)
            {
                var rogue = new Rogue();

                LevelText.Text = rogue.Level.ToString();
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
            }
            else
            { 
                var sorcerer = new Sorcerer();

                LevelText.Text = sorcerer.Level.ToString();
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
                MessageBox.Show("Its not enough extra points!");
                return;
            }

            string bttn = (string)((Button)sender).Name;

            switch (bttn)
            {
                case "Strenght_up":
                    int str = Convert.ToInt32(Strenght_TB.Text);
                    str++;
                    Strenght_TB.Text = str.ToString();
                    break;
                case "Constitution_up":
                    int constit = Convert.ToInt32(Constitution_TB.Text);
                    constit++;
                    Constitution_TB.Text = constit.ToString();
                    break;
                case "Dexterity_up":
                    int dex = Convert.ToInt32(Dexterity_TB.Text);
                    dex++;
                    Dexterity_TB.Text = dex.ToString();
                    break;
                case "Intelligence_up":
                    int intel = Convert.ToInt32(Intelligence_TB.Text);
                    intel++;
                    Intelligence_TB.Text = intel.ToString();
                    break;
            }           
        }

        //private void ExtraDebuff_Click(object sender, RoutedEventArgs e)
        //{
        //    int ex = int.Parse(Extra_TB.Text);

        //    string bttn = (string)((Button)sender).Name;

        //    switch (bttn)
        //    {
        //        case "Strenght_down":
        //            int pa = int.Parse(PA_TB.Text);
        //            if(pa > 20)
        //            {
        //                --pa;
        //                ++ex;
        //                Extra_TB.Text = ex.ToString();
        //                Strenght_TB.Text = pa.ToString();
        //            }
        //            else
        //            {
        //                ReduceException(ex);
        //                Extra_TB.Text = ex.ToString();
        //            }
        //            break;
        //        case "Constitution_down":
        //            int ma = int.Parse(MA_TB.Text);
        //            if(ma > 20)
        //            {
        //                --ma;
        //                ++ex;
        //                Extra_TB.Text = ex.ToString();
        //                Constitution_TB.Text = ma.ToString();
        //            }
        //            else 
        //            {
        //                ReduceException(ex);
        //                Extra_TB.Text = ex.ToString();
        //            }
        //            break;
        //        case "Dexterity_down":
        //            int pr = int.Parse(PR_TB.Text);
        //            if (pr > 20)
        //            {
        //                --pr;
        //                ++ex;
        //                Extra_TB.Text = ex.ToString();
        //                Dexterity_TB.Text = pr.ToString();
        //            }
        //            else
        //            {
        //                ReduceException(ex);
        //                Extra_TB.Text = ex.ToString();
        //            }
        //            break;
        //        case "Intelligence_down":
        //            int mr = int.Parse(MR_TB.Text);
        //            if (mr > 20)
        //            {
        //                --mr;
        //                ++ex;
        //                Extra_TB.Text = ex.ToString();
        //                Intelligence_TB.Text = mr.ToString();
        //            }
        //            else
        //            {
        //                ReduceException(ex);
        //                Extra_TB.Text = ex.ToString();
        //            }
        //            break;
        //    }    

        //    int ReduceException(int ability)
        //    {
        //        return --ability;
        //    }
        //}

        private void PickButton_Click(object sender, RoutedEventArgs e)
        {
            string name;
    


            if (ChooseWarriorRB.IsChecked == true)
            {
                Warrior war = new Warrior();
                war.PAttack = Convert.ToInt32(PA_TB.Text);
                name = "Warrior";
                AddToDataBase(war);
            }
            else if (ChooseRogueRB.IsChecked == true)
            {
                Rogue rogue = new Rogue();
                name = "Rogue";
                AddToDataBase(rogue);
            }
            else
            {
                Sorcerer sorc = new Sorcerer();
                name = "Sorcerer";
                AddToDataBase(sorc);
            }

            _todoData = new BindingList<TodoModel>()
            {
                new TodoModel()
                {
                    Character = name, Level = Convert.ToInt32(LevelText.Text), HP = int.Parse(HP_TB.Text), MP = int.Parse(MP_TB.Text),
                    Strenght = int.Parse(Strenght_TB.Text), Dexterity = int.Parse(Dexterity_TB.Text), Intelligence = int.Parse(Intelligence_TB.Text),
                    Constitution = int.Parse(Constitution_TB.Text), PAttack = int.Parse(PA_TB.Text), MAttack = int.Parse(MA_TB.Text),
                    PResist = int.Parse(PR_TB.Text), MResist = int.Parse(MR_TB.Text), ASpeed = int.Parse(AS_TB.Text), MSpeed = int.Parse(MS_TB.Text)
                }
            };

            CharacterList.Items.Add(_todoData);
        }

        private static void AddToDataBase(Hero hero)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Diyar");
            var collection = database.GetCollection<Hero>("Hero!");
            collection.InsertOne(hero);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             PickButton.IsEnabled = Strenght_down.IsEnabled = Strenght_up.IsEnabled = Constitution_down.IsEnabled = Constitution_up.IsEnabled =
             Dexterity_down.IsEnabled = Dexterity_up.IsEnabled = Intelligence_down.IsEnabled = Intelligence_up.IsEnabled = false;
        }

        private void ExperienceButton_Click(object sender, RoutedEventArgs e)
        {
            int exp = Convert.ToInt32(ExperienceText.Text);
            exp += 1000;
            ExperienceText.Text = exp.ToString();
            if(exp >= 45000)
            {
                ExperienceButton.IsEnabled = false;
            }
        }

        private void ExperienceText_TextChanged(object sender, TextChangedEventArgs e)
        {
            int expir = Convert.ToInt32(ExperienceText.Text);

            if ( expir < 1000)
            {
                LevelText.Text = "1";
            }
            else if (expir >= 1000 && expir < 3000)
            {
                LevelText.Text = "2";
            }
            else if (expir >= 3000 && expir < 6000)
            {
                LevelText.Text = "3";
            }
            else if (expir >= 6000 && expir < 10000)
            {
                LevelText.Text = "4";
            }
            else if (expir >= 10000 && expir < 15000)
            {
                LevelText.Text = "5";
            }
            else if (expir >= 15000 && expir < 21000)
            {
                LevelText.Text = "6";
            }
            else if (expir >= 21000 && expir < 28000)
            {
                LevelText.Text = "7";
            }
            else if (expir >= 28000 && expir < 36000)
            {
                LevelText.Text = "8";
            }
            else if (expir >= 36000 && expir < 45000)
            {
                LevelText.Text = "9";
            }
            else
            {
                LevelText.Text = "10";
            }
        }
    }
}
