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
using System.Diagnostics;

namespace IS_Hospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AdminPanelMenuItem.Visibility = Visibility.Collapsed;
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AdminMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void UpdateTables_Click(object sender, RoutedEventArgs e)
        {
            startAdminPanel();
        }

        private void AdminMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
                startAdminPanel();
        }

        private void startAdminPanel()
        {
            Process.Start(@"C:\Users\nikit\source\repos\IS_Hospital\IS_Hospital_Admin\bin\Debug\net5.0-windows\IS_Hospital_Admin.exe");
        }
    }
}
