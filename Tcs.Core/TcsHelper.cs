using Precise.Common.Communication.Managers.TCS;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace Tcs.Core
{
    public static class TcsHelper
    {
        private static string Tcp_Project_SearchName = "Tcp_cmd_server";
        private static string Tcp_Project_Path = "/flash/projects/";


        public static bool IsTcsRunning(TCSManager tcsManager)
        {
            return ProgramManager.IsProgramRunning(tcsManager.Controller, Tcp_Project_SearchName);
        }

        public static string GetTcsProjectName(TCSManager tcsManager)
        {
            var folders = tcsManager.Controller.FileSystem.GetDirectories(Tcp_Project_Path);
            string result = folders.First(f => f.EntryType == "dir" && f.EntryName.Contains(Tcp_Project_SearchName)).EntryName;
            return result ?? Tcp_Project_SearchName;
        }

        public static string GetTcsThreadName(TCSManager tcsManager)
        {
            var executionDetails = tcsManager.Controller.GetExecutionDetails();
            string result = executionDetails.ThreadNames.FirstOrDefault(t => t.Contains(Tcp_Project_SearchName));
            return result;
        }

        public static bool IsTcsInMemory(TCSManager tcsManager)
        {
            return ProgramManager.IsProgramInMemory(tcsManager.Controller, Tcp_Project_SearchName);
        }
        
        public static void LoadTCS(TCSManager tcsManager, string projectName = "Tcp_cmd_server")
        {
            ProgramManager.LoadProgram(tcsManager.Controller, projectName);
        }

        public static void StartTCS(TCSManager tcsManager)
        {
            if (tcsManager.Controller.IsActive)
            {
                if (IsTcsRunning(tcsManager) == false)
                {
                    string projectName = GetTcsProjectName(tcsManager);
                    LoadTCS(tcsManager, projectName);
                    tcsManager.Controller.CompileProject(projectName);
                    tcsManager.Controller.RunProject(projectName, false);
                }
            }
        }

        public static void StopTCS(TCSManager tcsManager)
        {
            if (tcsManager.Controller.IsActive)
            {
                if (IsTcsRunning(tcsManager))
                {
                    string thread = GetTcsThreadName(tcsManager);
                    tcsManager.Controller.ThreadStop(thread);
                }
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
