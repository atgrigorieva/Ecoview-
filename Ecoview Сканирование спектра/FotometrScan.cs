using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecoview_Сканирование_спектра
{
    public partial class FotometrScan : Form
    {
        CreateDimension _Analis;
        string versionPribor;
       
        
        public FotometrScan(CreateDimension parent, string versionPribor1)
        {
            InitializeComponent();
            this._Analis = parent;
            this.versionPribor = versionPribor1;
            
        }

        private void FotometrScan_Load(object sender, EventArgs e)
        {

        }

        private void Averaging_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Averaging.Checked == true)
            {
                this.numericUpDown1.Enabled = true;
            }
            else
            {
                this.numericUpDown1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox2.Text) < Convert.ToDouble(textBox3.Text))
            {
                MessageBox.Show("Начальная длина волны не может быть меньше последней!");
                return;
            }
            else
            {
                _Analis.start = Convert.ToDouble(textBox2.Text);
                _Analis.cancel = Convert.ToDouble(textBox3.Text);
                _Analis.step = Convert.ToDouble(comboBox1.SelectedItem.ToString());
                _Analis.countChart = Convert.ToInt32(numericUpDown1.Value.ToString());
                _Analis.Description = textBox1.Text;
                if (comboBox2.SelectedItem.ToString() == "Нормальный")
                {
                    _Analis.ResponseModeNormal = true;
                }
                else
                {
                    _Analis.ResponseModeNormal = false;
                }

                if (radioButton1.Checked == true)
                {
                    _Analis.typeIzmer = "Abs";

                }
                else
                {
                    _Analis.typeIzmer = "%T";

                }
                _Analis.ScanSpectrWindows();
                //_Analis.ScaTableCreate();
                // _Analis.button10.Enabled = true;
                Close();
            }
        }
    }
}
