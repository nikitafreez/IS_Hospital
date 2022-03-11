using System;
using System.Windows;
using IS_Hospital.Models;

namespace IS_Hospital
{
    public partial class ClientAddUpdateWindow : Window
    {
        public ClientAddUpdateWindow()
        {
            InitializeComponent();
        }

        private void ClientAddUpdateWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            AllModel<Passport> passports = new AllModel<Passport>("Passports");
            PassportComboBox.ItemsSource = passports.Objs;
            
            PassportComboBox.DisplayMemberPath = "MultiBox" ;
            PassportComboBox.SelectedValuePath = "Id";
            
            switch (MainWindow.clientOperation)
            {
                case 1:
                {
                    FuncButton.Content = "Добавить";
                    return;
                }
                case 2:
                {
                    PassportComboBox.SelectedValue = MainWindow.ClientIdPassport;
                    InnTextBox.Text = MainWindow.ClientInn;
                    SnilsTextBox.Text = MainWindow.ClientSnils;
                    PhoneTextBox.Text = MainWindow.ClientPhoneNumber;
                    EmailTextBox.Text = MainWindow.ClientEmail;
                    OmsTextBox.Text = MainWindow.ClientOms;

                    FuncButton.Content = "Изменить";
                    return;
                }
            }
        }

        private async void FuncButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (InnTextBox.Text.Length == 12 && SnilsTextBox.Text.Length == 9 && PhoneTextBox.Text.Length == 11 && OmsTextBox.Text.Length == 16)
            {
                switch (MainWindow.clientOperation)
                {
                    case 1:
                        {
                            try
                            {
                                Client client = new Client();

                                client.IdPassport = Convert.ToInt32(PassportComboBox.SelectedValue.ToString());
                                client.ClientEmail = EmailTextBox.Text;
                                client.ClientInn = InnTextBox.Text;
                                client.ClientSnils = SnilsTextBox.Text;
                                client.ClientOms = OmsTextBox.Text;
                                client.ClientPhoneNumber = PhoneTextBox.Text;

                                await client.Add();
                                this.Close();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, "Окно");
                                this.Close();
                            }
                            return;
                        }
                    case 2:
                        {
                            try
                            {
                                Client client = new Client();

                                client.IdPassport = Convert.ToInt32(PassportComboBox.SelectedValue.ToString());
                                client.ClientEmail = EmailTextBox.Text;
                                client.ClientInn = InnTextBox.Text;
                                client.ClientSnils = SnilsTextBox.Text;
                                client.ClientOms = OmsTextBox.Text;
                                client.ClientPhoneNumber = PhoneTextBox.Text;
                                client.Id = MainWindow.clientToUpdateId;

                                await client.Update();
                                this.Close();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, "Окно");
                                this.Close();
                            }
                            return;
                        }
                }
            }
            else
            {
                MessageBox.Show($"Некорректно введены данные пользователя. Повторите попытку.\n" +
                    $"Длина ИНН=12\tУ вас ИНН={InnTextBox.Text.Length}\n" +
                    $"Длина СНИЛС=9\tУ вас СНИЛС={SnilsTextBox.Text.Length}\n" +
                    $"Длина ОМС = 16\tУ вас ОМС ={OmsTextBox.Text.Length}");
            }
        }
    }
}