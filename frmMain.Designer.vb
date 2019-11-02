Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnRate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSwitchUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.beDateFrom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beDateTo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.beCountry = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnDestination = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageMargin = New DevExpress.XtraBars.BarButtonItem()
        Me.btnJunk = New DevExpress.XtraBars.BarButtonItem()
        Me.brnCanceled = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMatching = New DevExpress.XtraBars.BarButtonItem()
        Me.bcNegative = New DevExpress.XtraBars.BarCheckItem()
        Me.bcExcessive = New DevExpress.XtraBars.BarCheckItem()
        Me.bcMismatch = New DevExpress.XtraBars.BarCheckItem()
        Me.btnShowDefict = New DevExpress.XtraBars.BarButtonItem()
        Me.bcPendingDmc = New DevExpress.XtraBars.BarCheckItem()
        Me.bcFixedDmc = New DevExpress.XtraBars.BarCheckItem()
        Me.bcPendingTo = New DevExpress.XtraBars.BarCheckItem()
        Me.bcFixedTo = New DevExpress.XtraBars.BarCheckItem()
        Me.btnShow = New DevExpress.XtraBars.BarButtonItem()
        Me.bcNewRecord = New DevExpress.XtraBars.BarCheckItem()
        Me.btnAddDispute = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTO = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.bhUsername = New DevExpress.XtraBars.BarHeaderItem()
        Me.biLoginTime = New DevExpress.XtraBars.BarStaticItem()
        Me.bhLogginTime = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.btnManageCurrency = New DevExpress.XtraBars.BarButtonItem()
        Me.btnErrors = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ProfitabilityTool.WaitForm1), True, True)
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowKeyTips = False
        Me.RibbonControl1.AllowMdiChildButtons = False
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.btnRate, Me.btnSave, Me.btnLoad, Me.btnSwitchUser, Me.btnManageUsers, Me.btnChangePassword, Me.btnExit, Me.beDateFrom, Me.beDateTo, Me.beCountry, Me.btnDestination, Me.btnManageMargin, Me.btnJunk, Me.brnCanceled, Me.btnMatching, Me.bcNegative, Me.bcExcessive, Me.bcMismatch, Me.btnShowDefict, Me.bcPendingDmc, Me.bcFixedDmc, Me.bcPendingTo, Me.bcFixedTo, Me.btnShow, Me.bcNewRecord, Me.btnAddDispute, Me.btnTO, Me.BarStaticItem1, Me.bhUsername, Me.biLoginTime, Me.bhLogginTime, Me.BarHeaderItem1, Me.BarButtonGroup1, Me.btnManageCurrency, Me.btnErrors, Me.btnAbout})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 44
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemLookUpEdit2})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1376, 122)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btnRate
        '
        Me.btnRate.Caption = "Import"
        Me.btnRate.Id = 2
        Me.btnRate.ImageOptions.Image = CType(resources.GetObject("btnRate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 3
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnLoad
        '
        Me.btnLoad.Caption = "Load" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All"
        Me.btnLoad.Id = 4
        Me.btnLoad.ImageOptions.Image = CType(resources.GetObject("btnLoad.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSwitchUser
        '
        Me.btnSwitchUser.Caption = "Switch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User"
        Me.btnSwitchUser.Id = 5
        Me.btnSwitchUser.ImageOptions.Image = CType(resources.GetObject("btnSwitchUser.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSwitchUser.ImageOptions.LargeImage = CType(resources.GetObject("btnSwitchUser.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSwitchUser.Name = "btnSwitchUser"
        Me.btnSwitchUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Caption = "Manage Users"
        Me.btnManageUsers.Id = 6
        Me.btnManageUsers.ImageOptions.Image = CType(resources.GetObject("btnManageUsers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnManageUsers.ImageOptions.LargeImage = CType(resources.GetObject("btnManageUsers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Caption = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.btnChangePassword.Id = 8
        Me.btnChangePassword.ImageOptions.Image = CType(resources.GetObject("btnChangePassword.ImageOptions.Image"), System.Drawing.Image)
        Me.btnChangePassword.ImageOptions.LargeImage = CType(resources.GetObject("btnChangePassword.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnExit
        '
        Me.btnExit.Caption = "Exit"
        Me.btnExit.Id = 9
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.ImageOptions.LargeImage = CType(resources.GetObject("btnExit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'beDateFrom
        '
        Me.beDateFrom.Caption = "Date From"
        Me.beDateFrom.Edit = Me.RepositoryItemDateEdit1
        Me.beDateFrom.EditWidth = 85
        Me.beDateFrom.Id = 11
        Me.beDateFrom.Name = "beDateFrom"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'beDateTo
        '
        Me.beDateTo.Caption = "Date To    "
        Me.beDateTo.Edit = Me.RepositoryItemDateEdit2
        Me.beDateTo.EditWidth = 85
        Me.beDateTo.Id = 12
        Me.beDateTo.Name = "beDateTo"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'beCountry
        '
        Me.beCountry.Caption = "Country    "
        Me.beCountry.Edit = Me.RepositoryItemLookUpEdit1
        Me.beCountry.EditWidth = 85
        Me.beCountry.Id = 13
        Me.beCountry.Name = "beCountry"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestinationCode", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Destination", "Country")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "Select Country"
        '
        'btnDestination
        '
        Me.btnDestination.Caption = "" & Global.Microsoft.VisualBasic.ChrW(10) & "Destination"
        Me.btnDestination.Id = 14
        Me.btnDestination.ImageOptions.Image = CType(resources.GetObject("btnDestination.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDestination.ImageOptions.LargeImage = CType(resources.GetObject("btnDestination.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnManageMargin
        '
        Me.btnManageMargin.Caption = "" & Global.Microsoft.VisualBasic.ChrW(10) & "Margin"
        Me.btnManageMargin.Id = 15
        Me.btnManageMargin.ImageOptions.Image = CType(resources.GetObject("btnManageMargin.ImageOptions.Image"), System.Drawing.Image)
        Me.btnManageMargin.Name = "btnManageMargin"
        Me.btnManageMargin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnJunk
        '
        Me.btnJunk.Caption = "Junk"
        Me.btnJunk.Id = 16
        Me.btnJunk.ImageOptions.Image = CType(resources.GetObject("btnJunk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnJunk.Name = "btnJunk"
        Me.btnJunk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'brnCanceled
        '
        Me.brnCanceled.Caption = "Canceled"
        Me.brnCanceled.Id = 17
        Me.brnCanceled.ImageOptions.Image = CType(resources.GetObject("brnCanceled.ImageOptions.Image"), System.Drawing.Image)
        Me.brnCanceled.ImageOptions.LargeImage = CType(resources.GetObject("brnCanceled.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.brnCanceled.Name = "brnCanceled"
        Me.brnCanceled.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnMatching
        '
        Me.btnMatching.Caption = "Matching"
        Me.btnMatching.Id = 18
        Me.btnMatching.ImageOptions.Image = CType(resources.GetObject("btnMatching.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMatching.ImageOptions.LargeImage = CType(resources.GetObject("btnMatching.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMatching.Name = "btnMatching"
        Me.btnMatching.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bcNegative
        '
        Me.bcNegative.BindableChecked = True
        Me.bcNegative.Caption = "Nagative "
        Me.bcNegative.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcNegative.Checked = True
        Me.bcNegative.Id = 19
        Me.bcNegative.Name = "bcNegative"
        Me.bcNegative.SmallWithTextWidth = 78
        '
        'bcExcessive
        '
        Me.bcExcessive.BindableChecked = True
        Me.bcExcessive.Caption = "Excessive"
        Me.bcExcessive.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcExcessive.Checked = True
        Me.bcExcessive.Id = 20
        Me.bcExcessive.Name = "bcExcessive"
        Me.bcExcessive.SmallWithTextWidth = 78
        '
        'bcMismatch
        '
        Me.bcMismatch.BindableChecked = True
        Me.bcMismatch.Caption = "Mismatch "
        Me.bcMismatch.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcMismatch.Checked = True
        Me.bcMismatch.Id = 21
        Me.bcMismatch.Name = "bcMismatch"
        Me.bcMismatch.SmallWithTextWidth = 78
        '
        'btnShowDefict
        '
        Me.btnShowDefict.Caption = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deficit"
        Me.btnShowDefict.Id = 22
        Me.btnShowDefict.ImageOptions.Image = CType(resources.GetObject("btnShowDefict.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowDefict.Name = "btnShowDefict"
        Me.btnShowDefict.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bcPendingDmc
        '
        Me.bcPendingDmc.BindableChecked = True
        Me.bcPendingDmc.Caption = "Pending DMC"
        Me.bcPendingDmc.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcPendingDmc.Checked = True
        Me.bcPendingDmc.Id = 23
        Me.bcPendingDmc.Name = "bcPendingDmc"
        '
        'bcFixedDmc
        '
        Me.bcFixedDmc.BindableChecked = True
        Me.bcFixedDmc.Caption = "Fixed DMC"
        Me.bcFixedDmc.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcFixedDmc.Checked = True
        Me.bcFixedDmc.Id = 24
        Me.bcFixedDmc.Name = "bcFixedDmc"
        '
        'bcPendingTo
        '
        Me.bcPendingTo.BindableChecked = True
        Me.bcPendingTo.Caption = "Pending T/O"
        Me.bcPendingTo.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcPendingTo.Checked = True
        Me.bcPendingTo.Id = 25
        Me.bcPendingTo.Name = "bcPendingTo"
        '
        'bcFixedTo
        '
        Me.bcFixedTo.BindableChecked = True
        Me.bcFixedTo.Caption = "Fixed T/O"
        Me.bcFixedTo.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcFixedTo.Checked = True
        Me.bcFixedTo.Id = 26
        Me.bcFixedTo.Name = "bcFixedTo"
        '
        'btnShow
        '
        Me.btnShow.Caption = "Show"
        Me.btnShow.Id = 27
        Me.btnShow.ImageOptions.Image = CType(resources.GetObject("btnShow.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bcNewRecord
        '
        Me.bcNewRecord.BindableChecked = True
        Me.bcNewRecord.Caption = "New Record"
        Me.bcNewRecord.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.bcNewRecord.Checked = True
        Me.bcNewRecord.Id = 29
        Me.bcNewRecord.Name = "bcNewRecord"
        '
        'btnAddDispute
        '
        Me.btnAddDispute.Caption = "Add Dispute"
        Me.btnAddDispute.Id = 30
        Me.btnAddDispute.ImageOptions.Image = CType(resources.GetObject("btnAddDispute.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddDispute.ImageOptions.LargeImage = CType(resources.GetObject("btnAddDispute.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddDispute.Name = "btnAddDispute"
        Me.btnAddDispute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnTO
        '
        Me.btnTO.Caption = "T/O"
        Me.btnTO.Id = 31
        Me.btnTO.ImageOptions.Image = CType(resources.GetObject("btnTO.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTO.ImageOptions.LargeImage = CType(resources.GetObject("btnTO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnTO.Name = "btnTO"
        Me.btnTO.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Logged as:"
        Me.BarStaticItem1.Id = 32
        Me.BarStaticItem1.LeftIndent = 50
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'bhUsername
        '
        Me.bhUsername.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.bhUsername.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bhUsername.Appearance.Options.UseFont = True
        Me.bhUsername.Caption = "Username"
        Me.bhUsername.Id = 33
        Me.bhUsername.Name = "bhUsername"
        '
        'biLoginTime
        '
        Me.biLoginTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.biLoginTime.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.biLoginTime.Caption = "Login time: HH:mm"
        Me.biLoginTime.Id = 34
        Me.biLoginTime.Name = "biLoginTime"
        Me.biLoginTime.RightIndent = 50
        '
        'bhLogginTime
        '
        Me.bhLogginTime.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bhLogginTime.Appearance.Options.UseFont = True
        Me.bhLogginTime.Caption = "00:00"
        Me.bhLogginTime.Id = 35
        Me.bhLogginTime.Name = "bhLogginTime"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 36
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonGroup1.Id = 38
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'btnManageCurrency
        '
        Me.btnManageCurrency.Caption = "Currency"
        Me.btnManageCurrency.Id = 41
        Me.btnManageCurrency.ImageOptions.Image = CType(resources.GetObject("btnManageCurrency.ImageOptions.Image"), System.Drawing.Image)
        Me.btnManageCurrency.Name = "btnManageCurrency"
        Me.btnManageCurrency.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnErrors
        '
        Me.btnErrors.Caption = "Errors"
        Me.btnErrors.Id = 42
        Me.btnErrors.ImageOptions.Image = CType(resources.GetObject("btnErrors.ImageOptions.Image"), System.Drawing.Image)
        Me.btnErrors.Name = "btnErrors"
        Me.btnErrors.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAbout
        '
        Me.btnAbout.Caption = "About"
        Me.btnAbout.Id = 43
        Me.btnAbout.ImageOptions.Image = CType(resources.GetObject("btnAbout.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup5, Me.RibbonPageGroup7, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Glyph = CType(resources.GetObject("RibbonPageGroup1.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRate)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnErrors)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Data"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Glyph = CType(resources.GetObject("RibbonPageGroup2.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.beCountry)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.beDateFrom)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.beDateTo)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnLoad)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnJunk)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.brnCanceled)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMatching)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Show"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.Glyph = CType(resources.GetObject("RibbonPageGroup5.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bcNegative)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bcExcessive)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bcMismatch)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnShowDefict)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Deficit"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.Glyph = CType(resources.GetObject("RibbonPageGroup7.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bcPendingDmc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bcFixedDmc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bcPendingTo)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bcFixedTo)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bcNewRecord)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnAddDispute)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnShow)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Disputes"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Glyph = CType(resources.GetObject("RibbonPageGroup3.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnSwitchUser)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnChangePassword)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnManageUsers)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnManageCurrency)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnDestination, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnTO)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnManageMargin)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Administration"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.Glyph = CType(resources.GetObject("RibbonPageGroup4.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnAbout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnExit)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Settings"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestinationCode", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Destination", "Country")})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bhUsername)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.biLoginTime)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 460)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1376, 31)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 122)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1376, 338)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Reference", Nothing, "(Number of Bookings: {0})")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "BookingID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowShowHide = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ref"
        Me.GridColumn2.FieldName = "Reference"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Reference", "{0}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Hotel Code"
        Me.GridColumn3.FieldName = "HotelCode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hotel Name"
        Me.GridColumn4.FieldName = "HotelName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Country"
        Me.GridColumn5.FieldName = "HotelCountry"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GWG Status"
        Me.GridColumn6.FieldName = "GwgStatus"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Purchase Currency"
        Me.GridColumn7.FieldName = "PurchaseCurrency"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 60
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Purchase Price"
        Me.GridColumn8.FieldName = "PurchasePrice"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurchasePrice", "{0:0.##}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Sales Currency"
        Me.GridColumn9.FieldName = "SalesCurrency"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 60
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Sales Price"
        Me.GridColumn10.FieldName = "SalesPrice"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesPrice", "{0:0.##}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GWG Handling Fee"
        Me.GridColumn11.FieldName = "GwgHandlingFee"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GwgHandlingFee", "{0:0.##}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Margin"
        Me.GridColumn12.FieldName = "Margin"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 60
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Difference"
        Me.GridColumn13.FieldName = "Difference"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Difference", "{0:0.##}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        Me.GridColumn13.Width = 60
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Currency Hotel TC"
        Me.GridColumn14.FieldName = "CurrencyHotelTC"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        Me.GridColumn14.Width = 60
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Net Rate Hotel TC"
        Me.GridColumn15.FieldName = "NetRateHotelTC"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetRateHotelTC", "{0:0.##}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 13
        Me.GridColumn15.Width = 60
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Net Rate Handling TC"
        Me.GridColumn16.FieldName = "NetRateHandlingTC"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetRateHandlingTC", "{0:0.##}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 14
        Me.GridColumn16.Width = 60
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Check Hotel"
        Me.GridColumn17.FieldName = "CheckHotel"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 15
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Company Group"
        Me.GridColumn18.FieldName = "CompanyGroup"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 16
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Booking Date"
        Me.GridColumn19.FieldName = "BookingDate"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 17
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Travel Date"
        Me.GridColumn20.FieldName = "TravelDate"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 18
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Room Type"
        Me.GridColumn21.FieldName = "RoomType"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 19
        Me.GridColumn21.Width = 60
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Board"
        Me.GridColumn22.FieldName = "Board"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 20
        Me.GridColumn22.Width = 50
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Duration"
        Me.GridColumn23.FieldName = "Duration"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 21
        Me.GridColumn23.Width = 50
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "TransferTo"
        Me.GridColumn24.FieldName = "TransferTo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 22
        Me.GridColumn24.Width = 50
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "TransferFrom"
        Me.GridColumn25.FieldName = "TransferFrom"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 23
        Me.GridColumn25.Width = 50
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Pax"
        Me.GridColumn26.FieldName = "Pax"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 24
        Me.GridColumn26.Width = 45
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Adult"
        Me.GridColumn27.FieldName = "Adult"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 25
        Me.GridColumn27.Width = 45
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Child"
        Me.GridColumn28.FieldName = "Child"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 26
        Me.GridColumn28.Width = 45
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "ImportDate"
        Me.GridColumn29.FieldName = "ImportDate"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 27
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "IncomingAgency"
        Me.GridColumn30.FieldName = "IncomingAgency"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 28
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "BookingStateDesc"
        Me.GridColumn31.FieldName = "BookingStateDesc"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 29
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "HotelFlag"
        Me.GridColumn32.FieldName = "HotelFlag"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 30
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "MissingBookings"
        Me.GridColumn33.FieldName = "MissingBookings"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 31
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "MarginCheck"
        Me.GridColumn34.FieldName = "MarginCheck"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 32
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "DifferenceTOPrice"
        Me.GridColumn35.FieldName = "DifferenceTOPrice"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 33
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "ActionBy"
        Me.GridColumn36.FieldName = "ActionBy"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 34
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Status"
        Me.GridColumn37.FieldName = "Status"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 35
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Comments"
        Me.GridColumn38.FieldName = "Comments"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 36
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "AdjustedPrice"
        Me.GridColumn39.FieldName = "AdjustedPrice"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.AllowEdit = False
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 37
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "PriceBreakdown"
        Me.GridColumn40.FieldName = "PriceBreakdown"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.AllowEdit = False
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 38
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Settings"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 28
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 491)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Profitability Tool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btnRate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSwitchUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnManageUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents beDateFrom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beDateTo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents beCountry As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnDestination As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnManageMargin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnJunk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents brnCanceled As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMatching As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bcNegative As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents bcExcessive As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents bcMismatch As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnShowDefict As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bcPendingDmc As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents bcFixedDmc As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents bcPendingTo As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents bcFixedTo As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnShow As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bcNewRecord As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnAddDispute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents biLoginTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Public WithEvents bhUsername As DevExpress.XtraBars.BarHeaderItem
    Public WithEvents bhLogginTime As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents btnManageCurrency As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnErrors As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAbout As DevExpress.XtraBars.BarButtonItem

End Class
