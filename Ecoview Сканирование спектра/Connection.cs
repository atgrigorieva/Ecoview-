using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Ecoview_Сканирование_спектра
{
    public class Connection
    {
        Ecoview _Analis;
        public Connection(Ecoview parent)
        {
            this._Analis = parent;
            COnectionPort();


        }
        public bool nonPort;
        public string portsName;
        public SerialPort newPort;
        public string[] RDstring;
        public int countSA;
        public string GE5_1_0 = "";
        public int indata_zero;
        public string versionPribor; //версия прибора
        public string wavelength1;
        public TextBox GWNew;
        public string GW1_2;
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/";
        public void COnectionPort()
        {
            // SettingPort _SettingPort = new SettingPort(_Analis.nonPort, _Analis.portsName);
            newPort = new SerialPort();
            SettingPort _SettingPort = new SettingPort(this);
            _Analis.newPort = newPort;
            _Analis.nonPort = nonPort;
            _Analis.portsName = portsName;
            if (_Analis.nonPort == true)
            {
                _SettingPort.ShowDialog();
            }
            else
            {
                _SettingPort.Dispose();
            }
            _Analis.newPort = newPort;
            _Analis.nonPort = nonPort;
            _Analis.portsName = portsName;
            if (_Analis.nonPort == true)
            {
                _Analis.newPort = new SerialPort();

                try
                {
                    // настройки порта (Communication interface)
                    _Analis.newPort.PortName = _Analis.portsName;
                    _Analis.newPort.BaudRate = 19200;
                    _Analis.newPort.DataBits = 8;
                    _Analis.newPort.Parity = System.IO.Ports.Parity.None;
                    _Analis.newPort.StopBits = System.IO.Ports.StopBits.One;
                    // Установка таймаутов чтения/записи (read/write timeouts)
                    //_Analis.newPort.ReadTimeout = 20000;
                    //_Analis.newPort.WriteTimeout = 1;
                    //    newPort.DataReceived += new SerialDataReceivedEventHandler(newPort_DataReceived);
                    _Analis.newPort.RtsEnable = false;
                    _Analis.newPort.DtrEnable = true;
                    _Analis.newPort.Open();// MessageBox.Show("ПОРТ ОТКРЫТ " + newPort.PortName);


                    _Analis.newPort.DiscardInBuffer();
                    _Analis.newPort.DiscardOutBuffer();
                }
                catch (Exception)
                {
                    MessageBox.Show("Порт не был выбран!");
                    return;

                }
                newPort = _Analis.newPort;
                string openport = path + "/pribor/openport.port";
                File.WriteAllText(openport, string.Empty);
                File.AppendAllText(openport, _Analis.portsName, Encoding.UTF8);
                string pathTemp = Path.GetTempPath();
                EncriptorPribor encriptSerNomer = new EncriptorPribor(openport, pathTemp);

                _Analis.newPort.Write("CO\r");
                GWNew = _Analis.GWNew;
                wavelength1 = GWNew.Text;
                SettingWL setingwl = new SettingWL(this);
                _Analis.nonPort = nonPort;
                _Analis.portsName = portsName;
                //CO();
                RD rd = new RD(this);
                newPort = _Analis.newPort;
                _Analis.RDstring = RDstring;
                _Analis.ComPodkl = true;

                //sage.SAGE1(this);
                SAGE sage = new SAGE(ref _Analis.countSA, ref _Analis.GE5_1_0, ref versionPribor, ref newPort, ref _Analis.ResponseModeNormal);
                _Analis.versionPribor = versionPribor;






            }


        }
    }
}
