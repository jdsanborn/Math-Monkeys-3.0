namespace Math_Monkeys
{
    partial class Problem_Select_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Problem_Select_Screen));
            this.btnStartLesson = new System.Windows.Forms.Button();
            this.ddljungleNames = new System.Windows.Forms.ComboBox();
            this.lblSelectAJungle = new System.Windows.Forms.Label();
            this.lblLastLoginDate = new System.Windows.Forms.Label();
            this.lblWelcomStudent = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartLesson
            // 
            this.btnStartLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLesson.Location = new System.Drawing.Point(149, 254);
            this.btnStartLesson.MaximumSize = new System.Drawing.Size(601, 75);
            this.btnStartLesson.MinimumSize = new System.Drawing.Size(601, 75);
            this.btnStartLesson.Name = "btnStartLesson";
            this.btnStartLesson.Size = new System.Drawing.Size(601, 75);
            this.btnStartLesson.TabIndex = 0;
            this.btnStartLesson.Text = "Start Lesson";
            this.btnStartLesson.UseVisualStyleBackColor = true;
            this.btnStartLesson.Click += new System.EventHandler(this.btnStartLesson_Click);
            // 
            // ddljungleNames
            // 
            this.ddljungleNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddljungleNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddljungleNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddljungleNames.FormattingEnabled = true;
            this.ddljungleNames.Location = new System.Drawing.Point(148, 166);
            this.ddljungleNames.MaximumSize = new System.Drawing.Size(601, 0);
            this.ddljungleNames.MinimumSize = new System.Drawing.Size(151, 0);
            this.ddljungleNames.Name = "ddljungleNames";
            this.ddljungleNames.Size = new System.Drawing.Size(601, 37);
            this.ddljungleNames.TabIndex = 1;
            this.ddljungleNames.TabStop = false;
            // 
            // lblSelectAJungle
            // 
            this.lblSelectAJungle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectAJungle.AutoSize = true;
            this.lblSelectAJungle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAJungle.Location = new System.Drawing.Point(346, 134);
            this.lblSelectAJungle.Name = "lblSelectAJungle";
            this.lblSelectAJungle.Size = new System.Drawing.Size(193, 29);
            this.lblSelectAJungle.TabIndex = 2;
            this.lblSelectAJungle.Text = "Select a Jungle";
            this.lblSelectAJungle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastLoginDate
            // 
            this.lblLastLoginDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastLoginDate.AutoSize = true;
            this.lblLastLoginDate.Location = new System.Drawing.Point(131, 705);
            this.lblLastLoginDate.Name = "lblLastLoginDate";
            this.lblLastLoginDate.Size = new System.Drawing.Size(159, 13);
            this.lblLastLoginDate.TabIndex = 3;
            this.lblLastLoginDate.Text = "Last Login: DAY MONTH YEAR";
            // 
            // lblWelcomStudent
            // 
            this.lblWelcomStudent.AutoSize = true;
            this.lblWelcomStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomStudent.Location = new System.Drawing.Point(167, 65);
            this.lblWelcomStudent.Name = "lblWelcomStudent";
            this.lblWelcomStudent.Size = new System.Drawing.Size(237, 55);
            this.lblWelcomStudent.TabIndex = 4;
            this.lblWelcomStudent.Text = "Welcome ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(1276, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 42);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1027, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Problem_Select_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblWelcomStudent);
            this.Controls.Add(this.lblLastLoginDate);
            this.Controls.Add(this.lblSelectAJungle);
            this.Controls.Add(this.ddljungleNames);
            this.Controls.Add(this.btnStartLesson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1202, 704);
            this.Name = "Problem_Select_Screen";
            this.Text = "Math Monkeys - Problem Selection";
            this.Load += new System.EventHandler(this.Problem_Select_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartLesson;
        private System.Windows.Forms.ComboBox ddljungleNames;
        private System.Windows.Forms.Label lblSelectAJungle;
        private System.Windows.Forms.Label lblLastLoginDate;
        private System.Windows.Forms.Label lblWelcomStudent;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button1;
    }
}