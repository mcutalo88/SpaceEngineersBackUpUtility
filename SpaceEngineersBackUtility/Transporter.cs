using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}