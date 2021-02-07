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
            this.menuGraph5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraph6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrFilterNo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrFilter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrFilter2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrFilter3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewDiagram6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewLegend = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewAxis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFontFamily = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFont1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFont2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFont3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFont4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFontSizeAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrViewFontSizeCustom = new System.Windows.Forms.ToolStripTextBox();
            this.menuGrNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuName = new System.Windows.Forms.ToolStripTextBox();
            this.menuCmbBx = new System.Windows.Forms.ToolStripComboBox();
            this.statusStr = new System.Windows.Forms.StatusStrip();
            this.statusStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.lblGpuFreq = new System.Windows.Forms.Label();
            this.labelGpuFreq = new System.Windows.Forms.Label();
            this.lblCpuFreq = new System.Windows.Forms.Label();
            this.labelCpuFreq = new System.Windows.Forms.Label();
            this.lbl01pc = new System.Windows.Forms.Label();
            this.lbl1pc = new System.Windows.Forms.Label();
            this.lbl10pc = new System.Windows.Forms.Label();
            this.lbl50pc = new System.Windows.Forms.Label();
            this.lblModeFPS = new System.Windows.Forms.Label();
            this.lblAvgFPS = new System.Windows.Forms.Label();
            this.lblGpuPower = new System.Windows.Forms.Label();
            this.lblGpuTemp = new System.Windows.Forms.Label();
            this.lblGpuUsage = new System.Windows.Forms.Label();
            this.lblCpuPower = new System.Windows.Forms.Label();
            this.lblCpuTemp = new System.Windows.Forms.Label();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.lblGpuName = new System.Windows.Forms.Label();
            this.lblCpuName = new System.Windows.Forms.Label();
            this.lblApi = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.label10pc = new System.Windows.Forms.Label();
            this.labelGpuTemp = new System.Windows.Forms.Label();
            this.labelGpuPower = new System.Windows.Forms.Label();
            this.labelGpuUsage = new System.Windows.Forms.Label();
            this.labelGpuName = new System.Windows.Forms.Label();
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelCpuPower = new System.Windows.Forms.Label();
            this.label01pc = new System.Windows.Forms.Label();
            this.label1pc = new System.Windows.Forms.Label();
            this.label50pc = new System.Windows.Forms.Label();
            this.labelModeFPS = new System.Windows.Forms.Label();
            this.labelAvgFPS = new System.Windows.Forms.Label();
            this.labelApi = new System.Windows.Forms.Label();
            this.labelCpuUsage = new System.Windows.Forms.Label();
            this.labelCpuName = new System.Windows.Forms.Label();
            this.labelApplication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).BeginInit();
            this.menuStr.SuspendLayout();
            this.statusStr.SuspendLayout();
            this.grpBxInfo.SuspendLayout();
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
            this.chkListFile.Location = new System.Drawing.Point(12, 30);
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
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chrMain.Legends.Add(legend1);
            this.chrMain.Location = new System.Drawing.Point(12, 100);
            this.chrMain.Name = "chrMain";
            this.chrMain.Size = new System.Drawing.Size(860, 425);
            this.chrMain.TabIndex = 17;
            // 
            // menuStr
            // 
            this.menuStr.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuGraph,
            this.menuGr,
            this.menuHelp,
            this.menuName,
            this.menuCmbBx});
            this.menuStr.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStr.Location = new System.Drawing.Point(0, 0);
            this.menuStr.Name = "menuStr";
            this.menuStr.Size = new System.Drawing.Size(1184, 27);
            this.menuStr.TabIndex = 18;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileAdd,
            this.menuFileControl,
            this.menuResolution,
            this.menuFileSaveAs});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 23);
            this.menuFile.Text = "Файл";
            // 
            // menuFileAdd
            // 
            this.menuFileAdd.Name = "menuFileAdd";
            this.menuFileAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuFileAdd.Size = new System.Drawing.Size(221, 22);
            this.menuFileAdd.Text = "Добавить данные...";
            this.menuFileAdd.Click += new System.EventHandler(this.menuFileAdd_Click);
            // 
            // menuFileControl
            // 
            this.menuFileControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileControlDelete,
            this.menuFileControlInvert});
            this.menuFileControl.Name = "menuFileControl";
            this.menuFileControl.Size = new System.Drawing.Size(221, 22);
            this.menuFileControl.Text = "Управлять данными...";
            // 
            // menuFileControlDelete
            // 
            this.menuFileControlDelete.Name = "menuFileControlDelete";
            this.menuFileControlDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuFileControlDelete.Size = new System.Drawing.Size(262, 22);
            this.menuFileControlDelete.Text = "Удалить выбранные";
            this.menuFileControlDelete.Click += new System.EventHandler(this.menuFileControlDelete_Click);
            // 
            // menuFileControlInvert
            // 
            this.menuFileControlInvert.Name = "menuFileControlInvert";
            this.menuFileControlInvert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuFileControlInvert.Size = new System.Drawing.Size(262, 22);
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
            this.menuResolution.Size = new System.Drawing.Size(221, 22);
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
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(221, 22);
            this.menuFileSaveAs.Text = "Сохранить как...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuGraph
            // 
            this.menuGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGraph1,
            this.menuGraph2,
            this.menuGraph3,
            this.menuGraph4,
            this.menuGraph5,
            this.menuGraph6});
            this.menuGraph.Name = "menuGraph";
            this.menuGraph.Size = new System.Drawing.Size(88, 23);
            this.menuGraph.Text = "Тип графика";
            // 
            // menuGraph1
            // 
            this.menuGraph1.Checked = true;
            this.menuGraph1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGraph1.Name = "menuGraph1";
            this.menuGraph1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuGraph1.Size = new System.Drawing.Size(270, 22);
            this.menuGraph1.Text = "Времени кадров";
            this.menuGraph1.Click += new System.EventHandler(this.menuGraph1_Click);
            this.menuGraph1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuGraph1_MouseDown);
            // 
            // menuGraph2
            // 
            this.menuGraph2.Name = "menuGraph2";
            this.menuGraph2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuGraph2.Size = new System.Drawing.Size(270, 22);
            this.menuGraph2.Text = "Кадров в секунду";
            this.menuGraph2.Click += new System.EventHandler(this.menuGraph2_Click);
            this.menuGraph2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuGraph2_MouseDown);
            // 
            // menuGraph3
            // 
            this.menuGraph3.Name = "menuGraph3";
            this.menuGraph3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.menuGraph3.Size = new System.Drawing.Size(270, 22);
            this.menuGraph3.Text = "Плотности вероятности";
            this.menuGraph3.Click += new System.EventHandler(this.menuGraph3_Click);
            this.menuGraph3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuGraph3_MouseDown);
            // 
            // menuGraph4
            // 
            this.menuGraph4.Enabled = false;
            this.menuGraph4.Name = "menuGraph4";
            this.menuGraph4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.menuGraph4.Size = new System.Drawing.Size(270, 22);
            this.menuGraph4.Text = "Распределения вероятности";
            this.menuGraph4.Click += new System.EventHandler(this.menuGraph4_Click);
            // 
            // menuGraph5
            // 
            this.menuGraph5.Name = "menuGraph5";
            this.menuGraph5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.menuGraph5.Size = new System.Drawing.Size(270, 22);
            this.menuGraph5.Text = "Сравнения статистики (FPS)";
            this.menuGraph5.Click += new System.EventHandler(this.menuGraph5_Click);
            this.menuGraph5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuGraph5_MouseDown);
            // 
            // menuGraph6
            // 
            this.menuGraph6.Name = "menuGraph6";
            this.menuGraph6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.menuGraph6.Size = new System.Drawing.Size(270, 22);
            this.menuGraph6.Text = "Сравнения статистики (%)";
            this.menuGraph6.Click += new System.EventHandler(this.menuGraph6_Click);
            this.menuGraph6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuGraph6_MouseDown);
            // 
            // menuGr
            // 
            this.menuGr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrDraw,
            this.menuGrClear,
            this.menuGrFilter,
            this.menuGrView,
            this.menuGrNewWindow});
            this.menuGr.Name = "menuGr";
            this.menuGr.Size = new System.Drawing.Size(60, 23);
            this.menuGr.Text = "График";
            // 
            // menuGrDraw
            // 
            this.menuGrDraw.Name = "menuGrDraw";
            this.menuGrDraw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuGrDraw.Size = new System.Drawing.Size(250, 22);
            this.menuGrDraw.Text = "Построить";
            this.menuGrDraw.Click += new System.EventHandler(this.menuGrDraw_Click);
            // 
            // menuGrClear
            // 
            this.menuGrClear.Name = "menuGrClear";
            this.menuGrClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.menuGrClear.Size = new System.Drawing.Size(250, 22);
            this.menuGrClear.Text = "Очистить";
            this.menuGrClear.Click += new System.EventHandler(this.menuGrClear_Click);
            // 
            // menuGrFilter
            // 
            this.menuGrFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrFilterNo,
            this.menuGrFilter1,
            this.menuGrFilter2,
            this.menuGrFilter3});
            this.menuGrFilter.Name = "menuGrFilter";
            this.menuGrFilter.Size = new System.Drawing.Size(250, 22);
            this.menuGrFilter.Text = "Фильтр";
            // 
            // menuGrFilterNo
            // 
            this.menuGrFilterNo.Checked = true;
            this.menuGrFilterNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrFilterNo.Name = "menuGrFilterNo";
            this.menuGrFilterNo.Size = new System.Drawing.Size(129, 22);
            this.menuGrFilterNo.Text = "Нет";
            this.menuGrFilterNo.Click += new System.EventHandler(this.menuGrFilterNo_Click);
            // 
            // menuGrFilter1
            // 
            this.menuGrFilter1.Name = "menuGrFilter1";
            this.menuGrFilter1.Size = new System.Drawing.Size(129, 22);
            this.menuGrFilter1.Text = "Слабый";
            this.menuGrFilter1.Click += new System.EventHandler(this.menuGrFilter1_Click);
            // 
            // menuGrFilter2
            // 
            this.menuGrFilter2.Name = "menuGrFilter2";
            this.menuGrFilter2.Size = new System.Drawing.Size(129, 22);
            this.menuGrFilter2.Text = "Обычный";
            this.menuGrFilter2.Click += new System.EventHandler(this.menuGrFilter2_Click);
            // 
            // menuGrFilter3
            // 
            this.menuGrFilter3.Name = "menuGrFilter3";
            this.menuGrFilter3.Size = new System.Drawing.Size(129, 22);
            this.menuGrFilter3.Text = "Сильный";
            this.menuGrFilter3.Click += new System.EventHandler(this.menuGrFilter3_Click);
            // 
            // menuGrView
            // 
            this.menuGrView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewDiagram,
            this.menuGrViewLegend,
            this.menuGrViewAxis,
            this.menuGrViewFont});
            this.menuGrView.Name = "menuGrView";
            this.menuGrView.Size = new System.Drawing.Size(250, 22);
            this.menuGrView.Text = "Внешний вид";
            // 
            // menuGrViewDiagram
            // 
            this.menuGrViewDiagram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewDiagram1,
            this.menuGrViewDiagram2,
            this.menuGrViewDiagram3,
            this.menuGrViewDiagram4,
            this.menuGrViewDiagram5,
            this.menuGrViewDiagram6});
            this.menuGrViewDiagram.Enabled = false;
            this.menuGrViewDiagram.Name = "menuGrViewDiagram";
            this.menuGrViewDiagram.Size = new System.Drawing.Size(158, 22);
            this.menuGrViewDiagram.Text = "Диаграмма";
            this.menuGrViewDiagram.Click += new System.EventHandler(this.menuGrViewDiagram_Click);
            // 
            // menuGrViewDiagram1
            // 
            this.menuGrViewDiagram1.Checked = true;
            this.menuGrViewDiagram1.CheckOnClick = true;
            this.menuGrViewDiagram1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewDiagram1.Name = "menuGrViewDiagram1";
            this.menuGrViewDiagram1.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram1.Text = "Средний FPS";
            // 
            // menuGrViewDiagram2
            // 
            this.menuGrViewDiagram2.Checked = true;
            this.menuGrViewDiagram2.CheckOnClick = true;
            this.menuGrViewDiagram2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewDiagram2.Name = "menuGrViewDiagram2";
            this.menuGrViewDiagram2.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram2.Text = "Модальный FPS";
            // 
            // menuGrViewDiagram3
            // 
            this.menuGrViewDiagram3.Checked = true;
            this.menuGrViewDiagram3.CheckOnClick = true;
            this.menuGrViewDiagram3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewDiagram3.Name = "menuGrViewDiagram3";
            this.menuGrViewDiagram3.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram3.Text = "Медианный FPS";
            // 
            // menuGrViewDiagram4
            // 
            this.menuGrViewDiagram4.CheckOnClick = true;
            this.menuGrViewDiagram4.Name = "menuGrViewDiagram4";
            this.menuGrViewDiagram4.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram4.Text = "10% low";
            // 
            // menuGrViewDiagram5
            // 
            this.menuGrViewDiagram5.Checked = true;
            this.menuGrViewDiagram5.CheckOnClick = true;
            this.menuGrViewDiagram5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewDiagram5.Name = "menuGrViewDiagram5";
            this.menuGrViewDiagram5.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram5.Text = "1% low";
            // 
            // menuGrViewDiagram6
            // 
            this.menuGrViewDiagram6.Checked = true;
            this.menuGrViewDiagram6.CheckOnClick = true;
            this.menuGrViewDiagram6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewDiagram6.Name = "menuGrViewDiagram6";
            this.menuGrViewDiagram6.Size = new System.Drawing.Size(162, 22);
            this.menuGrViewDiagram6.Text = "0.1% low";
            // 
            // menuGrViewLegend
            // 
            this.menuGrViewLegend.Checked = true;
            this.menuGrViewLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewLegend.Name = "menuGrViewLegend";
            this.menuGrViewLegend.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuGrViewLegend.Size = new System.Drawing.Size(158, 22);
            this.menuGrViewLegend.Text = "Легенда";
            this.menuGrViewLegend.Click += new System.EventHandler(this.menuGrLegend_Click);
            // 
            // menuGrViewAxis
            // 
            this.menuGrViewAxis.Checked = true;
            this.menuGrViewAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewAxis.Enabled = false;
            this.menuGrViewAxis.Name = "menuGrViewAxis";
            this.menuGrViewAxis.Size = new System.Drawing.Size(158, 22);
            this.menuGrViewAxis.Text = "Подписи осей";
            this.menuGrViewAxis.Click += new System.EventHandler(this.menuGrViewAxis_Click);
            // 
            // menuGrViewFont
            // 
            this.menuGrViewFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewFontFamily,
            this.menuGrViewFontSize});
            this.menuGrViewFont.Enabled = false;
            this.menuGrViewFont.Name = "menuGrViewFont";
            this.menuGrViewFont.Size = new System.Drawing.Size(158, 22);
            this.menuGrViewFont.Text = "Шрифт";
            // 
            // menuGrViewFontFamily
            // 
            this.menuGrViewFontFamily.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewFont1,
            this.menuGrViewFont2,
            this.menuGrViewFont3,
            this.menuGrViewFont4});
            this.menuGrViewFontFamily.Name = "menuGrViewFontFamily";
            this.menuGrViewFontFamily.Size = new System.Drawing.Size(134, 22);
            this.menuGrViewFontFamily.Text = "Семейство";
            // 
            // menuGrViewFont1
            // 
            this.menuGrViewFont1.Name = "menuGrViewFont1";
            this.menuGrViewFont1.Size = new System.Drawing.Size(178, 22);
            this.menuGrViewFont1.Text = "Arial";
            // 
            // menuGrViewFont2
            // 
            this.menuGrViewFont2.Checked = true;
            this.menuGrViewFont2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewFont2.Name = "menuGrViewFont2";
            this.menuGrViewFont2.Size = new System.Drawing.Size(178, 22);
            this.menuGrViewFont2.Text = "Microsoft Sans Serif";
            // 
            // menuGrViewFont3
            // 
            this.menuGrViewFont3.Name = "menuGrViewFont3";
            this.menuGrViewFont3.Size = new System.Drawing.Size(178, 22);
            this.menuGrViewFont3.Text = "Times New Roman";
            // 
            // menuGrViewFont4
            // 
            this.menuGrViewFont4.Name = "menuGrViewFont4";
            this.menuGrViewFont4.Size = new System.Drawing.Size(178, 22);
            this.menuGrViewFont4.Text = "Verdana";
            // 
            // menuGrViewFontSize
            // 
            this.menuGrViewFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrViewFontSizeAuto,
            this.menuGrViewFontSizeCustom});
            this.menuGrViewFontSize.Name = "menuGrViewFontSize";
            this.menuGrViewFontSize.Size = new System.Drawing.Size(134, 22);
            this.menuGrViewFontSize.Text = "Размер";
            // 
            // menuGrViewFontSizeAuto
            // 
            this.menuGrViewFontSizeAuto.Checked = true;
            this.menuGrViewFontSizeAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuGrViewFontSizeAuto.Name = "menuGrViewFontSizeAuto";
            this.menuGrViewFontSizeAuto.Size = new System.Drawing.Size(240, 22);
            this.menuGrViewFontSizeAuto.Text = "Авто";
            // 
            // menuGrViewFontSizeCustom
            // 
            this.menuGrViewFontSizeCustom.Name = "menuGrViewFontSizeCustom";
            this.menuGrViewFontSizeCustom.Size = new System.Drawing.Size(180, 23);
            this.menuGrViewFontSizeCustom.Text = "14";
            // 
            // menuGrNewWindow
            // 
            this.menuGrNewWindow.Enabled = false;
            this.menuGrNewWindow.Name = "menuGrNewWindow";
            this.menuGrNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuGrNewWindow.Size = new System.Drawing.Size(250, 22);
            this.menuGrNewWindow.Text = "Открыть в новом окне...";
            this.menuGrNewWindow.Click += new System.EventHandler(this.menuGrNewWindow_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpInfo,
            this.menuHelpVersion});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 23);
            this.menuHelp.Text = "Справка";
            // 
            // menuHelpInfo
            // 
            this.menuHelpInfo.Name = "menuHelpInfo";
            this.menuHelpInfo.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpInfo.Size = new System.Drawing.Size(231, 22);
            this.menuHelpInfo.Text = "Краткая информация";
            this.menuHelpInfo.Click += new System.EventHandler(this.menuHelpInfo_Click);
            // 
            // menuHelpVersion
            // 
            this.menuHelpVersion.Name = "menuHelpVersion";
            this.menuHelpVersion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.menuHelpVersion.Size = new System.Drawing.Size(231, 22);
            this.menuHelpVersion.Text = "О FrameViewGraph...";
            this.menuHelpVersion.Click += new System.EventHandler(this.menuHelpVersion_Click);
            // 
            // menuName
            // 
            this.menuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(600, 23);
            this.menuName.TextChanged += new System.EventHandler(this.menuName_TextChanged);
            // 
            // menuCmbBx
            // 
            this.menuCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCmbBx.Name = "menuCmbBx";
            this.menuCmbBx.Size = new System.Drawing.Size(300, 23);
            this.menuCmbBx.SelectedIndexChanged += new System.EventHandler(this.menuCmbBx_SelectedIndexChanged);
            // 
            // statusStr
            // 
            this.statusStr.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStatus});
            this.statusStr.Location = new System.Drawing.Point(0, 539);
            this.statusStr.Name = "statusStr";
            this.statusStr.Size = new System.Drawing.Size(1184, 22);
            this.statusStr.TabIndex = 19;
            this.statusStr.Text = "statusStr";
            // 
            // statusStatus
            // 
            this.statusStatus.Name = "statusStatus";
            this.statusStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grpBxInfo
            // 
            this.grpBxInfo.Controls.Add(this.lblGpuFreq);
            this.grpBxInfo.Controls.Add(this.labelGpuFreq);
            this.grpBxInfo.Controls.Add(this.lblCpuFreq);
            this.grpBxInfo.Controls.Add(this.labelCpuFreq);
            this.grpBxInfo.Controls.Add(this.lbl01pc);
            this.grpBxInfo.Controls.Add(this.lbl1pc);
            this.grpBxInfo.Controls.Add(this.lbl10pc);
            this.grpBxInfo.Controls.Add(this.lbl50pc);
            this.grpBxInfo.Controls.Add(this.lblModeFPS);
            this.grpBxInfo.Controls.Add(this.lblAvgFPS);
            this.grpBxInfo.Controls.Add(this.lblGpuPower);
            this.grpBxInfo.Controls.Add(this.lblGpuTemp);
            this.grpBxInfo.Controls.Add(this.lblGpuUsage);
            this.grpBxInfo.Controls.Add(this.lblCpuPower);
            this.grpBxInfo.Controls.Add(this.lblCpuTemp);
            this.grpBxInfo.Controls.Add(this.lblCpuUsage);
            this.grpBxInfo.Controls.Add(this.lblGpuName);
            this.grpBxInfo.Controls.Add(this.lblCpuName);
            this.grpBxInfo.Controls.Add(this.lblApi);
            this.grpBxInfo.Controls.Add(this.lblApplication);
            this.grpBxInfo.Controls.Add(this.label10pc);
            this.grpBxInfo.Controls.Add(this.labelGpuTemp);
            this.grpBxInfo.Controls.Add(this.labelGpuPower);
            this.grpBxInfo.Controls.Add(this.labelGpuUsage);
            this.grpBxInfo.Controls.Add(this.labelGpuName);
            this.grpBxInfo.Controls.Add(this.labelCpuTemp);
            this.grpBxInfo.Controls.Add(this.labelCpuPower);
            this.grpBxInfo.Controls.Add(this.label01pc);
            this.grpBxInfo.Controls.Add(this.label1pc);
            this.grpBxInfo.Controls.Add(this.label50pc);
            this.grpBxInfo.Controls.Add(this.labelModeFPS);
            this.grpBxInfo.Controls.Add(this.labelAvgFPS);
            this.grpBxInfo.Controls.Add(this.labelApi);
            this.grpBxInfo.Controls.Add(this.labelCpuUsage);
            this.grpBxInfo.Controls.Add(this.labelCpuName);
            this.grpBxInfo.Controls.Add(this.labelApplication);
            this.grpBxInfo.Location = new System.Drawing.Point(878, 30);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(294, 495);
            this.grpBxInfo.TabIndex = 20;
            this.grpBxInfo.TabStop = false;
            this.grpBxInfo.Text = "Информация про тест";
            // 
            // lblGpuFreq
            // 
            this.lblGpuFreq.Location = new System.Drawing.Point(172, 222);
            this.lblGpuFreq.Name = "lblGpuFreq";
            this.lblGpuFreq.Size = new System.Drawing.Size(116, 20);
            this.lblGpuFreq.TabIndex = 37;
            this.lblGpuFreq.Text = "-";
            this.lblGpuFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGpuFreq
            // 
            this.labelGpuFreq.Location = new System.Drawing.Point(6, 222);
            this.labelGpuFreq.Name = "labelGpuFreq";
            this.labelGpuFreq.Size = new System.Drawing.Size(160, 20);
            this.labelGpuFreq.TabIndex = 36;
            this.labelGpuFreq.Text = "Частота GPU:";
            // 
            // lblCpuFreq
            // 
            this.lblCpuFreq.Location = new System.Drawing.Point(172, 102);
            this.lblCpuFreq.Name = "lblCpuFreq";
            this.lblCpuFreq.Size = new System.Drawing.Size(116, 20);
            this.lblCpuFreq.TabIndex = 35;
            this.lblCpuFreq.Text = "-";
            this.lblCpuFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCpuFreq
            // 
            this.labelCpuFreq.Location = new System.Drawing.Point(6, 102);
            this.labelCpuFreq.Name = "labelCpuFreq";
            this.labelCpuFreq.Size = new System.Drawing.Size(160, 20);
            this.labelCpuFreq.TabIndex = 34;
            this.labelCpuFreq.Text = "Частота CPU:";
            // 
            // lbl01pc
            // 
            this.lbl01pc.Location = new System.Drawing.Point(172, 422);
            this.lbl01pc.Name = "lbl01pc";
            this.lbl01pc.Size = new System.Drawing.Size(116, 20);
            this.lbl01pc.TabIndex = 33;
            this.lbl01pc.Text = "-";
            this.lbl01pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1pc
            // 
            this.lbl1pc.Location = new System.Drawing.Point(172, 402);
            this.lbl1pc.Name = "lbl1pc";
            this.lbl1pc.Size = new System.Drawing.Size(116, 20);
            this.lbl1pc.TabIndex = 32;
            this.lbl1pc.Text = "-";
            this.lbl1pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl10pc
            // 
            this.lbl10pc.Location = new System.Drawing.Point(172, 382);
            this.lbl10pc.Name = "lbl10pc";
            this.lbl10pc.Size = new System.Drawing.Size(116, 20);
            this.lbl10pc.TabIndex = 31;
            this.lbl10pc.Text = "-";
            this.lbl10pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl50pc
            // 
            this.lbl50pc.Location = new System.Drawing.Point(172, 362);
            this.lbl50pc.Name = "lbl50pc";
            this.lbl50pc.Size = new System.Drawing.Size(116, 20);
            this.lbl50pc.TabIndex = 30;
            this.lbl50pc.Text = "-";
            this.lbl50pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModeFPS
            // 
            this.lblModeFPS.Location = new System.Drawing.Point(172, 342);
            this.lblModeFPS.Name = "lblModeFPS";
            this.lblModeFPS.Size = new System.Drawing.Size(116, 20);
            this.lblModeFPS.TabIndex = 29;
            this.lblModeFPS.Text = "-";
            this.lblModeFPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgFPS
            // 
            this.lblAvgFPS.Location = new System.Drawing.Point(172, 322);
            this.lblAvgFPS.Name = "lblAvgFPS";
            this.lblAvgFPS.Size = new System.Drawing.Size(116, 20);
            this.lblAvgFPS.TabIndex = 28;
            this.lblAvgFPS.Text = "-";
            this.lblAvgFPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGpuPower
            // 
            this.lblGpuPower.Location = new System.Drawing.Point(172, 282);
            this.lblGpuPower.Name = "lblGpuPower";
            this.lblGpuPower.Size = new System.Drawing.Size(116, 20);
            this.lblGpuPower.TabIndex = 27;
            this.lblGpuPower.Text = "-";
            this.lblGpuPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGpuTemp
            // 
            this.lblGpuTemp.Location = new System.Drawing.Point(172, 262);
            this.lblGpuTemp.Name = "lblGpuTemp";
            this.lblGpuTemp.Size = new System.Drawing.Size(116, 20);
            this.lblGpuTemp.TabIndex = 26;
            this.lblGpuTemp.Text = "-";
            this.lblGpuTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGpuUsage
            // 
            this.lblGpuUsage.Location = new System.Drawing.Point(172, 242);
            this.lblGpuUsage.Name = "lblGpuUsage";
            this.lblGpuUsage.Size = new System.Drawing.Size(116, 20);
            this.lblGpuUsage.TabIndex = 25;
            this.lblGpuUsage.Text = "-";
            this.lblGpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuPower
            // 
            this.lblCpuPower.Location = new System.Drawing.Point(172, 162);
            this.lblCpuPower.Name = "lblCpuPower";
            this.lblCpuPower.Size = new System.Drawing.Size(116, 20);
            this.lblCpuPower.TabIndex = 24;
            this.lblCpuPower.Text = "-";
            this.lblCpuPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuTemp
            // 
            this.lblCpuTemp.Location = new System.Drawing.Point(172, 142);
            this.lblCpuTemp.Name = "lblCpuTemp";
            this.lblCpuTemp.Size = new System.Drawing.Size(116, 20);
            this.lblCpuTemp.TabIndex = 23;
            this.lblCpuTemp.Text = "-";
            this.lblCpuTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.Location = new System.Drawing.Point(172, 122);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(116, 20);
            this.lblCpuUsage.TabIndex = 22;
            this.lblCpuUsage.Text = "-";
            this.lblCpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGpuName
            // 
            this.lblGpuName.Location = new System.Drawing.Point(62, 202);
            this.lblGpuName.Name = "lblGpuName";
            this.lblGpuName.Size = new System.Drawing.Size(226, 20);
            this.lblGpuName.TabIndex = 21;
            this.lblGpuName.Text = "-";
            this.lblGpuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuName
            // 
            this.lblCpuName.Location = new System.Drawing.Point(62, 82);
            this.lblCpuName.Name = "lblCpuName";
            this.lblCpuName.Size = new System.Drawing.Size(226, 20);
            this.lblCpuName.TabIndex = 20;
            this.lblCpuName.Text = "-";
            this.lblCpuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApi
            // 
            this.lblApi.Location = new System.Drawing.Point(132, 42);
            this.lblApi.Name = "lblApi";
            this.lblApi.Size = new System.Drawing.Size(156, 20);
            this.lblApi.TabIndex = 19;
            this.lblApi.Text = "-";
            this.lblApi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplication
            // 
            this.lblApplication.Location = new System.Drawing.Point(132, 22);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(156, 20);
            this.lblApplication.TabIndex = 18;
            this.lblApplication.Text = "-";
            this.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10pc
            // 
            this.label10pc.Location = new System.Drawing.Point(6, 382);
            this.label10pc.Name = "label10pc";
            this.label10pc.Size = new System.Drawing.Size(140, 20);
            this.label10pc.TabIndex = 17;
            this.label10pc.Text = "10%:";
            // 
            // labelGpuTemp
            // 
            this.labelGpuTemp.Location = new System.Drawing.Point(6, 262);
            this.labelGpuTemp.Name = "labelGpuTemp";
            this.labelGpuTemp.Size = new System.Drawing.Size(160, 20);
            this.labelGpuTemp.TabIndex = 16;
            this.labelGpuTemp.Text = "Температура GPU:";
            // 
            // labelGpuPower
            // 
            this.labelGpuPower.Location = new System.Drawing.Point(6, 282);
            this.labelGpuPower.Name = "labelGpuPower";
            this.labelGpuPower.Size = new System.Drawing.Size(160, 20);
            this.labelGpuPower.TabIndex = 15;
            this.labelGpuPower.Text = "Потребление GPU:";
            // 
            // labelGpuUsage
            // 
            this.labelGpuUsage.Location = new System.Drawing.Point(6, 242);
            this.labelGpuUsage.Name = "labelGpuUsage";
            this.labelGpuUsage.Size = new System.Drawing.Size(160, 20);
            this.labelGpuUsage.TabIndex = 14;
            this.labelGpuUsage.Text = "Загрузка GPU:";
            // 
            // labelGpuName
            // 
            this.labelGpuName.Location = new System.Drawing.Point(6, 202);
            this.labelGpuName.Name = "labelGpuName";
            this.labelGpuName.Size = new System.Drawing.Size(50, 20);
            this.labelGpuName.TabIndex = 13;
            this.labelGpuName.Text = "GPU:";
            // 
            // labelCpuTemp
            // 
            this.labelCpuTemp.Location = new System.Drawing.Point(6, 142);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(160, 20);
            this.labelCpuTemp.TabIndex = 12;
            this.labelCpuTemp.Text = "Температура CPU:";
            // 
            // labelCpuPower
            // 
            this.labelCpuPower.Location = new System.Drawing.Point(6, 162);
            this.labelCpuPower.Name = "labelCpuPower";
            this.labelCpuPower.Size = new System.Drawing.Size(160, 20);
            this.labelCpuPower.TabIndex = 11;
            this.labelCpuPower.Text = "Потребление CPU:";
            // 
            // label01pc
            // 
            this.label01pc.Location = new System.Drawing.Point(6, 422);
            this.label01pc.Name = "label01pc";
            this.label01pc.Size = new System.Drawing.Size(140, 20);
            this.label01pc.TabIndex = 10;
            this.label01pc.Text = "0.1%:";
            // 
            // label1pc
            // 
            this.label1pc.Location = new System.Drawing.Point(6, 402);
            this.label1pc.Name = "label1pc";
            this.label1pc.Size = new System.Drawing.Size(140, 20);
            this.label1pc.TabIndex = 9;
            this.label1pc.Text = "1%:";
            // 
            // label50pc
            // 
            this.label50pc.Location = new System.Drawing.Point(6, 362);
            this.label50pc.Name = "label50pc";
            this.label50pc.Size = new System.Drawing.Size(140, 20);
            this.label50pc.TabIndex = 8;
            this.label50pc.Text = "50%:";
            // 
            // labelModeFPS
            // 
            this.labelModeFPS.Location = new System.Drawing.Point(6, 342);
            this.labelModeFPS.Name = "labelModeFPS";
            this.labelModeFPS.Size = new System.Drawing.Size(140, 20);
            this.labelModeFPS.TabIndex = 7;
            this.labelModeFPS.Text = "Модальный FPS:";
            // 
            // labelAvgFPS
            // 
            this.labelAvgFPS.Location = new System.Drawing.Point(6, 322);
            this.labelAvgFPS.Name = "labelAvgFPS";
            this.labelAvgFPS.Size = new System.Drawing.Size(140, 20);
            this.labelAvgFPS.TabIndex = 6;
            this.labelAvgFPS.Text = "Средний FPS:";
            // 
            // labelApi
            // 
            this.labelApi.Location = new System.Drawing.Point(6, 42);
            this.labelApi.Name = "labelApi";
            this.labelApi.Size = new System.Drawing.Size(120, 20);
            this.labelApi.TabIndex = 3;
            this.labelApi.Text = "API:";
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.Location = new System.Drawing.Point(6, 122);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(160, 20);
            this.labelCpuUsage.TabIndex = 2;
            this.labelCpuUsage.Text = "Загрузка CPU:";
            // 
            // labelCpuName
            // 
            this.labelCpuName.Location = new System.Drawing.Point(6, 82);
            this.labelCpuName.Name = "labelCpuName";
            this.labelCpuName.Size = new System.Drawing.Size(50, 20);
            this.labelCpuName.TabIndex = 1;
            this.labelCpuName.Text = "CPU:";
            // 
            // labelApplication
            // 
            this.labelApplication.Location = new System.Drawing.Point(6, 22);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(120, 20);
            this.labelApplication.TabIndex = 0;
            this.labelApplication.Text = "Программа:";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.grpBxInfo);
            this.Controls.Add(this.statusStr);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).EndInit();
            this.menuStr.ResumeLayout(false);
            this.menuStr.PerformLayout();
            this.statusStr.ResumeLayout(false);
            this.statusStr.PerformLayout();
            this.grpBxInfo.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem menuGrViewLegend;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpInfo;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVersion;
        private System.Windows.Forms.StatusStrip statusStr;
        private System.Windows.Forms.ToolStripStatusLabel statusStatus;
        private System.Windows.Forms.ToolStripTextBox menuName;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewAxis;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFont;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFontFamily;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFont1;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFont2;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFont3;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFont4;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFontSize;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewFontSizeAuto;
        private System.Windows.Forms.ToolStripTextBox menuGrViewFontSizeCustom;
        private System.Windows.Forms.ToolStripMenuItem menuGrFilter;
        private System.Windows.Forms.ToolStripMenuItem menuGrFilterNo;
        private System.Windows.Forms.ToolStripMenuItem menuGrFilter1;
        private System.Windows.Forms.ToolStripMenuItem menuGrFilter2;
        private System.Windows.Forms.ToolStripMenuItem menuGrFilter3;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Label labelCpuUsage;
        private System.Windows.Forms.Label labelCpuName;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.Label labelApi;
        private System.Windows.Forms.Label label01pc;
        private System.Windows.Forms.Label label1pc;
        private System.Windows.Forms.Label label50pc;
        private System.Windows.Forms.Label labelModeFPS;
        private System.Windows.Forms.Label labelAvgFPS;
        private System.Windows.Forms.Label labelCpuTemp;
        private System.Windows.Forms.Label labelCpuPower;
        private System.Windows.Forms.Label labelGpuTemp;
        private System.Windows.Forms.Label labelGpuPower;
        private System.Windows.Forms.Label labelGpuUsage;
        private System.Windows.Forms.Label labelGpuName;
        private System.Windows.Forms.Label lblCpuPower;
        private System.Windows.Forms.Label lblCpuTemp;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label lblGpuName;
        private System.Windows.Forms.Label lblCpuName;
        private System.Windows.Forms.Label lblApi;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label label10pc;
        private System.Windows.Forms.Label lblGpuPower;
        private System.Windows.Forms.Label lblGpuTemp;
        private System.Windows.Forms.Label lblGpuUsage;
        private System.Windows.Forms.Label lblAvgFPS;
        private System.Windows.Forms.Label lbl01pc;
        private System.Windows.Forms.Label lbl1pc;
        private System.Windows.Forms.Label lbl10pc;
        private System.Windows.Forms.Label lbl50pc;
        private System.Windows.Forms.Label lblModeFPS;
        private System.Windows.Forms.Label lblGpuFreq;
        private System.Windows.Forms.Label labelGpuFreq;
        private System.Windows.Forms.Label lblCpuFreq;
        private System.Windows.Forms.Label labelCpuFreq;
        private System.Windows.Forms.ToolStripComboBox menuCmbBx;
        private System.Windows.Forms.ToolStripMenuItem menuGraph5;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram1;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram2;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram3;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram4;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram5;
        private System.Windows.Forms.ToolStripMenuItem menuGrViewDiagram6;
        private System.Windows.Forms.ToolStripMenuItem menuGraph6;
    }
}

