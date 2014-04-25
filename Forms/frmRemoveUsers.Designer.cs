namespace Math_Monkeys.Forms
{
    partial class frmRemoveUsers
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
            this.dtgRemoveUsers = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelRemoveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveSelectedUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRemoveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRemoveUsers
            // 
            this.dtgRemoveUsers.AllowUserToDeleteRows = false;
            this.dtgRemoveUsers.AutoGenerateColumns = false;
            this.dtgRemoveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRemoveUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getFullNameDataGridViewTextBoxColumn,
            this.screenNameDataGridViewTextBoxColumn,
            this.Grade});
            this.dtgRemoveUsers.DataSource = this.studentBindingSource;
            this.dtgRemoveUsers.Location = new System.Drawing.Point(12, 25);
            this.dtgRemoveUsers.Name = "dtgRemoveUsers";
            this.dtgRemoveUsers.ReadOnly = true;
            this.dtgRemoveUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRemoveUsers.Size = new System.Drawing.Size(410, 413);
            this.dtgRemoveUsers.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cancel";
            // 
            // btnCancelRemoveUser
            // 
            this.btnCancelRemoveUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.fileclose;
            this.btnCancelRemoveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnCancelRemoveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRemoveUser.Location = new System.Drawing.Point(230, 444);
            this.btnCancelRemoveUser.Name = "btnCancelRemoveUser";
            this.btnCancelRemoveUser.Size = new System.Drawing.Size(32, 32);
            this.btnCancelRemoveUser.TabIndex = 3;
            this.btnCancelRemoveUser.UseVisualStyleBackColor = true;
            this.btnCancelRemoveUser.Click += new System.EventHandler ( this.ButtonPressEvent_CancelRemoveUser );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Remove Selected User(s)";
            // 
            // btnRemoveSelectedUsers
            // 
            this.btnRemoveSelectedUsers.BackgroundImage = global::Math_Monkeys.Properties.Resources.delete_user;
            this.btnRemoveSelectedUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveSelectedUsers.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveSelectedUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedUsers.Location = new System.Drawing.Point(301, 444);
            this.btnRemoveSelectedUsers.Name = "btnRemoveSelectedUsers";
            this.btnRemoveSelectedUsers.Size = new System.Drawing.Size(121, 32);
            this.btnRemoveSelectedUsers.TabIndex = 2;
            this.btnRemoveSelectedUsers.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedUsers.Click += new System.EventHandler ( this.ButtonPressEvent_RemoveSelectedUser );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select User(s) to Remove:";
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 87;
            // 
            // screenNameDataGridViewTextBoxColumn
            // 
            this.screenNameDataGridViewTextBoxColumn.DataPropertyName = "ScreenName";
            this.screenNameDataGridViewTextBoxColumn.HeaderText = "Screen Name";
            this.screenNameDataGridViewTextBoxColumn.Name = "screenNameDataGridViewTextBoxColumn";
            this.screenNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.screenNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // getFullNameDataGridViewTextBoxColumn
            // 
            this.getFullNameDataGridViewTextBoxColumn.DataPropertyName = "GetFullName";
            this.getFullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.getFullNameDataGridViewTextBoxColumn.Name = "getFullNameDataGridViewTextBoxColumn";
            this.getFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.getFullNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.AllowNew = false;
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // frmRemoveUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveSelectedUsers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelRemoveUser);
            this.Controls.Add(this.dtgRemoveUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRemoveUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove User(s)";
            this.Load += new System.EventHandler ( this.LoadEvent_RemoveUserForm );
            ((System.ComponentModel.ISupportInitialize)(this.dtgRemoveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRemoveUsers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelRemoveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveSelectedUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn getFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}