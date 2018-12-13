using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ecoview_Сканирование_спектра
{
    class PortClose
    {
        Ecoview _Analis;
        public PortClose(Ecoview parent)
        {
            this._Analis = parent;
            try
            {
                if (_Analis.ComPort == true)
                {
                    char[] ClosePribor = { Convert.ToChar('Q'), Convert.ToChar('U'), Convert.ToChar('\r') };
                    _Analis.newPort.Write("QU\r");
                    Thread.Sleep(500);
                    //  byte[] buffer1 = new byte[byteRecieved1];
                    string indata = _Analis.newPort.ReadExisting();
                    bool indata_bool = true;
                    while (indata_bool == true)
                    {
                        if (indata.Contains(">"))
                        {

                            indata_bool = false;

                        }

                        else
                        {
                            indata = _Analis.newPort.ReadExisting();
                        }
                    }

                    _Analis.GWNew.Text = null;
                    //  _Analis.GEText.Text = null;
                    //  _Analis.GAText.Text = null;
                    //  _Analis.OptichPlot.Text = null;



                    _Analis.newPort.Close();
                    _Analis.wavelength1 = Convert.ToString(0);
                    // ComPort = false;
                    _Analis.ComPort = false;
                    _Analis.ComPodkl = false;
                }
            }
            catch
            {
                MessageBox.Show("Прервана связь с прибором. Подключитесь снова!");
               // SWF.Application.OpenForms["LogoFrm"].Close();
                _Analis.GWNew.Text = null;



                if (_Analis.versionPribor != null && _Analis.versionPribor != "")
                {
                    _Analis.newPort.Close();
                }
                _Analis.wavelength1 = Convert.ToString(0);
                // ComPort = false;
                _Analis.ComPort = false;
                _Analis.ComPodkl = false;
                _Analis.StopSpectr = true;
                _Analis.StopAgro = true;


                return;
            }
        }
    }
}
