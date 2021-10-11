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
using HeroClass;

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
                        PA_down.IsEnabled = true;
                        ++pa;
                        PA_TB.Text = pa.ToString();
                    }
                    else
                    {
                        PA_up.IsEnabled = false;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MA_up":
                    int ma = int.Parse(MA_TB.Text);
                    if (ma < 30)
                    {
                        MA_down.IsEnabled = true;
                        ++ma;
                        MA_TB.Text = ma.ToString();
                    }
                    else
                    {
                        MA_up.IsEnabled = false;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "PR_up":
                    int pr = int.Parse(PR_TB.Text);
                    if (pr < 30)
                    {
                        PR_down.IsEnabled = true;
                        ++pr;
                        PR_TB.Text = pr.ToString();
                    }
                    else 
                    {
                        PR_up.IsEnabled = false;
                        ++ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MR_up":
                    int mr = int.Parse(MR_TB.Text);
                    if(mr < 30)
                    {
                        MR_down.IsEnabled = true;
                        ++mr;
                        MR_TB.Text = mr.ToString();
                    }
                    else
                    {
                        MR_up.IsEnabled = false;
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

            if (ex < 20)
            {
                ++ex;
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
                case "PA_down":
                    int pa = int.Parse(PA_TB.Text);
                    if(pa > 20)
                    {
                        PA_up.IsEnabled = true;
                        --pa;
                        PA_TB.Text = pa.ToString();
                    }
                    else
                    {
                        PA_down.IsEnabled = false;
                        --ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MA_down":
                    int ma = int.Parse(MA_TB.Text);
                    if(ma > 20)
                    {
                        MA_up.IsEnabled = true;
                        --ma;
                        MA_TB.Text = ma.ToString();
                    }
                    else 
                    {
                        MA_down.IsEnabled = false;
                        --ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "PR_down":
                    int pr = int.Parse(PR_TB.Text);
                    if (pr > 20)
                    {
                        PR_up.IsEnabled = true;
                        --pr;
                        PR_TB.Text = pr.ToString();
                    }
                    else
                    {
                        PR_down.IsEnabled = false;
                        --ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
                case "MR_down":
                    int mr = int.Parse(MR_TB.Text);
                    if (mr > 20)
                    {
                        MR_up.IsEnabled = true;
                        --mr;
                        MR_TB.Text = mr.ToString();
                    }
                    else
                    {
                        MR_down.IsEnabled = false;
                        --ex;
                        Extra_TB.Text = ex.ToString();
                    }
                    break;
            }    
        }

        private void ExtraDebuff(object sender, ContextMenuEventArgs e)
        {

        }

        private void ExtraDebuff(object sender, RoutedEventArgs e)
        {

        }
    }
}
