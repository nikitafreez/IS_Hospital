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

namespace IS_Hospital
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        //SqlConnection conString = new SqlConnection("Data Source=SQL5080.site4now.net;Initial Catalog=db_a7d3b8_nikitafreez;User Id=db_a7d3b8_nikitafreez_admin;Password=POROL123");
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text != "admin" && passwordBox.Text != "admin")
                MessageBox.Show("Всё хуйня, давай по новой");
        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
