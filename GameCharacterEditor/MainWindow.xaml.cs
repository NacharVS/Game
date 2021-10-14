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
using GameCharacterEditor.Models;
using HeroClass;

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
            string bttn = (string)((Button)sender).Content;

            switch (bttn)
            {
                case "Warrior":
                    var warrior = new Warrior();

                    HP_TB.Text = warrior.healthPoint.ToString();
                    MP_TB.Text = warrior.manaPoint.ToString();
                    Strenght_TB.Text = warrior.strenght.ToString();
                    Dexterity_TB.Text = warrior.dexterity.ToString();
                    Intelligenct_TB.Text = warrior.intelligence.ToString();
                    Constitution_TB.Text = warrior.constitution.ToString();
                    Extra_TB.Text = warrior.extra.ToString();
                    PA_TB.Text = warrior.pAttack.ToString();
                    MA_TB.Text = warrior.mAttack.ToString();
                    PR_TB.Text = warrior.pResist.ToString();
                    MR_TB.Text = warrior.mResist.ToString();
                    AS_TB.Text = warrior.attackSpeed.ToString();
                    MS_TB.Text = warrior.walkSpeed.ToString();
                    break;

                case "Rogue":
                    var rogue = new Rogue();

                    HP_TB.Text = rogue.healthPoint.ToString();
                    MP_TB.Text = rogue.manaPoint.ToString();
                    Strenght_TB.Text = rogue.strenght.ToString();
                    Dexterity_TB.Text = rogue.dexterity.ToString();
                    Intelligenct_TB.Text = rogue.intelligence.ToString();
                    Constitution_TB.Text = rogue.constitution.ToString();
                    Extra_TB.Text = rogue.extra.ToString();
                    PA_TB.Text = rogue.pAttack.ToString();
                    MA_TB.Text = rogue.mAttack.ToString();
                    PR_TB.Text = rogue.pResist.ToString();
                    MR_TB.Text = rogue.mResist.ToString();
                    AS_TB.Text = rogue.attackSpeed.ToString();
                    MS_TB.Text = rogue.walkSpeed.ToString();
                    break;

                case "Sorcerer":
                    var sorcerer = new Sorcerer();

                    HP_TB.Text = sorcerer.healthPoint.ToString();
                    MP_TB.Text = sorcerer.manaPoint.ToString();
                    Strenght_TB.Text = sorcerer.strenght.ToString();
                    Dexterity_TB.Text = sorcerer.dexterity.ToString();
                    Intelligenct_TB.Text = sorcerer.intelligence.ToString();
                    Constitution_TB.Text = sorcerer.constitution.ToString();
                    Extra_TB.Text = sorcerer.extra.ToString();
                    PA_TB.Text = sorcerer.pAttack.ToString();
                    MA_TB.Text = sorcerer.mAttack.ToString();
                    PR_TB.Text = sorcerer.pResist.ToString();
                    MR_TB.Text = sorcerer.mResist.ToString();
                    AS_TB.Text = sorcerer.attackSpeed.ToString();
                    MS_TB.Text = sorcerer.walkSpeed.ToString();
                    break;
                default:
                    MessageBox.Show("error");
                    break;
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
                case "PA_up":
                    int pa = int.Parse(PA_TB.Text);
                    if(pa < 30)
                    {
                        ++pa;
                        PA_TB.Text = pa.ToString();
                    }
                    else
                    {
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MA_up":
                    int ma = int.Parse(MA_TB.Text);
                    if (ma < 30)
                    {
                        ++ma;
                        MA_TB.Text = ma.ToString();
                    }
                    else
                    {
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "PR_up":
                    int pr = int.Parse(PR_TB.Text);
                    if (pr < 30)
                    {
                        ++pr;
                        PR_TB.Text = pr.ToString();
                    }
                    else 
                    {
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MR_up":
                    int mr = int.Parse(MR_TB.Text);
                    if(mr < 30)
                    {
                        ++mr;
                        MR_TB.Text = mr.ToString();
                    }
                    else
                    {
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }           
        }

        private void ExtraDebuff_Click(object sender, RoutedEventArgs e)
        {
            int ex = int.Parse(Extra_TB.Text);

            string bttn = (string)((Button)sender).Name;

            switch (bttn)
            {
                case "PA_down":
                    int pa = int.Parse(PA_TB.Text);
                    if(pa > 20)
                    {
                        --pa;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                        PA_TB.Text = pa.ToString();
                    }
                    else
                    {
                        ReduceException(ex);
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MA_down":
                    int ma = int.Parse(MA_TB.Text);
                    if(ma > 20)
                    {
                        --ma;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                        MA_TB.Text = ma.ToString();
                    }
                    else 
                    {
                        ReduceException(ex);
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "PR_down":
                    int pr = int.Parse(PR_TB.Text);
                    if (pr > 20)
                    {
                        --pr;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                        PR_TB.Text = pr.ToString();
                    }
                    else
                    {
                        ReduceException(ex);
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MR_down":
                    int mr = int.Parse(MR_TB.Text);
                    if (mr > 20)
                    {
                        --mr;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                        MR_TB.Text = mr.ToString();
                    }
                    else
                    {
                        ReduceException(ex);
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
            }    

            int ReduceException(int ability)
            {
                return --ability;
            }
        }

        private void PickButton_Click(object sender, RoutedEventArgs e)
        {
            _todoData = new BindingList<TodoModel>()
            {
                new TodoModel(){Character = (string)((Button) sender).Name, HP = int.Parse(HP_TB.Text), MP = int.Parse(MP_TB.Text), Strenght = int.Parse(Strenght_TB.Text) }
            };

        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            InventoryWindow inv = new InventoryWindow();
            inv.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoData = new BindingList<TodoModel>()
            {
                new TodoModel(){ID = 1, Character = "Rogue", Strenght = 20, Dexterity = 30, Intelligence = 15, Constitution = 20, PAttack = 30, MAttack = 20, PResist = 30, MResist = 20, ASpeed = 20, MSpeed = 20}
            };

            CharacterList.ItemsSource = _todoData;

        }
    }
}
