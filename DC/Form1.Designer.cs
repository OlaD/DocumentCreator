namespace DC
{
				partial class mainWindow
				{
								/// <summary>
								/// Required designer variable.
								/// </summary>
								private System.ComponentModel.IContainer components = null;

								/// <summary>
								/// Clean up any resources being used.
								/// </summary>
								/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
								protected override void Dispose(bool disposing)
								{
												if (disposing && (components != null))
												{
																components.Dispose();
												}
												base.Dispose(disposing);
								}

								#region Windows Form Designer generated code

								/// <summary>
								/// Required method for Designer support - do not modify
								/// the contents of this method with the code editor.
								/// </summary>
								private void InitializeComponent()
								{
												this.applicationTabControl = new System.Windows.Forms.TabControl();
												this.candidateData = new System.Windows.Forms.TabPage();
												this.education = new System.Windows.Forms.TabPage();
												this.jobs = new System.Windows.Forms.TabPage();
												this.achievements = new System.Windows.Forms.TabPage();
												this.position = new System.Windows.Forms.TabPage();
												this.walidateAndSave = new System.Windows.Forms.Button();
												this.loadXml = new System.Windows.Forms.Button();
												this.date = new System.Windows.Forms.DateTimePicker();
												this.dateLabel = new System.Windows.Forms.Label();
												this.name = new System.Windows.Forms.TextBox();
												this.surname = new System.Windows.Forms.TextBox();
												this.nameLabel = new System.Windows.Forms.Label();
												this.surnameLabel = new System.Windows.Forms.Label();
												this.addressGroupBox = new System.Windows.Forms.GroupBox();
												this.postCode = new System.Windows.Forms.TextBox();
												this.city = new System.Windows.Forms.TextBox();
												this.houseNumber = new System.Windows.Forms.TextBox();
												this.street = new System.Windows.Forms.TextBox();
												this.flatNumber = new System.Windows.Forms.TextBox();
												this.postCodeLabel = new System.Windows.Forms.Label();
												this.cityLabel = new System.Windows.Forms.Label();
												this.streetLabel = new System.Windows.Forms.Label();
												this.houseNumberLabel = new System.Windows.Forms.Label();
												this.flatNumberLabel = new System.Windows.Forms.Label();
												this.academyName = new System.Windows.Forms.Label();
												this.facultyName = new System.Windows.Forms.Label();
												this.academyGroupBox = new System.Windows.Forms.GroupBox();
												this.textBox6 = new System.Windows.Forms.TextBox();
												this.textBox7 = new System.Windows.Forms.TextBox();
												this.obtainedDegreesAndTitlesTable = new System.Windows.Forms.ListView();
												this.degreeOrTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.degreeOrTitleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.obtainingYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.obtainedDegreesAndTitlesGroupBox = new System.Windows.Forms.GroupBox();
												this.addDegreeOrTitle = new System.Windows.Forms.Button();
												this.removeDegreeOrTitle = new System.Windows.Forms.Button();
												this.editDegreeOrTitle = new System.Windows.Forms.Button();
												this.exJobEdit = new System.Windows.Forms.Button();
												this.exJobRemove = new System.Windows.Forms.Button();
												this.exJobAdd = new System.Windows.Forms.Button();
												this.exJobsTable = new System.Windows.Forms.ListView();
												this.exJobPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobStartYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobEndYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.removeAchievement = new System.Windows.Forms.Button();
												this.editAchievement = new System.Windows.Forms.Button();
												this.addAchievement = new System.Windows.Forms.Button();
												this.achievementsList = new System.Windows.Forms.ListBox();
												this.textBox1 = new System.Windows.Forms.TextBox();
												this.textBox2 = new System.Windows.Forms.TextBox();
												this.comboBox1 = new System.Windows.Forms.ComboBox();
												this.radioButton1 = new System.Windows.Forms.RadioButton();
												this.radioButton2 = new System.Windows.Forms.RadioButton();
												this.label1 = new System.Windows.Forms.Label();
												this.label2 = new System.Windows.Forms.Label();
												this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
												this.label3 = new System.Windows.Forms.Label();
												this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
												this.label4 = new System.Windows.Forms.Label();
												this.label6 = new System.Windows.Forms.Label();
												this.checkBox1 = new System.Windows.Forms.CheckBox();
												this.groupBox1 = new System.Windows.Forms.GroupBox();
												this.groupBox2 = new System.Windows.Forms.GroupBox();
												this.applicationTabControl.SuspendLayout();
												this.candidateData.SuspendLayout();
												this.education.SuspendLayout();
												this.jobs.SuspendLayout();
												this.achievements.SuspendLayout();
												this.position.SuspendLayout();
												this.addressGroupBox.SuspendLayout();
												this.academyGroupBox.SuspendLayout();
												this.obtainedDegreesAndTitlesGroupBox.SuspendLayout();
												this.groupBox1.SuspendLayout();
												this.groupBox2.SuspendLayout();
												this.SuspendLayout();
												// 
												// applicationTabControl
												// 
												this.applicationTabControl.Controls.Add(this.candidateData);
												this.applicationTabControl.Controls.Add(this.education);
												this.applicationTabControl.Controls.Add(this.jobs);
												this.applicationTabControl.Controls.Add(this.achievements);
												this.applicationTabControl.Controls.Add(this.position);
												this.applicationTabControl.Location = new System.Drawing.Point(12, 41);
												this.applicationTabControl.Name = "applicationTabControl";
												this.applicationTabControl.SelectedIndex = 0;
												this.applicationTabControl.Size = new System.Drawing.Size(427, 280);
												this.applicationTabControl.TabIndex = 0;
												// 
												// candidateData
												// 
												this.candidateData.Controls.Add(this.addressGroupBox);
												this.candidateData.Controls.Add(this.surnameLabel);
												this.candidateData.Controls.Add(this.nameLabel);
												this.candidateData.Controls.Add(this.surname);
												this.candidateData.Controls.Add(this.name);
												this.candidateData.Location = new System.Drawing.Point(4, 22);
												this.candidateData.Name = "candidateData";
												this.candidateData.Padding = new System.Windows.Forms.Padding(3);
												this.candidateData.Size = new System.Drawing.Size(419, 254);
												this.candidateData.TabIndex = 0;
												this.candidateData.Text = "Dane kandydata";
												this.candidateData.UseVisualStyleBackColor = true;
												// 
												// education
												// 
												this.education.Controls.Add(this.obtainedDegreesAndTitlesGroupBox);
												this.education.Controls.Add(this.academyGroupBox);
												this.education.Location = new System.Drawing.Point(4, 22);
												this.education.Name = "education";
												this.education.Padding = new System.Windows.Forms.Padding(3);
												this.education.Size = new System.Drawing.Size(419, 254);
												this.education.TabIndex = 1;
												this.education.Text = "Wykształcenie";
												this.education.UseVisualStyleBackColor = true;
												// 
												// jobs
												// 
												this.jobs.Controls.Add(this.exJobsTable);
												this.jobs.Controls.Add(this.exJobRemove);
												this.jobs.Controls.Add(this.exJobEdit);
												this.jobs.Controls.Add(this.exJobAdd);
												this.jobs.Location = new System.Drawing.Point(4, 22);
												this.jobs.Name = "jobs";
												this.jobs.Size = new System.Drawing.Size(419, 254);
												this.jobs.TabIndex = 2;
												this.jobs.Text = "Przebieg pracy";
												this.jobs.UseVisualStyleBackColor = true;
												// 
												// achievements
												// 
												this.achievements.Controls.Add(this.achievementsList);
												this.achievements.Controls.Add(this.removeAchievement);
												this.achievements.Controls.Add(this.editAchievement);
												this.achievements.Controls.Add(this.addAchievement);
												this.achievements.Location = new System.Drawing.Point(4, 22);
												this.achievements.Name = "achievements";
												this.achievements.Size = new System.Drawing.Size(419, 254);
												this.achievements.TabIndex = 3;
												this.achievements.Text = "Osiągnięcia";
												this.achievements.UseVisualStyleBackColor = true;
												// 
												// position
												// 
												this.position.Controls.Add(this.groupBox2);
												this.position.Controls.Add(this.groupBox1);
												this.position.Controls.Add(this.label4);
												this.position.Controls.Add(this.dateTimePicker2);
												this.position.Controls.Add(this.label3);
												this.position.Controls.Add(this.dateTimePicker1);
												this.position.Controls.Add(this.label2);
												this.position.Controls.Add(this.label1);
												this.position.Controls.Add(this.comboBox1);
												this.position.Controls.Add(this.textBox1);
												this.position.Location = new System.Drawing.Point(4, 22);
												this.position.Name = "position";
												this.position.Size = new System.Drawing.Size(419, 254);
												this.position.TabIndex = 4;
												this.position.Text = "Stanowisko";
												this.position.UseVisualStyleBackColor = true;
												// 
												// walidateAndSave
												// 
												this.walidateAndSave.Location = new System.Drawing.Point(228, 326);
												this.walidateAndSave.Name = "walidateAndSave";
												this.walidateAndSave.Size = new System.Drawing.Size(194, 23);
												this.walidateAndSave.TabIndex = 2;
												this.walidateAndSave.Text = "Waliduj i zapisz";
												this.walidateAndSave.UseVisualStyleBackColor = true;
												// 
												// loadXml
												// 
												this.loadXml.Location = new System.Drawing.Point(28, 326);
												this.loadXml.Name = "loadXml";
												this.loadXml.Size = new System.Drawing.Size(194, 23);
												this.loadXml.TabIndex = 3;
												this.loadXml.Text = "Wczytaj dane z XML";
												this.loadXml.UseVisualStyleBackColor = true;
												// 
												// date
												// 
												this.date.Location = new System.Drawing.Point(72, 12);
												this.date.Name = "date";
												this.date.Size = new System.Drawing.Size(147, 20);
												this.date.TabIndex = 4;
												// 
												// dateLabel
												// 
												this.dateLabel.AutoSize = true;
												this.dateLabel.Location = new System.Drawing.Point(13, 18);
												this.dateLabel.Name = "dateLabel";
												this.dateLabel.Size = new System.Drawing.Size(33, 13);
												this.dateLabel.TabIndex = 5;
												this.dateLabel.Text = "Data:";
												// 
												// name
												// 
												this.name.Location = new System.Drawing.Point(98, 21);
												this.name.Name = "name";
												this.name.Size = new System.Drawing.Size(276, 20);
												this.name.TabIndex = 0;
												// 
												// surname
												// 
												this.surname.Location = new System.Drawing.Point(98, 47);
												this.surname.Name = "surname";
												this.surname.Size = new System.Drawing.Size(276, 20);
												this.surname.TabIndex = 1;
												// 
												// nameLabel
												// 
												this.nameLabel.AutoSize = true;
												this.nameLabel.Location = new System.Drawing.Point(16, 24);
												this.nameLabel.Name = "nameLabel";
												this.nameLabel.Size = new System.Drawing.Size(29, 13);
												this.nameLabel.TabIndex = 2;
												this.nameLabel.Text = "Imię:";
												// 
												// surnameLabel
												// 
												this.surnameLabel.AutoSize = true;
												this.surnameLabel.Location = new System.Drawing.Point(15, 50);
												this.surnameLabel.Name = "surnameLabel";
												this.surnameLabel.Size = new System.Drawing.Size(56, 13);
												this.surnameLabel.TabIndex = 3;
												this.surnameLabel.Text = "Nazwisko:";
												// 
												// addressGroupBox
												// 
												this.addressGroupBox.Controls.Add(this.flatNumberLabel);
												this.addressGroupBox.Controls.Add(this.houseNumberLabel);
												this.addressGroupBox.Controls.Add(this.streetLabel);
												this.addressGroupBox.Controls.Add(this.cityLabel);
												this.addressGroupBox.Controls.Add(this.postCodeLabel);
												this.addressGroupBox.Controls.Add(this.flatNumber);
												this.addressGroupBox.Controls.Add(this.street);
												this.addressGroupBox.Controls.Add(this.houseNumber);
												this.addressGroupBox.Controls.Add(this.city);
												this.addressGroupBox.Controls.Add(this.postCode);
												this.addressGroupBox.Location = new System.Drawing.Point(9, 86);
												this.addressGroupBox.Name = "addressGroupBox";
												this.addressGroupBox.Size = new System.Drawing.Size(379, 157);
												this.addressGroupBox.TabIndex = 5;
												this.addressGroupBox.TabStop = false;
												this.addressGroupBox.Text = "Adres";
												// 
												// postCode
												// 
												this.postCode.Location = new System.Drawing.Point(89, 19);
												this.postCode.Name = "postCode";
												this.postCode.Size = new System.Drawing.Size(276, 20);
												this.postCode.TabIndex = 0;
												// 
												// city
												// 
												this.city.Location = new System.Drawing.Point(89, 45);
												this.city.Name = "city";
												this.city.Size = new System.Drawing.Size(276, 20);
												this.city.TabIndex = 1;
												// 
												// houseNumber
												// 
												this.houseNumber.Location = new System.Drawing.Point(89, 97);
												this.houseNumber.Name = "houseNumber";
												this.houseNumber.Size = new System.Drawing.Size(276, 20);
												this.houseNumber.TabIndex = 2;
												// 
												// street
												// 
												this.street.Location = new System.Drawing.Point(89, 71);
												this.street.Name = "street";
												this.street.Size = new System.Drawing.Size(276, 20);
												this.street.TabIndex = 3;
												// 
												// flatNumber
												// 
												this.flatNumber.Location = new System.Drawing.Point(89, 123);
												this.flatNumber.Name = "flatNumber";
												this.flatNumber.Size = new System.Drawing.Size(276, 20);
												this.flatNumber.TabIndex = 4;
												// 
												// postCodeLabel
												// 
												this.postCodeLabel.AutoSize = true;
												this.postCodeLabel.Location = new System.Drawing.Point(6, 22);
												this.postCodeLabel.Name = "postCodeLabel";
												this.postCodeLabel.Size = new System.Drawing.Size(77, 13);
												this.postCodeLabel.TabIndex = 5;
												this.postCodeLabel.Text = "Kod pocztowy:";
												// 
												// cityLabel
												// 
												this.cityLabel.AutoSize = true;
												this.cityLabel.Location = new System.Drawing.Point(6, 48);
												this.cityLabel.Name = "cityLabel";
												this.cityLabel.Size = new System.Drawing.Size(71, 13);
												this.cityLabel.TabIndex = 6;
												this.cityLabel.Text = "Miejscowość:";
												// 
												// streetLabel
												// 
												this.streetLabel.AutoSize = true;
												this.streetLabel.Location = new System.Drawing.Point(6, 74);
												this.streetLabel.Name = "streetLabel";
												this.streetLabel.Size = new System.Drawing.Size(34, 13);
												this.streetLabel.TabIndex = 7;
												this.streetLabel.Text = "Ulica:";
												// 
												// houseNumberLabel
												// 
												this.houseNumberLabel.AutoSize = true;
												this.houseNumberLabel.Location = new System.Drawing.Point(6, 100);
												this.houseNumberLabel.Name = "houseNumberLabel";
												this.houseNumberLabel.Size = new System.Drawing.Size(50, 13);
												this.houseNumberLabel.TabIndex = 8;
												this.houseNumberLabel.Text = "Nr domu:";
												// 
												// flatNumberLabel
												// 
												this.flatNumberLabel.AutoSize = true;
												this.flatNumberLabel.Location = new System.Drawing.Point(7, 126);
												this.flatNumberLabel.Name = "flatNumberLabel";
												this.flatNumberLabel.Size = new System.Drawing.Size(76, 13);
												this.flatNumberLabel.TabIndex = 9;
												this.flatNumberLabel.Text = "Nr mieszkania:";
												// 
												// academyName
												// 
												this.academyName.AutoSize = true;
												this.academyName.Location = new System.Drawing.Point(6, 29);
												this.academyName.Name = "academyName";
												this.academyName.Size = new System.Drawing.Size(79, 13);
												this.academyName.TabIndex = 0;
												this.academyName.Text = "Nazwa uczelni:";
												// 
												// facultyName
												// 
												this.facultyName.AutoSize = true;
												this.facultyName.Location = new System.Drawing.Point(6, 55);
												this.facultyName.Name = "facultyName";
												this.facultyName.Size = new System.Drawing.Size(88, 13);
												this.facultyName.TabIndex = 1;
												this.facultyName.Text = "Nazwa wydziału:";
												// 
												// academyGroupBox
												// 
												this.academyGroupBox.Controls.Add(this.textBox7);
												this.academyGroupBox.Controls.Add(this.textBox6);
												this.academyGroupBox.Controls.Add(this.academyName);
												this.academyGroupBox.Controls.Add(this.facultyName);
												this.academyGroupBox.Location = new System.Drawing.Point(6, 6);
												this.academyGroupBox.Name = "academyGroupBox";
												this.academyGroupBox.Size = new System.Drawing.Size(402, 83);
												this.academyGroupBox.TabIndex = 2;
												this.academyGroupBox.TabStop = false;
												this.academyGroupBox.Text = "Ukończona uczelnia";
												// 
												// textBox6
												// 
												this.textBox6.Location = new System.Drawing.Point(102, 26);
												this.textBox6.Name = "textBox6";
												this.textBox6.Size = new System.Drawing.Size(268, 20);
												this.textBox6.TabIndex = 2;
												// 
												// textBox7
												// 
												this.textBox7.Location = new System.Drawing.Point(102, 52);
												this.textBox7.Name = "textBox7";
												this.textBox7.Size = new System.Drawing.Size(268, 20);
												this.textBox7.TabIndex = 3;
												// 
												// obtainedDegreesAndTitlesTable
												// 
												this.obtainedDegreesAndTitlesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.degreeOrTitle,
            this.degreeOrTitleName,
            this.obtainingYear});
												this.obtainedDegreesAndTitlesTable.FullRowSelect = true;
												this.obtainedDegreesAndTitlesTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
												this.obtainedDegreesAndTitlesTable.Location = new System.Drawing.Point(11, 47);
												this.obtainedDegreesAndTitlesTable.MultiSelect = false;
												this.obtainedDegreesAndTitlesTable.Name = "obtainedDegreesAndTitlesTable";
												this.obtainedDegreesAndTitlesTable.Size = new System.Drawing.Size(373, 103);
												this.obtainedDegreesAndTitlesTable.TabIndex = 3;
												this.obtainedDegreesAndTitlesTable.UseCompatibleStateImageBehavior = false;
												this.obtainedDegreesAndTitlesTable.View = System.Windows.Forms.View.Details;
												// 
												// degreeOrTitle
												// 
												this.degreeOrTitle.Text = "Stopień/tytuł";
												this.degreeOrTitle.Width = 128;
												// 
												// degreeOrTitleName
												// 
												this.degreeOrTitleName.Text = "Nazwa";
												this.degreeOrTitleName.Width = 148;
												// 
												// obtainingYear
												// 
												this.obtainingYear.Text = "Rok uzyskania";
												this.obtainingYear.Width = 82;
												// 
												// obtainedDegreesAndTitlesGroupBox
												// 
												this.obtainedDegreesAndTitlesGroupBox.Controls.Add(this.editDegreeOrTitle);
												this.obtainedDegreesAndTitlesGroupBox.Controls.Add(this.removeDegreeOrTitle);
												this.obtainedDegreesAndTitlesGroupBox.Controls.Add(this.addDegreeOrTitle);
												this.obtainedDegreesAndTitlesGroupBox.Controls.Add(this.obtainedDegreesAndTitlesTable);
												this.obtainedDegreesAndTitlesGroupBox.Location = new System.Drawing.Point(9, 95);
												this.obtainedDegreesAndTitlesGroupBox.Name = "obtainedDegreesAndTitlesGroupBox";
												this.obtainedDegreesAndTitlesGroupBox.Size = new System.Drawing.Size(399, 156);
												this.obtainedDegreesAndTitlesGroupBox.TabIndex = 4;
												this.obtainedDegreesAndTitlesGroupBox.TabStop = false;
												this.obtainedDegreesAndTitlesGroupBox.Text = "Uzyskane stopnie i tytuły";
												// 
												// addDegreeOrTitle
												// 
												this.addDegreeOrTitle.Location = new System.Drawing.Point(11, 18);
												this.addDegreeOrTitle.Name = "addDegreeOrTitle";
												this.addDegreeOrTitle.Size = new System.Drawing.Size(163, 23);
												this.addDegreeOrTitle.TabIndex = 4;
												this.addDegreeOrTitle.Text = "Dodaj";
												this.addDegreeOrTitle.UseVisualStyleBackColor = true;
												// 
												// removeDegreeOrTitle
												// 
												this.removeDegreeOrTitle.Location = new System.Drawing.Point(285, 18);
												this.removeDegreeOrTitle.Name = "removeDegreeOrTitle";
												this.removeDegreeOrTitle.Size = new System.Drawing.Size(99, 23);
												this.removeDegreeOrTitle.TabIndex = 5;
												this.removeDegreeOrTitle.Text = "Usuń";
												this.removeDegreeOrTitle.UseVisualStyleBackColor = true;
												// 
												// editDegreeOrTitle
												// 
												this.editDegreeOrTitle.Location = new System.Drawing.Point(180, 18);
												this.editDegreeOrTitle.Name = "editDegreeOrTitle";
												this.editDegreeOrTitle.Size = new System.Drawing.Size(99, 23);
												this.editDegreeOrTitle.TabIndex = 6;
												this.editDegreeOrTitle.Text = "Edytuj";
												this.editDegreeOrTitle.UseVisualStyleBackColor = true;
												// 
												// exJobEdit
												// 
												this.exJobEdit.Location = new System.Drawing.Point(199, 12);
												this.exJobEdit.Name = "exJobEdit";
												this.exJobEdit.Size = new System.Drawing.Size(99, 23);
												this.exJobEdit.TabIndex = 6;
												this.exJobEdit.Text = "Edytuj";
												this.exJobEdit.UseVisualStyleBackColor = true;
												// 
												// exJobRemove
												// 
												this.exJobRemove.Location = new System.Drawing.Point(304, 12);
												this.exJobRemove.Name = "exJobRemove";
												this.exJobRemove.Size = new System.Drawing.Size(99, 23);
												this.exJobRemove.TabIndex = 5;
												this.exJobRemove.Text = "Usuń";
												this.exJobRemove.UseVisualStyleBackColor = true;
												// 
												// exJobAdd
												// 
												this.exJobAdd.Location = new System.Drawing.Point(9, 12);
												this.exJobAdd.Name = "exJobAdd";
												this.exJobAdd.Size = new System.Drawing.Size(184, 23);
												this.exJobAdd.TabIndex = 4;
												this.exJobAdd.Text = "Dodaj";
												this.exJobAdd.UseVisualStyleBackColor = true;
												// 
												// exJobsTable
												// 
												this.exJobsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.exJobPosition,
            this.exJobPlace,
            this.exJobStartYear,
            this.exJobEndYear});
												this.exJobsTable.FullRowSelect = true;
												this.exJobsTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
												this.exJobsTable.Location = new System.Drawing.Point(9, 41);
												this.exJobsTable.MultiSelect = false;
												this.exJobsTable.Name = "exJobsTable";
												this.exJobsTable.Size = new System.Drawing.Size(397, 198);
												this.exJobsTable.TabIndex = 3;
												this.exJobsTable.UseCompatibleStateImageBehavior = false;
												this.exJobsTable.View = System.Windows.Forms.View.Details;
												// 
												// exJobPosition
												// 
												this.exJobPosition.Text = "Stanowisko";
												this.exJobPosition.Width = 128;
												// 
												// exJobPlace
												// 
												this.exJobPlace.Text = "Miejsce";
												this.exJobPlace.Width = 136;
												// 
												// exJobStartYear
												// 
												this.exJobStartYear.Text = "od";
												this.exJobStartYear.Width = 43;
												// 
												// exJobEndYear
												// 
												this.exJobEndYear.Text = "do";
												this.exJobEndYear.Width = 41;
												// 
												// removeAchievement
												// 
												this.removeAchievement.Location = new System.Drawing.Point(307, 14);
												this.removeAchievement.Name = "removeAchievement";
												this.removeAchievement.Size = new System.Drawing.Size(99, 23);
												this.removeAchievement.TabIndex = 9;
												this.removeAchievement.Text = "Usuń";
												this.removeAchievement.UseVisualStyleBackColor = true;
												// 
												// editAchievement
												// 
												this.editAchievement.Location = new System.Drawing.Point(202, 14);
												this.editAchievement.Name = "editAchievement";
												this.editAchievement.Size = new System.Drawing.Size(99, 23);
												this.editAchievement.TabIndex = 10;
												this.editAchievement.Text = "Edytuj";
												this.editAchievement.UseVisualStyleBackColor = true;
												// 
												// addAchievement
												// 
												this.addAchievement.Location = new System.Drawing.Point(12, 14);
												this.addAchievement.Name = "addAchievement";
												this.addAchievement.Size = new System.Drawing.Size(184, 23);
												this.addAchievement.TabIndex = 8;
												this.addAchievement.Text = "Dodaj";
												this.addAchievement.UseVisualStyleBackColor = true;
												// 
												// achievementsList
												// 
												this.achievementsList.FormattingEnabled = true;
												this.achievementsList.Location = new System.Drawing.Point(12, 44);
												this.achievementsList.Name = "achievementsList";
												this.achievementsList.Size = new System.Drawing.Size(394, 199);
												this.achievementsList.TabIndex = 11;
												// 
												// textBox1
												// 
												this.textBox1.Location = new System.Drawing.Point(77, 14);
												this.textBox1.Name = "textBox1";
												this.textBox1.Size = new System.Drawing.Size(326, 20);
												this.textBox1.TabIndex = 0;
												// 
												// textBox2
												// 
												this.textBox2.Location = new System.Drawing.Point(16, 29);
												this.textBox2.Name = "textBox2";
												this.textBox2.Size = new System.Drawing.Size(75, 20);
												this.textBox2.TabIndex = 1;
												// 
												// comboBox1
												// 
												this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
												this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
												this.comboBox1.FormattingEnabled = true;
												this.comboBox1.Items.AddRange(new object[] {
            "Określony",
            "Nieokreślony"});
												this.comboBox1.Location = new System.Drawing.Point(77, 87);
												this.comboBox1.Name = "comboBox1";
												this.comboBox1.Size = new System.Drawing.Size(94, 21);
												this.comboBox1.TabIndex = 3;
												// 
												// radioButton1
												// 
												this.radioButton1.AutoSize = true;
												this.radioButton1.Location = new System.Drawing.Point(16, 29);
												this.radioButton1.Name = "radioButton1";
												this.radioButton1.Size = new System.Drawing.Size(82, 17);
												this.radioButton1.TabIndex = 5;
												this.radioButton1.TabStop = true;
												this.radioButton1.Text = "Mianowanie";
												this.radioButton1.UseVisualStyleBackColor = true;
												// 
												// radioButton2
												// 
												this.radioButton2.AutoSize = true;
												this.radioButton2.Location = new System.Drawing.Point(16, 63);
												this.radioButton2.Name = "radioButton2";
												this.radioButton2.Size = new System.Drawing.Size(100, 17);
												this.radioButton2.TabIndex = 6;
												this.radioButton2.TabStop = true;
												this.radioButton2.Text = "Umowa o pracę";
												this.radioButton2.UseVisualStyleBackColor = true;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(8, 17);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(65, 13);
												this.label1.TabIndex = 7;
												this.label1.Text = "Stanowisko:";
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(9, 54);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(47, 13);
												this.label2.TabIndex = 8;
												this.label2.Text = "Od dnia:";
												// 
												// dateTimePicker1
												// 
												this.dateTimePicker1.Location = new System.Drawing.Point(77, 48);
												this.dateTimePicker1.Name = "dateTimePicker1";
												this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
												this.dateTimePicker1.TabIndex = 9;
												// 
												// label3
												// 
												this.label3.AutoSize = true;
												this.label3.Location = new System.Drawing.Point(8, 90);
												this.label3.Name = "label3";
												this.label3.Size = new System.Drawing.Size(49, 13);
												this.label3.TabIndex = 10;
												this.label3.Text = "Na czas:";
												// 
												// dateTimePicker2
												// 
												this.dateTimePicker2.Location = new System.Drawing.Point(252, 88);
												this.dateTimePicker2.Name = "dateTimePicker2";
												this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
												this.dateTimePicker2.TabIndex = 11;
												// 
												// label4
												// 
												this.label4.AutoSize = true;
												this.label4.Location = new System.Drawing.Point(199, 90);
												this.label4.Name = "label4";
												this.label4.Size = new System.Drawing.Size(47, 13);
												this.label4.TabIndex = 12;
												this.label4.Text = "Do dnia:";
												// 
												// label6
												// 
												this.label6.AutoSize = true;
												this.label6.Location = new System.Drawing.Point(97, 36);
												this.label6.Name = "label6";
												this.label6.Size = new System.Drawing.Size(31, 13);
												this.label6.TabIndex = 14;
												this.label6.Text = "etatu";
												// 
												// checkBox1
												// 
												this.checkBox1.AutoSize = true;
												this.checkBox1.Location = new System.Drawing.Point(16, 64);
												this.checkBox1.Name = "checkBox1";
												this.checkBox1.Size = new System.Drawing.Size(75, 17);
												this.checkBox1.TabIndex = 15;
												this.checkBox1.Text = "pełen etat";
												this.checkBox1.UseVisualStyleBackColor = true;
												// 
												// groupBox1
												// 
												this.groupBox1.Controls.Add(this.textBox2);
												this.groupBox1.Controls.Add(this.checkBox1);
												this.groupBox1.Controls.Add(this.label6);
												this.groupBox1.Location = new System.Drawing.Point(13, 132);
												this.groupBox1.Name = "groupBox1";
												this.groupBox1.Size = new System.Drawing.Size(190, 100);
												this.groupBox1.TabIndex = 16;
												this.groupBox1.TabStop = false;
												this.groupBox1.Text = "Wymiar zatrudnienia";
												// 
												// groupBox2
												// 
												this.groupBox2.Controls.Add(this.radioButton1);
												this.groupBox2.Controls.Add(this.radioButton2);
												this.groupBox2.Location = new System.Drawing.Point(219, 132);
												this.groupBox2.Name = "groupBox2";
												this.groupBox2.Size = new System.Drawing.Size(190, 100);
												this.groupBox2.TabIndex = 17;
												this.groupBox2.TabStop = false;
												this.groupBox2.Text = "Podstawa zatrudnienia";
												// 
												// mainWindow
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(448, 357);
												this.Controls.Add(this.dateLabel);
												this.Controls.Add(this.date);
												this.Controls.Add(this.loadXml);
												this.Controls.Add(this.walidateAndSave);
												this.Controls.Add(this.applicationTabControl);
												this.Name = "mainWindow";
												this.Text = "Wniosek";
												this.applicationTabControl.ResumeLayout(false);
												this.candidateData.ResumeLayout(false);
												this.candidateData.PerformLayout();
												this.education.ResumeLayout(false);
												this.jobs.ResumeLayout(false);
												this.achievements.ResumeLayout(false);
												this.position.ResumeLayout(false);
												this.position.PerformLayout();
												this.addressGroupBox.ResumeLayout(false);
												this.addressGroupBox.PerformLayout();
												this.academyGroupBox.ResumeLayout(false);
												this.academyGroupBox.PerformLayout();
												this.obtainedDegreesAndTitlesGroupBox.ResumeLayout(false);
												this.groupBox1.ResumeLayout(false);
												this.groupBox1.PerformLayout();
												this.groupBox2.ResumeLayout(false);
												this.groupBox2.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.TabControl applicationTabControl;
								private System.Windows.Forms.TabPage candidateData;
								private System.Windows.Forms.TabPage education;
								private System.Windows.Forms.TabPage jobs;
								private System.Windows.Forms.TabPage achievements;
								private System.Windows.Forms.TabPage position;
								private System.Windows.Forms.Button walidateAndSave;
								private System.Windows.Forms.Button loadXml;
								private System.Windows.Forms.DateTimePicker date;
								private System.Windows.Forms.Label dateLabel;
								private System.Windows.Forms.Label surnameLabel;
								private System.Windows.Forms.Label nameLabel;
								private System.Windows.Forms.TextBox surname;
								private System.Windows.Forms.TextBox name;
								private System.Windows.Forms.GroupBox addressGroupBox;
								private System.Windows.Forms.Label flatNumberLabel;
								private System.Windows.Forms.Label houseNumberLabel;
								private System.Windows.Forms.Label streetLabel;
								private System.Windows.Forms.Label cityLabel;
								private System.Windows.Forms.Label postCodeLabel;
								private System.Windows.Forms.TextBox flatNumber;
								private System.Windows.Forms.TextBox street;
								private System.Windows.Forms.TextBox houseNumber;
								private System.Windows.Forms.TextBox city;
								private System.Windows.Forms.TextBox postCode;
								private System.Windows.Forms.GroupBox academyGroupBox;
								private System.Windows.Forms.TextBox textBox7;
								private System.Windows.Forms.TextBox textBox6;
								private System.Windows.Forms.Label academyName;
								private System.Windows.Forms.Label facultyName;
								private System.Windows.Forms.GroupBox obtainedDegreesAndTitlesGroupBox;
								private System.Windows.Forms.Button editDegreeOrTitle;
								private System.Windows.Forms.Button removeDegreeOrTitle;
								private System.Windows.Forms.Button addDegreeOrTitle;
								private System.Windows.Forms.ListView obtainedDegreesAndTitlesTable;
								private System.Windows.Forms.ColumnHeader degreeOrTitle;
								private System.Windows.Forms.ColumnHeader degreeOrTitleName;
								private System.Windows.Forms.ColumnHeader obtainingYear;
								private System.Windows.Forms.ListView exJobsTable;
								private System.Windows.Forms.ColumnHeader exJobPosition;
								private System.Windows.Forms.ColumnHeader exJobPlace;
								private System.Windows.Forms.ColumnHeader exJobStartYear;
								private System.Windows.Forms.ColumnHeader exJobEndYear;
								private System.Windows.Forms.Button exJobRemove;
								private System.Windows.Forms.Button exJobEdit;
								private System.Windows.Forms.Button exJobAdd;
								private System.Windows.Forms.ListBox achievementsList;
								private System.Windows.Forms.Button removeAchievement;
								private System.Windows.Forms.Button editAchievement;
								private System.Windows.Forms.Button addAchievement;
								private System.Windows.Forms.GroupBox groupBox1;
								private System.Windows.Forms.TextBox textBox2;
								private System.Windows.Forms.CheckBox checkBox1;
								private System.Windows.Forms.Label label6;
								private System.Windows.Forms.Label label4;
								private System.Windows.Forms.DateTimePicker dateTimePicker2;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.DateTimePicker dateTimePicker1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.RadioButton radioButton2;
								private System.Windows.Forms.RadioButton radioButton1;
								private System.Windows.Forms.ComboBox comboBox1;
								private System.Windows.Forms.TextBox textBox1;
								private System.Windows.Forms.GroupBox groupBox2;
				}
}

