namespace Math_Monkeys.Forms
{
    partial class frmParentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParentReport));
            this.dtgParentReport = new System.Windows.Forms.DataGridView();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedAssignmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incompleteAssignmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAssignmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getUserTypeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPrint = new System.Windows.Forms.Label();
            this.printDocumentParentReport = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParentReport
            // 
            this.dtgParentReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgParentReport.AutoGenerateColumns = false;
            this.dtgParentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dOBDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.completedAssignmentsDataGridViewTextBoxColumn,
            this.incompleteAssignmentsDataGridViewTextBoxColumn,
            this.totalAssignmentsDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.getUserTypeStringDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.screenNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.getFullNameDataGridViewTextBoxColumn});
            this.dtgParentReport.DataSource = this.studentBindingSource;
            this.dtgParentReport.Location = new System.Drawing.Point(6, 104);
            this.dtgParentReport.Name = "dtgParentReport";
            this.dtgParentReport.Size = new System.Drawing.Size(684, 315);
            this.dtgParentReport.TabIndex = 1;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // completedAssignmentsDataGridViewTextBoxColumn
            // 
            this.completedAssignmentsDataGridViewTextBoxColumn.DataPropertyName = "CompletedAssignments";
            this.completedAssignmentsDataGridViewTextBoxColumn.HeaderText = "CompletedAssignments";
            this.completedAssignmentsDataGridViewTextBoxColumn.Name = "completedAssignmentsDataGridViewTextBoxColumn";
            this.completedAssignmentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incompleteAssignmentsDataGridViewTextBoxColumn
            // 
            this.incompleteAssignmentsDataGridViewTextBoxColumn.DataPropertyName = "IncompleteAssignments";
            this.incompleteAssignmentsDataGridViewTextBoxColumn.HeaderText = "IncompleteAssignments";
            this.incompleteAssignmentsDataGridViewTextBoxColumn.Name = "incompleteAssignmentsDataGridViewTextBoxColumn";
            this.incompleteAssignmentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAssignmentsDataGridViewTextBoxColumn
            // 
            this.totalAssignmentsDataGridViewTextBoxColumn.DataPropertyName = "TotalAssignments";
            this.totalAssignmentsDataGridViewTextBoxColumn.HeaderText = "TotalAssignments";
            this.totalAssignmentsDataGridViewTextBoxColumn.Name = "totalAssignmentsDataGridViewTextBoxColumn";
            this.totalAssignmentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // getUserTypeStringDataGridViewTextBoxColumn
            // 
            this.getUserTypeStringDataGridViewTextBoxColumn.DataPropertyName = "GetUserTypeString";
            this.getUserTypeStringDataGridViewTextBoxColumn.HeaderText = "GetUserTypeString";
            this.getUserTypeStringDataGridViewTextBoxColumn.Name = "getUserTypeStringDataGridViewTextBoxColumn";
            this.getUserTypeStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // screenNameDataGridViewTextBoxColumn
            // 
            this.screenNameDataGridViewTextBoxColumn.DataPropertyName = "ScreenName";
            this.screenNameDataGridViewTextBoxColumn.HeaderText = "ScreenName";
            this.screenNameDataGridViewTextBoxColumn.Name = "screenNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // getFullNameDataGridViewTextBoxColumn
            // 
            this.getFullNameDataGridViewTextBoxColumn.DataPropertyName = "GetFullName";
            this.getFullNameDataGridViewTextBoxColumn.HeaderText = "GetFullName";
            this.getFullNameDataGridViewTextBoxColumn.Name = "getFullNameDataGridViewTextBoxColumn";
            this.getFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 65);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.BackColor = System.Drawing.Color.Transparent;
            this.lblPrint.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrint.Location = new System.Drawing.Point(21, 76);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(48, 24);
            this.lblPrint.TabIndex = 24;
            this.lblPrint.Text = "Print";
            // 
            // printDocumentParentReport
            // 
            this.printDocumentParentReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentParentReport_PrintPage);
            // 
            // frmParentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 400);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.dtgParentReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Location = new System.Drawing.Point(1366, 768);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmParentReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent  Report";
            this.Load += new System.EventHandler(this.frmParentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgParentReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedAssignmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incompleteAssignmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAssignmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getUserTypeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getFullNameDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocumentParentReport;
    }
}