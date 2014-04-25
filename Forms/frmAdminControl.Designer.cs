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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminControl));
            this.assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incompletedAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.problemSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.assignProblemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemSetDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathDrillSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlGreeting = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlGreeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentsBindingSource
            // 
            this.assignmentsBindingSource.DataMember = "Assignments";
            this.assignmentsBindingSource.DataSource = this.studentBindingSource;
            // 
            // incompletedAssignmentsBindingSource
            // 
            this.incompletedAssignmentsBindingSource.DataMember = "IncompletedAssignments";
            this.incompletedAssignmentsBindingSource.DataSource = this.studentBindingSource;
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
            this.lblTitle.Size = new System.Drawing.Size(160, 30);
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
            this.lblAdminName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "GetFullName", true));
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
            this.lblLastLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblLoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginDate.AutoSize = true;
            this.lblLoginDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLoginDate.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblLoginDate.Location = new System.Drawing.Point(1080, 24);
            this.lblLoginDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginDate.Name = "lblLoginDate";
            this.lblLoginDate.Size = new System.Drawing.Size(180, 20);
            this.lblLoginDate.TabIndex = 8;
            this.lblLoginDate.Text = " MM/DD/YYYY HH:MM PM";
            this.lblLoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCurrentTime.Font = global::Math_Monkeys.Properties.Settings.Default.AdminFontNormal;
            this.lblCurrentTime.Location = new System.Drawing.Point(1018, 4);
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
            this.menuStripAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripAdmin_MouseMove);
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
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            this.parentReportToolStripMenuItem.Click += new System.EventHandler(this.parentReportToolStripMenuItem_Click);
            // 
            // printSummaryToolStripMenuItem
            // 
            this.printSummaryToolStripMenuItem.Name = "printSummaryToolStripMenuItem";
            this.printSummaryToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.printSummaryToolStripMenuItem.Text = "&Summary Report";
            this.printSummaryToolStripMenuItem.Click += new System.EventHandler(this.printSummaryToolStripMenuItem_Click);
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
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddUserClicked);
            // 
            // importStudentsToolStripMenuItem
            // 
            this.importStudentsToolStripMenuItem.Enabled = false;
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
            this.removeStudentsToolStripMenuItem.Click += new System.EventHandler(this.removeStudentsToolStripMenuItem_Click);
            // 
            // problemSetToolStripMenuItem
            // 
            this.problemSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProblemSetToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.assignProblemSetToolStripMenuItem});
            this.problemSetToolStripMenuItem.Name = "problemSetToolStripMenuItem";
            this.problemSetToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.problemSetToolStripMenuItem.Text = "&Problem Set";
            // 
            // addProblemSetToolStripMenuItem
            // 
            this.addProblemSetToolStripMenuItem.Name = "addProblemSetToolStripMenuItem";
            this.addProblemSetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addProblemSetToolStripMenuItem.Text = "&Add Problem Set";
            this.addProblemSetToolStripMenuItem.Click += new System.EventHandler(this.addProblemSetToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeToolStripMenuItem.Text = "&Remove Problem Set";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // assignProblemSetToolStripMenuItem
            // 
            this.assignProblemSetToolStripMenuItem.Name = "assignProblemSetToolStripMenuItem";
            this.assignProblemSetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.assignProblemSetToolStripMenuItem.Text = "A&ssign Problem set";
            this.assignProblemSetToolStripMenuItem.Click += new System.EventHandler(this.assignProblemSetToolStripMenuItem_Click);
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
            this.problemSetDefaultsToolStripMenuItem.Click += new System.EventHandler(this.problemSetDefaultsToolStripMenuItem_Click);
            // 
            // mathDrillSettingsToolStripMenuItem
            // 
            this.mathDrillSettingsToolStripMenuItem.Name = "mathDrillSettingsToolStripMenuItem";
            this.mathDrillSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mathDrillSettingsToolStripMenuItem.Text = "Math Drill Settings";
            this.mathDrillSettingsToolStripMenuItem.Click += new System.EventHandler(this.mathDrillSettingsToolStripMenuItem_Click);
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
            // pnlGreeting
            // 
            this.pnlGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGreeting.Controls.Add(this.lblTitle);
            this.pnlGreeting.Controls.Add(this.pbxLogo);
            this.pnlGreeting.Controls.Add(this.lblCurrentTime);
            this.pnlGreeting.Controls.Add(this.lblAdminName);
            this.pnlGreeting.Controls.Add(this.lblLoginDate);
            this.pnlGreeting.Controls.Add(this.lblLastLogin);
            this.pnlGreeting.Controls.Add(this.lblWelcome);
            this.pnlGreeting.Location = new System.Drawing.Point(0, 27);
            this.pnlGreeting.Margin = new System.Windows.Forms.Padding(3, 3, 3, 300);
            this.pnlGreeting.Name = "pnlGreeting";
            this.pnlGreeting.Size = new System.Drawing.Size(1260, 107);
            this.pnlGreeting.TabIndex = 15;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogout.Location = new System.Drawing.Point(1167, 669);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 24);
            this.lblLogout.TabIndex = 22;
            this.lblLogout.Text = "Logout";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::Math_Monkeys.Properties.Resources.Log_Out_icon__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1172, 601);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 65);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Math_Monkeys.User);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // frmAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.pnlGreeting);
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
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlGreeting.ResumeLayout(false);
            this.pnlGreeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttFrmAdmin;
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
        private System.Windows.Forms.ToolStripMenuItem parentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printStudentDetailToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.BindingSource problemSetBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource incompletedAssignmentsBindingSource;
        private System.Windows.Forms.BindingSource assignmentsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
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
        private System.Windows.Forms.Panel pnlGreeting;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem assignProblemSetToolStripMenuItem;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}