   M S B A M L   `   `   `  ����F  BIS_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:IS_HospitalIS_Hospital  5   	       IS_Hospital.AuthWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:IS_Hospital     5   	     � Title$  Авторизация��5      $	��450��6   $	��800��6"   $��Century Gothic)�6.   ���	#FFF0F0F0 � WindowState$ 	Maximized=�6a    � WindowStartupLocation$ CenterScreen=�6y   $	��300��6�   $	��300��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��4* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��1��6%   $��Center=�62   $��Center=�6O   .+�5      �� $��
Логин��6   $
��Left=�6$   $	��Top=�6@   $��Century Gothic)�6X   $��18(�6t   $��32��6�   $��63��6�   �� 5      -   5         ��Name$ loginBox��5      $
��Left=�6(    �� TextWrapping$
 Wrap=�6D   $	��Top=�6X   $	��192��6p   $��16(�6|   $��22��6�   �� 5      $��Пароль��6   $
��Left=�6%   $	��Top=�6A   $��Century Gothic)�6Y   $��18(�6u   $��32��6�   $��77��6�   �� 5      -   5        $ passwordBox��5      $
��Left=�6+   $
 Wrap=�6G   $	��Top=�6[   $	��192��6s   $��16(�6�   $��22��6�   �� 5      $
��0, 5q�6   .+�5      �� -   5         ��Name$ loginButton��5      $��
Войти��6.   $��Center=�6>   $	��Top=�6[   $��16(�6s   ���	#FF5FD400
���   �$��57��6�   $��24��6�   6�   5      5       5"      5#      