using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineersBackUtility
{
    class SpaceEngineerDAO
    {
        DataContext db = new DataContext(@"space_eng_util_db.mdf");        
         
        string backupPath;         // textbox holding seleected path 
        bool localBackup;           // checkbox for localbackup 
        bool dedicatedServerBackup; // checkbox for dedicatedServerBackup 
        bool useDefaultPath;        // radiobutton for useDefaultPath 
        bool customSavePath;        // radiobutton for customeSavePath 
        bool enable;                // enable button
        bool disable;               // disable button
        string numBackups;          // holds number of backups status today 
        string lastBackup;          // last backup status
        string nextBackup;          // next scheduled backup  
        
        public SpaceEngineerDAO(){
        }

        public string getBackupPath(){
            return backupPath; 
        }
        public void setBackupPath(string hold){
            this.backupPath = hold; 
        }

        public void writeToDBTest(){
           SpaceEngineerLINQDataContext dc = new SpaceEngineerLINQDataContext();
           Table<LocalBackup> t = dc.GetTable<LocalBackup>();
           LocalBackup back = new LocalBackup();

           
           back.Origin = "Poop";
           dc.LocalBackups.InsertOnSubmit(back);   
           dc.SubmitChanges(ConflictMode.ContinueOnConflict);
            //var holdquery = from p in db.GetTable<LocalBackup>() select p.Origin;
            
        }


    }
}
