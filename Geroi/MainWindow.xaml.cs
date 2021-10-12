﻿using System;
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
            Class_Mag wd = new Class_Mag();
            wd.Show();
            this.Close();
        }

        private void perehod_mechnik(object sender, MouseButtonEventArgs e)
        {
            Class_Mechnik wd = new Class_Mechnik();
            wd.Show();
            this.Close();
        }

        private void Perehod_Luchnik(object sender, MouseButtonEventArgs e)
        {
            Class_Luchnik wd = new Class_Luchnik();
            wd.Show();
            this.Close();
        }

        private void Perehod_Razboinik(object sender, MouseButtonEventArgs e)
        {
            Class_Razboinik wd = new Class_Razboinik();
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
