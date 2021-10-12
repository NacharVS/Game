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
        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            tb.Text = " You selected " + lbi.Content.ToString() + "./";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("person created!!!!!!!");
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            dam.Text = "200";
            def.Text = "400";
            att.Text = "111";
            spe.Text = "700";
            mag.Text = "666";
            hp.Text = "300";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            dam.Text = "2000";
            def.Text = "4000";
            att.Text = "1101";
            spe.Text = "7000";
            mag.Text = "6606";
            hp.Text = "3000";
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            dam.Text = "20";
            def.Text = "40";
            att.Text = "11";
            spe.Text = "70";
            mag.Text = "66";
            hp.Text = "30";
        }
    }
}