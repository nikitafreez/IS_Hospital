   M S B A M L   `   `   `  ���� L  HIS_Hospital_Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IS_Hospital_AdminIS_Hospital_Admin  "    IS_Hospital_Admin.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:IS_Hospital_Admin     -     � Title$  Админ окно��$	��450��$	��800�� � WindowState$ 	Maximized=�$��Century Gothic)�.��� .+�o� $��25��$	��Top=�.@�m� $��Файл��.@�m� $��Экспорт��.@�m� $
��Word��m� $	��PDF���� m� $��Excel���� m� $��
Выйти��m� $��Справка���� $��0, 25, 0, 0q�.@��� $��Пользователи��.���� $��
0, 0, 0, 0q�.@��� $��Пользователи��.��� .+��� $��	10,0,10,0q�$��2��.+��� $��
Логин���� -    ��Name$ loginTextBox��$
��Left=�$	��120��$��0, -5q��� $��Пароль���� -   $ passwordTextBox��$
��Left=�$	��120��$��0, -5q��� $��Роль���� -    ��Name$ roleComboBox��$
��Left=�$	��120��$��0, -5q��� $
��Left=� �� Orientation$ 
Horizontal=�$��0, 10q�.+��� -    ��Name$ userAdd��$��Добавить���� -   $ 
userUpdate��$��Изменить��$
��5, 0q��� -   $ 
userDelete��$��Удалить��&   System.Windows.Controls.DataGrid  -     Name$ userDataGrid��$��0, 145, 0, 0q�$��2��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$)
 #Номер пользователя��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $
 
Логин�� �� *Login+  $
 Пароль�� �� *
Password+  $
 Роль�� �� *IdRole+     
Visibility$ 	Collapsed=� �� *Path+ � ContextMenu �� .@�m� -	   $��Удалить���� $��Роли��.��� .+��� $��10, 0q�.+��� $��Название роли���� -
   $ roleTextBox��$
��Left=�$	��120���� $
��Left=�$ 
Horizontal=�$
��0, 5q�.+��� -   $ roleAdd��$��Добавить���� -   $ 
roleUpdate��$��Изменить��$
��5, 0q��� -   $ 
roleDelete��$��Удалить��  -   $ roleDataGrid��$��0, 75, 0, 0q�$ False��$
 True��	   $
 Номер роли�� �� *Id+  $
 Название роли�� �� *
RoleName+  $ 	Collapsed=� �� *Path+ �� .@�m� -   $��Удалить���� $��Отдел Кадров��.���� .@��� $��Паспорта��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -   $ passportAdd��$��Добавить���� -   $ passportUpdate��$��Изменить��$
��5, 0q��� -   $ passportDelete��$��Удалить���� -   $ passportsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -   $ passportDataGrid��$��0, 40, 0, 0q�$��2��$ False��$
 True��	   $
 ID Паспорта�� �� *Id+  $
 
Серия�� �� *PassportSeries+  $
 
Номер�� �� *PassportNumber+  $
 
Выдан�� �� *PassportWhoGive+  $
 Дата выдачи�� �� *PassportDateOfGive+  $
 Имя�� �� *PassportFirstName+  $
 Фамилия�� �� *PassportSecondName+  $
 Отчество�� �� *PassportMiddleName+  $
 Пол�� �� *PassportGender+  $
 Дата рождения�� �� *PassportDateOfBirth+  $!
 Место прописки�� �� *PassportLivingPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� -   $��Изменить��m� -   $��Удалить���� $��Отделы��.��� .+��� $��	10,0,10,0q�$��2��.+��� $#��Название отдела���� -   $ departmentName��$
��Left=�$	��120��$��0, -5q��� $.��(Номер телефона отдела���� -   $ departmentPhone��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -   $ departmentAdd��$��Добавить���� -   $ departmentUpdate��$��Изменить��$
��5, 0q��� -   $ departmentDelete��$��Удалить���� -   $ departmentsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -   $ departmentsDataGrid��$��0, 100, 0, 0q�$��2��$ False��$
 True��	   $
 Номер отдела�� �� *Id+  $
 Название�� �� *DepartmentName+  $!
 Номер телефона�� �� *DepartmentPhoneNumber+ �� .@�m� -   $��Удалить���� $��Должности��.��� .+��� $��	10,0,10,0q�$��2��.+��� $)��#Название должности���� -   $ positionNameTextBox��$
��Left=�$	��120��$��0, -5q��� $#��Оклад должности���� -    $ positionSalaryTextBox��$
��Left=�$	��120��$��0, -5q��� $��
Отдел���� -!   $ departmentComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -"   $ positionAdd��$��Добавить���� -#   $ positionUpdate��$��Изменить��$
��5, 0q��� -$   $ positionDelete��$��Удалить���� -%   $ positionsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -&   $ positionsDataGrid��$��0, 135, 0, 0q�$��2��$ False��$
 True��	   $#
 Номер должности�� �� *Id+  $
 Название�� �� *PositionName+  $
 
Оклад�� �� *PositionSalary+  $
 Отдел ID�� �� *IdDepartment+  $
 Отдел NAME�� �� *	DepName+ �� .@�m� -'   $��Удалить���� $��Сотрудники��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -(   $ 	workerAdd��$��Добавить���� -)   $ workerUpdate��$��Изменить��$
��5, 0q��� -*   $ workerDelete��$��Удалить���� -+   $ workersUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -,   $ workerDataGrid��$��0, 40, 0, 0q�$��2��$ False��$
 True������ 	   $
 ID сотрудника�� �� *Id+  $
 Паспорт�� �� *
IdPassport+  $
 Должность�� �� *	PosName+  $
 ИНН�� �� *	WorkerInn+  $
 
СНИЛС�� �� *WorkerSnils+  $!
 Номер телефона�� �� *WorkerPhoneNumber+  $
 Эл. почта�� �� *WorkerEmail+  $
 Образование�� �� *WorkerEducation+  $
 Уч. заведение�� �� *WorkerEducationPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� --   $��Изменить��m� -.   $��Удалить���� $��Бухгалтерия��.���� .@��� $��Зарплаты��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Размер З/П���� -/   $ SalaryAmountTextBox��$
��Left=�$	��120��$��0, -5q��� $%��Часов отработано���� -0   $ HoursWorkedTextBox��$
��Left=�$	��120��$��0, -5q��� $ Vertical=�.+��� $!��Дата выдачи З/П��(  "System.Windows.Controls.DatePicker  -1     Name$ DateOfGiveDatePicker��$
��Left=�$	��120��$��0, -5q��� $��Премия���� -2   $ PrizeAmountTextBox��$
��Left=�$	��120��$��0, -5q��� $!��ИНН сотрудника���� -3   $ workerINNComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -4   $ 	salaryAdd��$��Добавить���� -5   $ salaryUpdate��$��Изменить��$
��5, 0q��� -6   $ salaryDelete��$��Удалить���� -7   $ salariesUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -8   $ salariesDataGrid��$��0, 140, 0, 0q�$��2��$ False��$
 True��	   $
 ID зарплаты�� �� *Id+  $
 Размер�� �� *SalaryAmount+  $%
 Часов отработано�� �� *HoursWorked+  $
 Дата Выдачи�� �� *
DateOfGive+  $
 Премия�� �� *PrizeAmount+  $!
 ИНН сотрудника�� �� *WorINN+ �� .@�m� -9   $��Удалить���� $��Клиенты��.���� .@��� $��Паспорта��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -:   $ passport1Add��$��Добавить���� -;   $ passport1Update��$��Изменить��$
��5, 0q��� -<   $ passport1Delete��$��Удалить���� -=   $ passports1Update��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  ->   $ passport1DataGrid��$��0, 40, 0, 0q�$��2��$ False��$
 True��	   $
 ID Паспорта�� �� *Id+  $
 
Серия�� �� *PassportSeries+  $
 
Номер�� �� *PassportNumber+  $
 
Выдан�� �� *PassportWhoGive+  $
 Дата выдачи�� �� *PassportDateOfGive+  $
 Имя�� �� *PassportFirstName+  $
 Фамилия�� �� *PassportSecondName+  $
 Отчество�� �� *PassportMiddleName+  $
 Пол�� �� *PassportGender+  $
 Дата рождения�� �� *PassportDateOfBirth+  $!
 Место прописки�� �� *PassportLivingPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� -?   $��Удалить���� $��Клиенты��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -@   $ 	clientAdd��$��Добавить���� -A   $ clientUpdate��$��Изменить��$
��5, 0q��� -B   $ clientDelete��$��Удалить���� -C   $ clientsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -D   $ clientsDataGrid��$��0, 40, 0, 0q�$��2��$ False��$
 True��	   $
 ID клиента�� �� *Id+  $
 Паспорт�� �� *
IdPassport+  $
 ИНН�� �� *	ClientInn+  $
 
СНИЛС�� �� *ClientSnils+  $
 ОМС�� �� *	ClientOms+  $!
 Номер телефона�� �� *ClientPhoneNumber+  $
 Эл. почта�� �� *ClientEmail+  $ 	Collapsed=� �� *Path+ �� .@�m� -E   $��Изменить��m� -F   $��Удалить���� $&�� Мед. оборудование��.���� .@��� $��Оборудование��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $/��)Название оборудования���� -G   $ EquipmentNameTextBox��$
��Left=�$	��120��$��0, -5q��� $+��%Срок службы (в годах)���� -H   $! EquipmentServiceLifeTextBox��$
��Left=�$	��120��$��0, -5q��� $ Vertical=�.+��� $;��5Дата введения в эксплуатацию��  -I   $  EquipmentStartupDatePicker��$
��Left=�$	��120��$��0, -5q��� $��Стоимость���� -J   $ EquipmentCostTextBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -K   $ equipmentAdd��$��Добавить���� -L   $ equipmentUpdate��$��Изменить��$
��5, 0q��� -M   $ equipmentDelete��$��Удалить���� -N   $ equipmentsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -O   $ equipmentsDataGrid��$��0, 110, 0, 0q�$��2��$ False��$
 True��	   $!
 ID оборудования�� �� *Id+  $
 Название�� �� *EquipmentName+  $
 Дата ввода�� �� *EquipmentStartupDate+  $'
 !Срок эксплуатации�� �� *EquipmentServiceLife+  $
 Стоимость�� �� *EquipmentCost+ �� .@�m� -P   $��Удалить���� $��Мед. услуги��.���� .@��� $��Список услуг��.��� .+��� $��	10,0,10,0q�$��2��.+��� $#��Название услуги���� -Q   $ serviceNameTextBox��$
��Left=�$	��120��$��0, -5q��� $%��Стоимость услуги���� -R   $ serviceCostTextBox��$
��Left=�$	��120��$��0, -5q��� $)��#Ответственный врач���� -S   $ serviceWorkerComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -T   $ 
serviceAdd��$��Добавить���� -U   $ serviceUpdate��$��Изменить��$
��5, 0q��� -V   $ serviceDelete��$��Удалить���� -W   $ servicesUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -X   $ servicesDataGrid��$��0, 135, 0, 0q�$��2��$ False��$
 True��	   $
 ID Услуги�� �� *Id+  $
 Название�� �� *ServiceTitle+  $
 Стоимость�� �� *ServiceCost+  $)
 #Ответственный врач�� �� *	WorName+ �� .@�m� -Y   $��Удалить��