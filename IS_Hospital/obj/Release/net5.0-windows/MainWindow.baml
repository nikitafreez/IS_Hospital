   M S B A M L   `   `   `  ���� F  BIS_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:IS_HospitalIS_Hospital      IS_Hospital.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:IS_Hospital     -     � Title$  Главное окно��$	��450��$	��800�� � WindowState$ 	Maximized=�$��Century Gothic)�.��� .+�o� $��25��$	��Top=�.@�m� $��Файл��.@�m� $��Экспорт��.@�m� -   $��Excel���� m� -   $	��PDF���� m� -   $��
Выйти���� -    ��Name$ 
TabControl��$��0, 25, 0, 0q�.@��� -    ��Name$ UsersTab��$��Пользователи��.���� $��
0, 0, 0, 0q�.@��� -   $ userDataGridTab��$��Пользователи��.��� .+��� $��	10,0,10,0q�$��2��.+��� $��
Логин���� -    ��Name$ loginTextBox��$
��Left=�$	��120��$��0, -5q��� $��Пароль���� -	   $ passwordTextBox��$
��Left=�$	��120��$��0, -5q��� $��Роль���� -
    ��Name$ roleComboBox��$
��Left=�$	��120��$��0, -5q��� $
��Left=� �� Orientation$ 
Horizontal=�$��0, 10q�.+��� -    ��Name$ userAdd��$��Добавить���� -   $ 
userUpdate��$��Изменить��$
��5, 0q��� -   $ 
userDelete��$��Удалить���� -   $ usersUpdate��$��Right=�$��5,0,0,0q�.���� .+��� $��Images/updateIcon.png��$��20���� -   $ userSeachBox��$	��100��$��5,0,0,0q��� -   $ usersSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20��&   System.Windows.Controls.DataGrid  -     Name$ userDataGrid��$��0, 145, 0, 0q�$��2��	   AutoGenerateColumns$	 False��
   
IsReadOnly$

 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$) #Номер пользователя��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ 
Логин�� �� *Login+  $ Пароль�� �� *
Password+  $ Роль�� �� *IdRole+     
Visibility$ 	Collapsed=� �� *Path+ � ContextMenu �� .@�m� -   $��Удалить���� -   $ roleDataGridTab��$��Роли��.��� .+��� $��10, 0q�.+��� $��Название роли���� -   $ roleTextBox��$
��Left=�$	��120���� $
��Left=�$ 
Horizontal=�$
��0, 5q�.+��� -   $ roleAdd��$��Добавить���� -   $ 
roleUpdate��$��Изменить��$
��5, 0q��� -   $ 
roleDelete��$��Удалить���� -   $ rolesUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20���� -   $ roleSeachBox��$	��100��$��5,0,0,0q��� -   $ rolesSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20��  -   $ roleDataGrid��$��0, 75, 0, 0q�$	 False��$

 True��   $ Номер роли�� �� *Id+  $ Название роли�� �� *
RoleName+  $ 	Collapsed=� �� *Path+ �� .@�m� -   $��Удалить���� -   $ OtdelKadrovTab��$��Отдел Кадров��.���� .@��� -   $ passportDataGridTab��$��Паспорта��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -   $ passportAdd��$��Добавить���� -    $ passportUpdate��$��Изменить��$
��5, 0q��� -!   $ passportDelete��$��Удалить���� -"   $ passportsSeachBox��$	��100��$��5,0,0,0q��� -#   $ passportsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -$   $ passportsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -%   $ passportDataGrid��$��0, 40, 0, 0q�$��2��$	 False��$

 True��   $ ID Паспорта�� �� *Id+  $ 
Серия�� �� *PassportSeries+  $ 
Номер�� �� *PassportNumber+  $ 
Выдан�� �� *PassportWhoGive+  $ Дата выдачи�� �� *PassportDateOfGive+  $ Имя�� �� *PassportFirstName+  $ Фамилия�� �� *PassportSecondName+  $ Отчество�� �� *PassportMiddleName+  $ Пол�� �� *PassportGender+  $ Дата рождения�� �� *PassportDateOfBirth+  $! Место прописки�� �� *PassportLivingPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� -&   $��Изменить��m� -'   $��Удалить���� -(   $ departmentsDataGridTab��$��Отделы��.��� .+��� $��	10,0,10,0q�$��2��.+��� $#��Название отдела���� -)   $ departmentName��$
��Left=�$	��120��$��0, -5q��� $.��(Номер телефона отдела���� -*   $ departmentPhone��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -+   $ departmentAdd��$��Добавить���� -,   $ departmentUpdate��$��Изменить��$
��5, 0q��� --   $ departmentDelete��$��Удалить���� -.   $ departmentsSeachBox��$	��100��$��5,0,0,0q��� -/   $ departmentsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -0   $ departmentsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -1   $ departmentsDataGrid��$��0, 100, 0, 0q�$��2��$	 False��$

 True��   $ Номер отдела�� �� *Id+  $ Название�� �� *DepartmentName+  $! Номер телефона�� �� *DepartmentPhoneNumber+ �� .@�m� -2   $��Удалить���� -3   $ positionsDataGridTab��$��Должности��.��� .+��� $��	10,0,10,0q�$��2��.+��� $)��#Название должности���� -4   $ positionNameTextBox��$
��Left=�$	��120��$��0, -5q��� $#��Оклад должности���� -5   $ positionSalaryTextBox��$
��Left=�$	��120��$��0, -5q��� $��
Отдел���� -6   $ departmentComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -7   $ positionAdd��$��Добавить���� -8   $ positionUpdate��$��Изменить��$
��5, 0q��� -9   $ positionDelete��$��Удалить���� -:   $ positionsSeachBox��$	��100��$��5,0,0,0q��� -;   $ positionsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -<   $ positionsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -=   $ positionsDataGrid��$��0, 135, 0, 0q�$��2��$	 False��$

 True��   $# Номер должности�� �� *Id+  $ Название�� �� *PositionName+  $ 
Оклад�� �� *PositionSalary+  $ Отдел ID�� �� *IdDepartment+  $ Отдел NAME�� �� *	DepName+ �� .@�m� ->   $��Удалить���� -?   $ workerDataGridTab��$��Сотрудники��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -@   $ 	workerAdd��$��Добавить���� -A   $ workerUpdate��$��Изменить��$
��5, 0q��� -B   $ workerDelete��$��Удалить���� -C   $ workersSeachBox��$	��100��$��5,0,0,0q��� -D   $ workersSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -E   $ workersUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -F   $ workerDataGrid��$��0, 40, 0, 0q�$��2��$	 False��$

 True������    $ ID сотрудника�� �� *Id+  $ Паспорт�� �� *
IdPassport+  $ Должность�� �� *	PosName+  $ ИНН�� �� *	WorkerInn+  $ 
СНИЛС�� �� *WorkerSnils+  $! Номер телефона�� �� *WorkerPhoneNumber+  $ Эл. почта�� �� *WorkerEmail+  $ Образование�� �� *WorkerEducation+  $ Уч. заведение�� �� *WorkerEducationPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� -G   $��Изменить��m� -H   $��Удалить���� -I   $ cabinetsDataGridTab��$��Кабинеты��.��� .+��� $��	10,0,10,0q�$��2��.+��� $!��Номер кабинета���� -J   $ cabinetNumTextBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -K   $ 
cabinetAdd��$��Добавить���� -L   $ cabinetUpdate��$��Изменить��$
��5, 0q��� -M   $ cabinetDelete��$��Удалить���� -N   $ cabinetsSeachBox��$	��100��$��5,0,0,0q��� -O   $ cabinetsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -P   $ cabinetsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -Q   $ cabinetsDataGrid��$��0, 70, 0, 0q�$��2��$	 False��$

 True��   $ ID кабинета�� �� *Id+  $! Номер кабинета�� �� *
CabinetNum+ �� .@�m� -R   $��Удалить���� -S   $  workerOnCabinetDataGridTab��$.��(Сотрудники в кабинете��.��� .+��� $��	10,0,10,0q�$��2��.+��� $��Сотрудник���� -T   $ workerOnCabinetComboBox��$
��Left=�$	��120��$��0, -5q��� $��Кабинет���� -U   $ cabinetWithWorkerComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -V   $ workerOnCabinetAdd��$��Добавить���� -W   $ workerOnCabinetUpdate��$��Изменить��$
��5, 0q��� -X   $ workerOnCabinetDelete��$��Удалить���� -Y   $ workerOnCabinetsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -Z   $ workerOnCabinetDataGrid��$��0, 110, 0, 0q�$��2��$	 False��$

 True��   $ Сотрудник�� �� *
IdWorker+  $ Кабинет�� �� *	IdCabinet+ �� .@�m� -[   $��Удалить���� -\   $ BuhgalteriaTab��$��Бухгалтерия��.���� .@��� -]   $ salariesDataGridTab��$��Зарплаты��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Размер З/П���� -^   $ SalaryAmountTextBox��$
��Left=�$	��120��$��0, -5q��� $%��Часов отработано���� -_   $ HoursWorkedTextBox��$
��Left=�$	��120��$��0, -5q��� $ Vertical=�.+��� $!��Дата выдачи З/П��(  "System.Windows.Controls.DatePicker  -`     Name$ DateOfGiveDatePicker��$
��Left=�$	��120��$��0, -5q��� $��Премия���� -a   $ PrizeAmountTextBox��$
��Left=�$	��120��$��0, -5q��� $!��ИНН сотрудника���� -b   $ workerINNComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -c   $ 	salaryAdd��$��Добавить���� -d   $ salaryUpdate��$��Изменить��$
��5, 0q��� -e   $ salaryDelete��$��Удалить���� -f   $ salariesUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -g   $ salariesDataGrid��$��0, 140, 0, 0q�$��2��$	 False��$

 True��   $ ID зарплаты�� �� *Id+  $ Размер�� �� *SalaryAmount+  $% Часов отработано�� �� *HoursWorked+  $ Дата Выдачи�� �� *
DateOfGive+  $ Премия�� �� *PrizeAmount+  $! ИНН сотрудника�� �� *WorINN+ �� .@�m� -h   $��Удалить���� -i   $ transactionsDataGridTab��$��Транзакции��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $%��Сумма транзакции���� -j   $ TransactionSumTextBox��$
��Left=�$	��120��$��0, -5q��� $��Описание���� -k   $ TransactionDescTextBox��$
��Left=�$	��120��$��0, -5q��� $#��Дата транзакции��  -l   $ TransactionDatePicker��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -m   $ transactionAdd��$��Добавить���� -n   $ transactionUpdate��$��Изменить��$
��5, 0q��� -o   $ transactionDelete��$��Удалить���� -p   $ transactionsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -q   $ transactionsDataGrid��$��0, 140, 0, 0q�$��2��$	 False��$

 True��   $ ID транзакции�� �� *Id+  $ 
Сумма�� �� *TransactionSum+  $ Описание�� �� *TransactionDescription+  $# Дата транзакции�� �� *TransactionDate+ �� .@�m� -r   $��Удалить���� -s   $ budjetsDataGridTab��$)��#Бюджет организации��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Сумма бюджета���� -t   $ BudjetSumTextBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -u   $ 	budjetAdd��$��Добавить���� -v   $ budjetUpdate��$��Изменить��$
��5, 0q��� -w   $ budjetDelete��$��Удалить���� -x   $ budjetsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -y   $ budjetsDataGrid��$��0, 70, 0, 0q�$��2��$	 False��$

 True��   $ ID бюджета�� �� *Id+  $ Бюджет�� �� *BudgetAmmount+ �� .@�m� -z   $��Удалить���� -{   $ 
ClientsTab��$��Клиенты��.���� .@��� -|   $ passport1DataGridTab��$��Паспорта��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -}   $ passport1Add��$��Добавить���� -~   $ passport1Update��$��Изменить��$
��5, 0q��� -   $ passport1Delete��$��Удалить���� -�   $ passport1sSeachBox��$	��100��$��5,0,0,0q��� -�   $ passport1sSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -�   $ passports1Update��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ passport1DataGrid��$��0, 40, 0, 0q�$��2��$	 False��$

 True��   $ ID Паспорта�� �� *Id+  $ 
Серия�� �� *PassportSeries+  $ 
Номер�� �� *PassportNumber+  $ 
Выдан�� �� *PassportWhoGive+  $ Дата выдачи�� �� *PassportDateOfGive+  $ Имя�� �� *PassportFirstName+  $ Фамилия�� �� *PassportSecondName+  $ Отчество�� �� *PassportMiddleName+  $ Пол�� �� *PassportGender+  $ Дата рождения�� �� *PassportDateOfBirth+  $! Место прописки�� �� *PassportLivingPlace+  $ 	Collapsed=� �� *Path+ �� .@�m� -�   $��Удалить���� -�   $ clientsDataGridTab��$��Клиенты��.��� .+��� $��	10,0,10,0q�$��2��.+�]� $��Stretch=�$��0, 10q�.+��� -�   $ 	clientAdd��$��Добавить���� -�   $ clientUpdate��$��Изменить��$
��5, 0q��� -�   $ clientDelete��$��Удалить���� -�   $ clientsSeachBox��$	��100��$��5,0,0,0q��� -�   $ clientsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -�   $ clientsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ clientsDataGrid��$��0, 40, 0, 0q�$��2��$	 False��$

 True��   $ ID клиента�� �� *Id+  $ Паспорт�� �� *
IdPassport+  $ ИНН�� �� *	ClientInn+  $ 
СНИЛС�� �� *ClientSnils+  $ ОМС�� �� *	ClientOms+  $! Номер телефона�� �� *ClientPhoneNumber+  $ Эл. почта�� �� *ClientEmail+  $ 	Collapsed=� �� *Path+ �� .@�m� -�   $��Изменить��m� -�   $��Удалить���� -�   $ OborudovanieTab��$&�� Мед. оборудование��.���� .@��� -�   $ equipmentsDataGridTab��$��Оборудование��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $/��)Название оборудования���� -�   $ EquipmentNameTextBox��$
��Left=�$	��120��$��0, -5q��� $+��%Срок службы (в годах)���� -�   $! EquipmentServiceLifeTextBox��$
��Left=�$	��120��$��0, -5q��� $ Vertical=�.+��� $;��5Дата введения в эксплуатацию��  -�   $  EquipmentStartupDatePicker��$
��Left=�$	��120��$��0, -5q��� $��Стоимость���� -�   $ EquipmentCostTextBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -�   $ equipmentAdd��$��Добавить���� -�   $ equipmentUpdate��$��Изменить��$
��5, 0q��� -�   $ equipmentDelete��$��Удалить���� -�   $ equipmentsSeachBox��$	��100��$��5,0,0,0q��� -�   $ equipmentsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -�   $ equipmentsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ equipmentsDataGrid��$��0, 110, 0, 0q�$��2��$	 False��$

 True��   $! ID оборудования�� �� *Id+  $ Название�� �� *EquipmentName+  $ Дата ввода�� �� *EquipmentStartupDate+  $' !Срок эксплуатации�� �� *EquipmentServiceLife+  $ Стоимость�� �� *EquipmentCost+ �� .@�m� -�   $��Удалить���� -�   $# equipmentOnCabinetDataGridTab��$2��,Оборудование в кабинете��.��� .+��� $��	10,0,10,0q�$��2��.+��� $��Оборудование���� -�   $  equipmentOnCabinetComboBox��$
��Left=�$	��120��$��0, -5q��� $��Кабинет���� -�   $" cabinetWithEquipmentComboBox��$
��Left=�$	��120��$��0, -5q��� $��Кол-во���� -�   $% EquipmentOnCabinetAmountTextBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -�   $ equipmentOnCabinetAdd��$��Добавить���� -�   $ equipmentOnCabinetUpdate��$��Изменить��$
��5, 0q��� -�   $ equipmentOnCabinetDelete��$��Удалить���� -�   $ equipmentOnCabinetsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $  equipmentOnCabinetDataGrid��$��0, 135, 0, 0q�$��2��$	 False��$

 True��   $  Обороудование�� �� *IdEquipment+  $ Кабинет�� �� *	IdCabinet+  $ Кол-во�� �� *EquipmentNum+ �� .@�m� -�   $��Удалить���� -�   $ 	UslugiTab��$��Мед. услуги��.���� .@��� -�   $ servicesDataGridTab��$��Список услуг��.��� .+��� $��	10,0,10,0q�$��2��.+��� $#��Название услуги���� -�   $ serviceNameTextBox��$
��Left=�$	��120��$��0, -5q��� $%��Стоимость услуги���� -�   $ serviceCostTextBox��$
��Left=�$	��120��$��0, -5q��� $)��#Ответственный врач���� -�   $ serviceWorkerComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -�   $ 
serviceAdd��$��Добавить���� -�   $ serviceUpdate��$��Изменить��$
��5, 0q��� -�   $ serviceDelete��$��Удалить���� -�   $ servicesSeachBox��$	��100��$��5,0,0,0q��� -�   $ servicesSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -�   $ servicesUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ servicesDataGrid��$��0, 135, 0, 0q�$��2��$	 False��$

 True��   $ ID Услуги�� �� *Id+  $ Название�� �� *ServiceTitle+  $ Стоимость�� �� *ServiceCost+  $) #Ответственный врач�� �� *	WorName+ �� .@�m� -�   $��Удалить���� -�   $ treatmentsDataGridTab��$��Лечение��.��� .+��� $��	10,0,10,0q�$��2��.+��� $ 
Horizontal=�.+��� $ Vertical=�.+��� $��Сумма лечения���� -�   $ TreatmentSumTextBox��$
��Left=�$	��120��$��0, -5q��� $��Заключение���� -�   $ TreatmentReasonTextBox��$
��Left=�$	��120��$��0, -5q��� $ Vertical=�.+��� $��Дата лечения��  -�   $ TreatmentsDatePicker��$
��Left=�$	��120��$��0, -5q��� $��Пациент���� -�   $ TreatmentPatientComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -�   $ treatmentAdd��$��Добавить���� -�   $ treatmentUpdate��$��Изменить��$
��5, 0q��� -�   $ treatmentDelete��$��Удалить���� -�   $ treatmentsSeachBox��$	��100��$��5,0,0,0q��� -�   $ treatmentsSearchButton��$��Right=�$��5,0,0,0q�.���� .+��� $��/Images/searchIcon.png��$��20���� -�   $ treatmentsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ treatmentsDataGrid��$��0, 110, 0, 0q�$��2��$	 False��$

 True��   $ ID лечения�� �� *Id+  $ ID клиента�� �� *
IdClient+  $ Сумма лечения�� �� *TreatmentSum+  $ Заключение�� �� *TreatmentReason+  $ Дата лечения�� �� *TreatmentDate+ �� .@�m� -�   $��Удалить���� -�   $ servicesListDataGridTab��$<��6Список услуг во время лечения��.��� .+��� $��	10,0,10,0q�$��2��.+��� $��Лечение���� -�   $ serviceTreatmentComboBox��$
��Left=�$	��120��$��0, -5q��� $��Услуга���� -�   $ servicesListComboBox��$
��Left=�$	��120��$��0, -5q�]� $��Stretch=�$��0, 10q�.+��� -�   $ servicesListAdd��$��Добавить���� -�   $ servicesListUpdate��$��Изменить��$
��5, 0q��� -�   $ servicesListDelete��$��Удалить���� -�   $ servicesListsUpdate��$��Right=�.���� .+��� $��Images/updateIcon.png��$��20��  -�   $ servicesListDataGrid��$��0, 110, 0, 0q�$��2��$	 False��$

 True��   $ Лечение�� �� *IdTreatment+  $ Услуга�� �� *	IdService+ �� .@�m� -�   $��Удалить��