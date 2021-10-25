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
using HeroFabric;
using GameCore.Class;

namespace DiabloByKarpov.View
{
    /// <summary>
    /// Логика взаимодействия для WarriorPage.xaml
    /// </summary>
    public partial class WarriorPage : Page
    {
        public int test1;

        HeroMakerDefult hmd;
        //List<HeroClass> heroList;

        public WarriorPage()
        {
            InitializeComponent();

            hmd = new HeroMakerDefult();
            test1 = 100;

            //heroList = hmd.GetListHero();

            gridHero.ItemsSource = hmd.GetWarriorLst();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Visibility = Visibility.Hidden;
        }

        public int Test1
        {
            get => test1;
            set
            {
                test1 = value;
            }
        }
    }
}
