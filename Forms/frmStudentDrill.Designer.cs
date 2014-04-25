namespace Math_Monkeys
{
    partial class frmStudentDrill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentDrill));
            this.gbxMathProblem = new System.Windows.Forms.GroupBox();
            this.btnEnterAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.imageListOperations = new System.Windows.Forms.ImageList(this.components);
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblProblemBar = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.tmrProblem = new System.Windows.Forms.Timer(this.components);
            this.pnlNumberProblems = new System.Windows.Forms.Panel();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblTotalProblems = new System.Windows.Forms.Label();
            this.lblof = new System.Windows.Forms.Label();
            this.lblCurrentProblem = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblMonkeyDrill = new System.Windows.Forms.Label();
            this.gbxMathProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.pnlNumberProblems.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMathProblem
            // 
            this.gbxMathProblem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxMathProblem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxMathProblem.Controls.Add(this.btnEnterAnswer);
            this.gbxMathProblem.Controls.Add(this.txtAnswer);
            this.gbxMathProblem.Controls.Add(this.lblFeedback);
            this.gbxMathProblem.Controls.Add(this.lblOperand1);
            this.gbxMathProblem.Controls.Add(this.lblOperator);
            this.gbxMathProblem.Controls.Add(this.lblOperand2);
            this.gbxMathProblem.Controls.Add(this.lblProblemBar);
            this.gbxMathProblem.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMathProblem.Location = new System.Drawing.Point(429, 50);
            this.gbxMathProblem.Name = "gbxMathProblem";
            this.gbxMathProblem.Size = new System.Drawing.Size(493, 595);
            this.gbxMathProblem.TabIndex = 0;
            this.gbxMathProblem.TabStop = false;
            // 
            // btnEnterAnswer
            // 
            this.btnEnterAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterAnswer.AutoSize = true;
            this.btnEnterAnswer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnterAnswer.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.btnEnterAnswer.Location = new System.Drawing.Point(140, 236);
            this.btnEnterAnswer.MaximumSize = new System.Drawing.Size(375, 164);
            this.btnEnterAnswer.Name = "btnEnterAnswer";
            this.btnEnterAnswer.Size = new System.Drawing.Size(199, 55);
            this.btnEnterAnswer.TabIndex = 1;
            this.btnEnterAnswer.Text = "Submit";
            this.btnEnterAnswer.UseVisualStyleBackColor = false;
            this.btnEnterAnswer.Click += new System.EventHandler(this.btnEnterAnswer_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.txtAnswer.Location = new System.Drawing.Point(137, 186);
            this.txtAnswer.MaxLength = global::Math_Monkeys.Properties.Settings.Default.NumberLengthMax;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ShortcutsEnabled = false;
            this.txtAnswer.Size = new System.Drawing.Size(199, 44);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedback.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblFeedback.Location = new System.Drawing.Point(5, 314);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(483, 93);
            this.lblFeedback.TabIndex = 8;
            this.lblFeedback.Text = "Good Luck !";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperand1
            // 
            this.lblOperand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperand1.BackColor = System.Drawing.Color.Transparent;
            this.lblOperand1.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblOperand1.Location = new System.Drawing.Point(168, 56);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(168, 41);
            this.lblOperand1.TabIndex = 1;
            this.lblOperand1.Text = " 8 8 8 8 8";
            this.lblOperand1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperator
            // 
            this.lblOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperator.BackColor = System.Drawing.Color.Transparent;
            this.lblOperator.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOperator.ImageIndex = 1;
            this.lblOperator.ImageList = this.imageListOperations;
            this.lblOperator.Location = new System.Drawing.Point(133, 116);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(36, 36);
            this.lblOperator.TabIndex = 11;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageListOperations
            // 
            this.imageListOperations.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOperations.ImageStream")));
            this.imageListOperations.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOperations.Images.SetKeyName(0, "info.png");
            this.imageListOperations.Images.SetKeyName(1, "Plus.png");
            this.imageListOperations.Images.SetKeyName(2, "Subtraction.png");
            this.imageListOperations.Images.SetKeyName(3, "times.png");
            this.imageListOperations.Images.SetKeyName(4, "Divide.png");
            // 
            // lblOperand2
            // 
            this.lblOperand2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperand2.BackColor = System.Drawing.Color.Transparent;
            this.lblOperand2.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblOperand2.Location = new System.Drawing.Point(168, 117);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(168, 41);
            this.lblOperand2.TabIndex = 3;
            this.lblOperand2.Text = " 8 8 8 8 8";
            this.lblOperand2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProblemBar
            // 
            this.lblProblemBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblemBar.AutoSize = true;
            this.lblProblemBar.BackColor = System.Drawing.Color.Transparent;
            this.lblProblemBar.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblProblemBar.Location = new System.Drawing.Point(130, 133);
            this.lblProblemBar.Margin = new System.Windows.Forms.Padding(0);
            this.lblProblemBar.Name = "lblProblemBar";
            this.lblProblemBar.Size = new System.Drawing.Size(209, 37);
            this.lblProblemBar.TabIndex = 4;
            this.lblProblemBar.Text = "____________";
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
            this.btnLogout.Location = new System.Drawing.Point(1273, 580);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 65);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_4;
            this.imgMathMonkeys.Location = new System.Drawing.Point(12, 5);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(100, 100);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 6;
            this.imgMathMonkeys.TabStop = false;
            // 
            // tmrProblem
            // 
            this.tmrProblem.Interval = 1000;
            // 
            // pnlNumberProblems
            // 
            this.pnlNumberProblems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNumberProblems.Controls.Add(this.lblProblem);
            this.pnlNumberProblems.Controls.Add(this.lblTotalProblems);
            this.pnlNumberProblems.Controls.Add(this.lblof);
            this.pnlNumberProblems.Controls.Add(this.lblCurrentProblem);
            this.pnlNumberProblems.Location = new System.Drawing.Point(566, 5);
            this.pnlNumberProblems.Name = "pnlNumberProblems";
            this.pnlNumberProblems.Size = new System.Drawing.Size(230, 45);
            this.pnlNumberProblems.TabIndex = 24;
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblProblem.Location = new System.Drawing.Point(7, 10);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(84, 24);
            this.lblProblem.TabIndex = 20;
            this.lblProblem.Text = "Problem:";
            // 
            // lblTotalProblems
            // 
            this.lblTotalProblems.AutoSize = true;
            this.lblTotalProblems.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblTotalProblems.Location = new System.Drawing.Point(178, 10);
            this.lblTotalProblems.Name = "lblTotalProblems";
            this.lblTotalProblems.Size = new System.Drawing.Size(43, 24);
            this.lblTotalProblems.TabIndex = 22;
            this.lblTotalProblems.Text = "###";
            // 
            // lblof
            // 
            this.lblof.AutoSize = true;
            this.lblof.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblof.Location = new System.Drawing.Point(144, 10);
            this.lblof.Name = "lblof";
            this.lblof.Size = new System.Drawing.Size(26, 24);
            this.lblof.TabIndex = 12;
            this.lblof.Text = "of";
            // 
            // lblCurrentProblem
            // 
            this.lblCurrentProblem.AutoSize = true;
            this.lblCurrentProblem.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblCurrentProblem.Location = new System.Drawing.Point(97, 10);
            this.lblCurrentProblem.Name = "lblCurrentProblem";
            this.lblCurrentProblem.Size = new System.Drawing.Size(43, 24);
            this.lblCurrentProblem.TabIndex = 21;
            this.lblCurrentProblem.Text = "###";
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLogout.Location = new System.Drawing.Point(1273, 652);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 24);
            this.lblLogout.TabIndex = 19;
            this.lblLogout.Text = "Logout";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Enabled = global::Math_Monkeys.Properties.Settings.Default.ShowProblemTimer;
            this.lblTimer.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblTimer.Location = new System.Drawing.Point(8, 652);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(67, 24);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "MM:SS";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimer.Visible = global::Math_Monkeys.Properties.Settings.Default.ShowProblemTimer;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "AdminFontNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblUsername.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblUsername.Location = new System.Drawing.Point(121, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 24);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "<Student Name>";
            // 
            // lblMonkeyDrill
            // 
            this.lblMonkeyDrill.AutoSize = true;
            this.lblMonkeyDrill.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblMonkeyDrill.Location = new System.Drawing.Point(118, 5);
            this.lblMonkeyDrill.Name = "lblMonkeyDrill";
            this.lblMonkeyDrill.Size = new System.Drawing.Size(189, 37);
            this.lblMonkeyDrill.TabIndex = 14;
            this.lblMonkeyDrill.Text = "Monkey Drill";
            // 
            // frmStudentDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 685);
            this.ControlBox = false;
            this.Controls.Add(this.pnlNumberProblems);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblMonkeyDrill);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.imgMathMonkeys);
            this.Controls.Add(this.gbxMathProblem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(535, 288);
            this.Name = "frmStudentDrill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Monkey Drill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxMathProblem.ResumeLayout(false);
            this.gbxMathProblem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.pnlNumberProblems.ResumeLayout(false);
            this.pnlNumberProblems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterAnswer;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblProblemBar;
        private System.Windows.Forms.PictureBox imgMathMonkeys;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox gbxMathProblem;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblof;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblMonkeyDrill;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Timer tmrProblem;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblCurrentProblem;
        private System.Windows.Forms.Label lblTotalProblems;
        private System.Windows.Forms.Panel pnlNumberProblems;
        private System.Windows.Forms.ImageList imageListOperations;

    }
}