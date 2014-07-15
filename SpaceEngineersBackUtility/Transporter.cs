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
        public String destination;
        public String source;
            
        public Transporter()
        {
            this.destination = "";
            this.source = "";
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
                //Validate...
                File.Copy(source, destination);
                //Update the DB - ..
            }
            catch (FileNotFoundException ex){
                Console.Write(ex);
            }
        }
    }
}