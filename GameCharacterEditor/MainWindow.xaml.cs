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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newForm = new Window1(this);
            newForm.Show();

        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void AddPersonalGridViewRows(Person Warior)
        {
            PersonalTable.Items.Add(Warior);
            PersonalTable.Items.Refresh();  
        }
    }
}
