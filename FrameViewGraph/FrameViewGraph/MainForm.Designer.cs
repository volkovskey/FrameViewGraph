namespace FrameViewGraph
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.File_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Graph = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph_Plot = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GraphType = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GraphSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphSettings_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter_No = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter_Low = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter_Middle = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter_High = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphSettings_Apprearance = new System.Windows.Forms.ToolStripMenuItem();
            this.Apprearance_Legend = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphSettings_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_MainColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_AvgFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_ModeFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_MedianFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_10low = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_1low = new System.Windows.Forms.ToolStripMenuItem();
            this.MainColumns_01low = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_AdditionalColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalColumns_CPUTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalColumns_GPUTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalColumns_CPUPower = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalColumns_GPUPower = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_DataSource = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSource_API = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSource_Display = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettings_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_RU = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettings_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.Theme_Lite = new System.Windows.Forms.ToolStripMenuItem();
            this.Theme_Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.StatusMenu = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileList = new System.Windows.Forms.CheckedListBox();
            this.PlotView = new OxyPlot.WindowsForms.PlotView();
            this.MainMenu.SuspendLayout();
            this.StatusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Graph,
            this.Menu_GraphType,
            this.Menu_GraphSettings,
            this.Menu_AppSettings,
            this.Menu_About});
            this.MainMenu.Name = "MainMenu";
            // 
            // Menu_File
            // 
            resources.ApplyResources(this.Menu_File, "Menu_File");
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_OpenFile});
            this.Menu_File.Name = "Menu_File";
            // 
            // File_OpenFile
            // 
            resources.ApplyResources(this.File_OpenFile, "File_OpenFile");
            this.File_OpenFile.Name = "File_OpenFile";
            this.File_OpenFile.Click += new System.EventHandler(this.File_OpenFile_Click);
            // 
            // Menu_Graph
            // 
            resources.ApplyResources(this.Menu_Graph, "Menu_Graph");
            this.Menu_Graph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Graph_Plot,
            this.Graph_Clear});
            this.Menu_Graph.Name = "Menu_Graph";
            // 
            // Graph_Plot
            // 
            resources.ApplyResources(this.Graph_Plot, "Graph_Plot");
            this.Graph_Plot.Name = "Graph_Plot";
            // 
            // Graph_Clear
            // 
            resources.ApplyResources(this.Graph_Clear, "Graph_Clear");
            this.Graph_Clear.Name = "Graph_Clear";
            // 
            // Menu_GraphType
            // 
            resources.ApplyResources(this.Menu_GraphType, "Menu_GraphType");
            this.Menu_GraphType.Name = "Menu_GraphType";
            // 
            // Menu_GraphSettings
            // 
            resources.ApplyResources(this.Menu_GraphSettings, "Menu_GraphSettings");
            this.Menu_GraphSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GraphSettings_Filter,
            this.GraphSettings_Apprearance,
            this.GraphSettings_Data});
            this.Menu_GraphSettings.Name = "Menu_GraphSettings";
            // 
            // GraphSettings_Filter
            // 
            resources.ApplyResources(this.GraphSettings_Filter, "GraphSettings_Filter");
            this.GraphSettings_Filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Filter_No,
            this.Filter_Low,
            this.Filter_Middle,
            this.Filter_High});
            this.GraphSettings_Filter.Name = "GraphSettings_Filter";
            // 
            // Filter_No
            // 
            resources.ApplyResources(this.Filter_No, "Filter_No");
            this.Filter_No.Checked = true;
            this.Filter_No.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filter_No.Name = "Filter_No";
            // 
            // Filter_Low
            // 
            resources.ApplyResources(this.Filter_Low, "Filter_Low");
            this.Filter_Low.Name = "Filter_Low";
            // 
            // Filter_Middle
            // 
            resources.ApplyResources(this.Filter_Middle, "Filter_Middle");
            this.Filter_Middle.Name = "Filter_Middle";
            // 
            // Filter_High
            // 
            resources.ApplyResources(this.Filter_High, "Filter_High");
            this.Filter_High.Name = "Filter_High";
            // 
            // GraphSettings_Apprearance
            // 
            resources.ApplyResources(this.GraphSettings_Apprearance, "GraphSettings_Apprearance");
            this.GraphSettings_Apprearance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Apprearance_Legend});
            this.GraphSettings_Apprearance.Name = "GraphSettings_Apprearance";
            // 
            // Apprearance_Legend
            // 
            resources.ApplyResources(this.Apprearance_Legend, "Apprearance_Legend");
            this.Apprearance_Legend.Checked = true;
            this.Apprearance_Legend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Apprearance_Legend.Name = "Apprearance_Legend";
            // 
            // GraphSettings_Data
            // 
            resources.ApplyResources(this.GraphSettings_Data, "GraphSettings_Data");
            this.GraphSettings_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data_MainColumns,
            this.Data_AdditionalColumns,
            this.Data_DataSource});
            this.GraphSettings_Data.Name = "GraphSettings_Data";
            // 
            // Data_MainColumns
            // 
            resources.ApplyResources(this.Data_MainColumns, "Data_MainColumns");
            this.Data_MainColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainColumns_AvgFPS,
            this.MainColumns_ModeFPS,
            this.MainColumns_MedianFPS,
            this.MainColumns_10low,
            this.MainColumns_1low,
            this.MainColumns_01low});
            this.Data_MainColumns.Name = "Data_MainColumns";
            // 
            // MainColumns_AvgFPS
            // 
            resources.ApplyResources(this.MainColumns_AvgFPS, "MainColumns_AvgFPS");
            this.MainColumns_AvgFPS.Checked = true;
            this.MainColumns_AvgFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainColumns_AvgFPS.Name = "MainColumns_AvgFPS";
            // 
            // MainColumns_ModeFPS
            // 
            resources.ApplyResources(this.MainColumns_ModeFPS, "MainColumns_ModeFPS");
            this.MainColumns_ModeFPS.Checked = true;
            this.MainColumns_ModeFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainColumns_ModeFPS.Name = "MainColumns_ModeFPS";
            // 
            // MainColumns_MedianFPS
            // 
            resources.ApplyResources(this.MainColumns_MedianFPS, "MainColumns_MedianFPS");
            this.MainColumns_MedianFPS.Checked = true;
            this.MainColumns_MedianFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainColumns_MedianFPS.Name = "MainColumns_MedianFPS";
            // 
            // MainColumns_10low
            // 
            resources.ApplyResources(this.MainColumns_10low, "MainColumns_10low");
            this.MainColumns_10low.Checked = true;
            this.MainColumns_10low.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainColumns_10low.Name = "MainColumns_10low";
            // 
            // MainColumns_1low
            // 
            resources.ApplyResources(this.MainColumns_1low, "MainColumns_1low");
            this.MainColumns_1low.Name = "MainColumns_1low";
            // 
            // MainColumns_01low
            // 
            resources.ApplyResources(this.MainColumns_01low, "MainColumns_01low");
            this.MainColumns_01low.Checked = true;
            this.MainColumns_01low.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainColumns_01low.Name = "MainColumns_01low";
            // 
            // Data_AdditionalColumns
            // 
            resources.ApplyResources(this.Data_AdditionalColumns, "Data_AdditionalColumns");
            this.Data_AdditionalColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdditionalColumns_CPUTemp,
            this.AdditionalColumns_GPUTemp,
            this.AdditionalColumns_CPUPower,
            this.AdditionalColumns_GPUPower});
            this.Data_AdditionalColumns.Name = "Data_AdditionalColumns";
            // 
            // AdditionalColumns_CPUTemp
            // 
            resources.ApplyResources(this.AdditionalColumns_CPUTemp, "AdditionalColumns_CPUTemp");
            this.AdditionalColumns_CPUTemp.Name = "AdditionalColumns_CPUTemp";
            // 
            // AdditionalColumns_GPUTemp
            // 
            resources.ApplyResources(this.AdditionalColumns_GPUTemp, "AdditionalColumns_GPUTemp");
            this.AdditionalColumns_GPUTemp.Name = "AdditionalColumns_GPUTemp";
            // 
            // AdditionalColumns_CPUPower
            // 
            resources.ApplyResources(this.AdditionalColumns_CPUPower, "AdditionalColumns_CPUPower");
            this.AdditionalColumns_CPUPower.Name = "AdditionalColumns_CPUPower";
            // 
            // AdditionalColumns_GPUPower
            // 
            resources.ApplyResources(this.AdditionalColumns_GPUPower, "AdditionalColumns_GPUPower");
            this.AdditionalColumns_GPUPower.Name = "AdditionalColumns_GPUPower";
            // 
            // Data_DataSource
            // 
            resources.ApplyResources(this.Data_DataSource, "Data_DataSource");
            this.Data_DataSource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataSource_API,
            this.DataSource_Display});
            this.Data_DataSource.Name = "Data_DataSource";
            // 
            // DataSource_API
            // 
            resources.ApplyResources(this.DataSource_API, "DataSource_API");
            this.DataSource_API.Checked = true;
            this.DataSource_API.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DataSource_API.Name = "DataSource_API";
            // 
            // DataSource_Display
            // 
            resources.ApplyResources(this.DataSource_Display, "DataSource_Display");
            this.DataSource_Display.Name = "DataSource_Display";
            // 
            // Menu_AppSettings
            // 
            resources.ApplyResources(this.Menu_AppSettings, "Menu_AppSettings");
            this.Menu_AppSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppSettings_Language,
            this.AppSettings_Theme});
            this.Menu_AppSettings.Name = "Menu_AppSettings";
            // 
            // AppSettings_Language
            // 
            resources.ApplyResources(this.AppSettings_Language, "AppSettings_Language");
            this.AppSettings_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Language_EN,
            this.Language_RU});
            this.AppSettings_Language.Name = "AppSettings_Language";
            // 
            // Language_EN
            // 
            resources.ApplyResources(this.Language_EN, "Language_EN");
            this.Language_EN.Name = "Language_EN";
            this.Language_EN.Click += new System.EventHandler(this.Language_EN_Click);
            // 
            // Language_RU
            // 
            resources.ApplyResources(this.Language_RU, "Language_RU");
            this.Language_RU.Name = "Language_RU";
            this.Language_RU.Click += new System.EventHandler(this.Language_RU_Click);
            // 
            // AppSettings_Theme
            // 
            resources.ApplyResources(this.AppSettings_Theme, "AppSettings_Theme");
            this.AppSettings_Theme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Theme_Lite,
            this.Theme_Dark});
            this.AppSettings_Theme.Name = "AppSettings_Theme";
            // 
            // Theme_Lite
            // 
            resources.ApplyResources(this.Theme_Lite, "Theme_Lite");
            this.Theme_Lite.Checked = true;
            this.Theme_Lite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Theme_Lite.Name = "Theme_Lite";
            // 
            // Theme_Dark
            // 
            resources.ApplyResources(this.Theme_Dark, "Theme_Dark");
            this.Theme_Dark.Name = "Theme_Dark";
            // 
            // Menu_About
            // 
            resources.ApplyResources(this.Menu_About, "Menu_About");
            this.Menu_About.Name = "Menu_About";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            resources.ApplyResources(this.OpenFile, "OpenFile");
            // 
            // StatusMenu
            // 
            resources.ApplyResources(this.StatusMenu, "StatusMenu");
            this.StatusMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.StatusMenu.Name = "StatusMenu";
            // 
            // StatusText
            // 
            resources.ApplyResources(this.StatusText, "StatusText");
            this.StatusText.Name = "StatusText";
            // 
            // FileList
            // 
            resources.ApplyResources(this.FileList, "FileList");
            this.FileList.FormattingEnabled = true;
            this.FileList.Name = "FileList";
            this.FileList.TabStop = false;
            this.FileList.UseTabStops = false;
            // 
            // PlotView
            // 
            resources.ApplyResources(this.PlotView, "PlotView");
            this.PlotView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlotView.Name = "PlotView";
            this.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotView.TabStop = false;
            this.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.PlotView);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.StatusMenu);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusMenu.ResumeLayout(false);
            this.StatusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem Menu_File;
        private ToolStripMenuItem Menu_Graph;
        private ToolStripMenuItem Menu_GraphType;
        private ToolStripMenuItem Menu_GraphSettings;
        private ToolStripMenuItem Menu_AppSettings;
        private ToolStripMenuItem Menu_About;
        private ToolStripMenuItem AppSettings_Language;
        private ToolStripMenuItem Language_EN;
        private ToolStripMenuItem Language_RU;
        private ToolStripMenuItem File_OpenFile;
        private OpenFileDialog OpenFile;
        private StatusStrip StatusMenu;
        private CheckedListBox FileList;
        private OxyPlot.WindowsForms.PlotView PlotView;
        private ToolStripMenuItem Graph_Plot;
        private ToolStripMenuItem Graph_Clear;
        private ToolStripStatusLabel StatusText;
        private ToolStripMenuItem AppSettings_Theme;
        private ToolStripMenuItem Theme_Lite;
        private ToolStripMenuItem Theme_Dark;
        private ToolStripMenuItem GraphSettings_Filter;
        private ToolStripMenuItem Filter_No;
        private ToolStripMenuItem Filter_Low;
        private ToolStripMenuItem Filter_Middle;
        private ToolStripMenuItem Filter_High;
        private ToolStripMenuItem GraphSettings_Apprearance;
        private ToolStripMenuItem Apprearance_Legend;
        private ToolStripMenuItem GraphSettings_Data;
        private ToolStripMenuItem Data_MainColumns;
        private ToolStripMenuItem MainColumns_AvgFPS;
        private ToolStripMenuItem MainColumns_ModeFPS;
        private ToolStripMenuItem MainColumns_MedianFPS;
        private ToolStripMenuItem MainColumns_10low;
        private ToolStripMenuItem MainColumns_1low;
        private ToolStripMenuItem MainColumns_01low;
        private ToolStripMenuItem Data_AdditionalColumns;
        private ToolStripMenuItem AdditionalColumns_CPUTemp;
        private ToolStripMenuItem AdditionalColumns_GPUTemp;
        private ToolStripMenuItem AdditionalColumns_CPUPower;
        private ToolStripMenuItem AdditionalColumns_GPUPower;
        private ToolStripMenuItem Data_DataSource;
        private ToolStripMenuItem DataSource_API;
        private ToolStripMenuItem DataSource_Display;
    }
}