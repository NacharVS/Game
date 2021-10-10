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
            }
        }
    }
}
