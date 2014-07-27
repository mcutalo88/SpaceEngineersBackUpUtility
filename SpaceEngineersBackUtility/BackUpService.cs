using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SpaceEngineersBackUtility
{
    class BackUpService : ServiceBase
    {
        public BackUpService()
        {
            this.ServiceName = "SpaceEngineersBackUpUtilityService";
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
               
            EventLog.Log = "Initializing backup service..";
        }

        protected override void OnStart(string[] args)
        {
            
            EventLog.Log = "Starting backup service..";
            base.OnStart(args);
        }

        protected override void OnStop()
        {

            base.OnStop();
        }
    }
}