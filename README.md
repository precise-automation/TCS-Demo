#### Note
All projects refeence the Tcs.Core library which includes control for robts via TCS or Directly via the ControllerHellper class
Tcs.Core references DLLs from your installed version of GDS
This repository is designed to be a Demonstration of the capabilities of using C# to write custom UIs
There is no plan to release C# API documentation, so please refeence the example Programs
If you like this Repo or have questions, let us know at:  Support_PreciseFlex@brooksautomation.com 


#### Current GDS Versions
GDS must be installed in C:\Program Files\
- Current Tested Version: 5.2.3.16

#### Example Projects

- Demo-AllFeatures - [Under Development] - Example of every possible feature, quite large 
-> Vision programming not yet working 
- Demo_SLAS - [Stable] - Program shown at SLAS 2025 Tradeshow 
- Demo_Exmaple5 - [Stable] - Example Controlling Robot Programs, Variables, and Jog Control without using TCS
- Demo_Example4 - [Stable] - Example using Jog Control for Fine Point Location Teaching
- Demo_Modbus - [Stable] - Example Interface for using robot as Slave Modbus device
-> Need to set Data ID 560 to "255.255.255.255" before use
-> Support Slave ID 255 and Holding Registers 0-15
