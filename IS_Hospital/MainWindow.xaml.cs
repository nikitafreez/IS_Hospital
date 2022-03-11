using IS_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace IS_Hospital
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
        AllModel<ServicesTables> serviceTables = new AllModel<ServicesTables>("ServicesTables");
        AllModel<Transaction> transactions = new AllModel<Transaction>("Transactions");
        AllModel<Accounting> accountings = new AllModel<Accounting>("Accountings");
        AllModel<Cabinet> cabinets = new AllModel<Cabinet>("Cabinets");
        AllModel<WorkersOnCabinet> workersOnCabinets = new AllModel<WorkersOnCabinet>("WorkersOnCabinets");
        AllModel<EquipmentsOnCabinet> equipmentOnCabinets = new AllModel<EquipmentsOnCabinet>("EquipmentsOnCabinets");
        AllModel<Treatment> treatments = new AllModel<Treatment>("Treatments");
        AllModel<ServicesList> servicesList = new AllModel<ServicesList>("ServicesLists");

        DataGridSupport gridSupport = new DataGridSupport();

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

        private void transactionsDataUpdate()
        {
            try
            {
                transactionsDataGrid.ItemsSource = transactions.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void budjetsDataUpdate()
        {
            try
            {
                budjetsDataGrid.ItemsSource = accountings.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void cabinetsDataUpdate()
        {
            try
            {
                cabinetsDataGrid.ItemsSource = cabinets.Objs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void workersOnCabinetsDataUpdate()
        {
            try
            {
                workerOnCabinetDataGrid.ItemsSource = workersOnCabinets.Objs;

                workerOnCabinetComboBox.ItemsSource = workers.Objs;
                workerOnCabinetComboBox.DisplayMemberPath = "FIO";
                workerOnCabinetComboBox.SelectedValuePath = "Id";

                cabinetWithWorkerComboBox.ItemsSource = cabinets.Objs;
                cabinetWithWorkerComboBox.DisplayMemberPath = "CabinetNum";
                cabinetWithWorkerComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void equipmentOnCabinetsDataUpdate()
        {
            try
            {
                equipmentOnCabinetDataGrid.ItemsSource = equipmentOnCabinets.Objs;

                equipmentOnCabinetComboBox.ItemsSource = equipments.Objs;
                equipmentOnCabinetComboBox.DisplayMemberPath = "EquipmentName";
                equipmentOnCabinetComboBox.SelectedValuePath = "Id";

                cabinetWithEquipmentComboBox.ItemsSource = cabinets.Objs;
                cabinetWithEquipmentComboBox.DisplayMemberPath = "CabinetNum";
                cabinetWithEquipmentComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void treatmentsDataUpdate()
        {
            try
            {
                treatmentsDataGrid.ItemsSource = treatments.Objs;

                TreatmentPatientComboBox.ItemsSource = clients.Objs;
                TreatmentPatientComboBox.DisplayMemberPath = "FIO";
                TreatmentPatientComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void servicesListDataUpdate()
        {
            try
            {
                servicesListDataGrid.ItemsSource = servicesList.Objs;

                serviceTreatmentComboBox.ItemsSource = treatments.Objs;
                serviceTreatmentComboBox.DisplayMemberPath = "Id";
                serviceTreatmentComboBox.SelectedValuePath = "Id";


                servicesListComboBox.ItemsSource = serviceTables.Objs;
                servicesListComboBox.DisplayMemberPath = "ServiceTitle";
                servicesListComboBox.SelectedValuePath = "Id";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void AdminWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
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
                transactionsDataUpdate();
                budjetsDataUpdate();
                cabinetsDataUpdate();
                workersOnCabinetsDataUpdate();
                equipmentOnCabinetsDataUpdate();
                treatmentsDataUpdate();
                servicesListDataUpdate();
            }
            catch
            {
                MessageBox.Show("Проверьте подключение к интернету и повторите попытку.");
            }
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

        private void rolesUpdate_Click(object sender, RoutedEventArgs e)
        {
            roleDataUpdate();
        }

        private async void userAdd_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text.Length >= 3 && passwordTextBox.Text.Length >= 3)
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
            else
            {
                MessageBox.Show("Некорректно введены данные пользователя. Повторите попытку");
            }
        }

        private async void UserUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text.Length >= 3 && passwordTextBox.Text.Length >= 3)
            {
                if (userDataGrid.SelectedItems[0] is User user)
                {
                    user.Login = loginTextBox.Text;
                    user.Password = GetHash(passwordTextBox.Text);
                    user.IdRole = int.Parse(roleComboBox.SelectedValue.ToString());
                    await user.Update();
                }

                userDataUpdate();
                loginTextBox.Text = String.Empty;
                passwordTextBox.Text = String.Empty;
                roleComboBox.SelectedItem = 0;
            }
            else
            {
                MessageBox.Show("Некорректно введены данные пользователя. Повторите попытку");
            }
        }

        private async void UserDelete_OnClick(object sender, RoutedEventArgs e)
        {
            await (userDataGrid.SelectedItems[0] as User).Delete();
            userDataUpdate();
        }


        private void usersUpdate_Click(object sender, RoutedEventArgs e)
        {
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
            try
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
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы. Повторите попытку.");
            }
        }

        private async void PassportDelete_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {

                if (passportDataGrid.SelectedItem is Passport pass)
                {
                    await pass.Delete();
                    passportDataUpdate();
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы. Повторите попытку.");
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
            try
            {
                Department department = new Department();
                department.DepartmentName = departmentName.Text;
                department.DepartmentPhoneNumber = departmentPhone.Text;

                await department.Add();
                departmentDataUpdate();
                departmentName.Text = String.Empty;
                departmentPhone.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("Данные неккоректны. Повторите попытку.");
            }
        }

        private async void DepartmentDelete_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (departmentsDataGrid.SelectedItem is Department department)
                {
                    await department.Delete();
                    departmentDataUpdate();
                }

            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы. Повторите попытку.");
            }
        }

        private async void DepartmentsUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            departmentDataUpdate();
        }

        private async void DepartmentUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы или данные неккоректны. Повторите попытку.");
            }
        }

        private async void PositionAdd_OnClick(object sender, RoutedEventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Данные неккоректны. Повторите попытку.");
            }
        }

        private async void PositionUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы или данные неккоректны. Повторите попытку.");
            }
        }

        private async void PositionDelete_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (positionsDataGrid.SelectedItem is Position position)
                {
                    await position.Delete();
                    positionDataUpdate();
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблиц. Повторите попытку.");
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
            try
            {
                if (workerDataGrid.SelectedItem is Worker worker)
                {
                    await worker.Delete();
                    workerDataUpdate();
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы. Повторите попытку.");
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
            try
            {
                if (clientsDataGrid.SelectedItem is Client client)
                {
                    await client.Delete();
                    clientDataUpdate();
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы или данные неккоректны. Повторите попытку.");
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
            try
            {
                Equipment equipment = new Equipment();
                equipment.EquipmentName = EquipmentNameTextBox.Text;
                equipment.EquipmentCost = Convert.ToDouble(EquipmentCostTextBox.Text);
                equipment.EquipmentServiceLife = Convert.ToDouble(EquipmentServiceLifeTextBox.Text);
                equipment.EquipmentStartupDate = Convert.ToDateTime(EquipmentStartupDatePicker.Text);

                await equipment.Add();
                equipmentDataUpdate();
            }
            catch
            {
                MessageBox.Show("Данные неккоректны. Повторите попытку.");
            }
        }

        private async void EquipmentDelete_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                await (equipmentsDataGrid.SelectedItems[0] as Equipment).Delete();
                equipmentDataUpdate();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы. Повторите попытку.");
            }
        }

        private async void EquipmentUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Вы не выбрали данные из таблицы или данные неккоректны. Повторите попытку.");
            }
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
            ServicesTables services = new ServicesTables();
            services.ServiceTitle = serviceNameTextBox.Text;
            services.ServiceCost = Convert.ToInt32(serviceCostTextBox.Text);
            services.IdWorker = Convert.ToInt32(serviceWorkerComboBox.SelectedValue.ToString());

            await services.Add();
            serviceTableDataUpdate();
        }

        private async void serviceUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (servicesDataGrid.SelectedItems[0] is ServicesTables servicesTable)
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
            await (servicesDataGrid.SelectedItem as ServicesTables).Delete();
            serviceTableDataUpdate();
        }

        private void servicesUpdate_Click(object sender, RoutedEventArgs e)
        {
            serviceTableDataUpdate();
        }

        private void servicesDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (servicesDataGrid.SelectedItem is ServicesTables selectedItem)
            {
                serviceNameTextBox.Text = selectedItem.ServiceTitle;
                serviceCostTextBox.Text = selectedItem.ServiceCost.ToString();
                serviceWorkerComboBox.SelectedValue = selectedItem.IdWorker;
            }
        }

        private async void transactionAdd_Click(object sender, RoutedEventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionSum = Convert.ToInt32(TransactionSumTextBox.Text);
            transaction.TransactionDescription = TransactionDescTextBox.Text;
            transaction.TransactionDate = Convert.ToDateTime(TransactionDatePicker.Text);
            await transaction.Add();
            transactionsDataUpdate();
        }

        private async void transactionUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (transactionsDataGrid.SelectedItems[0] is Transaction transaction)
            {

                transaction.TransactionSum = Convert.ToInt32(TransactionSumTextBox.Text);
                transaction.TransactionDescription = TransactionDescTextBox.Text;
                transaction.TransactionDate = Convert.ToDateTime(TransactionDatePicker.Text);

                await transaction.Update();
            }

            transactionsDataUpdate();
        }

        private async void transactionDelete_Click(object sender, RoutedEventArgs e)
        {
            await (transactionsDataGrid.SelectedItem as Transaction).Delete();
            transactionsDataUpdate();
        }

        private void transactionsDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (transactionsDataGrid.SelectedItem is Transaction transaction)
            {
                TransactionSumTextBox.Text = transaction.TransactionSum.ToString();
                TransactionDescTextBox.Text = transaction.TransactionDescription.ToString();
                TransactionDatePicker.Text = transaction.TransactionDate.ToString();
            }
        }

        private void transactionsUpdate_Click(object sender, RoutedEventArgs e)
        {
            transactionsDataUpdate();
        }

        private void budjetsDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (budjetsDataGrid.SelectedItem is Accounting accounting)
            {
                BudjetSumTextBox.Text = accounting.BudgetAmmount.ToString();
            }
        }

        private void budjetsUpdate_Click(object sender, RoutedEventArgs e)
        {
            budjetsDataUpdate();
        }

        private async void budjetDelete_Click(object sender, RoutedEventArgs e)
        {
            await (budjetsDataGrid.SelectedItem as Accounting).Delete();
            budjetsDataUpdate();
        }

        private async void budjetUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (budjetsDataGrid.SelectedItems[0] is Accounting accounting)
            {

                accounting.BudgetAmmount = Convert.ToDouble(BudjetSumTextBox.Text);

                await accounting.Update();
            }
            budjetsDataUpdate();
        }

        private async void budjetAdd_Click(object sender, RoutedEventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.BudgetAmmount = Convert.ToDouble(BudjetSumTextBox.Text);

            await accounting.Add();
            budjetsDataUpdate();
        }

        private async void cabinetAdd_Click(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            cabinet.CabinetNum = cabinetNumTextBox.Text;

            await cabinet.Add();
            cabinetsDataUpdate();
        }

        private async void cabinetUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (cabinetsDataGrid.SelectedItems[0] is Cabinet cabinet)
            {
                cabinet.CabinetNum = cabinetNumTextBox.Text;

                await cabinet.Update();
            }
            cabinetsDataUpdate();
        }

        private async void cabinetDelete_Click(object sender, RoutedEventArgs e)
        {
            await (cabinetsDataGrid.SelectedItem as Cabinet).Delete();
            cabinetsDataUpdate();
        }

        private void cabinetsUpdate_Click(object sender, RoutedEventArgs e)
        {
            cabinetsDataUpdate();
        }

        private void cabinetsDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (cabinetsDataGrid.SelectedItem is Cabinet cabinet)
            {
                cabinetNumTextBox.Text = cabinet.CabinetNum.ToString();
            }
        }

        private async void workerOnCabinetUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (workerOnCabinetDataGrid.SelectedItems[0] is WorkersOnCabinet workersCab)
            {
                workersCab.IdCabinet = Convert.ToInt32(cabinetWithWorkerComboBox.SelectedValue.ToString());
                workersCab.IdWorker = Convert.ToInt32(workerOnCabinetComboBox.SelectedValue.ToString());

                await workersCab.Update();
            }
            workersOnCabinetsDataUpdate();
        }

        private async void workerOnCabinetAdd_Click(object sender, RoutedEventArgs e)
        {
            WorkersOnCabinet workersOnCabinet = new WorkersOnCabinet();
            workersOnCabinet.IdCabinet = Convert.ToInt32(cabinetWithWorkerComboBox.SelectedValue.ToString());
            workersOnCabinet.IdWorker = Convert.ToInt32(workerOnCabinetComboBox.SelectedValue.ToString());

            await workersOnCabinet.Add();
            workersOnCabinetsDataUpdate();
        }

        private async void workerOnCabinetDelete_Click(object sender, RoutedEventArgs e)
        {
            await (workerOnCabinetDataGrid.SelectedItem as WorkersOnCabinet).Delete();
            workersOnCabinetsDataUpdate();
        }

        private void workerOnCabinetsUpdate_Click(object sender, RoutedEventArgs e)
        {
            workersOnCabinetsDataUpdate();
        }

        private void workerOnCabinetDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (workerOnCabinetDataGrid.SelectedItem is WorkersOnCabinet workersOnCabinet)
            {
                cabinetWithWorkerComboBox.SelectedValue = workersOnCabinet.IdCabinet;
                workerOnCabinetComboBox.SelectedValue = workersOnCabinet.IdWorker;
            }
        }

        private async void equipmentOnCabinetDelete_Click(object sender, RoutedEventArgs e)
        {
            await (equipmentOnCabinetDataGrid.SelectedItem as EquipmentsOnCabinet).Delete();
            equipmentOnCabinetsDataUpdate();
        }

        private async void equipmentOnCabinetUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (equipmentOnCabinetDataGrid.SelectedItems[0] is EquipmentsOnCabinet equipmentsOnCabinet)
            {

                equipmentsOnCabinet.IdCabinet = Convert.ToInt32(cabinetWithEquipmentComboBox.SelectedValue);
                equipmentsOnCabinet.IdEquipment = Convert.ToInt32(equipmentOnCabinetComboBox.SelectedValue);
                equipmentsOnCabinet.EquipmentNum = Convert.ToInt32(EquipmentOnCabinetAmountTextBox.Text);

                await equipmentsOnCabinet.Update();
            }
            equipmentOnCabinetsDataUpdate();
        }

        private async void equipmentOnCabinetAdd_Click(object sender, RoutedEventArgs e)
        {
            EquipmentsOnCabinet equipmentsOnCabinet = new EquipmentsOnCabinet();
            equipmentsOnCabinet.IdCabinet = Convert.ToInt32(cabinetWithEquipmentComboBox.SelectedValue);
            equipmentsOnCabinet.IdEquipment = Convert.ToInt32(equipmentOnCabinetComboBox.SelectedValue);
            equipmentsOnCabinet.EquipmentNum = Convert.ToInt32(EquipmentOnCabinetAmountTextBox.Text);

            await equipmentsOnCabinet.Add();
            equipmentOnCabinetsDataUpdate();
        }

        private void equipmentOnCabinetsUpdate_Click(object sender, RoutedEventArgs e)
        {
            equipmentOnCabinetsDataUpdate();
        }

        private void equipmentOnCabinetDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (equipmentOnCabinetDataGrid.SelectedItem is EquipmentsOnCabinet equipmentsOnCabinet)
            {
                equipmentOnCabinetComboBox.SelectedValue = equipmentsOnCabinet.IdEquipment.ToString();
                cabinetWithEquipmentComboBox.SelectedValue = equipmentsOnCabinet.IdCabinet.ToString();
                EquipmentOnCabinetAmountTextBox.Text = equipmentsOnCabinet.EquipmentNum.ToString();
            }
        }

        private async void treatmentAdd_Click(object sender, RoutedEventArgs e)
        {
            Treatment treatment = new Treatment();
            treatment.TreatmentSum = Convert.ToDouble(TreatmentSumTextBox.Text);
            treatment.TreatmentReason = TreatmentReasonTextBox.Text;
            treatment.TreatmentDate = Convert.ToDateTime(TreatmentsDatePicker.Text);
            treatment.IdClient = Convert.ToInt32(TreatmentPatientComboBox.SelectedValue);

            await treatment.Add();
            treatmentsDataUpdate();
        }

        private async void treatmentUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (treatmentsDataGrid.SelectedItems[0] is Treatment treatment)
            {
                treatment.TreatmentSum = Convert.ToDouble(TreatmentSumTextBox.Text);
                treatment.TreatmentReason = TreatmentReasonTextBox.Text;
                treatment.TreatmentDate = Convert.ToDateTime(TreatmentsDatePicker.Text);
                treatment.IdClient = Convert.ToInt32(TreatmentPatientComboBox.SelectedValue);

                await treatment.Update();
            }
            treatmentsDataUpdate();
        }

        private async void treatmentDelete_Click(object sender, RoutedEventArgs e)
        {
            await (treatmentsDataGrid.SelectedItem as Treatment).Delete();
            treatmentsDataUpdate();
        }

        private void treatmentsUpdate_Click(object sender, RoutedEventArgs e)
        {
            treatmentsDataUpdate();
        }

        private void treatmentsDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (treatmentsDataGrid.SelectedItem is Treatment treatment)
            {
                TreatmentSumTextBox.Text = treatment.TreatmentSum.ToString();
                TreatmentReasonTextBox.Text = treatment.TreatmentReason.ToString();
                TreatmentsDatePicker.Text = treatment.TreatmentDate.ToString();
                TreatmentPatientComboBox.SelectedValue = treatment.IdClient.ToString();
            }
        }

        private async void servicesListAdd_Click(object sender, RoutedEventArgs e)
        {
            ServicesList servicesList = new ServicesList();
            servicesList.IdService = Convert.ToInt32(servicesListComboBox.SelectedValue);
            servicesList.IdTreatment = Convert.ToInt32(serviceTreatmentComboBox.SelectedValue);

            await servicesList.Add();
            servicesListDataUpdate();
        }

        private async void servicesListUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (servicesListDataGrid.SelectedItems[0] is ServicesList servicesList)
            {
                servicesList.IdService = Convert.ToInt32(servicesListComboBox.SelectedValue);
                servicesList.IdTreatment = Convert.ToInt32(serviceTreatmentComboBox.SelectedValue);

                await servicesList.Update();
            }
            servicesListDataUpdate();
        }

        private async void servicesListDelete_Click(object sender, RoutedEventArgs e)
        {
            await (servicesListDataGrid.SelectedItem as ServicesList).Delete();
            servicesListDataUpdate();
        }

        private void servicesListsUpdate_Click(object sender, RoutedEventArgs e)
        {
            servicesListDataUpdate();
        }

        private void servicesListDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (servicesListDataGrid.SelectedItem is ServicesList servicesList)
            {
                servicesListComboBox.SelectedValue = servicesList.IdService.ToString();
                serviceTreatmentComboBox.SelectedValue = servicesList.IdTreatment.ToString();
            }
        }

        private void ExcelExportClick_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                List<DataGrid> dataGrids = new List<DataGrid>()
            {
                userDataGrid,
                roleDataGrid,
                passportDataGrid,
                departmentsDataGrid,
                positionsDataGrid,
                workerDataGrid,
                cabinetsDataGrid,
                workerOnCabinetDataGrid,
                salariesDataGrid,
                transactionsDataGrid,
                budjetsDataGrid,
                clientsDataGrid,
                equipmentsDataGrid,
                equipmentOnCabinetDataGrid,
                servicesDataGrid,
                treatmentsDataGrid,
                servicesListDataGrid
            };

                if (userDataGridTab.IsSelected && UsersTab.IsSelected)
                    gridSupport.ExcelExport(ref userDataGrid);

                if (roleDataGridTab.IsSelected && UsersTab.IsSelected)
                    gridSupport.ExcelExport(ref roleDataGrid);

                if (passportDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref passportDataGrid);

                if (passport1DataGridTab.IsSelected && ClientsTab.IsSelected)
                    gridSupport.ExcelExport(ref passportDataGrid);

                if (departmentsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref departmentsDataGrid);

                if (positionsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref positionsDataGrid);

                if (workerDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref workerDataGrid);

                if (cabinetsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref cabinetsDataGrid);

                if (workerOnCabinetDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.ExcelExport(ref workerOnCabinetDataGrid);

                if (salariesDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.ExcelExport(ref salariesDataGrid);

                if (transactionsDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.ExcelExport(ref transactionsDataGrid);

                if (budjetsDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.ExcelExport(ref budjetsDataGrid);

                if (clientsDataGridTab.IsSelected && ClientsTab.IsSelected)
                    gridSupport.ExcelExport(ref clientsDataGrid);

                if (equipmentsDataGridTab.IsSelected && OborudovanieTab.IsSelected)
                    gridSupport.ExcelExport(ref equipmentsDataGrid);

                if (equipmentOnCabinetDataGridTab.IsSelected && OborudovanieTab.IsSelected)
                    gridSupport.ExcelExport(ref equipmentOnCabinetDataGrid);

                if (servicesDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.ExcelExport(ref servicesDataGrid);

                if (treatmentsDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.ExcelExport(ref treatmentsDataGrid);

                if (servicesListDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.ExcelExport(ref servicesListDataGrid);
            }
            catch
            {
                MessageBox.Show("Выгрузка выполнена");
            }
        }

        private void PdfExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (userDataGridTab.IsSelected && UsersTab.IsSelected)
                    gridSupport.PdfExport(userDataGrid, "UserExport");

                if (roleDataGridTab.IsSelected && UsersTab.IsSelected)
                    gridSupport.PdfExport(roleDataGrid, "RoleExport");

                if (passportDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(passportDataGrid, "PassportExport");

                if (passport1DataGridTab.IsSelected && ClientsTab.IsSelected)
                    gridSupport.PdfExport(passportDataGrid, "PassportExport");

                if (departmentsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(departmentsDataGrid, "DepartmentExport");

                if (positionsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(positionsDataGrid, "PositionExport");

                if (workerDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(workerDataGrid, "WorkerExport");

                if (cabinetsDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(cabinetsDataGrid, "CabinetExport");

                if (workerOnCabinetDataGridTab.IsSelected && OtdelKadrovTab.IsSelected)
                    gridSupport.PdfExport(workerOnCabinetDataGrid, "WorkerOnCabinetExport");

                if (salariesDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.PdfExport(salariesDataGrid, "SalaryExport");

                if (transactionsDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.PdfExport(transactionsDataGrid, "TransactionExport");

                if (budjetsDataGridTab.IsSelected && BuhgalteriaTab.IsSelected)
                    gridSupport.PdfExport(budjetsDataGrid, "BudjetExport");

                if (clientsDataGridTab.IsSelected && ClientsTab.IsSelected)
                    gridSupport.PdfExport(clientsDataGrid, "ClientExport");

                if (equipmentsDataGridTab.IsSelected && OborudovanieTab.IsSelected)
                    gridSupport.PdfExport(equipmentsDataGrid, "EquipmentExport");

                if (equipmentOnCabinetDataGridTab.IsSelected && OborudovanieTab.IsSelected)
                    gridSupport.PdfExport(equipmentOnCabinetDataGrid, "EquipmentOnCabinetExport");

                if (servicesDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.PdfExport(servicesDataGrid, "ServiceExport");

                if (treatmentsDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.PdfExport(treatmentsDataGrid, "TreatmentExport");

                if (servicesListDataGridTab.IsSelected && UslugiTab.IsSelected)
                    gridSupport.PdfExport(servicesListDataGrid, "ServicesListExport");
            }
            catch
            {
                MessageBox.Show("Выгрузка выполнена");
            }
        }

        private void usersSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = users.Objs.Where(user => user.Login.Contains(userSeachBox.Text));
            userDataGrid.ItemsSource = filtred;
        }

        private void rolesSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = roles.Objs.Where(role => role.RoleName.Contains(roleSeachBox.Text));
            roleDataGrid.ItemsSource = filtred;
        }

        private void passportsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = passports.Objs.Where(role => role.PassportNumber.Contains(passportsSeachBox.Text));
            passportDataGrid.ItemsSource = filtred;
        }

        private void departmentsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = departments.Objs.Where(role => role.DepartmentName.Contains(departmentsSeachBox.Text));
            departmentsDataGrid.ItemsSource = filtred;
        }

        private void positionsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = positions.Objs.Where(role => role.PositionName.Contains(positionsSeachBox.Text));
            positionsDataGrid.ItemsSource = filtred;
        }

        private void workersSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = workers.Objs.Where(role => role.WorkerInn.Contains(workersSeachBox.Text));
            workerDataGrid.ItemsSource = filtred;
        }

        private void cabinetsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = cabinets.Objs.Where(role => role.CabinetNum.Contains(cabinetsSeachBox.Text));
            cabinetsDataGrid.ItemsSource = filtred;
        }


        private void passport1sSearchButton_Click(object sender, RoutedEventArgs e)
        {

            var filtred = passports.Objs.Where(role => role.PassportNumber.Contains(passport1sSeachBox.Text));
            passport1DataGrid.ItemsSource = filtred;
        }

        private void clientsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = clients.Objs.Where(role => role.ClientOms.Contains(clientsSeachBox.Text));
            clientsDataGrid.ItemsSource = filtred;
        }

        private void equipmentsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = equipments.Objs.Where(role => role.EquipmentName.Contains(equipmentsSeachBox.Text));
            equipmentsDataGrid.ItemsSource = filtred;
        }

        private void servicesSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = serviceTables.Objs.Where(role => role.ServiceTitle.Contains(servicesSeachBox.Text));
            servicesDataGrid.ItemsSource = filtred;
        }

        private void treatmentsSearchButton_Click(object sender, RoutedEventArgs e)
        {
            var filtred = treatments.Objs.Where(role => role.TreatmentReason.Contains(treatmentsSeachBox.Text));
            treatmentsDataGrid.ItemsSource = filtred;
        }

        private void equipmentsUpdate_Click(object sender, RoutedEventArgs e)
        {
            equipmentDataUpdate();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}