namespace Math_Monkeys.Forms
{
    partial class frmAssignStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignStudents));
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            this.dtgProblemSetList = new System.Windows.Forms.DataGridView();
            this.gbFilterProblemSet = new System.Windows.Forms.GroupBox();
            this.cbDivision = new System.Windows.Forms.CheckBox();
            this.cbMultiplication = new System.Windows.Forms.CheckBox();
            this.cbSubtraction = new System.Windows.Forms.CheckBox();
            this.cbAddition = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveAssignment = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMoveUP = new System.Windows.Forms.Button();
            this.dgvCurrentAssignments = new System.Windows.Forms.DataGridView();
            this.incompletedAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTotalAssignments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInCompleteAssignments = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.problemSetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProblemSetList)).BeginInit();
            this.gbFilterProblemSet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.AllowUserToAddRows = false;
            this.dtgStudentList.AllowUserToDeleteRows = false;
            this.dtgStudentList.AllowUserToResizeColumns = false;
            this.dtgStudentList.AllowUserToResizeRows = false;
            this.dtgStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStudentList.AutoGenerateColumns = false;
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getFullNameDataGridViewTextBoxColumn});
            this.dtgStudentList.DataSource = this.studentBindingSource;
            this.dtgStudentList.Location = new System.Drawing.Point(6, 19);
            this.dtgStudentList.MultiSelect = false;
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.ReadOnly = true;
            this.dtgStudentList.RowHeadersVisible = false;
            this.dtgStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStudentList.Size = new System.Drawing.Size(300, 529);
            this.dtgStudentList.TabIndex = 0;
            // 
            // dtgProblemSetList
            // 
            this.dtgProblemSetList.AllowUserToAddRows = false;
            this.dtgProblemSetList.AllowUserToDeleteRows = false;
            this.dtgProblemSetList.AllowUserToResizeColumns = false;
            this.dtgProblemSetList.AllowUserToResizeRows = false;
            this.dtgProblemSetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProblemSetList.AutoGenerateColumns = false;
            this.dtgProblemSetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProblemSetList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dtgProblemSetList.DataSource = this.problemSetBindingSource;
            this.dtgProblemSetList.Location = new System.Drawing.Point(6, 106);
            this.dtgProblemSetList.Name = "dtgProblemSetList";
            this.dtgProblemSetList.ReadOnly = true;
            this.dtgProblemSetList.RowHeadersVisible = false;
            this.dtgProblemSetList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProblemSetList.Size = new System.Drawing.Size(300, 442);
            this.dtgProblemSetList.TabIndex = 0;
            this.dtgProblemSetList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ButtonPressEvent_AddProblemSets);
            // 
            // gbFilterProblemSet
            // 
            this.gbFilterProblemSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilterProblemSet.Controls.Add(this.cbDivision);
            this.gbFilterProblemSet.Controls.Add(this.cbMultiplication);
            this.gbFilterProblemSet.Controls.Add(this.cbSubtraction);
            this.gbFilterProblemSet.Controls.Add(this.cbAddition);
            this.gbFilterProblemSet.Location = new System.Drawing.Point(7, 29);
            this.gbFilterProblemSet.Name = "gbFilterProblemSet";
            this.gbFilterProblemSet.Size = new System.Drawing.Size(300, 60);
            this.gbFilterProblemSet.TabIndex = 0;
            this.gbFilterProblemSet.TabStop = false;
            this.gbFilterProblemSet.Text = "Filter Problem Sets";
            // 
            // cbDivision
            // 
            this.cbDivision.BackgroundImage = global::Math_Monkeys.Properties.Resources.Divide;
            this.cbDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbDivision.Location = new System.Drawing.Point(231, 18);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(60, 25);
            this.cbDivision.TabIndex = 3;
            this.cbDivision.UseVisualStyleBackColor = true;
            this.cbDivision.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedEvent_Operations);
            // 
            // cbMultiplication
            // 
            this.cbMultiplication.BackgroundImage = global::Math_Monkeys.Properties.Resources.times;
            this.cbMultiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbMultiplication.Location = new System.Drawing.Point(157, 18);
            this.cbMultiplication.Name = "cbMultiplication";
            this.cbMultiplication.Size = new System.Drawing.Size(60, 25);
            this.cbMultiplication.TabIndex = 2;
            this.cbMultiplication.UseVisualStyleBackColor = true;
            this.cbMultiplication.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedEvent_Operations);
            // 
            // cbSubtraction
            // 
            this.cbSubtraction.BackgroundImage = global::Math_Monkeys.Properties.Resources.Subtraction;
            this.cbSubtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbSubtraction.Location = new System.Drawing.Point(83, 18);
            this.cbSubtraction.Name = "cbSubtraction";
            this.cbSubtraction.Size = new System.Drawing.Size(60, 25);
            this.cbSubtraction.TabIndex = 1;
            this.cbSubtraction.UseVisualStyleBackColor = true;
            this.cbSubtraction.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedEvent_Operations);
            // 
            // cbAddition
            // 
            this.cbAddition.BackgroundImage = global::Math_Monkeys.Properties.Resources.Plus;
            this.cbAddition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbAddition.Location = new System.Drawing.Point(9, 18);
            this.cbAddition.Name = "cbAddition";
            this.cbAddition.Size = new System.Drawing.Size(60, 25);
            this.cbAddition.TabIndex = 0;
            this.cbAddition.UseVisualStyleBackColor = true;
            this.cbAddition.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedEvent_Operations);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbFilterProblemSet);
            this.groupBox2.Controls.Add(this.dtgProblemSetList);
            this.groupBox2.Location = new System.Drawing.Point(369, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 560);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Problem Set(s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgStudentList);
            this.groupBox3.Location = new System.Drawing.Point(26, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 560);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select A Student";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Controls.Add(this.dgvCurrentAssignments);
            this.groupBox4.Location = new System.Drawing.Point(766, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 454);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Assignments";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 380);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveAssignment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(234, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 8;
            // 
            // btnRemoveAssignment
            // 
            this.btnRemoveAssignment.Location = new System.Drawing.Point(14, 6);
            this.btnRemoveAssignment.Name = "btnRemoveAssignment";
            this.btnRemoveAssignment.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveAssignment.TabIndex = 1;
            this.btnRemoveAssignment.UseVisualStyleBackColor = true;
            this.btnRemoveAssignment.Click += new System.EventHandler(this.ButtonPressEvent_RemoveProblemSets);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Remove";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMoveDown);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(168, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 60);
            this.panel3.TabIndex = 1;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(14, 6);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(32, 32);
            this.btnMoveDown.TabIndex = 0;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Move Down";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnMoveUP);
            this.panel2.Location = new System.Drawing.Point(102, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 60);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Move Up";
            // 
            // btnMoveUP
            // 
            this.btnMoveUP.Enabled = false;
            this.btnMoveUP.Location = new System.Drawing.Point(14, 6);
            this.btnMoveUP.Name = "btnMoveUP";
            this.btnMoveUP.Size = new System.Drawing.Size(32, 32);
            this.btnMoveUP.TabIndex = 1;
            this.btnMoveUP.UseVisualStyleBackColor = true;
            // 
            // dgvCurrentAssignments
            // 
            this.dgvCurrentAssignments.AllowUserToAddRows = false;
            this.dgvCurrentAssignments.AllowUserToDeleteRows = false;
            this.dgvCurrentAssignments.AllowUserToResizeColumns = false;
            this.dgvCurrentAssignments.AllowUserToResizeRows = false;
            this.dgvCurrentAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentAssignments.AutoGenerateColumns = false;
            this.dgvCurrentAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.problemSetNameDataGridViewTextBoxColumn});
            this.dgvCurrentAssignments.DataSource = this.incompletedAssignmentsBindingSource;
            this.dgvCurrentAssignments.Location = new System.Drawing.Point(6, 19);
            this.dgvCurrentAssignments.Name = "dgvCurrentAssignments";
            this.dgvCurrentAssignments.ReadOnly = true;
            this.dgvCurrentAssignments.RowHeadersVisible = false;
            this.dgvCurrentAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentAssignments.Size = new System.Drawing.Size(297, 355);
            this.dgvCurrentAssignments.TabIndex = 0;
            this.dgvCurrentAssignments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonPressEvent_RemoveProblemSets);
            // 
            // incompletedAssignmentsBindingSource
            // 
            this.incompletedAssignmentsBindingSource.DataMember = "IncompletedAssignments";
            this.incompletedAssignmentsBindingSource.DataSource = this.studentBindingSource;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(709, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonPressEvent_AddProblemSets);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GetFullName", true));
            this.lblStudentName.Location = new System.Drawing.Point(149, 19);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(105, 13);
            this.lblStudentName.TabIndex = 7;
            this.lblStudentName.Text = "<STUDENT NAME>";
            // 
            // lblTotalAssignments
            // 
            this.lblTotalAssignments.AutoSize = true;
            this.lblTotalAssignments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "TotalAssignments", true));
            this.lblTotalAssignments.Location = new System.Drawing.Point(149, 38);
            this.lblTotalAssignments.Name = "lblTotalAssignments";
            this.lblTotalAssignments.Size = new System.Drawing.Size(28, 13);
            this.lblTotalAssignments.TabIndex = 8;
            this.lblTotalAssignments.Text = "###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Assignments:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incomplete Assignments:";
            // 
            // lblInCompleteAssignments
            // 
            this.lblInCompleteAssignments.AutoSize = true;
            this.lblInCompleteAssignments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "IncompleteAssignments", true));
            this.lblInCompleteAssignments.Location = new System.Drawing.Point(149, 61);
            this.lblInCompleteAssignments.Name = "lblInCompleteAssignments";
            this.lblInCompleteAssignments.Size = new System.Drawing.Size(28, 13);
            this.lblInCompleteAssignments.TabIndex = 12;
            this.lblInCompleteAssignments.Text = "###";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblInCompleteAssignments);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.lblTotalAssignments);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblStudentName);
            this.groupBox5.Location = new System.Drawing.Point(766, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Student Info";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(13, 11);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(32, 32);
            this.btnDone.TabIndex = 0;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.ButtonPressEvent_DoneAssignStudent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Add";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Done";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDone);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(1011, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 5;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Math_Monkeys.Student);
            // 
            // problemSetNameDataGridViewTextBoxColumn
            // 
            this.problemSetNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.problemSetNameDataGridViewTextBoxColumn.DataPropertyName = "ProblemSetName";
            this.problemSetNameDataGridViewTextBoxColumn.HeaderText = "Problem Set Name";
            this.problemSetNameDataGridViewTextBoxColumn.Name = "problemSetNameDataGridViewTextBoxColumn";
            this.problemSetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getFullNameDataGridViewTextBoxColumn
            // 
            this.getFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.getFullNameDataGridViewTextBoxColumn.DataPropertyName = "GetFullName";
            this.getFullNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.getFullNameDataGridViewTextBoxColumn.Name = "getFullNameDataGridViewTextBoxColumn";
            this.getFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Problem Set Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // problemSetBindingSource
            // 
            this.problemSetBindingSource.DataSource = typeof(Math_Monkeys.ProblemSet);
            // 
            // frmAssignStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAssignStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Assignments";
            this.Load += new System.EventHandler(this.LoadEvent_AssignStudentsForm);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProblemSetList)).EndInit();
            this.gbFilterProblemSet.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incompletedAssignmentsBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStudentList;
        private System.Windows.Forms.DataGridView dtgProblemSetList;
        private System.Windows.Forms.BindingSource problemSetBindingSource;
        private System.Windows.Forms.GroupBox gbFilterProblemSet;
        private System.Windows.Forms.CheckBox cbDivision;
        private System.Windows.Forms.CheckBox cbMultiplication;
        private System.Windows.Forms.CheckBox cbSubtraction;
        private System.Windows.Forms.CheckBox cbAddition;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveAssignment;
        private System.Windows.Forms.Button btnMoveUP;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblTotalAssignments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInCompleteAssignments;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn getFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView dgvCurrentAssignments;
        private System.Windows.Forms.BindingSource incompletedAssignmentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemSetNameDataGridViewTextBoxColumn;
    }
}