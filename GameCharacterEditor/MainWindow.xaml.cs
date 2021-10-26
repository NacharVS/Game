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
using MongoDB.Driver;

namespace GameCharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoModel> _todoData;
        private List<Helmet> _helmets;

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
                LevelBlock.Text = warrior.Level.ToString() + " Level";
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
                LevelBlock.Text = rogue.Level.ToString() + " Level";
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
                LevelBlock.Text = sorcerer.Level.ToString() + " Level";
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
                MessageBox.Show("Its not enough extra points!");
                return;
            }

            string bttn = (string)((Button)sender).Name;

            switch(bttn)
            {
                case "Strenght_up":
                    Strenght_TB.Text = ((Convert.ToInt32(Strenght_TB.Text)) + 1).ToString();
                    break;
                case "Constitution_up":
                    Constitution_TB.Text = ((Convert.ToInt32(Constitution_TB.Text)) + 1).ToString();
                    break;
                case "Dexterity_up":
                    Dexterity_TB.Text = ((Convert.ToInt32(Dexterity_TB.Text)) + 1).ToString();
                    break;
                case "Intelligence_up":
                    Intelligence_TB.Text = ((Convert.ToInt32(Intelligence_TB.Text)) + 1).ToString();
                    break;
            }
            
        }

        ////private void ExtraDebuff_Click(object sender, RoutedEventArgs e)
        ////{
        ////    int ex = int.Parse(Extra_TB.Text);

        ////    string bttn = (string)((Button)sender).Name;

        ////    switch (bttn)
        ////    {
        ////        case "PA_down":
        ////            int pa = int.Parse(PA_TB.Text);
        ////            if(pa > 20)
        ////            {
        ////                --pa;
        ////                ++ex;
        ////                Extra_TB.Text = ex.ToString();
        ////                PA_TB.Text = pa.ToString();
        ////            }
        ////            else
        ////            {
        ////                ReduceException(ex);
        ////                Extra_TB.Text = ex.ToString();
        ////            }
        ////            break;
        ////        case "MA_down":
        ////            int ma = int.Parse(MA_TB.Text);
        ////            if(ma > 20)
        ////            {
        ////                --ma;
        ////                ++ex;
        ////                Extra_TB.Text = ex.ToString();
        ////                MA_TB.Text = ma.ToString();
        ////            }
        ////            else 
        ////            {
        ////                ReduceException(ex);
        ////                Extra_TB.Text = ex.ToString();
        ////            }
        ////            break;
        ////        case "PR_down":
        ////            int pr = int.Parse(PR_TB.Text);
        ////            if (pr > 20)
        ////            {
        ////                --pr;
        ////                ++ex;
        ////                Extra_TB.Text = ex.ToString();
        ////                PR_TB.Text = pr.ToString();
        ////            }
        ////            else
        ////            {
        ////                ReduceException(ex);
        ////                Extra_TB.Text = ex.ToString();
        ////            }
        ////            break;
        ////        case "MR_down":
        ////            int mr = int.Parse(MR_TB.Text);
        ////            if (mr > 20)
        ////            {
        ////                --mr;
        ////                ++ex;
        ////                Extra_TB.Text = ex.ToString();
        ////                MR_TB.Text = mr.ToString();
        ////            }
        ////            else
        ////            {
        ////                ReduceException(ex);
        ////                Extra_TB.Text = ex.ToString();
        ////            }
        ////            break;
        ////    }    

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
                name = "Warrior";
                AddToDataBase(war);

                //else if(ChooseRogueRB.IsChecked == true)
                //{
                //    Rogue rogue = new Rogue();
                //    name = "Rogue";
                //    AddToDataBase(rogue);
                //}
                //else
                //{
                //    Sorcerer sorc = new Sorcerer();
                //    name = "Sorcerer";
                //    AddToDataBase(sorc);
                //}

                _todoData = new BindingList<TodoModel>()
                {
                    new TodoModel()
                    {
                        Character = name, HP = int.Parse(HP_TB.Text), MP = int.Parse(MP_TB.Text),
                        Strenght = int.Parse(Strenght_TB.Text), Dexterity = int.Parse(Dexterity_TB.Text), Intelligence = int.Parse(Intelligence_TB.Text),
                        Constitution = int.Parse(Constitution_TB.Text), PAttack = int.Parse(PA_TB.Text), MAttack = int.Parse(MA_TB.Text),
                        PResist = int.Parse(PR_TB.Text), MResist = int.Parse(MR_TB.Text), ASpeed = int.Parse(AS_TB.Text), MSpeed = int.Parse(MS_TB.Text)
                    }
                };

                CharacterList.Items.Add(_todoData);
            }
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

        private void HelnetComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
