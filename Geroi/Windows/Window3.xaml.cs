﻿using System;
using System.Collections.Generic;
using System.DrawingCore;
using System.IO;
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

namespace Geroi
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
        private static BitmapImage Bmp2BmpImg(Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, System.DrawingCore.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitImg = new BitmapImage();
                bitImg.BeginInit();
                bitImg.StreamSource = memory;
                bitImg.CacheOption = BitmapCacheOption.OnLoad;
                bitImg.EndInit();
                return bitImg;
            }
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
            if (kl == 0)
            {
                Kol.Text = kl.ToString();
                Plus1.Visibility = Visibility.Hidden;
                Plus3.Visibility = Visibility.Hidden;
                Plus2.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                Minus1.Visibility = Visibility.Visible;
                Kol.Text = kl.ToString();
            }
        }

        private void Minus1_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Strenght.Text);
            st -= 1;
            if (st == 1)
            {
                Strenght.Text = st.ToString();
                Minus1.Visibility = Visibility.Hidden;
            }
            else if (st > 1)
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
                Kol.Text = kl.ToString();
            }
        }

        private void Minus2_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Agility.Text);
            st -= 1;
            if (st == 1)
            {
                Agility.Text = st.ToString();
                Minus2.Visibility = Visibility.Hidden;
            }
            else if (st > 1)
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
                Kol.Text = kl.ToString();
            }
        }

        private void Minus3_Click(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Intelligence.Text);
            st -= 1;
            if (st == 1)
            {
                Intelligence.Text = st.ToString();
                Minus3.Visibility = Visibility.Hidden;
            }
            else if (st > 1)
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
        private void level1_Click(object sender, RoutedEventArgs e)
        {
            int L1000 = Convert.ToInt32(LL.Text);
            int LLL = Convert.ToInt32(Опыт.Text);
            L1000 += 1000;
            LL.Text = L1000.ToString();
            if (L1000 >= LLL)
            {
                LLL += 6000;
                Опыт.Text = LLL.ToString();
                MessageBox.Show("Переход на следующий уровень");
                int kl = Convert.ToInt32(Kol.Text);
                kl += 5;
                Kol.Text = kl.ToString();
            }
        }
        private void level2_Click(object sender, RoutedEventArgs e)
        {
            int L1000 = Convert.ToInt32(LL.Text);
            int LLL = Convert.ToInt32(Опыт.Text);
            L1000 += 2000;
            LL.Text = L1000.ToString();
            if (L1000 > LLL || L1000 == LLL)
            {
                LLL += 6000;
                Опыт.Text = LLL.ToString();
                MessageBox.Show("Переход на следующий уровень");
                int kl = Convert.ToInt32(Kol.Text);
                kl += 5;
                Kol.Text = kl.ToString();
            }
        }
        private void pol_Click(object sender, RoutedEventArgs e)
        {
            Unit unit = new Unit(int.Parse(Strenght.Text), int.Parse(Agility.Text), int.Parse(Intelligence.Text),Convert.ToString(OMA.Text), Convert.ToString(OM.Text));
            byte[] imagebytes = File.ReadAllBytes(unit.Path1);
            unit.Add(unit);
            MessageBox.Show("Занесено в базу!");
        }
    }
}
