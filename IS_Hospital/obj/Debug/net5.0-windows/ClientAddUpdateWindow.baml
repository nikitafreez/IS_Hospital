   M S B A M L   `   `   `  ����F  BIS_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:IS_HospitalIS_Hospital  5   	   '    !IS_Hospital.ClientAddUpdateWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   +localclr-namespace:IS_Hospital     5   	   -   5          � Title$  ClientAddUpdateWindow��5   	   $	��450��6'   $	��800��64    � WindowState$ 	Maximized=�5	   	   $��Century Gothic)�6I   $��16(�6e   .��5
   	   �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��1��6"   $��Center=�62   $��Center=�6O   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $/��)Контактная информация��6   .��5      �� .+�5      �� $!��Адрес эл. почты��6    $
��Left=�6:   �� 5      -   5         ��Name$ EmailTextBox��5   "   �� 5      $!��Номер телефона��6    $
��Left=�69   �� 5      -   5        $ PhoneTextBox��5   "   5      5      �� 5      $��Документы��6   $	��200��6.   .��5       �� .+�5!      �� $��Паспорт��6    �� 5"      -   5         ��Name$ PassportComboBox��5"   #   �� 5#      $��ИНН��6    �� 5$      -   5        $ 
InnTextBox��5$   "   �� 5%      $��
СНИЛС��6    �� 5&      -   5        $ SnilsTextBox��5&   "   �� 5'      $��ОМС��6    �� 5(      -   5        $ 
OmsTextBox��5(   "   5)      5*      5+      �� 5,      -   5         ��Name$ 
FuncButton��5,      $��FunctionalButton��6)   $��0, 10q�6D   6p   5-      5.      5/      