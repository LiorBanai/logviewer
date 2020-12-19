﻿using DevExpress.XtraGrid.Views.Grid;

namespace Analogy
{
    partial class UCLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (DesignMode) return;
            tmrNewData.Stop();
            tmrNewData.Dispose();
            if (disposing)
            {

                if (components != null)
                {
                    components.Dispose();

                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogs));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.logGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDataSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTimeDiff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThread = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbHighlight = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barTopFiltering = new DevExpress.XtraBars.Bar();
            this.bBtnClearLog = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnRemoveBoomark = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btswitchMessageDetails = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btswitchRefreshLog = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsAutoScrollToBottom = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barSubItemSaveLog = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemSaveEntireInAnalogy = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSaveViewAgnostic = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSaveCurrentSelectionAnalogyFormat = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSaveEntireLog = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSaveLog = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSaveCurrentSelectionCustomFormat = new DevExpress.XtraBars.BarButtonItem();
            this.bSMExports = new DevExpress.XtraBars.BarSubItem();
            this.bBtnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExportHtml = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnFullGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bBtnUndockView = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnUndockViewPerProcess = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnUndockSelection = new DevExpress.XtraBars.BarButtonItem();
            this.bbiScreenshot = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnImport = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnDataVisualizer = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnShare = new DevExpress.XtraBars.BarButtonItem();
            this.bdcTopFiltering = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.BbarMainMenu = new DevExpress.XtraBars.Bar();
            this.barMessage = new DevExpress.XtraBars.Bar();
            this.bBtnCopyButtom = new DevExpress.XtraBars.BarButtonItem();
            this.sbarMessageInfo = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barBookmark = new DevExpress.XtraBars.Bar();
            this.bbiSaveBookmarks = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnopyBookmarked = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnCopyAllBookmarks = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnGoToMessage = new DevExpress.XtraBars.BarButtonItem();
            this.sbarBookmarks = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barGroup = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bstaticTotalMessages = new DevExpress.XtraBars.BarStaticItem();
            this.bstaticAlert = new DevExpress.XtraBars.BarStaticItem();
            this.bbtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bprogressBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bBtnExpand = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnButtomExpand = new DevExpress.XtraBars.BarButtonItem();
            this.btSwitchExpandButtomMessage = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbiDiffTime = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDatetiemFilterFrom = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDatetiemFilterTo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBookmarkNonPersist = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBookmarkPersist = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopyAllMessages = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddNoteToMessage = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncludeMessage = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncludeColumnHeaderFilter = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcludeMessage = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcludeSource = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExcludeModule = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncreaseFontSize = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDecreaseFontSize = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncludeSource = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncludeModule = new DevExpress.XtraBars.BarButtonItem();
            this.bbiJsonViewer = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.sbtnMoreHighlight = new DevExpress.XtraEditors.SimpleButton();
            this.pnlButtonsHighlight = new System.Windows.Forms.Panel();
            this.lblPageNumber = new DevExpress.XtraEditors.LabelControl();
            this.sBtnPageNext = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnLastPage = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPagePrevious = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPageFirst = new DevExpress.XtraEditors.SimpleButton();
            this.chkbHighlight = new System.Windows.Forms.CheckBox();
            this.spltcDateFiltering = new System.Windows.Forms.SplitContainer();
            this.deOlderThanFilter = new DevExpress.XtraEditors.DateEdit();
            this.ceOlderThanFilter = new DevExpress.XtraEditors.CheckEdit();
            this.deNewerThanFilter = new DevExpress.XtraEditors.DateEdit();
            this.ceNewerThanFilter = new DevExpress.XtraEditors.CheckEdit();
            this.spltcProcessesModule = new System.Windows.Forms.SplitContainer();
            this.txtbModule = new DevExpress.XtraEditors.TextEdit();
            this.ceModulesProcess = new DevExpress.XtraEditors.CheckEdit();
            this.sbtnIncludeModules = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUndockPerProcess = new DevExpress.XtraEditors.SimpleButton();
            this.spltcSources = new System.Windows.Forms.SplitContainer();
            this.txtbSource = new DevExpress.XtraEditors.TextEdit();
            this.ceSources = new DevExpress.XtraEditors.CheckEdit();
            this.sbtnIncludeSources = new DevExpress.XtraEditors.SimpleButton();
            this.spltTextExclude = new System.Windows.Forms.SplitContainer();
            this.txtbExclude = new DevExpress.XtraEditors.TextEdit();
            this.ceExcludeText = new DevExpress.XtraEditors.CheckEdit();
            this.sbtnTextExclude = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnMostCommon = new DevExpress.XtraEditors.SimpleButton();
            this.spltText = new System.Windows.Forms.SplitContainer();
            this.txtbInclude = new DevExpress.XtraEditors.TextEdit();
            this.ceIncludeText = new DevExpress.XtraEditors.CheckEdit();
            this.defaultToolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.sbtnTextInclude = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPreDefinedFilters = new DevExpress.XtraEditors.SimpleButton();
            this.chkLstLogLevel = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.rtxtContent = new DevExpress.XtraEditors.MemoEdit();
            this.gridControlBookmarkedMessages = new DevExpress.XtraGrid.GridControl();
            this.gridViewBookmarkedMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBookmarkDataSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkAudit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkObject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBookmarkMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.tmrNewData = new System.Windows.Forms.Timer(this.components);
            this.pnlFilters = new DevExpress.XtraEditors.PanelControl();
            this.xtcFiltersLeft = new DevExpress.XtraTab.XtraTabControl();
            this.xtpFilters = new DevExpress.XtraTab.XtraTabPage();
            this.pnlLeftFilters = new DevExpress.XtraEditors.PanelControl();
            this.pnlModulesAndDates = new System.Windows.Forms.Panel();
            this.xtcFilters = new DevExpress.XtraTab.XtraTabControl();
            this.xtpFiltersIncludes = new DevExpress.XtraTab.XtraTabPage();
            this.clbInclude = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.xtpFiltersExclude = new DevExpress.XtraTab.XtraTabPage();
            this.clbExclude = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.xtpSearchFilterPanel = new DevExpress.XtraTab.XtraTabPage();
            this.rgSearchMode = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnToggleSearchFilter = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.contextMenuStripFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogGridPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelLogs = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanelMessageInfo = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanelBookmarks = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbHighlight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.pnlButtonsHighlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).BeginInit();
            this.spltcDateFiltering.Panel1.SuspendLayout();
            this.spltcDateFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deOlderThanFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOlderThanFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceOlderThanFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNewerThanFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNewerThanFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNewerThanFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).BeginInit();
            this.spltcProcessesModule.Panel1.SuspendLayout();
            this.spltcProcessesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceModulesProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).BeginInit();
            this.spltcSources.Panel1.SuspendLayout();
            this.spltcSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).BeginInit();
            this.spltTextExclude.Panel1.SuspendLayout();
            this.spltTextExclude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbExclude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExcludeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).BeginInit();
            this.spltText.Panel1.SuspendLayout();
            this.spltText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbInclude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIncludeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLstLogLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBookmarkedMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBookmarkedMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilters)).BeginInit();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcFiltersLeft)).BeginInit();
            this.xtcFiltersLeft.SuspendLayout();
            this.xtpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftFilters)).BeginInit();
            this.pnlLeftFilters.SuspendLayout();
            this.pnlModulesAndDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcFilters)).BeginInit();
            this.xtcFilters.SuspendLayout();
            this.xtpFiltersIncludes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbInclude)).BeginInit();
            this.xtpFiltersExclude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbExclude)).BeginInit();
            this.xtpSearchFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgSearchMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGridPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelLogs.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dockPanelMessageInfo.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            this.dockPanelBookmarks.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
            // 
            // document1
            // 
            this.document1.Caption = "Logs";
            this.document1.ControlName = "dockPanelLogs";
            this.document1.FloatLocation = new System.Drawing.Point(0, 0);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Location = new System.Drawing.Point(0, 206);
            this.gridControl.MainView = this.logGrid;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1847, 264);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.logGrid});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            this.gridControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogGrid_KeyPress);
            // 
            // logGrid
            // 
            this.logGrid.Appearance.Row.Options.UseTextOptions = true;
            this.logGrid.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.logGrid.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.logGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDataSource,
            this.gridColumnDate,
            this.gridColumnTimeDiff,
            this.gridColumnText,
            this.gridColumnSource,
            this.gridColumnLevel,
            this.gridColumnClass,
            this.gridColumnCategory,
            this.gridColumnUser,
            this.gridColumnModule,
            this.gridColumnObject,
            this.gridColumnProcessID,
            this.gridColumnThread,
            this.gridColumnMachineName});
            this.logGrid.DetailHeight = 431;
            this.logGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.logGrid.GridControl = this.gridControl;
            this.logGrid.Images = this.imageList;
            this.logGrid.IndicatorWidth = 24;
            this.logGrid.Name = "logGrid";
            this.logGrid.OptionsBehavior.AllowIncrementalSearch = true;
            this.logGrid.OptionsFilter.AllowColumnMRUFilterList = false;
            this.logGrid.OptionsFilter.AllowMRUFilterList = false;
            this.logGrid.OptionsFind.AlwaysVisible = true;
            this.logGrid.OptionsLayout.Columns.StoreAllOptions = true;
            this.logGrid.OptionsLayout.Columns.StoreAppearance = true;
            this.logGrid.OptionsLayout.StoreAllOptions = true;
            this.logGrid.OptionsLayout.StoreAppearance = true;
            this.logGrid.OptionsLayout.StoreFormatRules = true;
            this.logGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.logGrid.OptionsView.AutoCalcPreviewLineCount = true;
            this.logGrid.OptionsView.ColumnAutoWidth = false;
            this.logGrid.OptionsView.RowAutoHeight = true;
            this.logGrid.OptionsView.ShowAutoFilterRow = true;
            this.logGrid.OptionsView.ShowGroupPanel = false;
            this.logGrid.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.LogGrid_CustomDrawRowIndicator);
            this.logGrid.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.LogGridView_SelectionChanged);
            this.logGrid.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.logGrid_FocusedRowChanged);
            this.logGrid.ShowFilterPopupListBox += new DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventHandler(this.GridViewShowFilterPopupListBox);
            this.logGrid.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.LogGridViewCustomColumnDisplayText);
            this.logGrid.Click += new System.EventHandler(this.logGrid_Click);
            this.logGrid.DoubleClick += new System.EventHandler(this.LogGrid_DoubleClick);
            // 
            // gridColumnDataSource
            // 
            this.gridColumnDataSource.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDataSource.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnDataSource.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnDataSource.Caption = "Data Source/File Name";
            this.gridColumnDataSource.FieldName = "DataProvider";
            this.gridColumnDataSource.MinWidth = 24;
            this.gridColumnDataSource.Name = "gridColumnDataSource";
            this.gridColumnDataSource.OptionsColumn.AllowEdit = false;
            this.gridColumnDataSource.OptionsColumn.AllowFocus = false;
            this.gridColumnDataSource.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDataSource.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDataSource.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnDataSource.OptionsColumn.ReadOnly = true;
            this.gridColumnDataSource.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnDataSource.Visible = true;
            this.gridColumnDataSource.VisibleIndex = 0;
            this.gridColumnDataSource.Width = 175;
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnDate.Caption = "Date";
            this.gridColumnDate.DisplayFormat.FormatString = "yyyy.MM.dd HH:mm:ss.ff";
            this.gridColumnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDate.FieldName = "Date";
            this.gridColumnDate.MinWidth = 24;
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.OptionsColumn.AllowEdit = false;
            this.gridColumnDate.OptionsColumn.AllowFocus = false;
            this.gridColumnDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnDate.OptionsColumn.ReadOnly = true;
            this.gridColumnDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 1;
            this.gridColumnDate.Width = 164;
            // 
            // gridColumnTimeDiff
            // 
            this.gridColumnTimeDiff.Caption = "Time Difference";
            this.gridColumnTimeDiff.FieldName = "TimeDiff";
            this.gridColumnTimeDiff.MinWidth = 22;
            this.gridColumnTimeDiff.Name = "gridColumnTimeDiff";
            this.gridColumnTimeDiff.OptionsColumn.AllowEdit = false;
            this.gridColumnTimeDiff.Width = 87;
            // 
            // gridColumnText
            // 
            this.gridColumnText.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnText.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnText.Caption = "Text";
            this.gridColumnText.FieldName = "Text";
            this.gridColumnText.MinWidth = 24;
            this.gridColumnText.Name = "gridColumnText";
            this.gridColumnText.OptionsColumn.AllowEdit = false;
            this.gridColumnText.OptionsColumn.AllowFocus = false;
            this.gridColumnText.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnText.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnText.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnText.OptionsColumn.ReadOnly = true;
            this.gridColumnText.OptionsFilter.AllowFilter = false;
            this.gridColumnText.Visible = true;
            this.gridColumnText.VisibleIndex = 2;
            this.gridColumnText.Width = 290;
            // 
            // gridColumnSource
            // 
            this.gridColumnSource.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSource.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnSource.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnSource.Caption = "Source";
            this.gridColumnSource.FieldName = "Source";
            this.gridColumnSource.MinWidth = 24;
            this.gridColumnSource.Name = "gridColumnSource";
            this.gridColumnSource.OptionsColumn.AllowEdit = false;
            this.gridColumnSource.OptionsColumn.AllowFocus = false;
            this.gridColumnSource.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnSource.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnSource.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnSource.OptionsColumn.ReadOnly = true;
            this.gridColumnSource.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnSource.Visible = true;
            this.gridColumnSource.VisibleIndex = 3;
            this.gridColumnSource.Width = 234;
            // 
            // gridColumnLevel
            // 
            this.gridColumnLevel.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnLevel.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnLevel.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnLevel.Caption = "Level";
            this.gridColumnLevel.FieldName = "Level";
            this.gridColumnLevel.MinWidth = 24;
            this.gridColumnLevel.Name = "gridColumnLevel";
            this.gridColumnLevel.OptionsColumn.AllowEdit = false;
            this.gridColumnLevel.OptionsColumn.AllowFocus = false;
            this.gridColumnLevel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnLevel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnLevel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnLevel.OptionsColumn.ReadOnly = true;
            this.gridColumnLevel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnLevel.Visible = true;
            this.gridColumnLevel.VisibleIndex = 4;
            this.gridColumnLevel.Width = 115;
            // 
            // gridColumnClass
            // 
            this.gridColumnClass.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnClass.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnClass.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnClass.Caption = "Class";
            this.gridColumnClass.FieldName = "Class";
            this.gridColumnClass.MinWidth = 24;
            this.gridColumnClass.Name = "gridColumnClass";
            this.gridColumnClass.OptionsColumn.AllowEdit = false;
            this.gridColumnClass.OptionsColumn.AllowFocus = false;
            this.gridColumnClass.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnClass.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnClass.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnClass.OptionsColumn.ReadOnly = true;
            this.gridColumnClass.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnClass.Visible = true;
            this.gridColumnClass.VisibleIndex = 6;
            this.gridColumnClass.Width = 115;
            // 
            // gridColumnCategory
            // 
            this.gridColumnCategory.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCategory.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnCategory.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnCategory.Caption = "Category";
            this.gridColumnCategory.FieldName = "Category";
            this.gridColumnCategory.MinWidth = 24;
            this.gridColumnCategory.Name = "gridColumnCategory";
            this.gridColumnCategory.OptionsColumn.AllowEdit = false;
            this.gridColumnCategory.OptionsColumn.AllowFocus = false;
            this.gridColumnCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnCategory.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnCategory.OptionsColumn.ReadOnly = true;
            this.gridColumnCategory.Visible = true;
            this.gridColumnCategory.VisibleIndex = 7;
            this.gridColumnCategory.Width = 115;
            // 
            // gridColumnUser
            // 
            this.gridColumnUser.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnUser.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnUser.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnUser.Caption = "User";
            this.gridColumnUser.FieldName = "User";
            this.gridColumnUser.MinWidth = 24;
            this.gridColumnUser.Name = "gridColumnUser";
            this.gridColumnUser.OptionsColumn.AllowEdit = false;
            this.gridColumnUser.OptionsColumn.AllowFocus = false;
            this.gridColumnUser.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnUser.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnUser.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnUser.OptionsColumn.ReadOnly = true;
            this.gridColumnUser.Visible = true;
            this.gridColumnUser.VisibleIndex = 8;
            this.gridColumnUser.Width = 115;
            // 
            // gridColumnModule
            // 
            this.gridColumnModule.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnModule.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnModule.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnModule.Caption = "Process/Module";
            this.gridColumnModule.FieldName = "Module";
            this.gridColumnModule.MinWidth = 24;
            this.gridColumnModule.Name = "gridColumnModule";
            this.gridColumnModule.OptionsColumn.AllowEdit = false;
            this.gridColumnModule.OptionsColumn.AllowFocus = false;
            this.gridColumnModule.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnModule.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnModule.OptionsColumn.ReadOnly = true;
            this.gridColumnModule.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnModule.Visible = true;
            this.gridColumnModule.VisibleIndex = 5;
            this.gridColumnModule.Width = 115;
            // 
            // gridColumnObject
            // 
            this.gridColumnObject.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnObject.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnObject.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnObject.Caption = "Object";
            this.gridColumnObject.FieldName = "Object";
            this.gridColumnObject.MinWidth = 24;
            this.gridColumnObject.Name = "gridColumnObject";
            this.gridColumnObject.OptionsColumn.AllowEdit = false;
            this.gridColumnObject.OptionsColumn.AllowFocus = false;
            this.gridColumnObject.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnObject.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnObject.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnObject.OptionsColumn.ReadOnly = true;
            this.gridColumnObject.OptionsColumn.ShowCaption = false;
            this.gridColumnObject.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColumnObject.Width = 87;
            // 
            // gridColumnProcessID
            // 
            this.gridColumnProcessID.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnProcessID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnProcessID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnProcessID.Caption = "ProcessID";
            this.gridColumnProcessID.FieldName = "ProcessID";
            this.gridColumnProcessID.MinWidth = 24;
            this.gridColumnProcessID.Name = "gridColumnProcessID";
            this.gridColumnProcessID.OptionsColumn.AllowEdit = false;
            this.gridColumnProcessID.OptionsColumn.AllowFocus = false;
            this.gridColumnProcessID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnProcessID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnProcessID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnProcessID.OptionsColumn.ReadOnly = true;
            this.gridColumnProcessID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnProcessID.Visible = true;
            this.gridColumnProcessID.VisibleIndex = 9;
            this.gridColumnProcessID.Width = 115;
            // 
            // gridColumnThread
            // 
            this.gridColumnThread.Caption = "Thread ID";
            this.gridColumnThread.FieldName = "ThreadID";
            this.gridColumnThread.MinWidth = 25;
            this.gridColumnThread.Name = "gridColumnThread";
            this.gridColumnThread.OptionsColumn.AllowEdit = false;
            this.gridColumnThread.Visible = true;
            this.gridColumnThread.VisibleIndex = 10;
            this.gridColumnThread.Width = 109;
            // 
            // gridColumnMachineName
            // 
            this.gridColumnMachineName.Caption = "Machine Name";
            this.gridColumnMachineName.FieldName = "MachineName";
            this.gridColumnMachineName.MinWidth = 25;
            this.gridColumnMachineName.Name = "gridColumnMachineName";
            this.gridColumnMachineName.OptionsColumn.AllowEdit = false;
            this.gridColumnMachineName.Visible = true;
            this.gridColumnMachineName.VisibleIndex = 11;
            this.gridColumnMachineName.Width = 94;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Error_16x16.png");
            this.imageList.Images.SetKeyName(1, "Warning_16x16.png");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "folder32x32.gif");
            this.imageList.Images.SetKeyName(4, "Error_32x32.png");
            this.imageList.Images.SetKeyName(5, "Warning_32x32.png");
            this.imageList.Images.SetKeyName(6, "debug.gif");
            this.imageList.Images.SetKeyName(7, "New_16x16.png");
            this.imageList.Images.SetKeyName(8, "Analogy_icon1_16x16.ico");
            this.imageList.Images.SetKeyName(9, "Question_16x16.png");
            this.imageList.Images.SetKeyName(10, "log16x16.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbHighlight);
            this.panel1.Controls.Add(this.sbtnMoreHighlight);
            this.panel1.Controls.Add(this.pnlButtonsHighlight);
            this.panel1.Controls.Add(this.chkbHighlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1847, 26);
            this.panel1.TabIndex = 4;
            // 
            // txtbHighlight
            // 
            this.txtbHighlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbHighlight.Location = new System.Drawing.Point(200, 0);
            this.txtbHighlight.MenuManager = this.barManager1;
            this.txtbHighlight.Name = "txtbHighlight";
            this.txtbHighlight.Size = new System.Drawing.Size(1163, 22);
            this.txtbHighlight.TabIndex = 23;
            this.txtbHighlight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbHighlight_KeyUp);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTopFiltering,
            this.BbarMainMenu,
            this.barMessage,
            this.barBookmark,
            this.barGroup,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.bdcTopFiltering);
            this.barManager1.DockControls.Add(this.sbarMessageInfo);
            this.barManager1.DockControls.Add(this.sbarBookmarks);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btswitchMessageDetails,
            this.btswitchRefreshLog,
            this.bBtnSaveLog,
            this.bBtnImport,
            this.bBtnClearLog,
            this.bBtnExpand,
            this.barButtonItem3,
            this.bBtnButtomExpand,
            this.bBtnCopyButtom,
            this.btSwitchExpandButtomMessage,
            this.bBtnopyBookmarked,
            this.barButtonItem4,
            this.bBtnGoToMessage,
            this.bBtnRemoveBoomark,
            this.bBtnCopyAllBookmarks,
            this.btsAutoScrollToBottom,
            this.bSMExports,
            this.bBtnExportExcel,
            this.bBtnExportCSV,
            this.bBtnExportHtml,
            this.bBtnUndockView,
            this.bBtnSaveEntireLog,
            this.bBtnDataVisualizer,
            this.bbiScreenshot,
            this.bbtnSaveViewAgnostic,
            this.barSubItemSaveLog,
            this.barButtonItemSaveEntireInAnalogy,
            this.barSubItem1,
            this.bBtnUndockViewPerProcess,
            this.bBtnShare,
            this.bBtnFullGrid,
            this.bbtnReload,
            this.bBtnSaveCurrentSelectionCustomFormat,
            this.bBtnSaveCurrentSelectionAnalogyFormat,
            this.bBtnUndockSelection,
            this.bbiDiffTime,
            this.bbiDatetiemFilterFrom,
            this.bbiDatetiemFilterTo,
            this.bbiBookmarkNonPersist,
            this.bbiBookmarkPersist,
            this.bbiCopyMessage,
            this.bbiCopyAllMessages,
            this.bbiAddNoteToMessage,
            this.bbiIncludeMessage,
            this.bbiIncludeColumnHeaderFilter,
            this.bbiExcludeMessage,
            this.bbiExcludeSource,
            this.bbiExcludeModule,
            this.bbiSaveLayout,
            this.bbiIncreaseFontSize,
            this.bbiDecreaseFontSize,
            this.bbiIncludeSource,
            this.bbiIncludeModule,
            this.bbiSaveBookmarks,
            this.bbiJsonViewer,
            this.bbtnCancel,
            this.bstaticTotalMessages,
            this.bstaticAlert,
            this.bprogressBar});
            this.barManager1.MainMenu = this.BbarMainMenu;
            this.barManager1.MaxItemId = 71;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemProgressBar2,
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.StatusBar = this.bar1;
            // 
            // barTopFiltering
            // 
            this.barTopFiltering.BarName = "Log Operations";
            this.barTopFiltering.DockCol = 0;
            this.barTopFiltering.DockRow = 0;
            this.barTopFiltering.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barTopFiltering.FloatLocation = new System.Drawing.Point(133, 284);
            this.barTopFiltering.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnClearLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnRemoveBoomark),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btswitchMessageDetails),
            new DevExpress.XtraBars.LinkPersistInfo(this.btswitchRefreshLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsAutoScrollToBottom),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSaveLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bSMExports),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnFullGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiScreenshot),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnImport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnDataVisualizer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnShare)});
            this.barTopFiltering.OptionsBar.AllowQuickCustomization = false;
            this.barTopFiltering.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barTopFiltering.OptionsBar.DisableClose = true;
            this.barTopFiltering.OptionsBar.DisableCustomization = true;
            this.barTopFiltering.OptionsBar.UseWholeRow = true;
            this.barTopFiltering.StandaloneBarDockControl = this.bdcTopFiltering;
            this.barTopFiltering.Text = "Operations";
            // 
            // bBtnClearLog
            // 
            this.bBtnClearLog.Caption = "Clear Log";
            this.bBtnClearLog.Id = 6;
            this.bBtnClearLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnClearLog.ImageOptions.Image")));
            this.bBtnClearLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnClearLog.ImageOptions.LargeImage")));
            this.bBtnClearLog.Name = "bBtnClearLog";
            this.bBtnClearLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnClearLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnClearLog_ItemClick);
            // 
            // bBtnRemoveBoomark
            // 
            this.bBtnRemoveBoomark.Caption = "Delete message";
            this.bBtnRemoveBoomark.Id = 15;
            this.bBtnRemoveBoomark.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnRemoveBoomark.ImageOptions.Image")));
            this.bBtnRemoveBoomark.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnRemoveBoomark.ImageOptions.LargeImage")));
            this.bBtnRemoveBoomark.Name = "bBtnRemoveBoomark";
            this.bBtnRemoveBoomark.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnRemoveBoomark.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnRemoveBoomark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnRemoveBoomark_ItemClick);
            // 
            // bbtnReload
            // 
            this.bbtnReload.Caption = "Reload Files";
            this.bbtnReload.Id = 38;
            this.bbtnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnReload.ImageOptions.SvgImage")));
            this.bbtnReload.Name = "bbtnReload";
            this.bbtnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbtnReload.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btswitchMessageDetails
            // 
            this.btswitchMessageDetails.BindableChecked = true;
            this.btswitchMessageDetails.Caption = "Message Details";
            this.btswitchMessageDetails.Checked = true;
            this.btswitchMessageDetails.Hint = "Show/Hide selected message details (CTRL+D)";
            this.btswitchMessageDetails.Id = 2;
            this.btswitchMessageDetails.Name = "btswitchMessageDetails";
            this.btswitchMessageDetails.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btswitchExpand_CheckedChanged);
            // 
            // btswitchRefreshLog
            // 
            this.btswitchRefreshLog.Caption = "Refresh log:";
            this.btswitchRefreshLog.Id = 3;
            this.btswitchRefreshLog.Name = "btswitchRefreshLog";
            this.btswitchRefreshLog.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btswitchRefreshLog_CheckedChanged);
            // 
            // btsAutoScrollToBottom
            // 
            this.btsAutoScrollToBottom.Caption = "Scroll to newest message:";
            this.btsAutoScrollToBottom.Id = 18;
            this.btsAutoScrollToBottom.Name = "btsAutoScrollToBottom";
            this.btsAutoScrollToBottom.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsAutoScrollToBottom_CheckedChanged);
            // 
            // barSubItemSaveLog
            // 
            this.barSubItemSaveLog.Caption = "Save Log";
            this.barSubItemSaveLog.Id = 31;
            this.barSubItemSaveLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveLog.ImageOptions.Image")));
            this.barSubItemSaveLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveLog.ImageOptions.LargeImage")));
            this.barSubItemSaveLog.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSaveEntireInAnalogy),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnSaveViewAgnostic),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveCurrentSelectionAnalogyFormat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveEntireLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveCurrentSelectionCustomFormat)});
            this.barSubItemSaveLog.Name = "barSubItemSaveLog";
            this.barSubItemSaveLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItemSaveEntireInAnalogy
            // 
            this.barButtonItemSaveEntireInAnalogy.Caption = "Save entire log in Analogy Format (agnostic to specific implementation)";
            this.barButtonItemSaveEntireInAnalogy.Id = 32;
            this.barButtonItemSaveEntireInAnalogy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveEntireInAnalogy.ImageOptions.Image")));
            this.barButtonItemSaveEntireInAnalogy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveEntireInAnalogy.ImageOptions.LargeImage")));
            this.barButtonItemSaveEntireInAnalogy.Name = "barButtonItemSaveEntireInAnalogy";
            this.barButtonItemSaveEntireInAnalogy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemSaveEntireInAnalogy_ItemClick);
            // 
            // bbtnSaveViewAgnostic
            // 
            this.bbtnSaveViewAgnostic.Caption = "Save current view in Analogy Format (agnostic to Specific implementation)";
            this.bbtnSaveViewAgnostic.Id = 30;
            this.bbtnSaveViewAgnostic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSaveViewAgnostic.ImageOptions.Image")));
            this.bbtnSaveViewAgnostic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSaveViewAgnostic.ImageOptions.LargeImage")));
            this.bbtnSaveViewAgnostic.Name = "bbtnSaveViewAgnostic";
            this.bbtnSaveViewAgnostic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbtnSaveViewAgnostic_ItemClick);
            // 
            // bBtnSaveCurrentSelectionAnalogyFormat
            // 
            this.bBtnSaveCurrentSelectionAnalogyFormat.Caption = "Save current rows selection in Analogy Format (agnostic to Specific implementatio" +
    "n)";
            this.bBtnSaveCurrentSelectionAnalogyFormat.Id = 40;
            this.bBtnSaveCurrentSelectionAnalogyFormat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveCurrentSelectionAnalogyFormat.ImageOptions.Image")));
            this.bBtnSaveCurrentSelectionAnalogyFormat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveCurrentSelectionAnalogyFormat.ImageOptions.LargeImage")));
            this.bBtnSaveCurrentSelectionAnalogyFormat.Name = "bBtnSaveCurrentSelectionAnalogyFormat";
            this.bBtnSaveCurrentSelectionAnalogyFormat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveCurrentSelectionAnalogyFormat_ItemClick);
            // 
            // bBtnSaveEntireLog
            // 
            this.bBtnSaveEntireLog.Caption = "Save entire Log (custom Format)";
            this.bBtnSaveEntireLog.Id = 25;
            this.bBtnSaveEntireLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveEntireLog.ImageOptions.Image")));
            this.bBtnSaveEntireLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveEntireLog.ImageOptions.LargeImage")));
            this.bBtnSaveEntireLog.Name = "bBtnSaveEntireLog";
            this.bBtnSaveEntireLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnSaveEntireLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveEntireLog_ItemClick);
            // 
            // bBtnSaveLog
            // 
            this.bBtnSaveLog.Caption = "Save current view (custom Format)";
            this.bBtnSaveLog.Id = 4;
            this.bBtnSaveLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveLog.ImageOptions.Image")));
            this.bBtnSaveLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveLog.ImageOptions.LargeImage")));
            this.bBtnSaveLog.Name = "bBtnSaveLog";
            this.bBtnSaveLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnSaveLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveLog_ItemClick);
            // 
            // bBtnSaveCurrentSelectionCustomFormat
            // 
            this.bBtnSaveCurrentSelectionCustomFormat.Caption = "save current rows selection (custom Format)";
            this.bBtnSaveCurrentSelectionCustomFormat.Id = 39;
            this.bBtnSaveCurrentSelectionCustomFormat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveCurrentSelectionCustomFormat.ImageOptions.Image")));
            this.bBtnSaveCurrentSelectionCustomFormat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveCurrentSelectionCustomFormat.ImageOptions.LargeImage")));
            this.bBtnSaveCurrentSelectionCustomFormat.Name = "bBtnSaveCurrentSelectionCustomFormat";
            this.bBtnSaveCurrentSelectionCustomFormat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveCurrentSelectionCustomFormat_ItemClick);
            // 
            // bSMExports
            // 
            this.bSMExports.Caption = "Export";
            this.bSMExports.Id = 20;
            this.bSMExports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bSMExports.ImageOptions.Image")));
            this.bSMExports.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bSMExports.ImageOptions.LargeImage")));
            this.bSMExports.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bBtnExportExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnExportCSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnExportHtml)});
            this.bSMExports.Name = "bSMExports";
            this.bSMExports.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnExportExcel
            // 
            this.bBtnExportExcel.Caption = "Export To Excel";
            this.bBtnExportExcel.Id = 21;
            this.bBtnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportExcel.ImageOptions.Image")));
            this.bBtnExportExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportExcel.ImageOptions.LargeImage")));
            this.bBtnExportExcel.Name = "bBtnExportExcel";
            this.bBtnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportExcel_ItemClick);
            // 
            // bBtnExportCSV
            // 
            this.bBtnExportCSV.Caption = "Export To CSV";
            this.bBtnExportCSV.Id = 22;
            this.bBtnExportCSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportCSV.ImageOptions.Image")));
            this.bBtnExportCSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportCSV.ImageOptions.LargeImage")));
            this.bBtnExportCSV.Name = "bBtnExportCSV";
            this.bBtnExportCSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportCSV_ItemClick);
            // 
            // bBtnExportHtml
            // 
            this.bBtnExportHtml.Caption = "Export To Html";
            this.bBtnExportHtml.Id = 23;
            this.bBtnExportHtml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportHtml.ImageOptions.Image")));
            this.bBtnExportHtml.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportHtml.ImageOptions.LargeImage")));
            this.bBtnExportHtml.Name = "bBtnExportHtml";
            this.bBtnExportHtml.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnExportHtml.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnExportHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportHtml_ItemClick);
            // 
            // bBtnFullGrid
            // 
            this.bBtnFullGrid.Caption = "Full";
            this.bBtnFullGrid.Id = 37;
            this.bBtnFullGrid.ImageOptions.Image = global::Analogy.Properties.Resources.FullscreenBlue16;
            this.bBtnFullGrid.Name = "bBtnFullGrid";
            this.bBtnFullGrid.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Undock View";
            this.barSubItem1.Id = 34;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnUndockView),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnUndockViewPerProcess),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnUndockSelection)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnUndockView
            // 
            this.bBtnUndockView.Caption = "Undock View (No Filtering)";
            this.bBtnUndockView.Id = 24;
            this.bBtnUndockView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnUndockView.ImageOptions.Image")));
            this.bBtnUndockView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnUndockView.ImageOptions.LargeImage")));
            this.bBtnUndockView.Name = "bBtnUndockView";
            this.bBtnUndockView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnUndockView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUndockView_ItemClick);
            // 
            // bBtnUndockViewPerProcess
            // 
            this.bBtnUndockViewPerProcess.Caption = "Undock View per process/Module";
            this.bBtnUndockViewPerProcess.Id = 35;
            this.bBtnUndockViewPerProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnUndockViewPerProcess.ImageOptions.Image")));
            this.bBtnUndockViewPerProcess.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnUndockViewPerProcess.ImageOptions.LargeImage")));
            this.bBtnUndockViewPerProcess.Name = "bBtnUndockViewPerProcess";
            this.bBtnUndockViewPerProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUndockViewPerProcess_ItemClick);
            // 
            // bBtnUndockSelection
            // 
            this.bBtnUndockSelection.Caption = "Undock rows selection";
            this.bBtnUndockSelection.Id = 41;
            this.bBtnUndockSelection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnUndockSelection.ImageOptions.Image")));
            this.bBtnUndockSelection.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnUndockSelection.ImageOptions.LargeImage")));
            this.bBtnUndockSelection.Name = "bBtnUndockSelection";
            this.bBtnUndockSelection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUndockSelection_ItemClick);
            // 
            // bbiScreenshot
            // 
            this.bbiScreenshot.Caption = "Take screenshot";
            this.bbiScreenshot.Hint = "Take screenshot of the messages control";
            this.bbiScreenshot.Id = 27;
            this.bbiScreenshot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiScreenshot.ImageOptions.Image")));
            this.bbiScreenshot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiScreenshot.ImageOptions.LargeImage")));
            this.bbiScreenshot.Name = "bbiScreenshot";
            this.bbiScreenshot.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiScreenshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiScreenshot_ItemClick);
            // 
            // bBtnImport
            // 
            this.bBtnImport.Caption = "Import Log";
            this.bBtnImport.Id = 5;
            this.bBtnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnImport.ImageOptions.Image")));
            this.bBtnImport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnImport.ImageOptions.LargeImage")));
            this.bBtnImport.Name = "bBtnImport";
            this.bBtnImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnImport_ItemClick);
            // 
            // bBtnDataVisualizer
            // 
            this.bBtnDataVisualizer.Caption = "Data Visualizer";
            this.bBtnDataVisualizer.Id = 26;
            this.bBtnDataVisualizer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnDataVisualizer.ImageOptions.Image")));
            this.bBtnDataVisualizer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnDataVisualizer.ImageOptions.LargeImage")));
            this.bBtnDataVisualizer.Name = "bBtnDataVisualizer";
            this.bBtnDataVisualizer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnDataVisualizer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnDataVisualizer_ItemClick);
            // 
            // bBtnShare
            // 
            this.bBtnShare.Caption = "Share Log";
            this.bBtnShare.Id = 36;
            this.bBtnShare.ImageOptions.Image = global::Analogy.Properties.Resources.upload16x16;
            this.bBtnShare.Name = "bBtnShare";
            this.bBtnShare.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bdcTopFiltering
            // 
            this.bdcTopFiltering.AutoSize = true;
            this.bdcTopFiltering.CausesValidation = false;
            this.bdcTopFiltering.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdcTopFiltering.Location = new System.Drawing.Point(0, 0);
            this.bdcTopFiltering.Manager = this.barManager1;
            this.bdcTopFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdcTopFiltering.Name = "bdcTopFiltering";
            this.bdcTopFiltering.Size = new System.Drawing.Size(1847, 39);
            this.bdcTopFiltering.Text = "standaloneBarDockControl1";
            // 
            // BbarMainMenu
            // 
            this.BbarMainMenu.BarName = "Main menu";
            this.BbarMainMenu.DockCol = 0;
            this.BbarMainMenu.DockRow = 0;
            this.BbarMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BbarMainMenu.FloatLocation = new System.Drawing.Point(258, 133);
            this.BbarMainMenu.OptionsBar.MultiLine = true;
            this.BbarMainMenu.OptionsBar.UseWholeRow = true;
            this.BbarMainMenu.Text = "Main menu";
            this.BbarMainMenu.Visible = false;
            // 
            // barMessage
            // 
            this.barMessage.BarName = "Message";
            this.barMessage.DockCol = 0;
            this.barMessage.DockRow = 0;
            this.barMessage.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barMessage.FloatLocation = new System.Drawing.Point(901, 601);
            this.barMessage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnCopyButtom)});
            this.barMessage.OptionsBar.AllowCollapse = true;
            this.barMessage.OptionsBar.AllowDelete = true;
            this.barMessage.OptionsBar.AllowQuickCustomization = false;
            this.barMessage.OptionsBar.AllowRename = true;
            this.barMessage.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barMessage.OptionsBar.DisableClose = true;
            this.barMessage.OptionsBar.DisableCustomization = true;
            this.barMessage.OptionsBar.UseWholeRow = true;
            this.barMessage.StandaloneBarDockControl = this.sbarMessageInfo;
            this.barMessage.Text = "Message Info";
            // 
            // bBtnCopyButtom
            // 
            this.bBtnCopyButtom.Caption = "Copy";
            this.bBtnCopyButtom.Id = 10;
            this.bBtnCopyButtom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnCopyButtom.ImageOptions.Image")));
            this.bBtnCopyButtom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnCopyButtom.ImageOptions.LargeImage")));
            this.bBtnCopyButtom.Name = "bBtnCopyButtom";
            this.bBtnCopyButtom.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnCopyButtom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnCopyButtom_ItemClick);
            // 
            // sbarMessageInfo
            // 
            this.sbarMessageInfo.CausesValidation = false;
            this.sbarMessageInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbarMessageInfo.Location = new System.Drawing.Point(0, 0);
            this.sbarMessageInfo.Manager = this.barManager1;
            this.sbarMessageInfo.Name = "sbarMessageInfo";
            this.sbarMessageInfo.Size = new System.Drawing.Size(1843, 29);
            this.sbarMessageInfo.Text = "standaloneBarDockControl1";
            // 
            // barBookmark
            // 
            this.barBookmark.BarName = "Boommarks";
            this.barBookmark.DockCol = 0;
            this.barBookmark.DockRow = 0;
            this.barBookmark.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barBookmark.FloatLocation = new System.Drawing.Point(166, 593);
            this.barBookmark.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSaveBookmarks),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnopyBookmarked),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnCopyAllBookmarks),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnGoToMessage)});
            this.barBookmark.OptionsBar.AllowCollapse = true;
            this.barBookmark.OptionsBar.AllowDelete = true;
            this.barBookmark.OptionsBar.AllowQuickCustomization = false;
            this.barBookmark.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barBookmark.OptionsBar.DisableClose = true;
            this.barBookmark.OptionsBar.DisableCustomization = true;
            this.barBookmark.OptionsBar.UseWholeRow = true;
            this.barBookmark.StandaloneBarDockControl = this.sbarBookmarks;
            this.barBookmark.Text = "Custom 5";
            // 
            // bbiSaveBookmarks
            // 
            this.bbiSaveBookmarks.Caption = "Save Bookmarks";
            this.bbiSaveBookmarks.Id = 61;
            this.bbiSaveBookmarks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSaveBookmarks.ImageOptions.Image")));
            this.bbiSaveBookmarks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSaveBookmarks.ImageOptions.LargeImage")));
            this.bbiSaveBookmarks.Name = "bbiSaveBookmarks";
            this.bbiSaveBookmarks.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnopyBookmarked
            // 
            this.bBtnopyBookmarked.Caption = "Copy Selected Message";
            this.bBtnopyBookmarked.Id = 12;
            this.bBtnopyBookmarked.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnopyBookmarked.ImageOptions.Image")));
            this.bBtnopyBookmarked.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnopyBookmarked.ImageOptions.LargeImage")));
            this.bBtnopyBookmarked.Name = "bBtnopyBookmarked";
            this.bBtnopyBookmarked.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnopyBookmarked.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnopyBookmarked_ItemClick);
            // 
            // bBtnCopyAllBookmarks
            // 
            this.bBtnCopyAllBookmarks.Caption = "Copy all messages in grid";
            this.bBtnCopyAllBookmarks.Id = 16;
            this.bBtnCopyAllBookmarks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnCopyAllBookmarks.ImageOptions.Image")));
            this.bBtnCopyAllBookmarks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnCopyAllBookmarks.ImageOptions.LargeImage")));
            this.bBtnCopyAllBookmarks.Name = "bBtnCopyAllBookmarks";
            this.bBtnCopyAllBookmarks.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnCopyAllBookmarks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnCopyAllBookmarks_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Clear Bookmarks";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bBtnGoToMessage
            // 
            this.bBtnGoToMessage.Caption = "Go To Message";
            this.bBtnGoToMessage.Id = 14;
            this.bBtnGoToMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnGoToMessage.ImageOptions.Image")));
            this.bBtnGoToMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnGoToMessage.ImageOptions.LargeImage")));
            this.bBtnGoToMessage.Name = "bBtnGoToMessage";
            this.bBtnGoToMessage.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnGoToMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnGoToMessage_ItemClick);
            // 
            // sbarBookmarks
            // 
            this.sbarBookmarks.CausesValidation = false;
            this.sbarBookmarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbarBookmarks.Location = new System.Drawing.Point(0, 0);
            this.sbarBookmarks.Manager = this.barManager1;
            this.sbarBookmarks.Name = "sbarBookmarks";
            this.sbarBookmarks.Size = new System.Drawing.Size(1843, 38);
            this.sbarBookmarks.Text = "standaloneBarDockControl1";
            // 
            // barGroup
            // 
            this.barGroup.BarName = "Counts";
            this.barGroup.DockCol = 0;
            this.barGroup.DockRow = 0;
            this.barGroup.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barGroup.FloatLocation = new System.Drawing.Point(327, 221);
            this.barGroup.OptionsBar.AllowQuickCustomization = false;
            this.barGroup.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barGroup.OptionsBar.UseWholeRow = true;
            this.barGroup.Text = "Counts";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 7";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bstaticTotalMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.bstaticAlert),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.bprogressBar, "", false, true, true, 534)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 7";
            // 
            // bstaticTotalMessages
            // 
            this.bstaticTotalMessages.Caption = "Total messages: N/A";
            this.bstaticTotalMessages.Id = 67;
            this.bstaticTotalMessages.Name = "bstaticTotalMessages";
            // 
            // bstaticAlert
            // 
            this.bstaticAlert.Caption = "ALERTS EXISTS: !";
            this.bstaticAlert.Id = 68;
            this.bstaticAlert.Name = "bstaticAlert";
            this.bstaticAlert.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbtnCancel.Caption = "Cancel Processing";
            this.bbtnCancel.Id = 66;
            this.bbtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnCancel.ImageOptions.Image")));
            this.bbtnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnCancel.ImageOptions.LargeImage")));
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbtnCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCancel_Click);
            // 
            // bprogressBar
            // 
            this.bprogressBar.AutoFillWidth = true;
            this.bprogressBar.Edit = this.repositoryItemMarqueeProgressBar1;
            this.bprogressBar.Id = 70;
            this.bprogressBar.Name = "bprogressBar";
            this.bprogressBar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bprogressBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1853, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 727);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1853, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1853, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // bBtnExpand
            // 
            this.bBtnExpand.Caption = "Expand";
            this.bBtnExpand.Id = 7;
            this.bBtnExpand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExpand.ImageOptions.Image")));
            this.bBtnExpand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExpand.ImageOptions.LargeImage")));
            this.bBtnExpand.Name = "bBtnExpand";
            this.bBtnExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Copy";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnButtomExpand
            // 
            this.bBtnButtomExpand.Caption = "Expand";
            this.bBtnButtomExpand.Id = 9;
            this.bBtnButtomExpand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnButtomExpand.ImageOptions.Image")));
            this.bBtnButtomExpand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnButtomExpand.ImageOptions.LargeImage")));
            this.bBtnButtomExpand.Name = "bBtnButtomExpand";
            this.bBtnButtomExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnButtomExpand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnButtomExpand_ItemClick);
            // 
            // btSwitchExpandButtomMessage
            // 
            this.btSwitchExpandButtomMessage.Caption = "Expand";
            this.btSwitchExpandButtomMessage.Id = 11;
            this.btSwitchExpandButtomMessage.Name = "btSwitchExpandButtomMessage";
            this.btSwitchExpandButtomMessage.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleSwitchItem1_CheckedChanged);
            // 
            // bbiDiffTime
            // 
            this.bbiDiffTime.Caption = "Calculate time difference from this point";
            this.bbiDiffTime.Id = 43;
            this.bbiDiffTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDiffTime.ImageOptions.Image")));
            this.bbiDiffTime.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDiffTime.ImageOptions.LargeImage")));
            this.bbiDiffTime.Name = "bbiDiffTime";
            // 
            // bbiDatetiemFilterFrom
            // 
            this.bbiDatetiemFilterFrom.Caption = "Date Time Filter: From";
            this.bbiDatetiemFilterFrom.Id = 44;
            this.bbiDatetiemFilterFrom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDatetiemFilterFrom.ImageOptions.Image")));
            this.bbiDatetiemFilterFrom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDatetiemFilterFrom.ImageOptions.LargeImage")));
            this.bbiDatetiemFilterFrom.Name = "bbiDatetiemFilterFrom";
            // 
            // bbiDatetiemFilterTo
            // 
            this.bbiDatetiemFilterTo.Caption = "Date Time Filter: To";
            this.bbiDatetiemFilterTo.Id = 45;
            this.bbiDatetiemFilterTo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDatetiemFilterTo.ImageOptions.Image")));
            this.bbiDatetiemFilterTo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDatetiemFilterTo.ImageOptions.LargeImage")));
            this.bbiDatetiemFilterTo.Name = "bbiDatetiemFilterTo";
            // 
            // bbiBookmarkNonPersist
            // 
            this.bbiBookmarkNonPersist.Caption = "Bookmark this message (Non persist)";
            this.bbiBookmarkNonPersist.Id = 46;
            this.bbiBookmarkNonPersist.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBookmarkNonPersist.ImageOptions.Image")));
            this.bbiBookmarkNonPersist.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBookmarkNonPersist.ImageOptions.LargeImage")));
            this.bbiBookmarkNonPersist.Name = "bbiBookmarkNonPersist";
            // 
            // bbiBookmarkPersist
            // 
            this.bbiBookmarkPersist.Caption = "Bookmark this message for later user (Persist)";
            this.bbiBookmarkPersist.Id = 47;
            this.bbiBookmarkPersist.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBookmarkPersist.ImageOptions.Image")));
            this.bbiBookmarkPersist.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBookmarkPersist.ImageOptions.LargeImage")));
            this.bbiBookmarkPersist.Name = "bbiBookmarkPersist";
            // 
            // bbiCopyMessage
            // 
            this.bbiCopyMessage.Caption = "Copy selected message to clipboard";
            this.bbiCopyMessage.Id = 48;
            this.bbiCopyMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCopyMessage.ImageOptions.Image")));
            this.bbiCopyMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCopyMessage.ImageOptions.LargeImage")));
            this.bbiCopyMessage.Name = "bbiCopyMessage";
            // 
            // bbiCopyAllMessages
            // 
            this.bbiCopyAllMessages.Caption = "Copy all messages in view to clipboard";
            this.bbiCopyAllMessages.Id = 49;
            this.bbiCopyAllMessages.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCopyAllMessages.ImageOptions.Image")));
            this.bbiCopyAllMessages.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCopyAllMessages.ImageOptions.LargeImage")));
            this.bbiCopyAllMessages.Name = "bbiCopyAllMessages";
            // 
            // bbiAddNoteToMessage
            // 
            this.bbiAddNoteToMessage.Caption = "Add Note/Comment to this message (not auto saved)";
            this.bbiAddNoteToMessage.Id = 50;
            this.bbiAddNoteToMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAddNoteToMessage.ImageOptions.Image")));
            this.bbiAddNoteToMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAddNoteToMessage.ImageOptions.LargeImage")));
            this.bbiAddNoteToMessage.Name = "bbiAddNoteToMessage";
            // 
            // bbiIncludeMessage
            // 
            this.bbiIncludeMessage.Caption = "Include Selected message";
            this.bbiIncludeMessage.Id = 51;
            this.bbiIncludeMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIncludeMessage.ImageOptions.Image")));
            this.bbiIncludeMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIncludeMessage.ImageOptions.LargeImage")));
            this.bbiIncludeMessage.Name = "bbiIncludeMessage";
            // 
            // bbiIncludeColumnHeaderFilter
            // 
            this.bbiIncludeColumnHeaderFilter.Caption = "Set X as column header filter for Y";
            this.bbiIncludeColumnHeaderFilter.Id = 52;
            this.bbiIncludeColumnHeaderFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIncludeColumnHeaderFilter.ImageOptions.Image")));
            this.bbiIncludeColumnHeaderFilter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIncludeColumnHeaderFilter.ImageOptions.LargeImage")));
            this.bbiIncludeColumnHeaderFilter.Name = "bbiIncludeColumnHeaderFilter";
            // 
            // bbiExcludeMessage
            // 
            this.bbiExcludeMessage.Caption = "Exclude selected message";
            this.bbiExcludeMessage.Id = 53;
            this.bbiExcludeMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExcludeMessage.ImageOptions.Image")));
            this.bbiExcludeMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExcludeMessage.ImageOptions.LargeImage")));
            this.bbiExcludeMessage.Name = "bbiExcludeMessage";
            // 
            // bbiExcludeSource
            // 
            this.bbiExcludeSource.Caption = "Exclude source";
            this.bbiExcludeSource.Id = 54;
            this.bbiExcludeSource.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExcludeSource.ImageOptions.Image")));
            this.bbiExcludeSource.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExcludeSource.ImageOptions.LargeImage")));
            this.bbiExcludeSource.Name = "bbiExcludeSource";
            // 
            // bbiExcludeModule
            // 
            this.bbiExcludeModule.Caption = "Exclude process/module";
            this.bbiExcludeModule.Id = 55;
            this.bbiExcludeModule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExcludeModule.ImageOptions.Image")));
            this.bbiExcludeModule.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExcludeModule.ImageOptions.LargeImage")));
            this.bbiExcludeModule.Name = "bbiExcludeModule";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save columns layout";
            this.bbiSaveLayout.Id = 56;
            this.bbiSaveLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSaveLayout.ImageOptions.Image")));
            this.bbiSaveLayout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSaveLayout.ImageOptions.LargeImage")));
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiIncreaseFontSize
            // 
            this.bbiIncreaseFontSize.Caption = "Increase font size";
            this.bbiIncreaseFontSize.Id = 57;
            this.bbiIncreaseFontSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIncreaseFontSize.ImageOptions.Image")));
            this.bbiIncreaseFontSize.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIncreaseFontSize.ImageOptions.LargeImage")));
            this.bbiIncreaseFontSize.Name = "bbiIncreaseFontSize";
            // 
            // bbiDecreaseFontSize
            // 
            this.bbiDecreaseFontSize.Caption = "Decrease font size";
            this.bbiDecreaseFontSize.Id = 58;
            this.bbiDecreaseFontSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDecreaseFontSize.ImageOptions.Image")));
            this.bbiDecreaseFontSize.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDecreaseFontSize.ImageOptions.LargeImage")));
            this.bbiDecreaseFontSize.Name = "bbiDecreaseFontSize";
            // 
            // bbiIncludeSource
            // 
            this.bbiIncludeSource.Caption = "Include source";
            this.bbiIncludeSource.Id = 59;
            this.bbiIncludeSource.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIncludeSource.ImageOptions.Image")));
            this.bbiIncludeSource.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIncludeSource.ImageOptions.LargeImage")));
            this.bbiIncludeSource.Name = "bbiIncludeSource";
            // 
            // bbiIncludeModule
            // 
            this.bbiIncludeModule.Caption = "Include process/module";
            this.bbiIncludeModule.Id = 60;
            this.bbiIncludeModule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIncludeModule.ImageOptions.Image")));
            this.bbiIncludeModule.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIncludeModule.ImageOptions.LargeImage")));
            this.bbiIncludeModule.Name = "bbiIncludeModule";
            // 
            // bbiJsonViewer
            // 
            this.bbiJsonViewer.Caption = "Open message in JSON Visualizer";
            this.bbiJsonViewer.Id = 62;
            this.bbiJsonViewer.ImageOptions.Image = global::Analogy.Properties.Resources.json16x16;
            this.bbiJsonViewer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiJsonViewer.ImageOptions.LargeImage")));
            this.bbiJsonViewer.Name = "bbiJsonViewer";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // repositoryItemProgressBar2
            // 
            this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
            // 
            // sbtnMoreHighlight
            // 
            this.sbtnMoreHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnMoreHighlight.Location = new System.Drawing.Point(1363, 0);
            this.sbtnMoreHighlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnMoreHighlight.Name = "sbtnMoreHighlight";
            this.sbtnMoreHighlight.Size = new System.Drawing.Size(71, 26);
            this.sbtnMoreHighlight.TabIndex = 43;
            this.sbtnMoreHighlight.Text = "More ...";
            this.sbtnMoreHighlight.Click += new System.EventHandler(this.sbtnMoreHighlight_Click);
            // 
            // pnlButtonsHighlight
            // 
            this.pnlButtonsHighlight.Controls.Add(this.lblPageNumber);
            this.pnlButtonsHighlight.Controls.Add(this.sBtnPageNext);
            this.pnlButtonsHighlight.Controls.Add(this.sBtnLastPage);
            this.pnlButtonsHighlight.Controls.Add(this.sbtnPagePrevious);
            this.pnlButtonsHighlight.Controls.Add(this.sbtnPageFirst);
            this.pnlButtonsHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonsHighlight.Location = new System.Drawing.Point(1434, 0);
            this.pnlButtonsHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonsHighlight.Name = "pnlButtonsHighlight";
            this.pnlButtonsHighlight.Size = new System.Drawing.Size(413, 26);
            this.pnlButtonsHighlight.TabIndex = 12;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageNumber.Appearance.Options.UseTextOptions = true;
            this.lblPageNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPageNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPageNumber.Location = new System.Drawing.Point(178, 4);
            this.lblPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(60, 18);
            this.lblPageNumber.TabIndex = 46;
            this.lblPageNumber.Text = "Page 1 / 1";
            // 
            // sBtnPageNext
            // 
            this.sBtnPageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnPageNext.Location = new System.Drawing.Point(248, 0);
            this.sBtnPageNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnPageNext.Name = "sBtnPageNext";
            this.sBtnPageNext.Size = new System.Drawing.Size(87, 25);
            this.sBtnPageNext.TabIndex = 45;
            this.sBtnPageNext.Text = "Next Page";
            this.sBtnPageNext.Click += new System.EventHandler(this.sBtnPageNext_Click);
            // 
            // sBtnLastPage
            // 
            this.sBtnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnLastPage.Location = new System.Drawing.Point(337, 0);
            this.sBtnLastPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnLastPage.Name = "sBtnLastPage";
            this.sBtnLastPage.Size = new System.Drawing.Size(73, 25);
            this.sBtnLastPage.TabIndex = 44;
            this.sBtnLastPage.Text = "Last Page";
            this.sBtnLastPage.Click += new System.EventHandler(this.sBtnLastPage_Click);
            // 
            // sbtnPagePrevious
            // 
            this.sbtnPagePrevious.Location = new System.Drawing.Point(85, 0);
            this.sbtnPagePrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnPagePrevious.Name = "sbtnPagePrevious";
            this.sbtnPagePrevious.Size = new System.Drawing.Size(87, 25);
            this.sbtnPagePrevious.TabIndex = 43;
            this.sbtnPagePrevious.Text = "Previous Page";
            this.sbtnPagePrevious.Click += new System.EventHandler(this.sbtnPagePrevious_Click);
            // 
            // sbtnPageFirst
            // 
            this.sbtnPageFirst.Location = new System.Drawing.Point(6, 0);
            this.sbtnPageFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnPageFirst.Name = "sbtnPageFirst";
            this.sbtnPageFirst.Size = new System.Drawing.Size(73, 25);
            this.sbtnPageFirst.TabIndex = 42;
            this.sbtnPageFirst.Text = "first Page";
            this.sbtnPageFirst.Click += new System.EventHandler(this.sbtnPageFirst_Click);
            // 
            // chkbHighlight
            // 
            this.chkbHighlight.AutoSize = true;
            this.chkbHighlight.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbHighlight.Location = new System.Drawing.Point(0, 0);
            this.chkbHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbHighlight.Name = "chkbHighlight";
            this.chkbHighlight.Size = new System.Drawing.Size(200, 26);
            this.chkbHighlight.TabIndex = 11;
            this.chkbHighlight.Text = "Highlight lines that contains:";
            this.chkbHighlight.UseVisualStyleBackColor = true;
            this.chkbHighlight.CheckedChanged += new System.EventHandler(this.chkbHighlight_CheckedChanged);
            // 
            // spltcDateFiltering
            // 
            this.spltcDateFiltering.Dock = System.Windows.Forms.DockStyle.Right;
            this.spltcDateFiltering.Location = new System.Drawing.Point(962, 0);
            this.spltcDateFiltering.Name = "spltcDateFiltering";
            // 
            // spltcDateFiltering.Panel1
            // 
            this.spltcDateFiltering.Panel1.Controls.Add(this.deOlderThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.ceOlderThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.deNewerThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.ceNewerThanFilter);
            this.spltcDateFiltering.Panel2Collapsed = true;
            this.spltcDateFiltering.Size = new System.Drawing.Size(521, 22);
            this.spltcDateFiltering.SplitterDistance = 496;
            this.spltcDateFiltering.TabIndex = 27;
            // 
            // deOlderThanFilter
            // 
            this.deOlderThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deOlderThanFilter.EditValue = new System.DateTime(2019, 11, 29, 10, 2, 22, 242);
            this.deOlderThanFilter.Location = new System.Drawing.Point(306, 0);
            this.deOlderThanFilter.MenuManager = this.barManager1;
            this.deOlderThanFilter.Name = "deOlderThanFilter";
            this.deOlderThanFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deOlderThanFilter.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deOlderThanFilter.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd.MM.yyyy hh:mm:ss.fff";
            this.deOlderThanFilter.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deOlderThanFilter.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss.fff";
            this.deOlderThanFilter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deOlderThanFilter.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss.fff";
            this.deOlderThanFilter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deOlderThanFilter.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss.fff";
            this.deOlderThanFilter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deOlderThanFilter.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deOlderThanFilter.Size = new System.Drawing.Size(207, 22);
            this.deOlderThanFilter.TabIndex = 27;
            // 
            // ceOlderThanFilter
            // 
            this.ceOlderThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceOlderThanFilter.Location = new System.Drawing.Point(264, 0);
            this.ceOlderThanFilter.MenuManager = this.barManager1;
            this.ceOlderThanFilter.Name = "ceOlderThanFilter";
            this.ceOlderThanFilter.Properties.Appearance.Options.UseImage = true;
            this.ceOlderThanFilter.Properties.AutoWidth = true;
            this.ceOlderThanFilter.Properties.Caption = "To:";
            this.ceOlderThanFilter.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceOlderThanFilter.Properties.ImageOptions.ImageChecked")));
            this.ceOlderThanFilter.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceOlderThanFilter.Properties.ImageOptions.ImageUnchecked")));
            this.ceOlderThanFilter.Size = new System.Drawing.Size(42, 22);
            this.ceOlderThanFilter.TabIndex = 29;
            // 
            // deNewerThanFilter
            // 
            this.deNewerThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deNewerThanFilter.EditValue = new System.DateTime(2019, 11, 29, 10, 2, 22, 242);
            this.deNewerThanFilter.Location = new System.Drawing.Point(57, 0);
            this.deNewerThanFilter.MenuManager = this.barManager1;
            this.deNewerThanFilter.Name = "deNewerThanFilter";
            this.deNewerThanFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNewerThanFilter.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNewerThanFilter.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd.MM.yyyy hh:mm:ss.fff";
            this.deNewerThanFilter.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deNewerThanFilter.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss.fff";
            this.deNewerThanFilter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNewerThanFilter.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss.fff";
            this.deNewerThanFilter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deNewerThanFilter.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss.fff";
            this.deNewerThanFilter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deNewerThanFilter.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deNewerThanFilter.Size = new System.Drawing.Size(207, 22);
            this.deNewerThanFilter.TabIndex = 25;
            // 
            // ceNewerThanFilter
            // 
            this.ceNewerThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceNewerThanFilter.Location = new System.Drawing.Point(0, 0);
            this.ceNewerThanFilter.MenuManager = this.barManager1;
            this.ceNewerThanFilter.Name = "ceNewerThanFilter";
            this.ceNewerThanFilter.Properties.Appearance.Options.UseImage = true;
            this.ceNewerThanFilter.Properties.AutoWidth = true;
            this.ceNewerThanFilter.Properties.Caption = "From:";
            this.ceNewerThanFilter.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceNewerThanFilter.Properties.ImageOptions.ImageChecked")));
            this.ceNewerThanFilter.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceNewerThanFilter.Properties.ImageOptions.ImageUnchecked")));
            this.ceNewerThanFilter.Size = new System.Drawing.Size(57, 22);
            this.ceNewerThanFilter.TabIndex = 28;
            // 
            // spltcProcessesModule
            // 
            this.spltcProcessesModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcProcessesModule.Location = new System.Drawing.Point(0, 0);
            this.spltcProcessesModule.Name = "spltcProcessesModule";
            // 
            // spltcProcessesModule.Panel1
            // 
            this.spltcProcessesModule.Panel1.Controls.Add(this.txtbModule);
            this.spltcProcessesModule.Panel1.Controls.Add(this.ceModulesProcess);
            this.spltcProcessesModule.Panel1.Controls.Add(this.sbtnIncludeModules);
            this.spltcProcessesModule.Panel1.Controls.Add(this.sbtnUndockPerProcess);
            this.spltcProcessesModule.Panel2Collapsed = true;
            this.spltcProcessesModule.Size = new System.Drawing.Size(962, 22);
            this.spltcProcessesModule.SplitterDistance = 574;
            this.spltcProcessesModule.TabIndex = 26;
            // 
            // txtbModule
            // 
            this.txtbModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbModule.Location = new System.Drawing.Point(229, 0);
            this.txtbModule.MenuManager = this.barManager1;
            this.txtbModule.Name = "txtbModule";
            this.txtbModule.Properties.NullText = "Use , to separate values. to exclude source or module prefix it with -. e.g: incl" +
    "udeA, -ExcludeB";
            this.txtbModule.Size = new System.Drawing.Size(529, 22);
            this.txtbModule.TabIndex = 26;
            // 
            // ceModulesProcess
            // 
            this.ceModulesProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceModulesProcess.Location = new System.Drawing.Point(0, 0);
            this.ceModulesProcess.MenuManager = this.barManager1;
            this.ceModulesProcess.Name = "ceModulesProcess";
            this.ceModulesProcess.Properties.AutoWidth = true;
            this.ceModulesProcess.Properties.Caption = "Include/Exclude Processes/Modules:";
            this.ceModulesProcess.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceModulesProcess.Properties.ImageOptions.ImageChecked")));
            this.ceModulesProcess.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceModulesProcess.Properties.ImageOptions.ImageUnchecked")));
            this.ceModulesProcess.Size = new System.Drawing.Size(229, 22);
            toolTipTitleItem1.Text = "Process / Module Property Filtering (include and exclude)";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Use , to separate values. to exclude source or module prefix it with -. e.g: incl" +
    "udeA, -ExcludeB";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.ceModulesProcess.SuperTip = superToolTip1;
            this.ceModulesProcess.TabIndex = 27;
            this.ceModulesProcess.ToolTip = "Use , to separate values. to exclude source or module prefix it with -";
            // 
            // sbtnIncludeModules
            // 
            this.sbtnIncludeModules.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnIncludeModules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnIncludeModules.ImageOptions.Image")));
            this.sbtnIncludeModules.Location = new System.Drawing.Point(758, 0);
            this.sbtnIncludeModules.Name = "sbtnIncludeModules";
            this.sbtnIncludeModules.Size = new System.Drawing.Size(23, 22);
            this.sbtnIncludeModules.TabIndex = 24;
            this.sbtnIncludeModules.ToolTip = "Clear the text";
            this.sbtnIncludeModules.Click += new System.EventHandler(this.sbtnIncludeModules_Click);
            // 
            // sbtnUndockPerProcess
            // 
            this.sbtnUndockPerProcess.AutoSize = true;
            this.sbtnUndockPerProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnUndockPerProcess.Location = new System.Drawing.Point(781, 0);
            this.sbtnUndockPerProcess.Name = "sbtnUndockPerProcess";
            this.sbtnUndockPerProcess.Size = new System.Drawing.Size(181, 22);
            this.sbtnUndockPerProcess.TabIndex = 24;
            this.sbtnUndockPerProcess.Text = "Split view per Process/Module";
            this.sbtnUndockPerProcess.Visible = false;
            this.sbtnUndockPerProcess.Click += new System.EventHandler(this.sbtnUndockPerProcess_Click);
            // 
            // spltcSources
            // 
            this.spltcSources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcSources.Location = new System.Drawing.Point(2, 62);
            this.spltcSources.Name = "spltcSources";
            // 
            // spltcSources.Panel1
            // 
            this.spltcSources.Panel1.Controls.Add(this.txtbSource);
            this.spltcSources.Panel1.Controls.Add(this.ceSources);
            this.spltcSources.Panel1.Controls.Add(this.sbtnIncludeSources);
            this.spltcSources.Panel2Collapsed = true;
            this.spltcSources.Size = new System.Drawing.Size(1483, 24);
            this.spltcSources.SplitterDistance = 683;
            this.spltcSources.TabIndex = 25;
            // 
            // txtbSource
            // 
            this.txtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbSource.EditValue = "Use , to separate values. to exclude source or module prefix it with -. e.g: incl" +
    "udeA, includeB, -ExcludeC, -ExcludeD";
            this.txtbSource.Location = new System.Drawing.Point(166, 0);
            this.txtbSource.MenuManager = this.barManager1;
            this.txtbSource.Name = "txtbSource";
            this.txtbSource.Properties.NullText = "Use , to separate values. to exclude source or module prefix it with -. e.g: incl" +
    "udeA, includeB, -ExcludeC, -ExcludeD";
            this.txtbSource.Size = new System.Drawing.Size(1294, 22);
            this.txtbSource.TabIndex = 25;
            // 
            // ceSources
            // 
            this.ceSources.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceSources.Location = new System.Drawing.Point(0, 0);
            this.ceSources.MenuManager = this.barManager1;
            this.ceSources.Name = "ceSources";
            this.ceSources.Properties.AutoWidth = true;
            this.ceSources.Properties.Caption = "Include/Exclude Sources:";
            this.ceSources.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceSources.Properties.ImageOptions.ImageChecked")));
            this.ceSources.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceSources.Properties.ImageOptions.ImageUnchecked")));
            this.ceSources.Size = new System.Drawing.Size(166, 24);
            toolTipTitleItem2.Text = "Source Propery Filtering (include and exclude)";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Use , to separate values. to exclude source prefix it with -. e.g: includeA, incl" +
    "udeB, -ExcludeC, -ExcludeD";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.ceSources.SuperTip = superToolTip2;
            this.ceSources.TabIndex = 26;
            this.ceSources.ToolTip = "Use , to separate values. to exclude source or module prefix it with -";
            // 
            // sbtnIncludeSources
            // 
            this.sbtnIncludeSources.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnIncludeSources.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnIncludeSources.ImageOptions.Image")));
            this.sbtnIncludeSources.Location = new System.Drawing.Point(1460, 0);
            this.sbtnIncludeSources.Name = "sbtnIncludeSources";
            this.sbtnIncludeSources.Size = new System.Drawing.Size(23, 24);
            this.sbtnIncludeSources.TabIndex = 24;
            this.sbtnIncludeSources.ToolTip = "Clear the text";
            this.sbtnIncludeSources.Click += new System.EventHandler(this.sbtnIncludeSources_Click);
            // 
            // spltTextExclude
            // 
            this.spltTextExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltTextExclude.Location = new System.Drawing.Point(2, 33);
            this.spltTextExclude.Name = "spltTextExclude";
            // 
            // spltTextExclude.Panel1
            // 
            this.spltTextExclude.Panel1.Controls.Add(this.txtbExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.ceExcludeText);
            this.spltTextExclude.Panel1.Controls.Add(this.sbtnTextExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.sBtnMostCommon);
            this.spltTextExclude.Panel2Collapsed = true;
            this.spltTextExclude.Size = new System.Drawing.Size(1483, 24);
            this.spltTextExclude.SplitterDistance = 998;
            this.spltTextExclude.TabIndex = 24;
            // 
            // txtbExclude
            // 
            this.txtbExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbExclude.Location = new System.Drawing.Point(99, 0);
            this.txtbExclude.MenuManager = this.barManager1;
            this.txtbExclude.Name = "txtbExclude";
            this.txtbExclude.Properties.NullText = "Use & or + for AND operations. Use | for OR operations";
            this.txtbExclude.Size = new System.Drawing.Size(1241, 22);
            this.txtbExclude.TabIndex = 20;
            this.txtbExclude.EditValueChanged += new System.EventHandler(this.txtbExclude_EditValueChanged);
            // 
            // ceExcludeText
            // 
            this.ceExcludeText.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceExcludeText.Location = new System.Drawing.Point(0, 0);
            this.ceExcludeText.MenuManager = this.barManager1;
            this.ceExcludeText.Name = "ceExcludeText";
            this.ceExcludeText.Properties.AutoWidth = true;
            this.ceExcludeText.Properties.Caption = "Exclude Text:";
            this.ceExcludeText.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceExcludeText.Properties.ImageOptions.ImageChecked")));
            this.ceExcludeText.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceExcludeText.Properties.ImageOptions.ImageUnchecked")));
            this.ceExcludeText.Size = new System.Drawing.Size(99, 24);
            toolTipTitleItem3.Text = "Text Property Filtering (exclude)";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Use (&& or +) for AND operations. Use | for OR operations";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.ceExcludeText.SuperTip = superToolTip3;
            this.ceExcludeText.TabIndex = 23;
            // 
            // sbtnTextExclude
            // 
            this.sbtnTextExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnTextExclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnTextExclude.ImageOptions.Image")));
            this.sbtnTextExclude.Location = new System.Drawing.Point(1340, 0);
            this.sbtnTextExclude.Name = "sbtnTextExclude";
            this.sbtnTextExclude.Size = new System.Drawing.Size(23, 24);
            this.sbtnTextExclude.TabIndex = 20;
            this.sbtnTextExclude.ToolTip = "Clear the text";
            this.sbtnTextExclude.Click += new System.EventHandler(this.sbtnTextExclude_Click);
            // 
            // sBtnMostCommon
            // 
            this.sBtnMostCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnMostCommon.Location = new System.Drawing.Point(1363, 0);
            this.sBtnMostCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnMostCommon.Name = "sBtnMostCommon";
            this.sBtnMostCommon.Size = new System.Drawing.Size(120, 24);
            this.sBtnMostCommon.TabIndex = 8;
            this.sBtnMostCommon.Text = "Most Common";
            this.sBtnMostCommon.Click += new System.EventHandler(this.sBtnMostCommon_Click);
            // 
            // spltText
            // 
            this.spltText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltText.Location = new System.Drawing.Point(2, 5);
            this.spltText.Name = "spltText";
            // 
            // spltText.Panel1
            // 
            this.spltText.Panel1.Controls.Add(this.txtbInclude);
            this.spltText.Panel1.Controls.Add(this.ceIncludeText);
            this.spltText.Panel1.Controls.Add(this.sbtnTextInclude);
            this.spltText.Panel1.Controls.Add(this.sbtnPreDefinedFilters);
            this.spltText.Panel2Collapsed = true;
            this.spltText.Size = new System.Drawing.Size(1483, 23);
            this.spltText.SplitterDistance = 998;
            this.spltText.TabIndex = 22;
            // 
            // txtbInclude
            // 
            this.txtbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbInclude.Location = new System.Drawing.Point(97, 0);
            this.txtbInclude.MenuManager = this.barManager1;
            this.txtbInclude.Name = "txtbInclude";
            this.txtbInclude.Properties.NullText = "Use & or + for AND operations. Use | for OR operations";
            this.txtbInclude.Size = new System.Drawing.Size(1340, 22);
            this.txtbInclude.TabIndex = 19;
            this.txtbInclude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbInclude_KeyPress);
            // 
            // ceIncludeText
            // 
            this.ceIncludeText.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceIncludeText.Location = new System.Drawing.Point(0, 0);
            this.ceIncludeText.MenuManager = this.barManager1;
            this.ceIncludeText.Name = "ceIncludeText";
            this.ceIncludeText.Properties.Appearance.Options.UseImage = true;
            this.ceIncludeText.Properties.AutoWidth = true;
            this.ceIncludeText.Properties.Caption = "Include Text:";
            this.ceIncludeText.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("ceIncludeText.Properties.ImageOptions.ImageChecked")));
            this.ceIncludeText.Properties.ImageOptions.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("ceIncludeText.Properties.ImageOptions.ImageUnchecked")));
            this.ceIncludeText.Size = new System.Drawing.Size(97, 23);
            toolTipTitleItem4.Text = "Text Property Filtering";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Use (&& or +) for AND operations. Use | for OR operations";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.ceIncludeText.SuperTip = superToolTip4;
            this.ceIncludeText.TabIndex = 22;
            this.ceIncludeText.ToolTip = "Use & or + for AND operations. Use | for OR operations";
            this.ceIncludeText.ToolTipController = this.defaultToolTipController;
            // 
            // defaultToolTipController
            // 
            this.defaultToolTipController.Appearance.Options.UseBorderColor = true;
            // 
            // sbtnTextInclude
            // 
            this.sbtnTextInclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnTextInclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnTextInclude.ImageOptions.Image")));
            this.sbtnTextInclude.Location = new System.Drawing.Point(1437, 0);
            this.sbtnTextInclude.Name = "sbtnTextInclude";
            this.sbtnTextInclude.Size = new System.Drawing.Size(23, 23);
            this.sbtnTextInclude.TabIndex = 20;
            this.sbtnTextInclude.ToolTip = "Clear the text";
            this.sbtnTextInclude.Click += new System.EventHandler(this.sbtnTextInclude_Click);
            // 
            // sbtnPreDefinedFilters
            // 
            this.sbtnPreDefinedFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnPreDefinedFilters.ImageOptions.Image = global::Analogy.Properties.Resources.SingleMasterFilter_16x16;
            this.sbtnPreDefinedFilters.Location = new System.Drawing.Point(1460, 0);
            this.sbtnPreDefinedFilters.Name = "sbtnPreDefinedFilters";
            this.sbtnPreDefinedFilters.Size = new System.Drawing.Size(23, 23);
            this.sbtnPreDefinedFilters.TabIndex = 21;
            this.sbtnPreDefinedFilters.ToolTip = "Pre-defined filters";
            this.sbtnPreDefinedFilters.Click += new System.EventHandler(this.sbtnPreDefinedFilters_Click);
            // 
            // chkLstLogLevel
            // 
            this.chkLstLogLevel.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.chkLstLogLevel.CheckOnClick = true;
            this.chkLstLogLevel.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkLstLogLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkLstLogLevel.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Trace"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Error + Critical"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Warning"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Debug"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Verbose")});
            this.chkLstLogLevel.Location = new System.Drawing.Point(1704, 2);
            this.chkLstLogLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLstLogLevel.Name = "chkLstLogLevel";
            this.chkLstLogLevel.Size = new System.Drawing.Size(141, 163);
            this.chkLstLogLevel.TabIndex = 22;
            this.chkLstLogLevel.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkLstLogLevel_ItemCheck);
            this.chkLstLogLevel.SelectedIndexChanged += new System.EventHandler(this.chkLstLogLevel_SelectedIndexChanged);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtContent.Location = new System.Drawing.Point(0, 29);
            this.rtxtContent.MenuManager = this.barManager1;
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(1843, 112);
            this.rtxtContent.TabIndex = 2;
            // 
            // gridControlBookmarkedMessages
            // 
            this.gridControlBookmarkedMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBookmarkedMessages.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlBookmarkedMessages.Location = new System.Drawing.Point(0, 38);
            this.gridControlBookmarkedMessages.MainView = this.gridViewBookmarkedMessages;
            this.gridControlBookmarkedMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlBookmarkedMessages.Name = "gridControlBookmarkedMessages";
            this.gridControlBookmarkedMessages.Size = new System.Drawing.Size(1843, 103);
            this.gridControlBookmarkedMessages.TabIndex = 3;
            this.gridControlBookmarkedMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBookmarkedMessages});
            this.gridControlBookmarkedMessages.DoubleClick += new System.EventHandler(this.gridControlBookmarkedMessages_DoubleClick);
            // 
            // gridViewBookmarkedMessages
            // 
            this.gridViewBookmarkedMessages.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewBookmarkedMessages.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewBookmarkedMessages.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewBookmarkedMessages.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridViewBookmarkedMessages.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridViewBookmarkedMessages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewBookmarkedMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBookmarkDataSource,
            this.gridColumnBookmarkDate,
            this.gridColumnBookmarkText,
            this.gridColumnBookmarkSource,
            this.gridColumnBookmarkLevel,
            this.gridColumnBookmarkClass,
            this.gridColumnBookmarkCategory,
            this.gridColumnBookmarkUser,
            this.gridColumnBookmarkModule,
            this.gridColumnBookmarkAudit,
            this.gridColumnBookmarkObject,
            this.gridColumnBookmarkProcessID,
            this.gridColumnBookmarkMachineName});
            this.gridViewBookmarkedMessages.DetailHeight = 431;
            this.gridViewBookmarkedMessages.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewBookmarkedMessages.GridControl = this.gridControlBookmarkedMessages;
            this.gridViewBookmarkedMessages.Images = this.imageList;
            this.gridViewBookmarkedMessages.IndicatorWidth = 24;
            this.gridViewBookmarkedMessages.Name = "gridViewBookmarkedMessages";
            this.gridViewBookmarkedMessages.OptionsBehavior.Editable = false;
            this.gridViewBookmarkedMessages.OptionsCustomization.AllowGroup = false;
            this.gridViewBookmarkedMessages.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewBookmarkedMessages.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewBookmarkedMessages.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridViewBookmarkedMessages.OptionsLayout.Columns.StoreAppearance = true;
            this.gridViewBookmarkedMessages.OptionsLayout.StoreAllOptions = true;
            this.gridViewBookmarkedMessages.OptionsLayout.StoreAppearance = true;
            this.gridViewBookmarkedMessages.OptionsLayout.StoreFormatRules = true;
            this.gridViewBookmarkedMessages.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBookmarkedMessages.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridViewBookmarkedMessages.OptionsView.ColumnAutoWidth = false;
            this.gridViewBookmarkedMessages.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewBookmarkedMessages.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBookmarkedMessages.OptionsView.RowAutoHeight = true;
            this.gridViewBookmarkedMessages.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBookmarkedMessages.OptionsView.ShowGroupPanel = false;
            this.gridViewBookmarkedMessages.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.LogGrid_CustomDrawRowIndicator);
            // 
            // gridColumnBookmarkDataSource
            // 
            this.gridColumnBookmarkDataSource.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkDataSource.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkDataSource.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkDataSource.Caption = "Data Source";
            this.gridColumnBookmarkDataSource.FieldName = "DataProvider";
            this.gridColumnBookmarkDataSource.MinWidth = 24;
            this.gridColumnBookmarkDataSource.Name = "gridColumnBookmarkDataSource";
            this.gridColumnBookmarkDataSource.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkDataSource.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkDataSource.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkDataSource.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkDataSource.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkDataSource.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkDataSource.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkDataSource.Visible = true;
            this.gridColumnBookmarkDataSource.VisibleIndex = 0;
            this.gridColumnBookmarkDataSource.Width = 175;
            // 
            // gridColumnBookmarkDate
            // 
            this.gridColumnBookmarkDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkDate.Caption = "Date";
            this.gridColumnBookmarkDate.DisplayFormat.FormatString = "yyyy.MM.dd HH:mm:ss.ff";
            this.gridColumnBookmarkDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnBookmarkDate.FieldName = "Date";
            this.gridColumnBookmarkDate.MinWidth = 24;
            this.gridColumnBookmarkDate.Name = "gridColumnBookmarkDate";
            this.gridColumnBookmarkDate.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkDate.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkDate.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBookmarkDate.Visible = true;
            this.gridColumnBookmarkDate.VisibleIndex = 1;
            this.gridColumnBookmarkDate.Width = 164;
            // 
            // gridColumnBookmarkText
            // 
            this.gridColumnBookmarkText.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkText.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkText.Caption = "Text";
            this.gridColumnBookmarkText.FieldName = "Text";
            this.gridColumnBookmarkText.MinWidth = 24;
            this.gridColumnBookmarkText.Name = "gridColumnBookmarkText";
            this.gridColumnBookmarkText.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkText.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkText.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkText.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkText.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkText.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkText.OptionsFilter.AllowFilter = false;
            this.gridColumnBookmarkText.Visible = true;
            this.gridColumnBookmarkText.VisibleIndex = 2;
            this.gridColumnBookmarkText.Width = 290;
            // 
            // gridColumnBookmarkSource
            // 
            this.gridColumnBookmarkSource.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkSource.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkSource.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkSource.Caption = "Source";
            this.gridColumnBookmarkSource.FieldName = "Source";
            this.gridColumnBookmarkSource.MinWidth = 24;
            this.gridColumnBookmarkSource.Name = "gridColumnBookmarkSource";
            this.gridColumnBookmarkSource.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkSource.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkSource.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkSource.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkSource.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkSource.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkSource.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkSource.Visible = true;
            this.gridColumnBookmarkSource.VisibleIndex = 5;
            this.gridColumnBookmarkSource.Width = 234;
            // 
            // gridColumnBookmarkLevel
            // 
            this.gridColumnBookmarkLevel.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkLevel.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkLevel.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkLevel.Caption = "Level";
            this.gridColumnBookmarkLevel.FieldName = "Level";
            this.gridColumnBookmarkLevel.MinWidth = 24;
            this.gridColumnBookmarkLevel.Name = "gridColumnBookmarkLevel";
            this.gridColumnBookmarkLevel.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkLevel.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkLevel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkLevel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkLevel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkLevel.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkLevel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkLevel.Visible = true;
            this.gridColumnBookmarkLevel.VisibleIndex = 6;
            this.gridColumnBookmarkLevel.Width = 115;
            // 
            // gridColumnBookmarkClass
            // 
            this.gridColumnBookmarkClass.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkClass.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkClass.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkClass.Caption = "Class";
            this.gridColumnBookmarkClass.FieldName = "Class";
            this.gridColumnBookmarkClass.MinWidth = 24;
            this.gridColumnBookmarkClass.Name = "gridColumnBookmarkClass";
            this.gridColumnBookmarkClass.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkClass.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkClass.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkClass.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkClass.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkClass.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkClass.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkClass.Visible = true;
            this.gridColumnBookmarkClass.VisibleIndex = 7;
            this.gridColumnBookmarkClass.Width = 115;
            // 
            // gridColumnBookmarkCategory
            // 
            this.gridColumnBookmarkCategory.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkCategory.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkCategory.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkCategory.Caption = "Category";
            this.gridColumnBookmarkCategory.FieldName = "Category";
            this.gridColumnBookmarkCategory.MinWidth = 24;
            this.gridColumnBookmarkCategory.Name = "gridColumnBookmarkCategory";
            this.gridColumnBookmarkCategory.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkCategory.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkCategory.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkCategory.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkCategory.Visible = true;
            this.gridColumnBookmarkCategory.VisibleIndex = 8;
            this.gridColumnBookmarkCategory.Width = 115;
            // 
            // gridColumnBookmarkUser
            // 
            this.gridColumnBookmarkUser.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkUser.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkUser.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkUser.Caption = "User";
            this.gridColumnBookmarkUser.FieldName = "User";
            this.gridColumnBookmarkUser.MinWidth = 24;
            this.gridColumnBookmarkUser.Name = "gridColumnBookmarkUser";
            this.gridColumnBookmarkUser.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkUser.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkUser.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkUser.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkUser.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkUser.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkUser.Visible = true;
            this.gridColumnBookmarkUser.VisibleIndex = 9;
            this.gridColumnBookmarkUser.Width = 115;
            // 
            // gridColumnBookmarkModule
            // 
            this.gridColumnBookmarkModule.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkModule.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkModule.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkModule.Caption = "Module";
            this.gridColumnBookmarkModule.FieldName = "Module";
            this.gridColumnBookmarkModule.MinWidth = 24;
            this.gridColumnBookmarkModule.Name = "gridColumnBookmarkModule";
            this.gridColumnBookmarkModule.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkModule.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkModule.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkModule.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkModule.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkModule.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkModule.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkModule.Visible = true;
            this.gridColumnBookmarkModule.VisibleIndex = 10;
            this.gridColumnBookmarkModule.Width = 115;
            // 
            // gridColumnBookmarkAudit
            // 
            this.gridColumnBookmarkAudit.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkAudit.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkAudit.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkAudit.Caption = "Audit";
            this.gridColumnBookmarkAudit.FieldName = "Audit";
            this.gridColumnBookmarkAudit.MinWidth = 24;
            this.gridColumnBookmarkAudit.Name = "gridColumnBookmarkAudit";
            this.gridColumnBookmarkAudit.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkAudit.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkAudit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkAudit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkAudit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkAudit.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkAudit.Visible = true;
            this.gridColumnBookmarkAudit.VisibleIndex = 3;
            this.gridColumnBookmarkAudit.Width = 115;
            // 
            // gridColumnBookmarkObject
            // 
            this.gridColumnBookmarkObject.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkObject.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkObject.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkObject.Caption = "Object";
            this.gridColumnBookmarkObject.MinWidth = 24;
            this.gridColumnBookmarkObject.Name = "gridColumnBookmarkObject";
            this.gridColumnBookmarkObject.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkObject.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkObject.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkObject.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkObject.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkObject.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkObject.OptionsColumn.ShowCaption = false;
            this.gridColumnBookmarkObject.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColumnBookmarkObject.Width = 87;
            // 
            // gridColumnBookmarkProcessID
            // 
            this.gridColumnBookmarkProcessID.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBookmarkProcessID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumnBookmarkProcessID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumnBookmarkProcessID.Caption = "ProcessID";
            this.gridColumnBookmarkProcessID.FieldName = "ProcessID";
            this.gridColumnBookmarkProcessID.MinWidth = 24;
            this.gridColumnBookmarkProcessID.Name = "gridColumnBookmarkProcessID";
            this.gridColumnBookmarkProcessID.OptionsColumn.AllowEdit = false;
            this.gridColumnBookmarkProcessID.OptionsColumn.AllowFocus = false;
            this.gridColumnBookmarkProcessID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkProcessID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnBookmarkProcessID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnBookmarkProcessID.OptionsColumn.ReadOnly = true;
            this.gridColumnBookmarkProcessID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.gridColumnBookmarkProcessID.Visible = true;
            this.gridColumnBookmarkProcessID.VisibleIndex = 4;
            this.gridColumnBookmarkProcessID.Width = 115;
            // 
            // gridColumnBookmarkMachineName
            // 
            this.gridColumnBookmarkMachineName.Caption = "Machine Name";
            this.gridColumnBookmarkMachineName.FieldName = "MachineName";
            this.gridColumnBookmarkMachineName.MinWidth = 25;
            this.gridColumnBookmarkMachineName.Name = "gridColumnBookmarkMachineName";
            this.gridColumnBookmarkMachineName.Visible = true;
            this.gridColumnBookmarkMachineName.VisibleIndex = 11;
            this.gridColumnBookmarkMachineName.Width = 94;
            // 
            // imageListBottom
            // 
            this.imageListBottom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBottom.ImageStream")));
            this.imageListBottom.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBottom.Images.SetKeyName(0, "Info_16x16.png");
            this.imageListBottom.Images.SetKeyName(1, "RichEditBookmark_16x16.png");
            this.imageListBottom.Images.SetKeyName(2, "RichEditBookmark_32x32.png");
            // 
            // tmrNewData
            // 
            this.tmrNewData.Enabled = true;
            this.tmrNewData.Interval = 1000;
            this.tmrNewData.Tick += new System.EventHandler(this.tmrNewData_Tick);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.xtcFiltersLeft);
            this.pnlFilters.Controls.Add(this.chkLstLogLevel);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 39);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1847, 167);
            this.pnlFilters.TabIndex = 6;
            // 
            // xtcFiltersLeft
            // 
            this.xtcFiltersLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcFiltersLeft.Location = new System.Drawing.Point(2, 2);
            this.xtcFiltersLeft.Name = "xtcFiltersLeft";
            this.xtcFiltersLeft.SelectedTabPage = this.xtpFilters;
            this.xtcFiltersLeft.Size = new System.Drawing.Size(1702, 163);
            this.xtcFiltersLeft.TabIndex = 28;
            this.xtcFiltersLeft.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpFilters,
            this.xtpSearchFilterPanel});
            // 
            // xtpFilters
            // 
            this.xtpFilters.Controls.Add(this.pnlLeftFilters);
            this.xtpFilters.Controls.Add(this.xtcFilters);
            this.xtpFilters.Name = "xtpFilters";
            this.xtpFilters.Size = new System.Drawing.Size(1695, 129);
            this.xtpFilters.Text = "Filters";
            // 
            // pnlLeftFilters
            // 
            this.pnlLeftFilters.Controls.Add(this.pnlModulesAndDates);
            this.pnlLeftFilters.Controls.Add(this.spltcSources);
            this.pnlLeftFilters.Controls.Add(this.spltTextExclude);
            this.pnlLeftFilters.Controls.Add(this.spltText);
            this.pnlLeftFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftFilters.Name = "pnlLeftFilters";
            this.pnlLeftFilters.Size = new System.Drawing.Size(1487, 129);
            this.pnlLeftFilters.TabIndex = 27;
            // 
            // pnlModulesAndDates
            // 
            this.pnlModulesAndDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModulesAndDates.Controls.Add(this.spltcProcessesModule);
            this.pnlModulesAndDates.Controls.Add(this.spltcDateFiltering);
            this.pnlModulesAndDates.Location = new System.Drawing.Point(2, 91);
            this.pnlModulesAndDates.Name = "pnlModulesAndDates";
            this.pnlModulesAndDates.Size = new System.Drawing.Size(1483, 22);
            this.pnlModulesAndDates.TabIndex = 28;
            // 
            // xtcFilters
            // 
            this.xtcFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.xtcFilters.Location = new System.Drawing.Point(1487, 0);
            this.xtcFilters.Name = "xtcFilters";
            this.xtcFilters.SelectedTabPage = this.xtpFiltersIncludes;
            this.xtcFilters.Size = new System.Drawing.Size(208, 129);
            this.xtcFilters.TabIndex = 29;
            this.xtcFilters.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpFiltersIncludes,
            this.xtpFiltersExclude});
            // 
            // xtpFiltersIncludes
            // 
            this.xtpFiltersIncludes.Controls.Add(this.clbInclude);
            this.xtpFiltersIncludes.Name = "xtpFiltersIncludes";
            this.xtpFiltersIncludes.Size = new System.Drawing.Size(201, 95);
            this.xtpFiltersIncludes.Text = "Includes";
            // 
            // clbInclude
            // 
            this.clbInclude.CheckOnClick = true;
            this.clbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbInclude.Location = new System.Drawing.Point(0, 0);
            this.clbInclude.Name = "clbInclude";
            this.clbInclude.Size = new System.Drawing.Size(201, 95);
            this.clbInclude.TabIndex = 21;
            // 
            // xtpFiltersExclude
            // 
            this.xtpFiltersExclude.Controls.Add(this.clbExclude);
            this.xtpFiltersExclude.Name = "xtpFiltersExclude";
            this.xtpFiltersExclude.Size = new System.Drawing.Size(201, 95);
            this.xtpFiltersExclude.Text = "Excludes";
            // 
            // clbExclude
            // 
            this.clbExclude.CheckOnClick = true;
            this.clbExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbExclude.Location = new System.Drawing.Point(0, 0);
            this.clbExclude.Name = "clbExclude";
            this.clbExclude.Size = new System.Drawing.Size(201, 95);
            this.clbExclude.TabIndex = 22;
            // 
            // xtpSearchFilterPanel
            // 
            this.xtpSearchFilterPanel.Controls.Add(this.rgSearchMode);
            this.xtpSearchFilterPanel.Controls.Add(this.labelControl1);
            this.xtpSearchFilterPanel.Controls.Add(this.sbtnToggleSearchFilter);
            this.xtpSearchFilterPanel.Name = "xtpSearchFilterPanel";
            this.xtpSearchFilterPanel.Size = new System.Drawing.Size(1695, 129);
            this.xtpSearchFilterPanel.Text = "Search/Filter Panel";
            // 
            // rgSearchMode
            // 
            this.rgSearchMode.AutoSizeInLayoutControl = true;
            this.rgSearchMode.Location = new System.Drawing.Point(398, 3);
            this.rgSearchMode.MenuManager = this.barManager1;
            this.rgSearchMode.Name = "rgSearchMode";
            this.rgSearchMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Search Mode (CTRL + F)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Filter Mode (ALT + F)")});
            this.rgSearchMode.Size = new System.Drawing.Size(250, 94);
            this.rgSearchMode.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(309, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Text Mode:";
            // 
            // sbtnToggleSearchFilter
            // 
            this.sbtnToggleSearchFilter.Location = new System.Drawing.Point(3, 3);
            this.sbtnToggleSearchFilter.Name = "sbtnToggleSearchFilter";
            this.sbtnToggleSearchFilter.Size = new System.Drawing.Size(294, 28);
            this.sbtnToggleSearchFilter.TabIndex = 0;
            this.sbtnToggleSearchFilter.Text = "Toggle Search/Filter Panel On/Off";
            // 
            // contextMenuStripFilters
            // 
            this.contextMenuStripFilters.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFilters.Name = "contextMenuStripFilters";
            this.contextMenuStripFilters.Size = new System.Drawing.Size(61, 4);
            // 
            // LogGridPopupMenu
            // 
            this.LogGridPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnClearLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDiffTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDatetiemFilterFrom),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDatetiemFilterTo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBookmarkNonPersist),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBookmarkPersist),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiJsonViewer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCopyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCopyAllMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNoteToMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIncludeMessage, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIncludeSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIncludeModule),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIncludeColumnHeaderFilter),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExcludeMessage, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExcludeSource),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExcludeModule),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSaveLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIncreaseFontSize),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDecreaseFontSize)});
            this.LogGridPopupMenu.Manager = this.barManager1;
            this.LogGridPopupMenu.Name = "LogGridPopupMenu";
            // 
            // alertControl1
            // 
            this.alertControl1.ShowPinButton = false;
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.barManager1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1});
            this.tabbedView1.Orientation = System.Windows.Forms.Orientation.Vertical;
            dockingContainer1.Element = this.documentGroup1;
            dockingContainer1.Length.UnitValue = 1.4189383070301291D;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1});
            this.tabbedView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelLogs,
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanelLogs
            // 
            this.dockPanelLogs.Controls.Add(this.dockPanel2_Container);
            this.dockPanelLogs.DockedAsTabbedDocument = true;
            this.dockPanelLogs.ID = new System.Guid("3e67bfab-0a04-4919-82f8-b34cb75b93ba");
            this.dockPanelLogs.Name = "dockPanelLogs";
            this.dockPanelLogs.Options.ShowCloseButton = false;
            this.dockPanelLogs.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelLogs.Text = "Logs";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.panel1);
            this.dockPanel2_Container.Controls.Add(this.gridControl);
            this.dockPanel2_Container.Controls.Add(this.pnlFilters);
            this.dockPanel2_Container.Controls.Add(this.bdcTopFiltering);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1847, 470);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanelMessageInfo;
            this.panelContainer1.Controls.Add(this.dockPanelMessageInfo);
            this.panelContainer1.Controls.Add(this.dockPanelBookmarks);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatSize = new System.Drawing.Size(428, 200);
            this.panelContainer1.ID = new System.Guid("ac1a6167-81e4-42f6-b999-c394cc58516b");
            this.panelContainer1.Location = new System.Drawing.Point(0, 523);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 204);
            this.panelContainer1.Size = new System.Drawing.Size(1853, 204);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanelMessageInfo
            // 
            this.dockPanelMessageInfo.Controls.Add(this.controlContainer1);
            this.dockPanelMessageInfo.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanelMessageInfo.FloatSize = new System.Drawing.Size(428, 200);
            this.dockPanelMessageInfo.ID = new System.Guid("476f3ac6-a99d-4213-81ee-71700997df5e");
            this.dockPanelMessageInfo.Location = new System.Drawing.Point(5, 27);
            this.dockPanelMessageInfo.Name = "dockPanelMessageInfo";
            this.dockPanelMessageInfo.Options.ShowCloseButton = false;
            this.dockPanelMessageInfo.OriginalSize = new System.Drawing.Size(200, 204);
            this.dockPanelMessageInfo.Size = new System.Drawing.Size(1843, 141);
            this.dockPanelMessageInfo.Text = "Message Info";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.rtxtContent);
            this.controlContainer1.Controls.Add(this.sbarMessageInfo);
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(1843, 141);
            this.controlContainer1.TabIndex = 0;
            // 
            // dockPanelBookmarks
            // 
            this.dockPanelBookmarks.Controls.Add(this.dockPanel1_Container);
            this.dockPanelBookmarks.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanelBookmarks.FloatSize = new System.Drawing.Size(699, 204);
            this.dockPanelBookmarks.ID = new System.Guid("4840b804-35ee-475a-bd26-b12c47dc3c17");
            this.dockPanelBookmarks.Location = new System.Drawing.Point(5, 27);
            this.dockPanelBookmarks.Name = "dockPanelBookmarks";
            this.dockPanelBookmarks.OriginalSize = new System.Drawing.Size(200, 204);
            this.dockPanelBookmarks.Size = new System.Drawing.Size(1843, 141);
            this.dockPanelBookmarks.Text = "Bookmarks";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gridControlBookmarkedMessages);
            this.dockPanel1_Container.Controls.Add(this.sbarBookmarks);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1843, 141);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // UCLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCLogs";
            this.Size = new System.Drawing.Size(1853, 759);
            this.Load += new System.EventHandler(this.UCLogs_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbHighlight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.pnlButtonsHighlight.ResumeLayout(false);
            this.spltcDateFiltering.Panel1.ResumeLayout(false);
            this.spltcDateFiltering.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).EndInit();
            this.spltcDateFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deOlderThanFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deOlderThanFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceOlderThanFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNewerThanFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNewerThanFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNewerThanFilter.Properties)).EndInit();
            this.spltcProcessesModule.Panel1.ResumeLayout(false);
            this.spltcProcessesModule.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).EndInit();
            this.spltcProcessesModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceModulesProcess.Properties)).EndInit();
            this.spltcSources.Panel1.ResumeLayout(false);
            this.spltcSources.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).EndInit();
            this.spltcSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSources.Properties)).EndInit();
            this.spltTextExclude.Panel1.ResumeLayout(false);
            this.spltTextExclude.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).EndInit();
            this.spltTextExclude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbExclude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExcludeText.Properties)).EndInit();
            this.spltText.Panel1.ResumeLayout(false);
            this.spltText.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).EndInit();
            this.spltText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbInclude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIncludeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLstLogLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBookmarkedMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBookmarkedMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilters)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcFiltersLeft)).EndInit();
            this.xtcFiltersLeft.ResumeLayout(false);
            this.xtpFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftFilters)).EndInit();
            this.pnlLeftFilters.ResumeLayout(false);
            this.pnlModulesAndDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcFilters)).EndInit();
            this.xtcFilters.ResumeLayout(false);
            this.xtpFiltersIncludes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbInclude)).EndInit();
            this.xtpFiltersExclude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbExclude)).EndInit();
            this.xtpSearchFilterPanel.ResumeLayout(false);
            this.xtpSearchFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgSearchMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGridPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelLogs.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel2_Container.PerformLayout();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanelMessageInfo.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            this.dockPanelBookmarks.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private GridView logGrid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnClass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModule;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObject;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProcessID;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer tmrNewData;
        private DevExpress.XtraGrid.GridControl gridControlBookmarkedMessages;
        private GridView gridViewBookmarkedMessages;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkClass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkModule;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkAudit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkObject;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkProcessID;
        private System.Windows.Forms.ImageList imageListBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbHighlight;
        private System.Windows.Forms.Panel pnlButtonsHighlight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTimeDiff;
        private DevExpress.XtraBars.StandaloneBarDockControl bdcTopFiltering;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barTopFiltering;
        private DevExpress.XtraBars.Bar BbarMainMenu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToggleSwitchItem btswitchMessageDetails;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveLog;
        private DevExpress.XtraBars.BarButtonItem bBtnImport;
        private DevExpress.XtraBars.BarButtonItem bBtnClearLog;
        internal DevExpress.XtraBars.BarToggleSwitchItem btswitchRefreshLog;
        private DevExpress.XtraEditors.SimpleButton sBtnMostCommon;
        private DevExpress.XtraEditors.CheckedListBoxControl chkLstLogLevel;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem bBtnExpand;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar barMessage;
        private DevExpress.XtraBars.BarButtonItem bBtnButtomExpand;
        private DevExpress.XtraBars.BarButtonItem bBtnCopyButtom;
        private DevExpress.XtraBars.BarToggleSwitchItem btSwitchExpandButtomMessage;
        private DevExpress.XtraBars.Bar barBookmark;
        private DevExpress.XtraBars.BarButtonItem bBtnopyBookmarked;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bBtnGoToMessage;
        private DevExpress.XtraBars.BarButtonItem bBtnRemoveBoomark;
        private DevExpress.XtraBars.BarButtonItem bBtnCopyAllBookmarks;
        private DevExpress.XtraEditors.SimpleButton sbtnPageFirst;
        private DevExpress.XtraEditors.LabelControl lblPageNumber;
        private DevExpress.XtraEditors.SimpleButton sBtnPageNext;
        private DevExpress.XtraEditors.SimpleButton sBtnLastPage;
        private DevExpress.XtraEditors.SimpleButton sbtnPagePrevious;
        private DevExpress.XtraBars.BarSubItem bSMExports;
        private DevExpress.XtraBars.BarButtonItem bBtnExportExcel;
        private DevExpress.XtraBars.BarButtonItem bBtnExportCSV;
        private DevExpress.XtraBars.BarButtonItem bBtnExportHtml;
        internal DevExpress.XtraBars.BarToggleSwitchItem btsAutoScrollToBottom;
        private DevExpress.XtraBars.BarButtonItem bBtnUndockView;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveEntireLog;
        private DevExpress.XtraBars.BarButtonItem bBtnDataVisualizer;
        private DevExpress.XtraBars.BarButtonItem bbiScreenshot;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThread;
        private DevExpress.XtraBars.BarButtonItem bbtnSaveViewAgnostic;
        private DevExpress.XtraBars.BarSubItem barSubItemSaveLog;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveEntireInAnalogy;
        private DevExpress.XtraEditors.TextEdit txtbInclude;
        private DevExpress.XtraEditors.TextEdit txtbExclude;
        private DevExpress.XtraEditors.TextEdit txtbHighlight;
        private DevExpress.XtraEditors.MemoEdit rtxtContent;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bBtnUndockViewPerProcess;
        private System.Windows.Forms.SplitContainer spltText;
        private DevExpress.XtraEditors.SimpleButton sbtnTextInclude;
        private System.Windows.Forms.SplitContainer spltTextExclude;
        private DevExpress.XtraEditors.SimpleButton sbtnTextExclude;
        private System.Windows.Forms.SplitContainer spltcSources;
        private DevExpress.XtraEditors.TextEdit txtbSource;
        private DevExpress.XtraEditors.SimpleButton sbtnIncludeSources;
        private System.Windows.Forms.SplitContainer spltcProcessesModule;
        private DevExpress.XtraEditors.TextEdit txtbModule;
        private DevExpress.XtraEditors.SimpleButton sbtnIncludeModules;
        private DevExpress.XtraEditors.SimpleButton sbtnUndockPerProcess;
        private System.Windows.Forms.SplitContainer spltcDateFiltering;
        private DevExpress.XtraEditors.DateEdit deNewerThanFilter;
        private DevExpress.XtraEditors.DateEdit deOlderThanFilter;
        private DevExpress.XtraEditors.SimpleButton sbtnMoreHighlight;
        private DevExpress.XtraEditors.SimpleButton sbtnPreDefinedFilters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFilters;
        private DevExpress.XtraBars.Bar barGroup;
        private DevExpress.XtraBars.BarButtonItem bBtnShare;
        private DevExpress.XtraBars.BarButtonItem bBtnFullGrid;
        private DevExpress.XtraBars.BarButtonItem bbtnReload;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMachineName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBookmarkMachineName;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveCurrentSelectionCustomFormat;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveCurrentSelectionAnalogyFormat;
        private DevExpress.XtraBars.BarButtonItem bBtnUndockSelection;
        private DevExpress.XtraEditors.CheckEdit ceExcludeText;
        private DevExpress.XtraEditors.CheckEdit ceIncludeText;
        private DevExpress.XtraEditors.CheckEdit ceSources;
        private DevExpress.XtraEditors.CheckEdit ceModulesProcess;
        private DevExpress.XtraEditors.CheckEdit ceOlderThanFilter;
        private DevExpress.XtraEditors.CheckEdit ceNewerThanFilter;
        private DevExpress.XtraEditors.PanelControl pnlLeftFilters;
        private DevExpress.XtraEditors.CheckedListBoxControl clbInclude;
        private DevExpress.XtraEditors.CheckedListBoxControl clbExclude;
        private System.Windows.Forms.Panel pnlModulesAndDates;
        private DevExpress.XtraEditors.PanelControl pnlFilters;
        private DevExpress.XtraTab.XtraTabControl xtcFilters;
        private DevExpress.XtraTab.XtraTabPage xtpFiltersIncludes;
        private DevExpress.XtraTab.XtraTabPage xtpFiltersExclude;
        private DevExpress.XtraTab.XtraTabControl xtcFiltersLeft;
        private DevExpress.XtraTab.XtraTabPage xtpSearchFilterPanel;
        private DevExpress.XtraTab.XtraTabPage xtpFilters;
        private DevExpress.XtraEditors.SimpleButton sbtnToggleSearchFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rgSearchMode;
        private DevExpress.XtraBars.PopupMenu LogGridPopupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiDiffTime;
        private DevExpress.XtraBars.BarButtonItem bbiDatetiemFilterFrom;
        private DevExpress.XtraBars.BarButtonItem bbiDatetiemFilterTo;
        private DevExpress.XtraBars.BarButtonItem bbiBookmarkNonPersist;
        private DevExpress.XtraBars.BarButtonItem bbiBookmarkPersist;
        private DevExpress.XtraBars.BarButtonItem bbiCopyMessage;
        private DevExpress.XtraBars.BarButtonItem bbiCopyAllMessages;
        private DevExpress.XtraBars.BarButtonItem bbiAddNoteToMessage;
        private DevExpress.XtraBars.BarButtonItem bbiIncludeMessage;
        private DevExpress.XtraBars.BarButtonItem bbiIncludeColumnHeaderFilter;
        private DevExpress.XtraBars.BarButtonItem bbiExcludeMessage;
        private DevExpress.XtraBars.BarButtonItem bbiExcludeSource;
        private DevExpress.XtraBars.BarButtonItem bbiExcludeModule;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiIncreaseFontSize;
        private DevExpress.XtraBars.BarButtonItem bbiDecreaseFontSize;
        private DevExpress.XtraBars.BarButtonItem bbiIncludeSource;
        private DevExpress.XtraBars.BarButtonItem bbiIncludeModule;
        private DevExpress.XtraBars.BarButtonItem bbiSaveBookmarks;
        private DevExpress.XtraBars.BarButtonItem bbiJsonViewer;
        private DevExpress.Utils.ToolTipController defaultToolTipController;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelLogs;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelBookmarks;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarButtonItem bbtnCancel;
        private DevExpress.XtraBars.BarStaticItem bstaticTotalMessages;
        private DevExpress.XtraBars.BarStaticItem bstaticAlert;
        private DevExpress.XtraBars.BarEditItem bprogressBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMessageInfo;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.StandaloneBarDockControl sbarMessageInfo;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.StandaloneBarDockControl sbarBookmarks;
    }
}
