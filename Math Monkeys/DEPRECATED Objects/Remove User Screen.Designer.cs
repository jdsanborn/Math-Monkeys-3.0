namespace Math_Monkeys
{
    partial class Form3Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Remove));
            this.btnRemove = new System.Windows.Forms.Button();
            this.ddlStudentRemove = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(69, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(273, 50);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ddlStudentRemove
            // 
            this.ddlStudentRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStudentRemove.FormattingEnabled = true;
            this.ddlStudentRemove.Location = new System.Drawing.Point(85, 79);
            this.ddlStudentRemove.Name = "ddlStudentRemove";
            this.ddlStudentRemove.Size = new System.Drawing.Size(237, 21);
            this.ddlStudentRemove.TabIndex = 1;
            this.ddlStudentRemove.SelectedIndexChanged += new System.EventHandler(this.ddlStudentRemove_SelectedIndexChanged_1);
            // 
            // Form3Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 247);
            this.Controls.Add(this.ddlStudentRemove);
            this.Controls.Add(this.btnRemove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 285);
            this.Name = "Form3Remove";
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.Form3Remove_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox ddlStudentRemove;
    }
}