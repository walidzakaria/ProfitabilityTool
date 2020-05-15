# Profitability Tool
Copyright to [FTI Touristik](http://www.fti.de/)

This is a VB.NET windows application that imports daily bookings information, and aims to settle the margin profitability for **Meeting Point Internation**, and also to settle the calculation deficit between it and the different tour operators.

## Installation
1. The SQL database needs to be hosted into SQL Server. A full database schema is included here.
2. Copy the files in Debug Folder into the client machines.
3. Run the executive file Profitability Tool.exe.

## Application Running

Once you open the Profitability Tool.exe file the following happens:

- A login screen shows up.
- When loggin, the application main screen shows:

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

### Pre-Configurations
```

```

## Application Screenshots

## Requirements
- Windows 7 Service Pack 1, Windows 8, Windows 8.1, Windows Server 2008 R2 SP1, Windows Server 2008 Service Pack 2, Windows Server 2012, Windows Server 2012 R2, Windows Vista Service Pack 2
- .NET Framework v4.5.2 or higher installed on the client machines.
- 1 GHz or faster processor
- 512 MB of RAM
- 4.5 GB of available hard disk space (x86)
- 4.5 GB of available hard disk space (x64)
- For maintanance a [DevExpress WinForms](https://www.devexpress.com/products/net/controls/winforms/) is needed & [VS.NET](https://visualstudio.microsoft.com/vs/).