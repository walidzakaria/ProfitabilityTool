# Profitability Tool© ![Logo](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/profitability_logo.png)
Copyright to [FTI Touristik GmbH](http://www.fti.de/).

```Profitability Tool``` is a VB.NET Desktop Application that imports daily bookings information and store them. ```Profitability Tool``` mainly aims to:
- Settle the margin profitability for **Meeting Point** *(difference between purchase & sales price)*.
- Settle the calculations deficit between **Meeting Point** and the **Tour Operators**.

## Installation
1. The [SQL database](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Database%20Script.sql) needs to be hosted into SQL Server. A full database schema is included [here](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Database%20Script.sql).
2. Copy the files in Debug Folder into the client machines.
3. Create a shortcut to the executive file ```Profitability_Tool.exe``` into the user desktops.
3. Run the executive file ```Profitability_Tool.exe``` or the shortcut referring to it.

## Application Running

Once you open the ```Profitability Tool``` the following happens:

- A login screen shows up.

    ![Login](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Login.png "Login Screen")

- When logged-in, the application main screen shows:

    ![Main Screen](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Main.png "Main Screen")

## User Permissions
There are four different user profiles with different authority levels:
1. **Admin:** A user profile with the highest permission levels, and aimed to manage user accounts, and modify bookings.
2. **RS (Red Sea):** A user profile with permissions to ```import & edit``` booking entries.
3. **DMC:** A user profile with no permissions to ```edit``` bookings data, and with permissions to ```create comments``` and to change the bookings status to:
    - Fixed DMC 
    - Pending DMC
    - Pending T/O
4. **TO (Tour Operator):** A user profile with no permissions to ```edit``` bookings data, and with permissions to ```create comments``` and to change the bookings status to:
    - Fixed T/O
    - Pending DMC
    - Pending T/O

>**Note:** You can change user permission level any time.

## Pre-Configurations

![Administration](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Administration.png "Administration")

In order to have ```Profitability Tool``` running properly, you need to configure the below:
- **Destinations:** You can find it in the ```Destination``` button in ```Administration``` ribbon group. Every destination should be defined as 2 Letter code and full destination name *(e.g. Code: "EG", Destination: "Egypt")*.

  ![Destinations](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Destinations.png "Destinations")

- **Tour Operators:** You can find it in the ```T/O``` button in ```Administration``` ribbon group.
  
  ![Tour Operators](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Tour_Operators.png "Tour Operators")

- **Currency Exchange:** You can find it in the ```Currency``` button in ```Administration``` ribbon group. Every Currency can be defined with multiple rates based on travel dates.

  ![Currency Exchange](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Currency.png "Currency Exchange")

- **Margins:** You can find it in the ```Margin``` button in ```Administration``` ribbon group. The margin includes the acceptable margin difference range between the purchase price and sales price, also the acceptable calculation discrepancy range between the ```DMC``` sales calculation and the ```Tour Operator``` cost calculation. The margin should be defined against each destination and tour operator.

  ![Margins](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Manage_Margins.png "Margins")

- **Users Visibility** To be more secured every single user needs to be granted permission to see which destination and which tour operator. In order to set that, use ```Manage Users``` button in ```Administration``` ribbon group, select the respective user, and then press button ```Options```.

  ![User Options](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/User_Options.png "User Options")

  Select the user valid destinations & Tour Operators, and ```Save```.

## Application Operations
### Importing New Bookings

![Importing Data](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Data_ribbon_group.png "Importing Data")


1. Open the Excel report of the daily bookings, select all rows except for the header, and copy.
2. Go to ```Profitability Tool``` and press button ```Import``` in ```Data``` ribbon group.
3. Remove any undesired rows by selecting them, and pressing ```Del``` key.
4. Save the imported bookings, by clicking ```Save``` button in ```Data``` ribbon group. Make sure that there is no error message pops up, if so, please contact us.
5. Check if any bookings have missing parameters by clicking on ```Errors``` button in ```Data``` ribbon group. If any bookings appear, you can open every booking, and check the error log.

    ![Missing Paramters Log](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Booking_Information_Other_Log.png "Missing Parameters Log")

6. Fix the missing parameters, and resave the bookings again in order to recalculate those errors with the new parameters.
7. You can edit a saved booking by double-clicking it, change the data, and ```save```.


### Showing Saved Data
![Showing Data](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Show_and_deficit.png "Showing Data")

After saving the booking, they are automatically categorized as:
- **Junk:** Junk bookings are those that have one of the following criteria:
    - Status = "BNA", or "OnR".
    - MarginCheck = "Option".
    - NetRateHotelTC < 1
    - HotelName contains "rundreise", "circuit", or "roulette".
- **Canceled:** Cancelled bookings are those that have status as "CNX".
- **Matching:** Matching bookings are those that fulfill all ```Matching Criteria```.
- **Deficit:** Deficit bookings are those that don't fulfil one or more of the ```Matching Criteria```.

#### Those are the Matching Criteria:
- **No negative margin:** Sales price is higher than the purchase price.
- **No excessive margin:** The difference between the sales price and purchase price is within the range of the respective  margin range.
- **No mismatch:** The difference between the DMC sales price and the tour operator cost price is within the range of the respective margin range.

### Filtering the Bookings:
You can select the desired bookings category by selecting the following:
1. Select the target destination.
2. Select travel date from/to.
3. Click on the respective category button (Junk, Canceled, Matching, Deficit).
Then the bookings show up in ```Profitability Tool``` grid.
You can set further advanced filtrations using the grid powerful interactive filtration options. The grid has the below options:
- **Find:** You can search for any part in any column by pressing ```CTRL + F```.
- **Filter:** You can add a filter to any column by hovering over the column header, the filter symbol will appear, click on it, and set the desired filter criteria.
- **Grouping:** You can group the rows against any desired column(s), and on multiple levels. This can be done by selecting the header of the desired column, then *drag & drop* it into the upper part of the grid *(group panel)*.
- **Sorting:** You can sort the rows by clicking on the desired column header. You can sort from *Ascending* to *Descending* or vice versa by repeating the mouse click.
- **Rearranging Columns:** Drag the column headers into the desired order.
- **Show/Hide Columns:** You can hide any column by dragging its header away from the grid. To show it again, right-click on any column header, and select ```Column Chooser``` a window will appear with all the hidden columns, double-click in the desired column you want to show.

### Changing Booking(s) Status
After showing the desired category, and applying the needed filtrations, you can change the booking(s) status by:
- Double-Click on the selected booking if a single selection.
- Pressing ```Enter``` key if bulk selection.

    ![Disputes](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Booking_Disputes.png "Disputes")

Then the comments/disputes window shows. In this window, you can see the older disputes and comments thread, and you can also create a new comment by following the below steps:
1. Click on button ```New Comment```.
2. Change the desired status.
3. Insert your comment.     *(the smart tool can also detect if you type any calculation and inputs its result into the calculation field)*
4. Optionally input a suggested rate, or leave it blank.
5. Press ```Save```.

#### Different Booking Status:
- **Pending DMC:** The booking needs to be settled by ```Meeting Point```.
- **Fixed DMC:** ```Meeting Point``` has settled the booking.
- **Pending Tour Operator:** The booking needs to be settled by ```the Tour Operator```.
- **Fixed Tour Operator:** ```The Tour Operator``` has settled the booking.

### Working with Bookings in Dispute

![Disputes](https://github.com/walidzakaria/ProfitabilityTool/blob/master/Screenshots/Show_booking_with_disputes.png "Disputes")

Each DMC or Tour Operator can see its own disputed bookings only *(Fixed and Pending)*, and handle them by changing the status again.

>The main purpose is to eventually have all the deficit bookings as fixed either by DMC or by T/O.

## Requirements
- Supported Operating Systems:
    - Windows 10.
    - Windows 7 Service Pack 1.
    - Windows 8, Windows 8.1.
    - Windows Server 2008 R2 SP1.
    - Windows Server 2008 Service Pack 2.
    - Windows Server 2012.
    - Windows Server 2012 R2.
    - Windows Vista Service Pack 2
- .NET Framework v4.5.2 or higher installed on the client machines.
- 1 GHz or faster processor.
- 512 MB of RAM or more.
- 4.5 GB of available hard disk space (x86) or more.
- 4.5 GB of available hard disk space (x64) or more.
- For maintenance a [DevExpress WinForms](https://www.devexpress.com/products/net/controls/winforms/) is needed & [VS.NET](https://visualstudio.microsoft.com/vs/).

## Software License
Commercial Software. Copyright to [FTI Touristik GmbH](http://www.fti.de/).