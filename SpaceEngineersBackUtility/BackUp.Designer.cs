namespace SpaceEngineersBackUtility
{
    partial class BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp));
            this.tabController = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.dedicatedServerBackup = new System.Windows.Forms.CheckBox();
            this.localBackup = new System.Windows.Forms.CheckBox();
            this.customSavePath = new System.Windows.Forms.RadioButton();
            this.customSaveInput = new System.Windows.Forms.TextBox();
            this.useDefaultPath = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.schedule = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sched_options = new System.Windows.Forms.ComboBox();
            this.sched_sat = new System.Windows.Forms.CheckBox();
            this.sched_fri = new System.Windows.Forms.CheckBox();
            this.sched_wed = new System.Windows.Forms.CheckBox();
            this.sched_tue = new System.Windows.Forms.CheckBox();
            this.sched_thu = new System.Windows.Forms.CheckBox();
            this.sched_mon = new System.Windows.Forms.CheckBox();
            this.restore = new System.Windows.Forms.TabPage();
            this.cloud = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabController.SuspendLayout();
            this.general.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.general);
            this.tabController.Controls.Add(this.schedule);
            this.tabController.Controls.Add(this.restore);
            this.tabController.Controls.Add(this.cloud);
            this.tabController.Location = new System.Drawing.Point(2, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(477, 290);
            this.tabController.TabIndex = 0;
            // 
            // general
            // 
            this.general.Controls.Add(this.dedicatedServerBackup);
            this.general.Controls.Add(this.localBackup);
            this.general.Controls.Add(this.customSavePath);
            this.general.Controls.Add(this.customSaveInput);
            this.general.Controls.Add(this.useDefaultPath);
            this.general.Controls.Add(this.label10);
            this.general.Controls.Add(this.label9);
            this.general.Controls.Add(this.alert);
            this.general.Controls.Add(this.button2);
            this.general.Controls.Add(this.button4);
            this.general.Controls.Add(this.button3);
            this.general.Controls.Add(this.groupBox1);
            this.general.Controls.Add(this.save);
            this.general.Controls.Add(this.label1);
            this.general.Controls.Add(this.backupPath);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(469, 264);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // dedicatedServerBackup
            // 
            this.dedicatedServerBackup.AutoSize = true;
            this.dedicatedServerBackup.Location = new System.Drawing.Point(164, 44);
            this.dedicatedServerBackup.Name = "dedicatedServerBackup";
            this.dedicatedServerBackup.Size = new System.Drawing.Size(109, 17);
            this.dedicatedServerBackup.TabIndex = 18;
            this.dedicatedServerBackup.Text = "Dedicated Server";
            this.dedicatedServerBackup.UseVisualStyleBackColor = true;
            this.dedicatedServerBackup.CheckedChanged += new System.EventHandler(this.dedicatedServerBackup_CheckedChanged_1);
            // 
            // localBackup
            // 
            this.localBackup.AutoSize = true;
            this.localBackup.Checked = true;
            this.localBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localBackup.Location = new System.Drawing.Point(106, 44);
            this.localBackup.Name = "localBackup";
            this.localBackup.Size = new System.Drawing.Size(52, 17);
            this.localBackup.TabIndex = 17;
            this.localBackup.Text = "Local";
            this.localBackup.UseVisualStyleBackColor = true;
            this.localBackup.CheckedChanged += new System.EventHandler(this.localBackup_CheckedChanged_1);
            // 
            // customSavePath
            // 
            this.customSavePath.AutoSize = true;
            this.customSavePath.Location = new System.Drawing.Point(121, 86);
            this.customSavePath.Name = "customSavePath";
            this.customSavePath.Size = new System.Drawing.Size(85, 17);
            this.customSavePath.TabIndex = 16;
            this.customSavePath.Text = "Custom Path";
            this.customSavePath.UseVisualStyleBackColor = true;
            // 
            // customSaveInput
            // 
            this.customSaveInput.Enabled = false;
            this.customSaveInput.Location = new System.Drawing.Point(121, 112);
            this.customSaveInput.Name = "customSaveInput";
            this.customSaveInput.Size = new System.Drawing.Size(100, 20);
            this.customSaveInput.TabIndex = 15;
            // 
            // useDefaultPath
            // 
            this.useDefaultPath.AutoSize = true;
            this.useDefaultPath.Checked = true;
            this.useDefaultPath.Location = new System.Drawing.Point(9, 86);
            this.useDefaultPath.Name = "useDefaultPath";
            this.useDefaultPath.Size = new System.Drawing.Size(106, 17);
            this.useDefaultPath.TabIndex = 14;
            this.useDefaultPath.TabStop = true;
            this.useDefaultPath.Text = "Use Default Path";
            this.useDefaultPath.UseVisualStyleBackColor = true;
            this.useDefaultPath.CheckedChanged += new System.EventHandler(this.useDefaultPath_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Custom game file path:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Games to backup:";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(16, 141);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 13);
            this.alert.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.select_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(364, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Enable";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(413, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Disable";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Next Backup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "# Backups Today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(388, 234);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup Path";
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(81, 10);
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(326, 20);
            this.backupPath.TabIndex = 0;
            // 
            // schedule
            // 
            this.schedule.Controls.Add(this.radioButton2);
            this.schedule.Controls.Add(this.radioButton1);
            this.schedule.Controls.Add(this.label7);
            this.schedule.Controls.Add(this.label8);
            this.schedule.Controls.Add(this.textBox3);
            this.schedule.Controls.Add(this.textBox2);
            this.schedule.Controls.Add(this.label6);
            this.schedule.Controls.Add(this.sched_options);
            this.schedule.Controls.Add(this.sched_sat);
            this.schedule.Controls.Add(this.sched_fri);
            this.schedule.Controls.Add(this.sched_wed);
            this.schedule.Controls.Add(this.sched_tue);
            this.schedule.Controls.Add(this.sched_thu);
            this.schedule.Controls.Add(this.sched_mon);
            this.schedule.Location = new System.Drawing.Point(4, 22);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(3);
            this.schedule.Size = new System.Drawing.Size(469, 264);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(410, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PM\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(363, 229);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AM\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "hr";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Backup Time";
            // 
            // sched_options
            // 
            this.sched_options.FormattingEnabled = true;
            this.sched_options.Items.AddRange(new object[] {
            "hourly",
            "Daily",
            "Weekly ",
            "Monthly "});
            this.sched_options.Location = new System.Drawing.Point(9, 15);
            this.sched_options.Name = "sched_options";
            this.sched_options.Size = new System.Drawing.Size(121, 21);
            this.sched_options.TabIndex = 7;
            this.sched_options.Text = "Backup Options";
            this.sched_options.SelectedIndexChanged += new System.EventHandler(this.sched_options_SelectedIndexChanged);
            // 
            // sched_sat
            // 
            this.sched_sat.AutoSize = true;
            this.sched_sat.Location = new System.Drawing.Point(259, 52);
            this.sched_sat.Name = "sched_sat";
            this.sched_sat.Size = new System.Drawing.Size(42, 17);
            this.sched_sat.TabIndex = 6;
            this.sched_sat.Text = "Sat";
            this.sched_sat.UseVisualStyleBackColor = true;
            // 
            // sched_fri
            // 
            this.sched_fri.AutoSize = true;
            this.sched_fri.Location = new System.Drawing.Point(216, 52);
            this.sched_fri.Name = "sched_fri";
            this.sched_fri.Size = new System.Drawing.Size(37, 17);
            this.sched_fri.TabIndex = 5;
            this.sched_fri.Text = "Fri";
            this.sched_fri.UseVisualStyleBackColor = true;
            // 
            // sched_wed
            // 
            this.sched_wed.AutoSize = true;
            this.sched_wed.Location = new System.Drawing.Point(110, 52);
            this.sched_wed.Name = "sched_wed";
            this.sched_wed.Size = new System.Drawing.Size(49, 17);
            this.sched_wed.TabIndex = 4;
            this.sched_wed.Text = "Wed";
            this.sched_wed.UseVisualStyleBackColor = true;
            // 
            // sched_tue
            // 
            this.sched_tue.AutoSize = true;
            this.sched_tue.Location = new System.Drawing.Point(59, 52);
            this.sched_tue.Name = "sched_tue";
            this.sched_tue.Size = new System.Drawing.Size(45, 17);
            this.sched_tue.TabIndex = 3;
            this.sched_tue.Text = "Tue";
            this.sched_tue.UseVisualStyleBackColor = true;
            // 
            // sched_thu
            // 
            this.sched_thu.AutoSize = true;
            this.sched_thu.Location = new System.Drawing.Point(165, 52);
            this.sched_thu.Name = "sched_thu";
            this.sched_thu.Size = new System.Drawing.Size(45, 17);
            this.sched_thu.TabIndex = 2;
            this.sched_thu.Text = "Thu";
            this.sched_thu.UseVisualStyleBackColor = true;
            // 
            // sched_mon
            // 
            this.sched_mon.AutoSize = true;
            this.sched_mon.Location = new System.Drawing.Point(9, 52);
            this.sched_mon.Name = "sched_mon";
            this.sched_mon.Size = new System.Drawing.Size(47, 17);
            this.sched_mon.TabIndex = 1;
            this.sched_mon.Text = "Mon";
            this.sched_mon.UseVisualStyleBackColor = true;
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(4, 22);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(469, 264);
            this.restore.TabIndex = 3;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            // 
            // cloud
            // 
            this.cloud.Location = new System.Drawing.Point(4, 22);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(469, 264);
            this.cloud.TabIndex = 2;
            this.cloud.Text = "Cloud";
            this.cloud.UseVisualStyleBackColor = true;
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 291);
            this.Controls.Add(this.tabController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackUp";
            this.Text = "Space Engineers Backup Utility";
            this.tabController.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.schedule.ResumeLayout(false);
            this.schedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage schedule;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage cloud;
        private System.Windows.Forms.TextBox backupPath;
        private System.Windows.Forms.TabPage restore;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox sched_sat;
        private System.Windows.Forms.CheckBox sched_fri;
        private System.Windows.Forms.CheckBox sched_wed;
        private System.Windows.Forms.CheckBox sched_tue;
        private System.Windows.Forms.CheckBox sched_thu;
        private System.Windows.Forms.CheckBox sched_mon;
        private System.Windows.Forms.ComboBox sched_options;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton customSavePath;
        private System.Windows.Forms.TextBox customSaveInput;
        private System.Windows.Forms.RadioButton useDefaultPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox dedicatedServerBackup;
        private System.Windows.Forms.CheckBox localBackup;
    }
}

