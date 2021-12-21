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

        private void Per_w(object sender, MouseButtonEventArgs e)
        {
            Pages.WindowWarrior CW = new Pages.WindowWarrior();
            CW.Show();
            this.Close();
        }

        private void Per_m(object sender, MouseButtonEventArgs e)
        {
            Pages.WindowMage CW = new Pages.WindowMage();
            CW.Show();
            this.Close();
        }

        private void Per_h(object sender, MouseButtonEventArgs e)
        {
            Pages.WindowHealer CW = new Pages.WindowHealer();
            CW.Show();
            this.Close();
        }

        private void Per_r(object sender, MouseButtonEventArgs e)
        {
            Pages.WindowRobber CW = new Pages.WindowRobber();
            CW.Show();
            this.Close();
        }

        private void Per_b(object sender, MouseButtonEventArgs e)
        {
            Pages.WindowBandit CW = new Pages.WindowBandit();
            CW.Show();
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
