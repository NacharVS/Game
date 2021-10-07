using System;
using System.Collections.Generic;
using System.Text;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow mw;
        public Window1(MainWindow mwf)
        {
            InitializeComponent();
            mw = mwf;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            bool right = true;
            if (nameObject.Text == "" || nameObject.Text == "" || Health.Text == "" || Rassa.Text == "" || ResistMagic.Text == "" || Convert.ToInt32(Lov.Text) < 1 || Convert.ToInt32(Intelect.Text) < 1)
            {
                right = false;
                MessageBox.Show("Введенны неверные данные");

            }
            if (right)
            {
                mw.AddPersonalGridViewRows(new Person(nameObject.Text, Health.Text, Rassa.Text, ResistMagic.Text, Lov.Text, Intelect.Text, Convert.ToInt32(Strench.Text)));
                this.addWindow.Close();
            }
        }

        private void endAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.addWindow.Close();
        }
    }
}
