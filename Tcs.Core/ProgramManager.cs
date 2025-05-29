using Precise.Common.Communication.Controllers;
using System.Linq;
using System.Threading;

namespace Tcs.Core
{
    public static class ProgramManager
    {
        private static string Flash_Project_Path = "/flash/projects/";
        private static string Memory_Project_Path = "/GPL/";

        public static bool IsProgramInMemory(ControllerHelper controller, string projectName)
        {
            var folders = controller.FileSystem.GetDirectories(Memory_Project_Path);

            bool result = folders.Any(f => f.EntryType == "dir" && f.EntryName.Contains(projectName));
            return result;
        }

        public static bool IsProgramRunning(ControllerHelper controller, string projectName)
        {
            var executionDetails = controller.GetExecutionDetails();
            bool result = executionDetails.ThreadNames.Any(t => t.Contains(projectName));
            return result;
        }

        public static string GetProgramThreadName(ControllerHelper controller, string projectName)
        {
            var executionDetails = controller.GetExecutionDetails();
            string result = executionDetails.ThreadNames.FirstOrDefault(t => t.Contains(projectName));
            return result;
        }

        public static void LoadProgram(ControllerHelper controller, string projectName)
        {
            if (controller.IsActive)
                if (IsProgramRunning(controller, projectName) == false)
                    if (IsProgramInMemory(controller, projectName) == false)
                    {
                        controller.LoadProject(Flash_Project_Path, projectName);

                        // Wait for TCS to Load
                        int count = 0;
                        do
                        {
                            Thread.Sleep(250);
                            count++;
                        } while (IsProgramInMemory(controller, projectName) == false && count < 4 * 10);
                    }
        }

        public static void StartProgram(ControllerHelper controller, string projectName)
        {
            if (controller.IsActive)
            {
                if (IsProgramInMemory(controller, projectName) == false)
                {
                    LoadProgram(controller, projectName);
                }

                controller.CompileProject(projectName);
                controller.RunProject(projectName, false);
                
            }
        }

        public static void StopProgram(ControllerHelper controller, string projectName)
        {
            if (controller.IsActive)
            {
                if (IsProgramRunning(controller, projectName))
                {
                    string thread = GetProgramThreadName(controller, projectName);
                    controller.ThreadStop(thread);
                }
            }
        }

        public static void StopAllPrograms(ControllerHelper controller)
        {
            if (controller.IsActive)
            {
                controller.ThreadStopAll();
            }
        }
    }
}
