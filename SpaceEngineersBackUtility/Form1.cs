using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace SpaceEngineersBackUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void backupPath_TextChanged(object sender, EventArgs e)
        {
            Transporter teleport = new Transporter();            
        }

        private void save_Click(object sender, EventArgs e)
        {
            Transporter teleport = new Transporter();
            if (!String.IsNullOrEmpty(backupPath.Text)){

                teleport.destination = backupPath.Text;
                teleport.isDefaultPath = true;
                teleport.isLocal = true; //change if user wants to save server meeps
                teleport.doBackUp();
                
            }else{
                error.Show();                
                error.Text = "Please fill out Backup Path.";

            }
               
            
        }
    }
}
