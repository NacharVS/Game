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
using System.Windows.Shapes;

namespace GameCharacterEditor
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Image_MouseLeave1(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void Image_MouseEnter1(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void Plus1_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Strenght.Text);
            st += 1;
            Strenght.Text = st.ToString();
            int kl = Convert.ToInt32(Kol.Text);
            kl -= 1;
            if (kl < 0)
            {
                Kol.Text = kl.ToString();
                Plus1.Visibility = Visibility.Hidden;
                Plus3.Visibility = Visibility.Hidden;
                Plus2.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus1.Visibility = Visibility.Visible;
                Minus2.Visibility = Visibility.Visible;
                Minus3.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus1_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Strenght.Text);
            st -= 1;
            if (st == 0)
            {
                Strenght.Text = st.ToString();
                Minus1.Visibility = Visibility.Hidden;
                Minus3.Visibility = Visibility.Hidden;
                Minus2.Visibility = Visibility.Hidden;
            }
            else if (st > 0)
            {
                Plus3.Visibility = Visibility.Visible;
                Plus2.Visibility = Visibility.Visible;
                Plus1.Visibility = Visibility.Visible;
                Strenght.Text = st.ToString();
            }
            int kl = Convert.ToInt32(Kol.Text);
            kl += 1;
            Kol.Text = kl.ToString();
        }
        private void Plus2_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Agility.Text);
            st += 1;
            Agility.Text = st.ToString();
            int kl = Convert.ToInt32(Kol.Text);
            kl -= 1;
            if (kl == 0)
            {
                Kol.Text = kl.ToString();
                Plus3.Visibility = Visibility.Hidden;
                Plus1.Visibility = Visibility.Hidden;
                Plus2.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus2.Visibility = Visibility.Visible;
                Minus1.Visibility = Visibility.Visible;
                Minus3.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus2_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Agility.Text);
            st -= 1;
            if (st == 0)
            {
                Agility.Text = st.ToString();
                Minus2.Visibility = Visibility.Hidden;
                Minus1.Visibility = Visibility.Hidden;
                Minus3.Visibility = Visibility.Hidden;
            }
            else if (st > 0)
            {
                Plus2.Visibility = Visibility.Visible;
                Plus3.Visibility = Visibility.Visible;
                Plus1.Visibility = Visibility.Visible;
                Agility.Text = st.ToString();
            }
            int kl = Convert.ToInt32(Kol.Text);
            kl += 1;
            Kol.Text = kl.ToString();
        }
        private void Plus3_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Intelligence.Text);
            st += 1;
            Intelligence.Text = st.ToString();
            int kl = Convert.ToInt32(Kol.Text);
            kl -= 1;
            if (kl == 0)
            {
                Kol.Text = kl.ToString();
                Plus3.Visibility = Visibility.Hidden;
                Plus1.Visibility = Visibility.Hidden;
                Plus2.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus3.Visibility = Visibility.Visible;
                Minus1.Visibility = Visibility.Visible;
                Minus2.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus3_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Intelligence.Text);
            st -= 1;
            if (st == 0)
            {
                Intelligence.Text = st.ToString();
                Minus3.Visibility = Visibility.Hidden;
                Minus1.Visibility = Visibility.Hidden;
                Minus2.Visibility = Visibility.Hidden;
            }
            else if (st > 0)
            {
                Plus3.Visibility = Visibility.Visible;
                Plus1.Visibility = Visibility.Visible;
                Plus2.Visibility = Visibility.Visible;
                Intelligence.Text = st.ToString();
            }
            int kl = Convert.ToInt32(Kol.Text);
            kl += 1;
            Kol.Text = kl.ToString();
        }
        private void Plus4_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Attack_speed.Text);
            st += 1;
            Attack_speed.Text = st.ToString();
            int kl = Convert.ToInt32(Kol.Text);
            kl -= 1;
            if (kl == 0)
            {
                Kol.Text = kl.ToString();
                Plus4.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus4.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus4_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Attack_speed.Text);
            st -= 1;
            if (st == 0)
            {
                Attack_speed.Text = st.ToString();
                Minus4.Visibility = Visibility.Hidden;
            }
            else if (st > 0)
            {
                Plus4.Visibility = Visibility.Visible;
                Attack_speed.Text = st.ToString();
            }
            int kl = Convert.ToInt32(Kol.Text);
            kl += 1;
            Kol.Text = kl.ToString();
        }
        private void Plus5_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Armor.Text);
            st += 1;
            Armor.Text = st.ToString();
            int kl = Convert.ToInt32(Kol.Text);
            kl -= 1;
            if (kl == 0)
            {
                Kol.Text = kl.ToString();
                Plus4.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus4.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus5_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Armor.Text);
            st -= 1;
            if (st == 0)
            {
                Armor.Text = st.ToString();
                Minus4.Visibility = Visibility.Hidden;
            }
            else if (st > 0)
            {
                Plus4.Visibility = Visibility.Visible;
                Armor.Text = st.ToString();
            }
            int kl = Convert.ToInt32(Kol.Text);
            kl += 1;
            Kol.Text = kl.ToString();
        }
    }
}
