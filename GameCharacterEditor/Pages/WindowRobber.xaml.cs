using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameCharacterEditor.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowRobber.xaml
    /// </summary>
    public partial class WindowRobber : Window
    {
        public WindowRobber()
        {
            InitializeComponent();
        }

        private void Plus_Click_Str(object sender, RoutedEventArgs e)
        {
            int str = Convert.ToInt32(Strenght.Text);
            int p = Convert.ToInt32(Point.Text);

            str += 1;
            Strenght.Text = str.ToString();
            p -= 1;

            if (p == 0)
            {
                Point.Text = p.ToString();
                PlusStr.Visibility = Visibility.Hidden;
                PlusInt.Visibility = Visibility.Hidden;
                PlusAgl.Visibility = Visibility.Hidden;
            }
            else if (p > 0)
            {
                MinStr.Visibility = Visibility.Visible;
                Point.Text = p.ToString();
            }
        }

        private void Plus_Click_Agl(object sender, RoutedEventArgs e)
        {
            int agl = Convert.ToInt32(Agility.Text);
            int kl = Convert.ToInt32(Point.Text);

            agl += 1;
            Agility.Text = agl.ToString();
            kl -= 1;

            if (kl == 0)
            {
                Point.Text = kl.ToString();
                PlusInt.Visibility = Visibility.Hidden;
                PlusStr.Visibility = Visibility.Hidden;
                PlusAgl.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                MinAgl.Visibility = Visibility.Visible;
                Point.Text = kl.ToString();
            }
        }

        private void Plus_Click_Int(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Intelligence.Text);
            st += 1;
            Intelligence.Text = st.ToString();
            int kl = Convert.ToInt32(Point.Text);
            kl -= 1;
            if (kl == 0)
            {
                Point.Text = kl.ToString();
                PlusInt.Visibility = Visibility.Hidden;
                PlusStr.Visibility = Visibility.Hidden;
                PlusAgl.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                MinInt.Visibility = Visibility.Visible;
                Point.Text = kl.ToString();
            }
        }

        private void Minus_Click_Str(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Strenght.Text);
            st -= 1;

            if (st == 0)
            {
                Strenght.Text = st.ToString();
                MinStr.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PlusInt.Visibility = Visibility.Visible;
                PlusAgl.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                Strenght.Text = st.ToString();
            }

            int kl = Convert.ToInt32(Point.Text);
            kl += 1;
            Point.Text = kl.ToString();
        }

        private void Minus_Click_Agl(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Agility.Text);
            st -= 1;

            if (st == 0)
            {
                Agility.Text = st.ToString();
                MinAgl.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PlusAgl.Visibility = Visibility.Visible;
                PlusInt.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                Agility.Text = st.ToString();
            }

            int kl = Convert.ToInt32(Point.Text);
            kl += 1;
            Point.Text = kl.ToString();
        }

        private void Minus_Click_Int(object sender, RoutedEventArgs e)
        {
            int st = Convert.ToInt32(Intelligence.Text);
            st -= 1;
            if (st == 0)
            {
                Intelligence.Text = st.ToString();
                MinInt.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PlusInt.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                PlusAgl.Visibility = Visibility.Visible;
                Intelligence.Text = st.ToString();
            }

            int kl = Convert.ToInt32(Point.Text);
            kl += 1;
            Point.Text = kl.ToString();
        }

        private void Experience1_Click(object sender, RoutedEventArgs e)
        {
            int L1000 = Convert.ToInt32(FirstLvl.Text);
            int Lvl = Convert.ToInt32(NeedExp.Text);

            L1000 += 1000;
            FirstLvl.Text = L1000.ToString();

            if (L1000 >= Lvl)
            {
                Lvl += 6000;
                NeedExp.Text = Lvl.ToString();
                int kl = Convert.ToInt32(Point.Text);
                kl += 5;
                Point.Text = kl.ToString();
                PlusInt.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                PlusAgl.Visibility = Visibility.Visible;
            }
        }

        private void Experience2_Click(object sender, RoutedEventArgs e)
        {
            int L2000 = Convert.ToInt32(FirstLvl.Text);
            int Lvl = Convert.ToInt32(NeedExp.Text);

            L2000 += 2000;
            FirstLvl.Text = L2000.ToString();

            if (L2000 >= Lvl)
            {
                Lvl += 6000;
                NeedExp.Text = Lvl.ToString();
                int kl = Convert.ToInt32(Point.Text);
                kl += 5;
                Point.Text = kl.ToString();
                PlusInt.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                PlusAgl.Visibility = Visibility.Visible;
            }
        }

        private void Experience3_Click(object sender, RoutedEventArgs e)
        {
            int L3000 = Convert.ToInt32(FirstLvl.Text);
            int Lvl = Convert.ToInt32(NeedExp.Text);

            L3000 += 3000;
            FirstLvl.Text = L3000.ToString();

            if (L3000 >= Lvl)
            {
                Lvl += 6000;
                NeedExp.Text = Lvl.ToString();
                int kl = Convert.ToInt32(Point.Text);
                kl += 5;
                Point.Text = kl.ToString();
                PlusInt.Visibility = Visibility.Visible;
                PlusStr.Visibility = Visibility.Visible;
                PlusAgl.Visibility = Visibility.Visible;
            }
        }

        private void btn_bd_Click(object sender, RoutedEventArgs e)
        {
            Unit_Robber unit = new Unit_Robber(int.Parse(Agility.Text), int.Parse(Strenght.Text), int.Parse(Intelligence.Text));
            byte[] imagebytes = File.ReadAllBytes(unit.IMG);
            Unit_Robber.Add(unit);
            MessageBox.Show("Занесено в базу!");
        }
    }
}
