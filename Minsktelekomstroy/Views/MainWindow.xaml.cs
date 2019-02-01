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
using MaterialDesignThemes.Wpf;

namespace Minsktelekomstroy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<MenuItem> menu = new List<MenuItem>();

            menu.Add(new MenuItem("Главное меню", PackIconKind.Menu));
            menu.Add(new MenuItem("Отделов кадров", PackIconKind.People));
            menu.Add(new MenuItem("Услуги", PackIconKind.ServiceToolbox));
            menu.Add(new MenuItem("О компании", PackIconKind.About));
            menu.Add(new MenuItem("Справочная система", PackIconKind.Help));
            menu.Add(new MenuItem("Выход", PackIconKind.Close));
            ListViewMenu.ItemsSource = menu;
        }
    }
}
