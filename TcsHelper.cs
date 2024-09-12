using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Brooks_TCS_Demo
{
    public static class TcsHelper
    {
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
    }
}
