namespace Math_Monkeys.Forms
{
    partial class frmEditUser
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
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpModStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.txtModStudentGrade = new System.Windows.Forms.TextBox();
            this.txtModStudentVerifyPassword = new System.Windows.Forms.TextBox();
            this.txtModStudentPassword = new System.Windows.Forms.TextBox();
            this.txtModStudentScreenName = new System.Windows.Forms.TextBox();
            this.txtModStudentLastName = new System.Windows.Forms.TextBox();
            this.txtModStudentFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Save";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cancel";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Math_Monkeys.Properties.Resources.fileclose;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(322, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.ButtonPressEvent_CancelEditUser);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Math_Monkeys.Properties.Resources.saveUser;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(375, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler ( this.ButtonPressEvent_SaveEditUser );
            // 
            // dtpModStudentDOB
            // 
            this.dtpModStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModStudentDOB.Location = new System.Drawing.Point(125, 233);
            this.dtpModStudentDOB.Name = "dtpModStudentDOB";
            this.dtpModStudentDOB.Size = new System.Drawing.Size(121, 20);
            this.dtpModStudentDOB.TabIndex = 7;
            // 
            // txtModStudentGrade
            // 
            this.txtModStudentGrade.Location = new System.Drawing.Point(125, 207);
            this.txtModStudentGrade.Name = "txtModStudentGrade";
            this.txtModStudentGrade.Size = new System.Drawing.Size(282, 20);
            this.txtModStudentGrade.TabIndex = 6;
            // 
            // txtModStudentVerifyPassword
            // 
            this.txtModStudentVerifyPassword.Location = new System.Drawing.Point(125, 181);
            this.txtModStudentVerifyPassword.Name = "txtModStudentVerifyPassword";
            this.txtModStudentVerifyPassword.Size = new System.Drawing.Size(152, 20);
            this.txtModStudentVerifyPassword.TabIndex = 5;
            this.txtModStudentVerifyPassword.UseSystemPasswordChar = true;
            // 
            // txtModStudentPassword
            // 
            this.txtModStudentPassword.Location = new System.Drawing.Point(125, 155);
            this.txtModStudentPassword.Name = "txtModStudentPassword";
            this.txtModStudentPassword.Size = new System.Drawing.Size(152, 20);
            this.txtModStudentPassword.TabIndex = 4;
            this.txtModStudentPassword.UseSystemPasswordChar = true;
            // 
            // txtModStudentScreenName
            // 
            this.txtModStudentScreenName.Location = new System.Drawing.Point(125, 129);
            this.txtModStudentScreenName.Name = "txtModStudentScreenName";
            this.txtModStudentScreenName.Size = new System.Drawing.Size(282, 20);
            this.txtModStudentScreenName.TabIndex = 3;
            // 
            // txtModStudentLastName
            // 
            this.txtModStudentLastName.Location = new System.Drawing.Point(125, 103);
            this.txtModStudentLastName.Name = "txtModStudentLastName";
            this.txtModStudentLastName.Size = new System.Drawing.Size(282, 20);
            this.txtModStudentLastName.TabIndex = 2;
            // 
            // txtModStudentFirstName
            // 
            this.txtModStudentFirstName.Location = new System.Drawing.Point(125, 77);
            this.txtModStudentFirstName.Name = "txtModStudentFirstName";
            this.txtModStudentFirstName.Size = new System.Drawing.Size(282, 20);
            this.txtModStudentFirstName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(62, 21);
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
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(53, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Re-Enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Screen Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name:";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 346);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpModStudentDOB);
            this.Controls.Add(this.txtModStudentGrade);
            this.Controls.Add(this.txtModStudentVerifyPassword);
            this.Controls.Add(this.txtModStudentPassword);
            this.Controls.Add(this.txtModStudentScreenName);
            this.Controls.Add(this.txtModStudentLastName);
            this.Controls.Add(this.txtModStudentFirstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpModStudentDOB;
        private System.Windows.Forms.TextBox txtModStudentGrade;
        private System.Windows.Forms.TextBox txtModStudentVerifyPassword;
        private System.Windows.Forms.TextBox txtModStudentPassword;
        private System.Windows.Forms.TextBox txtModStudentScreenName;
        private System.Windows.Forms.TextBox txtModStudentLastName;
        private System.Windows.Forms.TextBox txtModStudentFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}