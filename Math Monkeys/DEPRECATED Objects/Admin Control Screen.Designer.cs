namespace Math_Monkeys
{
    partial class Admin_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Control));
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnCreateNewStudent = new System.Windows.Forms.Button();
            this.ddlAdminSelects = new System.Windows.Forms.ComboBox();
            this.btnAssignNew = new System.Windows.Forms.Button();
            this.btnViewProgress = new System.Windows.Forms.Button();
            this.dtgAdministrator = new System.Windows.Forms.DataGridView();
            this.clmAssignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWelcomAdmin = new System.Windows.Forms.Label();
            this.lblLastAdminLogin = new System.Windows.Forms.Label();
            this.btnLogOutAdmin = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnChangeProblem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdministrator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(12, 468);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(186, 24);
            this.btnRemoveSelected.TabIndex = 0;
            this.btnRemoveSelected.Text = "Remove Selected  Student";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnCreateNewStudent
            // 
            this.btnCreateNewStudent.Location = new System.Drawing.Point(13, 416);
            this.btnCreateNewStudent.Name = "btnCreateNewStudent";
            this.btnCreateNewStudent.Size = new System.Drawing.Size(186, 46);
            this.btnCreateNewStudent.TabIndex = 1;
            this.btnCreateNewStudent.Text = "Create New Student";
            this.btnCreateNewStudent.UseVisualStyleBackColor = true;
            this.btnCreateNewStudent.Click += new System.EventHandler(this.btnCreateNewStudent_Click);
            // 
            // ddlAdminSelects
            // 
            this.ddlAdminSelects.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.ddlAdminSelects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ddlAdminSelects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAdminSelects.FormattingEnabled = true;
            this.ddlAdminSelects.Location = new System.Drawing.Point(11, 51);
            this.ddlAdminSelects.Name = "ddlAdminSelects";
            this.ddlAdminSelects.Size = new System.Drawing.Size(186, 21);
            this.ddlAdminSelects.TabIndex = 2;
            // 
            // btnAssignNew
            // 
            this.btnAssignNew.Location = new System.Drawing.Point(11, 258);
            this.btnAssignNew.Name = "btnAssignNew";
            this.btnAssignNew.Size = new System.Drawing.Size(186, 50);
            this.btnAssignNew.TabIndex = 3;
            this.btnAssignNew.Text = "Assign New Problem Set to Selected Student";
            this.btnAssignNew.UseVisualStyleBackColor = true;
            this.btnAssignNew.Click += new System.EventHandler(this.btnAssignNew_Click);
            // 
            // btnViewProgress
            // 
            this.btnViewProgress.Location = new System.Drawing.Point(11, 81);
            this.btnViewProgress.Name = "btnViewProgress";
            this.btnViewProgress.Size = new System.Drawing.Size(186, 55);
            this.btnViewProgress.TabIndex = 5;
            this.btnViewProgress.Text = "View Student Progess";
            this.btnViewProgress.UseVisualStyleBackColor = true;
            this.btnViewProgress.Click += new System.EventHandler(this.btnViewProgress_Click);
            // 
            // dtgAdministrator
            // 
            this.dtgAdministrator.AllowDrop = true;
            this.dtgAdministrator.AllowUserToAddRows = false;
            this.dtgAdministrator.AllowUserToDeleteRows = false;
            this.dtgAdministrator.AllowUserToOrderColumns = true;
            this.dtgAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAdministrator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAdministrator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAssignment,
            this.clmCompleted,
            this.clmGoal,
            this.clmGrade,
            this.clmDate});
            this.dtgAdministrator.Location = new System.Drawing.Point(223, 51);
            this.dtgAdministrator.Name = "dtgAdministrator";
            this.dtgAdministrator.ReadOnly = true;
            this.dtgAdministrator.Size = new System.Drawing.Size(869, 670);
            this.dtgAdministrator.TabIndex = 6;
            this.dtgAdministrator.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAdministrator_CellContentClick);
            // 
            // clmAssignment
            // 
            this.clmAssignment.HeaderText = "Assignment";
            this.clmAssignment.MaxInputLength = 30;
            this.clmAssignment.Name = "clmAssignment";
            this.clmAssignment.ReadOnly = true;
            // 
            // clmCompleted
            // 
            this.clmCompleted.HeaderText = "Completed";
            this.clmCompleted.MaxInputLength = 30;
            this.clmCompleted.Name = "clmCompleted";
            this.clmCompleted.ReadOnly = true;
            // 
            // clmGoal
            // 
            this.clmGoal.HeaderText = "Goal";
            this.clmGoal.MaxInputLength = 30;
            this.clmGoal.Name = "clmGoal";
            this.clmGoal.ReadOnly = true;
            // 
            // clmGrade
            // 
            this.clmGrade.HeaderText = "Percent Correct";
            this.clmGrade.MaxInputLength = 30;
            this.clmGrade.Name = "clmGrade";
            this.clmGrade.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.MaxInputLength = 30;
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // lblWelcomAdmin
            // 
            this.lblWelcomAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcomAdmin.AutoSize = true;
            this.lblWelcomAdmin.Location = new System.Drawing.Point(434, 27);
            this.lblWelcomAdmin.Name = "lblWelcomAdmin";
            this.lblWelcomAdmin.Size = new System.Drawing.Size(90, 13);
            this.lblWelcomAdmin.TabIndex = 10;
            this.lblWelcomAdmin.Text = "Welcome ADMIN";
            // 
            // lblLastAdminLogin
            // 
            this.lblLastAdminLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastAdminLogin.AutoSize = true;
            this.lblLastAdminLogin.Location = new System.Drawing.Point(774, 27);
            this.lblLastAdminLogin.Name = "lblLastAdminLogin";
            this.lblLastAdminLogin.Size = new System.Drawing.Size(191, 13);
            this.lblLastAdminLogin.TabIndex = 11;
            this.lblLastAdminLogin.Text = "Last Login: DAY MONTH YEAR, TIME";
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOutAdmin.Location = new System.Drawing.Point(988, 12);
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.Size = new System.Drawing.Size(111, 33);
            this.btnLogOutAdmin.TabIndex = 12;
            this.btnLogOutAdmin.Text = "Log Out";
            this.btnLogOutAdmin.UseVisualStyleBackColor = true;
            this.btnLogOutAdmin.Click += new System.EventHandler(this.btnLogOutAdmin_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // btnChangeProblem
            // 
            this.btnChangeProblem.Location = new System.Drawing.Point(12, 314);
            this.btnChangeProblem.Name = "btnChangeProblem";
            this.btnChangeProblem.Size = new System.Drawing.Size(186, 50);
            this.btnChangeProblem.TabIndex = 17;
            this.btnChangeProblem.Text = "Change Assigned Problem Sets and/or Settings";
            this.btnChangeProblem.UseVisualStyleBackColor = true;
            this.btnChangeProblem.Click += new System.EventHandler(this.btnChangeProblem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Student Selection";
            // 
            // Admin_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeProblem);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnLogOutAdmin);
            this.Controls.Add(this.lblLastAdminLogin);
            this.Controls.Add(this.lblWelcomAdmin);
            this.Controls.Add(this.dtgAdministrator);
            this.Controls.Add(this.btnViewProgress);
            this.Controls.Add(this.btnAssignNew);
            this.Controls.Add(this.ddlAdminSelects);
            this.Controls.Add(this.btnCreateNewStudent);
            this.Controls.Add(this.btnRemoveSelected);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1129, 726);
            this.Name = "Admin_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Admin Control";
            this.Load += new System.EventHandler(this.Admin_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdministrator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnCreateNewStudent;
        private System.Windows.Forms.ComboBox ddlAdminSelects;
        private System.Windows.Forms.Button btnAssignNew;
        private System.Windows.Forms.Button btnViewProgress;
        private System.Windows.Forms.DataGridView dtgAdministrator;
        private System.Windows.Forms.Label lblWelcomAdmin;
        private System.Windows.Forms.Label lblLastAdminLogin;
        private System.Windows.Forms.Button btnLogOutAdmin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnChangeProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
    }
}