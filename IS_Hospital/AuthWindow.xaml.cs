using IS_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        AllModel<User> users = new AllModel<User>("Users");
        //SqlConnection conString = new SqlConnection("Data Source=SQL5080.site4now.net;Initial Catalog=db_a7d3b8_nikitafreez;User Id=db_a7d3b8_nikitafreez_admin;Password=POROL123");
        public AuthWindow()
        {
            InitializeComponent();
#if DEBUG
            passwordBox.Text = "admin";
            loginBox.Text = "admin";
#endif
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text != "admin" && passwordBox.Text != "admin")
                MessageBox.Show("Нельзя создать пользователя с такими данными");
        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            try
            {
                if (users.Objs.Any(user => user.Login == loginBox.Text && user.Password == GetHash(passwordBox.Text)))
                {
                    var user = users.Objs.FirstOrDefault(user => user.Login == loginBox.Text && user.Password == GetHash(passwordBox.Text));
                    switch ((await new Role() { Id = (int)user.IdRole }.Get()).Id)
                    {
                        case 1: //admin
                            {
                                mainWin.Show();
                                this.Close();
                                return;
                            }
                        case 3: //doctor
                            {
                                mainWin.UsersTab.Visibility = Visibility.Collapsed;
                                mainWin.BuhgalteriaTab.Visibility = Visibility.Collapsed;
                                mainWin.OtdelKadrovTab.Visibility = Visibility.Collapsed;
                                mainWin.OborudovanieTab.Visibility = Visibility.Collapsed;
                                mainWin.ClientsTab.IsSelected = true;
                                mainWin.Show();
                                this.Close();
                                return;
                            }
                        case 4: //buhgalter
                            {
                                mainWin.UsersTab.Visibility = Visibility.Collapsed;
                                mainWin.ClientsTab.Visibility = Visibility.Collapsed;
                                mainWin.OtdelKadrovTab.Visibility = Visibility.Collapsed;
                                mainWin.OborudovanieTab.Visibility = Visibility.Collapsed;
                                mainWin.UslugiTab.Visibility = Visibility.Collapsed;
                                mainWin.BuhgalteriaTab.IsSelected = true;
                                mainWin.Show();
                                this.Close();
                                return;
                            }
                        case 14: //Technik
                            {
                                mainWin.UsersTab.Visibility = Visibility.Collapsed;
                                mainWin.ClientsTab.Visibility = Visibility.Collapsed;
                                mainWin.OtdelKadrovTab.Visibility = Visibility.Collapsed;
                                mainWin.BuhgalteriaTab.Visibility = Visibility.Collapsed;
                                mainWin.UslugiTab.Visibility = Visibility.Collapsed;
                                mainWin.OborudovanieTab.IsSelected = true;
                                mainWin.Show();
                                this.Close();
                                return;
                            }
                        case 16: //Kadrovik
                            {
                                mainWin.UsersTab.Visibility = Visibility.Collapsed;
                                mainWin.ClientsTab.Visibility = Visibility.Collapsed;
                                mainWin.OborudovanieTab.Visibility = Visibility.Collapsed;
                                mainWin.BuhgalteriaTab.Visibility = Visibility.Collapsed;
                                mainWin.UslugiTab.Visibility = Visibility.Collapsed;
                                mainWin.OtdelKadrovTab.IsSelected = true;
                                mainWin.Show();
                                this.Close();
                                return;
                            }
                        default:
                            {
                                MessageBox.Show("Данная роль пока что не поддерживается. Свяжитесь с Администратором.");
                                return;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Данного пользователя не существует. Повторите попытку");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте подключение к интернету и повторите попытку.");
            }
        }
    }
}
