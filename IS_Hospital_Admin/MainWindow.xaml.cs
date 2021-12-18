using IS_Hospital_Admin.Models;
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

namespace IS_Hospital_Admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AllModel<Role> roles = new AllModel<Role>("Roles");
        AllModel<User> users = new AllModel<User>("Users");
        AllModel<Passport> passports = new AllModel<Passport>("Passports");

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void roleAdd_Click(object sender, RoutedEventArgs e)
        {
            Role role = new Role();
            role.RoleName = roleTextBox.Text;

            await role.Add();
            roleDataUpdate();
            roleTextBox.Text = String.Empty;
        }

        private void roleDataUpdate()
        {
            try
            {
                roleDataGrid.ItemsSource = roles.Objs;

                //List<Role> roleList = new List<Role>();
                //foreach (Role role in roles.Objs)
                //    roleList.Add(role);
                roleComboBox.ItemsSource = roles.Objs;
                roleComboBox.DisplayMemberPath = "RoleName";
                roleComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void userDataUpdate()
        {
            try
            {
                userDataGrid.ItemsSource = users.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void passportDataUpdate()
        {
            try
            {
                passportDataGrid.ItemsSource = passports.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void AdminWindow_Loaded(object sender, RoutedEventArgs e)
        {
            roleDataUpdate();
            userDataUpdate();
            passportDataUpdate();
        }

        private async void roleUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(roleDataGrid.SelectedItems[0] is Role role)
            {
                role.RoleName = roleTextBox.Text;
                await role.Update();
            }
            roleDataUpdate();
        }

        private async void roleDelete_Click(object sender, RoutedEventArgs e)
        {
            await (roleDataGrid.SelectedItems[0] as Role).Delete();
            roleDataUpdate();
        }

        private async void userAdd_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Login = loginTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.IdRole = int.Parse(roleComboBox.SelectedValue.ToString());

            await user.Add();
            userDataUpdate();
            loginTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            roleComboBox.SelectedItem = 0;
        }

        private async void UserUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if(userDataGrid.SelectedItems[0] is User user)
            {
                user.Login = loginTextBox.Text;
                user.Password = passwordTextBox.Text;
                user.IdRole = int.Parse(roleComboBox.SelectedValue.ToString());
                await user.Update();
            }
            userDataUpdate();
            loginTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            roleComboBox.SelectedItem = 0;
        }

        private async void UserDelete_OnClick(object sender, RoutedEventArgs e)
        {
            await (userDataGrid.SelectedItems[0] as User).Delete();
            userDataUpdate();
        }
        private void roleDataGrid_MouseLeftButtonDown(object sender, SelectedCellsChangedEventArgs e)
        {
            if (roleDataGrid.SelectedItem is Role selectedItem)
                roleTextBox.Text = selectedItem.RoleName;
        }


        private void UserDataGrid_OnMouseLeftButtonDown(object sender, SelectedCellsChangedEventArgs e)
        {
            if (userDataGrid.SelectedItem is User selectedItem)
            {
                loginTextBox.Text = selectedItem.Login;
                passwordTextBox.Text = selectedItem.Password;
                roleComboBox.SelectedValue = selectedItem.IdRole;
            }
        }

        public static int passOperation = 0; //1 - Add; 2 - Update
        private void PassportAdd_OnClick(object sender, RoutedEventArgs e)
        {
            passOperation = 1;
            PassportAddUpdateWindow newWin = new PassportAddUpdateWindow();
            newWin.Show();
            passportDataUpdate();
        }

        public static int passToUpdateId = 0;
        private void PassportUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (passportDataGrid.SelectedItems[0] is Passport passportToUpdate)
            {
                passToUpdateId = passportToUpdate.Id;
                passOperation = 2;
                PassportAddUpdateWindow newWin = new PassportAddUpdateWindow();
                newWin.Show();
            }
            passportDataUpdate();
        }
        
        private async void PassportDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (passportDataGrid.SelectedItem is Passport pass)
            {
                await pass.Delete();
                passportDataUpdate();
            }
        }

        private void PassportsUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            passportDataUpdate();
        }
        public static string passSeria = "";
        public static string passNum = "";
        public static string whoGive = "";
        public static DateTime dateOfGive;
        public static string firstName = "";
        public static string secondName = "";
        public static string middleName = "";
        public static string gender = "";
        public static DateTime dateOfBirth;
        public static string livingPlace = "";

        private void PassportDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (passportDataGrid.SelectedItem is Passport selectedItem)
            {
                passSeria = selectedItem.PassportSeries;
                passNum = selectedItem.PassportNumber;
                whoGive = selectedItem.PassportWhoGive;
                dateOfGive = selectedItem.PassportDateOfGive;
                firstName = selectedItem.PassportFirstName;
                secondName = selectedItem.PassportSecondName;
                middleName = selectedItem.PassportMiddleName;
                gender = selectedItem.PassportGender;
                dateOfBirth = selectedItem.PassportDateOfBirth;
                livingPlace = selectedItem.PassportLivingPlace;
            }
        }
        
        // private void roleDataGrid_MouseLeftButtonDown(object sender, SelectedCellsChangedEventArgs e)
        // {
        //     if (roleDataGrid.SelectedItem is Role selectedItem)
        //         roleTextBox.Text = selectedItem.RoleName;
        // }
        private void DepartmentsDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    
}
