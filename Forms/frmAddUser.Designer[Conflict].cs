namespace Math_Monkeys.Forms
{
    partial class frmAddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtNewStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtNewStudentLastName = new System.Windows.Forms.TextBox();
            this.txtNewStudentScreenName = new System.Windows.Forms.TextBox();
            this.txtNewStudentPassword = new System.Windows.Forms.TextBox();
            this.txtNewStudentVerifyPassword = new System.Windows.Forms.TextBox();
            this.txtNewStudentGrade = new System.Windows.Forms.TextBox();
            this.dtpAddStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCancelAddUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderNewUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Screen Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Re-Enter Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Birthdate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Class:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(62, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(209, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Adminstrator";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtNewStudentFirstName
            // 
            this.txtNewStudentFirstName.Location = new System.Drawing.Point(125, 68);
            this.txtNewStudentFirstName.MaxLength = 30;
            this.txtNewStudentFirstName.Name = "txtNewStudentFirstName";
            this.txtNewStudentFirstName.ShortcutsEnabled = false;
            this.txtNewStudentFirstName.Size = new System.Drawing.Size(282, 20);
            this.txtNewStudentFirstName.TabIndex = 1;
            this.txtNewStudentFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewStudentFirstName_KeyPress);
            // 
            // txtNewStudentLastName
            // 
            this.txtNewStudentLastName.Location = new System.Drawing.Point(125, 94);
            this.txtNewStudentLastName.Name = "txtNewStudentLastName";
            this.txtNewStudentLastName.Size = new System.Drawing.Size(282, 20);
            this.txtNewStudentLastName.TabIndex = 2;
            // 
            // txtNewStudentScreenName
            // 
            this.txtNewStudentScreenName.Location = new System.Drawing.Point(125, 120);
            this.txtNewStudentScreenName.Name = "txtNewStudentScreenName";
            this.txtNewStudentScreenName.Size = new System.Drawing.Size(282, 20);
            this.txtNewStudentScreenName.TabIndex = 3;
            // 
            // txtNewStudentPassword
            // 
            this.txtNewStudentPassword.Location = new System.Drawing.Point(125, 146);
            this.txtNewStudentPassword.Name = "txtNewStudentPassword";
            this.txtNewStudentPassword.Size = new System.Drawing.Size(152, 20);
            this.txtNewStudentPassword.TabIndex = 4;
            this.txtNewStudentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewStudentVerifyPassword
            // 
            this.txtNewStudentVerifyPassword.Location = new System.Drawing.Point(125, 172);
            this.txtNewStudentVerifyPassword.Name = "txtNewStudentVerifyPassword";
            this.txtNewStudentVerifyPassword.Size = new System.Drawing.Size(152, 20);
            this.txtNewStudentVerifyPassword.TabIndex = 5;
            this.txtNewStudentVerifyPassword.UseSystemPasswordChar = true;
            // 
            // txtNewStudentGrade
            // 
            this.txtNewStudentGrade.Location = new System.Drawing.Point(125, 198);
            this.txtNewStudentGrade.Name = "txtNewStudentGrade";
            this.txtNewStudentGrade.Size = new System.Drawing.Size(282, 20);
            this.txtNewStudentGrade.TabIndex = 6;
            // 
            // dtpAddStudentDOB
            // 
            this.dtpAddStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddStudentDOB.Location = new System.Drawing.Point(125, 224);
            this.dtpAddStudentDOB.Name = "dtpAddStudentDOB";
            this.dtpAddStudentDOB.Size = new System.Drawing.Size(121, 20);
            this.dtpAddStudentDOB.TabIndex = 7;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.add_user;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Location = new System.Drawing.Point(361, 283);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(32, 32);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.add_user1;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(290, 283);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(32, 32);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.ButtonAddUserClicked);
            // 
            // btnCancelAddUser
            // 
            this.btnCancelAddUser.BackgroundImage = global::Math_Monkeys.Properties.Resources.fileclose;
            this.btnCancelAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelAddUser.FlatAppearance.BorderSize = 0;
            this.btnCancelAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddUser.Location = new System.Drawing.Point(231, 283);
            this.btnCancelAddUser.Name = "btnCancelAddUser";
            this.btnCancelAddUser.Size = new System.Drawing.Size(32, 32);
            this.btnCancelAddUser.TabIndex = 10;
            this.btnCancelAddUser.UseVisualStyleBackColor = true;
            this.btnCancelAddUser.Click += new System.EventHandler(this.ButtonCancelAddUserClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cancel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Add";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Add && New";
            // 
            // errorProviderNewUser
            // 
            this.errorProviderNewUser.ContainerControl = this;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 346);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelAddUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dtpAddStudentDOB);
            this.Controls.Add(this.txtNewStudentGrade);
            this.Controls.Add(this.txtNewStudentVerifyPassword);
            this.Controls.Add(this.txtNewStudentPassword);
            this.Controls.Add(this.txtNewStudentScreenName);
            this.Controls.Add(this.txtNewStudentLastName);
            this.Controls.Add(this.txtNewStudentFirstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtNewStudentFirstName;
        private System.Windows.Forms.TextBox txtNewStudentLastName;
        private System.Windows.Forms.TextBox txtNewStudentScreenName;
        private System.Windows.Forms.TextBox txtNewStudentPassword;
        private System.Windows.Forms.TextBox txtNewStudentVerifyPassword;
        private System.Windows.Forms.TextBox txtNewStudentGrade;
        private System.Windows.Forms.DateTimePicker dtpAddStudentDOB;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancelAddUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderNewUser;
    }
}