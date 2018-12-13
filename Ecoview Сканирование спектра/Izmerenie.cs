using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ecoview_Сканирование_спектра
{
    class Izmerenie
    {
        Ecoview _Analis;
        public Izmerenie(Ecoview parent)
        {
            this._Analis = parent;
            _Analis.ScanSpectrChart_ = new List<List<List<double>>>();
            for (double i = 0; i < _Analis.countChart; i++)
            {
                _Analis.ScanSpectrChart_.Add(new List<List<double>>());

                _Analis.TableScan(i);
            }
            
            _Analis.ScanSpectrChart.Add(new List<List<double>>());
            int countWL = 0;
            for (double j = _Analis.start; j > _Analis.cancel - _Analis.step; j -= _Analis.step)
            {
                double abs = 0.0, t = 0.0;
                
                for (int i = 0; i < _Analis.countChart; i++)
                {
                    double energi = Convert.ToDouble(_Analis.ScanSpectrChart_[i][countWL][1]);
                    double energi_zero = Convert.ToInt32(_Analis.ScanSpectrChartZero[countWL][1]);
                    int sa_zero = Convert.ToInt32(_Analis.ScanSpectrChartZero[countWL][0]);

                    abs += Convert.ToDouble(string.Format("{0:0.000}",
                        Math.Log10((energi_zero - Convert.ToDouble(_Analis.RDstring[sa_zero])) /
                        (Convert.ToDouble(energi) - Convert.ToDouble(_Analis.RDstring[sa_zero])))));

                    t += Convert.ToDouble(string.Format("{0:0.00}",
                        ((energi - Convert.ToDouble(_Analis.RDstring[sa_zero])) /
                        (energi_zero - Convert.ToDouble(_Analis.RDstring[sa_zero])) * 100)));


                    //energi += _Analis.ScanSpectrChart_[i][countWL][1];
                }
                countWL++;

                //energi = energi / _Analis.countChart;



                _Analis.ScanSpectrChart[_Analis.ScanSpectrChart.Count-1].Add(new List<double> { Math.Round(j, 1), abs / _Analis.countChart, t / _Analis.countChart});

                double x1 = j;
                double y1 = 0;
                if (_Analis.typeIzmer == "Abs")
                {
                    y1 = abs / _Analis.countChart;
                }
                else
                {
                    y1 = t / _Analis.countChart;
                }
                

                _Analis.ScanChart.Series[_Analis.ScanSpectrChart.Count - 1].Points.AddXY(x1, y1);
                _Analis.ScanChart.Series[_Analis.ScanSpectrChart.Count - 1].ChartType = SeriesChartType.Line;
            }
            _Analis.ScanChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            _Analis.ScanChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            _Analis.ScanChart.ChartAreas[0].AxisX.Minimum = _Analis.cancel;
            _Analis.ScanChart.ChartAreas[0].AxisX.Maximum = _Analis.start;
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

            ///_Analis.TableScan_Save();
            //_Analis.ScanTable_Save();

            /// _Analis.coutPressPlay++;
            _Analis.countButtonClick++;
        }
    }
}
