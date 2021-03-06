﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private byte numberOfDataSet = 2;
        private Byte typeOfGraph = 1;
        private Byte filter = 0;
        private Int16 resolutionWidth = 1920;
        private Int16 resolutionHeight = 1080;
        private List<String> filesName = new List<string>(); //list of file's name
        private List<Array> parsedData = new List<Array>();
        private List<Array> infoData = new List<Array>(); //name, api, temp etc 4 right column and diagrams
        private List<Array> apiData = new List<Array>(); //stats data 4 right column and diagrams
        private List<Array> displayData = new List<Array>(); //stats data 4 right column and diagrams
        private List<Array> Data4BPT = new List<Array>(); //time, bat, cput, cpup, gput, gpup
        private List<Array> LoadData = new List<Array>(); //load cpu, cpu by threads, gpu

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
            ax1.Minimum = 0;
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
                            mySeriesOfPoint.Points.AddXY(data[0, j], data[numberOfDataSet, j]);
                        }
                    }
                    else if (filter >= 1 && filter <= 3)
                    {
                        float[] FrameTime = new float[data.GetLength(1)];
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            data[numberOfDataSet, j] = (float)Math.Round(data[numberOfDataSet, j], 2);
                            FrameTime[j] = data[numberOfDataSet, j];
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
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if ((float)Count[data[numberOfDataSet, j]] / data.GetLength(1) > FilterLevel)
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
            ax2.Minimum = 0;
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
                    if (filter == 0)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            //Console.WriteLine(data[0, j] + " " + data[numberOfDataSet, j]);
                            data[numberOfDataSet, j] = (float)Math.Round(1.0f / data[numberOfDataSet, j] * 1000f, 2);
                            mySeriesOfPoint.Points.AddXY(data[0, j], data[numberOfDataSet, j]);
                        }
                    }
                    else if (filter >= 1 && filter <= 3)
                    {
                        float[] FPS = new float[data.GetLength(1)];
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            data[numberOfDataSet, j] = (float)Math.Round(1.0f / data[numberOfDataSet, j] * 1000f, 2);
                            FPS[j] = data[numberOfDataSet, j];
                        }
                        Array.Sort(FPS);
                        Dictionary<float, int> Count = new Dictionary<float, int>();
                        for (int h = 0; h < FPS.Length;)
                        {
                            int y;
                            for (y = h + 1; y < FPS.Length; y++)
                            {
                                if (FPS[h] != FPS[y])
                                {
                                    if (FPS[h] > 0) Count.Add(FPS[h], y - h);
                                    h = y;
                                    break;
                                }
                            }
                            if (y == FPS.Length)
                            {
                                if (FPS[h] > 0) Count.Add(FPS[h], y - h);
                                break;
                            }
                        }
                        float FilterLevel = 0f;
                        if (filter == 1) FilterLevel = 0.00001f;
                        else if (filter == 2) FilterLevel = 0.0001f;
                        else if (filter == 3) FilterLevel = 0.001f;
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if ((float)Count[data[numberOfDataSet, j]] / data.GetLength(1) > FilterLevel)
                            {
                                mySeriesOfPoint.Points.AddXY(data[0, j], data[numberOfDataSet, j]);
                            }
                        }
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
            ay3.Title = "Вероятность (%)";
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
                        FPS[k] = (int)Math.Round(1.0f / data[numberOfDataSet, k] * 1000f);
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
                                if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                                i = j;
                                break;
                            }
                        }
                        if (j == FPS.Length)
                        {
                            if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                            break;
                        }
                    }

                    int kol = data.GetLength(1);

                    if (filter == 0) kol = 0;
                    else if (filter == 1) kol = (int)(kol / 5000.0);
                    else if (filter == 2) kol = (int)(kol / 1000.0);
                    else if (filter == 3) kol = (int)(kol / 100.0);
                    foreach (var fps in Count)
                    {
                        if (fps.Value > kol)
                        {
                            mySeriesOfPoint.Points.AddXY(fps.Key, fps.Value * 100.0 / data.GetLength(1));
                        }
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphDiagrams()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ay5 = new Axis();
            ay5.Title = "Кадры в секунду (FPS)";
            chrMain.ChartAreas[0].AxisY = ay5;
            chrMain.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            for (int a = 0; a < parsedData.Count; a++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[a]))
                {
                    string[] FPSdata = { };
                    if (numberOfDataSet == 1)
                    {
                        FPSdata = (string[])apiData[a].Clone();
                    }
                    else if (numberOfDataSet == 2)
                    {
                        FPSdata = (string[])displayData[a].Clone();
                    }
                    string[] tnpData = { };
                    tnpData = (string[])infoData[a].Clone();
                    String nameTest = nameOfTest;
                    String lineData = filesName[a];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Column;
                    mySeriesOfPoint.ChartArea = nameTest;
                    mySeriesOfPoint.XValueType = ChartValueType.String;
                    mySeriesOfPoint.IsValueShownAsLabel = true;

                    if (menuGrDataDiagram1.Checked) mySeriesOfPoint.Points.AddXY("Avg", Math.Round(checkFloat(FPSdata[0]), 2));
                    if (menuGrDataDiagram2.Checked) mySeriesOfPoint.Points.AddXY("Mode", Math.Round(checkFloat(FPSdata[1]), 2));
                    if (menuGrDataDiagram3.Checked) mySeriesOfPoint.Points.AddXY("50%", Math.Round(checkFloat(FPSdata[2]), 2));
                    if (menuGrDataDiagram4.Checked) mySeriesOfPoint.Points.AddXY("10%", Math.Round(checkFloat(FPSdata[3]), 2));
                    if (menuGrDataDiagram5.Checked) mySeriesOfPoint.Points.AddXY("1%", Math.Round(checkFloat(FPSdata[4]), 2));
                    if (menuGrDataDiagram6.Checked) mySeriesOfPoint.Points.AddXY("0.1%", Math.Round(checkFloat(FPSdata[5]), 2));

                    if (menuGrDataTnP_CPUtemp.Checked) mySeriesOfPoint.Points.AddXY("CPU, °C", Math.Round(String2Float(tnpData[5]), 2));
                    if (menuGrDataTnP_CPUpower.Checked) mySeriesOfPoint.Points.AddXY("CPU, Вт", Math.Round(String2Float(tnpData[6]), 2));
                    if (menuGrDataTnP_GPUtemp.Checked) mySeriesOfPoint.Points.AddXY("GPU, °C", Math.Round(String2Float(tnpData[11]), 2));
                    if (menuGrDataTnP_GPUpower.Checked) mySeriesOfPoint.Points.AddXY("GPU, Вт", Math.Round(String2Float(tnpData[12]), 2));

                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphDiagramsPC()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ay6 = new Axis();
            ay6.Title = "Кадры в секунду (%)";
            chrMain.ChartAreas[0].AxisY = ay6;
            chrMain.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            if (menuCmbBx.SelectedIndex > -1)
            {
                string[] mainData = new string[6];
                if (numberOfDataSet == 1)
                {
                    Array.Copy(apiData[menuCmbBx.SelectedIndex], mainData, 6);
                }
                else if (numberOfDataSet == 2)
                {
                    Array.Copy(displayData[menuCmbBx.SelectedIndex], mainData, 6);
                }
                string[] mainTnPData = { };
                mainTnPData = (string[])infoData[menuCmbBx.SelectedIndex].Clone();
                for (int a = 0; a < parsedData.Count; a++)
                {
                    if (chkListFile.CheckedItems.Contains(filesName[a]))
                    {
                        string[] FPSdata = { };
                        if (numberOfDataSet == 1)
                        {
                            FPSdata = (string[])apiData[a].Clone();
                        }
                        else if (numberOfDataSet == 2)
                        {
                            FPSdata = (string[])displayData[a].Clone();
                        }
                        string[] tnpData = { };
                        tnpData = (string[])infoData[a].Clone();
                        String nameTest = nameOfTest;
                        String lineData = filesName[a];
                        Series mySeriesOfPoint = new Series(lineData);
                        mySeriesOfPoint.ChartType = SeriesChartType.Column;
                        mySeriesOfPoint.ChartArea = nameTest;
                        mySeriesOfPoint.XValueType = ChartValueType.String;
                        mySeriesOfPoint.IsValueShownAsLabel = true;

                        if (menuGrDataDiagram1.Checked) mySeriesOfPoint.Points.AddXY("Avg", Math.Round(checkFloat(FPSdata[0]) / checkFloat(mainData[0]) * 100, 2));
                        if (menuGrDataDiagram2.Checked) mySeriesOfPoint.Points.AddXY("Mode", Math.Round(checkFloat(FPSdata[1]) / checkFloat(mainData[1]) * 100, 2));
                        if (menuGrDataDiagram3.Checked) mySeriesOfPoint.Points.AddXY("50%", Math.Round(checkFloat(FPSdata[2]) / checkFloat(mainData[2]) * 100, 2));
                        if (menuGrDataDiagram4.Checked) mySeriesOfPoint.Points.AddXY("10%", Math.Round(checkFloat(FPSdata[3]) / checkFloat(mainData[3]) * 100, 2));
                        if (menuGrDataDiagram5.Checked) mySeriesOfPoint.Points.AddXY("1%", Math.Round(checkFloat(FPSdata[4]) / checkFloat(mainData[4]) * 100, 2));
                        if (menuGrDataDiagram6.Checked) mySeriesOfPoint.Points.AddXY("0.1%", Math.Round(checkFloat(FPSdata[5]) / checkFloat(mainData[5]) * 100, 2));

                        if (menuGrDataTnP_CPUtemp.Checked) mySeriesOfPoint.Points.AddXY("CPU, °C", Math.Round(String2Float(tnpData[5]) / String2Float(mainTnPData[5]) * 100, 2));
                        if (menuGrDataTnP_CPUpower.Checked) mySeriesOfPoint.Points.AddXY("CPU, Вт", Math.Round(String2Float(tnpData[6]) / String2Float(mainTnPData[6]) * 100, 2));
                        if (menuGrDataTnP_GPUtemp.Checked) mySeriesOfPoint.Points.AddXY("GPU, °C", Math.Round(String2Float(tnpData[11]) / String2Float(mainTnPData[11]) * 100, 2));
                        if (menuGrDataTnP_GPUpower.Checked) mySeriesOfPoint.Points.AddXY("GPU, Вт", Math.Round(String2Float(tnpData[12]) / String2Float(mainTnPData[12]) * 100, 2));

                        chrMain.Series.Add(mySeriesOfPoint);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите справа сверху данные, которые надо принять за 100%.", "Ошибка");
            }
        }

        private void graphBattery()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax7 = new Axis();
            ax7.Title = "Время (мс)";
            ax7.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax7;
            Axis ay7 = new Axis();
            ay7.Title = "Уровень заряда (%)";
            chrMain.ChartAreas[0].AxisY = ay7;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[Data4BPT[i].GetLength(0), Data4BPT[i].GetLength(1)];
                    Array.Copy((float[,])Data4BPT[i], data, Data4BPT[i].Length);
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

        private void graphCPUtemp()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax8 = new Axis();
            ax8.Title = "Время (мс)";
            ax8.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax8;
            Axis ay8 = new Axis();
            ay8.Title = "Температура CPU (C°)";
            chrMain.ChartAreas[0].AxisY = ay8;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[Data4BPT[i].GetLength(0), Data4BPT[i].GetLength(1)];
                    Array.Copy((float[,])Data4BPT[i], data, Data4BPT[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[2, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphCPUpower()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax9 = new Axis();
            ax9.Title = "Время (мс)";
            ax9.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax9;
            Axis ay9 = new Axis();
            ay9.Title = "Потребление CPU (Вт)";
            chrMain.ChartAreas[0].AxisY = ay9;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[Data4BPT[i].GetLength(0), Data4BPT[i].GetLength(1)];
                    Array.Copy((float[,])Data4BPT[i], data, Data4BPT[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[3, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphGPUtemp()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax10 = new Axis();
            ax10.Title = "Время (мс)";
            ax10.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax10;
            Axis ay10 = new Axis();
            ay10.Title = "Температура GPU (C°)";
            chrMain.ChartAreas[0].AxisY = ay10;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[Data4BPT[i].GetLength(0), Data4BPT[i].GetLength(1)];
                    Array.Copy((float[,])Data4BPT[i], data, Data4BPT[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[4, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphGPUpower()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax11 = new Axis();
            ax11.Title = "Время (мс)";
            ax11.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax11;
            Axis ay11 = new Axis();
            ay11.Title = "Потребление GPU (Вт)";
            chrMain.ChartAreas[0].AxisY = ay11;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[Data4BPT[i].GetLength(0), Data4BPT[i].GetLength(1)];
                    Array.Copy((float[,])Data4BPT[i], data, Data4BPT[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[5, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private void graphCPUload()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax12 = new Axis();
            ax12.Title = "Время (мс)";
            ax12.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax12;
            Axis ay12 = new Axis();
            ay12.Title = "Средняя загрузка всех потоков CPU (%)";
            chrMain.ChartAreas[0].AxisY = ay12;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[LoadData[i].GetLength(0), LoadData[i].GetLength(1)];
                    Array.Copy((float[,])LoadData[i], data, LoadData[i].Length);
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

        private void graphCPUloadByThread()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax12 = new Axis();
            ax12.Title = "Время (мс)";
            ax12.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax12;
            Axis ay12 = new Axis();
            ay12.Title = "Загрузка всех потоков CPU (%)";
            chrMain.ChartAreas[0].AxisY = ay12;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[LoadData[i].GetLength(0), LoadData[i].GetLength(1)];
                    Array.Copy((float[,])LoadData[i], data, LoadData[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    
                    for (int l = 3; l < data.GetLength(0); l++)
                    {
                        Series mySeriesOfPoint = new Series((l - 3).ToString() + " " + lineData);
                        mySeriesOfPoint.ChartType = SeriesChartType.Line;
                        mySeriesOfPoint.ChartArea = nameTest;
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            mySeriesOfPoint.Points.AddXY(data[0, j], data[l, j]);
                        }
                        chrMain.Series.Add(mySeriesOfPoint);
                    }
                }
            }
        }

        private void graphGPUload()
        {
            cleanChart();
            chrMain.ChartAreas.Add(new ChartArea(nameOfTest));
            Axis ax13 = new Axis();
            ax13.Title = "Время (мс)";
            ax13.Minimum = 0;
            chrMain.ChartAreas[0].AxisX = ax13;
            Axis ay13 = new Axis();
            ay13.Title = "Загрузка GPU (%)";
            chrMain.ChartAreas[0].AxisY = ay13;
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (chkListFile.CheckedItems.Contains(filesName[i]))
                {
                    float[,] data = new float[LoadData[i].GetLength(0), LoadData[i].GetLength(1)];
                    Array.Copy((float[,])LoadData[i], data, LoadData[i].Length);
                    String nameTest = nameOfTest;
                    String lineData = filesName[i];
                    Series mySeriesOfPoint = new Series(lineData);
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = nameTest;

                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        mySeriesOfPoint.Points.AddXY(data[0, j], data[2, j]);
                    }
                    chrMain.Series.Add(mySeriesOfPoint);
                }
            }
        }

        private float[,] openCSV(String path)
        {
            //0 - Time
            //1 - MsBetweenPresents
            //2 - MsBetweenDisplayChange
            try
            {
                float[,] result = new float[3, 0];
                float[,] PnTinfo = new float[6, 0];
                float[,] loadInfo; //0 - time, 1 - cpu avg, 2 - gpu avg, 3+ - cpu by thread

                string[] info = new string[13];

                int counter = 0;

                int cpuFreq = 0;
                int cpuUsage = 0;
                int cpuTemp = 0;
                double cpuPower = 0;

                int gpuFreq = 0;
                int gpuMemFreq = 0;
                int gpuUsage = 0;
                int gpuTemp = 0;
                int gpuPower = 0;

                var reader = new StreamReader(File.OpenRead(path));
                var firstLine = reader.ReadLine();

                if (firstLine == Properties.Resources.FV11)
                {
                    var secondLine = reader.ReadLine();
                    var valuesSecondLine = secondLine.Split(',');

                    info[0] = valuesSecondLine[0]; //Application
                    info[1] = valuesSecondLine[4]; //Runtime
                    info[2] = valuesSecondLine[2]; //CPU
                    info[7] = valuesSecondLine[1]; //GPU

                    int lastIndexOfThread = 38;
                    for (int i = 39; i < 103; i++)
                    {
                        if (valuesSecondLine[i] != "NA")
                        {
                            lastIndexOfThread = i;
                        }
                        else
                        {
                            break;
                        }
                    }

                    loadInfo = new float[lastIndexOfThread - 38 + 3, 0];

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[12].Contains(".") && values[13].Contains(".") && values[14].Contains("."))
                        {
                            Parallel.Invoke(
                                () =>
                                {
                                    result = ResizeArray(result);
                                },
                                () =>
                                {
                                    loadInfo = ResizeArray(loadInfo);
                                },
                                () =>
                                {
                                    PnTinfo = ResizeArray(PnTinfo);
                                });
                            Parallel.Invoke(
                                () =>
                                {
                                    result[0, result.GetLength(1) - 1] = checkFloat(values[12]) * 1000f; //TimeInSeconds
                                    PnTinfo[0, PnTinfo.GetLength(1) - 1] = checkFloat(values[12]) * 1000f; //TimeInSeconds
                                    loadInfo[0, loadInfo.GetLength(1) - 1] = checkFloat(values[12]) * 1000f; //TimeInSeconds
                                    result[1, result.GetLength(1) - 1] = checkFloat(values[13]); //MsBetweenPresents
                                    result[2, result.GetLength(1) - 1] = checkFloat(values[14]); //MsBetweenDisplayChangeActual
                                },
                                () =>
                                {
                                    try
                                    {
                                        cpuFreq += Convert.ToInt32(values[34]); //CPUClk(MHz)
                                    }
                                    catch { }
                                    try
                                    {
                                        cpuUsage += Convert.ToInt32(values[35]); //CPUUtil(%)
                                        loadInfo[1, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[35]);
                                    }
                                    catch { }
                                    try
                                    {
                                        cpuTemp += Convert.ToInt32(values[36]); //CPU Package Temp(C)
                                        PnTinfo[2, PnTinfo.GetLength(1) - 1] = checkFloat(values[36]);
                                    }
                                    catch { }
                                },
                                () =>
                                {
                                    try
                                    {
                                        cpuPower += Convert.ToDouble(values[37]); //CPU Package Power(W)
                                        PnTinfo[3, PnTinfo.GetLength(1) - 1] = checkFloat(values[37]);
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuFreq += Convert.ToInt32(values[19]); //GPU0Clk(MHz)
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuUsage += Convert.ToInt32(values[20]); //GPU0Util(%)
                                        loadInfo[2, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[20]);
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuTemp += Convert.ToInt32(values[21]); //GPU0Temp(C)
                                        PnTinfo[4, PnTinfo.GetLength(1) - 1] = checkFloat(values[21]);
                                    }
                                    catch { }
                                },
                                () =>
                                {
                                    for (int i = 0; i < loadInfo.GetLength(0) - 3; i++)
                                    {
                                        loadInfo[i + 3, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[39 + i]);
                                    }
                                },
                                () =>
                                {
                                    try
                                    {
                                        if (values[32] != "NA")
                                        {
                                            gpuPower += Convert.ToInt32(values[32]); //NV Pwr(W) (API)
                                            PnTinfo[5, PnTinfo.GetLength(1) - 1] = checkFloat(values[32]);
                                        }
                                        else if (values[33] != "NA")
                                        {
                                            gpuPower += Convert.ToInt32(values[33]); //NV Pwr(W) (API)
                                            PnTinfo[5, PnTinfo.GetLength(1) - 1] = checkFloat(values[33]);
                                        }
                                    }
                                    catch { }
                                });
                            PnTinfo[1, PnTinfo.GetLength(1) - 1] = 0;

                            counter++;
                        }
                    }

                    info[3] = Math.Round((double)cpuFreq / counter, 2).ToString() + " МГц";
                    info[4] = Math.Round((double)cpuUsage / counter, 2).ToString() + " %";
                    info[5] = Math.Round((double)cpuTemp / counter, 2).ToString() + " C°";
                    info[6] = Math.Round(cpuPower / counter, 2).ToString() + " Вт";

                    info[8] = Math.Round((double)gpuFreq / counter, 2).ToString() + " МГц";
                    info[9] = "NA";
                    info[10] = Math.Round((double)gpuUsage / counter, 2).ToString() + " %";
                    info[11] = Math.Round((double)gpuTemp / counter, 2).ToString() + " C°";
                    info[12] = Math.Round((double)gpuPower / counter, 2).ToString() + " Вт";

                    infoData.Add(info);
                }
                else if (firstLine == Properties.Resources.FV12)
                {
                    var secondLine = reader.ReadLine();
                    var valuesSecondLine = secondLine.Split(',');

                    info[0] = valuesSecondLine[0]; //Application
                    info[1] = valuesSecondLine[4]; //Runtime
                    info[2] = valuesSecondLine[2]; //CPU
                    info[7] = valuesSecondLine[1]; //GPU

                    int lastIndexOfThread = 40;
                    for (int i = 41; i < 105; i++)
                    {
                        if (valuesSecondLine[i] != "NA")
                        {
                            lastIndexOfThread = i;
                        }
                        else
                        {
                            break;
                        }
                    }

                    loadInfo = new float[lastIndexOfThread - 40 + 3, 0];

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[12].Contains(".") && values[13].Contains(".") && values[14].Contains("."))
                        {
                            Parallel.Invoke(
                                () =>
                                {
                                    result = ResizeArray(result);
                                },
                                () =>
                                {
                                    loadInfo = ResizeArray(loadInfo);
                                },
                                () =>
                                {
                                    PnTinfo = ResizeArray(PnTinfo);
                                });
                            Parallel.Invoke(
                                () =>
                                {
                                    result[0, result.GetLength(1) - 1] = checkFloat(values[12]) * 1000f; //TimeInSeconds
                                    PnTinfo[0, PnTinfo.GetLength(1) - 1] = checkFloat(values[12]) * 1000f;
                                    loadInfo[0, loadInfo.GetLength(1) - 1] = checkFloat(values[12]) * 1000f; //TimeInSeconds
                                    result[1, result.GetLength(1) - 1] = checkFloat(values[13]); //MsBetweenPresents
                                    result[2, result.GetLength(1) - 1] = checkFloat(values[14]); //MsBetweenDisplayChangeActual
                                },
                                () =>
                                {
                                    try
                                    {
                                        cpuFreq += Convert.ToInt32(values[36]); //CPUClk(MHz)
                                    }
                                    catch { }
                                    try
                                    {
                                        cpuUsage += Convert.ToInt32(values[37]); //CPUUtil(%)
                                        loadInfo[1, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[37]);
                                    }
                                    catch { }
                                    try
                                    {
                                        cpuTemp += Convert.ToInt32(values[38]); //CPU Package Temp(C)
                                        PnTinfo[2, PnTinfo.GetLength(1) - 1] = checkFloat(values[38]);
                                    }
                                    catch { }
                                    try
                                    {
                                        cpuPower += Convert.ToDouble(values[39]); //CPU Package Power(W)
                                        PnTinfo[3, PnTinfo.GetLength(1) - 1] = checkFloat(values[39]);
                                    }
                                    catch { }
                                },
                                () =>
                                {
                                    try
                                    {
                                        gpuFreq += Convert.ToInt32(values[19]); //GPU0Clk(MHz)
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuMemFreq += Convert.ToInt32(values[20]); //GPU0MemClk(MHz)
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuUsage += Convert.ToInt32(values[21]); //GPU0Util(%)
                                        loadInfo[2, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[21]);
                                    }
                                    catch { }
                                    try
                                    {
                                        gpuTemp += Convert.ToInt32(values[22]); //GPU0Temp(C)
                                        PnTinfo[4, PnTinfo.GetLength(1) - 1] = checkFloat(values[22]);
                                    }
                                    catch { }
                                },
                                () =>
                                {
                                    for (int i = 0; i < loadInfo.GetLength(0) - 3; i++)
                                    {
                                        loadInfo[i + 3, loadInfo.GetLength(1) - 1] = Convert.ToInt32(values[41 + i]);
                                    }
                                },
                                () =>
                                {
                                    try
                                    {
                                        if (values[34] != "NA")
                                        {
                                            gpuPower += Convert.ToInt32(values[34]); //NV Pwr(W) (API)
                                            PnTinfo[5, PnTinfo.GetLength(1) - 1] = checkFloat(values[34]);
                                        }
                                        else if (values[35] != "NA")
                                        {
                                            gpuPower += Convert.ToInt32(values[35]); //NV Pwr(W) (API)
                                            PnTinfo[5, PnTinfo.GetLength(1) - 1] = checkFloat(values[35]);
                                        }
                                    }
                                    catch { }

                                    try
                                    {
                                        if (values[107] != "NA")
                                        {
                                            PnTinfo[1, PnTinfo.GetLength(1) - 1] = checkFloat(values[107]);
                                        }
                                        else
                                        {
                                            PnTinfo[1, PnTinfo.GetLength(1) - 1] = 0;
                                        }

                                    }
                                    catch { }
                                });

                            counter++;
                        }
                    }

                    info[3] = Math.Round((double)cpuFreq / counter, 2).ToString() + " МГц";
                    info[4] = Math.Round((double)cpuUsage / counter, 2).ToString() + " %";
                    info[5] = Math.Round((double)cpuTemp / counter, 2).ToString() + " C°";
                    info[6] = Math.Round(cpuPower / counter, 2).ToString() + " Вт";

                    info[8] = Math.Round((double)gpuFreq / counter, 2).ToString() + " МГц";
                    info[9] = Math.Round((double)gpuMemFreq / counter, 2).ToString() + " МГц";
                    info[10] = Math.Round((double)gpuUsage / counter, 2).ToString() + " %";
                    info[11] = Math.Round((double)gpuTemp / counter, 2).ToString() + " C°";
                    info[12] = Math.Round((double)gpuPower / counter, 2).ToString() + " Вт";

                    infoData.Add(info);
                }
                else
                {
                    MessageBox.Show("Структура файла нарушена, удостоверьтесь, что используете правильную версию FrameView.", "Ошибка");
                    return null;
                }

                void calculateFPS(byte number)
                {
                    double[] FPS = new double[result.GetLength(1)];
                    float startTime = result[0, 0];
                    for (int i = 0; i < result.GetLength(1); i++)
                    {
                        result[0, i] -= startTime;
                        if (result[number, i] == 0 && i != 0) result[number, i] = result[number, i - 1];
                        else if (result[number, i] == 0 && i == 0) result[number, i] = result[number, i + 1];
                        else if (result[number, i] == 0) Application.Exit();
                        FPS[i] = Math.Round(1000 / result[number, i], 1);
                    }

                    double avgFPS = FPS.Average();

                    Array.Sort(FPS);
                    Dictionary<double, int> Count = new Dictionary<double, int>();
                    for (int i = 0; i < FPS.Length;)
                    {
                        int j;
                        for (j = i + 1; j < FPS.Length; j++)
                        {
                            if (FPS[i] != FPS[j])
                            {
                                if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                                i = j;
                                break;
                            }
                        }
                        if (j == FPS.Length)
                        {
                            if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                            break;
                        }
                    }

                    double pc50 = 0, pc10 = 0, pc1 = 0, pc01 = 0;
                    bool pc50b = false, pc10b = false, pc1b = false, pc01b = false;
                    double FPScount = 0;
                    double modeFPS = 0;
                    double countModeFPS = 0;

                    foreach (var fps in Count)
                    {
                        FPScount += fps.Value;
                        if (FPScount / counter >= 0.5 && !pc50b)
                        {
                            pc50b = !pc50b;
                            pc50 = fps.Key;
                        }
                        else if (FPScount / counter >= 0.1 && !pc10b)
                        {
                            pc10b = !pc10b;
                            pc10 = fps.Key;
                        }
                        else if (FPScount / counter >= 0.01 && !pc1b)
                        {
                            pc1b = !pc1b;
                            pc1 = fps.Key;
                        }
                        else if (FPScount / counter >= 0.001 && !pc01b)
                        {
                            pc01b = !pc01b;
                            pc01 = fps.Key;
                        }
                    }

                    for (int i = 0; i < result.GetLength(1); i++)
                    {
                        FPS[i] = Math.Round(FPS[i]);
                    }
                    Array.Sort(FPS);
                    Count = new Dictionary<double, int>();
                    for (int i = 0; i < FPS.Length;)
                    {
                        int j;
                        for (j = i + 1; j < FPS.Length; j++)
                        {
                            if (FPS[i] != FPS[j])
                            {
                                if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                                i = j;
                                break;
                            }
                        }
                        if (j == FPS.Length)
                        {
                            if (FPS[i] > 0) Count.Add(FPS[i], j - i);
                            break;
                        }
                    }

                    foreach (var fps in Count)
                    {
                        if (countModeFPS < fps.Value)
                        {
                            countModeFPS = fps.Value;
                            modeFPS = fps.Key;
                        }
                    }

                    string[] tempData = { Math.Round((double)avgFPS, 2).ToString(), modeFPS.ToString(), pc50.ToString(), pc10.ToString(), pc1.ToString(), pc01.ToString() };
                    if (number == 1)
                    {
                        apiData.Add(tempData);
                    }
                    else if (number == 2)
                    {
                        displayData.Add(tempData);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                void MoveData()
                {
                    float startTime = PnTinfo[0, 0];
                    float startTime2 = loadInfo[0, 0];
                    for (int i = 0; i < PnTinfo.GetLength(1); i++)
                    {
                        PnTinfo[0, i] -= startTime;
                        loadInfo[0, i] -= startTime2;
                    }
                }

                calculateFPS(1);
                calculateFPS(2);
                MoveData();
                Data4BPT.Add(PnTinfo);
                LoadData.Add(loadInfo);

                return result;
            }
            catch
            {
                return null;
            }


        }

        private float checkFloat(string s)
        {
            float a;
            a = float.Parse(s);
            return a;
        }

        private float String2Float(string s)
        {
            float tempValue = 0;
            int index = s.LastIndexOf(' ');
            tempValue = float.Parse(s.Substring(0, index));
            return tempValue;
        }

        private bool tryOpenCSV(String path)
        {
            try
            {
                bool open = false;
                var reader = new StreamReader(File.OpenRead(path));
                var firstLine = reader.ReadLine();
                
                if (firstLine == Properties.Resources.FV11)
                {
                    open = true;
                }
                else if (firstLine == Properties.Resources.FV12)
                {
                    open = true;
                }
                return open;
            }
            catch
            {
                MessageBox.Show("Невозможно открыть данный файл. Возможно он открыт в другой программе.", "Ошибка");
                return false;
            }
        }

        private static float[,] ResizeArray(float[,] arr)
        {
            float[,] newArr = new float[arr.GetLength(0), arr.GetLength(1) + 1];
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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            String versionOfProgram = typeof(frmMain).Assembly.GetName().Version.ToString();
            int lengthOfVersion = versionOfProgram.LastIndexOf('.');
            Properties.Settings.Default.version = versionOfProgram.Substring(0, lengthOfVersion);
            this.Text = "FVG v." + Properties.Settings.Default.version + " by volkovskey";
            nameOfTest = "test_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            menuName.Text = nameOfTest;
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
            for (int i = 0; i < chrMain.Series.Count; i++)
            {
                chrMain.Series[i].Font = newFont;
            }
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
                chrMain.Series[i].Font = startedFont;
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
                if (tryOpenCSV(openFileDlg.FileName))
                {
                    statusStatus.Text = "Идет загрузка данных с файла...";
                    statusStr.Refresh();
                    chkListFile.Items.Add(openFileDlg.SafeFileName);
                    menuCmbBx.Items.Add(openFileDlg.SafeFileName);

                    parsedData.Add(openCSV(openFileDlg.FileName));
                    filesName.Add(openFileDlg.SafeFileName);
                    statusStatus.Text = "Загрузка закончена.";
                }
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
                            menuCmbBx.Items.RemoveAt(i);
                            filesName.RemoveAt(index);
                            parsedData.RemoveAt(index);
                            infoData.RemoveAt(index);
                            displayData.RemoveAt(index);
                            apiData.RemoveAt(index);
                            Data4BPT.RemoveAt(index);
                            LoadData.RemoveAt(index);
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
            if (chkListFile.Items.Count != 0)
            {
                if (chkListFile.CheckedItems.Count != 0)
                {
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
                        graphDiagrams();
                    }
                    else if (typeOfGraph == 5)
                    {
                        graphDiagramsPC();
                    }
                    else if (typeOfGraph == 6)
                    {
                        graphBattery();
                    }
                    else if (typeOfGraph == 7)
                    {
                        graphCPUtemp();
                    }
                    else if (typeOfGraph == 8)
                    {
                        graphGPUtemp();
                    }
                    else if (typeOfGraph == 9)
                    {
                        graphCPUpower();
                    }
                    else if (typeOfGraph == 10)
                    {
                        graphGPUpower();
                    }
                    else if (typeOfGraph == 11)
                    {
                        graphCPUload();
                    }
                    else if (typeOfGraph == 12)
                    {
                        graphCPUloadByThread();
                    }
                    else if (typeOfGraph == 13)
                    {
                        graphGPUload();
                    }
                    else
                    {
                        menuFileSaveAs.Enabled = false;
                        MessageBox.Show("Ошибка выбора типа графика", "Ошибка");
                    }
                }
                else
                {
                    menuFileSaveAs.Enabled = false;
                    MessageBox.Show("Нет выделенных файлов.", "Ошибка");
                }
            }
            else
            {
                menuFileSaveAs.Enabled = false;
                MessageBox.Show("Нет открытых файлов.", "Ошибка");
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
            String text = "FVG - FrameViewGraph.\n\nДанная программа предназначена для анализа данных, полученных с программы FrameView. Можно построить несколько разных типов графиков и настроить их внешний вид под себя. Такие данные намного удобнее, чем сравнивать два, три, четыре видеофрагмента.\n\nИнструкция по использования появится на YT-канале 'volkovskey' в ближайшее время.";
            MessageBox.Show(text, "О программе");
        }

        private void menuHelpVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название программы: FrameViewGraph\nВерсия программы: " + Properties.Settings.Default.version + "\nСтатус текущей версии программы: Стабильная\nПодходящие версии FrameView: 1.1, 1.2\nРазработчик: volkovskey\nКопирайт: Copyright ©volkovskey 2020-2021\nЛицензия: MIT License\nТекст лицензии:\n\n" + Properties.Resources.license, "Версия программы");
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
            if (!menuGraph1.Checked)
            {
                disableAllGraphs();
                menuGraph1.Checked = true;
                typeOfGraph = 1;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph2.Checked)
            {
                disableAllGraphs();
                menuGraph2.Checked = true;
                typeOfGraph = 2;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph3.Checked)
            {
                disableAllGraphs();
                menuGraph3.Checked = true;
                typeOfGraph = 3;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph4_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph4.Checked)
            {
                disableAllGraphs();
                menuGraph4.Checked = true;
                typeOfGraph = 4;
                menuGrDataDiagram.Enabled = true;
                menuGrDataTempAndPower.Enabled = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph5_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph5.Checked)
            {
                disableAllGraphs();
                menuGraph5.Checked = true;
                typeOfGraph = 5;
                menuGrDataDiagram.Enabled = true;
                menuGrDataTempAndPower.Enabled = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void disableAllFilters()
        {
            menuGrFilterNo.Checked = false;
            menuGrFilter1.Checked = false;
            menuGrFilter2.Checked = false;
            menuGrFilter3.Checked = false;
        }

        private void menuGrFilterNo_Click(object sender, EventArgs e)
        {
            if (!menuGrFilterNo.Checked)
            {
                disableAllFilters();
                menuGrFilterNo.Checked = true;
                filter = 0;
            }
        }

        private void menuGrFilter1_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter1.Checked)
            {
                disableAllFilters();
                menuGrFilter1.Checked = true;
                filter = 1;
            }
        }

        private void menuGrFilter2_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter2.Checked)
            {
                disableAllFilters();
                menuGrFilter2.Checked = true;
                filter = 2;
            }
        }

        private void menuGrFilter3_Click(object sender, EventArgs e)
        {
            if (!menuGrFilter3.Checked)
            {
                disableAllFilters();
                menuGrFilter3.Checked = true;
                filter = 3;
            }
        }

        private void disableAllGraphs()
        {
            menuGraph1.Checked = false;
            menuGraph2.Checked = false;
            menuGraph3.Checked = false;
            menuGraph4.Checked = false;
            menuGraph5.Checked = false;
            menuGraph6.Checked = false;
            menuGraph7.Checked = false;
            menuGraph8.Checked = false;
            menuGraph9.Checked = false;
            menuGraph0.Checked = false;
            menuGraph11.Checked = false;
            menuGraph12.Checked = false;
            menuGraph13.Checked = false;
            menuGrDataDiagram.Enabled = false;
            menuGrDataTempAndPower.Enabled = false;
        }

        private void menuGraph1_Click(object sender, EventArgs e)
        {
            if (!menuGraph1.Checked)
            {
                disableAllGraphs();
                menuGraph1.Checked = true;
                typeOfGraph = 1;
            }
        }

        private void menuGraph2_Click(object sender, EventArgs e)
        {
            if (!menuGraph2.Checked)
            {
                disableAllGraphs();
                menuGraph2.Checked = true;
                typeOfGraph = 2;
            }
        }

        private void menuGraph3_Click(object sender, EventArgs e)
        {
            if (!menuGraph3.Checked)
            {
                disableAllGraphs();
                menuGraph3.Checked = true;
                typeOfGraph = 3;
            }
        }

        private void menuGraph4_Click(object sender, EventArgs e)
        {
            if (!menuGraph4.Checked)
            {
                disableAllGraphs();
                menuGraph4.Checked = true;
                typeOfGraph = 4;
                menuGrDataDiagram.Enabled = true;
                menuGrDataTempAndPower.Enabled = true;
            }
        }

        private void menuGraph5_Click(object sender, EventArgs e)
        {
            if (!menuGraph5.Checked)
            {
                disableAllGraphs();
                menuGraph5.Checked = true;
                typeOfGraph = 5;
                menuGrDataDiagram.Enabled = true;
                menuGrDataTempAndPower.Enabled = true;
            }
        }

        private void menuCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuCmbBx.SelectedIndex > -1)
            {
                string[] shortData = new string[13];
                string[] fpsData = new string[6];
                Array.Copy(infoData[menuCmbBx.SelectedIndex], shortData, 13);
                if (numberOfDataSet == 1)
                {
                    Array.Copy(apiData[menuCmbBx.SelectedIndex], fpsData, 6);
                }
                else if (numberOfDataSet == 2)
                {
                    Array.Copy(displayData[menuCmbBx.SelectedIndex], fpsData, 6);
                }

                lblApplication.Text = shortData[0];
                lblApi.Text = shortData[1];

                lblCpuName.Text = shortData[2];
                lblCpuFreq.Text = shortData[3];
                lblCpuUsage.Text = shortData[4];
                lblCpuTemp.Text = shortData[5];
                lblCpuPower.Text = shortData[6];

                lblGpuName.Text = shortData[7];
                lblGpuFreq.Text = shortData[8];
                lblGpuMemFreq.Text = shortData[9];
                lblGpuUsage.Text = shortData[10];
                lblGpuTemp.Text = shortData[11];
                lblGpuPower.Text = shortData[12];

                lblAvgFPS.Text = fpsData[0];
                lblModeFPS.Text = fpsData[1];
                lbl50pc.Text = fpsData[2];
                lbl10pc.Text = fpsData[3];
                lbl1pc.Text = fpsData[4];
                lbl01pc.Text = fpsData[5];
            }
        }

        private void menuGrDataDiagram_Click(object sender, EventArgs e)
        {
            menuGr.DropDown.AutoClose = !menuGr.DropDown.AutoClose;
            menuGrData.DropDown.AutoClose = !menuGrData.DropDown.AutoClose;
            menuGrDataDiagram.DropDown.AutoClose = !menuGrDataDiagram.DropDown.AutoClose;
            if (menuGrDataDiagram.DropDown.AutoClose) menuGrDataDiagram.DropDown.Close();
        }
        private void menuGrDataTempAndPower_Click(object sender, EventArgs e)
        {
            menuGr.DropDown.AutoClose = !menuGr.DropDown.AutoClose;
            menuGrData.DropDown.AutoClose = !menuGrData.DropDown.AutoClose;
            menuGrDataTempAndPower.DropDown.AutoClose = !menuGrDataTempAndPower.DropDown.AutoClose;
            if (menuGrDataTempAndPower.DropDown.AutoClose) menuGrDataTempAndPower.DropDown.Close();
        }
        private void menuGrDataSetDisplay_Click(object sender, EventArgs e)
        {
            menuGrDataSetAPI.Checked = false;
            menuGrDataSetDisplay.Checked = true;
            numberOfDataSet = 2;

            menuGrDraw_Click(sender, e);
            menuCmbBx_SelectedIndexChanged(sender, e);
        }

        private void menuGrDataSetAPI_Click(object sender, EventArgs e)
        {
            menuGrDataSetAPI.Checked = true;
            menuGrDataSetDisplay.Checked = false;
            numberOfDataSet = 1;

            menuGrDraw_Click(sender, e);
            menuCmbBx_SelectedIndexChanged(sender, e);
        }

        private void menuGraph6_Click(object sender, EventArgs e)
        {
            if (!menuGraph6.Checked)
            {
                disableAllGraphs();
                menuGraph6.Checked = true;
                typeOfGraph = 6;
            }
        }

        private void menuGraph7_Click(object sender, EventArgs e)
        {
            if (!menuGraph7.Checked)
            {
                disableAllGraphs();
                menuGraph7.Checked = true;
                typeOfGraph = 7;
            }
        }

        private void menuGraph8_Click(object sender, EventArgs e)
        {
            if (!menuGraph8.Checked)
            {
                disableAllGraphs();
                menuGraph8.Checked = true;
                typeOfGraph = 8;
            }
        }

        private void menuGraph9_Click(object sender, EventArgs e)
        {
            if (!menuGraph9.Checked)
            {
                disableAllGraphs();
                menuGraph9.Checked = true;
                typeOfGraph = 9;
            }
        }

        private void menuGraph0_Click(object sender, EventArgs e)
        {
            if (!menuGraph5.Checked)
            {
                disableAllGraphs();
                menuGraph0.Checked = true;
                typeOfGraph = 10;
            }
        }

        private void menuGraph6_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph6.Checked)
            {
                disableAllGraphs();
                menuGraph6.Checked = true;
                typeOfGraph = 6;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph7_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph7.Checked)
            {
                disableAllGraphs();
                menuGraph7.Checked = true;
                typeOfGraph = 7;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph8_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph8.Checked)
            {
                disableAllGraphs();
                menuGraph8.Checked = true;
                typeOfGraph = 8;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph9_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph9.Checked)
            {
                disableAllGraphs();
                menuGraph9.Checked = true;
                typeOfGraph = 9;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph0_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph0.Checked)
            {
                disableAllGraphs();
                menuGraph0.Checked = true;
                typeOfGraph = 10;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph11_Click(object sender, EventArgs e)
        {
            if (!menuGraph11.Checked)
            {
                disableAllGraphs();
                menuGraph11.Checked = true;
                typeOfGraph = 11;
            }
        }

        private void menuGraph11_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph11.Checked)
            {
                disableAllGraphs();
                menuGraph11.Checked = true;
                typeOfGraph = 11;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph13_Click(object sender, EventArgs e)
        {
            if (!menuGraph13.Checked)
            {
                disableAllGraphs();
                menuGraph13.Checked = true;
                typeOfGraph = 13;
            }
        }

        private void menuGraph13_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph13.Checked)
            {
                disableAllGraphs();
                menuGraph13.Checked = true;
                typeOfGraph = 13;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }

        private void menuGraph12_Click(object sender, EventArgs e)
        {
            if (!menuGraph12.Checked)
            {
                disableAllGraphs();
                menuGraph12.Checked = true;
                typeOfGraph = 12;
            }
        }

        private void menuGraph12_MouseDown(object sender, MouseEventArgs e)
        {
            if (!menuGraph12.Checked)
            {
                disableAllGraphs();
                menuGraph12.Checked = true;
                typeOfGraph = 12;
            }
            if (e.Button == MouseButtons.Right)
            {
                menuGrDraw_Click(sender, e);
            }
        }
    }
}

