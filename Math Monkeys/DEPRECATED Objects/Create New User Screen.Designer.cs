namespace Math_Monkeys
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartingJungle = new System.Windows.Forms.Label();
            this.ddlJungleSelection = new System.Windows.Forms.ComboBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblStartingJungle
            // 
            this.lblStartingJungle.AutoSize = true;
            this.lblStartingJungle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingJungle.Location = new System.Drawing.Point(164, 99);
            this.lblStartingJungle.Name = "lblStartingJungle";
            this.lblStartingJungle.Size = new System.Drawing.Size(203, 31);
            this.lblStartingJungle.TabIndex = 1;
            this.lblStartingJungle.Text = "Starting Jungle:";
            // 
            // ddlJungleSelection
            // 
            this.ddlJungleSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlJungleSelection.FormattingEnabled = true;
            this.ddlJungleSelection.Location = new System.Drawing.Point(139, 142);
            this.ddlJungleSelection.Name = "ddlJungleSelection";
            this.ddlJungleSelection.Size = new System.Drawing.Size(266, 21);
            this.ddlJungleSelection.TabIndex = 2;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(124, 42);
            this.txtNewName.MaxLength = 30;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(226, 20);
            this.txtNewName.TabIndex = 3;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(170, 180);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(197, 36);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 236);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.ddlJungleSelection);
            this.Controls.Add(this.lblStartingJungle);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(531, 274);
            this.MinimumSize = new System.Drawing.Size(531, 274);
            this.Name = "NewUserForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Monkeys - Create New User";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartingJungle;
        private System.Windows.Forms.ComboBox ddlJungleSelection;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnCreateUser;
    }
}