using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brooks_TCS_Demo
{
    public static class TcsProjectManager
    {
        private static string Tcp_Project_Name = "Tcp_cmd_server_pa";
        private static string Tcp_Project_Path = "/flash/projects/";

        public static void LoadTCS(TCSManager tcsManager)
        {
            if (tcsManager.Controller.IsActive)
                tcsManager.Controller.LoadProject(Tcp_Project_Path, Tcp_Project_Name);
        }

        public static void StartTCS(TCSManager tcsManager)
        {
            if (tcsManager.Controller.IsActive)
            {
                tcsManager.Controller.CompileProject(Tcp_Project_Name);
                tcsManager.Controller.RunProject(Tcp_Project_Name, false);
            }
        }

        public static void StopTCS(TCSManager tcsManager)
        {
            if (tcsManager.Controller.IsActive)
            {
                tcsManager.Controller.ThreadStopAll();
                tcsManager.Controller.UnloadProject(Tcp_Project_Name);
            }
        }
    }
}
