using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrameViewGraph
{
    public partial class frmMain : Form
    {
        private String nameOfTest = "";
        private Byte typeOfGraph = 1;
        private Byte filter = 0;
        private Int16 resolutionWidth = 1920;
        private Int16 resolutionHeight = 1080;
        private List<String> filesName = new List<string>();
        private List<Array> parsedData = new List<Array>();

        public frmMain()
        {
            InitializeComponent();
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
                    if (filter == 0)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            mySeriesOfPoint.Points.AddXY(data[0, j], data[1, j]);
                        }
                    }
                    else if (filter >= 1 && filter <= 4)
                    {
                        float[] FrameTime = new float[data.GetLength(1)];
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            data[1, j] = (float)Math.Round(data[1, j], 2);
                            FrameTime[j] = data[1, j];
                        }
                        Array.Sort(FrameTime);
                        Dictionary<float, int> Count = new Dictionary<float, int>();
                        for (int h = 0; h < FrameTime.Length;)
                        {
                            int y;
                            for (y = h + 1; y < FrameTime.Length; y++)
                            {
                                if (FrameTime[h] != FrameTime[y])
                                {
                                    if (FrameTime[h] > 0) Count.Add(FrameTime[h], y - h);
                                    h = y;
                                    break;
                                }
                            }
                            if (y == FrameTime.Length)
                            {
                                if (FrameTime[h] > 0) Count.Add(FrameTime[h], y - h);
                                break;
                            }
                        }
                        float FilterLevel = 0f;
                        if (filter == 1) FilterLevel = 0.00001f;
                        else if (filter == 2) FilterLevel = 0.0001f;
                        else if (filter == 3) FilterLevel = 0.001f;
                        else if (filter == 4) FilterLevel = 0.01f;
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if ((float)Count[data[1, j]] / data.GetLength(1) > FilterLevel)
                            {
                                mySeriesOfPoint.Points.AddXY(data[0, j], data[1, j]);
                            }
                        }
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

        private void cleanChart()
        {
            chrMain.Series.Clear();
            chrMain.ChartAreas.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            menuName.Text = nameOfTest;
            statusName.Text = nameOfTest;
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            int startedBorderWidth = chrMain.Series[0].BorderWidth;
            Font startedFont = chrMain.Series[0].Font;
            Font newFont = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 12);
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].BorderWidth = (int)Math.Round(resolutionWidth * resolutionHeight / (1920 * 1080.0));
            }
            chrMain.ChartAreas[0].AxisX.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisY.LabelStyle.Font = newFont;
            chrMain.ChartAreas[0].AxisX.TitleFont = newFont;
            chrMain.ChartAreas[0].AxisY.TitleFont = newFont;
            chrMain.Titles[0].Font = newFont;
            chrMain.Legends[0].Font = newFont;
            chrMain.Titles.Add(this.Text);
            chrMain.Titles[1].Font = new Font("Verdana", (float)Math.Sqrt(resolutionWidth * resolutionHeight / (1920 * 1080)) * 10);
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

            //To started
            chrMain.Width = 860;
            chrMain.Height = 425;
            chrMain.Location = new System.Drawing.Point(12, 100);
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

        private void menuFileAdd_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK && !chkListFile.Items.Contains(openFileDlg.SafeFileName))
            {
                statusStatus.Text = "Идет загрузка данных с файла...";
                statusStr.Refresh();
                chkListFile.Items.Add(openFileDlg.SafeFileName);
                parsedData.Add(openCSV(openFileDlg.FileName));
                filesName.Add(openFileDlg.SafeFileName);
                statusStatus.Text = "Загрузка закончена.";
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

        private void menuGrNewWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не доступно", "Предупреждение");
        }

        private void menuHelpInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FVG - FrameViewGraph.\n\nДанная программа предназначена для анализа данных, полученных с программы FrameView. Можно построить несколько разных типов графиков и настроить их внешний вид под себя. Такие данные намного удобнее, чем сравнивать два, три, четыре видеофрагмента.\n\nИнструкция по использования появится на YT-канале 'volkovskey' в ближайшее время.", "О программе");
        }

        private void menuHelpVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название программы: FrameViewGraph\nВерсия программы: 0.3.1\nСтатус текущей версии программы: Beta\nНеобходимая версия FrameView: 1.1\nРазработчик: volkovskey\nКопирайт: Copyright ©volkovskey 2020-2021\nЛицензия: MIT License\nТекст лицензии:\n\n" + Properties.Resources.license, "Версия программы");
        }

        private void menuName_TextChanged(object sender, EventArgs e)
        {
            if (menuName.Text == "")
            {
                nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            }
            else
            {
                nameOfTest = menuName.Text;
            }
            statusName.Text = nameOfTest;
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void menuGrLegend_Click(object sender, EventArgs e)
        {
            if (menuGrViewLegend.Checked)
            {
                chrMain.Legends[0].Enabled = false;
                menuGrViewLegend.Checked = false;
            }
            else
            {
                chrMain.Legends[0].Enabled = true;
                menuGrViewLegend.Checked = true;
            }
        }

        private void menuGraph1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                graphFrameTime();
            }
            if (!menuGraph1.Checked)
            {
                menuGraph1.Checked = true;
                menuGraph2.Checked = false;
                menuGraph3.Checked = false;
                menuGraph4.Checked = false;
                typeOfGraph = 1;
            }
        }

        private void menuGraph2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                graphFPS();
            }
            if (!menuGraph2.Checked)
            {
                menuGraph1.Checked = false;
                menuGraph2.Checked = true;
                menuGraph3.Checked = false;
                menuGraph4.Checked = false;
                typeOfGraph = 1;
            }
        }

        private void menuGraph3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                graphProbabilityDensity();
            }
            if (!menuGraph3.Checked)
            {
                menuGraph1.Checked = false;
                menuGraph2.Checked = false;
                menuGraph3.Checked = true;
                menuGraph4.Checked = false;
                typeOfGraph = 1;
            }
        }

        private void menuGrFilterNo_Click(object sender, EventArgs e)
        {
            if (!menuGrFilterNo.Checked)
            {
                menuGrFilterNo.Checked = true;
                menuGrFilter1.Checked = false;
                menuGrFilter2.Checked = false;
                menuGrFilter3.Checked = false;
                menuGrFilter4.Checked = false;
                filter = 0;
            }
        }

        private void menuGrFilter1_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter1.Checked)
            {
                menuGrFilterNo.Checked = false;
                menuGrFilter1.Checked = true;
                menuGrFilter2.Checked = false;
                menuGrFilter3.Checked = false;
                menuGrFilter4.Checked = false;
                filter = 1;
            }
        }

        private void menuGrFilter2_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter2.Checked)
            {
                menuGrFilterNo.Checked = false;
                menuGrFilter1.Checked = false;
                menuGrFilter2.Checked = true;
                menuGrFilter3.Checked = false;
                menuGrFilter4.Checked = false;
                filter = 2;
            }
        }

        private void menuGrFilter3_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter3.Checked)
            {
                menuGrFilterNo.Checked = false;
                menuGrFilter1.Checked = false;
                menuGrFilter2.Checked = false;
                menuGrFilter3.Checked = true;
                menuGrFilter4.Checked = false;
                filter = 3;
            }
        }

        private void menuGrFilter4_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter4.Checked)
            {
                menuGrFilterNo.Checked = false;
                menuGrFilter1.Checked = false;
                menuGrFilter2.Checked = false;
                menuGrFilter3.Checked = false;
                menuGrFilter4.Checked = true;
                filter = 4;
            }
        }
    }
}
