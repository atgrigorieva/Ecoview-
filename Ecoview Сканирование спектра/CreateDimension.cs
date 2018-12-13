using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecoview_Сканирование_спектра
{
    public class CreateDimension
    {
        Ecoview _Analis;
        public string GWString;
        public int countSTR;
        public string k1_linear0;
        public string Description;
        public string DateTime;
        public string Ispolnitel;
        public string direction;
        public string code;
        public TextBox[] textBox = new TextBox[20];
        public TextBox[] textBoxCO = new TextBox[20];
        public int NoCoIzmer;
        public string edconctr;
        public string SposobZadan;
        public string Zavisimoct;
        public string aproksim;
        public bool ResponseModeNormal = true;
        public string Veshestvo1;
        public string WidthCuvette;
        public string ND;
        public int Days;
        public string CountSeriya, CountInSeriya, NoCaIzm1, NoCaSer1;
        public string BottomLine, TopLine;
        public double k0, k1, k2;
        public bool USE_KO;
        public string F1, F2, errorMethod;
        public double start = 0.0, cancel = 0.0, interval, delay;
        public double[] massWL;
        public double[] massGE;
        public string[][,] countScan;
        public int countscan = 0;
        public string typeIzmer;
        public int index;
        public OpenFileDialog openFileDialog1;
        
        public string filepath;
        public double shag;


        public int countChart;
        public double step;
        public CreateDimension(Ecoview parent)
        {
            this._Analis = parent;
            Description = _Analis.Description;
            
            
           
            if (_Analis.ComPort == true)
            {
                GWString = _Analis.GWNew.Text;
            }
            else
            {
                GWString = _Analis.wavelength1;
            }
            if (_Analis.ComPodkl == true)
            {

                FotometrScan fotometrScan = new FotometrScan(this, _Analis.versionPribor);
                fotometrScan.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Для проведения сканирования необхдимо подключиться к прибору!");
            }


        }

        public void ScanSpectrWindows()
        {
            _Analis.start = start;
            _Analis.cancel = cancel;
            _Analis.step = step;
            _Analis.countChart = countChart;
            _Analis.ScanSpectrChart = new List<List<List<double>>>();
            _Analis.typeIzmer = typeIzmer;
            //_Analis.coutPressPlay = 0;
        }
    }
}
