﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ecoview_Сканирование_спектра
{
    class RD
    {
        Connection _Conection;
        public RD(Connection parent)
        {
            this._Conection = parent;
            _Conection.newPort.Write("RD 1\r");

            Thread.Sleep(500);
            //  byte[] buffer1 = new byte[byteRecieved1];
            string indata = _Conection.newPort.ReadExisting();

            bool indata_bool = true;
            while (indata_bool == true)
            {
                if (indata.Contains(">"))
                {

                    indata_bool = false;

                }

                else
                {

                    indata = _Conection.newPort.ReadExisting();

                }
            }

            string substring = "\r";
            int count = (indata.Length - indata.Replace(substring, "").Length) / substring.Length;
            _Conection.RDstring = new string[count];
            // Regex regex = new Regex(@"\W");
            for (int i = 0; i < count; i++)
            {
                _Conection.RDstring[i] = indata.Split('\r')[i]; ;
            }
        }
    }
}
