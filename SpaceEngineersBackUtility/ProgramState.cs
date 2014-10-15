using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineersBackUtility
{
    class ProgramState
    {
        String backupPath;
        bool localBackup; 
        bool dedicatedSErverBackup;
        bool useDefaultPath;
        bool customSavePath; 
        String customeSaveInput;  
        bool button4;
        bool button3; 

      public ProgramState()
      {
          this.backupPath = "";
          this.localBackup = true;
          this.dedicatedSErverBackup = true;
          this.useDefaultPath = true;
          this.customeSaveInput = "";
          this.button4 = true;
          this.button3 = true; 
   
      }
       
      /* Saves user input from the UI. **/  
      public void SaveInput(String backupPath, bool localBackup, bool dedicatedServerBackup, bool useDefaultPath, bool customSavePath, String customeSaveInput, bool button4, bool button3)
      {
          SpaceEngineerLINQDataContext dc = new SpaceEngineerLINQDataContext();
          Table<UiSaveState> t = dc.GetTable<UiSaveState>();
          List <UiSaveState> saveState= new List <UiSaveState>();
          UiSaveState back = new UiSaveState();
          int size=saveState.Count(); 
 
          if (size>1)
          {
              saveState.Clear(); 
          }
          else
          {
            
             saveState.Add(); 
          }

          
          
          dc.LocalBackups.InsertOnSubmit(back);
          dc.SubmitChanges();

          
      }
    }
    
   

}
