using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Ecoview_Сканирование_спектра
{
    class SaveAll
    {
        Ecoview _Analis;
        public SaveAll(Ecoview parent)
        {
            this._Analis = parent;
            SaveScan();
        }
        public void SaveScan()
        {
            SaveAsScanTable();
        }
        public void SaveAsScanTable()
        {
            _Analis.saveFileDialog1.InitialDirectory = "C";
            _Analis.saveFileDialog1.Title = "Save as CSV File";
            _Analis.saveFileDialog1.FileName = "";
            _Analis.saveFileDialog1.Filter = "CSV файл|*.csv";
            if (_Analis.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                CreateXMLDocumentIzmerenieScan(ref _Analis.filepath);
               
            }
        }
        public void CreateXMLDocumentIzmerenieScan(ref string filepath)
        {
            filepath = _Analis.saveFileDialog1.FileName;
            using (Stream stream = File.OpenWrite(filepath))
            {
                stream.SetLength(0);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    // loop through each row of our DataGridView
                    string typeIzmer = "Type Izmerenie;" + _Analis.typeIzmer;
                    writer.WriteLine(typeIzmer);
                    string lineHeader = "WL; Abs; %T";
                    writer.WriteLine(lineHeader);
                    for (int i = 0; i < _Analis.ScanSpectrChart[0].Count; i++)
                    {
                        string line = "";
                        for (int j = 0; j < 3; j++)
                        {
                            line = line + _Analis.ScanSpectrChart[0][i][j] + ";";
                        }
                        writer.WriteLine(line);
                    }


                    

                    writer.Flush();
                }
            };
        }

    }
}
