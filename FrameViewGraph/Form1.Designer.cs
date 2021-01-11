namespace FrameViewGraph
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkListFile = new System.Windows.Forms.CheckedListBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.chrMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStr = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileControlDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileControlInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolutionFullHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolutionQHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolutionUHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolutionCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResolutionCustomX = new System.Windows.Forms.ToolStripTextBox();
            this.menuResolutionCustomY = new System.Windows.Forms.ToolStripTextBox();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewNameValue = new System.Windows.Forms.ToolStripTextBox();
            this.легендаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).BeginInit();
            this.menuStr.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 0;
            // 
            // chkListFile
            // 
            this.chkListFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkListFile.CheckOnClick = true;
            this.chkListFile.FormattingEnabled = true;
            this.chkListFile.Location = new System.Drawing.Point(12, 27);
            this.chkListFile.Name = "chkListFile";
            this.chkListFile.Size = new System.Drawing.Size(860, 65);
            this.chkListFile.TabIndex = 5;
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "CSV files (*.csv)|*.csv";
            // 
            // chrMain
            // 
            legend1.Name = "Legend1";
            this.chrMain.Legends.Add(legend1);
            this.chrMain.Location = new System.Drawing.Point(12, 100);
            this.chrMain.Name = "chrMain";
            this.chrMain.Size = new System.Drawing.Size(860, 425);
            this.chrMain.TabIndex = 17;
            // 
            // menuStr
            // 
            this.menuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuGraph,
            this.menuGr,
            this.menuHelp});
            this.menuStr.Location = new System.Drawing.Point(0, 0);
            this.menuStr.Name = "menuStr";
            this.menuStr.Size = new System.Drawing.Size(884, 24);
            this.menuStr.TabIndex = 18;
            this.menuStr.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileAdd,
            this.menuFileControl,
            this.menuResolution,
            this.menuFileSaveAs});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuFileAdd
            // 
            this.menuFileAdd.Name = "menuFileAdd";
            this.menuFileAdd.Size = new System.Drawing.Size(194, 22);
            this.menuFileAdd.Text = "Добавить данные...";
            this.menuFileAdd.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // menuFileControl
            // 
            this.menuFileControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileControlDelete,
            this.menuFileControlInvert});
            this.menuFileControl.Name = "menuFileControl";
            this.menuFileControl.Size = new System.Drawing.Size(194, 22);
            this.menuFileControl.Text = "Управлять данными...";
            // 
            // menuFileControlDelete
            // 
            this.menuFileControlDelete.Name = "menuFileControlDelete";
            this.menuFileControlDelete.Size = new System.Drawing.Size(225, 22);
            this.menuFileControlDelete.Text = "Удалить выбранные";
            this.menuFileControlDelete.Click += new System.EventHandler(this.menuFileControlDelete_Click);
            // 
            // menuFileControlInvert
            // 
            this.menuFileControlInvert.Name = "menuFileControlInvert";
            this.menuFileControlInvert.Size = new System.Drawing.Size(225, 22);
            this.menuFileControlInvert.Text = "Инвертировать выбранные";
            this.menuFileControlInvert.Click += new System.EventHandler(this.menuFileControlInvert_Click);
            // 
            // menuResolution
            // 
            this.menuResolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResolutionFullHD,
            this.menuResolutionQHD,
            this.menuResolutionUHD,
            this.menuResolutionCustom});
            this.menuResolution.Name = "menuResolution";
            this.menuResolution.Size = new System.Drawing.Size(194, 22);
            this.menuResolution.Text = "Разрешение";
            // 
            // menuResolutionFullHD
            // 
            this.menuResolutionFullHD.Checked = true;
            this.menuResolutionFullHD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuResolutionFullHD.Name = "menuResolutionFullHD";
            this.menuResolutionFullHD.Size = new System.Drawing.Size(176, 22);
            this.menuResolutionFullHD.Text = "FullHD";
            this.menuResolutionFullHD.ToolTipText = "Ширина: 1920. Высота: 1080.";
            this.menuResolutionFullHD.Click += new System.EventHandler(this.menuResolutionFullHD_Click);
            // 
            // menuResolutionQHD
            // 
            this.menuResolutionQHD.Name = "menuResolutionQHD";
            this.menuResolutionQHD.Size = new System.Drawing.Size(176, 22);
            this.menuResolutionQHD.Text = "QHD";
            this.menuResolutionQHD.ToolTipText = "Ширина: 2560. Высота: 1440.";
            this.menuResolutionQHD.Click += new System.EventHandler(this.menuResolutionQHD_Click);
            // 
            // menuResolutionUHD
            // 
            this.menuResolutionUHD.Name = "menuResolutionUHD";
            this.menuResolutionUHD.Size = new System.Drawing.Size(176, 22);
            this.menuResolutionUHD.Text = "UHD";
            this.menuResolutionUHD.ToolTipText = "Ширина: 3840. Высота: 2160.";
            this.menuResolutionUHD.Click += new System.EventHandler(this.menuResolutionUHD_Click);
            // 
            // menuResolutionCustom
            // 
            this.menuResolutionCustom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResolutionCustomX,
            this.menuResolutionCustomY});
            this.menuResolutionCustom.Name = "menuResolutionCustom";
            this.menuResolutionCustom.Size = new System.Drawing.Size(176, 22);
            this.menuResolutionCustom.Text = "Пользовательское";
            this.menuResolutionCustom.Click += new System.EventHandler(this.menuResolutionCustom_Click);
            // 
            // menuResolutionCustomX
            // 
            this.menuResolutionCustomX.Name = "menuResolutionCustomX";
            this.menuResolutionCustomX.Size = new System.Drawing.Size(100, 23);
            this.menuResolutionCustomX.Text = "1920";
            this.menuResolutionCustomX.ToolTipText = "Максимальное значение: 32767";
            this.menuResolutionCustomX.TextChanged += new System.EventHandler(this.menuResolutionCustomX_TextChanged);
            // 
            // menuResolutionCustomY
            // 
            this.menuResolutionCustomY.Name = "menuResolutionCustomY";
            this.menuResolutionCustomY.Size = new System.Drawing.Size(100, 23);
            this.menuResolutionCustomY.Text = "1080";
            this.menuResolutionCustomY.ToolTipText = "Максимальное значение: 32767";
            this.menuResolutionCustomY.TextChanged += new System.EventHandler(this.menuResolutionCustomY_TextChanged);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Enabled = false;
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(194, 22);
            this.menuFileSaveAs.Text = "Сохранить как...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // menuGraph
            // 
            this.menuGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGraph1,
            this.menuGraph2,
            this.menuGraph3,
            this.menuGraph4});
            this.menuGraph.Name = "menuGraph";
            this.menuGraph.Size = new System.Drawing.Size(88, 20);
            this.menuGraph.Text = "Тип графика";
            // 
            // menuGraph1
            // 
            this.menuGraph1.Checked = true;
            this.menuGraph1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGraph1.Name = "menuGraph1";
            this.menuGraph1.Size = new System.Drawing.Size(230, 22);
            this.menuGraph1.Text = "Времени кадров";
            this.menuGraph1.Click += new System.EventHandler(this.menuGraph1_Click);
            // 
            // menuGraph2
            // 
            this.menuGraph2.Name = "menuGraph2";
            this.menuGraph2.Size = new System.Drawing.Size(230, 22);
            this.menuGraph2.Text = "Кадров в секунду";
            this.menuGraph2.Click += new System.EventHandler(this.menuGraph2_Click);
            // 
            // menuGraph3
            // 
            this.menuGraph3.Name = "menuGraph3";
            this.menuGraph3.Size = new System.Drawing.Size(230, 22);
            this.menuGraph3.Text = "Плотности вероятности";
            this.menuGraph3.Click += new System.EventHandler(this.menuGraph3_Click);
            // 
            // menuGraph4
            // 
            this.menuGraph4.Name = "menuGraph4";
            this.menuGraph4.Size = new System.Drawing.Size(230, 22);
            this.menuGraph4.Text = "Распределения вероятности";
            this.menuGraph4.Click += new System.EventHandler(this.menuGraph4_Click);
            // 
            // menuGr
            // 
            this.menuGr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrDraw,
            this.menuGrClear,
            this.menuGrView,
            this.menuGrNewWindow});
            this.menuGr.Name = "menuGr";
            this.menuGr.Size = new System.Drawing.Size(60, 20);
            this.menuGr.Text = "График";
            // 
            // menuGrDraw
            // 
            this.menuGrDraw.Name = "menuGrDraw";
            this.menuGrDraw.Size = new System.Drawing.Size(207, 22);
            this.menuGrDraw.Text = "Построить";
            this.menuGrDraw.Click += new System.EventHandler(this.menuGrDraw_Click);
            // 
            // menuGrClear
            // 
            this.menuGrClear.Name = "menuGrClear";
            this.menuGrClear.Size = new System.Drawing.Size(207, 22);
            this.menuGrClear.Text = "Очистить";
            this.menuGrClear.Click += new System.EventHandler(this.menuGrClear_Click);
            // 
            // menuGrView
            // 
            this.menuGrView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewName,
            this.легендаToolStripMenuItem});
            this.menuGrView.Name = "menuGrView";
            this.menuGrView.Size = new System.Drawing.Size(207, 22);
            this.menuGrView.Text = "Внешний вид";
            this.menuGrView.Click += new System.EventHandler(this.menuGrView_Click);
            // 
            // menuGrViewName
            // 
            this.menuGrViewName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewNameValue});
            this.menuGrViewName.Name = "menuGrViewName";
            this.menuGrViewName.Size = new System.Drawing.Size(126, 22);
            this.menuGrViewName.Text = "Название";
            // 
            // menuGrViewNameValue
            // 
            this.menuGrViewNameValue.Name = "menuGrViewNameValue";
            this.menuGrViewNameValue.Size = new System.Drawing.Size(180, 23);
            this.menuGrViewNameValue.TextChanged += new System.EventHandler(this.menuGrViewNameValue_TextChanged);
            // 
            // легендаToolStripMenuItem
            // 
            this.легендаToolStripMenuItem.Checked = true;
            this.легендаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.легендаToolStripMenuItem.Name = "легендаToolStripMenuItem";
            this.легендаToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.легендаToolStripMenuItem.Text = "Легенда";
            // 
            // menuGrNewWindow
            // 
            this.menuGrNewWindow.Name = "menuGrNewWindow";
            this.menuGrNewWindow.Size = new System.Drawing.Size(207, 22);
            this.menuGrNewWindow.Text = "Открыть в новом окне...";
            this.menuGrNewWindow.Click += new System.EventHandler(this.menuGrNewWindow_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpInfo,
            this.menuHelpVersion});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuHelpInfo
            // 
            this.menuHelpInfo.Name = "menuHelpInfo";
            this.menuHelpInfo.Size = new System.Drawing.Size(192, 22);
            this.menuHelpInfo.Text = "Краткая информация";
            this.menuHelpInfo.Click += new System.EventHandler(this.menuHelpInfo_Click);
            // 
            // menuHelpVersion
            // 
            this.menuHelpVersion.Name = "menuHelpVersion";
            this.menuHelpVersion.Size = new System.Drawing.Size(192, 22);
            this.menuHelpVersion.Text = "О FrameViewGraph...";
            this.menuHelpVersion.Click += new System.EventHandler(this.menuHelpVersion_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusName,
            this.statusStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStr";
            // 
            // statusName
            // 
            this.statusName.Name = "statusName";
            this.statusName.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStatus
            // 
            this.statusStatus.Name = "statusStatus";
            this.statusStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chrMain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkListFile);
            this.Controls.Add(this.menuStr);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStr;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FVG v.0.2.0 by volkovskey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).EndInit();
            this.menuStr.ResumeLayout(false);
            this.menuStr.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox chkListFile;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMain;
        private System.Windows.Forms.MenuStrip menuStr;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileAdd;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuGraph;
        private System.Windows.Forms.ToolStripMenuItem menuGraph2;
        private System.Windows.Forms.ToolStripMenuItem menuGraph3;
        private System.Windows.Forms.ToolStripMenuItem menuGraph4;
        private System.Windows.Forms.ToolStripMenuItem menuGraph1;
        private System.Windows.Forms.ToolStripMenuItem menuFileControl;
        private System.Windows.Forms.ToolStripMenuItem menuFileControlDelete;
        private System.Windows.Forms.ToolStripMenuItem menuFileControlInvert;
        private System.Windows.Forms.ToolStripMenuItem menuResolution;
        private System.Windows.Forms.ToolStripMenuItem menuResolutionFullHD;
        private System.Windows.Forms.ToolStripMenuItem menuResolutionQHD;
        private System.Windows.Forms.ToolStripMenuItem menuResolutionUHD;
        private System.Windows.Forms.ToolStripMenuItem menuResolutionCustom;
        private System.Windows.Forms.ToolStripTextBox menuResolutionCustomX;
        private System.Windows.Forms.ToolStripTextBox menuResolutionCustomY;
        private System.Windows.Forms.ToolStripMenuItem menuGr;
        private System.Windows.Forms.ToolStripMenuItem menuGrDraw;
        private System.Windows.Forms.ToolStripMenuItem menuGrClear;
        private System.Windows.Forms.ToolStripMenuItem menuGrView;
        private System.Windows.Forms.ToolStripMenuItem menuGrNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewName;
        private System.Windows.Forms.ToolStripTextBox menuGrViewNameValue;
        private System.Windows.Forms.ToolStripMenuItem легендаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpInfo;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVersion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusName;
        private System.Windows.Forms.ToolStripStatusLabel statusStatus;
    }
}

