   M S B A M L   `   `   `  ���� F  BIS_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:IS_HospitalIS_Hospital  )    #IS_Hospital.PassportAddUpdateWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:IS_Hospital     -     � Title$  PassportAddUpdateWindow��$	��450��$	��800�� � WindowState$ 	Maximized=�$��Century Gothic)�$��16(�.���  � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��1��$��1��$��Center=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+��� $��Пасспорт��.���� .+��� $#��Серия пасспорта��$
��Left=��� -    ��Name$ PassportSeriesTextBox���� $#��Номер пасспорта��$
��Left=��� -   $ PassportNumberTextBox���� $��Кем выдан���� -   $ PassportWhoGiveTextBox�� �� MaxLines$ 4�� �� TextWrapping$
 Wrap=�$	��160���� $��Дата выдачи��(  "System.Windows.Controls.DatePicker  -     Name$" PassportDateOfGiveDatePicker���� $%��Место жительства���� -   $  PassportLivingPlaceTextBox��$ 4��$
 Wrap=�$	��160���� $#��Данные человека��.���� .+��� $��Фамилия���� -   $ PassportFirstNameTextBox���� $��Имя���� -   $ PassportSecondNameTextBox���� $��Отчество���� -	   $ PassportMiddleNameTextBox���� $��0,5,0,0q��� $��Пол���� $ Vertical=�.+�	� -
   	 	�Name$	 	MaleRadio��
 	� 	GroupName$
 Gender��$��Мужской��	� -   $	 FemaleRadio��$
 Gender��$��Женский���� $��0,5,0,0q��� $��Дата рождения��  -   $# PassportDateOfBirthDatePicker���� -    ��Name$ 
FuncButton��$��FunctionalButton��$��0, 10q�