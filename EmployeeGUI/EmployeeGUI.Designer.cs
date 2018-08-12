namespace EmployeeGUI
{
    partial class FrmEmployeeAdd
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
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SSxBottom = new System.Windows.Forms.StatusStrip();
            this.LblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TCxEmployee = new System.Windows.Forms.TabControl();
            this.TPxEmployee = new System.Windows.Forms.TabPage();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblEmployeeDoubleClick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSearch1 = new System.Windows.Forms.Label();
            this.CbxEmployeeType = new System.Windows.Forms.ComboBox();
            this.BtnEmpSearch = new System.Windows.Forms.Button();
            this.LVxEmployees = new System.Windows.Forms.ListView();
            this.ColEmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtXtraProp1 = new System.Windows.Forms.TextBox();
            this.TxtXtraProp2 = new System.Windows.Forms.TextBox();
            this.LblXtraProp1Label = new System.Windows.Forms.Label();
            this.LblXtraProp2Label = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblEmployeeType = new System.Windows.Forms.Label();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.TPxCourses = new System.Windows.Forms.TabPage();
            this.TxtGBxAddCourse = new System.Windows.Forms.GroupBox();
            this.LVxCourses = new System.Windows.Forms.ListView();
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateApproved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRemoveCourse = new System.Windows.Forms.Button();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.TxtDateApproved = new System.Windows.Forms.TextBox();
            this.TxtCredits = new System.Windows.Forms.TextBox();
            this.LblDateApproved = new System.Windows.Forms.Label();
            this.LblCredits = new System.Windows.Forms.Label();
            this.TxtCourseID = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtGrade = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblGrade = new System.Windows.Forms.Label();
            this.LblCourseID = new System.Windows.Forms.Label();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.LblMiddleName = new System.Windows.Forms.Label();
            this.LblActiveEmployee = new System.Windows.Forms.Label();
            this.CkbActiveEmployee = new System.Windows.Forms.CheckBox();
            this.Approved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CkbApproved = new System.Windows.Forms.CheckBox();
            this.TxtStartDate = new System.Windows.Forms.TextBox();
            this.TxtMaritalStatus = new System.Windows.Forms.TextBox();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblMaritalStatus = new System.Windows.Forms.Label();
            this.CkbBenefits = new System.Windows.Forms.CheckBox();
            this.LblBenefits = new System.Windows.Forms.Label();
            this.LblDoubleClick = new System.Windows.Forms.Label();
            this.MnuMain.SuspendLayout();
            this.SSxBottom.SuspendLayout();
            this.TCxEmployee.SuspendLayout();
            this.TPxEmployee.SuspendLayout();
            this.TPxCourses.SuspendLayout();
            this.TxtGBxAddCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuiFile});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(568, 24);
            this.MnuMain.TabIndex = 10;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MnuiFile
            // 
            this.MnuiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuiFileOpen,
            this.MnuiFileSave,
            this.MnuiFileExit});
            this.MnuiFile.Name = "MnuiFile";
            this.MnuiFile.Size = new System.Drawing.Size(37, 20);
            this.MnuiFile.Text = "&File";
            // 
            // MnuiFileOpen
            // 
            this.MnuiFileOpen.Name = "MnuiFileOpen";
            this.MnuiFileOpen.Size = new System.Drawing.Size(103, 22);
            this.MnuiFileOpen.Text = "&Open";
            this.MnuiFileOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MnuiFileSave
            // 
            this.MnuiFileSave.Name = "MnuiFileSave";
            this.MnuiFileSave.Size = new System.Drawing.Size(103, 22);
            this.MnuiFileSave.Text = "&Save";
            this.MnuiFileSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MnuiFileExit
            // 
            this.MnuiFileExit.Name = "MnuiFileExit";
            this.MnuiFileExit.Size = new System.Drawing.Size(103, 22);
            this.MnuiFileExit.Text = "&Exit";
            this.MnuiFileExit.Click += new System.EventHandler(this.MnuiFileExit_Click);
            // 
            // SSxBottom
            // 
            this.SSxBottom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SSxBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatusStrip,
            this.LblStatus});
            this.SSxBottom.Location = new System.Drawing.Point(0, 535);
            this.SSxBottom.Name = "SSxBottom";
            this.SSxBottom.Size = new System.Drawing.Size(568, 22);
            this.SSxBottom.TabIndex = 11;
            this.SSxBottom.Text = "statusStrip1";
            // 
            // LblStatusStrip
            // 
            this.LblStatusStrip.Name = "LblStatusStrip";
            this.LblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 17);
            this.LblStatus.Text = "Ready";
            // 
            // TCxEmployee
            // 
            this.TCxEmployee.Controls.Add(this.TPxEmployee);
            this.TCxEmployee.Controls.Add(this.TPxCourses);
            this.TCxEmployee.Location = new System.Drawing.Point(12, 27);
            this.TCxEmployee.Name = "TCxEmployee";
            this.TCxEmployee.SelectedIndex = 0;
            this.TCxEmployee.Size = new System.Drawing.Size(558, 507);
            this.TCxEmployee.TabIndex = 16;
            // 
            // TPxEmployee
            // 
            this.TPxEmployee.Controls.Add(this.LblBenefits);
            this.TPxEmployee.Controls.Add(this.CkbBenefits);
            this.TPxEmployee.Controls.Add(this.LblStartDate);
            this.TPxEmployee.Controls.Add(this.LblDepartment);
            this.TPxEmployee.Controls.Add(this.LblTitle);
            this.TPxEmployee.Controls.Add(this.LblMaritalStatus);
            this.TPxEmployee.Controls.Add(this.TxtStartDate);
            this.TPxEmployee.Controls.Add(this.TxtMaritalStatus);
            this.TPxEmployee.Controls.Add(this.TxtDepartment);
            this.TPxEmployee.Controls.Add(this.TxtTitle);
            this.TPxEmployee.Controls.Add(this.CkbActiveEmployee);
            this.TPxEmployee.Controls.Add(this.LblActiveEmployee);
            this.TPxEmployee.Controls.Add(this.LblMiddleName);
            this.TPxEmployee.Controls.Add(this.TxtMiddleName);
            this.TPxEmployee.Controls.Add(this.BtnDelete);
            this.TPxEmployee.Controls.Add(this.LblEmployeeDoubleClick);
            this.TPxEmployee.Controls.Add(this.label2);
            this.TPxEmployee.Controls.Add(this.LblSearch1);
            this.TPxEmployee.Controls.Add(this.CbxEmployeeType);
            this.TPxEmployee.Controls.Add(this.BtnEmpSearch);
            this.TPxEmployee.Controls.Add(this.LVxEmployees);
            this.TPxEmployee.Controls.Add(this.TxtXtraProp1);
            this.TPxEmployee.Controls.Add(this.TxtXtraProp2);
            this.TPxEmployee.Controls.Add(this.LblXtraProp1Label);
            this.TPxEmployee.Controls.Add(this.LblXtraProp2Label);
            this.TPxEmployee.Controls.Add(this.BtnCreate);
            this.TPxEmployee.Controls.Add(this.TxtEmpID);
            this.TPxEmployee.Controls.Add(this.TxtLastName);
            this.TPxEmployee.Controls.Add(this.TxtFirstName);
            this.TPxEmployee.Controls.Add(this.LblLastName);
            this.TPxEmployee.Controls.Add(this.LblFirstName);
            this.TPxEmployee.Controls.Add(this.LblEmployeeType);
            this.TPxEmployee.Controls.Add(this.LblEmpID);
            this.TPxEmployee.Location = new System.Drawing.Point(4, 22);
            this.TPxEmployee.Name = "TPxEmployee";
            this.TPxEmployee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPxEmployee.Size = new System.Drawing.Size(550, 481);
            this.TPxEmployee.TabIndex = 0;
            this.TPxEmployee.Text = "Employee";
            this.TPxEmployee.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(119, 363);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 26);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblEmployeeDoubleClick
            // 
            this.LblEmployeeDoubleClick.AutoSize = true;
            this.LblEmployeeDoubleClick.Location = new System.Drawing.Point(260, 446);
            this.LblEmployeeDoubleClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmployeeDoubleClick.Name = "LblEmployeeDoubleClick";
            this.LblEmployeeDoubleClick.Size = new System.Drawing.Size(244, 13);
            this.LblEmployeeDoubleClick.TabIndex = 34;
            this.LblEmployeeDoubleClick.Text = "Double click an employee to load their information.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Leave both emtpy to show all employees";
            // 
            // LblSearch1
            // 
            this.LblSearch1.AutoSize = true;
            this.LblSearch1.Location = new System.Drawing.Point(3, 424);
            this.LblSearch1.Name = "LblSearch1";
            this.LblSearch1.Size = new System.Drawing.Size(205, 13);
            this.LblSearch1.TabIndex = 32;
            this.LblSearch1.Text = "Use Employee ID or Last Name to search ";
            // 
            // CbxEmployeeType
            // 
            this.CbxEmployeeType.AllowDrop = true;
            this.CbxEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEmployeeType.FormattingEnabled = true;
            this.CbxEmployeeType.Items.AddRange(new object[] {
            "SALARY",
            "SALES",
            "HOURLY",
            "CONTRACT"});
            this.CbxEmployeeType.Location = new System.Drawing.Point(104, 12);
            this.CbxEmployeeType.Name = "CbxEmployeeType";
            this.CbxEmployeeType.Size = new System.Drawing.Size(121, 21);
            this.CbxEmployeeType.TabIndex = 0;
            this.CbxEmployeeType.TextChanged += new System.EventHandler(this.CbxEmployeeType_TextChanged);
            // 
            // BtnEmpSearch
            // 
            this.BtnEmpSearch.Location = new System.Drawing.Point(3, 395);
            this.BtnEmpSearch.Name = "BtnEmpSearch";
            this.BtnEmpSearch.Size = new System.Drawing.Size(219, 26);
            this.BtnEmpSearch.TabIndex = 15;
            this.BtnEmpSearch.Text = "Search";
            this.BtnEmpSearch.UseVisualStyleBackColor = true;
            this.BtnEmpSearch.Click += new System.EventHandler(this.BtnEmpSearch_Click);
            // 
            // LVxEmployees
            // 
            this.LVxEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColEmployeeID,
            this.ColLastName,
            this.ColFirstName});
            this.LVxEmployees.FullRowSelect = true;
            this.LVxEmployees.GridLines = true;
            this.LVxEmployees.Location = new System.Drawing.Point(242, 12);
            this.LVxEmployees.Name = "LVxEmployees";
            this.LVxEmployees.Size = new System.Drawing.Size(285, 431);
            this.LVxEmployees.TabIndex = 29;
            this.LVxEmployees.UseCompatibleStateImageBehavior = false;
            this.LVxEmployees.View = System.Windows.Forms.View.Details;
            this.LVxEmployees.DoubleClick += new System.EventHandler(this.LVxEmployees_SelectedIndexChanged);
            // 
            // ColEmployeeID
            // 
            this.ColEmployeeID.Text = "ID";
            this.ColEmployeeID.Width = 80;
            // 
            // ColLastName
            // 
            this.ColLastName.Text = "Last Name";
            this.ColLastName.Width = 100;
            // 
            // ColFirstName
            // 
            this.ColFirstName.Text = "First Name";
            this.ColFirstName.Width = 100;
            // 
            // TxtXtraProp1
            // 
            this.TxtXtraProp1.Location = new System.Drawing.Point(104, 263);
            this.TxtXtraProp1.Name = "TxtXtraProp1";
            this.TxtXtraProp1.Size = new System.Drawing.Size(121, 20);
            this.TxtXtraProp1.TabIndex = 9;
            this.TxtXtraProp1.Visible = false;
            // 
            // TxtXtraProp2
            // 
            this.TxtXtraProp2.Location = new System.Drawing.Point(104, 291);
            this.TxtXtraProp2.Name = "TxtXtraProp2";
            this.TxtXtraProp2.Size = new System.Drawing.Size(121, 20);
            this.TxtXtraProp2.TabIndex = 10;
            this.TxtXtraProp2.Visible = false;
            // 
            // LblXtraProp1Label
            // 
            this.LblXtraProp1Label.AutoSize = true;
            this.LblXtraProp1Label.Location = new System.Drawing.Point(17, 266);
            this.LblXtraProp1Label.Name = "LblXtraProp1Label";
            this.LblXtraProp1Label.Size = new System.Drawing.Size(80, 13);
            this.LblXtraProp1Label.TabIndex = 27;
            this.LblXtraProp1Label.Text = "XtraProp1Label";
            this.LblXtraProp1Label.Visible = false;
            // 
            // LblXtraProp2Label
            // 
            this.LblXtraProp2Label.AutoSize = true;
            this.LblXtraProp2Label.Location = new System.Drawing.Point(17, 294);
            this.LblXtraProp2Label.Name = "LblXtraProp2Label";
            this.LblXtraProp2Label.Size = new System.Drawing.Size(80, 13);
            this.LblXtraProp2Label.TabIndex = 26;
            this.LblXtraProp2Label.Text = "XtraProp2Label";
            this.LblXtraProp2Label.Visible = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(6, 363);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(103, 26);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "Save";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Location = new System.Drawing.Point(104, 41);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(121, 20);
            this.TxtEmpID.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(104, 69);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(121, 20);
            this.TxtLastName.TabIndex = 2;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(104, 97);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(121, 20);
            this.TxtFirstName.TabIndex = 3;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(39, 72);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(58, 13);
            this.LblLastName.TabIndex = 22;
            this.LblLastName.Text = "Last Name";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(40, 100);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 20;
            this.LblFirstName.Text = "First Name";
            // 
            // LblEmployeeType
            // 
            this.LblEmployeeType.AutoSize = true;
            this.LblEmployeeType.Location = new System.Drawing.Point(17, 15);
            this.LblEmployeeType.Name = "LblEmployeeType";
            this.LblEmployeeType.Size = new System.Drawing.Size(80, 13);
            this.LblEmployeeType.TabIndex = 18;
            this.LblEmployeeType.Text = "Employee Type";
            // 
            // LblEmpID
            // 
            this.LblEmpID.AutoSize = true;
            this.LblEmpID.Location = new System.Drawing.Point(30, 44);
            this.LblEmpID.Name = "LblEmpID";
            this.LblEmpID.Size = new System.Drawing.Size(67, 13);
            this.LblEmpID.TabIndex = 16;
            this.LblEmpID.Text = "Employee ID";
            // 
            // TPxCourses
            // 
            this.TPxCourses.Controls.Add(this.TxtGBxAddCourse);
            this.TPxCourses.Location = new System.Drawing.Point(4, 22);
            this.TPxCourses.Name = "TPxCourses";
            this.TPxCourses.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPxCourses.Size = new System.Drawing.Size(550, 481);
            this.TPxCourses.TabIndex = 1;
            this.TPxCourses.Text = "Courses";
            this.TPxCourses.UseVisualStyleBackColor = true;
            // 
            // TxtGBxAddCourse
            // 
            this.TxtGBxAddCourse.Controls.Add(this.LblDoubleClick);
            this.TxtGBxAddCourse.Controls.Add(this.CkbApproved);
            this.TxtGBxAddCourse.Controls.Add(this.LVxCourses);
            this.TxtGBxAddCourse.Controls.Add(this.BtnRemoveCourse);
            this.TxtGBxAddCourse.Controls.Add(this.BtnAddCourse);
            this.TxtGBxAddCourse.Controls.Add(this.TxtDateApproved);
            this.TxtGBxAddCourse.Controls.Add(this.TxtCredits);
            this.TxtGBxAddCourse.Controls.Add(this.LblDateApproved);
            this.TxtGBxAddCourse.Controls.Add(this.LblCredits);
            this.TxtGBxAddCourse.Controls.Add(this.TxtCourseID);
            this.TxtGBxAddCourse.Controls.Add(this.TxtDescription);
            this.TxtGBxAddCourse.Controls.Add(this.TxtGrade);
            this.TxtGBxAddCourse.Controls.Add(this.LblDescription);
            this.TxtGBxAddCourse.Controls.Add(this.LblGrade);
            this.TxtGBxAddCourse.Controls.Add(this.LblCourseID);
            this.TxtGBxAddCourse.Location = new System.Drawing.Point(6, 6);
            this.TxtGBxAddCourse.Name = "TxtGBxAddCourse";
            this.TxtGBxAddCourse.Size = new System.Drawing.Size(545, 239);
            this.TxtGBxAddCourse.TabIndex = 16;
            this.TxtGBxAddCourse.TabStop = false;
            this.TxtGBxAddCourse.Text = "Add Courses";
            // 
            // LVxCourses
            // 
            this.LVxCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID,
            this.Description,
            this.Grade,
            this.DateApproved,
            this.Credits,
            this.Approved});
            this.LVxCourses.FullRowSelect = true;
            this.LVxCourses.GridLines = true;
            this.LVxCourses.Location = new System.Drawing.Point(210, 19);
            this.LVxCourses.Name = "LVxCourses";
            this.LVxCourses.Size = new System.Drawing.Size(305, 188);
            this.LVxCourses.TabIndex = 25;
            this.LVxCourses.UseCompatibleStateImageBehavior = false;
            this.LVxCourses.View = System.Windows.Forms.View.Details;
            this.LVxCourses.DoubleClick += new System.EventHandler(this.LVxCourses_SelectedIndexChanged);
            // 
            // CourseID
            // 
            this.CourseID.Text = "CourseID";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            // 
            // DateApproved
            // 
            this.DateApproved.Text = "DateApproved";
            // 
            // Credits
            // 
            this.Credits.Text = "Credits";
            // 
            // BtnRemoveCourse
            // 
            this.BtnRemoveCourse.Location = new System.Drawing.Point(104, 179);
            this.BtnRemoveCourse.Name = "BtnRemoveCourse";
            this.BtnRemoveCourse.Size = new System.Drawing.Size(100, 28);
            this.BtnRemoveCourse.TabIndex = 7;
            this.BtnRemoveCourse.Text = "Remove Course";
            this.BtnRemoveCourse.UseVisualStyleBackColor = true;
            this.BtnRemoveCourse.Click += new System.EventHandler(this.BtnRemoveCourse_Click);
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.Location = new System.Drawing.Point(6, 179);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(88, 28);
            this.BtnAddCourse.TabIndex = 6;
            this.BtnAddCourse.Text = "Save Course";
            this.BtnAddCourse.UseVisualStyleBackColor = true;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // TxtDateApproved
            // 
            this.TxtDateApproved.Location = new System.Drawing.Point(104, 99);
            this.TxtDateApproved.Name = "TxtDateApproved";
            this.TxtDateApproved.Size = new System.Drawing.Size(100, 20);
            this.TxtDateApproved.TabIndex = 3;
            // 
            // TxtCredits
            // 
            this.TxtCredits.Location = new System.Drawing.Point(104, 125);
            this.TxtCredits.Name = "TxtCredits";
            this.TxtCredits.Size = new System.Drawing.Size(100, 20);
            this.TxtCredits.TabIndex = 4;
            // 
            // LblDateApproved
            // 
            this.LblDateApproved.AutoSize = true;
            this.LblDateApproved.Location = new System.Drawing.Point(19, 102);
            this.LblDateApproved.Name = "LblDateApproved";
            this.LblDateApproved.Size = new System.Drawing.Size(79, 13);
            this.LblDateApproved.TabIndex = 23;
            this.LblDateApproved.Text = "Date Approved";
            // 
            // LblCredits
            // 
            this.LblCredits.AutoSize = true;
            this.LblCredits.Location = new System.Drawing.Point(59, 125);
            this.LblCredits.Name = "LblCredits";
            this.LblCredits.Size = new System.Drawing.Size(39, 13);
            this.LblCredits.TabIndex = 22;
            this.LblCredits.Text = "Credits";
            // 
            // TxtCourseID
            // 
            this.TxtCourseID.Location = new System.Drawing.Point(104, 21);
            this.TxtCourseID.Name = "TxtCourseID";
            this.TxtCourseID.Size = new System.Drawing.Size(100, 20);
            this.TxtCourseID.TabIndex = 0;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(104, 47);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 1;
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(104, 73);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(100, 20);
            this.TxtGrade.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(38, 50);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 19;
            this.LblDescription.Text = "Description";
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Location = new System.Drawing.Point(62, 76);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(36, 13);
            this.LblGrade.TabIndex = 17;
            this.LblGrade.Text = "Grade";
            // 
            // LblCourseID
            // 
            this.LblCourseID.AutoSize = true;
            this.LblCourseID.Location = new System.Drawing.Point(44, 28);
            this.LblCourseID.Name = "LblCourseID";
            this.LblCourseID.Size = new System.Drawing.Size(54, 13);
            this.LblCourseID.TabIndex = 14;
            this.LblCourseID.Text = "Course ID";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.Location = new System.Drawing.Point(104, 125);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(121, 20);
            this.TxtMiddleName.TabIndex = 4;
            // 
            // LblMiddleName
            // 
            this.LblMiddleName.AutoSize = true;
            this.LblMiddleName.Location = new System.Drawing.Point(28, 128);
            this.LblMiddleName.Name = "LblMiddleName";
            this.LblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.LblMiddleName.TabIndex = 37;
            this.LblMiddleName.Text = "Middle Name";
            // 
            // LblActiveEmployee
            // 
            this.LblActiveEmployee.AutoSize = true;
            this.LblActiveEmployee.Location = new System.Drawing.Point(11, 341);
            this.LblActiveEmployee.Name = "LblActiveEmployee";
            this.LblActiveEmployee.Size = new System.Drawing.Size(86, 13);
            this.LblActiveEmployee.TabIndex = 38;
            this.LblActiveEmployee.Text = "Active Employee";
            // 
            // CkbActiveEmployee
            // 
            this.CkbActiveEmployee.AutoSize = true;
            this.CkbActiveEmployee.Checked = true;
            this.CkbActiveEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbActiveEmployee.Location = new System.Drawing.Point(103, 340);
            this.CkbActiveEmployee.Name = "CkbActiveEmployee";
            this.CkbActiveEmployee.Size = new System.Drawing.Size(122, 17);
            this.CkbActiveEmployee.TabIndex = 12;
            this.CkbActiveEmployee.Text = "(Currently Employed)";
            this.CkbActiveEmployee.UseVisualStyleBackColor = true;
            // 
            // Approved
            // 
            this.Approved.Text = "Approved";
            // 
            // CkbApproved
            // 
            this.CkbApproved.AutoSize = true;
            this.CkbApproved.Checked = true;
            this.CkbApproved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbApproved.Location = new System.Drawing.Point(104, 152);
            this.CkbApproved.Name = "CkbApproved";
            this.CkbApproved.Size = new System.Drawing.Size(72, 17);
            this.CkbApproved.TabIndex = 5;
            this.CkbApproved.Text = "Approved";
            this.CkbApproved.UseVisualStyleBackColor = true;
            // 
            // TxtStartDate
            // 
            this.TxtStartDate.Location = new System.Drawing.Point(104, 237);
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.Size = new System.Drawing.Size(121, 20);
            this.TxtStartDate.TabIndex = 8;
            // 
            // TxtMaritalStatus
            // 
            this.TxtMaritalStatus.Location = new System.Drawing.Point(104, 153);
            this.TxtMaritalStatus.Name = "TxtMaritalStatus";
            this.TxtMaritalStatus.Size = new System.Drawing.Size(121, 20);
            this.TxtMaritalStatus.TabIndex = 5;
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(104, 181);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(121, 20);
            this.TxtDepartment.TabIndex = 6;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(104, 209);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(121, 20);
            this.TxtTitle.TabIndex = 7;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(42, 240);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(55, 13);
            this.LblStartDate.TabIndex = 48;
            this.LblStartDate.Text = "Start Date";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(35, 184);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(62, 13);
            this.LblDepartment.TabIndex = 47;
            this.LblDepartment.Text = "Department";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(70, 212);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 46;
            this.LblTitle.Text = "Title";
            // 
            // LblMaritalStatus
            // 
            this.LblMaritalStatus.AutoSize = true;
            this.LblMaritalStatus.Location = new System.Drawing.Point(26, 156);
            this.LblMaritalStatus.Name = "LblMaritalStatus";
            this.LblMaritalStatus.Size = new System.Drawing.Size(71, 13);
            this.LblMaritalStatus.TabIndex = 45;
            this.LblMaritalStatus.Text = "Marital Status";
            // 
            // CkbBenefits
            // 
            this.CkbBenefits.AutoSize = true;
            this.CkbBenefits.Checked = true;
            this.CkbBenefits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbBenefits.Location = new System.Drawing.Point(103, 317);
            this.CkbBenefits.Name = "CkbBenefits";
            this.CkbBenefits.Size = new System.Drawing.Size(15, 14);
            this.CkbBenefits.TabIndex = 11;
            this.CkbBenefits.UseVisualStyleBackColor = true;
            // 
            // LblBenefits
            // 
            this.LblBenefits.AutoSize = true;
            this.LblBenefits.Location = new System.Drawing.Point(56, 317);
            this.LblBenefits.Name = "LblBenefits";
            this.LblBenefits.Size = new System.Drawing.Size(41, 13);
            this.LblBenefits.TabIndex = 50;
            this.LblBenefits.Text = "Benifits";
            // 
            // LblDoubleClick
            // 
            this.LblDoubleClick.AutoSize = true;
            this.LblDoubleClick.Location = new System.Drawing.Point(207, 210);
            this.LblDoubleClick.Name = "LblDoubleClick";
            this.LblDoubleClick.Size = new System.Drawing.Size(160, 13);
            this.LblDoubleClick.TabIndex = 26;
            this.LblDoubleClick.Text = "*Double click a course to load it.";
            // 
            // FrmEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 557);
            this.Controls.Add(this.TCxEmployee);
            this.Controls.Add(this.SSxBottom);
            this.Controls.Add(this.MnuMain);
            this.MainMenuStrip = this.MnuMain;
            this.Name = "FrmEmployeeAdd";
            this.Text = "CS3260 Employee GUI";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.SSxBottom.ResumeLayout(false);
            this.SSxBottom.PerformLayout();
            this.TCxEmployee.ResumeLayout(false);
            this.TPxEmployee.ResumeLayout(false);
            this.TPxEmployee.PerformLayout();
            this.TPxCourses.ResumeLayout(false);
            this.TxtGBxAddCourse.ResumeLayout(false);
            this.TxtGBxAddCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuiFile;
        private System.Windows.Forms.ToolStripMenuItem MnuiFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MnuiFileSave;
        private System.Windows.Forms.StatusStrip SSxBottom;
        private System.Windows.Forms.ToolStripStatusLabel LblStatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripMenuItem MnuiFileExit;
        private System.Windows.Forms.TabControl TCxEmployee;
        private System.Windows.Forms.TabPage TPxEmployee;
        private System.Windows.Forms.ComboBox CbxEmployeeType;
        private System.Windows.Forms.Button BtnEmpSearch;
        private System.Windows.Forms.ListView LVxEmployees;
        private System.Windows.Forms.ColumnHeader ColEmployeeID;
        private System.Windows.Forms.ColumnHeader ColLastName;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.TextBox TxtXtraProp1;
        private System.Windows.Forms.TextBox TxtXtraProp2;
        private System.Windows.Forms.Label LblXtraProp1Label;
        private System.Windows.Forms.Label LblXtraProp2Label;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblEmployeeType;
        private System.Windows.Forms.Label LblEmpID;
        private System.Windows.Forms.TabPage TPxCourses;
        private System.Windows.Forms.GroupBox TxtGBxAddCourse;
        private System.Windows.Forms.ListView LVxCourses;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader DateApproved;
        private System.Windows.Forms.ColumnHeader Credits;
        private System.Windows.Forms.Button BtnRemoveCourse;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.TextBox TxtDateApproved;
        private System.Windows.Forms.TextBox TxtCredits;
        private System.Windows.Forms.Label LblDateApproved;
        private System.Windows.Forms.Label LblCredits;
        private System.Windows.Forms.TextBox TxtCourseID;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtGrade;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblGrade;
        private System.Windows.Forms.Label LblCourseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSearch1;
        private System.Windows.Forms.Label LblEmployeeDoubleClick;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblMiddleName;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.CheckBox CkbActiveEmployee;
        private System.Windows.Forms.Label LblActiveEmployee;
        private System.Windows.Forms.CheckBox CkbApproved;
        private System.Windows.Forms.ColumnHeader Approved;
        private System.Windows.Forms.Label LblBenefits;
        private System.Windows.Forms.CheckBox CkbBenefits;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblMaritalStatus;
        private System.Windows.Forms.TextBox TxtStartDate;
        private System.Windows.Forms.TextBox TxtMaritalStatus;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblDoubleClick;
    }
}

