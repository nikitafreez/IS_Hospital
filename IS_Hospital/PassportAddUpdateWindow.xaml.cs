using System;
using System.Windows;
using IS_Hospital.Models;

namespace IS_Hospital
{
    public partial class PassportAddUpdateWindow : Window
    {
        public PassportAddUpdateWindow()
        {
            InitializeComponent();
        }

        private void PassportAddUpdateWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow.passOperation == 1)
                FuncButton.Content = "Добавить";
            else
            {
                if (MainWindow.gender == "Муж.")
                    MaleRadio.IsChecked = true;
                else
                    FemaleRadio.IsChecked = true;
                PassportNumberTextBox.Text = MainWindow.passNum;
                PassportSeriesTextBox.Text = MainWindow.passSeria;
                PassportWhoGiveTextBox.Text = MainWindow.whoGive;
                PassportDateOfGiveDatePicker.SelectedDate = MainWindow.dateOfGive;
                PassportFirstNameTextBox.Text = MainWindow.firstName;
                PassportSecondNameTextBox.Text = MainWindow.secondName;
                PassportMiddleNameTextBox.Text = MainWindow.middleName;
                PassportDateOfBirthDatePicker.SelectedDate = MainWindow.dateOfBirth;
                PassportLivingPlaceTextBox.Text = MainWindow.livingPlace;
                
                FuncButton.Content = "Изменить";
            }
        }

        private async void FuncButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PassportSeriesTextBox.Text.Length == 4 && PassportNumberTextBox.Text.Length == 6)
                {
                    string genderSelected = "";
                    if (MaleRadio.IsChecked == true)
                        genderSelected = "Муж.";
                    if (FemaleRadio.IsChecked == true)
                        genderSelected = "Жен.";
                    switch (MainWindow.passOperation)
                    {
                        case 1:
                            {
                                try
                                {
                                    Passport passport = new Passport();
                                    passport.PassportSeries = PassportSeriesTextBox.Text;
                                    passport.PassportNumber = PassportNumberTextBox.Text;
                                    passport.PassportWhoGive = PassportWhoGiveTextBox.Text;
                                    passport.PassportDateOfGive = (DateTime)PassportDateOfGiveDatePicker.SelectedDate;
                                    passport.PassportFirstName = PassportFirstNameTextBox.Text;
                                    passport.PassportSecondName = PassportSecondNameTextBox.Text;
                                    passport.PassportMiddleName = PassportMiddleNameTextBox.Text;
                                    passport.PassportGender = genderSelected;
                                    passport.PassportDateOfBirth = (DateTime)PassportDateOfBirthDatePicker.SelectedDate;
                                    passport.PassportLivingPlace = PassportLivingPlaceTextBox.Text;

                                    await passport.Add();
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
                                Passport passport = new Passport();
                                passport.PassportSeries = PassportSeriesTextBox.Text;
                                passport.PassportNumber = PassportNumberTextBox.Text;
                                passport.PassportWhoGive = PassportWhoGiveTextBox.Text;
                                passport.PassportDateOfGive = (DateTime)PassportDateOfGiveDatePicker.SelectedDate;
                                passport.PassportFirstName = PassportFirstNameTextBox.Text;
                                passport.PassportSecondName = PassportSecondNameTextBox.Text;
                                passport.PassportMiddleName = PassportMiddleNameTextBox.Text;
                                passport.PassportGender = genderSelected;
                                passport.PassportDateOfBirth = (DateTime)PassportDateOfBirthDatePicker.SelectedDate;
                                passport.PassportLivingPlace = PassportLivingPlaceTextBox.Text;
                                passport.Id = MainWindow.passToUpdateId;

                                await passport.Update();
                                this.Close();
                                return;
                            }
                    }
                }
                else
                {
                    MessageBox.Show($"Некорректно введены данные пользователя. Повторите попытку.\n" +
                        $"Длина Серии=4\tУ вас Серия={PassportSeriesTextBox.Text.Length}\n" +
                        $"Длина Номера=9\tУ вас Номер={PassportNumberTextBox.Text.Length}");
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные. Повторите попытку.");
            }
        }
    }
}