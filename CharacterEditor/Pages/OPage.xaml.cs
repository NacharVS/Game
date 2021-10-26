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

namespace CharacterEditor.Pages
{
    /// <summary>
    /// Логика взаимодействия для OPage.xaml
    /// </summary>
    public partial class OPage : Page
    {
        public OPage()
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
                PS.Visibility = Visibility.Hidden;
                PI.Visibility = Visibility.Hidden;
                PA.Visibility = Visibility.Hidden;
            }
            else if (p > 0)
            {
                MS.Visibility = Visibility.Visible;
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
                PI.Visibility = Visibility.Hidden;
                PS.Visibility = Visibility.Hidden;
                PA.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                MA.Visibility = Visibility.Visible;
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
                PI.Visibility = Visibility.Hidden;
                PS.Visibility = Visibility.Hidden;
                PA.Visibility = Visibility.Hidden;
            }
            else if (kl > 0)
            {
                MI.Visibility = Visibility.Visible;
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
                MS.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PI.Visibility = Visibility.Visible;
                PA.Visibility = Visibility.Visible;
                PS.Visibility = Visibility.Visible;
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
                MA.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PA.Visibility = Visibility.Visible;
                PI.Visibility = Visibility.Visible;
                PS.Visibility = Visibility.Visible;
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
                MI.Visibility = Visibility.Hidden;
            }

            else if (st > 0)
            {
                PI.Visibility = Visibility.Visible;
                PS.Visibility = Visibility.Visible;
                PA.Visibility = Visibility.Visible;
                Intelligence.Text = st.ToString();
            }

            int kl = Convert.ToInt32(Point.Text);
            kl += 1;
            Point.Text = kl.ToString();
        }
    }
}
