using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public static class RobotTcsCmds
    {

        public static bool RobotInit(TCSManager tcsManager)
        {
            bool status = true;
            try
            {
                status &= EnableHighPower(tcsManager);
                status &= AttachRobot(tcsManager);
                status &= HomeRobot(tcsManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Robot Init");
                return false;
            }
            return status;
        }

        public static bool EnableHighPower(TCSManager tcsManager)
        {
            TcsHelper.SendSingleCommand(tcsManager, "hp 1");
            bool result = WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLReady, 10 * 1000);
            Thread.Sleep(250);
            return result;
        }
        public static bool AttachRobot(TCSManager tcsManager)
        {
            TcsHelper.SendSingleCommand(tcsManager, "Attach 1");
            return WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLAttached);
        }
        public static bool HomeRobot(TCSManager tcsManager)
        {
            bool state;
            TcsHelper.SendSingleCommand(tcsManager, "homeAll", 1000);
            if (WaitForRobotPowerState(tcsManager, PowerAutoExecStates.RobotsHoming, 5 * 1000) == false)
                return false;
            if (WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLReady, 30 * 1000) == false)
                return false;
            return true;
        }

        public static bool WaitForRobotPowerState(TCSManager tcsManager, PowerAutoExecStates state = PowerAutoExecStates.GPLReady, int timeoutMS = 10000)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds <= timeoutMS)
            {
                if (tcsManager.Controller.OperationInfo.CurrentPowerAutoExecState == state)
                    return true;
                Thread.Sleep(10);
            }
            return false;
        }

        public static bool WaitForNotRobotPowerState(TCSManager tcsManager, PowerAutoExecStates state = PowerAutoExecStates.GPLReady, int timeoutMS = 30000)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds <= timeoutMS)
            {
                if (tcsManager.Controller.OperationInfo.CurrentPowerAutoExecState != state)
                    return true;
                Thread.Sleep(10);
            }
            return false;
        }

        public static bool SetFreeMode(TCSManager tcsManager, bool enable)
        {
            try
            {
                if (tcsManager.Controller.IsActive)
                {
                    if (enable)
                    {
                        TcsHelper.SendSingleCommand(tcsManager, "Attach 1");
                        TcsHelper.SendSingleCommand(tcsManager, "FreeMode 0");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        TcsHelper.SendSingleCommand(tcsManager, "FreeMode -1");
                        
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured while setting free mode");
                return false; 
            }
        }

        public static bool ToggleHighPower(TCSManager tcsManager)
        {
            try
            {
                if (tcsManager.Controller.IsActive)
                {
                    if (tcsManager.Controller.OperationInfo.IsPowerEnabled)
                        TcsHelper.SendSingleCommand(tcsManager, "hp 0", 500);
                    else
                        EnableHighPower(tcsManager);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured while toggling high power");
                return false;
            }
        }

        public static bool IsRobotInFreeMode(TCSManager tcsManager)
        {
            // Check
            // Power Enabled == true
            // 3520 == jog mode
            // 12100 == axis is in torque control mode
            // Result -> FreeMode Enabled = True
            bool result = true;
            int robotNumber = 1;

            // Power Enabled
            var powerState = tcsManager.Controller.OperationInfo.CurrentPowerState;
            result &= powerState >= PowerStates.AutoModeWaiting;

            // Check if in Jog Mode (DataID 3520)
            var trajGenState = tcsManager.Controller.DatalogInfo.GetTrajectoryGeneratorState(robotNumber);
            result &= trajGenState == TrajectoryGeneratorState.PositionControlJogMode;

            // Check if in Torque Control Mode
            bool inTorqueControlMode = IsInTorqueControlMode(tcsManager);
            result &= inTorqueControlMode;

            return result;
        }


        public static bool IsInTorqueControlMode(TCSManager tcsManager, int robotNumber=1)
        {
            int bitMask = 0b10000010; // Need to figure out the correct mask here (Probably Bit 1 and 8 (Zero based))

            int result = ReadDataID(tcsManager, (int)ParameterDatabase.AxisDynamic_AxisOperationMode);

            return (result & bitMask) > 0;
        }

        public static int ReadDataID(TCSManager tcsManager, int DataID, int robotNum = 1, int dataUnit = 0, int arrayIndex= 0)
        {
            DataIDObj dataIDObj = new DataIDObj();
            dataIDObj.objDataID = DataID;
            dataIDObj.objDataUnit1 = robotNum;
            dataIDObj.objDataUnit2 = dataUnit;
            dataIDObj.objArrayIdx = arrayIndex;

            tcsManager.Controller.Handle.DataIdGet(ref dataIDObj);

            int result;
            if (int.TryParse(dataIDObj.objDataValue, out result) == false)
                return dataIDObj.objStatusCode;
            return result;
        }



    }
}
