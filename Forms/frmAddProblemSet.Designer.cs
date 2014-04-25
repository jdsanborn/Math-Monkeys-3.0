namespace Math_Monkeys.Forms
{
    partial class frmAddProblemSet
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
            this.OperationGroupbox = new System.Windows.Forms.GroupBox();
            this.rdoDivOperation = new System.Windows.Forms.RadioButton();
            this.rdoMultOperation = new System.Windows.Forms.RadioButton();
            this.rdoSubOperation = new System.Windows.Forms.RadioButton();
            this.rdoAddOperation = new System.Windows.Forms.RadioButton();
            this.FirstOperandGroupBox = new System.Windows.Forms.GroupBox();
            this.txtFirstOperandRangeMax = new System.Windows.Forms.TextBox();
            this.txtFirstOperandRangeMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SecondOperandGroupBox = new System.Windows.Forms.GroupBox();
            this.txtSecondOperandRangeMax = new System.Windows.Forms.TextBox();
            this.txtSecondOperandRangeMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ddlAttemptsPerProblem = new System.Windows.Forms.ComboBox();
            this.txtNumberOfProblems = new System.Windows.Forms.TextBox();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.cbxDivisionWholeNumberAnswers = new System.Windows.Forms.CheckBox();
            this.cbxSubtractionAllowNegativeAnswers = new System.Windows.Forms.CheckBox();
            this.cbxAdditionAllowNegative = new System.Windows.Forms.CheckBox();
            this.problemSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationGroupbox.SuspendLayout();
            this.FirstOperandGroupBox.SuspendLayout();
            this.SecondOperandGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Problems:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Attempts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goal (%) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Range Minimum:";
            // 
            // OperationGroupbox
            // 
            this.OperationGroupbox.Controls.Add(this.rdoDivOperation);
            this.OperationGroupbox.Controls.Add(this.rdoMultOperation);
            this.OperationGroupbox.Controls.Add(this.rdoSubOperation);
            this.OperationGroupbox.Controls.Add(this.rdoAddOperation);
            this.OperationGroupbox.Location = new System.Drawing.Point(53, 125);
            this.OperationGroupbox.Name = "OperationGroupbox";
            this.OperationGroupbox.Size = new System.Drawing.Size(332, 79);
            this.OperationGroupbox.TabIndex = 4;
            this.OperationGroupbox.TabStop = false;
            this.OperationGroupbox.Text = "Operation";
            // 
            // rdoDivOperation
            // 
            this.rdoDivOperation.AutoSize = true;
            this.rdoDivOperation.Image = global::Math_Monkeys.Properties.Resources.Divide;
            this.rdoDivOperation.Location = new System.Drawing.Point(257, 23);
            this.rdoDivOperation.Name = "rdoDivOperation";
            this.rdoDivOperation.Size = new System.Drawing.Size(46, 32);
            this.rdoDivOperation.TabIndex = 3;
            this.rdoDivOperation.TabStop = true;
            this.rdoDivOperation.UseVisualStyleBackColor = true;
            this.rdoDivOperation.CheckedChanged += new System.EventHandler(this.rdoDivOperation_CheckedChanged);
            // 
            // rdoMultOperation
            // 
            this.rdoMultOperation.AutoSize = true;
            this.rdoMultOperation.Image = global::Math_Monkeys.Properties.Resources.times;
            this.rdoMultOperation.Location = new System.Drawing.Point(181, 23);
            this.rdoMultOperation.Name = "rdoMultOperation";
            this.rdoMultOperation.Size = new System.Drawing.Size(46, 32);
            this.rdoMultOperation.TabIndex = 2;
            this.rdoMultOperation.TabStop = true;
            this.rdoMultOperation.UseVisualStyleBackColor = true;
            this.rdoMultOperation.CheckedChanged += new System.EventHandler(this.rdoMultOperation_CheckedChanged);
            // 
            // rdoSubOperation
            // 
            this.rdoSubOperation.AutoSize = true;
            this.rdoSubOperation.Image = global::Math_Monkeys.Properties.Resources.Subtraction;
            this.rdoSubOperation.Location = new System.Drawing.Point(105, 23);
            this.rdoSubOperation.Name = "rdoSubOperation";
            this.rdoSubOperation.Size = new System.Drawing.Size(46, 32);
            this.rdoSubOperation.TabIndex = 1;
            this.rdoSubOperation.TabStop = true;
            this.rdoSubOperation.UseVisualStyleBackColor = true;
            this.rdoSubOperation.CheckedChanged += new System.EventHandler(this.rdoSubOperation_CheckedChanged);
            // 
            // rdoAddOperation
            // 
            this.rdoAddOperation.AutoSize = true;
            this.rdoAddOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdoAddOperation.Checked = true;
            this.rdoAddOperation.Image = global::Math_Monkeys.Properties.Resources.Plus;
            this.rdoAddOperation.Location = new System.Drawing.Point(29, 23);
            this.rdoAddOperation.Name = "rdoAddOperation";
            this.rdoAddOperation.Size = new System.Drawing.Size(46, 32);
            this.rdoAddOperation.TabIndex = 0;
            this.rdoAddOperation.TabStop = true;
            this.rdoAddOperation.UseVisualStyleBackColor = true;
            this.rdoAddOperation.CheckedChanged += new System.EventHandler(this.rdoAddOperation_CheckedChanged);
            // 
            // FirstOperandGroupBox
            // 
            this.FirstOperandGroupBox.Controls.Add(this.txtFirstOperandRangeMax);
            this.FirstOperandGroupBox.Controls.Add(this.txtFirstOperandRangeMin);
            this.FirstOperandGroupBox.Controls.Add(this.label6);
            this.FirstOperandGroupBox.Controls.Add(this.label5);
            this.FirstOperandGroupBox.Location = new System.Drawing.Point(53, 277);
            this.FirstOperandGroupBox.Name = "FirstOperandGroupBox";
            this.FirstOperandGroupBox.Size = new System.Drawing.Size(332, 67);
            this.FirstOperandGroupBox.TabIndex = 6;
            this.FirstOperandGroupBox.TabStop = false;
            this.FirstOperandGroupBox.Text = "First Operand";
            // 
            // txtFirstOperandRangeMax
            // 
            this.txtFirstOperandRangeMax.Location = new System.Drawing.Point(261, 26);
            this.txtFirstOperandRangeMax.Name = "txtFirstOperandRangeMax";
            this.txtFirstOperandRangeMax.Size = new System.Drawing.Size(53, 20);
            this.txtFirstOperandRangeMax.TabIndex = 1;
            this.txtFirstOperandRangeMax.Text = "S#####";
            // 
            // txtFirstOperandRangeMin
            // 
            this.txtFirstOperandRangeMin.Location = new System.Drawing.Point(97, 26);
            this.txtFirstOperandRangeMin.Name = "txtFirstOperandRangeMin";
            this.txtFirstOperandRangeMin.Size = new System.Drawing.Size(50, 20);
            this.txtFirstOperandRangeMin.TabIndex = 0;
            this.txtFirstOperandRangeMin.Text = "S#####";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Range Maximum:";
            // 
            // SecondOperandGroupBox
            // 
            this.SecondOperandGroupBox.Controls.Add(this.txtSecondOperandRangeMax);
            this.SecondOperandGroupBox.Controls.Add(this.txtSecondOperandRangeMin);
            this.SecondOperandGroupBox.Controls.Add(this.label7);
            this.SecondOperandGroupBox.Controls.Add(this.label8);
            this.SecondOperandGroupBox.Location = new System.Drawing.Point(53, 360);
            this.SecondOperandGroupBox.Name = "SecondOperandGroupBox";
            this.SecondOperandGroupBox.Size = new System.Drawing.Size(332, 67);
            this.SecondOperandGroupBox.TabIndex = 7;
            this.SecondOperandGroupBox.TabStop = false;
            this.SecondOperandGroupBox.Text = "Second Operand";
            // 
            // txtSecondOperandRangeMax
            // 
            this.txtSecondOperandRangeMax.Location = new System.Drawing.Point(261, 28);
            this.txtSecondOperandRangeMax.Name = "txtSecondOperandRangeMax";
            this.txtSecondOperandRangeMax.Size = new System.Drawing.Size(53, 20);
            this.txtSecondOperandRangeMax.TabIndex = 1;
            this.txtSecondOperandRangeMax.Text = "S#####";
            // 
            // txtSecondOperandRangeMin
            // 
            this.txtSecondOperandRangeMin.Location = new System.Drawing.Point(97, 28);
            this.txtSecondOperandRangeMin.Name = "txtSecondOperandRangeMin";
            this.txtSecondOperandRangeMin.Size = new System.Drawing.Size(50, 20);
            this.txtSecondOperandRangeMin.TabIndex = 0;
            this.txtSecondOperandRangeMin.Text = "S#####";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Range Maximum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Range Minimum:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
            // 
            // ddlAttemptsPerProblem
            // 
            this.ddlAttemptsPerProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAttemptsPerProblem.FormattingEnabled = true;
            this.ddlAttemptsPerProblem.Items.AddRange(new object[] {
            "Until Correct",
            "One",
            "Two",
            "Three",
            "Four",
            "Five"});
            this.ddlAttemptsPerProblem.Location = new System.Drawing.Point(161, 88);
            this.ddlAttemptsPerProblem.Name = "ddlAttemptsPerProblem";
            this.ddlAttemptsPerProblem.Size = new System.Drawing.Size(121, 21);
            this.ddlAttemptsPerProblem.TabIndex = 3;
            // 
            // txtNumberOfProblems
            // 
            this.txtNumberOfProblems.Location = new System.Drawing.Point(161, 50);
            this.txtNumberOfProblems.Name = "txtNumberOfProblems";
            this.txtNumberOfProblems.Size = new System.Drawing.Size(39, 20);
            this.txtNumberOfProblems.TabIndex = 1;
            this.txtNumberOfProblems.Text = "###";
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(335, 50);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(50, 20);
            this.txtGoal.TabIndex = 2;
            this.txtGoal.Text = "###.##";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Math_Monkeys.Properties.Resources.fileclose;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(192, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.BackgroundImage = global::Math_Monkeys.Properties.Resources.addNew2;
            this.btnSaveAndNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveAndNew.FlatAppearance.BorderSize = 0;
            this.btnSaveAndNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveAndNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNew.Location = new System.Drawing.Point(335, 442);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(32, 32);
            this.btnSaveAndNew.TabIndex = 9;
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Math_Monkeys.Properties.Resources.filesave;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(262, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cancel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Save";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Save && New";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.cbxDivisionWholeNumberAnswers);
            this.OptionsGroupBox.Controls.Add(this.cbxSubtractionAllowNegativeAnswers);
            this.OptionsGroupBox.Controls.Add(this.cbxAdditionAllowNegative);
            this.OptionsGroupBox.Location = new System.Drawing.Point(53, 210);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(332, 61);
            this.OptionsGroupBox.TabIndex = 5;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // cbxDivisionWholeNumberAnswers
            // 
            this.cbxDivisionWholeNumberAnswers.AutoSize = true;
            this.cbxDivisionWholeNumberAnswers.Location = new System.Drawing.Point(9, 38);
            this.cbxDivisionWholeNumberAnswers.Name = "cbxDivisionWholeNumberAnswers";
            this.cbxDivisionWholeNumberAnswers.Size = new System.Drawing.Size(140, 17);
            this.cbxDivisionWholeNumberAnswers.TabIndex = 2;
            this.cbxDivisionWholeNumberAnswers.Text = "Whole Number Answers";
            this.cbxDivisionWholeNumberAnswers.UseVisualStyleBackColor = true;
            // 
            // cbxSubtractionAllowNegativeAnswers
            // 
            this.cbxSubtractionAllowNegativeAnswers.AutoSize = true;
            this.cbxSubtractionAllowNegativeAnswers.Location = new System.Drawing.Point(191, 19);
            this.cbxSubtractionAllowNegativeAnswers.Name = "cbxSubtractionAllowNegativeAnswers";
            this.cbxSubtractionAllowNegativeAnswers.Size = new System.Drawing.Size(135, 17);
            this.cbxSubtractionAllowNegativeAnswers.TabIndex = 1;
            this.cbxSubtractionAllowNegativeAnswers.Text = "Allow Negative Answer";
            this.cbxSubtractionAllowNegativeAnswers.UseVisualStyleBackColor = true;
            // 
            // cbxAdditionAllowNegative
            // 
            this.cbxAdditionAllowNegative.AutoSize = true;
            this.cbxAdditionAllowNegative.Location = new System.Drawing.Point(9, 19);
            this.cbxAdditionAllowNegative.Name = "cbxAdditionAllowNegative";
            this.cbxAdditionAllowNegative.Size = new System.Drawing.Size(146, 17);
            this.cbxAdditionAllowNegative.TabIndex = 0;
            this.cbxAdditionAllowNegative.Text = "Allow Negative Operands";
            this.cbxAdditionAllowNegative.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddProblemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.ControlBox = false;
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.txtNumberOfProblems);
            this.Controls.Add(this.ddlAttemptsPerProblem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.SecondOperandGroupBox);
            this.Controls.Add(this.FirstOperandGroupBox);
            this.Controls.Add(this.OperationGroupbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddProblemSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Problem Set";
            this.Load += new System.EventHandler(this.frmAddProblemSet_Load);
            this.OperationGroupbox.ResumeLayout(false);
            this.OperationGroupbox.PerformLayout();
            this.FirstOperandGroupBox.ResumeLayout(false);
            this.FirstOperandGroupBox.PerformLayout();
            this.SecondOperandGroupBox.ResumeLayout(false);
            this.SecondOperandGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox OperationGroupbox;
        private System.Windows.Forms.RadioButton rdoDivOperation;
        private System.Windows.Forms.RadioButton rdoMultOperation;
        private System.Windows.Forms.RadioButton rdoSubOperation;
        private System.Windows.Forms.RadioButton rdoAddOperation;
        private System.Windows.Forms.GroupBox FirstOperandGroupBox;
        private System.Windows.Forms.TextBox txtFirstOperandRangeMax;
        private System.Windows.Forms.TextBox txtFirstOperandRangeMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox SecondOperandGroupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox ddlAttemptsPerProblem;
        private System.Windows.Forms.TextBox txtNumberOfProblems;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtSecondOperandRangeMax;
        private System.Windows.Forms.TextBox txtSecondOperandRangeMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox cbxDivisionWholeNumberAnswers;
        private System.Windows.Forms.CheckBox cbxSubtractionAllowNegativeAnswers;
        private System.Windows.Forms.CheckBox cbxAdditionAllowNegative;
        private System.Windows.Forms.BindingSource problemSetBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}