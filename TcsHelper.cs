using Precise.Common.Communication.Managers.TCS;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace Brooks_TCS_Demo
{
    public static class TcsHelper
    {
        private static string Tcp_Project_Name = "Tcp_cmd_server_pa";
        private static string Tcp_Project_Path = "/flash/projects/";

        public static bool IsTcsRunning(TCSManager tcsManager)
        {
            var executionDetails = tcsManager.Controller.GetExecutionDetails();
            bool result = executionDetails.ThreadNames.Any(t => t.Contains("Tcp_cmd_server"));
            return result;
        }
        
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

        public static string GetTCSMacroFolder()
        {
            var folder = GetBaseUserDataFolder();
            folder = Path.Combine(folder, "GPL TCS Files");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        private static string GetBaseUserDataFolder()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(folder, "Guidance Development Studio");
        }

        public static void Wait(Func<bool> check, int timeoutMS = 25000)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!check() && stopwatch.ElapsedMilliseconds <= timeoutMS)
            {
                Thread.Sleep(10);
            }
        }


        public static string SendSingleCommand(TCSManager tcsManager, string command, int sleep = 100, int timeout = 5000)
        {
            if (tcsManager.Controller.IsActive)
            {
                tcsManager.CommandText = command;
                Console.WriteLine(string.Format("<-- {0}", command));
                tcsManager.SendCommand();
                TcsHelper.Wait(() => !tcsManager.IsBackgroundExecuting, timeout);
                Thread.Sleep(sleep);
                Console.WriteLine(string.Format("--> {0}", tcsManager.CommandResponse));
                return tcsManager.CommandResponse;
            }
            return string.Empty;
        }



    }
}
