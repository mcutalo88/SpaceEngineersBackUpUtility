﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Linq; 

namespace SpaceEngineersBackUtility
{
    public partial class BackUp : Form
    {
        Transporter teleport = new Transporter();

        public BackUp()
        {
            InitializeComponent();
        }

        private void general_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog fbd = new FolderBrowserDialog();
           fbd.ShowDialog(); // opens fileBroweser 
           backupPath.Text = fbd.SelectedPath; //Grabs the filepath from object 
        }

        private void save_Click(object sender, EventArgs e)
        {
            backupType();

            if (!String.IsNullOrEmpty(backupPath.Text)){

                teleport.destination = backupPath.Text;
                teleport.isDefaultPath = true;                

                if (teleport.backUp())
                {
                    alert.Show();
                    alert.ForeColor = Color.Green;
                    alert.Text = "Successfully backed up game files.";
                }else{
                    alert.Show();
                    alert.ForeColor = Color.Red;
                    alert.Text = "Error occured when trying to move game files.";
                }
                
            }else{
                alert.Show();                
                alert.Text = "Please fill out Backup Path.";
            }

            ////DataContext db = new DataContext("space_eng.util.db.mdf");

            //SpaceEngineerLINQDataContext dc = new SpaceEngineerLINQDataContext();
            ////var q = from a in dc.GetTable<LocalBackup>() select a.Origin; // Query Db

            //Table<LocalBackup> t = dc.GetTable<LocalBackup>();

            //LocalBackup back = new LocalBackup();
            //back.Origin = "TEST INSERT";
            //back.Destination = "TEST 12312312";

            //dc.LocalBackups.InsertOnSubmit(back);
            //dc.SubmitChanges(ConflictMode.ContinueOnConflict);

            ////t.InsertOnSubmit(back);
            ////t.Context.SubmitChanges();           
        }

        private void useDefaultPath_CheckedChanged(object sender, EventArgs e)
        {
            if (useDefaultPath.Checked == false &&
                customSavePath.Checked == true)
            {
                customSaveInput.Enabled = true;
            }
            else            
                customSaveInput.Enabled = false;            
        }

        private void backupType()
        {
            if (localBackup.Checked)
                teleport.isLocal = true;
            else if (dedicatedServerBackup.Checked)
                teleport.isLocal = false;
            
            if(localBackup.Checked && dedicatedServerBackup.Checked)
                Console.WriteLine("TODO: DO this choicenesss..");

            //TODO: write backup for both local and server... b/c server could be running on personal machine
        }

        private void sched_options_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (sched_options.SelectedItem == "hourly")
            {
                teleport.startBackupSequence();
            }
        }

        private void localBackup_CheckedChanged_1(object sender, EventArgs e)
        {
            backupType();
        }

        private void dedicatedServerBackup_CheckedChanged_1(object sender, EventArgs e)
        {
            backupType();
        }

        private void schedule_Click(object sender, EventArgs e)
        {

        }

    }
}
