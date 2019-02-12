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
using System.Windows.Shapes;

namespace Minsktelekomstroy
{
    /// <summary>
    /// Interaction logic for PersonnelDepartment.xaml
    /// </summary>
    public partial class PersonnelDepartment : Window
    {
        MainWindow mainWindow;

        public PersonnelDepartment()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
