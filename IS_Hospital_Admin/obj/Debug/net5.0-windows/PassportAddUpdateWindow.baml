   M S B A M L   `   `   `  ����L  HIS_Hospital_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IS_Hospital_AdminIS_Hospital_Admin  5   	   /    )IS_Hospital_Admin.PassportAddUpdateWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   1localclr-namespace:IS_Hospital_Admin     5   	   -   5          � Title$  PassportAddUpdateWindow��5   	   $	��450��6)   $	��800��66    � WindowState$ 	Maximized=�5	   	   $��Century Gothic)�6K   $��16(�6g   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��1��6"   $��Center=�62   $��Center=�6O   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Пасспорт��6   .��5      �� .+�5      �� $#��Серия пасспорта��6    $
��Left=�6:   �� 5      -   5         ��Name$ PassportSeriesTextBox��5   "   �� 5      $#��Номер пасспорта��6    $
��Left=�6:   �� 5      -   5        $ PassportNumberTextBox��5   "   �� 5      $��Кем выдан��6    �� 5      -   5        $ PassportWhoGiveTextBox��5   O    �� MaxLines$ 4��6"    �� TextWrapping$
 Wrap=�6/   $	��160��6C   6O   �� 5      $��Дата выдачи��6    (  "System.Windows.Controls.DatePicker  5       -   5          Name$" PassportDateOfGiveDatePicker��5    %   �� 5!      $%��Место жительства��6    �� 5"      -   5        $  PassportLivingPlaceTextBox��5"   O   $ 4��6"   $
 Wrap=�6/   $	��160��6C   6O   5#      5$      �� 5%      $#��Данные человека��6   .��5&      �� .+�5'      �� $��Фамилия��6    �� 5(      -   5        $ PassportFirstNameTextBox��5(   "   �� 5)      $��Имя��6    �� 5*      -   5        $ PassportSecondNameTextBox��5*   "   �� 5+      $��Отчество��6    �� 5,      -	   5        $ PassportMiddleNameTextBox��5,   "   �� 5-      $��0,5,0,0q�6$   �� 5.      $��Пол��6    �� 5/      $ Vertical=�6%   .+�50      	� -
   5        	 	�Name$	 	MaleRadio��50   O   
 	� 	GroupName$
 Gender��6*   $��Мужской��6=   6O   	� 51      -   5        $	 FemaleRadio��51   O   $
 Gender��6*   $��Женский��6=   6O   52      �� 53      $��0,5,0,0q�6$   �� 54      $��Дата рождения��6      55      -   5        $# PassportDateOfBirthDatePicker��55   %   56      57      58      �� 59      -   5         ��Name$ 
FuncButton��59      $��FunctionalButton��6)   $��0, 10q�6D   6p   5:      5;      5<      