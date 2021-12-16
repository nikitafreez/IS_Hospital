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
            roleDataGrid.ItemsSource = roles.Objs;

            //List<Role> roleList = new List<Role>();
            //foreach (Role role in roles.Objs)
            //    roleList.Add(role);
            roleComboBox.ItemsSource = roles.Objs;
            roleComboBox.DisplayMemberPath = "RoleName";
            roleComboBox.SelectedValuePath = "Id";
        }

        private void AdminWindow_Loaded(object sender, RoutedEventArgs e)
        {
            roleDataUpdate();
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

        private void userAdd_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(roleComboBox.SelectedValue.ToString());
        }

        private void roleDataGrid_MouseLeftButtonDown(object sender, SelectedCellsChangedEventArgs e)
        {
            Role? selectedItem = roleDataGrid.SelectedItem as Role;
            if (selectedItem != null)
                roleTextBox.Text = selectedItem.RoleName;
        }
    }
}
