namespace SpaceEngineersBackUtility
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.schedule = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cloud = new System.Windows.Forms.TabPage();
            this.restore = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabController.SuspendLayout();
            this.general.SuspendLayout();
            this.schedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.general.Controls.Add(this.groupBox1);
            this.general.Controls.Add(this.button1);
            this.general.Controls.Add(this.label1);
            this.general.Controls.Add(this.textBox1);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(469, 264);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            // 
            // schedule
            // 
            this.schedule.Controls.Add(this.comboBox1);
            this.schedule.Controls.Add(this.checkBox7);
            this.schedule.Controls.Add(this.checkBox6);
            this.schedule.Controls.Add(this.checkBox5);
            this.schedule.Controls.Add(this.checkBox4);
            this.schedule.Controls.Add(this.checkBox3);
            this.schedule.Controls.Add(this.checkBox2);
            this.schedule.Controls.Add(this.checkBox1);
            this.schedule.Location = new System.Drawing.Point(4, 22);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(3);
            this.schedule.Size = new System.Drawing.Size(469, 264);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
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
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(4, 22);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(469, 264);
            this.restore.TabIndex = 3;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "# Backups Today";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Next Backup";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Sun";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(66, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mon";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(225, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Thu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(119, 84);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Tue";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(170, 84);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(49, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Wed";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(276, 84);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(37, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Fri";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(319, 84);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(42, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Sat";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Daily",
            "Weekly ",
            "Monthly "});
            this.comboBox1.Location = new System.Drawing.Point(15, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Backup Options";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 291);
            this.Controls.Add(this.tabController);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabController.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.schedule.ResumeLayout(false);
            this.schedule.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage schedule;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage cloud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage restore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

