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
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxNameTest = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkListFile = new System.Windows.Forms.CheckedListBox();
            this.rdBtn1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn4 = new System.Windows.Forms.RadioButton();
            this.rdBtn3 = new System.Windows.Forms.RadioButton();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxCustomY = new System.Windows.Forms.TextBox();
            this.txtBxCustomX = new System.Windows.Forms.TextBox();
            this.rdBtnCustom = new System.Windows.Forms.RadioButton();
            this.rdBtnUHD = new System.Windows.Forms.RadioButton();
            this.rdBtnQHD = new System.Windows.Forms.RadioButton();
            this.rdBtnFullHD = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewWindow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chrMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название теста:";
            // 
            // txtBxNameTest
            // 
            this.txtBxNameTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxNameTest.Location = new System.Drawing.Point(147, 10);
            this.txtBxNameTest.Name = "txtBxNameTest";
            this.txtBxNameTest.Size = new System.Drawing.Size(724, 26);
            this.txtBxNameTest.TabIndex = 2;
            this.txtBxNameTest.TextChanged += new System.EventHandler(this.txtBxNameTest_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(731, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить файл";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkListFile
            // 
            this.chkListFile.CheckOnClick = true;
            this.chkListFile.FormattingEnabled = true;
            this.chkListFile.Location = new System.Drawing.Point(600, 190);
            this.chkListFile.Name = "chkListFile";
            this.chkListFile.Size = new System.Drawing.Size(271, 298);
            this.chkListFile.TabIndex = 5;
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Checked = true;
            this.rdBtn1.Location = new System.Drawing.Point(5, 25);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(153, 24);
            this.rdBtn1.TabIndex = 6;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "Времени кадров";
            this.rdBtn1.UseVisualStyleBackColor = true;
            this.rdBtn1.CheckedChanged += new System.EventHandler(this.rdBtn1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtn2);
            this.groupBox1.Controls.Add(this.rdBtn4);
            this.groupBox1.Controls.Add(this.rdBtn3);
            this.groupBox1.Controls.Add(this.rdBtn1);
            this.groupBox1.Location = new System.Drawing.Point(147, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тип графика";
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(5, 55);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(160, 24);
            this.rdBtn2.TabIndex = 9;
            this.rdBtn2.Text = "Кадров в секунду";
            this.rdBtn2.UseVisualStyleBackColor = true;
            this.rdBtn2.CheckedChanged += new System.EventHandler(this.rdBtn2_CheckedChanged);
            // 
            // rdBtn4
            // 
            this.rdBtn4.AutoSize = true;
            this.rdBtn4.Location = new System.Drawing.Point(5, 115);
            this.rdBtn4.Name = "rdBtn4";
            this.rdBtn4.Size = new System.Drawing.Size(249, 24);
            this.rdBtn4.TabIndex = 8;
            this.rdBtn4.Text = "Распределения вероятности";
            this.rdBtn4.UseVisualStyleBackColor = true;
            this.rdBtn4.CheckedChanged += new System.EventHandler(this.rdBtn4_CheckedChanged);
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Location = new System.Drawing.Point(5, 85);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(213, 24);
            this.rdBtn3.TabIndex = 7;
            this.rdBtn3.Text = "Плотности вероятности";
            this.rdBtn3.UseVisualStyleBackColor = true;
            this.rdBtn3.CheckedChanged += new System.EventHandler(this.rdBtn3_CheckedChanged);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "CSV files (*.csv)|*.csv";
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(600, 493);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(125, 60);
            this.btnDeleteList.TabIndex = 8;
            this.btnDeleteList.Text = "Удалить выбранные";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(451, 493);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(143, 60);
            this.btnInvert.TabIndex = 9;
            this.btnInvert.Text = "Инвертировать выбранные";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxCustomY);
            this.groupBox2.Controls.Add(this.txtBxCustomX);
            this.groupBox2.Controls.Add(this.rdBtnCustom);
            this.groupBox2.Controls.Add(this.rdBtnUHD);
            this.groupBox2.Controls.Add(this.rdBtnQHD);
            this.groupBox2.Controls.Add(this.rdBtnFullHD);
            this.groupBox2.Location = new System.Drawing.Point(600, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите разрешение";
            // 
            // txtBxCustomY
            // 
            this.txtBxCustomY.Enabled = false;
            this.txtBxCustomY.Location = new System.Drawing.Point(206, 114);
            this.txtBxCustomY.Name = "txtBxCustomY";
            this.txtBxCustomY.Size = new System.Drawing.Size(57, 26);
            this.txtBxCustomY.TabIndex = 11;
            this.txtBxCustomY.Text = "900";
            this.txtBxCustomY.TextChanged += new System.EventHandler(this.txtBxCustomY_TextChanged);
            // 
            // txtBxCustomX
            // 
            this.txtBxCustomX.Enabled = false;
            this.txtBxCustomX.Location = new System.Drawing.Point(143, 114);
            this.txtBxCustomX.Name = "txtBxCustomX";
            this.txtBxCustomX.Size = new System.Drawing.Size(57, 26);
            this.txtBxCustomX.TabIndex = 10;
            this.txtBxCustomX.Text = "1600";
            this.txtBxCustomX.TextChanged += new System.EventHandler(this.txtBxCustomX_TextChanged);
            // 
            // rdBtnCustom
            // 
            this.rdBtnCustom.AutoSize = true;
            this.rdBtnCustom.Location = new System.Drawing.Point(6, 115);
            this.rdBtnCustom.Name = "rdBtnCustom";
            this.rdBtnCustom.Size = new System.Drawing.Size(126, 24);
            this.rdBtnCustom.TabIndex = 9;
            this.rdBtnCustom.Text = "Custom (X;Y):";
            this.rdBtnCustom.UseVisualStyleBackColor = true;
            this.rdBtnCustom.CheckedChanged += new System.EventHandler(this.rdBtnCustom_CheckedChanged);
            // 
            // rdBtnUHD
            // 
            this.rdBtnUHD.AutoSize = true;
            this.rdBtnUHD.Location = new System.Drawing.Point(6, 85);
            this.rdBtnUHD.Name = "rdBtnUHD";
            this.rdBtnUHD.Size = new System.Drawing.Size(168, 24);
            this.rdBtnUHD.TabIndex = 8;
            this.rdBtnUHD.Text = "UHD    (3840x2160)";
            this.rdBtnUHD.UseVisualStyleBackColor = true;
            this.rdBtnUHD.CheckedChanged += new System.EventHandler(this.rdBtnUHD_CheckedChanged);
            // 
            // rdBtnQHD
            // 
            this.rdBtnQHD.Location = new System.Drawing.Point(6, 55);
            this.rdBtnQHD.Name = "rdBtnQHD";
            this.rdBtnQHD.Size = new System.Drawing.Size(213, 24);
            this.rdBtnQHD.TabIndex = 7;
            this.rdBtnQHD.Text = "QHD    (2560x1440)";
            this.rdBtnQHD.UseVisualStyleBackColor = true;
            this.rdBtnQHD.CheckedChanged += new System.EventHandler(this.rdBtnQHD_CheckedChanged);
            // 
            // rdBtnFullHD
            // 
            this.rdBtnFullHD.AutoSize = true;
            this.rdBtnFullHD.Checked = true;
            this.rdBtnFullHD.Location = new System.Drawing.Point(6, 25);
            this.rdBtnFullHD.Name = "rdBtnFullHD";
            this.rdBtnFullHD.Size = new System.Drawing.Size(169, 24);
            this.rdBtnFullHD.TabIndex = 6;
            this.rdBtnFullHD.TabStop = true;
            this.rdBtnFullHD.Text = "FullHD (1920x1080)";
            this.rdBtnFullHD.UseVisualStyleBackColor = true;
            this.rdBtnFullHD.CheckedChanged += new System.EventHandler(this.rdBtnFullHD_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 60);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить как...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewWindow
            // 
            this.btnNewWindow.Location = new System.Drawing.Point(161, 494);
            this.btnNewWindow.Name = "btnNewWindow";
            this.btnNewWindow.Size = new System.Drawing.Size(135, 60);
            this.btnNewWindow.TabIndex = 12;
            this.btnNewWindow.Text = "Открыть в новом окне";
            this.btnNewWindow.UseVisualStyleBackColor = true;
            this.btnNewWindow.Click += new System.EventHandler(this.btnNewWindow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Настройки внешнего вида";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(17, 52);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(129, 60);
            this.btnBuild.TabIndex = 14;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 122);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 60);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chrMain
            // 
            legend3.Name = "Legend1";
            this.chrMain.Legends.Add(legend3);
            this.chrMain.Location = new System.Drawing.Point(12, 192);
            this.chrMain.Name = "chrMain";
            this.chrMain.Size = new System.Drawing.Size(582, 295);
            this.chrMain.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.chrMain);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewWindow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxNameTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkListFile);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FVG v.0.1.1 by volkovskey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNameTest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox chkListFile;
        private System.Windows.Forms.RadioButton rdBtn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtn3;
        private System.Windows.Forms.RadioButton rdBtn4;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnUHD;
        private System.Windows.Forms.RadioButton rdBtnQHD;
        private System.Windows.Forms.RadioButton rdBtnFullHD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewWindow;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.RadioButton rdBtn2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMain;
        private System.Windows.Forms.RadioButton rdBtnCustom;
        private System.Windows.Forms.TextBox txtBxCustomX;
        private System.Windows.Forms.TextBox txtBxCustomY;
    }
}

