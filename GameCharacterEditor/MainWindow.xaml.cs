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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rogue rog = new Rogue();
            TbArmor.Text = rog.armor.ToString();
            TbAttackSpeed.Text = rog.attackSpeed.ToString();
            TbDexterity.Text = rog.dexterity.ToString();
            TbHP.Text = rog.healthPoint.ToString();
            TbIntellect.Text = rog.intellect.ToString();
            TbMana.Text = rog.manaPoint.ToString();
            TbMgAttack.Text = rog.mAttack.ToString();
            TbMoveSpeed.Text = rog.moveSpeed.ToString();
            TbPhAttack.Text = rog.pAttack.ToString();
            TbPhysique.Text = rog.physique.ToString();
            TbStrength.Text = rog.strength.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Warrior war = new Warrior();
            TbArmor.Text = war.armor.ToString();
            TbAttackSpeed.Text = war.attackSpeed.ToString();
            TbDexterity.Text = war.dexterity.ToString();
            TbHP.Text = war.healthPoint.ToString();
            TbIntellect.Text = war.intellect.ToString();
            TbMana.Text = war.manaPoint.ToString();
            TbMgAttack.Text = war.mAttack.ToString();
            TbMoveSpeed.Text = war.moveSpeed.ToString();
            TbPhAttack.Text = war.pAttack.ToString();
            TbPhysique.Text = war.physique.ToString();
            TbStrength.Text = war.strength.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sorcecer sorc = new Sorcecer();
            TbArmor.Text = sorc.armor.ToString();
            TbAttackSpeed.Text = sorc.attackSpeed.ToString();
            TbDexterity.Text = sorc.dexterity.ToString();
            TbHP.Text = sorc.healthPoint.ToString();
            TbIntellect.Text = sorc.intellect.ToString();
            TbMana.Text = sorc.manaPoint.ToString();
            TbMgAttack.Text = sorc.mAttack.ToString();
            TbMoveSpeed.Text = sorc.moveSpeed.ToString();
            TbPhAttack.Text = sorc.pAttack.ToString();
            TbPhysique.Text = sorc.physique.ToString();
            TbStrength.Text = sorc.strength.ToString();
        }

        private void AbilityDown_Click(object sender, RoutedEventArgs e)
        {
            int ex = int.Parse(TbExtraPoints.Text);
            string button = (string)((Button)sender).Name;

            switch (button)
            {
                case "PhysA_Down":
                    int Pa = int.Parse(TbPhAttack.Text);
                    if(Pa > 20)
                    {
                        --Pa;
                        ++ex;
                        TbExtraPoints.Text = ex.ToString();
                        TbPhAttack.Text = Pa.ToString();
                    }
                    else
                    {
                        Exception(ex);
                        TbExtraPoints.Text = ex.ToString();
                    }
                    break;
                case "MagA_Down":
                    int ma = int.Parse(TbMgAttack.Text);
                    if(ma > 20)
                    {
                        --ma;
                        ++ex;
                        TbExtraPoints.Text = ex.ToString();
                        TbMgAttack.Text = ma.ToString();
                    }
                    else
                    {
                        Exception(ex);
                        TbExtraPoints.Text = ex.ToString();
                    }
                    break;
            }
        }

        private void AbilityUp_Click(object sender, RoutedEventArgs e)
        {
            int ex = int.Parse(TbExtraPoints.Text);
            string button = (string)((Button)sender).Name;

            switch(button)
            {
                case "PhysA_Up":
                    int pa = int.Parse(TbPhAttack.Text);
                    if(pa < 30)
                    {
                        ++pa;
                        --ex;
                        TbExtraPoints.Text = ex.ToString();
                        TbPhAttack.Text = pa.ToString();
                    }
                    else
                    {
                        Exception(ex);
                        TbExtraPoints.Text = ex.ToString();
                    }
                    break;
                case "MagA_Up":
                    int ma = int.Parse(TbMgAttack.Text);
                    if(ma < 30)
                    {
                        ++ma;
                        --ex;
                        TbExtraPoints.Text = ex.ToString();
                        TbMgAttack.Text = ma.ToString();
                    }
                    else
                    {
                        Exception(ex);
                        TbExtraPoints.Text = ex.ToString();
                    }
                    break;
            }
        }

        private void Exception(int ability)
        {
            --ability;
        }
    }
}
