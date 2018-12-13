using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Ecoview_Сканирование_спектра
{
    class ExportExcelAll
    {
        Ecoview _Analis;
        public ExportExcelAll(Ecoview parent)
        {
            this._Analis = parent;
            RegistryKey hkcr = Registry.ClassesRoot;
            RegistryKey excelKey = hkcr.OpenSubKey("Excel.Application");
            bool excelInstalled = excelKey == null ? false : true;
            if (excelInstalled == true)
            {
                SaveExcelScan();
            }
        }
        public void SaveExcelScan()
        {
            ExportToExcelScan();
        }
        public void ExportToExcelScan()
        {
            _Analis.saveFileDialog1.InitialDirectory = "C";
            _Analis.saveFileDialog1.Title = "Save as Excel File";
            _Analis.saveFileDialog1.FileName = "";
            _Analis.saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            if (_Analis.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Application.Interactive = false;
                exApp.Application.Workbooks.Add(Type.Missing);
                exApp.Columns.ColumnWidth = 20;
               /* exApp.Cells[1, 0].Value = "Длина волны";
                exApp.Cells[1, 1].Value = "Abs";
                exApp.Cells[1, 2].Value = "%T";*/
                for (int i = 0; i < _Analis.ScanSpectrChart[0].Count-1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        //MessageBox.Show(this._Analis.ScanSpectrChart[0][i][j].ToString());
                        exApp.Cells[i + 2, j + 1] = Convert.ToDouble(this._Analis.ScanSpectrChart[0][i][j]);
                    }
                }


                for (int i = 0; i < _Analis.ScanSpectrChart_[0].Count - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        //MessageBox.Show(this._Analis.ScanSpectrChart[0][i][j].ToString());
                        exApp.Cells[i + 101, j + 1] = Convert.ToDouble(this._Analis.ScanSpectrChart_[0][i][j]);
                    }
                }
                for (int i = 0; i < _Analis.ScanSpectrChart_[0].Count - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        //MessageBox.Show(this._Analis.ScanSpectrChart[0][i][j].ToString());
                        exApp.Cells[i + 101, j + 5] = Convert.ToDouble(this._Analis.ScanSpectrChart_[0][i][j]);
                    }
                }

                for (int i = 0; i < _Analis.ScanSpectrChart_[0].Count - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        //MessageBox.Show(this._Analis.ScanSpectrChart[0][i][j].ToString());
                        exApp.Cells[i + 101, j + 8] = Convert.ToDouble(this._Analis.ScanSpectrChart_[0][i][j]);
                    }
                }


                exApp.ActiveWorkbook.SaveCopyAs(_Analis.saveFileDialog1.FileName.ToString());
                exApp.ActiveWorkbook.Saved = true;

                exApp.Visible = true;
                exApp.Application.Interactive = true;
            }
        }

    }
}
