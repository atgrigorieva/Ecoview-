using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Linq;

namespace Ecoview_Сканирование_спектра
{
    class OpenAll
    {
        Ecoview _Analis;
        public OpenAll(Ecoview parent)
        {
            this._Analis = parent;
            TableScan_Open();
        }
        public void TableScan_Open()
        {
            _Analis.openFileDialog1.InitialDirectory = "C";
            _Analis.openFileDialog1.Title = "Open File";
            _Analis.openFileDialog1.FileName = "";
            _Analis.openFileDialog1.Filter = "CSV файл|*.csv";
            if (_Analis.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _Analis.ScanChart.Series[0].Points.Clear();
                _Analis.ScanChart.Series[1].Points.Clear();
                _Analis.ScanChart.Series.Clear();
                _Analis.ScanChart.Series.Add("Series1");
                _Analis.ScanChart.Series.Add("Series2");
                _Analis.listBox1.Items.Clear();
                

                _Analis.dataGridView1.Rows.Clear();
                _Analis.dataGridView2.Rows.Clear();

                try
                {
                    // получаем выбранный файл
                    _Analis.filepath = _Analis.openFileDialog1.FileName;

                    using (TextFieldParser parser = new TextFieldParser(@_Analis.filepath))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(";");
                        _Analis.ScanSpectrChart = new List<List<List<double>>>();
                        _Analis.ScanSpectrChart.Add(new List<List<double>>());
                        //double[] filds_;
                        while (!parser.EndOfData)
                        {
                            //Processing row
                            
                            string[] fields = parser.ReadFields();
                            ///filds_ = new double[fields.Length - 1];
                            if (fields.Length == 2)
                            {
                                _Analis.typeIzmer = fields[1];
                            }
                            if (fields.Length > 3)
                            {
                                
                                _Analis.ScanSpectrChart[0].Add(new List<double> { Convert.ToDouble(fields[0]), Convert.ToDouble(fields[1]), Convert.ToDouble(fields[2]) });

                                
                                double x1 = Convert.ToDouble(fields[0]);
                                double y1 = 0;
                                if (_Analis.typeIzmer == "Abs")
                                {
                                    y1 = Convert.ToDouble(fields[1]); ;
                                }
                                else
                                {
                                    y1 = Convert.ToDouble(fields[2]);
                                }


                                _Analis.ScanChart.Series[_Analis.ScanSpectrChart.Count - 1].Points.AddXY(x1, y1);
                                _Analis.ScanChart.Series[_Analis.ScanSpectrChart.Count - 1].ChartType = SeriesChartType.Line;
                            }
                        }
                        _Analis.ScanChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                        _Analis.ScanChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                        _Analis.ScanChart.ChartAreas[0].AxisX.Minimum = _Analis.ScanSpectrChart[0][_Analis.ScanSpectrChart[0].Count-1][0];
                        _Analis.ScanChart.ChartAreas[0].AxisX.Maximum = _Analis.ScanSpectrChart[0][0][0];
                        _Analis.ScanChart.ChartAreas[0].AxisX.Title = "Длина волны";
                        if (_Analis.typeIzmer == "Abs")
                        {
                            _Analis.ScanChart.ChartAreas[0].AxisY.Title = "Abs";
                            _Analis.ScanChart.ChartAreas[0].AxisY.Minimum = 0;
                            _Analis.ScanChart.ChartAreas[0].AxisY.Maximum = 4;
                        }
                        else
                        {
                            _Analis.ScanChart.ChartAreas[0].AxisY.Title = "%T";
                            _Analis.ScanChart.ChartAreas[0].AxisY.Minimum = 0;
                            _Analis.ScanChart.ChartAreas[0].AxisY.Maximum = 105;
                        }
                    }


                    //loadCsvFile(_Analis.filepath);

                }
                catch (Exception t) { MessageBox.Show("exeption" + t.Message); }
            }
        }

        public void Person(string line)
        {
            var split = line.Split(';');
            string WL = split[0];
            string Abs = split[1];
            string t = split[2];
        }


        public List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            reader.Close();
            return searchList;
        }

    }
}
