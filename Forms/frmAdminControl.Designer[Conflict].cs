namespace Math_Monkeys
{
    partial class frmAdminControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminControl));
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.tbpReports = new System.Windows.Forms.TabPage();
            this.gbxProgressReport = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.problemSetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateCompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAttemptsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAttemptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemSetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fastestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxReportDate = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAssignments = new System.Windows.Forms.TabPage();
            this.gbxAssignProblemSet = new System.Windows.Forms.GroupBox();
            this.dgvAssignStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveAssigned = new System.Windows.Forms.Button();
            this.btnAssignProblemSet = new System.Windows.Forms.Button();
            this.btnMoveAssignedDown = new System.Windows.Forms.Button();
            this.btnMoveAssignedUp = new System.Windows.Forms.Button();
            this.lbxAssigned = new System.Windows.Forms.ListBox();
            this.incompletedAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbxAvailable = new System.Windows.Forms.ListBox();
            this.problemSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.tbpStudents = new System.Windows.Forms.TabPage();
            this.gbxRemoveStudent = new System.Windows.Forms.GroupBox();
            this.dgvRemoveStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblModify = new System.Windows.Forms.Label();
            this.gbxRemoveStudentInfo = new System.Windows.Forms.GroupBox();
            this.dtpRemoveDOB = new System.Windows.Forms.DateTimePicker();
            this.txtRemoveStudentGrade = new System.Windows.Forms.TextBox();
            this.lblRemoveStudentDOB = new System.Windows.Forms.Label();
            this.lblRemoveStudentGrade = new System.Windows.Forms.Label();
            this.gbxRemoveStudentName = new System.Windows.Forms.GroupBox();
            this.txtRemoveStudentVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblRemoveStudentPassword = new System.Windows.Forms.Label();
            this.lblRemoveStudentVerifyPassword = new System.Windows.Forms.Label();
            this.txtRemoveStudentPassword = new System.Windows.Forms.TextBox();
            this.txtRemoveStudentScreen = new System.Windows.Forms.TextBox();
            this.lblRemoveStudentScreen = new System.Windows.Forms.Label();
            this.lblRemoveStudentFirst = new System.Windows.Forms.Label();
            this.txtRemoveStudentLast = new System.Windows.Forms.TextBox();
            this.txtRemoveStudentFirst = new System.Windows.Forms.TextBox();
            this.lblRemoveStudentLast = new System.Windows.Forms.Label();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.gbxAddStudent = new System.Windows.Forms.GroupBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.gbxAddStudentName = new System.Windows.Forms.GroupBox();
            this.txtNewStudentVerifyPassword = new System.Windows.Forms.TextBox();
            this.lblAddStudentVerifyPassword = new System.Windows.Forms.Label();
            this.txtNewStudentPassword = new System.Windows.Forms.TextBox();
            this.lblAddStudentPassword = new System.Windows.Forms.Label();
            this.txtNewStudentScreenName = new System.Windows.Forms.TextBox();
            this.lblAddStudentScreen = new System.Windows.Forms.Label();
            this.lblAddStudentFirst = new System.Windows.Forms.Label();
            this.txtNewStudentLastName = new System.Windows.Forms.TextBox();
            this.txtNewStudentFirstName = new System.Windows.Forms.TextBox();
            this.lblAddStudentLast = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.txtNewStudentGrade = new System.Windows.Forms.TextBox();
            this.dtpAddStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddStudentDOB = new System.Windows.Forms.Label();
            this.lblAddStudentGrade = new System.Windows.Forms.Label();
            this.ttFrmAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.fdAdmin = new System.Windows.Forms.FontDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblLoginDate = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.errorProviderNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrShowLabel = new System.Windows.Forms.Timer(this.components);
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printStudentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProblemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemSetDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathDrillSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcAdmin.SuspendLayout();
            this.tbpReports.SuspendLayout();
            this.gbxProgressReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.gbxReportDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tbpAssignments.SuspendLayout();
            this.gbxAssignProblemSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).BeginInit();
            this.tbpStudents.SuspendLayout();
            this.gbxRemoveStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveStudent)).BeginInit();
            this.gbxRemoveStudentInfo.SuspendLayout();
            this.gbxRemoveStudentName.SuspendLayout();
            this.gbxAddStudent.SuspendLayout();
            this.gbxAddStudentName.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcAdmin.Controls.Add(this.tbpReports);
            this.tbcAdmin.Controls.Add(this.tbpAssignments);
            this.tbcAdmin.Controls.Add(this.tbpStudents);
            this.tbcAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbcAdmin.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.tbcAdmin.Location = new System.Drawing.Point(12, 142);
            this.tbcAdmin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(1169, 395);
            this.tbcAdmin.TabIndex = 0;
            this.tbcAdmin.SelectedIndexChanged += new System.EventHandler(this.tbcAdmin_SelectedIndexChanged);
            // 
            // tbpReports
            // 
            this.tbpReports.AutoScroll = true;
            this.tbpReports.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbpReports.Controls.Add(this.gbxProgressReport);
            this.tbpReports.Controls.Add(this.dgvStudents);
            this.tbpReports.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpReports.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.tbpReports.ForeColor = System.Drawing.Color.Black;
            this.tbpReports.Location = new System.Drawing.Point(4, 29);
            this.tbpReports.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpReports.Name = "tbpReports";
            this.tbpReports.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpReports.Size = new System.Drawing.Size(1161, 362);
            this.tbpReports.TabIndex = 0;
            this.tbpReports.Text = "Reports";
            // 
            // gbxProgressReport
            // 
            this.gbxProgressReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProgressReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxProgressReport.Controls.Add(this.dgvReport);
            this.gbxProgressReport.Controls.Add(this.gbxReportDate);
            this.gbxProgressReport.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProgressReport.Location = new System.Drawing.Point(0, 222);
            this.gbxProgressReport.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProgressReport.Name = "gbxProgressReport";
            this.gbxProgressReport.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProgressReport.Size = new System.Drawing.Size(762, 392);
            this.gbxProgressReport.TabIndex = 1;
            this.gbxProgressReport.TabStop = false;
            this.gbxProgressReport.Text = "Progress Report";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.problemSetNameDataGridViewTextBoxColumn,
            this.dateAssignedDataGridViewTextBoxColumn,
            this.isCompletedDataGridViewCheckBoxColumn,
            this.dateCompletedDataGridViewTextBoxColumn,
            this.numberOfAttemptsDataGridViewTextBoxColumn,
            this.highestGradeDataGridViewTextBoxColumn,
            this.lastAttemptDateDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.problemSetIDDataGridViewTextBoxColumn,
            this.problemSetDataGridViewTextBoxColumn,
            this.fastestTimeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvReport.DataSource = this.assignmentsBindingSource;
            this.dgvReport.Location = new System.Drawing.Point(9, 88);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(751, 373);
            this.dgvReport.TabIndex = 2;
            // 
            // problemSetNameDataGridViewTextBoxColumn
            // 
            this.problemSetNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.problemSetNameDataGridViewTextBoxColumn.DataPropertyName = "ProblemSetName";
            this.problemSetNameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.problemSetNameDataGridViewTextBoxColumn.HeaderText = "Problem Set Name";
            this.problemSetNameDataGridViewTextBoxColumn.Name = "problemSetNameDataGridViewTextBoxColumn";
            this.problemSetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAssignedDataGridViewTextBoxColumn
            // 
            this.dateAssignedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAssignedDataGridViewTextBoxColumn.DataPropertyName = "DateAssigned";
            dataGridViewCellStyle1.Format = "d";
            this.dateAssignedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateAssignedDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateAssignedDataGridViewTextBoxColumn.HeaderText = "Date Assigned";
            this.dateAssignedDataGridViewTextBoxColumn.Name = "dateAssignedDataGridViewTextBoxColumn";
            this.dateAssignedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            this.isCompletedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "IsCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.isCompletedDataGridViewCheckBoxColumn.HeaderText = "Completed";
            this.isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            this.isCompletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dateCompletedDataGridViewTextBoxColumn
            // 
            this.dateCompletedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCompletedDataGridViewTextBoxColumn.DataPropertyName = "DateCompleted";
            dataGridViewCellStyle2.Format = "d";
            this.dateCompletedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateCompletedDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateCompletedDataGridViewTextBoxColumn.HeaderText = "Date Completed";
            this.dateCompletedDataGridViewTextBoxColumn.Name = "dateCompletedDataGridViewTextBoxColumn";
            this.dateCompletedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfAttemptsDataGridViewTextBoxColumn
            // 
            this.numberOfAttemptsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfAttemptsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfAttempts";
            this.numberOfAttemptsDataGridViewTextBoxColumn.FillWeight = 50F;
            this.numberOfAttemptsDataGridViewTextBoxColumn.HeaderText = "Number Of Attempts";
            this.numberOfAttemptsDataGridViewTextBoxColumn.Name = "numberOfAttemptsDataGridViewTextBoxColumn";
            this.numberOfAttemptsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // highestGradeDataGridViewTextBoxColumn
            // 
            this.highestGradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.highestGradeDataGridViewTextBoxColumn.DataPropertyName = "HighestGrade";
            dataGridViewCellStyle3.Format = "P";
            this.highestGradeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.highestGradeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.highestGradeDataGridViewTextBoxColumn.HeaderText = "Highest Grade";
            this.highestGradeDataGridViewTextBoxColumn.Name = "highestGradeDataGridViewTextBoxColumn";
            this.highestGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastAttemptDateDataGridViewTextBoxColumn
            // 
            this.lastAttemptDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastAttemptDateDataGridViewTextBoxColumn.DataPropertyName = "LastAttemptDate";
            dataGridViewCellStyle4.Format = "d";
            this.lastAttemptDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lastAttemptDateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.lastAttemptDateDataGridViewTextBoxColumn.HeaderText = "Date of Last Attempt";
            this.lastAttemptDateDataGridViewTextBoxColumn.Name = "lastAttemptDateDataGridViewTextBoxColumn";
            this.lastAttemptDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentDataGridViewTextBoxColumn.Visible = false;
            // 
            // problemSetIDDataGridViewTextBoxColumn
            // 
            this.problemSetIDDataGridViewTextBoxColumn.DataPropertyName = "ProblemSetID";
            this.problemSetIDDataGridViewTextBoxColumn.HeaderText = "ProblemSetID";
            this.problemSetIDDataGridViewTextBoxColumn.Name = "problemSetIDDataGridViewTextBoxColumn";
            this.problemSetIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.problemSetIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // problemSetDataGridViewTextBoxColumn
            // 
            this.problemSetDataGridViewTextBoxColumn.DataPropertyName = "ProblemSet";
            this.problemSetDataGridViewTextBoxColumn.HeaderText = "ProblemSet";
            this.problemSetDataGridViewTextBoxColumn.Name = "problemSetDataGridViewTextBoxColumn";
            this.problemSetDataGridViewTextBoxColumn.ReadOnly = true;
            this.problemSetDataGridViewTextBoxColumn.Visible = false;
            // 
            // fastestTimeDataGridViewTextBoxColumn
            // 
            this.fastestTimeDataGridViewTextBoxColumn.DataPropertyName = "FastestTime";
            dataGridViewCellStyle5.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle5.NullValue = null;
            this.fastestTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.fastestTimeDataGridViewTextBoxColumn.HeaderText = "Fastest Time";
            this.fastestTimeDataGridViewTextBoxColumn.Name = "fastestTimeDataGridViewTextBoxColumn";
            this.fastestTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // assignmentsBindingSource
            // 
            this.assignmentsBindingSource.DataMember = "Assignments";
            this.assignmentsBindingSource.DataSource = this.studentBindingSource;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // gbxReportDate
            // 
            this.gbxReportDate.Controls.Add(this.dtpStartDate);
            this.gbxReportDate.Controls.Add(this.dtpEndDate);
            this.gbxReportDate.Controls.Add(this.lblEndDate);
            this.gbxReportDate.Controls.Add(this.lblStartDate);
            this.gbxReportDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReportDate.Location = new System.Drawing.Point(9, 28);
            this.gbxReportDate.Margin = new System.Windows.Forms.Padding(2);
            this.gbxReportDate.Name = "gbxReportDate";
            this.gbxReportDate.Padding = new System.Windows.Forms.Padding(2);
            this.gbxReportDate.Size = new System.Drawing.Size(504, 56);
            this.gbxReportDate.TabIndex = 0;
            this.gbxReportDate.TabStop = false;
            this.gbxReportDate.Text = "Report Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = global::Math_Monkeys.Properties.Settings.Default.DatePickerFormat;
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpStartDate.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(58, 19);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 25);
            this.dtpStartDate.TabIndex = 2;
            this.ttFrmAdmin.SetToolTip(this.dtpStartDate, "The beginning date from which you want to see progress reports.");
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = global::Math_Monkeys.Properties.Settings.Default.DatePickerFormat;
            this.dtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpEndDate.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(327, 19);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(160, 25);
            this.dtpEndDate.TabIndex = 3;
            this.ttFrmAdmin.SetToolTip(this.dtpEndDate, "The ending date from which you want to see progress reports.");
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(282, 22);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(41, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblStartDate.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblStartDate.Location = new System.Drawing.Point(9, 23);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(45, 20);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.dgvStudents.DataSource = this.studentBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(762, 216);
            this.dgvStudents.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GetFullName";
            this.dataGridViewTextBoxColumn13.FillWeight = 150F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ScreenName";
            this.dataGridViewTextBoxColumn11.FillWeight = 150F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Screen Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DOB";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn2.FillWeight = 75F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompletedAssignments";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Completed Assignments";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IncompleteAssignments";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Incomplete Assignments";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalAssignments";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Assignments";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 48;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 92;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GetUserTypeString";
            this.dataGridViewTextBoxColumn8.HeaderText = "GetUserTypeString";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 154;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn9.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn10.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 98;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn12.HeaderText = "Password";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 96;
            // 
            // tbpAssignments
            // 
            this.tbpAssignments.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbpAssignments.Controls.Add(this.gbxAssignProblemSet);
            this.tbpAssignments.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpAssignments.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.tbpAssignments.Location = new System.Drawing.Point(4, 29);
            this.tbpAssignments.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpAssignments.Name = "tbpAssignments";
            this.tbpAssignments.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpAssignments.Size = new System.Drawing.Size(1161, 362);
            this.tbpAssignments.TabIndex = 1;
            this.tbpAssignments.Text = "Assignments";
            // 
            // gbxAssignProblemSet
            // 
            this.gbxAssignProblemSet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxAssignProblemSet.Controls.Add(this.dgvAssignStudents);
            this.gbxAssignProblemSet.Controls.Add(this.btnRemoveAssigned);
            this.gbxAssignProblemSet.Controls.Add(this.btnAssignProblemSet);
            this.gbxAssignProblemSet.Controls.Add(this.btnMoveAssignedDown);
            this.gbxAssignProblemSet.Controls.Add(this.btnMoveAssignedUp);
            this.gbxAssignProblemSet.Controls.Add(this.lbxAssigned);
            this.gbxAssignProblemSet.Controls.Add(this.lbxAvailable);
            this.gbxAssignProblemSet.Controls.Add(this.lblAssigned);
            this.gbxAssignProblemSet.Controls.Add(this.lblAvailable);
            this.gbxAssignProblemSet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAssignProblemSet.Location = new System.Drawing.Point(5, 7);
            this.gbxAssignProblemSet.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAssignProblemSet.Name = "gbxAssignProblemSet";
            this.gbxAssignProblemSet.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAssignProblemSet.Size = new System.Drawing.Size(1227, 493);
            this.gbxAssignProblemSet.TabIndex = 0;
            this.gbxAssignProblemSet.TabStop = false;
            this.gbxAssignProblemSet.Text = "Assign Problem Sets";
            // 
            // dgvAssignStudents
            // 
            this.dgvAssignStudents.AllowUserToAddRows = false;
            this.dgvAssignStudents.AllowUserToDeleteRows = false;
            this.dgvAssignStudents.AutoGenerateColumns = false;
            this.dgvAssignStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn25});
            this.dgvAssignStudents.DataSource = this.studentBindingSource;
            this.dgvAssignStudents.Location = new System.Drawing.Point(15, 38);
            this.dgvAssignStudents.Name = "dgvAssignStudents";
            this.dgvAssignStudents.ReadOnly = true;
            this.dgvAssignStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignStudents.Size = new System.Drawing.Size(574, 424);
            this.dgvAssignStudents.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "GetFullName";
            this.dataGridViewTextBoxColumn26.HeaderText = "Name";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ScreenName";
            this.dataGridViewTextBoxColumn24.HeaderText = "Screen Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn14.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn15.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CompletedAssignments";
            this.dataGridViewTextBoxColumn16.HeaderText = "CompletedAssignments";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "IncompleteAssignments";
            this.dataGridViewTextBoxColumn17.HeaderText = "IncompleteAssignments";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TotalAssignments";
            this.dataGridViewTextBoxColumn18.HeaderText = "TotalAssignments";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn20.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "GetUserTypeString";
            this.dataGridViewTextBoxColumn21.HeaderText = "GetUserTypeString";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn22.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn23.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn25.HeaderText = "Password";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // btnRemoveAssigned
            // 
            this.btnRemoveAssigned.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAssigned.BackgroundImage")));
            this.btnRemoveAssigned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveAssigned.FlatAppearance.BorderSize = 0;
            this.btnRemoveAssigned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAssigned.Location = new System.Drawing.Point(849, 260);
            this.btnRemoveAssigned.Name = "btnRemoveAssigned";
            this.btnRemoveAssigned.Size = new System.Drawing.Size(76, 50);
            this.btnRemoveAssigned.TabIndex = 3;
            this.btnRemoveAssigned.UseVisualStyleBackColor = true;
            this.btnRemoveAssigned.Click += new System.EventHandler(this.btnRemoveAssigned_Click);
            // 
            // btnAssignProblemSet
            // 
            this.btnAssignProblemSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssignProblemSet.BackgroundImage")));
            this.btnAssignProblemSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAssignProblemSet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAssignProblemSet.FlatAppearance.BorderSize = 0;
            this.btnAssignProblemSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssignProblemSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignProblemSet.Location = new System.Drawing.Point(848, 204);
            this.btnAssignProblemSet.Name = "btnAssignProblemSet";
            this.btnAssignProblemSet.Size = new System.Drawing.Size(76, 50);
            this.btnAssignProblemSet.TabIndex = 2;
            this.btnAssignProblemSet.UseVisualStyleBackColor = true;
            this.btnAssignProblemSet.Click += new System.EventHandler(this.btnAssignProblemSet_Click);
            // 
            // btnMoveAssignedDown
            // 
            this.btnMoveAssignedDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveAssignedDown.BackgroundImage")));
            this.btnMoveAssignedDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoveAssignedDown.FlatAppearance.BorderSize = 0;
            this.btnMoveAssignedDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMoveAssignedDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAssignedDown.Location = new System.Drawing.Point(1145, 260);
            this.btnMoveAssignedDown.Name = "btnMoveAssignedDown";
            this.btnMoveAssignedDown.Size = new System.Drawing.Size(76, 50);
            this.btnMoveAssignedDown.TabIndex = 6;
            this.btnMoveAssignedDown.UseVisualStyleBackColor = true;
            // 
            // btnMoveAssignedUp
            // 
            this.btnMoveAssignedUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveAssignedUp.BackgroundImage")));
            this.btnMoveAssignedUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoveAssignedUp.FlatAppearance.BorderSize = 0;
            this.btnMoveAssignedUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoveAssignedUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAssignedUp.Location = new System.Drawing.Point(1144, 204);
            this.btnMoveAssignedUp.Name = "btnMoveAssignedUp";
            this.btnMoveAssignedUp.Size = new System.Drawing.Size(76, 50);
            this.btnMoveAssignedUp.TabIndex = 5;
            this.btnMoveAssignedUp.UseVisualStyleBackColor = true;
            // 
            // lbxAssigned
            // 
            this.lbxAssigned.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxAssigned.DataSource = this.incompletedAssignmentsBindingSource;
            this.lbxAssigned.DisplayMember = "ProblemSetName";
            this.lbxAssigned.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAssigned.FormattingEnabled = true;
            this.lbxAssigned.ItemHeight = 21;
            this.lbxAssigned.Location = new System.Drawing.Point(929, 38);
            this.lbxAssigned.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAssigned.Name = "lbxAssigned";
            this.lbxAssigned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAssigned.Size = new System.Drawing.Size(216, 445);
            this.lbxAssigned.TabIndex = 4;
            // 
            // incompletedAssignmentsBindingSource
            // 
            this.incompletedAssignmentsBindingSource.DataMember = "IncompletedAssignments";
            this.incompletedAssignmentsBindingSource.DataSource = this.studentBindingSource;
            // 
            // lbxAvailable
            // 
            this.lbxAvailable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxAvailable.DataSource = this.problemSetBindingSource;
            this.lbxAvailable.DisplayMember = "Name";
            this.lbxAvailable.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailable.FormattingEnabled = true;
            this.lbxAvailable.ItemHeight = 21;
            this.lbxAvailable.Location = new System.Drawing.Point(627, 38);
            this.lbxAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAvailable.Name = "lbxAvailable";
            this.lbxAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAvailable.Size = new System.Drawing.Size(216, 445);
            this.lbxAvailable.TabIndex = 1;
            this.lbxAvailable.ValueMember = "ID";
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssigned.Location = new System.Drawing.Point(994, 14);
            this.lblAssigned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(72, 21);
            this.lblAssigned.TabIndex = 14;
            this.lblAssigned.Text = "Assigned";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(700, 14);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(74, 21);
            this.lblAvailable.TabIndex = 13;
            this.lblAvailable.Text = "Available";
            // 
            // tbpStudents
            // 
            this.tbpStudents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbpStudents.Controls.Add(this.gbxRemoveStudent);
            this.tbpStudents.Controls.Add(this.gbxAddStudent);
            this.tbpStudents.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbpStudents.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.tbpStudents.Location = new System.Drawing.Point(4, 29);
            this.tbpStudents.Margin = new System.Windows.Forms.Padding(2);
            this.tbpStudents.Name = "tbpStudents";
            this.tbpStudents.Size = new System.Drawing.Size(1161, 362);
            this.tbpStudents.TabIndex = 3;
            this.tbpStudents.Text = "Students";
            // 
            // gbxRemoveStudent
            // 
            this.gbxRemoveStudent.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbxRemoveStudent.Controls.Add(this.dgvRemoveStudent);
            this.gbxRemoveStudent.Controls.Add(this.lblRemove);
            this.gbxRemoveStudent.Controls.Add(this.lblModify);
            this.gbxRemoveStudent.Controls.Add(this.gbxRemoveStudentInfo);
            this.gbxRemoveStudent.Controls.Add(this.gbxRemoveStudentName);
            this.gbxRemoveStudent.Controls.Add(this.btnModifyUser);
            this.gbxRemoveStudent.Controls.Add(this.btnRemoveStudent);
            this.gbxRemoveStudent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveStudent.Location = new System.Drawing.Point(325, 11);
            this.gbxRemoveStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudent.Name = "gbxRemoveStudent";
            this.gbxRemoveStudent.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudent.Size = new System.Drawing.Size(806, 457);
            this.gbxRemoveStudent.TabIndex = 37;
            this.gbxRemoveStudent.TabStop = false;
            this.gbxRemoveStudent.Text = "Remove Student";
            // 
            // dgvRemoveStudent
            // 
            this.dgvRemoveStudent.AllowUserToAddRows = false;
            this.dgvRemoveStudent.AllowUserToDeleteRows = false;
            this.dgvRemoveStudent.AutoGenerateColumns = false;
            this.dgvRemoveStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoveStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn38});
            this.dgvRemoveStudent.DataSource = this.studentBindingSource;
            this.dgvRemoveStudent.Location = new System.Drawing.Point(5, 24);
            this.dgvRemoveStudent.Name = "dgvRemoveStudent";
            this.dgvRemoveStudent.ReadOnly = true;
            this.dgvRemoveStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemoveStudent.Size = new System.Drawing.Size(508, 428);
            this.dgvRemoveStudent.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn39.DataPropertyName = "GetFullName";
            this.dataGridViewTextBoxColumn39.HeaderText = "Name";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ScreenName";
            this.dataGridViewTextBoxColumn37.HeaderText = "Screen Name";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn27.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn28.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "CompletedAssignments";
            this.dataGridViewTextBoxColumn29.HeaderText = "CompletedAssignments";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "IncompleteAssignments";
            this.dataGridViewTextBoxColumn30.HeaderText = "IncompleteAssignments";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "TotalAssignments";
            this.dataGridViewTextBoxColumn31.HeaderText = "TotalAssignments";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn32.HeaderText = "ID";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn33.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "GetUserTypeString";
            this.dataGridViewTextBoxColumn34.HeaderText = "GetUserTypeString";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn35.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn36.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn38.HeaderText = "Password";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Visible = false;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(690, 432);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(70, 21);
            this.lblRemove.TabIndex = 44;
            this.lblRemove.Text = "REMOVE";
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Location = new System.Drawing.Point(549, 431);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(64, 21);
            this.lblModify.TabIndex = 16;
            this.lblModify.Text = "MODIFY";
            // 
            // gbxRemoveStudentInfo
            // 
            this.gbxRemoveStudentInfo.Controls.Add(this.dtpRemoveDOB);
            this.gbxRemoveStudentInfo.Controls.Add(this.txtRemoveStudentGrade);
            this.gbxRemoveStudentInfo.Controls.Add(this.lblRemoveStudentDOB);
            this.gbxRemoveStudentInfo.Controls.Add(this.lblRemoveStudentGrade);
            this.gbxRemoveStudentInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveStudentInfo.Location = new System.Drawing.Point(518, 261);
            this.gbxRemoveStudentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudentInfo.Name = "gbxRemoveStudentInfo";
            this.gbxRemoveStudentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudentInfo.Size = new System.Drawing.Size(268, 107);
            this.gbxRemoveStudentInfo.TabIndex = 2;
            this.gbxRemoveStudentInfo.TabStop = false;
            this.gbxRemoveStudentInfo.Text = "Info";
            // 
            // dtpRemoveDOB
            // 
            this.dtpRemoveDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "DOB", true));
            this.dtpRemoveDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRemoveDOB.Location = new System.Drawing.Point(82, 61);
            this.dtpRemoveDOB.Name = "dtpRemoveDOB";
            this.dtpRemoveDOB.Size = new System.Drawing.Size(144, 26);
            this.dtpRemoveDOB.TabIndex = 1;
            // 
            // txtRemoveStudentGrade
            // 
            this.txtRemoveStudentGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Grade", true));
            this.txtRemoveStudentGrade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentGrade.Location = new System.Drawing.Point(82, 24);
            this.txtRemoveStudentGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentGrade.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtRemoveStudentGrade.Name = "txtRemoveStudentGrade";
            this.txtRemoveStudentGrade.ShortcutsEnabled = false;
            this.txtRemoveStudentGrade.Size = new System.Drawing.Size(56, 26);
            this.txtRemoveStudentGrade.TabIndex = 0;
            // 
            // lblRemoveStudentDOB
            // 
            this.lblRemoveStudentDOB.AutoSize = true;
            this.lblRemoveStudentDOB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentDOB.Location = new System.Drawing.Point(5, 64);
            this.lblRemoveStudentDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentDOB.Name = "lblRemoveStudentDOB";
            this.lblRemoveStudentDOB.Size = new System.Drawing.Size(40, 21);
            this.lblRemoveStudentDOB.TabIndex = 11;
            this.lblRemoveStudentDOB.Text = "DOB";
            // 
            // lblRemoveStudentGrade
            // 
            this.lblRemoveStudentGrade.AutoSize = true;
            this.lblRemoveStudentGrade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentGrade.Location = new System.Drawing.Point(5, 29);
            this.lblRemoveStudentGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentGrade.Name = "lblRemoveStudentGrade";
            this.lblRemoveStudentGrade.Size = new System.Drawing.Size(51, 21);
            this.lblRemoveStudentGrade.TabIndex = 9;
            this.lblRemoveStudentGrade.Text = "Grade";
            // 
            // gbxRemoveStudentName
            // 
            this.gbxRemoveStudentName.Controls.Add(this.txtRemoveStudentVerifyPassword);
            this.gbxRemoveStudentName.Controls.Add(this.lblRemoveStudentPassword);
            this.gbxRemoveStudentName.Controls.Add(this.lblRemoveStudentVerifyPassword);
            this.gbxRemoveStudentName.Controls.Add(this.txtRemoveStudentPassword);
            this.gbxRemoveStudentName.Controls.Add(this.txtRemoveStudentScreen);
            this.gbxRemoveStudentName.Controls.Add(this.lblRemoveStudentScreen);
            this.gbxRemoveStudentName.Controls.Add(this.lblRemoveStudentFirst);
            this.gbxRemoveStudentName.Controls.Add(this.txtRemoveStudentLast);
            this.gbxRemoveStudentName.Controls.Add(this.txtRemoveStudentFirst);
            this.gbxRemoveStudentName.Controls.Add(this.lblRemoveStudentLast);
            this.gbxRemoveStudentName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveStudentName.Location = new System.Drawing.Point(518, 19);
            this.gbxRemoveStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudentName.Name = "gbxRemoveStudentName";
            this.gbxRemoveStudentName.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRemoveStudentName.Size = new System.Drawing.Size(268, 238);
            this.gbxRemoveStudentName.TabIndex = 1;
            this.gbxRemoveStudentName.TabStop = false;
            this.gbxRemoveStudentName.Text = "Name";
            // 
            // txtRemoveStudentVerifyPassword
            // 
            this.txtRemoveStudentVerifyPassword.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Math_Monkeys.Properties.Settings.Default, "MaxPasswordLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRemoveStudentVerifyPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.txtRemoveStudentVerifyPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentVerifyPassword.Location = new System.Drawing.Point(127, 179);
            this.txtRemoveStudentVerifyPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentVerifyPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.MaxPasswordLength;
            this.txtRemoveStudentVerifyPassword.Name = "txtRemoveStudentVerifyPassword";
            this.txtRemoveStudentVerifyPassword.ShortcutsEnabled = false;
            this.txtRemoveStudentVerifyPassword.Size = new System.Drawing.Size(124, 26);
            this.txtRemoveStudentVerifyPassword.TabIndex = 4;
            this.txtRemoveStudentVerifyPassword.UseSystemPasswordChar = true;
            this.txtRemoveStudentVerifyPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblRemoveStudentPassword
            // 
            this.lblRemoveStudentPassword.AutoSize = true;
            this.lblRemoveStudentPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentPassword.Location = new System.Drawing.Point(5, 145);
            this.lblRemoveStudentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentPassword.Name = "lblRemoveStudentPassword";
            this.lblRemoveStudentPassword.Size = new System.Drawing.Size(76, 21);
            this.lblRemoveStudentPassword.TabIndex = 13;
            this.lblRemoveStudentPassword.Text = "Password";
            // 
            // lblRemoveStudentVerifyPassword
            // 
            this.lblRemoveStudentVerifyPassword.AutoSize = true;
            this.lblRemoveStudentVerifyPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentVerifyPassword.Location = new System.Drawing.Point(5, 184);
            this.lblRemoveStudentVerifyPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentVerifyPassword.Name = "lblRemoveStudentVerifyPassword";
            this.lblRemoveStudentVerifyPassword.Size = new System.Drawing.Size(118, 21);
            this.lblRemoveStudentVerifyPassword.TabIndex = 15;
            this.lblRemoveStudentVerifyPassword.Text = "Verify Password";
            // 
            // txtRemoveStudentPassword
            // 
            this.txtRemoveStudentPassword.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Math_Monkeys.Properties.Settings.Default, "MaxPasswordLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRemoveStudentPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.txtRemoveStudentPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentPassword.Location = new System.Drawing.Point(127, 140);
            this.txtRemoveStudentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.MaxPasswordLength;
            this.txtRemoveStudentPassword.Name = "txtRemoveStudentPassword";
            this.txtRemoveStudentPassword.ShortcutsEnabled = false;
            this.txtRemoveStudentPassword.Size = new System.Drawing.Size(124, 26);
            this.txtRemoveStudentPassword.TabIndex = 3;
            this.txtRemoveStudentPassword.UseSystemPasswordChar = true;
            this.txtRemoveStudentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtRemoveStudentScreen
            // 
            this.txtRemoveStudentScreen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ScreenName", true));
            this.txtRemoveStudentScreen.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentScreen.Location = new System.Drawing.Point(127, 101);
            this.txtRemoveStudentScreen.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentScreen.MaxLength = global::Math_Monkeys.Properties.Settings.Default.ScreenNameMax;
            this.txtRemoveStudentScreen.Name = "txtRemoveStudentScreen";
            this.txtRemoveStudentScreen.ShortcutsEnabled = false;
            this.txtRemoveStudentScreen.Size = new System.Drawing.Size(124, 26);
            this.txtRemoveStudentScreen.TabIndex = 2;
            this.txtRemoveStudentScreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScreenName_KeyPress);
            // 
            // lblRemoveStudentScreen
            // 
            this.lblRemoveStudentScreen.AutoSize = true;
            this.lblRemoveStudentScreen.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentScreen.Location = new System.Drawing.Point(5, 106);
            this.lblRemoveStudentScreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentScreen.Name = "lblRemoveStudentScreen";
            this.lblRemoveStudentScreen.Size = new System.Drawing.Size(56, 21);
            this.lblRemoveStudentScreen.TabIndex = 7;
            this.lblRemoveStudentScreen.Text = "Screen";
            // 
            // lblRemoveStudentFirst
            // 
            this.lblRemoveStudentFirst.AutoSize = true;
            this.lblRemoveStudentFirst.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentFirst.Location = new System.Drawing.Point(5, 28);
            this.lblRemoveStudentFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentFirst.Name = "lblRemoveStudentFirst";
            this.lblRemoveStudentFirst.Size = new System.Drawing.Size(39, 21);
            this.lblRemoveStudentFirst.TabIndex = 0;
            this.lblRemoveStudentFirst.Text = "First";
            // 
            // txtRemoveStudentLast
            // 
            this.txtRemoveStudentLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.txtRemoveStudentLast.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentLast.Location = new System.Drawing.Point(127, 62);
            this.txtRemoveStudentLast.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentLast.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtRemoveStudentLast.Name = "txtRemoveStudentLast";
            this.txtRemoveStudentLast.ShortcutsEnabled = false;
            this.txtRemoveStudentLast.Size = new System.Drawing.Size(124, 26);
            this.txtRemoveStudentLast.TabIndex = 1;
            this.txtRemoveStudentLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtRemoveStudentFirst
            // 
            this.txtRemoveStudentFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.txtRemoveStudentFirst.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveStudentFirst.Location = new System.Drawing.Point(127, 23);
            this.txtRemoveStudentFirst.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveStudentFirst.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtRemoveStudentFirst.Name = "txtRemoveStudentFirst";
            this.txtRemoveStudentFirst.ShortcutsEnabled = false;
            this.txtRemoveStudentFirst.Size = new System.Drawing.Size(124, 26);
            this.txtRemoveStudentFirst.TabIndex = 0;
            this.txtRemoveStudentFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblRemoveStudentLast
            // 
            this.lblRemoveStudentLast.AutoSize = true;
            this.lblRemoveStudentLast.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveStudentLast.Location = new System.Drawing.Point(5, 67);
            this.lblRemoveStudentLast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveStudentLast.Name = "lblRemoveStudentLast";
            this.lblRemoveStudentLast.Size = new System.Drawing.Size(39, 21);
            this.lblRemoveStudentLast.TabIndex = 5;
            this.lblRemoveStudentLast.Text = "Last";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifyUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifyUser.BackgroundImage")));
            this.btnModifyUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifyUser.Location = new System.Drawing.Point(518, 380);
            this.btnModifyUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(120, 50);
            this.btnModifyUser.TabIndex = 3;
            this.btnModifyUser.UseVisualStyleBackColor = false;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudent.BackgroundImage")));
            this.btnRemoveStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveStudent.Location = new System.Drawing.Point(666, 380);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(120, 50);
            this.btnRemoveStudent.TabIndex = 4;
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // gbxAddStudent
            // 
            this.gbxAddStudent.BackColor = System.Drawing.Color.Beige;
            this.gbxAddStudent.Controls.Add(this.lblAdd);
            this.gbxAddStudent.Controls.Add(this.btnAddNewStudent);
            this.gbxAddStudent.Controls.Add(this.gbxAddStudentName);
            this.gbxAddStudent.Controls.Add(this.gbxInfo);
            this.gbxAddStudent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddStudent.Location = new System.Drawing.Point(5, 11);
            this.gbxAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAddStudent.Name = "gbxAddStudent";
            this.gbxAddStudent.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAddStudent.Size = new System.Drawing.Size(297, 457);
            this.gbxAddStudent.TabIndex = 0;
            this.gbxAddStudent.TabStop = false;
            this.gbxAddStudent.Text = "Add Student";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(198, 432);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(40, 21);
            this.lblAdd.TabIndex = 37;
            this.lblAdd.Text = "ADD";
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewStudent.BackgroundImage")));
            this.btnAddNewStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNewStudent.Location = new System.Drawing.Point(160, 380);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(120, 50);
            this.btnAddNewStudent.TabIndex = 1;
            this.btnAddNewStudent.UseVisualStyleBackColor = false;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // gbxAddStudentName
            // 
            this.gbxAddStudentName.Controls.Add(this.txtNewStudentVerifyPassword);
            this.gbxAddStudentName.Controls.Add(this.lblAddStudentVerifyPassword);
            this.gbxAddStudentName.Controls.Add(this.txtNewStudentPassword);
            this.gbxAddStudentName.Controls.Add(this.lblAddStudentPassword);
            this.gbxAddStudentName.Controls.Add(this.txtNewStudentScreenName);
            this.gbxAddStudentName.Controls.Add(this.lblAddStudentScreen);
            this.gbxAddStudentName.Controls.Add(this.lblAddStudentFirst);
            this.gbxAddStudentName.Controls.Add(this.txtNewStudentLastName);
            this.gbxAddStudentName.Controls.Add(this.txtNewStudentFirstName);
            this.gbxAddStudentName.Controls.Add(this.lblAddStudentLast);
            this.gbxAddStudentName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddStudentName.Location = new System.Drawing.Point(12, 19);
            this.gbxAddStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAddStudentName.Name = "gbxAddStudentName";
            this.gbxAddStudentName.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAddStudentName.Size = new System.Drawing.Size(268, 238);
            this.gbxAddStudentName.TabIndex = 11;
            this.gbxAddStudentName.TabStop = false;
            this.gbxAddStudentName.Text = "Name";
            // 
            // txtNewStudentVerifyPassword
            // 
            this.txtNewStudentVerifyPassword.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Math_Monkeys.Properties.Settings.Default, "MaxPasswordLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNewStudentVerifyPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentVerifyPassword.Location = new System.Drawing.Point(127, 179);
            this.txtNewStudentVerifyPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentVerifyPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.MaxPasswordLength;
            this.txtNewStudentVerifyPassword.Name = "txtNewStudentVerifyPassword";
            this.txtNewStudentVerifyPassword.ShortcutsEnabled = false;
            this.txtNewStudentVerifyPassword.Size = new System.Drawing.Size(124, 26);
            this.txtNewStudentVerifyPassword.TabIndex = 4;
            this.txtNewStudentVerifyPassword.UseSystemPasswordChar = true;
            this.txtNewStudentVerifyPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtNewStudentVerifyPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblAddStudentVerifyPassword
            // 
            this.lblAddStudentVerifyPassword.AutoSize = true;
            this.lblAddStudentVerifyPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentVerifyPassword.Location = new System.Drawing.Point(5, 184);
            this.lblAddStudentVerifyPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentVerifyPassword.Name = "lblAddStudentVerifyPassword";
            this.lblAddStudentVerifyPassword.Size = new System.Drawing.Size(118, 21);
            this.lblAddStudentVerifyPassword.TabIndex = 16;
            this.lblAddStudentVerifyPassword.Text = "Verify Password";
            // 
            // txtNewStudentPassword
            // 
            this.txtNewStudentPassword.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Math_Monkeys.Properties.Settings.Default, "MaxPasswordLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNewStudentPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentPassword.Location = new System.Drawing.Point(127, 140);
            this.txtNewStudentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.MaxPasswordLength;
            this.txtNewStudentPassword.Name = "txtNewStudentPassword";
            this.txtNewStudentPassword.ShortcutsEnabled = false;
            this.txtNewStudentPassword.Size = new System.Drawing.Size(124, 26);
            this.txtNewStudentPassword.TabIndex = 3;
            this.txtNewStudentPassword.UseSystemPasswordChar = true;
            this.txtNewStudentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtNewStudentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewStudentPassword_Validating);
            // 
            // lblAddStudentPassword
            // 
            this.lblAddStudentPassword.AutoSize = true;
            this.lblAddStudentPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentPassword.Location = new System.Drawing.Point(5, 145);
            this.lblAddStudentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentPassword.Name = "lblAddStudentPassword";
            this.lblAddStudentPassword.Size = new System.Drawing.Size(69, 21);
            this.lblAddStudentPassword.TabIndex = 13;
            this.lblAddStudentPassword.Text = "Pasword";
            // 
            // txtNewStudentScreenName
            // 
            this.txtNewStudentScreenName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentScreenName.Location = new System.Drawing.Point(127, 101);
            this.txtNewStudentScreenName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentScreenName.MaxLength = global::Math_Monkeys.Properties.Settings.Default.ScreenNameMax;
            this.txtNewStudentScreenName.Name = "txtNewStudentScreenName";
            this.txtNewStudentScreenName.ShortcutsEnabled = false;
            this.txtNewStudentScreenName.Size = new System.Drawing.Size(124, 26);
            this.txtNewStudentScreenName.TabIndex = 2;
            this.txtNewStudentScreenName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScreenName_KeyPress);
            this.txtNewStudentScreenName.Validating += new System.ComponentModel.CancelEventHandler(this.txtScreenName_Validating);
            // 
            // lblAddStudentScreen
            // 
            this.lblAddStudentScreen.AutoSize = true;
            this.lblAddStudentScreen.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentScreen.Location = new System.Drawing.Point(5, 106);
            this.lblAddStudentScreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentScreen.Name = "lblAddStudentScreen";
            this.lblAddStudentScreen.Size = new System.Drawing.Size(56, 21);
            this.lblAddStudentScreen.TabIndex = 7;
            this.lblAddStudentScreen.Text = "Screen";
            // 
            // lblAddStudentFirst
            // 
            this.lblAddStudentFirst.AutoSize = true;
            this.lblAddStudentFirst.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentFirst.Location = new System.Drawing.Point(5, 28);
            this.lblAddStudentFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentFirst.Name = "lblAddStudentFirst";
            this.lblAddStudentFirst.Size = new System.Drawing.Size(39, 21);
            this.lblAddStudentFirst.TabIndex = 0;
            this.lblAddStudentFirst.Text = "First";
            // 
            // txtNewStudentLastName
            // 
            this.txtNewStudentLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentLastName.Location = new System.Drawing.Point(127, 62);
            this.txtNewStudentLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentLastName.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtNewStudentLastName.Name = "txtNewStudentLastName";
            this.txtNewStudentLastName.ShortcutsEnabled = false;
            this.txtNewStudentLastName.Size = new System.Drawing.Size(124, 26);
            this.txtNewStudentLastName.TabIndex = 1;
            this.txtNewStudentLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtNewStudentLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtNewStudentFirstName
            // 
            this.txtNewStudentFirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentFirstName.Location = new System.Drawing.Point(127, 23);
            this.txtNewStudentFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentFirstName.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtNewStudentFirstName.Name = "txtNewStudentFirstName";
            this.txtNewStudentFirstName.ShortcutsEnabled = false;
            this.txtNewStudentFirstName.Size = new System.Drawing.Size(124, 26);
            this.txtNewStudentFirstName.TabIndex = 0;
            this.txtNewStudentFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtNewStudentFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblAddStudentLast
            // 
            this.lblAddStudentLast.AutoSize = true;
            this.lblAddStudentLast.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentLast.Location = new System.Drawing.Point(5, 67);
            this.lblAddStudentLast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentLast.Name = "lblAddStudentLast";
            this.lblAddStudentLast.Size = new System.Drawing.Size(39, 21);
            this.lblAddStudentLast.TabIndex = 5;
            this.lblAddStudentLast.Text = "Last";
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtNewStudentGrade);
            this.gbxInfo.Controls.Add(this.dtpAddStudentDOB);
            this.gbxInfo.Controls.Add(this.lblAddStudentDOB);
            this.gbxInfo.Controls.Add(this.lblAddStudentGrade);
            this.gbxInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(12, 261);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInfo.Size = new System.Drawing.Size(268, 107);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Info";
            // 
            // txtNewStudentGrade
            // 
            this.txtNewStudentGrade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStudentGrade.Location = new System.Drawing.Point(82, 24);
            this.txtNewStudentGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStudentGrade.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NameLengthMax;
            this.txtNewStudentGrade.Name = "txtNewStudentGrade";
            this.txtNewStudentGrade.ShortcutsEnabled = false;
            this.txtNewStudentGrade.Size = new System.Drawing.Size(56, 26);
            this.txtNewStudentGrade.TabIndex = 0;
            this.txtNewStudentGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddStudentGrade_KeyPress);
            // 
            // dtpAddStudentDOB
            // 
            this.dtpAddStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddStudentDOB.Location = new System.Drawing.Point(82, 61);
            this.dtpAddStudentDOB.Name = "dtpAddStudentDOB";
            this.dtpAddStudentDOB.Size = new System.Drawing.Size(144, 26);
            this.dtpAddStudentDOB.TabIndex = 1;
            this.dtpAddStudentDOB.Validating += new System.ComponentModel.CancelEventHandler(this.dtpAddStudentDOB_Validating);
            // 
            // lblAddStudentDOB
            // 
            this.lblAddStudentDOB.AutoSize = true;
            this.lblAddStudentDOB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentDOB.Location = new System.Drawing.Point(5, 64);
            this.lblAddStudentDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentDOB.Name = "lblAddStudentDOB";
            this.lblAddStudentDOB.Size = new System.Drawing.Size(40, 21);
            this.lblAddStudentDOB.TabIndex = 11;
            this.lblAddStudentDOB.Text = "DOB";
            // 
            // lblAddStudentGrade
            // 
            this.lblAddStudentGrade.AutoSize = true;
            this.lblAddStudentGrade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentGrade.Location = new System.Drawing.Point(5, 29);
            this.lblAddStudentGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentGrade.Name = "lblAddStudentGrade";
            this.lblAddStudentGrade.Size = new System.Drawing.Size(51, 21);
            this.lblAddStudentGrade.TabIndex = 9;
            this.lblAddStudentGrade.Text = "Grade";
            // 
            // ttFrmAdmin
            // 
            this.ttFrmAdmin.IsBalloon = true;
            // 
            // fdAdmin
            // 
            this.fdAdmin.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.fdAdmin.FontMustExist = true;
            this.fdAdmin.MaxSize = 20;
            this.fdAdmin.MinSize = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontLarge;
            this.lblTitle.Location = new System.Drawing.Point(108, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Admin Control";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblWelcome.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblWelcome.Location = new System.Drawing.Point(110, 53);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(73, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAdminName.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblAdminName.Location = new System.Drawing.Point(187, 53);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(113, 20);
            this.lblAdminName.TabIndex = 6;
            this.lblAdminName.Text = "<ADMIN NAME>";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastLogin.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblLastLogin.Location = new System.Drawing.Point(987, 24);
            this.lblLastLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(79, 20);
            this.lblLastLogin.TabIndex = 7;
            this.lblLastLogin.Text = "Last Login:";
            // 
            // lblLoginDate
            // 
            this.lblLoginDate.AutoSize = true;
            this.lblLoginDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLoginDate.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblLoginDate.Location = new System.Drawing.Point(1068, 24);
            this.lblLoginDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginDate.Name = "lblLoginDate";
            this.lblLoginDate.Size = new System.Drawing.Size(180, 20);
            this.lblLoginDate.TabIndex = 8;
            this.lblLoginDate.Text = " MM/DD/YYYY HH:MM PM";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCurrentTime.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblCurrentTime.Location = new System.Drawing.Point(1010, 4);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentTime.Size = new System.Drawing.Size(240, 20);
            this.lblCurrentTime.TabIndex = 9;
            this.lblCurrentTime.Text = "Wednesday, Dec dd, yyyy hh:mm pm";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProviderNewUser
            // 
            this.errorProviderNewUser.ContainerControl = this;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.BackColor = System.Drawing.Color.Lavender;
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.problemSetToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripAdmin.Size = new System.Drawing.Size(1264, 24);
            this.menuStripAdmin.TabIndex = 10;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentReportToolStripMenuItem,
            this.printSummaryToolStripMenuItem,
            this.printStudentDetailToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(16, 0, 4, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = "&Reports";
            // 
            // parentReportToolStripMenuItem
            // 
            this.parentReportToolStripMenuItem.Name = "parentReportToolStripMenuItem";
            this.parentReportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.parentReportToolStripMenuItem.Text = "&Parent Report";
            // 
            // printSummaryToolStripMenuItem
            // 
            this.printSummaryToolStripMenuItem.Name = "printSummaryToolStripMenuItem";
            this.printSummaryToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.printSummaryToolStripMenuItem.Text = "&Summary Report";
            // 
            // printStudentDetailToolStripMenuItem
            // 
            this.printStudentDetailToolStripMenuItem.Name = "printStudentDetailToolStripMenuItem";
            this.printStudentDetailToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.printStudentDetailToolStripMenuItem.Text = "Student &Detail Report";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.importStudentsToolStripMenuItem,
            this.modifyStudentsToolStripMenuItem,
            this.removeStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "&Students";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addUserToolStripMenuItem.Text = "&Add User";
            // 
            // importStudentsToolStripMenuItem
            // 
            this.importStudentsToolStripMenuItem.Name = "importStudentsToolStripMenuItem";
            this.importStudentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importStudentsToolStripMenuItem.Text = "&Import Students";
            // 
            // modifyStudentsToolStripMenuItem
            // 
            this.modifyStudentsToolStripMenuItem.Name = "modifyStudentsToolStripMenuItem";
            this.modifyStudentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.modifyStudentsToolStripMenuItem.Text = "&Edit Student";
            this.modifyStudentsToolStripMenuItem.Click += new System.EventHandler(this.modifyStudentsToolStripMenuItem_Click);
            // 
            // removeStudentsToolStripMenuItem
            // 
            this.removeStudentsToolStripMenuItem.Name = "removeStudentsToolStripMenuItem";
            this.removeStudentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeStudentsToolStripMenuItem.Text = "&Remove Student(s)";
            // 
            // problemSetToolStripMenuItem
            // 
            this.problemSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProblemSetToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.problemSetToolStripMenuItem.Name = "problemSetToolStripMenuItem";
            this.problemSetToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.problemSetToolStripMenuItem.Text = "&Problem Set";
            // 
            // addProblemSetToolStripMenuItem
            // 
            this.addProblemSetToolStripMenuItem.Name = "addProblemSetToolStripMenuItem";
            this.addProblemSetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addProblemSetToolStripMenuItem.Text = "&Add Problem Set";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeToolStripMenuItem.Text = "&Remove Problem Set";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemSetDefaultsToolStripMenuItem,
            this.mathDrillSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // problemSetDefaultsToolStripMenuItem
            // 
            this.problemSetDefaultsToolStripMenuItem.Name = "problemSetDefaultsToolStripMenuItem";
            this.problemSetDefaultsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.problemSetDefaultsToolStripMenuItem.Text = "&Problem Set Defaults";
            // 
            // mathDrillSettingsToolStripMenuItem
            // 
            this.mathDrillSettingsToolStripMenuItem.Name = "mathDrillSettingsToolStripMenuItem";
            this.mathDrillSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mathDrillSettingsToolStripMenuItem.Text = "Math Drill Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_4;
            this.pbxLogo.Location = new System.Drawing.Point(0, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(103, 100);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(1128, 649);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.lblCurrentTime);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.lblLoginDate);
            this.panel1.Controls.Add(this.lblLastLogin);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 107);
            this.panel1.TabIndex = 15;
            // 
            // frmAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbcAdmin);
            this.Controls.Add(this.menuStripAdmin);
            this.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAdmin;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAdminControl";
            this.Text = "Math Monkeys - Admin Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminControl_FormClosing);
            this.tbcAdmin.ResumeLayout(false);
            this.tbpReports.ResumeLayout(false);
            this.gbxProgressReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.gbxReportDate.ResumeLayout(false);
            this.gbxReportDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tbpAssignments.ResumeLayout(false);
            this.gbxAssignProblemSet.ResumeLayout(false);
            this.gbxAssignProblemSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).EndInit();
            this.tbpStudents.ResumeLayout(false);
            this.gbxRemoveStudent.ResumeLayout(false);
            this.gbxRemoveStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveStudent)).EndInit();
            this.gbxRemoveStudentInfo.ResumeLayout(false);
            this.gbxRemoveStudentInfo.PerformLayout();
            this.gbxRemoveStudentName.ResumeLayout(false);
            this.gbxRemoveStudentName.PerformLayout();
            this.gbxAddStudent.ResumeLayout(false);
            this.gbxAddStudent.PerformLayout();
            this.gbxAddStudentName.ResumeLayout(false);
            this.gbxAddStudentName.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.TabPage tbpReports;
        private System.Windows.Forms.TabPage tbpAssignments;
        private System.Windows.Forms.ToolTip ttFrmAdmin;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TabPage tbpStudents;
        private System.Windows.Forms.FontDialog fdAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblLoginDate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.ErrorProvider errorProviderNewUser;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrShowLabel;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxProgressReport;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox gbxReportDate;
        private System.Windows.Forms.GroupBox gbxAddStudent;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.GroupBox gbxAddStudentName;
        private System.Windows.Forms.TextBox txtNewStudentScreenName;
        private System.Windows.Forms.Label lblAddStudentScreen;
        private System.Windows.Forms.Label lblAddStudentFirst;
        private System.Windows.Forms.TextBox txtNewStudentLastName;
        private System.Windows.Forms.TextBox txtNewStudentFirstName;
        private System.Windows.Forms.Label lblAddStudentLast;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label lblAddStudentDOB;
        private System.Windows.Forms.Label lblAddStudentGrade;
        private System.Windows.Forms.GroupBox gbxAssignProblemSet;
        private System.Windows.Forms.ListBox lbxAssigned;
        private System.Windows.Forms.ListBox lbxAvailable;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.GroupBox gbxRemoveStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMoveAssignedDown;
        private System.Windows.Forms.Button btnMoveAssignedUp;
        private System.Windows.Forms.Button btnRemoveAssigned;
        private System.Windows.Forms.Button btnAssignProblemSet;
        private System.Windows.Forms.TextBox txtNewStudentPassword;
        private System.Windows.Forms.Label lblAddStudentPassword;
        private System.Windows.Forms.ToolStripMenuItem parentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printStudentDetailToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxRemoveStudentInfo;
        private System.Windows.Forms.TextBox txtRemoveStudentGrade;
        private System.Windows.Forms.Label lblRemoveStudentDOB;
        private System.Windows.Forms.Label lblRemoveStudentGrade;
        private System.Windows.Forms.GroupBox gbxRemoveStudentName;
        private System.Windows.Forms.TextBox txtRemoveStudentVerifyPassword;
        private System.Windows.Forms.Label lblRemoveStudentPassword;
        private System.Windows.Forms.Label lblRemoveStudentVerifyPassword;
        private System.Windows.Forms.TextBox txtRemoveStudentPassword;
        private System.Windows.Forms.TextBox txtRemoveStudentScreen;
        private System.Windows.Forms.Label lblRemoveStudentScreen;
        private System.Windows.Forms.Label lblRemoveStudentFirst;
        private System.Windows.Forms.TextBox txtRemoveStudentLast;
        private System.Windows.Forms.TextBox txtRemoveStudentFirst;
        private System.Windows.Forms.Label lblRemoveStudentLast;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.TextBox txtNewStudentVerifyPassword;
        private System.Windows.Forms.Label lblAddStudentVerifyPassword;
        private System.Windows.Forms.DateTimePicker dtpAddStudentDOB;
        private System.Windows.Forms.DateTimePicker dtpRemoveDOB;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.DataGridView dgvAssignStudents;
        private System.Windows.Forms.DataGridView dgvRemoveStudent;
        private System.Windows.Forms.BindingSource problemSetBindingSource;
        private System.Windows.Forms.TextBox txtNewStudentGrade;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.BindingSource incompletedAssignmentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.BindingSource assignmentsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemSetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAssignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAttemptsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAttemptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemSetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fastestTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProblemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemSetDefaultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathDrillSettingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}