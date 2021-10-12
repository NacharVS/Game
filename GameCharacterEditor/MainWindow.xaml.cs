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
        int a;
        public MainWindow()
        {
            InitializeComponent();
            a = Convert.ToInt32(TbExtraPoints.Text);
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TbPhAttack.Text = Convert.ToString(Convert.ToInt32(TbPhAttack.Text) - 1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
