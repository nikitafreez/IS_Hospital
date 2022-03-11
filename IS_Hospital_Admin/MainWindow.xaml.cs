using IS_Hospital_Admin.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
        AllModel<Department> departments = new AllModel<Department>("Departments");
        AllModel<Position> positions = new AllModel<Position>("Positions");
        AllModel<Worker> workers = new AllModel<Worker>("Workers");
        AllModel<Client> clients = new AllModel<Client>("Clients");
        AllModel<Equipment> equipments = new AllModel<Equipment>("Equipments");
        AllModel<Salary> salaries = new AllModel<Salary>("Salaries");
        AllModel<ServicesTable> serviceTables = new AllModel<ServicesTable>("ServicesTables");

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
                passport1DataGrid.ItemsSource = passports.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void departmentDataUpdate()
        {
            try
            {
                departmentsDataGrid.ItemsSource = departments.Objs;

                departmentComboBox.ItemsSource = departments.Objs;
                departmentComboBox.DisplayMemberPath = "DepartmentName";
                departmentComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void positionDataUpdate()
        {
            try
            {
                positionsDataGrid.ItemsSource = positions.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void workerDataUpdate()
        {
            try
            {
                workerDataGrid.ItemsSource = workers.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void clientDataUpdate()
        {
            try
            {
                clientsDataGrid.ItemsSource = clients.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void equipmentDataUpdate()
        {
            try
            {
                equipmentsDataGrid.ItemsSource = equipments.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void salaryDataUpdate()
        {
            try
            {
                salariesDataGrid.ItemsSource = salaries.Objs;

                workerINNComboBox.ItemsSource = workers.Objs;
                workerINNComboBox.DisplayMemberPath = "WorkerInn";
                workerINNComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }
        private void serviceTableDataUpdate()
        {
            try
            {
                servicesDataGrid.ItemsSource = serviceTables.Objs;

                serviceWorkerComboBox.ItemsSource = workers.Objs;
                serviceWorkerComboBox.DisplayMemberPath = "FIO";
                serviceWorkerComboBox.SelectedValuePath = "Id";
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
            departmentDataUpdate();
            positionDataUpdate();
            workerDataUpdate();
            clientDataUpdate();
            equipmentDataUpdate();
            salaryDataUpdate();
            serviceTableDataUpdate();
        }

        private async void roleUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (roleDataGrid.SelectedItems[0] is Role role)
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

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private async void userAdd_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Login = loginTextBox.Text;
            user.Password = GetHash(passwordTextBox.Text);
            user.IdRole = int.Parse(roleComboBox.SelectedValue.ToString());

            await user.Add();
            userDataUpdate();
            loginTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            roleComboBox.SelectedItem = 0;
        }

        private async void UserUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (userDataGrid.SelectedItems[0] is User user)
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
            if (departmentsDataGrid.SelectedItem is Department selectedItem)
            {
                departmentName.Text = selectedItem.DepartmentName;
                departmentPhone.Text = selectedItem.DepartmentPhoneNumber;
            }
        }

        private async void DepartmentAdd_OnClick(object sender, RoutedEventArgs e)
        {
            Department department = new Department();
            department.DepartmentName = departmentName.Text;
            department.DepartmentPhoneNumber = departmentPhone.Text;

            await department.Add();
            departmentDataUpdate();
            departmentName.Text = String.Empty;
            departmentPhone.Text = String.Empty;
        }

        private async void DepartmentDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (departmentsDataGrid.SelectedItem is Department department)
            {
                await department.Delete();
                departmentDataUpdate();
            }
        }

        private async void DepartmentsUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            departmentDataUpdate();
        }

        private async void DepartmentUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (departmentsDataGrid.SelectedItem is Department department)
            {
                department.DepartmentName = departmentName.Text;
                department.DepartmentPhoneNumber = departmentPhone.Text;

                await department.Update();
                departmentDataUpdate();
                departmentName.Text = String.Empty;
                departmentPhone.Text = String.Empty;
            }
        }

        private async void PositionAdd_OnClick(object sender, RoutedEventArgs e)
        {
            Position position = new Position();
            position.PositionName = positionNameTextBox.Text;
            position.PositionSalary = Convert.ToInt32(positionSalaryTextBox.Text);
            position.IdDepartment = Convert.ToInt32(departmentComboBox.SelectedValue.ToString());

            await position.Add();
            positionDataUpdate();
            positionNameTextBox.Text = String.Empty;
            positionSalaryTextBox.Text = String.Empty;
            departmentComboBox.SelectedItem = 1;
        }

        private async void PositionUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (positionsDataGrid.SelectedItem is Position position)
            {
                position.PositionName = positionNameTextBox.Text;
                position.PositionSalary = Convert.ToInt32(positionSalaryTextBox.Text);
                position.IdDepartment = Convert.ToInt32(departmentComboBox.SelectedValue.ToString());

                await position.Update();
                positionDataUpdate();
                positionNameTextBox.Text = String.Empty;
                positionSalaryTextBox.Text = String.Empty;
                departmentComboBox.SelectedItem = 1;
            }
        }

        private async void PositionDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (positionsDataGrid.SelectedItem is Position position)
            {
                await position.Delete();
                positionDataUpdate();
            }
        }

        private void PositionsUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            positionDataUpdate();
        }

        private void PositionsDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (positionsDataGrid.SelectedItem is Position selectedItem)
            {
                positionNameTextBox.Text = selectedItem.PositionName;
                positionSalaryTextBox.Text = selectedItem.PositionSalary.ToString();
                departmentComboBox.SelectedItem = selectedItem.IdDepartment;
            }
        }

        public static int workerOperation = 0;
        private void WorkerAdd_OnClick(object sender, RoutedEventArgs e)
        {
            workerOperation = 1;
            WorkerAddUpdateWindow newWin = new WorkerAddUpdateWindow();
            newWin.Show();
        }

        private void WorkerUpdate_OnClick(object sender, RoutedEventArgs e)
        {

            if (workerDataGrid.SelectedItem is Worker worker)
            {
                workerOperation = 2;
                WorkerAddUpdateWindow newWin = new WorkerAddUpdateWindow();
                newWin.Show();
            }
        }

        private void WorkersUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            workerDataUpdate();
        }

        private async void WorkerDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (workerDataGrid.SelectedItem is Worker worker)
            {
                await worker.Delete();
                workerDataUpdate();
            }
        }

        public static int workerToUpdateId = -1;
        public static int IdPassport = -1;
        public static int IdPosition = -1;
        public static string WorkerInn = "";
        public static string WorkerSnils = "";
        public static string WorkerPhoneNumber = "";
        public static string WorkerEmail = "";
        public static string WorkerEducation = "";
        public static string WorkerEducationPlace = "";
        private void WorkerDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (workerDataGrid.SelectedItem is Worker worker)
            {
                workerToUpdateId = worker.Id;
                IdPassport = worker.IdPassport;
                IdPosition = worker.IdPosition;
                WorkerInn = worker.WorkerInn;
                WorkerSnils = worker.WorkerSnils;
                WorkerPhoneNumber = worker.WorkerPhoneNumber;
                WorkerEmail = worker.WorkerEmail;
                WorkerEducation = worker.WorkerEducation;
                WorkerEducationPlace = worker.WorkerEducationPlace;
            }
        }

        public static int clientOperation = -1;
        private void ClientAdd_OnClick(object sender, RoutedEventArgs e)
        {
            clientOperation = 1;
            ClientAddUpdateWindow newWin = new ClientAddUpdateWindow();
            newWin.Show();
        }

        private void ClientUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (clientsDataGrid.SelectedItem is Client client)
            {
                clientOperation = 2;
                ClientAddUpdateWindow newWin = new ClientAddUpdateWindow();
                newWin.Show();
            }
        }

        private async void ClientDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (clientsDataGrid.SelectedItem is Client client)
            {
                await client.Delete();
                clientDataUpdate();
            }
        }

        private void ClientsUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            clientDataUpdate();
        }

        public static int clientToUpdateId = -1;
        public static int ClientIdPassport = -1;
        public static string ClientInn = "";
        public static string ClientSnils = "";
        public static string ClientPhoneNumber = "";
        public static string ClientEmail = "";
        public static string ClientOms = "";
        private void ClientsDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (clientsDataGrid.SelectedItem is Client client)
            {
                clientToUpdateId = client.Id;
                ClientIdPassport = client.IdPassport;
                ClientInn = client.ClientInn;
                ClientSnils = client.ClientSnils;
                ClientPhoneNumber = client.ClientPhoneNumber;
                ClientEmail = client.ClientEmail;
                ClientOms = client.ClientOms;
            }
        }

        private async void EquipmentAdd_OnClick(object sender, RoutedEventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.EquipmentName = EquipmentNameTextBox.Text;
            equipment.EquipmentCost = Convert.ToDouble(EquipmentCostTextBox.Text);
            equipment.EquipmentServiceLife = Convert.ToDouble(EquipmentServiceLifeTextBox.Text);
            equipment.EquipmentStartupDate = Convert.ToDateTime(EquipmentStartupDatePicker.Text);

            await equipment.Add();
            equipmentDataUpdate();
        }

        private async void EquipmentDelete_OnClick(object sender, RoutedEventArgs e)
        {
            await (equipmentsDataGrid.SelectedItems[0] as Equipment).Delete();
            equipmentDataUpdate();
        }

        private async void EquipmentUpdate_OnClick(object sender, RoutedEventArgs e)
        {

            if (equipmentsDataGrid.SelectedItems[0] is Equipment equipment)
            {
                equipment.EquipmentName = EquipmentNameTextBox.Text;
                equipment.EquipmentCost = Convert.ToDouble(EquipmentCostTextBox.Text);
                equipment.EquipmentServiceLife = Convert.ToDouble(EquipmentServiceLifeTextBox.Text);
                equipment.EquipmentStartupDate = Convert.ToDateTime(EquipmentStartupDatePicker.Text);
                await equipment.Update();
            }

            equipmentDataUpdate();
        }

        private void EquipmentsDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (equipmentsDataGrid.SelectedItem is Equipment selectedItem)
            {
                EquipmentNameTextBox.Text = selectedItem.EquipmentName;
                EquipmentCostTextBox.Text = Convert.ToString(selectedItem.EquipmentCost);
                EquipmentServiceLifeTextBox.Text = selectedItem.EquipmentServiceLife.ToString();
                EquipmentStartupDatePicker.Text = selectedItem.EquipmentStartupDate.ToString();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void salaryAdd_Click(object sender, RoutedEventArgs e)
        {
            Salary salary = new Salary();
            salary.SalaryAmount = Convert.ToInt32(SalaryAmountTextBox.Text);
            salary.HoursWorked = Convert.ToInt32(HoursWorkedTextBox.Text);
            salary.PrizeAmount = Convert.ToInt32(PrizeAmountTextBox.Text);
            salary.DateOfGive = Convert.ToDateTime(DateOfGiveDatePicker.Text);
            salary.IdWorker = Convert.ToInt32(workerINNComboBox.SelectedValue.ToString());

            await salary.Add();
            salaryDataUpdate();
        }

        private async void salaryUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (salariesDataGrid.SelectedItems[0] is Salary salary)
            {
                salary.SalaryAmount = Convert.ToInt32(SalaryAmountTextBox.Text);
                salary.HoursWorked = Convert.ToInt32(HoursWorkedTextBox.Text);
                salary.PrizeAmount = Convert.ToInt32(PrizeAmountTextBox.Text);
                salary.DateOfGive = Convert.ToDateTime(DateOfGiveDatePicker.Text);
                salary.IdWorker = Convert.ToInt32(workerINNComboBox.SelectedValue.ToString());

                await salary.Update();
            }

            salaryDataUpdate();
        }

        private async void salaryDelete_Click(object sender, RoutedEventArgs e)
        {
            await (salariesDataGrid.SelectedItem as Salary).Delete();
            salaryDataUpdate();
        }

        private void salariesUpdate_Click(object sender, RoutedEventArgs e)
        {
            salaryDataUpdate();
        }

        private void salariesDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (salariesDataGrid.SelectedItem is Salary selectedItem)
            {
                SalaryAmountTextBox.Text = selectedItem.SalaryAmount.ToString();
                HoursWorkedTextBox.Text = selectedItem.HoursWorked.ToString();
                PrizeAmountTextBox.Text = selectedItem.PrizeAmount.ToString();
                DateOfGiveDatePicker.Text = selectedItem.DateOfGive.ToString();
                workerINNComboBox.SelectedValue = selectedItem.IdWorker;
            }
        }


        private async void serviceAdd_Click(object sender, RoutedEventArgs e)
        {

            ServicesTable services = new ServicesTable();
            services.ServiceTitle = serviceNameTextBox.Text;
            services.ServiceCost = Convert.ToInt32(serviceCostTextBox.Text);
            services.IdWorker = Convert.ToInt32(serviceWorkerComboBox.SelectedValue.ToString());

            await services.Add();
            serviceTableDataUpdate();
        }

        private async void serviceUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (servicesDataGrid.SelectedItems[0] is ServicesTable servicesTable)
            {
                servicesTable.ServiceTitle = serviceNameTextBox.Text;
                servicesTable.ServiceCost = Convert.ToInt32(serviceCostTextBox.Text);
                servicesTable.IdWorker = Convert.ToInt32(serviceWorkerComboBox.SelectedValue.ToString());

                await servicesTable.Update();
            }

            serviceTableDataUpdate();
        }

        private async void serviceDelete_Click(object sender, RoutedEventArgs e)
        {
            await (servicesDataGrid.SelectedItem as ServicesTable).Delete();
            serviceTableDataUpdate();
        }

        private void servicesUpdate_Click(object sender, RoutedEventArgs e)
        {
            serviceTableDataUpdate();
        }

        private void servicesDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (servicesDataGrid.SelectedItem is ServicesTable selectedItem)
            {
                serviceNameTextBox.Text = selectedItem.ServiceTitle;
                serviceCostTextBox.Text = selectedItem.ServiceCost.ToString();
                serviceWorkerComboBox.SelectedValue = selectedItem.IdWorker;
            }
        }
    }
}