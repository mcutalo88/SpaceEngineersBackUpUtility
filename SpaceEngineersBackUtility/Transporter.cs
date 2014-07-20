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
        public bool isDefaultPath  {get; set;}     //Will use DEFAULT_PATH games files and back them up.    
        public bool isDafaultServer{get; set;}     //Will use DEFAULT_SERVER_PATH game files and back them up.
        public bool isLocal        {get; set;}     //if true: local games will be saved, False: server games will be saved.

        private static string DEFAULT_PATH        = Environment.ExpandEnvironmentVariables("%AppData%\\SpaceEngineers\\Saves");      //Default save for all local games.
        private static string DEFAULT_SERVER_PATH = Environment.ExpandEnvironmentVariables("%programdata%\\SpaceEngineersDedicated");//Default save for all dedicated server games.

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
        public bool backUp(){                        
            if (isLocal)
            {
                if (isDefaultPath)
                    return this.moveFiles(DEFAULT_PATH);
                else
                    return this.moveFiles(source);
            }
            else
            {
                if (isDafaultServer)
                    return this.moveFiles(DEFAULT_SERVER_PATH);
                else
                    return this.moveFiles(source);
            }            
        }

        private bool moveFiles(string currentSelectedPath){
           DirectoryInfo folderName;
           FileAttributes attr;

           try
           {
               String[] hold = Directory.GetFileSystemEntries(currentSelectedPath);
               hold = Directory.GetFileSystemEntries(hold[0]);

               Directory.CreateDirectory(destination + "\\" + DateTime.Now.ToString("MM-dd-yyyy"));
               destination += "\\" + DateTime.Now.ToString("MM-dd-yyyy");

               for (int content = 0; content < hold.Length; content++)
               { // iterates through folders 
                   attr = File.GetAttributes(hold[content]); // gets path of file or folder
                   if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                   { // checks to see if it's a dir 

                       folderName = new DirectoryInfo(hold[content]);
                       Directory.CreateDirectory(destination + "\\" + folderName.Name);

                       foreach (string iterFile in Directory.GetFileSystemEntries(hold[content]))
                       { // iterates through the files in a folder 
                           System.IO.FileInfo fi = new System.IO.FileInfo(iterFile);
                           File.Copy(iterFile, destination + "\\" + folderName.Name + "\\" + fi.Name);
                       }
                   }
                   else
                   {
                       System.IO.FileInfo fi = new System.IO.FileInfo(hold[content]);
                       File.Copy(hold[content], destination + "\\" + fi.Name);
                   }
               }

               return true;
           }
           catch (FileNotFoundException ex)
           {
               Console.WriteLine(ex.StackTrace);
               return false;
           }
           catch (IOException e)
           {
               Console.WriteLine(e.StackTrace);
               return false;
           }           
        }

    }
}