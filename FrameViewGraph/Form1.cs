using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrameViewGraph
{
    public partial class frmMain : Form
    {
        private String nameOfTest = "";
        private Byte typeOfGraph = 1;
        private Int16 resolutionWidth = 1920;
        private Int16 resolutionHeight = 1080;
        private List<String> filesName = new List<string>();
        private List<Array> parsedData = new List<Array>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK && !chkListFile.Items.Contains(openFileDlg.SafeFileName))
            {
                String frmText = this.Text;
                this.Text = frmText + "              Идет загрузка данных с файла";
                chkListFile.Items.Add(openFileDlg.SafeFileName);
                parsedData.Add(openCSV(openFileDlg.FileName));
                filesName.Add(openFileDlg.SafeFileName);
                this.Text = frmText;
            }
            else if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Нельзя добавлять файлы с одинаковым названием", "Ошибка");
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            if (chkListFile.Items.Count != 0)
            {
                if (chkListFile.CheckedItems.Count != 0)
                {
                    for (int i = chkListFile.Items.Count - 1; i >= 0; i--)
                    {
                        if (chkListFile.GetItemChecked(i))
                        {
                            int index = filesName.IndexOf(chkListFile.Items[i].ToString());
                            chkListFile.Items.RemoveAt(i);
                            filesName.RemoveAt(index);
                            parsedData.RemoveAt(index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Нет выделенных файлов.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Нет открытых файлов.", "Ошибка");
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (chkListFile.Items.Count != 0)
            {
                for (int i = 0; i < chkListFile.Items.Count; i++)
                {
                    chkListFile.SetItemChecked(i, !chkListFile.GetItemChecked(i));
                }
            }
            else
            {
                MessageBox.Show("Нет открытых файлов.", "Ошибка");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
        }

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int startedBorderWidth = chrMain.Series[0].BorderWidth;
            Font startedFont = chrMain.Series[0].Font;
            Font newFont = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 12);
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].BorderWidth = (int)Math.Round(resolutionWidth * resolutionHeight / 2000000.0);
            }
            chrMain.ChartAreas[0].AxisX.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisY.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisX.TitleFont = newFont;
            chrMain.ChartAreas[0].AxisY.TitleFont = newFont;
            chrMain.Titles[0].Font = newFont;
            chrMain.Legends[0].Font = newFont;
            chrMain.Titles.Add(this.Text);
            chrMain.Titles[0].Font = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 8);
            chrMain.Location = new Point(-10000, -10000);
            chrMain.Width = resolutionWidth;
            chrMain.Height = resolutionHeight;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить изображение как ...";
                sfd.Filter = "*.jpg|*.jpg;|*.png|*.png;|*.bmp|*.bmp";
                sfd.AddExtension = true;
                sfd.FileName = nameOfTest;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                        case 2: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                        case 3: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                    }
                }
            }
            chrMain.Width = 582;
            chrMain.Height = 295;
            chrMain.Location = new System.Drawing.Point(12, 190);
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].BorderWidth = startedBorderWidth;
            }
            chrMain.ChartAreas[0].AxisX.LabelStyle.Font = startedFont;
            chrMain.ChartAreas[0].AxisY.LabelStyle.Font = startedFont;
            chrMain.ChartAreas[0].AxisX.TitleFont = startedFont;
            chrMain.ChartAreas[0].AxisY.TitleFont = startedFont;
            chrMain.Titles[0].Font = startedFont;
            chrMain.Legends[0].Font = startedFont;
            chrMain.Titles.RemoveAt(1);
        }

        public static T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();

            Type control = controlToClone.GetType();
            PropertyInfo[] info = control.GetProperties();
            object p = control.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, controlToClone, null);
            foreach (PropertyInfo pi in info)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            menuFileSaveAs.Enabled = true;
            if (typeOfGraph == 1)
            {
                graphFrameTime();
            }
            else if (typeOfGraph == 2)
            {
                graphFPS();
            }
            else if (typeOfGraph == 3)
            {
                graphProbabilityDensity();
            }
            else if (typeOfGraph == 4)
            {
                menuFileSaveAs.Enabled = false;
                MessageBox.Show("Не доступно", "Предупреждение");
            }
            else
            {
                menuFileSaveAs.Enabled = false;
                MessageBox.Show("Ошибка выбора типа графика", "Ошибка");
            }
        }

        private void graphFrameTime()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax1 = new Axis();
            ax1.Title = "Время (мс)";
            chrMain.ChartAreas[0].AxisX = ax1;
            Axis ay1 = new Axis();
            ay1.Title = "Время кадра (мс)";
            chrMain.ChartAreas[0].AxisY = ay1;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[parsedData[i].GetLength(0), parsedData[i].GetLength(1)];
                    Array.Copy((float[,])parsedData[i], data, parsedData[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[1, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                    
                }
            }
        }

        private void graphFPS()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax2 = new Axis();
            ax2.Title = "Время (мс)";
            chrMain.ChartAreas[0].AxisX = ax2;
            Axis ay2 = new Axis();
            ay2.Title = "Кадры в секунду (FPS)";
            chrMain.ChartAreas[0].AxisY = ay2;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[parsedData[i].GetLength(0), parsedData[i].GetLength(1)];
                    Array.Copy((float[,])parsedData[i], data, parsedData[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;
                    float sum = 0f;
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        data[1, j] = (float)Math.Round(1.0f / data[1, j] * 1000f, 2);
                        sum += data[1, j];
                    }
                    float avg = sum / data.GetLength(1);
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        if (data[1, j] < avg * 3.0) mySeriesOfPoint.Points.AddXY(data[0, j], data[1, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphProbabilityDensity()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax3 = new Axis();
            ax3.Title = "Кадры в секунду (FPS)";
            chrMain.ChartAreas[0].AxisX = ax3;
            Axis ay3 = new Axis();
            ay3.Title = "Время (с)";
            chrMain.ChartAreas[0].AxisY = ay3;
            for (int a = 0; a < parsedData.Count; a++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[a]))
                {
                    float[,] data = new float[parsedData[a].GetLength(0), parsedData[a].GetLength(1)];
                    Array.Copy((float[,])parsedData[a], data, parsedData[a].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[a];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;
                    int[] FPS = new int[data.GetLength(1)];
                    for (int k = 0; k < data.GetLength(1); k++)
                    {
                        FPS[k] = (int)Math.Round(1.0f / data[1, k] * 1000f);
                    }
                    Array.Sort(FPS);
                    Dictionary<int, int> Count = new Dictionary<int, int>();
                    for (int i = 0; i < FPS.Length;)
                    {
                        int j;
                        for (j = i + 1; j < FPS.Length; j++)
                        {
                            if (FPS[i] != FPS[j])
                            {
                                if (j - i > 3 && FPS[i] > 0) Count.Add(FPS[i], j - i);
                                i = j;
                                break;
                            }
                        }
                        if (j == FPS.Length)
                        {
                            if (j - i > 3 && FPS[i] > 0) Count.Add(FPS[i], j - i);
                            break;
                        }
                    }
                    foreach (var fps in Count)
                    {
                        mySeriesOfPoint.Points.AddXY(fps.Key, fps.Value);
                        Console.WriteLine(fps.Key + " " + fps.Value);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
            
        }


        private float[,] openCSV(String path)
        {
            //0 - Time
            //1 - FrameTime
            float[,] result = new float[2, 0];
            var reader = new StreamReader(File.OpenRead(path));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (values[14].Contains("."))
                {
                    result = ResizeArray(result);
                    result[0, result.GetLength(1) - 1] = (float)Math.Round(float.Parse(values[12]) * 1000f);
                    result[1, result.GetLength(1) - 1] = float.Parse(values[14]);
                }
            }
            float startTime = result[0, 0];
            for (int i = 0; i < result.GetLength(1); i++)
            {
                result[0, i] -= startTime;
            }
            return result;
        }

        private static float[,] ResizeArray(float[,] arr)
        {
            float[,] newArr = new float[2, arr.GetLength(1) + 1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[i, j] = arr[i, j];
                }
            }
            return newArr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            menuFileSaveAs.Enabled = false;
            cleanChart();
        }

        private void cleanChart()
        {
            chrMain.Series.Clear();
            chrMain.ChartAreas.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            menuGrViewNameValue.Text = nameOfTest;
            statusName.Text = nameOfTest;
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int startedBorderWidth = chrMain.Series[0].BorderWidth;
            Font startedFont = chrMain.Series[0].Font;
            Font newFont = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 12);
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].BorderWidth = (int)Math.Round(resolutionWidth * resolutionHeight / 2000000.0);
            }
            chrMain.ChartAreas[0].AxisX.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisY.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisX.TitleFont = newFont;
            chrMain.ChartAreas[0].AxisY.TitleFont = newFont;
            chrMain.Titles[0].Font = newFont;
            chrMain.Legends[0].Font = newFont;
            chrMain.Titles.Add(this.Text);
            chrMain.Titles[0].Font = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 8);
            chrMain.Location = new Point(-10000, -10000);
            chrMain.Width = resolutionWidth;
            chrMain.Height = resolutionHeight;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить изображение как ...";
                sfd.Filter = "*.jpg|*.jpg;|*.png|*.png;|*.bmp|*.bmp";
                sfd.AddExtension = true;
                sfd.FileName = nameOfTest;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                        case 2: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                        case 3: chrMain.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                    }
                }
            }
            chrMain.Width = 582;
            chrMain.Height = 295;
            chrMain.Location = new System.Drawing.Point(12, 190);
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].BorderWidth = startedBorderWidth;
            }
            chrMain.ChartAreas[0].AxisX.LabelStyle.Font = startedFont;
            chrMain.ChartAreas[0].AxisY.LabelStyle.Font = startedFont;
            chrMain.ChartAreas[0].AxisX.TitleFont = startedFont;
            chrMain.ChartAreas[0].AxisY.TitleFont = startedFont;
            chrMain.Titles[0].Font = startedFont;
            chrMain.Legends[0].Font = startedFont;
            chrMain.Titles.RemoveAt(1);
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK && !chkListFile.Items.Contains(openFileDlg.SafeFileName))
            {
                statusStatus.Text = "Идет загрузка данных с файла...";
                chkListFile.Items.Add(openFileDlg.SafeFileName);
                parsedData.Add(openCSV(openFileDlg.FileName));
                filesName.Add(openFileDlg.SafeFileName);
                statusStatus.Text = "Загрузка закончена.";
            }
            else if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Нельзя добавлять файлы с одинаковым названием", "Ошибка");
            }
        }

        private void удалитьВыбранныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void инвертироватьВыбранныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuGraph1_Click(object sender, EventArgs e)
        {
            if (menuGraph1.Checked)
            {
                //Построить
            }
            else
            {
                menuGraph1.Checked = true;
                menuGraph2.Checked = false;
                menuGraph3.Checked = false;
                menuGraph4.Checked = false;
                typeOfGraph = 1;
            }
        }

        private void menuGraph4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
            //if (menuGraph4.Checked)
            //{
            //    //Построить
            //}
            //else
            //{
            //    menuGraph1.Checked = false;
            //    menuGraph2.Checked = false;
            //    menuGraph3.Checked = false;
            //    menuGraph4.Checked = true;
            //    typeOfGraph = 4;
            //}
        }

        private void menuGraph2_Click(object sender, EventArgs e)
        {
            if (menuGraph2.Checked)
            {
                //Построить
            }
            else
            {
                menuGraph1.Checked = false;
                menuGraph2.Checked = true;
                menuGraph3.Checked = false;
                menuGraph4.Checked = false;
                typeOfGraph = 2;
            }
        }

        private void menuGraph3_Click(object sender, EventArgs e)
        {
            if (menuGraph3.Checked)
            {
                //Построить
            }
            else
            {
                menuGraph1.Checked = false;
                menuGraph2.Checked = false;
                menuGraph3.Checked = true;
                menuGraph4.Checked = false;
                typeOfGraph = 3;
            }
        }

        private void menuFileControlDelete_Click(object sender, EventArgs e)
        {
            if (chkListFile.Items.Count != 0)
            {
                if (chkListFile.CheckedItems.Count != 0)
                {
                    for (int i = chkListFile.Items.Count - 1; i >= 0; i--)
                    {
                        if (chkListFile.GetItemChecked(i))
                        {
                            int index = filesName.IndexOf(chkListFile.Items[i].ToString());
                            chkListFile.Items.RemoveAt(i);
                            filesName.RemoveAt(index);
                            parsedData.RemoveAt(index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Нет выделенных файлов.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Нет открытых файлов.", "Ошибка");
            }
        }

        private void menuFileControlInvert_Click(object sender, EventArgs e)
        {
            if (chkListFile.Items.Count != 0)
            {
                for (int i = 0; i < chkListFile.Items.Count; i++)
                {
                    chkListFile.SetItemChecked(i, !chkListFile.GetItemChecked(i));
                }
            }
            else
            {
                MessageBox.Show("Нет открытых файлов.", "Ошибка");
            }
        }

        private void menuResolutionFullHD_Click(object sender, EventArgs e)
        {
            if (!menuResolutionFullHD.Checked)
            {
                menuResolutionFullHD.Checked = true;
                menuResolutionQHD.Checked = false;
                menuResolutionUHD.Checked = false;
                menuResolutionCustom.Checked = false;
                menuResolutionCustomX.Enabled = false;
                menuResolutionCustomY.Enabled = false;
                resolutionWidth = 1920;
                resolutionHeight = 1080;
            }
        }

        private void menuResolutionQHD_Click(object sender, EventArgs e)
        {
            if (!menuResolutionQHD.Checked)
            {
                menuResolutionFullHD.Checked = false;
                menuResolutionQHD.Checked = true;
                menuResolutionUHD.Checked = false;
                menuResolutionCustom.Checked = false;
                menuResolutionCustomX.Enabled = false;
                menuResolutionCustomY.Enabled = false;
                resolutionWidth = 2560;
                resolutionHeight = 1440;
            }
        }

        private void menuResolutionUHD_Click(object sender, EventArgs e)
        {
            if (!menuResolutionUHD.Checked)
            {
                menuResolutionFullHD.Checked = false;
                menuResolutionQHD.Checked = false;
                menuResolutionUHD.Checked = true;
                menuResolutionCustom.Checked = false;
                menuResolutionCustomX.Enabled = false;
                menuResolutionCustomY.Enabled = false;
                resolutionWidth = 3840;
                resolutionHeight = 2160;
            }
        }

        private void menuResolutionCustom_Click(object sender, EventArgs e)
        {
            if (!menuResolutionCustom.Checked)
            {
                menuResolutionFullHD.Checked = false;
                menuResolutionQHD.Checked = false;
                menuResolutionUHD.Checked = false;
                menuResolutionCustom.Checked = true;
                menuResolutionCustomX.Enabled = true;
                menuResolutionCustomY.Enabled = true;
                try
                {
                    resolutionWidth = Convert.ToInt16(menuResolutionCustomX.Text);
                    resolutionHeight = Convert.ToInt16(menuResolutionCustomY.Text);
                }
                catch
                {
                    MessageBox.Show("Возможно вы ввели не число", "Предупреждение");
                }
            }
        }

        private void menuResolutionCustomX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (menuResolutionCustomX.Text == "")
                {
                    resolutionWidth = 1920;
                }
                else
                {
                    resolutionWidth = Convert.ToInt16(menuResolutionCustomX.Text);
                }
            }
            catch
            {
                menuResolutionCustomX.Text = "1920";
                resolutionWidth = 1920;
            }
        }

        private void menuResolutionCustomY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (menuResolutionCustomY.Text == "")
                {
                    resolutionHeight = 1080;
                }
                else
                {
                    resolutionHeight = Convert.ToInt16(menuResolutionCustomY.Text);
                }
            }
            catch
            {
                menuResolutionCustomY.Text = "1080";
                resolutionWidth = 1080;
            }
        }

        private void menuGrDraw_Click(object sender, EventArgs e)
        {
            menuFileSaveAs.Enabled = true;
            if (typeOfGraph == 1)
            {
                graphFrameTime();
            }
            else if (typeOfGraph == 2)
            {
                graphFPS();
            }
            else if (typeOfGraph == 3)
            {
                graphProbabilityDensity();
            }
            else if (typeOfGraph == 4)
            {
                menuFileSaveAs.Enabled = false;
                MessageBox.Show("Не доступно", "Предупреждение");
            }
            else
            {
                menuFileSaveAs.Enabled = false;
                MessageBox.Show("Ошибка выбора типа графика", "Ошибка");
            }
        }

        private void menuGrClear_Click(object sender, EventArgs e)
        {
            menuFileSaveAs.Enabled = false;
            cleanChart();
        }

        private void menuGrView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
        }

        private void menuGrNewWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
        }

        private void menuGrViewNameValue_TextChanged(object sender, EventArgs e)
        {
            if (menuGrViewNameValue.Text == "")
            {
                nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            }
            else
            {
                nameOfTest = menuGrViewNameValue.Text;
            }
            statusName.Text = nameOfTest;
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void menuHelpInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FVG - FrameViewGraph.\n\nДанная программа предназначена для анализа данных, полученных с программы FrameView. Можно построить несколько разных типов графиков и настроить их внешний вид под себя. Такие данные намного удобнее, чем сравнивать два, три, четыре видеофрагмента.\n\nИнструкция по использования появится на YT-канале 'volkovskey' в ближайшее время.", "О программе");
        }

        private void menuHelpVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название программы: FrameViewGraph\nВерсия программы: 0.2.0\nСтатус текущей версии программы: Beta\nНеобходимая версия FrameView: 1.1\nРазработчик: volkovskey\nКопирайт: Copyright ©volkovskey 2020-2021\nЛицензия: MIT License\nТекст лицензии:\n\n" + Properties.Resources.license, "Версия программы");
        }
    }
}
