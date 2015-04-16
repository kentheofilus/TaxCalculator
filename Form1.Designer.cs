namespace KPrayogoFinal
{
    partial class Form1
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
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.marriedCheckBox = new System.Windows.Forms.CheckBox();
            this.salaryTBox = new System.Windows.Forms.TextBox();
            this.investTBox = new System.Windows.Forms.TextBox();
            this.exempNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayTBox = new System.Windows.Forms.TextBox();
            this.enterDataButton = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exemptCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exempNumeric)).BeginInit();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(156, 14);
            this.nameTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(139, 22);
            this.nameTBox.TabIndex = 0;
            // 
            // marriedCheckBox
            // 
            this.marriedCheckBox.AutoSize = true;
            this.marriedCheckBox.Location = new System.Drawing.Point(19, 43);
            this.marriedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marriedCheckBox.Name = "marriedCheckBox";
            this.marriedCheckBox.Size = new System.Drawing.Size(132, 21);
            this.marriedCheckBox.TabIndex = 1;
            this.marriedCheckBox.Text = "Check if Married";
            this.marriedCheckBox.UseVisualStyleBackColor = true;
            // 
            // salaryTBox
            // 
            this.salaryTBox.Location = new System.Drawing.Point(157, 78);
            this.salaryTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryTBox.Name = "salaryTBox";
            this.salaryTBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTBox.TabIndex = 2;
            // 
            // investTBox
            // 
            this.investTBox.Location = new System.Drawing.Point(157, 118);
            this.investTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.investTBox.Name = "investTBox";
            this.investTBox.Size = new System.Drawing.Size(100, 22);
            this.investTBox.TabIndex = 3;
            // 
            // exempNumeric
            // 
            this.exempNumeric.Location = new System.Drawing.Point(156, 160);
            this.exempNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exempNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.exempNumeric.Name = "exempNumeric";
            this.exempNumeric.Size = new System.Drawing.Size(81, 22);
            this.exempNumeric.TabIndex = 4;
            this.exempNumeric.Tag = "";
            this.exempNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Investment Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exemptions";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(114, 206);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(93, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(36, 353);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(93, 30);
            this.summaryButton.TabIndex = 10;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(135, 353);
            this.displayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(93, 30);
            this.displayButton.TabIndex = 11;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(234, 353);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 30);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(135, 403);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 30);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(36, 403);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 30);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayTBox
            // 
            this.displayTBox.Location = new System.Drawing.Point(387, 46);
            this.displayTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayTBox.Multiline = true;
            this.displayTBox.Name = "displayTBox";
            this.displayTBox.ReadOnly = true;
            this.displayTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTBox.Size = new System.Drawing.Size(532, 162);
            this.displayTBox.TabIndex = 15;
            // 
            // enterDataButton
            // 
            this.enterDataButton.Location = new System.Drawing.Point(39, 39);
            this.enterDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterDataButton.Name = "enterDataButton";
            this.enterDataButton.Size = new System.Drawing.Size(117, 34);
            this.enterDataButton.TabIndex = 16;
            this.enterDataButton.Text = "Enter Data";
            this.enterDataButton.UseVisualStyleBackColor = true;
            this.enterDataButton.Click += new System.EventHandler(this.enterDataButton_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.submitButton);
            this.inputGroupBox.Controls.Add(this.label4);
            this.inputGroupBox.Controls.Add(this.label3);
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Controls.Add(this.label1);
            this.inputGroupBox.Controls.Add(this.exempNumeric);
            this.inputGroupBox.Controls.Add(this.investTBox);
            this.inputGroupBox.Controls.Add(this.salaryTBox);
            this.inputGroupBox.Controls.Add(this.marriedCheckBox);
            this.inputGroupBox.Controls.Add(this.nameTBox);
            this.inputGroupBox.Location = new System.Drawing.Point(21, 81);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.inputGroupBox.Size = new System.Drawing.Size(324, 254);
            this.inputGroupBox.TabIndex = 17;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.exemptCountDataGridViewTextBoxColumn,
            this.taxRateDataGridViewTextBoxColumn,
            this.taxAmtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taxpayerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(387, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 175);
            this.dataGridView1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(928, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Created by Ken Prayogo";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(234, 403);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(93, 30);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Total Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exemptCountDataGridViewTextBoxColumn
            // 
            this.exemptCountDataGridViewTextBoxColumn.DataPropertyName = "ExemptCount";
            this.exemptCountDataGridViewTextBoxColumn.HeaderText = "Exemptions";
            this.exemptCountDataGridViewTextBoxColumn.Name = "exemptCountDataGridViewTextBoxColumn";
            this.exemptCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            this.taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.HeaderText = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            this.taxRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxAmtDataGridViewTextBoxColumn
            // 
            this.taxAmtDataGridViewTextBoxColumn.DataPropertyName = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.HeaderText = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.Name = "taxAmtDataGridViewTextBoxColumn";
            this.taxAmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxpayerBindingSource
            // 
            this.taxpayerBindingSource.DataSource = typeof(KPrayogoFinal.Taxpayer);
            // 
            // Form1
            // 
            this.AcceptButton = this.enterDataButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 478);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.enterDataButton);
            this.Controls.Add(this.displayTBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.summaryButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exempNumeric)).EndInit();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.CheckBox marriedCheckBox;
        private System.Windows.Forms.TextBox salaryTBox;
        private System.Windows.Forms.TextBox investTBox;
        private System.Windows.Forms.NumericUpDown exempNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox displayTBox;
        private System.Windows.Forms.Button enterDataButton;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource taxpayerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exemptCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadButton;
    }
}

