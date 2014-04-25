namespace Math_Monkeys
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ddlUserName = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPleaseChoose = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlUserName
            // 
            this.ddlUserName.BackColor = System.Drawing.SystemColors.Window;
            this.ddlUserName.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ddlUserName.DataSource = this.userBindingSource;
            this.ddlUserName.DisplayMember = "ScreenName";
            this.ddlUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUserName.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontNormal;
            this.ddlUserName.FormattingEnabled = true;
            this.ddlUserName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ddlUserName.Location = new System.Drawing.Point(195, 171);
            this.ddlUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlUserName.Name = "ddlUserName";
            this.ddlUserName.Size = new System.Drawing.Size(235, 31);
            this.ddlUserName.TabIndex = 0;
            this.ddlUserName.SelectedIndexChanged += new System.EventHandler(this.ddlUserName_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Math_Monkeys.User);
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayDate.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTodayDate.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontSmall;
            this.lblTodayDate.Location = new System.Drawing.Point(78, 395);
            this.lblTodayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(212, 19);
            this.lblTodayDate.TabIndex = 4;
            this.lblTodayDate.Text = "MMMMMMMMM DD, YYYY";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 10000;
            this.tmrClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontNormal;
            this.lblPassword.Location = new System.Drawing.Point(78, 222);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 23);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLogin.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontSmall;
            this.lblLogin.Location = new System.Drawing.Point(444, 292);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 19);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Math_Monkeys.Properties.Settings.Default, "MaxPasswordLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontNormal;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(195, 219);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = global::Math_Monkeys.Properties.Settings.Default.MaxPasswordLength;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(235, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPleaseChoose
            // 
            this.lblPleaseChoose.AutoSize = true;
            this.lblPleaseChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblPleaseChoose.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPleaseChoose.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontNormal;
            this.lblPleaseChoose.Location = new System.Drawing.Point(43, 174);
            this.lblPleaseChoose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPleaseChoose.Name = "lblPleaseChoose";
            this.lblPleaseChoose.Size = new System.Drawing.Size(144, 23);
            this.lblPleaseChoose.TabIndex = 2;
            this.lblPleaseChoose.Text = "Screen Name:";
            this.lblPleaseChoose.Click += new System.EventHandler(this.lblPleaseChoose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontSmall;
            this.btnLogin.Location = new System.Drawing.Point(438, 222);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.MaximumSize = new System.Drawing.Size(675, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 65);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.BackColor = System.Drawing.Color.Transparent;
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_4;
            this.imgMathMonkeys.Location = new System.Drawing.Point(-1, -1);
            this.imgMathMonkeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(65, 65);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 0;
            this.imgMathMonkeys.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontLarge", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontLarge;
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(69, 311);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 76);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Math Monkeys";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTime.Font = global::Math_Monkeys.Properties.Settings.Default.LoginFontSmall;
            this.lblTime.Location = new System.Drawing.Point(370, 395);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 19);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "HH:MM PM";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Math_Monkeys.Properties.Resources.Cartoon_jungle_background_07;
            this.ClientSize = new System.Drawing.Size(547, 423);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPleaseChoose);
            this.Controls.Add(this.ddlUserName);
            this.Controls.Add(this.imgMathMonkeys);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 865);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMathMonkeys;
        private System.Windows.Forms.Label lblPleaseChoose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ComboBox ddlUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
    }
}

