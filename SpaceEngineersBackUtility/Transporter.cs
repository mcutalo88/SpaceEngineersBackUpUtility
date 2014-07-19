using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;  
using System.IO;

namespace SpaceEngineersBackUtility
{
    class Transporter
    {
        public string destination  {get; set;}     //The path the user wants to move his saved games to.
        public string source       {get; set;}     //Custom source path where users saved games reside.
        public bool isDefaultPath  {get; set;}    
        public bool isDafaultServer{get; set;}
        public bool isLocal        {get; set;}     //if true: local games will be saved, False: server games will be saved.

        //Constants
        private static string DEFAULT_PATH          =  Environment.ExpandEnvironmentVariables("%AppData%\\SpaceEngineers\\Saves");     //Default save for all local games.
        private static string DEFAULT_SERVER_PATH = @"\%programdata%\SpaceEngineersDedicated";                       //Default save for all dedicated server games.

        public Transporter(){
            this.destination     = "";
            this.source          = "";
            this.isDefaultPath   = true;
            this.isDafaultServer = true;
            this.isLocal         = true;
        }

        /*
         * Validate File that source is pointing too.
         */
        public Boolean validateFile(){

            if (File.Exists(source))
                return true;
            else
                return false;
        }

        /*
         * Moves File to the destination.
         * TODO: make backup a service.
         */
        public void backUp(){
            
            try{
                if (isLocal)
                {
                    if (isDefaultPath)
                        
                        File.Copy(DEFAULT_PATH, destination);                      
                    else
                        //Err checking
                        File.Copy(source, destination);
                }
                else
                {
                    if (isDafaultServer)
                        
                        File.Copy(DEFAULT_SERVER_PATH, destination);
                    else
                        //Err Checking                        
                        File.Copy(source, destination);
                }
            }
            catch (FileNotFoundException ex){
                Console.Write(ex);
            }
        }
        public void doBackUp(){
           DirectoryInfo folderName;
           FileAttributes attr; 
           String [] hold = Directory.GetFileSystemEntries(DEFAULT_PATH);
           hold= Directory.GetFileSystemEntries(hold[0]);
         
           for (int content = 0; content < hold.Length; content++ ){ // iterates through folders 
                attr = File.GetAttributes(hold[content]); // gets path of file or folder
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory){ // checks to see if it's a dir 
                    
                    folderName = new DirectoryInfo(hold[content]);
                    Directory.CreateDirectory(destination + "\\"+folderName.Name); 

                    foreach (string iterFile in Directory.GetFileSystemEntries(hold[content])){ // iterates through the files in a folder 
                        System.IO.FileInfo fi = new System.IO.FileInfo(iterFile);
                        File.Copy(iterFile, destination + "\\"+folderName.Name +"\\"+fi.Name);
                    }

                }else{
                    System.IO.FileInfo fi = new System.IO.FileInfo(hold[content]);
                    File.Copy(hold[content],destination+"\\"+fi.Name); 
                }
           }
        }
    }
}