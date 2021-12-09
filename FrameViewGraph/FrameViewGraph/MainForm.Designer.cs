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
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Graph = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GraphType = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GraphSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettings_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.Language_RU = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.File_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Main
            // 
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Graph,
            this.Menu_GraphType,
            this.Menu_GraphSettings,
            this.Menu_AppSettings,
            this.Menu_About});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(840, 24);
            this.Menu_Main.TabIndex = 0;
            this.Menu_Main.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_OpenFile});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "File";
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
            this.AppSettings_Language.Size = new System.Drawing.Size(180, 22);
            this.AppSettings_Language.Text = "Language";
            // 
            // Language_EN
            // 
            this.Language_EN.Checked = true;
            this.Language_EN.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // File_OpenFile
            // 
            this.File_OpenFile.Name = "File_OpenFile";
            this.File_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.File_OpenFile.Size = new System.Drawing.Size(180, 22);
            this.File_OpenFile.Text = "Open file...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 441);
            this.Controls.Add(this.Menu_Main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrameViewGraph";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu_Main.ResumeLayout(false);
            this.Menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Menu_Main;
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
    }
}