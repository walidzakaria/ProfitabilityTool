Partial Public Class FrmMain
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
        Dim SkinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BtnRate = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSwitchUser = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnManageUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.BeDateFrom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BeDateTo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BeCountry = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BtnDestination = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnManageMargin = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnJunk = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCanceled = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnMatching = New DevExpress.XtraBars.BarButtonItem()
        Me.BcNegative = New DevExpress.XtraBars.BarCheckItem()
        Me.BcExcessive = New DevExpress.XtraBars.BarCheckItem()
        Me.BcMismatch = New DevExpress.XtraBars.BarCheckItem()
        Me.BtnShowDefict = New DevExpress.XtraBars.BarButtonItem()
        Me.BcPendingDmc = New DevExpress.XtraBars.BarCheckItem()
        Me.BcFixedDmc = New DevExpress.XtraBars.BarCheckItem()
        Me.BcPendingTo = New DevExpress.XtraBars.BarCheckItem()
        Me.BcFixedTo = New DevExpress.XtraBars.BarCheckItem()
        Me.BtnShow = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnAddDispute = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTO = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.bhUsername = New DevExpress.XtraBars.BarHeaderItem()
        Me.biLoginTime = New DevExpress.XtraBars.BarStaticItem()
        Me.bhLogginTime = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BtnManageCurrency = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnErrors = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.BeImportFrom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BeImportTill = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BtnSection = New DevExpress.XtraBars.BarButtonItem()
        Me.BcCannotFix = New DevExpress.XtraBars.BarCheckItem()
        Me.BtnResetGrid = New DevExpress.XtraBars.BarButtonItem()
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
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ProfitabilityTool.FrmWait), True, True)
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.SkinRibbonGalleryBarItem1, Me.BtnRate, Me.BtnSave, Me.BtnLoad, Me.BtnSwitchUser, Me.BtnManageUsers, Me.BtnChangePassword, Me.BtnExit, Me.BeDateFrom, Me.BeDateTo, Me.BeCountry, Me.BtnDestination, Me.BtnManageMargin, Me.BtnJunk, Me.BtnCanceled, Me.BtnMatching, Me.BcNegative, Me.BcExcessive, Me.BcMismatch, Me.BtnShowDefict, Me.BcPendingDmc, Me.BcFixedDmc, Me.BcPendingTo, Me.BcFixedTo, Me.BtnShow, Me.BtnAddDispute, Me.BtnTO, Me.BarStaticItem1, Me.bhUsername, Me.biLoginTime, Me.bhLogginTime, Me.BarHeaderItem1, Me.BarButtonGroup1, Me.BtnManageCurrency, Me.BtnErrors, Me.BtnAbout, Me.BeImportFrom, Me.BeImportTill, Me.BtnSection, Me.BcCannotFix, Me.BtnResetGrid})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 53
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1376, 132)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        '
        '
        '
        Me.SkinRibbonGalleryBarItem1.Gallery.AllowHoverImages = True
        Me.SkinRibbonGalleryBarItem1.Gallery.ColumnCount = 4
        Me.SkinRibbonGalleryBarItem1.Gallery.FixedHoverImageSize = False
        Me.SkinRibbonGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(16, 16)
        Me.SkinRibbonGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
        Me.SkinRibbonGalleryBarItem1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
        Me.SkinRibbonGalleryBarItem1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        SkinPaddingEdges2.Left = 8
        SkinPaddingEdges2.Right = 8
        Me.SkinRibbonGalleryBarItem1.Gallery.ItemImagePadding = SkinPaddingEdges2
        Me.SkinRibbonGalleryBarItem1.Gallery.ScaleImages = DevExpress.Utils.DefaultBoolean.[False]
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.ImageOptions.SvgImage = CType(resources.GetObject("SkinRibbonGalleryBarItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BtnRate
        '
        Me.BtnRate.AllowAllUp = True
        Me.BtnRate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnRate.Caption = "Import"
        Me.BtnRate.GroupIndex = 1
        Me.BtnRate.Id = 2
        Me.BtnRate.ImageOptions.Image = CType(resources.GetObject("BtnRate.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnRate.Name = "BtnRate"
        Me.BtnRate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnSave
        '
        Me.BtnSave.AllowAllUp = True
        Me.BtnSave.Caption = "Save"
        Me.BtnSave.GroupIndex = 1
        Me.BtnSave.Id = 3
        Me.BtnSave.ImageOptions.Image = CType(resources.GetObject("BtnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnLoad
        '
        Me.BtnLoad.AllowAllUp = True
        Me.BtnLoad.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnLoad.Caption = "Load" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All"
        Me.BtnLoad.GroupIndex = 3
        Me.BtnLoad.Id = 4
        Me.BtnLoad.ImageOptions.Image = CType(resources.GetObject("BtnLoad.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnSwitchUser
        '
        Me.BtnSwitchUser.Caption = "Switch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User"
        Me.BtnSwitchUser.Id = 5
        Me.BtnSwitchUser.ImageOptions.Image = CType(resources.GetObject("BtnSwitchUser.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSwitchUser.ImageOptions.LargeImage = CType(resources.GetObject("BtnSwitchUser.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnSwitchUser.Name = "BtnSwitchUser"
        Me.BtnSwitchUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnManageUsers
        '
        Me.BtnManageUsers.Caption = "Manage Users"
        Me.BtnManageUsers.Id = 6
        Me.BtnManageUsers.ImageOptions.Image = CType(resources.GetObject("BtnManageUsers.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnManageUsers.ImageOptions.LargeImage = CType(resources.GetObject("BtnManageUsers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnManageUsers.Name = "BtnManageUsers"
        Me.BtnManageUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.Caption = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.BtnChangePassword.Id = 8
        Me.BtnChangePassword.ImageOptions.Image = CType(resources.GetObject("BtnChangePassword.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnChangePassword.ImageOptions.LargeImage = CType(resources.GetObject("BtnChangePassword.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnExit
        '
        Me.BtnExit.Caption = "Exit"
        Me.BtnExit.Id = 9
        Me.BtnExit.ImageOptions.Image = CType(resources.GetObject("BtnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnExit.ImageOptions.LargeImage = CType(resources.GetObject("BtnExit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BeDateFrom
        '
        Me.BeDateFrom.Caption = "Travel From"
        Me.BeDateFrom.Edit = Me.RepositoryItemDateEdit1
        Me.BeDateFrom.EditWidth = 85
        Me.BeDateFrom.Id = 11
        Me.BeDateFrom.Name = "BeDateFrom"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.NullDate = New Date(2020, 1, 1, 13, 47, 58, 0)
        '
        'BeDateTo
        '
        Me.BeDateTo.Caption = "Travel Till    "
        Me.BeDateTo.Edit = Me.RepositoryItemDateEdit2
        Me.BeDateTo.EditWidth = 85
        Me.BeDateTo.Id = 12
        Me.BeDateTo.Name = "BeDateTo"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.NullDate = New Date(2050, 12, 31, 13, 48, 36, 0)
        '
        'BeCountry
        '
        Me.BeCountry.Caption = "Country      "
        Me.BeCountry.Edit = Me.RepositoryItemLookUpEdit1
        Me.BeCountry.EditWidth = 85
        Me.BeCountry.Id = 13
        Me.BeCountry.Name = "BeCountry"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DestinationCode", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Destination", "Country")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "Select Country"
        '
        'BtnDestination
        '
        Me.BtnDestination.Caption = "" & Global.Microsoft.VisualBasic.ChrW(10) & "Destination"
        Me.BtnDestination.Id = 14
        Me.BtnDestination.ImageOptions.Image = CType(resources.GetObject("BtnDestination.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDestination.ImageOptions.LargeImage = CType(resources.GetObject("BtnDestination.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnDestination.Name = "BtnDestination"
        Me.BtnDestination.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnManageMargin
        '
        Me.BtnManageMargin.Caption = "" & Global.Microsoft.VisualBasic.ChrW(10) & "Margin"
        Me.BtnManageMargin.Id = 15
        Me.BtnManageMargin.ImageOptions.Image = CType(resources.GetObject("BtnManageMargin.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnManageMargin.Name = "BtnManageMargin"
        Me.BtnManageMargin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnJunk
        '
        Me.BtnJunk.AllowAllUp = True
        Me.BtnJunk.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnJunk.Caption = "Junk"
        Me.BtnJunk.GroupIndex = 4
        Me.BtnJunk.Id = 16
        Me.BtnJunk.ImageOptions.Image = CType(resources.GetObject("BtnJunk.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnJunk.Name = "BtnJunk"
        Me.BtnJunk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnCanceled
        '
        Me.BtnCanceled.AllowAllUp = True
        Me.BtnCanceled.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnCanceled.Caption = "Canceled"
        Me.BtnCanceled.GroupIndex = 5
        Me.BtnCanceled.Id = 17
        Me.BtnCanceled.ImageOptions.Image = CType(resources.GetObject("BtnCanceled.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnCanceled.ImageOptions.LargeImage = CType(resources.GetObject("BtnCanceled.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnCanceled.Name = "BtnCanceled"
        Me.BtnCanceled.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnMatching
        '
        Me.BtnMatching.AllowAllUp = True
        Me.BtnMatching.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnMatching.Caption = "Matching"
        Me.BtnMatching.GroupIndex = 6
        Me.BtnMatching.Id = 18
        Me.BtnMatching.ImageOptions.Image = CType(resources.GetObject("BtnMatching.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnMatching.ImageOptions.LargeImage = CType(resources.GetObject("BtnMatching.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnMatching.Name = "BtnMatching"
        Me.BtnMatching.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BcNegative
        '
        Me.BcNegative.BindableChecked = True
        Me.BcNegative.Caption = "Negative "
        Me.BcNegative.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcNegative.Checked = True
        Me.BcNegative.Id = 19
        Me.BcNegative.Name = "BcNegative"
        Me.BcNegative.SmallWithTextWidth = 78
        '
        'BcExcessive
        '
        Me.BcExcessive.BindableChecked = True
        Me.BcExcessive.Caption = "Excessive"
        Me.BcExcessive.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcExcessive.Checked = True
        Me.BcExcessive.Id = 20
        Me.BcExcessive.Name = "BcExcessive"
        Me.BcExcessive.SmallWithTextWidth = 78
        '
        'BcMismatch
        '
        Me.BcMismatch.BindableChecked = True
        Me.BcMismatch.Caption = "Mismatch "
        Me.BcMismatch.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcMismatch.Checked = True
        Me.BcMismatch.Id = 21
        Me.BcMismatch.Name = "BcMismatch"
        Me.BcMismatch.SmallWithTextWidth = 78
        '
        'BtnShowDefict
        '
        Me.BtnShowDefict.AllowAllUp = True
        Me.BtnShowDefict.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnShowDefict.Caption = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deficit"
        Me.BtnShowDefict.GroupIndex = 7
        Me.BtnShowDefict.Id = 22
        Me.BtnShowDefict.ImageOptions.Image = CType(resources.GetObject("BtnShowDefict.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnShowDefict.Name = "BtnShowDefict"
        Me.BtnShowDefict.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BcPendingDmc
        '
        Me.BcPendingDmc.BindableChecked = True
        Me.BcPendingDmc.Caption = "Pending DMC"
        Me.BcPendingDmc.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcPendingDmc.Checked = True
        Me.BcPendingDmc.Id = 23
        Me.BcPendingDmc.Name = "BcPendingDmc"
        '
        'BcFixedDmc
        '
        Me.BcFixedDmc.BindableChecked = True
        Me.BcFixedDmc.Caption = "Fixed DMC"
        Me.BcFixedDmc.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcFixedDmc.Checked = True
        Me.BcFixedDmc.Id = 24
        Me.BcFixedDmc.Name = "BcFixedDmc"
        '
        'BcPendingTo
        '
        Me.BcPendingTo.BindableChecked = True
        Me.BcPendingTo.Caption = "Pending T/O"
        Me.BcPendingTo.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcPendingTo.Checked = True
        Me.BcPendingTo.Id = 25
        Me.BcPendingTo.Name = "BcPendingTo"
        '
        'BcFixedTo
        '
        Me.BcFixedTo.BindableChecked = True
        Me.BcFixedTo.Caption = "Fixed T/O"
        Me.BcFixedTo.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcFixedTo.Checked = True
        Me.BcFixedTo.Id = 26
        Me.BcFixedTo.Name = "BcFixedTo"
        '
        'BtnShow
        '
        Me.BtnShow.AllowAllUp = True
        Me.BtnShow.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnShow.Caption = "Show"
        Me.BtnShow.GroupIndex = 8
        Me.BtnShow.Id = 27
        Me.BtnShow.ImageOptions.Image = CType(resources.GetObject("BtnShow.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnAddDispute
        '
        Me.BtnAddDispute.Caption = "Add Dispute"
        Me.BtnAddDispute.Id = 30
        Me.BtnAddDispute.ImageOptions.Image = CType(resources.GetObject("BtnAddDispute.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAddDispute.ImageOptions.LargeImage = CType(resources.GetObject("BtnAddDispute.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnAddDispute.Name = "BtnAddDispute"
        Me.BtnAddDispute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnTO
        '
        Me.BtnTO.Caption = "T/O"
        Me.BtnTO.Id = 31
        Me.BtnTO.ImageOptions.Image = CType(resources.GetObject("BtnTO.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnTO.ImageOptions.LargeImage = CType(resources.GetObject("BtnTO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnTO.Name = "BtnTO"
        Me.BtnTO.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
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
        'BtnManageCurrency
        '
        Me.BtnManageCurrency.Caption = "Currency"
        Me.BtnManageCurrency.Id = 41
        Me.BtnManageCurrency.ImageOptions.Image = CType(resources.GetObject("BtnManageCurrency.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnManageCurrency.Name = "BtnManageCurrency"
        Me.BtnManageCurrency.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BtnErrors
        '
        Me.BtnErrors.AllowAllUp = True
        Me.BtnErrors.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BtnErrors.Caption = "Errors"
        Me.BtnErrors.GroupIndex = 2
        Me.BtnErrors.Id = 42
        Me.BtnErrors.ImageOptions.Image = CType(resources.GetObject("BtnErrors.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnErrors.Name = "BtnErrors"
        Me.BtnErrors.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BtnAbout
        '
        Me.BtnAbout.Caption = "About"
        Me.BtnAbout.Id = 43
        Me.BtnAbout.ImageOptions.Image = CType(resources.GetObject("BtnAbout.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BeImportFrom
        '
        Me.BeImportFrom.Caption = "Import From"
        Me.BeImportFrom.Edit = Me.RepositoryItemDateEdit3
        Me.BeImportFrom.EditWidth = 85
        Me.BeImportFrom.Id = 44
        Me.BeImportFrom.Name = "BeImportFrom"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.NullDate = New Date(2021, 1, 1, 13, 47, 58, 0)
        '
        'BeImportTill
        '
        Me.BeImportTill.Caption = "Import Till    "
        Me.BeImportTill.Edit = Me.RepositoryItemDateEdit4
        Me.BeImportTill.EditWidth = 85
        Me.BeImportTill.Id = 45
        Me.BeImportTill.Name = "BeImportTill"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.NullDate = New Date(2021, 1, 1, 13, 47, 58, 0)
        '
        'BtnSection
        '
        Me.BtnSection.Caption = "Section"
        Me.BtnSection.Id = 46
        Me.BtnSection.ImageOptions.Image = CType(resources.GetObject("BtnSection.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSection.Name = "BtnSection"
        Me.BtnSection.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'BcCannotFix
        '
        Me.BcCannotFix.BindableChecked = True
        Me.BcCannotFix.Caption = "Cannot Fix"
        Me.BcCannotFix.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
        Me.BcCannotFix.Checked = True
        Me.BcCannotFix.Id = 51
        Me.BcCannotFix.Name = "BcCannotFix"
        '
        'BtnResetGrid
        '
        Me.BtnResetGrid.Caption = "Reset Grid"
        Me.BtnResetGrid.Id = 52
        Me.BtnResetGrid.ImageOptions.SvgImage = CType(resources.GetObject("BtnResetGrid.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnResetGrid.Name = "BtnResetGrid"
        Me.BtnResetGrid.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup5, Me.RibbonPageGroup7, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup1.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup1.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnRate)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnErrors)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Data"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup2.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup2.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BeCountry)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BeDateFrom)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BeDateTo)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BeImportFrom)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BeImportTill)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnLoad)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnJunk)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnCanceled)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnMatching)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Show"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup5.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup5.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BcNegative)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BcExcessive)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BcMismatch)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BtnShowDefict)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Deficit"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup7.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup7.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BcPendingDmc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BcFixedDmc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BcPendingTo)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BcFixedTo)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BcCannotFix)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BtnAddDispute)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BtnShow)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Disputes"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup3.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup3.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnSwitchUser)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnChangePassword)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnManageUsers)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnManageCurrency)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnDestination, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnTO)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnManageMargin)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnSection)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnResetGrid)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Administration"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup4.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup4.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BtnAbout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BtnExit)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
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
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 467)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1376, 24)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 132)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1376, 335)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn41, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn42, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40})
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
        Me.GridColumn6.Caption = "GWGStatus"
        Me.GridColumn6.FieldName = "GwgStatus"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 50
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "BookingStatus"
        Me.GridColumn41.FieldName = "BookingStatus"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.AllowEdit = False
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Purchase Currency"
        Me.GridColumn7.FieldName = "PurchaseCurrency"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 60
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.Caption = "Purchase Price"
        Me.GridColumn8.FieldName = "PurchasePrice"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurchasePrice", "{0:0.##}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Sales Currency"
        Me.GridColumn9.FieldName = "SalesCurrency"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 60
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.Caption = "Sales Price"
        Me.GridColumn10.FieldName = "SalesPrice"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalesPrice", "{0:0.##}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GWG Handling Fee"
        Me.GridColumn11.FieldName = "GwgHandlingFee"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GwgHandlingFee", "{0:0.##}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "Margin"
        Me.GridColumn12.FieldName = "Margin"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 60
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "Difference"
        Me.GridColumn13.FieldName = "Difference"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Difference", "{0:0.##}")})
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        Me.GridColumn13.Width = 60
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Currency Hotel TC"
        Me.GridColumn14.FieldName = "CurrencyHotelTC"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        Me.GridColumn14.Width = 60
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn15.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn15.AppearanceCell.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn15.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.Caption = "Net Rate Hotel TC"
        Me.GridColumn15.FieldName = "NetRateHotelTC"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetRateHotelTC", "{0:0.##}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
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
        Me.GridColumn16.VisibleIndex = 15
        Me.GridColumn16.Width = 60
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Check Hotel"
        Me.GridColumn17.FieldName = "CheckHotel"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 16
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Company Group"
        Me.GridColumn18.FieldName = "CompanyGroup"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 17
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Booking Date"
        Me.GridColumn19.FieldName = "BookingDate"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 18
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Travel Date"
        Me.GridColumn20.FieldName = "TravelDate"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 19
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Room Type"
        Me.GridColumn21.FieldName = "RoomType"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 20
        Me.GridColumn21.Width = 60
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Board"
        Me.GridColumn22.FieldName = "Board"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 21
        Me.GridColumn22.Width = 50
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Duration"
        Me.GridColumn23.FieldName = "Duration"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 22
        Me.GridColumn23.Width = 50
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "TransferTo"
        Me.GridColumn24.FieldName = "TransferTo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 23
        Me.GridColumn24.Width = 50
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "TransferFrom"
        Me.GridColumn25.FieldName = "TransferFrom"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 24
        Me.GridColumn25.Width = 50
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Pax"
        Me.GridColumn26.FieldName = "Pax"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 25
        Me.GridColumn26.Width = 45
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Adult"
        Me.GridColumn27.FieldName = "Adult"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 26
        Me.GridColumn27.Width = 45
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Child"
        Me.GridColumn28.FieldName = "Child"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 27
        Me.GridColumn28.Width = 45
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "ImportDate"
        Me.GridColumn29.FieldName = "ImportDate"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 28
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "MPImportData"
        Me.GridColumn42.FieldName = "MPImportDate"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.AllowEdit = False
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 30
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "IncomingAgency"
        Me.GridColumn30.FieldName = "IncomingAgency"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 29
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "BookingStateDesc"
        Me.GridColumn31.FieldName = "BookingStateDesc"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 31
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "HotelFlag"
        Me.GridColumn32.FieldName = "HotelFlag"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 32
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "MissingBookings"
        Me.GridColumn33.FieldName = "MissingBookings"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 33
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "MarginCheck"
        Me.GridColumn34.FieldName = "MarginCheck"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 34
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "DifferenceTOPrice"
        Me.GridColumn35.FieldName = "DifferenceTOPrice"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 35
        '
        'GridColumn36
        '
        Me.GridColumn36.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn36.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn36.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn36.AppearanceHeader.Options.UseFont = True
        Me.GridColumn36.Caption = "ActionBy"
        Me.GridColumn36.FieldName = "ActionBy"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 36
        '
        'GridColumn37
        '
        Me.GridColumn37.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn37.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn37.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn37.AppearanceHeader.Options.UseFont = True
        Me.GridColumn37.Caption = "Status"
        Me.GridColumn37.FieldName = "Status"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 37
        '
        'GridColumn38
        '
        Me.GridColumn38.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn38.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn38.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn38.AppearanceHeader.Options.UseFont = True
        Me.GridColumn38.Caption = "Comments"
        Me.GridColumn38.FieldName = "Comments"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 38
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "AdjustedPrice"
        Me.GridColumn39.FieldName = "AdjustedPrice"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.AllowEdit = False
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 39
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "PriceBreakdown"
        Me.GridColumn40.FieldName = "PriceBreakdown"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.AllowEdit = False
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 40
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
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
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Travel From"
        Me.BarEditItem1.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem1.EditWidth = 85
        Me.BarEditItem1.Id = 11
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'FrmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 491)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmMain.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.ProfitabilityTool.My.Resources.Resources.profitability_logo
        Me.Name = "FrmMain"
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
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnRate As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents BtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSwitchUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnManageUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BeDateFrom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BeDateTo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BeCountry As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BtnDestination As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnManageMargin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnJunk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCanceled As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnMatching As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BcNegative As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BcExcessive As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BcMismatch As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BtnShowDefict As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BcPendingDmc As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BcFixedDmc As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BcPendingTo As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BcFixedTo As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BtnShow As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BtnAddDispute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents biLoginTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Public WithEvents bhUsername As DevExpress.XtraBars.BarHeaderItem
    Public WithEvents bhLogginTime As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BtnManageCurrency As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnErrors As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnAbout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BeImportFrom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BeImportTill As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BtnSection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BcCannotFix As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BtnResetGrid As DevExpress.XtraBars.BarButtonItem
End Class
