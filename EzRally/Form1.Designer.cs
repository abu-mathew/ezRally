namespace EzRally
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTaskAllocation = new System.Windows.Forms.DataGridView();
            this.btnCreateTasks = new System.Windows.Forms.Button();
            this.btnCreateCSV = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetOutputPath = new System.Windows.Forms.Button();
            this.btnSetStoryPath = new System.Windows.Forms.Button();
            this.btnSetTaskPath = new System.Windows.Forms.Button();
            this.btnSetTeamConfigPath = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.txtStoryConfigPath = new System.Windows.Forms.TextBox();
            this.txtTaskConfigPath = new System.Windows.Forms.TextBox();
            this.txtTeamConfigPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFilePaths = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveCommonSettings = new System.Windows.Forms.Button();
            this.nudStoryHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskAllocation)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoryHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTaskAllocation);
            this.tabPage1.Controls.Add(this.btnCreateTasks);
            this.tabPage1.Controls.Add(this.btnCreateCSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTaskAllocation
            // 
            this.dgvTaskAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskAllocation.Location = new System.Drawing.Point(6, 6);
            this.dgvTaskAllocation.Name = "dgvTaskAllocation";
            this.dgvTaskAllocation.Size = new System.Drawing.Size(631, 340);
            this.dgvTaskAllocation.TabIndex = 2;
            // 
            // btnCreateTasks
            // 
            this.btnCreateTasks.Location = new System.Drawing.Point(461, 352);
            this.btnCreateTasks.Name = "btnCreateTasks";
            this.btnCreateTasks.Size = new System.Drawing.Size(95, 23);
            this.btnCreateTasks.TabIndex = 1;
            this.btnCreateTasks.Text = "Generate Tasks";
            this.btnCreateTasks.UseVisualStyleBackColor = true;
            this.btnCreateTasks.Click += new System.EventHandler(this.btnCreateTasks_Click);
            // 
            // btnCreateCSV
            // 
            this.btnCreateCSV.Location = new System.Drawing.Point(562, 352);
            this.btnCreateCSV.Name = "btnCreateCSV";
            this.btnCreateCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCSV.TabIndex = 0;
            this.btnCreateCSV.Text = "Create CSV";
            this.btnCreateCSV.UseVisualStyleBackColor = true;
            this.btnCreateCSV.Click += new System.EventHandler(this.btnCreateCSV_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnSetOutputPath);
            this.tabPage2.Controls.Add(this.btnSetStoryPath);
            this.tabPage2.Controls.Add(this.btnSetTaskPath);
            this.tabPage2.Controls.Add(this.btnSetTeamConfigPath);
            this.tabPage2.Controls.Add(this.txtOutputPath);
            this.tabPage2.Controls.Add(this.txtStoryConfigPath);
            this.tabPage2.Controls.Add(this.txtTaskConfigPath);
            this.tabPage2.Controls.Add(this.txtTeamConfigPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnSaveFilePaths);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Template";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Template";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Template";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSetOutputPath
            // 
            this.btnSetOutputPath.Location = new System.Drawing.Point(504, 124);
            this.btnSetOutputPath.Name = "btnSetOutputPath";
            this.btnSetOutputPath.Size = new System.Drawing.Size(40, 23);
            this.btnSetOutputPath.TabIndex = 15;
            this.btnSetOutputPath.Text = "...";
            this.btnSetOutputPath.UseVisualStyleBackColor = true;
            this.btnSetOutputPath.Click += new System.EventHandler(this.btnSetOutputPath_Click);
            // 
            // btnSetStoryPath
            // 
            this.btnSetStoryPath.Location = new System.Drawing.Point(504, 90);
            this.btnSetStoryPath.Name = "btnSetStoryPath";
            this.btnSetStoryPath.Size = new System.Drawing.Size(40, 23);
            this.btnSetStoryPath.TabIndex = 14;
            this.btnSetStoryPath.Text = "...";
            this.btnSetStoryPath.UseVisualStyleBackColor = true;
            this.btnSetStoryPath.Click += new System.EventHandler(this.btnSetStoryPath_Click);
            // 
            // btnSetTaskPath
            // 
            this.btnSetTaskPath.Location = new System.Drawing.Point(504, 55);
            this.btnSetTaskPath.Name = "btnSetTaskPath";
            this.btnSetTaskPath.Size = new System.Drawing.Size(40, 23);
            this.btnSetTaskPath.TabIndex = 12;
            this.btnSetTaskPath.Text = "...";
            this.btnSetTaskPath.UseVisualStyleBackColor = true;
            this.btnSetTaskPath.Click += new System.EventHandler(this.btnSetTaskPath_Click);
            // 
            // btnSetTeamConfigPath
            // 
            this.btnSetTeamConfigPath.Location = new System.Drawing.Point(504, 16);
            this.btnSetTeamConfigPath.Name = "btnSetTeamConfigPath";
            this.btnSetTeamConfigPath.Size = new System.Drawing.Size(40, 23);
            this.btnSetTeamConfigPath.TabIndex = 11;
            this.btnSetTeamConfigPath.Text = "...";
            this.btnSetTeamConfigPath.UseVisualStyleBackColor = true;
            this.btnSetTeamConfigPath.Click += new System.EventHandler(this.btnSetTeamConfigPath_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(169, 127);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(319, 20);
            this.txtOutputPath.TabIndex = 10;
            // 
            // txtStoryConfigPath
            // 
            this.txtStoryConfigPath.Location = new System.Drawing.Point(169, 93);
            this.txtStoryConfigPath.Name = "txtStoryConfigPath";
            this.txtStoryConfigPath.ReadOnly = true;
            this.txtStoryConfigPath.Size = new System.Drawing.Size(319, 20);
            this.txtStoryConfigPath.TabIndex = 9;
            // 
            // txtTaskConfigPath
            // 
            this.txtTaskConfigPath.Location = new System.Drawing.Point(169, 58);
            this.txtTaskConfigPath.Name = "txtTaskConfigPath";
            this.txtTaskConfigPath.ReadOnly = true;
            this.txtTaskConfigPath.Size = new System.Drawing.Size(319, 20);
            this.txtTaskConfigPath.TabIndex = 7;
            // 
            // txtTeamConfigPath
            // 
            this.txtTeamConfigPath.Location = new System.Drawing.Point(169, 19);
            this.txtTeamConfigPath.Name = "txtTeamConfigPath";
            this.txtTeamConfigPath.ReadOnly = true;
            this.txtTeamConfigPath.Size = new System.Drawing.Size(319, 20);
            this.txtTeamConfigPath.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Output Path: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stories for Sprint: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Configuration: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Configuration: ";
            // 
            // btnSaveFilePaths
            // 
            this.btnSaveFilePaths.Location = new System.Drawing.Point(562, 352);
            this.btnSaveFilePaths.Name = "btnSaveFilePaths";
            this.btnSaveFilePaths.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFilePaths.TabIndex = 0;
            this.btnSaveFilePaths.Text = "Save";
            this.btnSaveFilePaths.UseVisualStyleBackColor = true;
            this.btnSaveFilePaths.Click += new System.EventHandler(this.btnSaveFilePaths_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSaveCommonSettings);
            this.tabPage3.Controls.Add(this.nudStoryHours);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(643, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveCommonSettings
            // 
            this.btnSaveCommonSettings.Location = new System.Drawing.Point(562, 352);
            this.btnSaveCommonSettings.Name = "btnSaveCommonSettings";
            this.btnSaveCommonSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCommonSettings.TabIndex = 2;
            this.btnSaveCommonSettings.Text = "Save";
            this.btnSaveCommonSettings.UseVisualStyleBackColor = true;
            // 
            // nudStoryHours
            // 
            this.nudStoryHours.Location = new System.Drawing.Point(335, 20);
            this.nudStoryHours.Name = "nudStoryHours";
            this.nudStoryHours.Size = new System.Drawing.Size(120, 20);
            this.nudStoryHours.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of hours for 1 Story Point";
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.Filter = "CSV Files|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 431);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskAllocation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoryHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreateTasks;
        private System.Windows.Forms.Button btnCreateCSV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSetOutputPath;
        private System.Windows.Forms.Button btnSetStoryPath;
        private System.Windows.Forms.Button btnSetTaskPath;
        private System.Windows.Forms.Button btnSetTeamConfigPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.TextBox txtStoryConfigPath;
        private System.Windows.Forms.TextBox txtTaskConfigPath;
        private System.Windows.Forms.TextBox txtTeamConfigPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFilePaths;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTaskAllocation;
        private System.Windows.Forms.Button btnSaveCommonSettings;
        private System.Windows.Forms.NumericUpDown nudStoryHours;
        private System.Windows.Forms.Label label6;
    }
}

