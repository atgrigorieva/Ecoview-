using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ecoview_Сканирование_спектра
{
    public partial class Ecoview : Form
    {
        public Ecoview()
        {
            InitializeComponent();
        }

        public bool nonPort; //Порт включен(выключен)
        public SerialPort newPort; //SerialPort
        public string portsName; //Имя порта
        public string[] RDstring;
        public bool ComPort, ComPodkl, StopSpectr, StopAgro, USE_KO;
        public int countSA;
        public string GE5_1_0 = "";
        public string pathTemp = System.IO.Path.GetTempPath();
        public bool ResponseModeNormal = true;
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/";
        public string Description, Description1;
        public string[][,] countScan;
        public int countButtonClick;
        public string filepath, filepath2, filepathFull;

        public int countChart = 0;
        public double step, start, cancel;
        //public int coutPressPlay = 0;
        public List<List<List<double>>> ScanSpectrChart;
        public List<List<List<double>>> ScanSpectrChart_;
        public List<List<double>> ScanSpectrChartZero;
        public string typeIzmer;

        private void button7_Click(object sender, EventArgs e)
        {
            Calibrovka calibrovka = new Calibrovka(this);
        }

        private void Ecoview_FormClosing(object sender, FormClosingEventArgs e)
        {
            PortClose portclose = new PortClose(this);
        }

        private void Ecoview_FormClosed(object sender, FormClosedEventArgs e)
        {
            PortClose portclose = new PortClose(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Izmerenie izmeren = new Izmerenie(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateDimension createDemension = new CreateDimension(this);
        }

        private void OnlyChart_CheckedChanged(object sender, EventArgs e)
        {
            if(OnlyChart.Checked == true)
            {
                sill.Enabled = false;
            }
        }

        private void shoulder_CheckedChanged(object sender, EventArgs e)
        {
            if (shoulder.Checked == true)
            {
                sill.Enabled = false;
            }
        }

        private void MinimumRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MinimumRadio.Checked == true)
            {
                sill.Enabled = true;
                MaxMinChenged();
            }
        }

        private void MaximumRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MaximumRadio.Checked == true)
            {
                sill.Enabled = true;
                MaxMinChenged();
            }
        }

        private void MaxMin_CheckedChanged(object sender, EventArgs e)
        {
            if (MaxMin.Checked == true)
            {
                sill.Enabled = true;
                MaxMinChenged();
            }
        }

        private void sill_ValueChanged(object sender, EventArgs e)
        {
            MaxMinChenged();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportExcelAll exportExcelAll = new ExportExcelAll(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveAll saveall = new SaveAll(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenAll openall = new OpenAll(this);
        }

        public void MaxMinChenged()
        {
            /*double step = 0.5;
            double cancel_ = ScanSpectrChart[0][ScanSpectrChart[0].Count - 1][0];
            double start_ = ScanSpectrChart[0][0][0];
            double m1 = Convert.ToDouble(((start_ - cancel_) / step));
            double m3 = Convert.ToDouble(sill.Value.ToString());
            double m2 = m3 / 100.0;
            int stepPassage = Convert.ToInt32(m1 * m2);*/
            int stepPassage = 1;
            double m2 = 0;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            ScanChart.Series[1].Points.Clear();
            double max = 0.0;
            double min = 0.0;

            for(int i = 0; i < ScanSpectrChart[0].Count; i++)
            {
                if(i < stepPassage && i + stepPassage < ScanSpectrChart[0].Count - 1)
                {
                    if (typeIzmer == "Abs")
                    {
                        double countPoint = ScanSpectrChart[0][i][1];
                        double nextPoint = ScanSpectrChart[0][i + stepPassage][1];
                        if (countPoint > nextPoint * (1 + m2))
                        {
                            if (MaximumRadio.Checked == true || MaxMin.Checked == true)
                            {
                                max = ScanSpectrChart[0][i][1];
                                dataGridView1.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                min = max;
                                double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                double y1 = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                ScanChart.Series[1].Points.AddXY(x1, y1);
                                ScanChart.Series[1].ChartType = SeriesChartType.Point;
                            }
                        }
                        else
                        {
                            if (MinimumRadio.Checked == true || MaxMin.Checked == true)
                            {
                                min = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                dataGridView2.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                max = min;
                                double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                double y1 = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                ScanChart.Series[1].Points.AddXY(x1, y1);
                                ScanChart.Series[1].ChartType = SeriesChartType.Point;
                            }
                        }
                    }
                    else
                    {
                        if (ScanSpectrChart[0][i][2] > ScanSpectrChart[0][i + stepPassage][2])
                        {
                            if (MaximumRadio.Checked == true || MaxMin.Checked == true)
                            {
                                max = ScanSpectrChart[0][i][2];
                                dataGridView1.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                min = max;
                                double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                double y1 = Convert.ToDouble(ScanSpectrChart[0][i][2]);
                                ScanChart.Series[1].Points.AddXY(x1, y1);
                                ScanChart.Series[1].ChartType = SeriesChartType.Point;
                            }
                        }
                        else
                        {
                            if (MinimumRadio.Checked == true || MaxMin.Checked == true)
                            {
                                min = Convert.ToDouble(ScanSpectrChart[0][i][2]);
                                dataGridView2.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                max = min;
                                double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                double y1 = Convert.ToDouble(ScanSpectrChart[0][i][2]);
                                ScanChart.Series[1].Points.AddXY(x1, y1);
                                ScanChart.Series[1].ChartType = SeriesChartType.Point;
                            }
                        }
                    }
                }
                else
                {
                    if(i + stepPassage < ScanSpectrChart[0].Count - 1)
                    {
                        if (typeIzmer == "Abs")
                        {
                            double countPoint = ScanSpectrChart[0][i][1];
                            /*if(ScanSpectrChart[0][i][0] == 431.5)
                            {
                                MessageBox.Show("Point!");
                            }*/
                            double nextPoint = ScanSpectrChart[0][i + stepPassage][1];
                            double backPoint = ScanSpectrChart[0][i - stepPassage][1];
                            if (countPoint > nextPoint * (1 + m2) &&
                                countPoint >= backPoint * (1 + m2))
                            {
                                if (MaximumRadio.Checked == true || MaxMin.Checked == true)
                                {
                                    max = ScanSpectrChart[0][i][1];
                                    dataGridView1.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                    min = max;
                                    double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                    double y1 = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                    ScanChart.Series[1].Points.AddXY(x1, y1);
                                    ScanChart.Series[1].ChartType = SeriesChartType.Point;
                                }
                            }
                            if (ScanSpectrChart[0][i][1] < ScanSpectrChart[0][i + stepPassage][1] &&
                                ScanSpectrChart[0][i][1] <= ScanSpectrChart[0][i - stepPassage][1])
                            {
                                if (MinimumRadio.Checked == true || MaxMin.Checked == true)
                                {
                                    min = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                    dataGridView2.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                    max = min;
                                    double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                    double y1 = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                    ScanChart.Series[1].Points.AddXY(x1, y1);
                                    ScanChart.Series[1].ChartType = SeriesChartType.Point;
                                }
                            }
                        }
                        else
                        {
                            if (ScanSpectrChart[0][i][2] > ScanSpectrChart[0][i + stepPassage][2] &&
                            ScanSpectrChart[0][i][2] >= ScanSpectrChart[0][i - stepPassage][2] )
                            {
                                if (MaximumRadio.Checked == true || MaxMin.Checked == true)
                                {
                                    max = ScanSpectrChart[0][i][2];
                                    dataGridView1.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                    min = max;
                                    double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                    double y1 = Convert.ToDouble(ScanSpectrChart[0][i][2]);
                                    ScanChart.Series[1].Points.AddXY(x1, y1);
                                    ScanChart.Series[1].ChartType = SeriesChartType.Point;
                                }
                            }
                            if (ScanSpectrChart[0][i][2] < ScanSpectrChart[0][i + stepPassage][1] &&
                                ScanSpectrChart[0][i][2] <= ScanSpectrChart[0][i - stepPassage][2])
                            {
                                if (MinimumRadio.Checked == true || MaxMin.Checked == true)
                                {
                                    min = Convert.ToDouble(ScanSpectrChart[0][i][1]);
                                    dataGridView2.Rows.Add(ScanSpectrChart[0][i][0], ScanSpectrChart[0][i][1], ScanSpectrChart[0][i][2]);
                                    max = min;
                                    double x1 = Convert.ToDouble(ScanSpectrChart[0][i][0]);
                                    double y1 = Convert.ToDouble(ScanSpectrChart[0][i][2]);
                                    ScanChart.Series[1].Points.AddXY(x1, y1);
                                    ScanChart.Series[1].ChartType = SeriesChartType.Point;
                                }
                            }
                        }

                        
                    }
                }
            }

            //MessageBox.Show(stepPassage.ToString());
        }

        public string versionPribor; //версия прибора
        public string wavelength1 = Convert.ToString(0);
        
        private void Connect_Click(object sender, EventArgs e)
        {
            Connection conection = new Connection(this);
        }

        public void SW_Scan(double SWTEXT)
        {
            Application.DoEvents();
            newPort.Write("SW " + Math.Round(SWTEXT, 1).ToString().Replace(".", ",") + "\r");
            string indata = "";
            while (indata.Contains(">") == false)
            {
                indata = newPort.ReadExisting();
            }
            Application.DoEvents();
            GWNew.Text = string.Format("{0:0.0}", Math.Round(SWTEXT, 1).ToString());
            Application.DoEvents();
        }

        public void SAGEScan()
        {
            Regex regex1 = new Regex(@"\D");
            Regex regex = new Regex(@"\W");

            if (versionPribor.Contains("2"))
            { countSA = 8; }
            else
            {
                countSA = 4;
            }
           

            newPort.Write("SA " + countSA + "\r");
            string indata = "";
            while (indata.Contains(">") == false)
            {
                indata = newPort.ReadExisting();
            }

            newPort.Write("GE 1\r");
            if (ResponseModeNormal == true)
            {
                if (versionPribor.Contains("2"))
                {
                    Thread.Sleep(3);
                }
                else
                {
                    Thread.Sleep(3);
                }
            }
            else
            {
                //Thread.Sleep(1000);
            }
            string indata_0 = "";

            while (indata_0.Contains("\r>") == false)
            {
                indata = newPort.ReadExisting();
                indata_0 += indata;
            }
            int index = 0;
            int index1 = 0;
            int countSub = 0;
            while ((index = indata_0.IndexOf("\r", index)) != -1)
            {
                // Console.WriteLine(index);
                index += "\r".Length;
                if (countSub < 2)
                {
                    index1 = index;
                }
                countSub++;
            }
            if (countSub > 2)
            {
                indata_0 = indata_0.Substring(0, index1);
            }

            string GE5_1 = regex.Replace(indata_0, "");
            GE5_1 = regex1.Replace(GE5_1, "");
            GE5_1_0 = GE5_1;
            while (Convert.ToInt32(GE5_1) > 10000 && countSA > 1)
            {
                countSA--;
                newPort.Write("SA " + countSA + "\r");
                indata = "";
                while (indata.Contains(">") == false)
                {
                    indata = newPort.ReadExisting();
                }

                newPort.Write("GE 1\r");
                if (ResponseModeNormal == true)
                {
                    if (versionPribor.Contains("2"))
                    {
                        Thread.Sleep(3);
                    }
                    else
                    {
                        Thread.Sleep(3);
                    }
                }
                else
                {
                    //Thread.Sleep(1000);
                }

                indata_0 = "";

                while (indata_0.Contains("\r>") == false)
                {
                    indata = newPort.ReadExisting();
                    indata_0 += indata;
                }
                index = 0;
                index1 = 0;
                countSub = 0;
                while ((index = indata_0.IndexOf("\r", index)) != -1)
                {
                    // Console.WriteLine(index);
                    index += "\r".Length;
                    if (countSub < 2)
                    {
                        index1 = index;
                    }
                    countSub++;
                }
                if (countSub > 2)
                {
                    indata_0 = indata_0.Substring(0, index1);
                }

                GE5_1 = regex.Replace(indata_0, "");
                GE5_1 = regex1.Replace(GE5_1, "");
                GE5_1_0 = GE5_1;
            }

            ScanSpectrChartZero.Add(new List<double>() { Convert.ToDouble(countSA), Convert.ToDouble(GE5_1_0) });
        }

        public void TableScan(double seria)
        {
            Regex regex = new Regex(@"\W");
            Regex regex1 = new Regex(@"\D");
            int countscan = 0;
            for (double i = start; i > cancel - step; i -= step)
            {
                double GEIZMERmass = 0;
                string GE5Izmer = "";
                while (GE5Izmer == "")
                {
                    SW_Scan(Math.Round(i, 1));

                    newPort.Write("SA " + ScanSpectrChartZero[countscan][0] + "\r");

                    string indata = "";
                    while (indata.Contains(">") == false)
                    {
                        indata = newPort.ReadExisting();
                    }

                    for (int j = 0; j < 10; j++)
                    {
                        newPort.Write("GE 1\r");

                        if (ResponseModeNormal == true)
                        {
                            if (versionPribor.Contains("2"))
                            {
                                Thread.Sleep(3);
                            }
                            else
                            {
                                Thread.Sleep(3);
                            }
                        }
                        else
                        {
                            //Thread.Sleep(1000);
                        }

                        string indata_0 = "";

                        while (indata_0.Contains("\r>") == false)
                        {
                            indata = newPort.ReadExisting();
                            indata_0 += indata;
                        }
                        int index = 0;
                        int index1 = 0;
                        int countSub = 0;
                        while ((index = indata_0.IndexOf("\r", index)) != -1)
                        {
                            // Console.WriteLine(index);
                            index += "\r".Length;
                            if (countSub < 2)
                            {
                                index1 = index;
                            }
                            countSub++;
                        }
                        if (countSub > 2)
                        {
                            indata_0 = indata_0.Substring(0, index1);
                        }
                        GE5Izmer = regex.Replace(indata_0, "");
                        GE5Izmer = regex1.Replace(GE5Izmer, "");
                        GEIZMERmass += Convert.ToDouble(GE5Izmer);
                    }
                    GEIZMERmass = GEIZMERmass / 10;
                    //GE5Izmer = Convert.ToString(GEIZMERmass);
                }

                ScanSpectrChart_[Convert.ToInt32(seria)].Add(new List<double> { i, GEIZMERmass });

                
            }
        }

        public void TableScan_Save()
        {


        }

    }
}
