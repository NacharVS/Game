using MongoDB.Bson.Serialization.Attributes;
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

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Mage_hero(object sender, MouseButtonEventArgs e)
        {
            Window1 wd = new Window1();
            wd.Show();
            this.Close();
        }

        private void Range_hero(object sender, MouseButtonEventArgs e)
        {
            Window2 wd = new Window2();
            wd.Show();
            this.Close();
        }

        private void Mill_hero(object sender, MouseButtonEventArgs e)
        {
            Window3 wd = new Window3();
            wd.Show();
            this.Close();
        }

        private void Hunter_hero(object sender, MouseButtonEventArgs e)
        {
            Window4 wd = new Window4();
            wd.Show();
            this.Close();
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
