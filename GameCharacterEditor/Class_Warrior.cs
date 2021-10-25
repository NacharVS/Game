using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    public partial class Class_Warrior
    {
        public Class_Warrior()
        {
            InitializeComponent();
                
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
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
    }
}
