using System;
using System.Collections.Generic;
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

        private void txtBxNameTest_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNameTest.Text == "")
            {
                nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            }
            else
            {
                nameOfTest = txtBxNameTest.Text;
            }
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK && !chkListFile.Items.Contains(openFileDlg.SafeFileName))
            {
                chkListFile.Items.Add(openFileDlg.SafeFileName);
                parsedData.Add(openCSV(openFileDlg.FileName));
                filesName.Add(openFileDlg.SafeFileName);
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
                            chkListFile.Items.RemoveAt(i);
                            int index = filesName.IndexOf(chkListFile.GetItemText(i));
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

        private void rdBtnFullHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnFullHD.Checked)
            {
                resolutionWidth = 1920;
                resolutionHeight = 1080;
                txtBxCustomX.Enabled = false;
                txtBxCustomY.Enabled = false;
            }
        }

        private void rdBtnQHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnQHD.Checked)
            {
                resolutionWidth = 2560;
                resolutionHeight = 1440;
                txtBxCustomX.Enabled = false;
                txtBxCustomY.Enabled = false;
            }
        }

        private void rdBtnUHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnUHD.Checked)
            {
                resolutionWidth = 3840;
                resolutionHeight = 2160;
                txtBxCustomX.Enabled = false;
                txtBxCustomY.Enabled = false;
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
            //Chart chrTemp = Clone(chrMain);
            //chrTemp.Location = new System.Drawing.Point(-10000, -10000);
            //chrTemp.Width = resolutionWidth;
            //chrTemp.Height = resolutionHeight;
            //using (SaveFileDialog sfd = new SaveFileDialog())
            //{
            //    sfd.Title = "Сохранить изображение как ...";
            //    sfd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
            //    sfd.AddExtension = true;
            //    sfd.FileName = nameOfTest;
            //    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        switch (sfd.FilterIndex)
            //        {
            //            case 1: chrTemp.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
            //            case 2: chrTemp.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
            //            case 3: chrTemp.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
            //        }
            //    }
            //}
            chrMain.Location = new System.Drawing.Point(-10000, -10000);
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

        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                typeOfGraph = 1;
            }
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn2.Checked)
            {
                typeOfGraph = 2;
            }
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn3.Checked)
            {
                typeOfGraph = 3;
            }
        }

        private void rdBtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn4.Checked)
            {
                typeOfGraph = 4;
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            switch (typeOfGraph)
            {
                case 1:
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
                            graphFrameTime((float[,])parsedData[i], nameOfTest, filesName[i]);
                        }
                    }
                    break;
                case 2:
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
                            graphFPS((float[,])parsedData[i], nameOfTest, filesName[i]);
                        }
                    }
                    break;
                case 3:
                    cleanChart();
                    chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
                    Axis ax3 = new Axis();
                    ax3.Title = "Кадры в секунду (FPS)";
                    chrMain.ChartAreas[0].AxisX = ax3;
                    Axis ay3 = new Axis();
                    ay3.Title = "Время (с)";
                    chrMain.ChartAreas[0].AxisY = ay3;
                    for (int i = 0; i < parsedData.Count; i++)
                    {
                        if (chkListFile.CheckedItems.Contains(filesName[i]))
                        {
                            graphProbabilityDensity((float[,])parsedData[i], nameOfTest, filesName[i]);
                        }
                    }
                    break;
                case 4:
                    MessageBox.Show("Не доступно", "Предупреждение");
                    break;
                default:
                    MessageBox.Show("Ошибка выбора типа графика", "Ошибка");
                    break;
            }
        }

        private void graphFrameTime(float[,] data, String nameTest, String lineData)
        {
            Series mySeriesOfPoint = new Series(lineData);
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = nameTest;
            for (int i = 0; i < data.GetLength(1); i++)
            {
                mySeriesOfPoint.Points.AddXY(data[0, i], data[1, i]);
            }
            chrMain.Series.Add(mySeriesOfPoint);
        }

        private void graphFPS(float[,] data, String nameTest, String lineData)
        {
            Series mySeriesOfPoint = new Series(lineData);
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = nameTest;
            for (int i = 0; i < data.GetLength(1); i++)
            {
                mySeriesOfPoint.Points.AddXY(data[0, i], 1.0f / data[1, i] * 1000f);
            }
            chrMain.Series.Add(mySeriesOfPoint);
        }

        private void graphProbabilityDensity(float[,] data, String nameTest, String lineData)
        {
            Series mySeriesOfPoint = new Series(lineData);
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = nameTest;
            int[] FPS = new int[data.GetLength(1)];
            for (int i = 0; i < data.GetLength(1); i++)
            {
                FPS[i] = (int)Math.Round(1.0f / data[1, i] * 1000f);
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
                        Count.Add(FPS[i], j - i);
                        i = j;
                        break;
                    }
                }
                if (j == FPS.Length)
                {
                    Count.Add(FPS[i], j - i);
                    break;
                }
            }
            foreach (var fps in Count)
            {
                mySeriesOfPoint.Points.AddXY(fps.Key, fps.Value);
            }
            chrMain.Series.Add(mySeriesOfPoint);
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
            chrMain.Titles.Clear();
            chrMain.Titles.Add(nameOfTest);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rdBtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCustom.Checked)
            {
                try
                {
                    resolutionWidth = Convert.ToInt16(txtBxCustomX.Text);
                    resolutionHeight = Convert.ToInt16(txtBxCustomY.Text);
                }
                catch
                {
                    MessageBox.Show("Возможно вы ввели не число", "Предупреждение");
                }
                txtBxCustomX.Enabled = true;
                txtBxCustomY.Enabled = true;
            }
        }

        private void txtBxCustomX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                resolutionWidth = Convert.ToInt16(txtBxCustomX.Text);
            }
            catch
            {
                txtBxCustomX.Text = "1920";
                resolutionWidth = 1920;
            }
        }

        private void txtBxCustomY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                resolutionHeight = Convert.ToInt16(txtBxCustomY.Text);
            }
            catch
            {
                txtBxCustomY.Text = "1080";
                resolutionHeight = 1080;
            }
        }
    }
}
