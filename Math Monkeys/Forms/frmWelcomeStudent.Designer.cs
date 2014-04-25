namespace Math_Monkeys.Forms
{
    partial class frmStudentWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentWelcome));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLoginDate = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = global::Math_Monkeys.Properties.Resources.Log_Out_icon__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1105, 579);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 65);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Math_Monkeys.Properties.Resources.Start2;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(535, 276);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 131);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_4;
            this.imgMathMonkeys.Location = new System.Drawing.Point(12, 12);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(100, 100);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 20;
            this.imgMathMonkeys.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblTime.Location = new System.Drawing.Point(1074, 53);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 24);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "HH:MM PM";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblUserName.Location = new System.Drawing.Point(275, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(252, 37);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "<Student Name>";
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLogout.Location = new System.Drawing.Point(1105, 648);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 24);
            this.lblLogout.TabIndex = 16;
            this.lblLogout.Text = "Logout";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDate.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblDate.Location = new System.Drawing.Point(935, 29);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(239, 24);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "MMMMMMMMMM DD, YYYY";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoginDate
            // 
            this.lblLoginDate.AutoSize = true;
            this.lblLoginDate.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLoginDate.Location = new System.Drawing.Point(278, 53);
            this.lblLoginDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginDate.Name = "lblLoginDate";
            this.lblLoginDate.Size = new System.Drawing.Size(222, 24);
            this.lblLoginDate.TabIndex = 10;
            this.lblLoginDate.Text = " MM/DD/YYYY HH:MM PM";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLastLogin.Location = new System.Drawing.Point(167, 49);
            this.lblLastLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(98, 24);
            this.lblLastLogin.TabIndex = 9;
            this.lblLastLogin.Text = "Last Login:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblWelcome.Location = new System.Drawing.Point(118, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(163, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome: ";
            // 
            // frmStudentWelcome
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.ControlBox = false;
            this.Controls.Add(this.imgMathMonkeys);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblLoginDate);
            this.Controls.Add(this.lblLastLogin);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLoginDate;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox imgMathMonkeys;
    }
}