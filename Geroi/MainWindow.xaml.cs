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

namespace Geroi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void perehod_mag(object sender, MouseButtonEventArgs e)
        {
            Window1 wd = new Window1();
            wd.Show();
            this.Close();
        }

        private void perehod_mechnik(object sender, MouseButtonEventArgs e)
        {
            Window1 wd = new Window1();
            wd.Show();
            this.Close();
        }
    }
}
