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
            this.Menu_GraphType = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GraphSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettings_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_RU = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.StatusMenu = new System.Windows.Forms.StatusStrip();
            this.FileList = new System.Windows.Forms.CheckedListBox();
            this.PlotView = new OxyPlot.WindowsForms.PlotView();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Graph,
            this.Menu_GraphType,
            this.Menu_GraphSettings,
            this.Menu_AppSettings,
            this.Menu_About});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1184, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_OpenFile});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "File";
            // 
            // File_OpenFile
            // 
            this.File_OpenFile.Name = "File_OpenFile";
            this.File_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.File_OpenFile.Size = new System.Drawing.Size(174, 22);
            this.File_OpenFile.Text = "Open file...";
            this.File_OpenFile.Click += new System.EventHandler(this.File_OpenFile_Click);
            // 
            // Menu_Graph
            // 
            this.Menu_Graph.Name = "Menu_Graph";
            this.Menu_Graph.Size = new System.Drawing.Size(51, 20);
            this.Menu_Graph.Text = "Graph";
            // 
            // Menu_GraphType
            // 
            this.Menu_GraphType.Name = "Menu_GraphType";
            this.Menu_GraphType.Size = new System.Drawing.Size(77, 20);
            this.Menu_GraphType.Text = "Graph type";
            // 
            // Menu_GraphSettings
            // 
            this.Menu_GraphSettings.Name = "Menu_GraphSettings";
            this.Menu_GraphSettings.Size = new System.Drawing.Size(95, 20);
            this.Menu_GraphSettings.Text = "Graph settings";
            // 
            // Menu_AppSettings
            // 
            this.Menu_AppSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppSettings_Language});
            this.Menu_AppSettings.Name = "Menu_AppSettings";
            this.Menu_AppSettings.Size = new System.Drawing.Size(85, 20);
            this.Menu_AppSettings.Text = "App settings";
            // 
            // AppSettings_Language
            // 
            this.AppSettings_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Language_EN,
            this.Language_RU});
            this.AppSettings_Language.Name = "AppSettings_Language";
            this.AppSettings_Language.Size = new System.Drawing.Size(126, 22);
            this.AppSettings_Language.Text = "Language";
            // 
            // Language_EN
            // 
            this.Language_EN.Name = "Language_EN";
            this.Language_EN.Size = new System.Drawing.Size(114, 22);
            this.Language_EN.Text = "English";
            this.Language_EN.Click += new System.EventHandler(this.Language_EN_Click);
            // 
            // Language_RU
            // 
            this.Language_RU.Name = "Language_RU";
            this.Language_RU.Size = new System.Drawing.Size(114, 22);
            this.Language_RU.Text = "Russian";
            this.Language_RU.Click += new System.EventHandler(this.Language_RU_Click);
            // 
            // Menu_About
            // 
            this.Menu_About.Name = "Menu_About";
            this.Menu_About.Size = new System.Drawing.Size(52, 20);
            this.Menu_About.Text = "About";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // StatusMenu
            // 
            this.StatusMenu.Location = new System.Drawing.Point(0, 539);
            this.StatusMenu.Name = "StatusMenu";
            this.StatusMenu.Size = new System.Drawing.Size(1184, 22);
            this.StatusMenu.TabIndex = 1;
            this.StatusMenu.Text = "statusStrip1";
            // 
            // FileList
            // 
            this.FileList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(12, 27);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(220, 508);
            this.FileList.TabIndex = 2;
            // 
            // PlotView
            // 
            this.PlotView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlotView.Location = new System.Drawing.Point(238, 26);
            this.PlotView.Name = "PlotView";
            this.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotView.Size = new System.Drawing.Size(764, 509);
            this.PlotView.TabIndex = 4;
            this.PlotView.Text = "Test";
            this.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.PlotView);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.StatusMenu);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrameViewGraph";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
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
    }
}