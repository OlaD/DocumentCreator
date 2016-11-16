namespace DC
{
				partial class MainWindow
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
												this.addressGroupBox = new System.Windows.Forms.GroupBox();
												this.flatNumberLabel = new System.Windows.Forms.Label();
												this.houseNumberLabel = new System.Windows.Forms.Label();
												this.streetLabel = new System.Windows.Forms.Label();
												this.cityLabel = new System.Windows.Forms.Label();
												this.postCodeLabel = new System.Windows.Forms.Label();
												this.flatNumber = new System.Windows.Forms.TextBox();
												this.street = new System.Windows.Forms.TextBox();
												this.houseNumber = new System.Windows.Forms.TextBox();
												this.city = new System.Windows.Forms.TextBox();
												this.postCode = new System.Windows.Forms.TextBox();
												this.surnameLabel = new System.Windows.Forms.Label();
												this.nameLabel = new System.Windows.Forms.Label();
												this.surname = new System.Windows.Forms.TextBox();
												this.name = new System.Windows.Forms.TextBox();
												this.education = new System.Windows.Forms.TabPage();
												this.titlesGroupBox = new System.Windows.Forms.GroupBox();
												this.editTitle = new System.Windows.Forms.Button();
												this.removeTitle = new System.Windows.Forms.Button();
												this.addTitle = new System.Windows.Forms.Button();
												this.titlesTable = new System.Windows.Forms.ListView();
												this.titleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.titleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.titleObtainingYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.academyGroupBox = new System.Windows.Forms.GroupBox();
												this.facultyName = new System.Windows.Forms.TextBox();
												this.academyName = new System.Windows.Forms.TextBox();
												this.academyNameLabel = new System.Windows.Forms.Label();
												this.facultyNameLabel = new System.Windows.Forms.Label();
												this.jobs = new System.Windows.Forms.TabPage();
												this.exJobsTable = new System.Windows.Forms.ListView();
												this.exJobPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobStartYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.exJobEndYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
												this.removeExJob = new System.Windows.Forms.Button();
												this.editExJob = new System.Windows.Forms.Button();
												this.addExJob = new System.Windows.Forms.Button();
												this.achievements = new System.Windows.Forms.TabPage();
												this.achievementsList = new System.Windows.Forms.ListBox();
												this.removeAchievement = new System.Windows.Forms.Button();
												this.editAchievement = new System.Windows.Forms.Button();
												this.addAchievement = new System.Windows.Forms.Button();
												this.employment = new System.Windows.Forms.TabPage();
												this.employmentBaseGroupBox = new System.Windows.Forms.GroupBox();
												this.nominationRadioButton = new System.Windows.Forms.RadioButton();
												this.contractRadioButton = new System.Windows.Forms.RadioButton();
												this.workingTimeGroupBox = new System.Windows.Forms.GroupBox();
												this.workingTime = new System.Windows.Forms.TextBox();
												this.fullWorkingTimeCheckBox = new System.Windows.Forms.CheckBox();
												this.workingTimeLabel = new System.Windows.Forms.Label();
												this.endDateLabel = new System.Windows.Forms.Label();
												this.endDate = new System.Windows.Forms.DateTimePicker();
												this.forPeriodLabel = new System.Windows.Forms.Label();
												this.startDate = new System.Windows.Forms.DateTimePicker();
												this.startDateLabel = new System.Windows.Forms.Label();
												this.positionLabel = new System.Windows.Forms.Label();
												this.forPeriod = new System.Windows.Forms.ComboBox();
												this.position = new System.Windows.Forms.TextBox();
												this.walidateAndSave = new System.Windows.Forms.Button();
												this.loadXml = new System.Windows.Forms.Button();
												this.date = new System.Windows.Forms.DateTimePicker();
												this.dateLabel = new System.Windows.Forms.Label();
												this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
												this.organizationalUnit = new System.Windows.Forms.TextBox();
												this.organizationalUnitLabel = new System.Windows.Forms.Label();
												this.applicationTabControl.SuspendLayout();
												this.candidateData.SuspendLayout();
												this.addressGroupBox.SuspendLayout();
												this.education.SuspendLayout();
												this.titlesGroupBox.SuspendLayout();
												this.academyGroupBox.SuspendLayout();
												this.jobs.SuspendLayout();
												this.achievements.SuspendLayout();
												this.employment.SuspendLayout();
												this.employmentBaseGroupBox.SuspendLayout();
												this.workingTimeGroupBox.SuspendLayout();
												this.SuspendLayout();
												// 
												// applicationTabControl
												// 
												this.applicationTabControl.Controls.Add(this.candidateData);
												this.applicationTabControl.Controls.Add(this.education);
												this.applicationTabControl.Controls.Add(this.jobs);
												this.applicationTabControl.Controls.Add(this.achievements);
												this.applicationTabControl.Controls.Add(this.employment);
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
												this.addressGroupBox.Location = new System.Drawing.Point(12, 86);
												this.addressGroupBox.Name = "addressGroupBox";
												this.addressGroupBox.Size = new System.Drawing.Size(394, 157);
												this.addressGroupBox.TabIndex = 5;
												this.addressGroupBox.TabStop = false;
												this.addressGroupBox.Text = "Adres";
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
												// houseNumberLabel
												// 
												this.houseNumberLabel.AutoSize = true;
												this.houseNumberLabel.Location = new System.Drawing.Point(6, 100);
												this.houseNumberLabel.Name = "houseNumberLabel";
												this.houseNumberLabel.Size = new System.Drawing.Size(50, 13);
												this.houseNumberLabel.TabIndex = 8;
												this.houseNumberLabel.Text = "Nr domu:";
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
												// cityLabel
												// 
												this.cityLabel.AutoSize = true;
												this.cityLabel.Location = new System.Drawing.Point(6, 48);
												this.cityLabel.Name = "cityLabel";
												this.cityLabel.Size = new System.Drawing.Size(71, 13);
												this.cityLabel.TabIndex = 6;
												this.cityLabel.Text = "Miejscowość:";
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
												// flatNumber
												// 
												this.flatNumber.Location = new System.Drawing.Point(89, 123);
												this.flatNumber.Name = "flatNumber";
												this.flatNumber.Size = new System.Drawing.Size(276, 20);
												this.flatNumber.TabIndex = 4;
												// 
												// street
												// 
												this.street.Location = new System.Drawing.Point(89, 71);
												this.street.Name = "street";
												this.street.Size = new System.Drawing.Size(276, 20);
												this.street.TabIndex = 3;
												// 
												// houseNumber
												// 
												this.houseNumber.Location = new System.Drawing.Point(89, 97);
												this.houseNumber.Name = "houseNumber";
												this.houseNumber.Size = new System.Drawing.Size(276, 20);
												this.houseNumber.TabIndex = 2;
												// 
												// city
												// 
												this.city.Location = new System.Drawing.Point(89, 45);
												this.city.Name = "city";
												this.city.Size = new System.Drawing.Size(276, 20);
												this.city.TabIndex = 1;
												// 
												// postCode
												// 
												this.postCode.Location = new System.Drawing.Point(89, 19);
												this.postCode.Name = "postCode";
												this.postCode.Size = new System.Drawing.Size(276, 20);
												this.postCode.TabIndex = 0;
												// 
												// surnameLabel
												// 
												this.surnameLabel.AutoSize = true;
												this.surnameLabel.Location = new System.Drawing.Point(17, 52);
												this.surnameLabel.Name = "surnameLabel";
												this.surnameLabel.Size = new System.Drawing.Size(56, 13);
												this.surnameLabel.TabIndex = 3;
												this.surnameLabel.Text = "Nazwisko:";
												// 
												// nameLabel
												// 
												this.nameLabel.AutoSize = true;
												this.nameLabel.Location = new System.Drawing.Point(18, 26);
												this.nameLabel.Name = "nameLabel";
												this.nameLabel.Size = new System.Drawing.Size(29, 13);
												this.nameLabel.TabIndex = 2;
												this.nameLabel.Text = "Imię:";
												// 
												// surname
												// 
												this.surname.Location = new System.Drawing.Point(100, 49);
												this.surname.Name = "surname";
												this.surname.Size = new System.Drawing.Size(276, 20);
												this.surname.TabIndex = 1;
												// 
												// name
												// 
												this.name.Location = new System.Drawing.Point(100, 23);
												this.name.Name = "name";
												this.name.Size = new System.Drawing.Size(276, 20);
												this.name.TabIndex = 0;
												// 
												// education
												// 
												this.education.Controls.Add(this.titlesGroupBox);
												this.education.Controls.Add(this.academyGroupBox);
												this.education.Location = new System.Drawing.Point(4, 22);
												this.education.Name = "education";
												this.education.Padding = new System.Windows.Forms.Padding(3);
												this.education.Size = new System.Drawing.Size(419, 254);
												this.education.TabIndex = 1;
												this.education.Text = "Wykształcenie";
												this.education.UseVisualStyleBackColor = true;
												// 
												// titlesGroupBox
												// 
												this.titlesGroupBox.Controls.Add(this.editTitle);
												this.titlesGroupBox.Controls.Add(this.removeTitle);
												this.titlesGroupBox.Controls.Add(this.addTitle);
												this.titlesGroupBox.Controls.Add(this.titlesTable);
												this.titlesGroupBox.Location = new System.Drawing.Point(9, 95);
												this.titlesGroupBox.Name = "titlesGroupBox";
												this.titlesGroupBox.Size = new System.Drawing.Size(399, 156);
												this.titlesGroupBox.TabIndex = 4;
												this.titlesGroupBox.TabStop = false;
												this.titlesGroupBox.Text = "Uzyskane stopnie i tytuły";
												// 
												// editTitle
												// 
												this.editTitle.Enabled = false;
												this.editTitle.Location = new System.Drawing.Point(180, 18);
												this.editTitle.Name = "editTitle";
												this.editTitle.Size = new System.Drawing.Size(99, 23);
												this.editTitle.TabIndex = 6;
												this.editTitle.Text = "Edytuj";
												this.editTitle.UseVisualStyleBackColor = true;
												this.editTitle.Click += new System.EventHandler(this.editTitle_Click);
												// 
												// removeTitle
												// 
												this.removeTitle.Enabled = false;
												this.removeTitle.Location = new System.Drawing.Point(285, 18);
												this.removeTitle.Name = "removeTitle";
												this.removeTitle.Size = new System.Drawing.Size(99, 23);
												this.removeTitle.TabIndex = 5;
												this.removeTitle.Text = "Usuń";
												this.removeTitle.UseVisualStyleBackColor = true;
												this.removeTitle.Click += new System.EventHandler(this.removeTitle_Click);
												// 
												// addTitle
												// 
												this.addTitle.Location = new System.Drawing.Point(11, 18);
												this.addTitle.Name = "addTitle";
												this.addTitle.Size = new System.Drawing.Size(163, 23);
												this.addTitle.TabIndex = 4;
												this.addTitle.Text = "Dodaj";
												this.addTitle.UseVisualStyleBackColor = true;
												this.addTitle.Click += new System.EventHandler(this.addTitle_Click);
												// 
												// titlesTable
												// 
												this.titlesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleType,
            this.titleName,
            this.titleObtainingYear});
												this.titlesTable.FullRowSelect = true;
												this.titlesTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
												this.titlesTable.Location = new System.Drawing.Point(11, 47);
												this.titlesTable.MultiSelect = false;
												this.titlesTable.Name = "titlesTable";
												this.titlesTable.Size = new System.Drawing.Size(373, 103);
												this.titlesTable.TabIndex = 3;
												this.titlesTable.UseCompatibleStateImageBehavior = false;
												this.titlesTable.View = System.Windows.Forms.View.Details;
												this.titlesTable.SelectedIndexChanged += new System.EventHandler(this.titlesTable_SelectedIndexChanged);
												// 
												// titleType
												// 
												this.titleType.Text = "Stopień/tytuł";
												this.titleType.Width = 128;
												// 
												// titleName
												// 
												this.titleName.Text = "Nazwa";
												this.titleName.Width = 148;
												// 
												// titleObtainingYear
												// 
												this.titleObtainingYear.Text = "Rok uzyskania";
												this.titleObtainingYear.Width = 82;
												// 
												// academyGroupBox
												// 
												this.academyGroupBox.Controls.Add(this.facultyName);
												this.academyGroupBox.Controls.Add(this.academyName);
												this.academyGroupBox.Controls.Add(this.academyNameLabel);
												this.academyGroupBox.Controls.Add(this.facultyNameLabel);
												this.academyGroupBox.Location = new System.Drawing.Point(6, 6);
												this.academyGroupBox.Name = "academyGroupBox";
												this.academyGroupBox.Size = new System.Drawing.Size(402, 83);
												this.academyGroupBox.TabIndex = 2;
												this.academyGroupBox.TabStop = false;
												this.academyGroupBox.Text = "Ukończona uczelnia";
												// 
												// facultyName
												// 
												this.facultyName.Location = new System.Drawing.Point(102, 52);
												this.facultyName.Name = "facultyName";
												this.facultyName.Size = new System.Drawing.Size(268, 20);
												this.facultyName.TabIndex = 3;
												// 
												// academyName
												// 
												this.academyName.Location = new System.Drawing.Point(102, 26);
												this.academyName.Name = "academyName";
												this.academyName.Size = new System.Drawing.Size(268, 20);
												this.academyName.TabIndex = 2;
												// 
												// academyNameLabel
												// 
												this.academyNameLabel.AutoSize = true;
												this.academyNameLabel.Location = new System.Drawing.Point(6, 29);
												this.academyNameLabel.Name = "academyNameLabel";
												this.academyNameLabel.Size = new System.Drawing.Size(79, 13);
												this.academyNameLabel.TabIndex = 0;
												this.academyNameLabel.Text = "Nazwa uczelni:";
												// 
												// facultyNameLabel
												// 
												this.facultyNameLabel.AutoSize = true;
												this.facultyNameLabel.Location = new System.Drawing.Point(6, 55);
												this.facultyNameLabel.Name = "facultyNameLabel";
												this.facultyNameLabel.Size = new System.Drawing.Size(88, 13);
												this.facultyNameLabel.TabIndex = 1;
												this.facultyNameLabel.Text = "Nazwa wydziału:";
												// 
												// jobs
												// 
												this.jobs.Controls.Add(this.exJobsTable);
												this.jobs.Controls.Add(this.removeExJob);
												this.jobs.Controls.Add(this.editExJob);
												this.jobs.Controls.Add(this.addExJob);
												this.jobs.Location = new System.Drawing.Point(4, 22);
												this.jobs.Name = "jobs";
												this.jobs.Size = new System.Drawing.Size(419, 254);
												this.jobs.TabIndex = 2;
												this.jobs.Text = "Przebieg pracy";
												this.jobs.UseVisualStyleBackColor = true;
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
												this.exJobsTable.SelectedIndexChanged += new System.EventHandler(this.exJobsTable_SelectedIndexChanged);
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
												// removeExJob
												// 
												this.removeExJob.Enabled = false;
												this.removeExJob.Location = new System.Drawing.Point(304, 12);
												this.removeExJob.Name = "removeExJob";
												this.removeExJob.Size = new System.Drawing.Size(99, 23);
												this.removeExJob.TabIndex = 5;
												this.removeExJob.Text = "Usuń";
												this.removeExJob.UseVisualStyleBackColor = true;
												this.removeExJob.Click += new System.EventHandler(this.exJobRemove_Click);
												// 
												// editExJob
												// 
												this.editExJob.Enabled = false;
												this.editExJob.Location = new System.Drawing.Point(199, 12);
												this.editExJob.Name = "editExJob";
												this.editExJob.Size = new System.Drawing.Size(99, 23);
												this.editExJob.TabIndex = 6;
												this.editExJob.Text = "Edytuj";
												this.editExJob.UseVisualStyleBackColor = true;
												this.editExJob.Click += new System.EventHandler(this.exJobEdit_Click);
												// 
												// addExJob
												// 
												this.addExJob.Location = new System.Drawing.Point(9, 12);
												this.addExJob.Name = "addExJob";
												this.addExJob.Size = new System.Drawing.Size(184, 23);
												this.addExJob.TabIndex = 4;
												this.addExJob.Text = "Dodaj";
												this.addExJob.UseVisualStyleBackColor = true;
												this.addExJob.Click += new System.EventHandler(this.exJobAdd_Click);
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
												// achievementsList
												// 
												this.achievementsList.FormattingEnabled = true;
												this.achievementsList.HorizontalScrollbar = true;
												this.achievementsList.Location = new System.Drawing.Point(12, 44);
												this.achievementsList.Name = "achievementsList";
												this.achievementsList.Size = new System.Drawing.Size(394, 199);
												this.achievementsList.TabIndex = 11;
												this.achievementsList.SelectedIndexChanged += new System.EventHandler(this.achievementsList_SelectedIndexChanged);
												// 
												// removeAchievement
												// 
												this.removeAchievement.Enabled = false;
												this.removeAchievement.Location = new System.Drawing.Point(307, 14);
												this.removeAchievement.Name = "removeAchievement";
												this.removeAchievement.Size = new System.Drawing.Size(99, 23);
												this.removeAchievement.TabIndex = 9;
												this.removeAchievement.Text = "Usuń";
												this.removeAchievement.UseVisualStyleBackColor = true;
												this.removeAchievement.Click += new System.EventHandler(this.removeAchievement_Click);
												// 
												// editAchievement
												// 
												this.editAchievement.Enabled = false;
												this.editAchievement.Location = new System.Drawing.Point(202, 14);
												this.editAchievement.Name = "editAchievement";
												this.editAchievement.Size = new System.Drawing.Size(99, 23);
												this.editAchievement.TabIndex = 10;
												this.editAchievement.Text = "Edytuj";
												this.editAchievement.UseVisualStyleBackColor = true;
												this.editAchievement.Click += new System.EventHandler(this.editAchievement_Click);
												// 
												// addAchievement
												// 
												this.addAchievement.Location = new System.Drawing.Point(12, 14);
												this.addAchievement.Name = "addAchievement";
												this.addAchievement.Size = new System.Drawing.Size(184, 23);
												this.addAchievement.TabIndex = 8;
												this.addAchievement.Text = "Dodaj";
												this.addAchievement.UseVisualStyleBackColor = true;
												this.addAchievement.Click += new System.EventHandler(this.addAchievement_Click);
												// 
												// employment
												// 
												this.employment.Controls.Add(this.employmentBaseGroupBox);
												this.employment.Controls.Add(this.workingTimeGroupBox);
												this.employment.Controls.Add(this.endDateLabel);
												this.employment.Controls.Add(this.endDate);
												this.employment.Controls.Add(this.forPeriodLabel);
												this.employment.Controls.Add(this.startDate);
												this.employment.Controls.Add(this.startDateLabel);
												this.employment.Controls.Add(this.positionLabel);
												this.employment.Controls.Add(this.forPeriod);
												this.employment.Controls.Add(this.position);
												this.employment.Location = new System.Drawing.Point(4, 22);
												this.employment.Name = "employment";
												this.employment.Size = new System.Drawing.Size(419, 254);
												this.employment.TabIndex = 4;
												this.employment.Text = "Stanowisko";
												this.employment.UseVisualStyleBackColor = true;
												// 
												// employmentBaseGroupBox
												// 
												this.employmentBaseGroupBox.Controls.Add(this.nominationRadioButton);
												this.employmentBaseGroupBox.Controls.Add(this.contractRadioButton);
												this.employmentBaseGroupBox.Location = new System.Drawing.Point(219, 132);
												this.employmentBaseGroupBox.Name = "employmentBaseGroupBox";
												this.employmentBaseGroupBox.Size = new System.Drawing.Size(190, 100);
												this.employmentBaseGroupBox.TabIndex = 17;
												this.employmentBaseGroupBox.TabStop = false;
												this.employmentBaseGroupBox.Text = "Podstawa zatrudnienia";
												// 
												// nominationRadioButton
												// 
												this.nominationRadioButton.AutoSize = true;
												this.nominationRadioButton.Location = new System.Drawing.Point(16, 29);
												this.nominationRadioButton.Name = "nominationRadioButton";
												this.nominationRadioButton.Size = new System.Drawing.Size(82, 17);
												this.nominationRadioButton.TabIndex = 5;
												this.nominationRadioButton.TabStop = true;
												this.nominationRadioButton.Text = "Mianowanie";
												this.nominationRadioButton.UseVisualStyleBackColor = true;
												// 
												// contractRadioButton
												// 
												this.contractRadioButton.AutoSize = true;
												this.contractRadioButton.Location = new System.Drawing.Point(16, 63);
												this.contractRadioButton.Name = "contractRadioButton";
												this.contractRadioButton.Size = new System.Drawing.Size(100, 17);
												this.contractRadioButton.TabIndex = 6;
												this.contractRadioButton.TabStop = true;
												this.contractRadioButton.Text = "Umowa o pracę";
												this.contractRadioButton.UseVisualStyleBackColor = true;
												// 
												// workingTimeGroupBox
												// 
												this.workingTimeGroupBox.Controls.Add(this.workingTime);
												this.workingTimeGroupBox.Controls.Add(this.fullWorkingTimeCheckBox);
												this.workingTimeGroupBox.Controls.Add(this.workingTimeLabel);
												this.workingTimeGroupBox.Location = new System.Drawing.Point(13, 132);
												this.workingTimeGroupBox.Name = "workingTimeGroupBox";
												this.workingTimeGroupBox.Size = new System.Drawing.Size(190, 100);
												this.workingTimeGroupBox.TabIndex = 16;
												this.workingTimeGroupBox.TabStop = false;
												this.workingTimeGroupBox.Text = "Wymiar zatrudnienia";
												// 
												// workingTime
												// 
												this.workingTime.Location = new System.Drawing.Point(16, 29);
												this.workingTime.Name = "workingTime";
												this.workingTime.Size = new System.Drawing.Size(75, 20);
												this.workingTime.TabIndex = 1;
												// 
												// fullWorkingTimeCheckBox
												// 
												this.fullWorkingTimeCheckBox.AutoSize = true;
												this.fullWorkingTimeCheckBox.Location = new System.Drawing.Point(16, 64);
												this.fullWorkingTimeCheckBox.Name = "fullWorkingTimeCheckBox";
												this.fullWorkingTimeCheckBox.Size = new System.Drawing.Size(75, 17);
												this.fullWorkingTimeCheckBox.TabIndex = 15;
												this.fullWorkingTimeCheckBox.Text = "pełen etat";
												this.fullWorkingTimeCheckBox.UseVisualStyleBackColor = true;
												this.fullWorkingTimeCheckBox.CheckedChanged += new System.EventHandler(this.fullWorkingTimeCheckBox_CheckedChanged);
												// 
												// workingTimeLabel
												// 
												this.workingTimeLabel.AutoSize = true;
												this.workingTimeLabel.Location = new System.Drawing.Point(97, 36);
												this.workingTimeLabel.Name = "workingTimeLabel";
												this.workingTimeLabel.Size = new System.Drawing.Size(31, 13);
												this.workingTimeLabel.TabIndex = 14;
												this.workingTimeLabel.Text = "etatu";
												// 
												// endDateLabel
												// 
												this.endDateLabel.AutoSize = true;
												this.endDateLabel.Location = new System.Drawing.Point(199, 90);
												this.endDateLabel.Name = "endDateLabel";
												this.endDateLabel.Size = new System.Drawing.Size(47, 13);
												this.endDateLabel.TabIndex = 12;
												this.endDateLabel.Text = "Do dnia:";
												// 
												// endDate
												// 
												this.endDate.Location = new System.Drawing.Point(252, 88);
												this.endDate.Name = "endDate";
												this.endDate.Size = new System.Drawing.Size(151, 20);
												this.endDate.TabIndex = 11;
												// 
												// forPeriodLabel
												// 
												this.forPeriodLabel.AutoSize = true;
												this.forPeriodLabel.Location = new System.Drawing.Point(8, 90);
												this.forPeriodLabel.Name = "forPeriodLabel";
												this.forPeriodLabel.Size = new System.Drawing.Size(49, 13);
												this.forPeriodLabel.TabIndex = 10;
												this.forPeriodLabel.Text = "Na czas:";
												// 
												// startDate
												// 
												this.startDate.Location = new System.Drawing.Point(77, 48);
												this.startDate.Name = "startDate";
												this.startDate.Size = new System.Drawing.Size(169, 20);
												this.startDate.TabIndex = 9;
												// 
												// startDateLabel
												// 
												this.startDateLabel.AutoSize = true;
												this.startDateLabel.Location = new System.Drawing.Point(8, 54);
												this.startDateLabel.Name = "startDateLabel";
												this.startDateLabel.Size = new System.Drawing.Size(47, 13);
												this.startDateLabel.TabIndex = 8;
												this.startDateLabel.Text = "Od dnia:";
												// 
												// positionLabel
												// 
												this.positionLabel.AutoSize = true;
												this.positionLabel.Location = new System.Drawing.Point(8, 17);
												this.positionLabel.Name = "positionLabel";
												this.positionLabel.Size = new System.Drawing.Size(65, 13);
												this.positionLabel.TabIndex = 7;
												this.positionLabel.Text = "Stanowisko:";
												// 
												// forPeriod
												// 
												this.forPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.forPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System;
												this.forPeriod.FormattingEnabled = true;
												this.forPeriod.Items.AddRange(new object[] {
            "Określony",
            "Nieokreślony"});
												this.forPeriod.Location = new System.Drawing.Point(77, 87);
												this.forPeriod.Name = "forPeriod";
												this.forPeriod.Size = new System.Drawing.Size(94, 21);
												this.forPeriod.TabIndex = 3;
												this.forPeriod.SelectedIndexChanged += new System.EventHandler(this.forPeriod_SelectedIndexChanged);
												// 
												// position
												// 
												this.position.Location = new System.Drawing.Point(77, 14);
												this.position.Name = "position";
												this.position.Size = new System.Drawing.Size(326, 20);
												this.position.TabIndex = 0;
												// 
												// walidateAndSave
												// 
												this.walidateAndSave.Location = new System.Drawing.Point(228, 326);
												this.walidateAndSave.Name = "walidateAndSave";
												this.walidateAndSave.Size = new System.Drawing.Size(194, 23);
												this.walidateAndSave.TabIndex = 2;
												this.walidateAndSave.Text = "Waliduj i zapisz";
												this.walidateAndSave.UseVisualStyleBackColor = true;
												this.walidateAndSave.Click += new System.EventHandler(this.walidateAndSave_Click);
												// 
												// loadXml
												// 
												this.loadXml.Location = new System.Drawing.Point(28, 326);
												this.loadXml.Name = "loadXml";
												this.loadXml.Size = new System.Drawing.Size(194, 23);
												this.loadXml.TabIndex = 3;
												this.loadXml.Text = "Wczytaj dane z XML";
												this.loadXml.UseVisualStyleBackColor = true;
												this.loadXml.Click += new System.EventHandler(this.loadXml_Click);
												// 
												// date
												// 
												this.date.Location = new System.Drawing.Point(48, 11);
												this.date.Name = "date";
												this.date.Size = new System.Drawing.Size(138, 20);
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
												// openFileDialog
												// 
												this.openFileDialog.FileName = "openFileDialog1";
												// 
												// organizationalUnit
												// 
												this.organizationalUnit.Location = new System.Drawing.Point(322, 11);
												this.organizationalUnit.Name = "organizationalUnit";
												this.organizationalUnit.Size = new System.Drawing.Size(114, 20);
												this.organizationalUnit.TabIndex = 6;
												// 
												// organizationalUnitLabel
												// 
												this.organizationalUnitLabel.AutoSize = true;
												this.organizationalUnitLabel.Location = new System.Drawing.Point(193, 17);
												this.organizationalUnitLabel.Name = "organizationalUnitLabel";
												this.organizationalUnitLabel.Size = new System.Drawing.Size(127, 13);
												this.organizationalUnitLabel.TabIndex = 7;
												this.organizationalUnitLabel.Text = "Jednostka organizacyjna:";
												// 
												// MainWindow
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(448, 357);
												this.Controls.Add(this.organizationalUnitLabel);
												this.Controls.Add(this.organizationalUnit);
												this.Controls.Add(this.dateLabel);
												this.Controls.Add(this.date);
												this.Controls.Add(this.loadXml);
												this.Controls.Add(this.walidateAndSave);
												this.Controls.Add(this.applicationTabControl);
												this.Name = "MainWindow";
												this.Text = "Wniosek";
												this.applicationTabControl.ResumeLayout(false);
												this.candidateData.ResumeLayout(false);
												this.candidateData.PerformLayout();
												this.addressGroupBox.ResumeLayout(false);
												this.addressGroupBox.PerformLayout();
												this.education.ResumeLayout(false);
												this.titlesGroupBox.ResumeLayout(false);
												this.academyGroupBox.ResumeLayout(false);
												this.academyGroupBox.PerformLayout();
												this.jobs.ResumeLayout(false);
												this.achievements.ResumeLayout(false);
												this.employment.ResumeLayout(false);
												this.employment.PerformLayout();
												this.employmentBaseGroupBox.ResumeLayout(false);
												this.employmentBaseGroupBox.PerformLayout();
												this.workingTimeGroupBox.ResumeLayout(false);
												this.workingTimeGroupBox.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.TabControl applicationTabControl;
								private System.Windows.Forms.TabPage candidateData;
								private System.Windows.Forms.TabPage education;
								private System.Windows.Forms.TabPage jobs;
								private System.Windows.Forms.TabPage achievements;
								private System.Windows.Forms.TabPage employment;
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
								private System.Windows.Forms.TextBox facultyName;
								private System.Windows.Forms.TextBox academyName;
								private System.Windows.Forms.Label academyNameLabel;
								private System.Windows.Forms.Label facultyNameLabel;
								private System.Windows.Forms.GroupBox titlesGroupBox;
								private System.Windows.Forms.Button editTitle;
								private System.Windows.Forms.Button removeTitle;
								private System.Windows.Forms.Button addTitle;
								private System.Windows.Forms.ListView titlesTable;
								private System.Windows.Forms.ColumnHeader titleType;
								private System.Windows.Forms.ColumnHeader titleName;
								private System.Windows.Forms.ColumnHeader titleObtainingYear;
								private System.Windows.Forms.ListView exJobsTable;
								private System.Windows.Forms.ColumnHeader exJobPosition;
								private System.Windows.Forms.ColumnHeader exJobPlace;
								private System.Windows.Forms.ColumnHeader exJobStartYear;
								private System.Windows.Forms.ColumnHeader exJobEndYear;
								private System.Windows.Forms.Button removeExJob;
								private System.Windows.Forms.Button editExJob;
								private System.Windows.Forms.Button addExJob;
								private System.Windows.Forms.ListBox achievementsList;
								private System.Windows.Forms.Button removeAchievement;
								private System.Windows.Forms.Button editAchievement;
								private System.Windows.Forms.Button addAchievement;
								private System.Windows.Forms.GroupBox workingTimeGroupBox;
								private System.Windows.Forms.TextBox workingTime;
								private System.Windows.Forms.CheckBox fullWorkingTimeCheckBox;
								private System.Windows.Forms.Label workingTimeLabel;
								private System.Windows.Forms.Label endDateLabel;
								private System.Windows.Forms.DateTimePicker endDate;
								private System.Windows.Forms.Label forPeriodLabel;
								private System.Windows.Forms.DateTimePicker startDate;
								private System.Windows.Forms.Label startDateLabel;
								private System.Windows.Forms.Label positionLabel;
								private System.Windows.Forms.RadioButton contractRadioButton;
								private System.Windows.Forms.RadioButton nominationRadioButton;
								private System.Windows.Forms.ComboBox forPeriod;
								private System.Windows.Forms.TextBox position;
								private System.Windows.Forms.GroupBox employmentBaseGroupBox;
								private System.Windows.Forms.OpenFileDialog openFileDialog;
								private System.Windows.Forms.TextBox organizationalUnit;
								private System.Windows.Forms.Label organizationalUnitLabel;
				}
}

