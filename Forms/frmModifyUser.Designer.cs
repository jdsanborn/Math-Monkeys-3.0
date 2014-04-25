namespace Math_Monkeys.Forms
{
    partial class frmModifyUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifySelectedUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelModifyUser = new System.Windows.Forms.Button();
            this.dtgModifyUser = new System.Windows.Forms.DataGridView();
            this.getFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select User to Modify";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modify Selected User";
            // 
            // btnModifySelectedUser
            // 
            this.btnModifySelectedUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.edit_user;
            this.btnModifySelectedUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifySelectedUser.FlatAppearance.BorderSize = 0;
            this.btnModifySelectedUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModifySelectedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifySelectedUser.Location = new System.Drawing.Point(322, 439);
            this.btnModifySelectedUser.Name = "btnModifySelectedUser";
            this.btnModifySelectedUser.Size = new System.Drawing.Size(95, 32);
            this.btnModifySelectedUser.TabIndex = 1;
            this.btnModifySelectedUser.UseVisualStyleBackColor = true;
            this.btnModifySelectedUser.Click += new System.EventHandler(this.ButtonPressEvent_ModifySelectedUser);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cancel";
            // 
            // btnCancelModifyUser
            // 
            this.btnCancelModifyUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.fileclose;
            this.btnCancelModifyUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelModifyUser.FlatAppearance.BorderSize = 0;
            this.btnCancelModifyUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelModifyUser.Location = new System.Drawing.Point(225, 439);
            this.btnCancelModifyUser.Name = "btnCancelModifyUser";
            this.btnCancelModifyUser.Size = new System.Drawing.Size(32, 32);
            this.btnCancelModifyUser.TabIndex = 2;
            this.btnCancelModifyUser.UseVisualStyleBackColor = true;
            this.btnCancelModifyUser.Click += new System.EventHandler(this.ButtonPressEvent_CancelModifyUser);
            // 
            // dtgModifyUser
            // 
            this.dtgModifyUser.AllowUserToDeleteRows = false;
            this.dtgModifyUser.AutoGenerateColumns = false;
            this.dtgModifyUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgModifyUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getFullNameDataGridViewTextBoxColumn,
            this.ScreenName,
            this.Grade});
            this.dtgModifyUser.DataSource = this.studentBindingSource;
            this.dtgModifyUser.Location = new System.Drawing.Point(7, 20);
            this.dtgModifyUser.MultiSelect = false;
            this.dtgModifyUser.Name = "dtgModifyUser";
            this.dtgModifyUser.ReadOnly = true;
            this.dtgModifyUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgModifyUser.Size = new System.Drawing.Size(410, 413);
            this.dtgModifyUser.TabIndex = 0;
            this.dtgModifyUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonPressEvent_ModifySelectedUser);
            // 
            // getFullNameDataGridViewTextBoxColumn
            // 
            this.getFullNameDataGridViewTextBoxColumn.DataPropertyName = "GetFullName";
            this.getFullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.getFullNameDataGridViewTextBoxColumn.Name = "getFullNameDataGridViewTextBoxColumn";
            this.getFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.getFullNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // ScreenName
            // 
            this.ScreenName.DataPropertyName = "ScreenName";
            this.ScreenName.HeaderText = "Screen Name";
            this.ScreenName.Name = "ScreenName";
            this.ScreenName.ReadOnly = true;
            this.ScreenName.Width = 140;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 85;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.AllowNew = false;
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // frmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 491);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifySelectedUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelModifyUser);
            this.Controls.Add(this.dtgModifyUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify User";
            this.Activated += new System.EventHandler(this.FormActivatedEvent_ModifyUserForm);
            this.Load += new System.EventHandler(this.LoadEvent_ModifyUserForm);
            ((System.ComponentModel.ISupportInitialize)(this.dtgModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifySelectedUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelModifyUser;
        private System.Windows.Forms.DataGridView dtgModifyUser;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn getFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}