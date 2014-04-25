namespace Math_Monkeys.Forms
{
    partial class frmDrillResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrillResult));
            this.gbxResults = new System.Windows.Forms.GroupBox();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblPercentGrade = new System.Windows.Forms.Label();
            this.lblNumWrong = new System.Windows.Forms.Label();
            this.lblNumCorrect = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.btnNextAssignment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imgMathMonkeys = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblNextAssignment = new System.Windows.Forms.Label();
            this.blbAssignmentCompleted = new System.Windows.Forms.Label();
            this.gbxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxResults
            // 
            this.gbxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxResults.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxResults.Controls.Add(this.lblTimeSpent);
            this.gbxResults.Controls.Add(this.lblPercentGrade);
            this.gbxResults.Controls.Add(this.lblNumWrong);
            this.gbxResults.Controls.Add(this.lblNumCorrect);
            this.gbxResults.Controls.Add(this.lblTime);
            this.gbxResults.Controls.Add(this.lblCorrectAnswers);
            this.gbxResults.Controls.Add(this.lblGrade);
            this.gbxResults.Controls.Add(this.lblWrongAnswers);
            this.gbxResults.Location = new System.Drawing.Point(427, 281);
            this.gbxResults.Name = "gbxResults";
            this.gbxResults.Size = new System.Drawing.Size(500, 316);
            this.gbxResults.TabIndex = 20;
            this.gbxResults.TabStop = false;
            this.gbxResults.Enter += new System.EventHandler(this.gbxResults_Enter);
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblTimeSpent.Location = new System.Drawing.Point(342, 225);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(101, 37);
            this.lblTimeSpent.TabIndex = 7;
            this.lblTimeSpent.Text = "##:##";
            this.lblTimeSpent.Click += new System.EventHandler(this.lblTimeSpent_Click);
            // 
            // lblPercentGrade
            // 
            this.lblPercentGrade.AutoSize = true;
            this.lblPercentGrade.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblPercentGrade.Location = new System.Drawing.Point(344, 168);
            this.lblPercentGrade.Name = "lblPercentGrade";
            this.lblPercentGrade.Size = new System.Drawing.Size(99, 37);
            this.lblPercentGrade.TabIndex = 6;
            this.lblPercentGrade.Text = "###%";
            this.lblPercentGrade.Click += new System.EventHandler(this.lblPercentGrade_Click);
            // 
            // lblNumWrong
            // 
            this.lblNumWrong.AutoSize = true;
            this.lblNumWrong.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblNumWrong.Location = new System.Drawing.Point(344, 111);
            this.lblNumWrong.Name = "lblNumWrong";
            this.lblNumWrong.Size = new System.Drawing.Size(74, 37);
            this.lblNumWrong.TabIndex = 5;
            this.lblNumWrong.Text = "###";
            this.lblNumWrong.Click += new System.EventHandler(this.lblNumWrong_Click);
            // 
            // lblNumCorrect
            // 
            this.lblNumCorrect.AutoSize = true;
            this.lblNumCorrect.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Math_Monkeys.Properties.Settings.Default, "LoginFontSmall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblNumCorrect.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblNumCorrect.Location = new System.Drawing.Point(344, 54);
            this.lblNumCorrect.Name = "lblNumCorrect";
            this.lblNumCorrect.Size = new System.Drawing.Size(74, 37);
            this.lblNumCorrect.TabIndex = 4;
            this.lblNumCorrect.Text = "###";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblTime.Location = new System.Drawing.Point(213, 225);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 37);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time :";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(58, 54);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(257, 37);
            this.lblCorrectAnswers.TabIndex = 0;
            this.lblCorrectAnswers.Text = "Correct Answers :";
            this.lblCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblGrade.Location = new System.Drawing.Point(198, 168);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(116, 37);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grade :";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.Maroon;
            this.lblWrongAnswers.Location = new System.Drawing.Point(67, 111);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(247, 37);
            this.lblWrongAnswers.TabIndex = 1;
            this.lblWrongAnswers.Text = "Wrong Answers :";
            this.lblWrongAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNextAssignment
            // 
            this.btnNextAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnNextAssignment.BackgroundImage = global::Math_Monkeys.Properties.Resources.Right_Arrow1;
            this.btnNextAssignment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextAssignment.FlatAppearance.BorderSize = 0;
            this.btnNextAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAssignment.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAssignment.Location = new System.Drawing.Point(1132, 584);
            this.btnNextAssignment.Name = "btnNextAssignment";
            this.btnNextAssignment.Size = new System.Drawing.Size(65, 65);
            this.btnNextAssignment.TabIndex = 1;
            this.btnNextAssignment.UseVisualStyleBackColor = false;
            this.btnNextAssignment.Click += new System.EventHandler(this.btnNextAssignment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackgroundImage = global::Math_Monkeys.Properties.Resources.Log_Out_icon__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1277, 584);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 65);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // imgMathMonkeys
            // 
            this.imgMathMonkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMathMonkeys.Image = global::Math_Monkeys.Properties.Resources.Math_Monkeys_Logo_4;
            this.imgMathMonkeys.Location = new System.Drawing.Point(12, 12);
            this.imgMathMonkeys.Name = "imgMathMonkeys";
            this.imgMathMonkeys.Size = new System.Drawing.Size(100, 100);
            this.imgMathMonkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMathMonkeys.TabIndex = 22;
            this.imgMathMonkeys.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblName.Location = new System.Drawing.Point(122, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 24);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "<Student Name>";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontLarge;
            this.lblTitle.Location = new System.Drawing.Point(118, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 47);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Assignment Results";
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogout.Location = new System.Drawing.Point(1277, 652);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 24);
            this.lblLogout.TabIndex = 21;
            this.lblLogout.Text = "Logout";
            // 
            // lblNextAssignment
            // 
            this.lblNextAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextAssignment.AutoSize = true;
            this.lblNextAssignment.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontSmall;
            this.lblNextAssignment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNextAssignment.Location = new System.Drawing.Point(1090, 652);
            this.lblNextAssignment.Name = "lblNextAssignment";
            this.lblNextAssignment.Size = new System.Drawing.Size(148, 24);
            this.lblNextAssignment.TabIndex = 18;
            this.lblNextAssignment.Text = "Next Assignment";
            // 
            // blbAssignmentCompleted
            // 
            this.blbAssignmentCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blbAssignmentCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blbAssignmentCompleted.Font = global::Math_Monkeys.Properties.Settings.Default.StudentFontNormal;
            this.blbAssignmentCompleted.Location = new System.Drawing.Point(496, 200);
            this.blbAssignmentCompleted.Name = "blbAssignmentCompleted";
            this.blbAssignmentCompleted.Size = new System.Drawing.Size(362, 56);
            this.blbAssignmentCompleted.TabIndex = 19;
            this.blbAssignmentCompleted.Text = "Assignment Completed!";
            // 
            // frmDrillResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 685);
            this.ControlBox = false;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgMathMonkeys);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.gbxResults);
            this.Controls.Add(this.lblNextAssignment);
            this.Controls.Add(this.blbAssignmentCompleted);
            this.Controls.Add(this.btnNextAssignment);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrillResult";
            this.Text = "Math Monkeys -Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxResults.ResumeLayout(false);
            this.gbxResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMathMonkeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blbAssignmentCompleted;
        private System.Windows.Forms.GroupBox gbxResults;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblNextAssignment;
        private System.Windows.Forms.Button btnNextAssignment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Label lblPercentGrade;
        private System.Windows.Forms.Label lblNumWrong;
        private System.Windows.Forms.Label lblNumCorrect;
        private System.Windows.Forms.PictureBox imgMathMonkeys;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
    }
}