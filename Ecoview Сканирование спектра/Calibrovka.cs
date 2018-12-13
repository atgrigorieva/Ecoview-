using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecoview_Сканирование_спектра
{
    class Calibrovka
    {
        Ecoview _Analis;
        public Calibrovka(Ecoview parent)
        {
            this._Analis = parent;

            
            try
            {
                _Analis.ScanSpectrChartZero = new List<List<double>>();

                for(double i = _Analis.start; i > _Analis.cancel - _Analis.step; i -= _Analis.step)
                {
                    _Analis.GWNew.Text = string.Format("{0:0.0}", Math.Round(i, 1));
                    _Analis.SW_Scan(Math.Round(i, 1));
                    _Analis.SAGEScan();
                }
               
                MessageBox.Show("Калибровка закончена!");
               
            }
            catch
            {

            }
        }
    }
}
