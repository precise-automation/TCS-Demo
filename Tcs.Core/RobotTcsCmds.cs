﻿using Precise.Common.Communication.Controllers;
using Precise.Common.Communication.Managers.TCS;
using Precise.Common.Communication.Protocols.GplComm;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Tcs.Core
{
    public static class RobotTcsCmds
    {

        public static bool RobotInit(TCSManager tcsManager, bool homeRobot = false)
        {
            if (tcsManager.Controller.IsActive == false) return false;

            bool status = true;
            try
            {
                status &= SetHighPower(tcsManager);
                status &= AttachRobot(tcsManager);
                if(homeRobot)
                    status &= HomeRobot(tcsManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Robot Init");
                return false;
            }
            return status;
        }

        public static bool SetHighPower(TCSManager tcsManager, bool state = true, bool waitForResponse = true)
        {
            if (tcsManager.Controller.IsActive == false) return false;

            if (state)
            {
                TcsHelper.SendSingleCommand(tcsManager, "hp 1");
               return !waitForResponse || WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLReady, 10 * 1000);

            }
            else
            {
                TcsHelper.SendSingleCommand(tcsManager, "hp 0");
                return true;
            }
            return false;
        }
        public static bool AttachRobot(TCSManager tcsManager, bool state = true, bool waitForResponse = true)
        {
            if (tcsManager.Controller.IsActive == false) return false;

            if (state)
            {
                TcsHelper.SendSingleCommand(tcsManager, "Attach 1");
                return !waitForResponse || WaitForRobotPowerState(tcsManager, PowerAutoExecStates.GPLAttached);
            }
            else
            {
                TcsHelper.SendSingleCommand(tcsManager, "Attach 0");
                return true;
            }
        }
        public static bool HomeRobot(TCSManager tcsManager, bool waitForResponse = true)
        {
            if (tcsManager.Controller.IsActive == false) return false;
            
            TcsHelper.SendSingleCommand(tcsManager, "homeAll", 1000);
            if (waitForResponse == false) return true;

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

        public static bool SetFreeMode(TCSManager tcsManager, bool enable, bool waitForEnable = true)
        {
            try
            {
                if (tcsManager.Controller.IsActive == false) return false;

                if (enable)
                {
                    TcsHelper.SendSingleCommand(tcsManager, "FreeMode 0");

                    if(waitForEnable) Thread.Sleep(3000);
                }
                else
                {
                    TcsHelper.SendSingleCommand(tcsManager, "FreeMode -1");
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
                if (tcsManager.Controller.IsActive == false) return false;

                if (tcsManager.Controller.OperationInfo.IsPowerEnabled)
                        TcsHelper.SendSingleCommand(tcsManager, "hp 0", 500);
                    else
                        SetHighPower(tcsManager);
                
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
            // As a work around check the following:
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
            DataIDObj dataIDObj = new DataIDObj() {
                objDataID = DataID,
                objDataUnit1 = robotNum,
                objDataUnit2 = dataUnit,
                objArrayIdx = arrayIndex
            };
            
            tcsManager.Controller.Handle.DataIdGet(ref dataIDObj);

            int result;
            if (int.TryParse(dataIDObj.objDataValue, out result) == false)
                return dataIDObj.objStatusCode;
            return result;
        }



    }
}
