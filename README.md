# Profitability Tool
Copyright to [FTI Touristik GmbH](http://www.fti.de/)

```Profitability Tool``` a VB.NET Desktop Application that imports daily bookings information and store them, it mainly aims to:
- Settle the margin profitability for **Meeting Point International** *(difference between purchase & sales price)*.
- Settle the calculations deficit between **Meeting Point International** and its different **tour operators**.

## Installation
1. The [SQL database](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Database%20Script.sql) needs to be hosted into SQL Server. A full database schema is included [here](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Database%20Script.sql).
2. Copy the files in Debug Folder into the client machines.
3. Run the executive file ```Profitability_Tool.exe```.

## Application Running

Once you open the Profitability Tool.exe file the following happens:

- A login screen shows up.

![Login](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Login.png "Login Screen")

- When logged-in, the application main screen shows:

![Main Screen](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Main.png "Main Screen")

## User Permissions
There are four different user profiles with different authority levels:
1. **Admin:** A user profile with the highest permission levels, and aimed to manage user accounts.
2. **RS (Red Sea):** A user profile with permissions to ```import, edit``` booking entries.
3. **DMC:** A user profile with no permissions to ```edit``` bookings data, and with permissions to ```create comments``` and to change the bookings status to:

    > Fixed DMC 

    > Pending DMC

    > Pending T/O
4. **TO (Tour Operator):** A user profile with no permissions to ```edit``` bookings data, and with permissions to ```create comments``` and to change the bookings status to:

    > Fixed T/O

    > Pending DMC

    > Pending T/O
    **Note:** You can change user permission level any time.

## Pre-Configurations
In order to have the ```Profitability Tool``` running properly, you need to configure the below:
- **Destinations:** You can find it in the ```Destination``` button in ```Administration``` ribbon group. Every destination should be defined as 2 Letter code and full destination name *(e.g. Code:'EG', Destination: 'Egypt')*.
- **Tour Operators:** You can find it in the ```T/O``` button in ```Administration``` ribbon group.
- **Currency Exchange:** You can find it in the ```Currency``` button in ```Administration``` ribbon group. Every Currency can be defined with multiple rates based on travel dates.
- **Margin:** You can find it in the ```Margin``` button in ```Administration``` ribbon group. The margin includes the acceptable margin difference between the purchase price and sales price, also the acceptabled calculation descrepancy between the ```DMC``` sales calculation and the ```Tour Operator``` cost calculation. The margin should be defined against each destination and tour operator.
- **Users Visibility** To be more secured every single user needs to be granted permission to see which destination and which tour operator. In order to set that, user ```Manage Users``` button in ```Administration``` ribbon group, select the user, and then press button ```Options```.


## Application Screenshots

## Requirements
- Windows 7 Service Pack 1, Windows 8, Windows 8.1, Windows Server 2008 R2 SP1, Windows Server 2008 Service Pack 2, Windows Server 2012, Windows Server 2012 R2, Windows Vista Service Pack 2
- .NET Framework v4.5.2 or higher installed on the client machines.
- 1 GHz or faster processor
- 512 MB of RAM
- 4.5 GB of available hard disk space (x86)
- 4.5 GB of available hard disk space (x64)
- For maintanance a [DevExpress WinForms](https://www.devexpress.com/products/net/controls/winforms/) is needed & [VS.NET](https://visualstudio.microsoft.com/vs/).

## Software License
Commercial Software.
