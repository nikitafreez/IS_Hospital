using System;
using System.Windows;
using IS_Hospital_Admin.Models;

namespace IS_Hospital_Admin
{
    public partial class WorkerAddUpdateWindow : Window
    {
        public WorkerAddUpdateWindow()
        {
            InitializeComponent();
        }

        private void WorkerAddUpdateWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            AllModel<Position> positions = new AllModel<Position>("Positions");
            AllModel<Passport> passports = new AllModel<Passport>("Passports");

            PositionComboBox.ItemsSource = positions.Objs;
            PassportComboBox.ItemsSource = passports.Objs;

            PositionComboBox.DisplayMemberPath = "PositionName";
            PositionComboBox.SelectedValuePath = "Id";

            PassportComboBox.DisplayMemberPath = "MultiBox" ;
            PassportComboBox.SelectedValuePath = "Id";
            switch (MainWindow.workerOperation)
            {
                case 1:
                {
                    FuncButton.Content = "Добавить";
                    return;
                }
                case 2:
                {
                    PassportComboBox.SelectedValue = MainWindow.IdPassport;
                    PositionComboBox.SelectedValue = MainWindow.IdPosition;
                    InnTextBox.Text = MainWindow.WorkerInn;
                    SnilsTextBox.Text = MainWindow.WorkerSnils;
                    PhoneTextBox.Text = MainWindow.WorkerPhoneNumber;
                    EmailTextBox.Text = MainWindow.WorkerEmail;
                    EducationTypeComboBox.SelectedValue = MainWindow.WorkerEducation;
                    EducationPlaceTextBox.Text = MainWindow.WorkerEducationPlace;
                    
                    FuncButton.Content = "Изменить";
                    return;
                }
            }
        }

        private async void FuncButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.workerOperation)
            {
                case 1:
                {
                    try
                    {
                        Worker worker = new Worker();

                        worker.IdPassport = Convert.ToInt32(PassportComboBox.SelectedValue.ToString());
                        worker.IdPosition = Convert.ToInt32(PositionComboBox.SelectedValue.ToString());
                        worker.WorkerEducation = EducationTypeComboBox.Text;
                        worker.WorkerEmail = EmailTextBox.Text;
                        worker.WorkerInn = InnTextBox.Text;
                        worker.WorkerSnils = SnilsTextBox.Text;
                        worker.WorkerEducationPlace = EducationPlaceTextBox.Text;
                        worker.WorkerPhoneNumber = PhoneTextBox.Text;

                        await worker.Add();
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
                        Worker worker = new Worker();

                        worker.IdPassport = Convert.ToInt32(PassportComboBox.SelectedValue.ToString());
                        worker.IdPosition = Convert.ToInt32(PositionComboBox.SelectedValue.ToString());
                        worker.WorkerEducation = EducationTypeComboBox.Text;
                        worker.WorkerEmail = EmailTextBox.Text;
                        worker.WorkerInn = InnTextBox.Text;
                        worker.WorkerSnils = SnilsTextBox.Text;
                        worker.WorkerEducationPlace = EducationPlaceTextBox.Text;
                        worker.WorkerPhoneNumber = PhoneTextBox.Text;
                        worker.Id = MainWindow.workerToUpdateId;
                        await worker.Update();
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

        private void EducationTypeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}