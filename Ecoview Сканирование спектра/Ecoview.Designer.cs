namespace Ecoview_Сканирование_спектра
{
    partial class Ecoview
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ScanChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label51 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dl_wl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label52 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label50 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.sill = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.OnlyChart = new System.Windows.Forms.RadioButton();
            this.shoulder = new System.Windows.Forms.RadioButton();
            this.MaxMin = new System.Windows.Forms.RadioButton();
            this.MaximumRadio = new System.Windows.Forms.RadioButton();
            this.MinimumRadio = new System.Windows.Forms.RadioButton();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.GWNew = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ScanChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanChart
            // 
            this.ScanChart.BackColor = System.Drawing.Color.Honeydew;
            this.ScanChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScanChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.MinorGrid.Enabled = true;
            chartArea4.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.MinorTickMark.Enabled = true;
            chartArea4.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea4.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea4.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.Title = "Оптическая плотность, А";
            chartArea4.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX2.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX2.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX2.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX2.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea4.AxisX2.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea4.AxisX2.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea4.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea4.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisY.Title = "Концетрация";
            chartArea4.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisY2.ScrollBar.BackColor = System.Drawing.Color.MintCream;
            chartArea4.AxisY2.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea4.AxisY2.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.BackColor = System.Drawing.Color.GhostWhite;
            chartArea4.Name = "ChartArea1";
            this.ScanChart.ChartAreas.Add(chartArea4);
            this.ScanChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScanChart.Location = new System.Drawing.Point(12, 12);
            this.ScanChart.Name = "ScanChart";
            this.ScanChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.ScanChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.IsVisibleInLegend = false;
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsVisibleInLegend = false;
            series8.LabelForeColor = System.Drawing.Color.Maroon;
            series8.Name = "Series2";
            this.ScanChart.Series.Add(series7);
            this.ScanChart.Series.Add(series8);
            this.ScanChart.Size = new System.Drawing.Size(795, 391);
            this.ScanChart.TabIndex = 24;
            this.ScanChart.Text = "ScanChart";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.Location = new System.Drawing.Point(865, 12);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(187, 20);
            this.label51.TabIndex = 26;
            this.label51.Text = "Таблица максимумов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dl_wl1,
            this.MAX,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(837, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 186);
            this.dataGridView1.TabIndex = 25;
            // 
            // Dl_wl1
            // 
            this.Dl_wl1.HeaderText = "ДВ";
            this.Dl_wl1.Name = "Dl_wl1";
            this.Dl_wl1.ReadOnly = true;
            this.Dl_wl1.Width = 70;
            // 
            // MAX
            // 
            this.MAX.HeaderText = "Abs";
            this.MAX.Name = "MAX";
            this.MAX.ReadOnly = true;
            this.MAX.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "%T";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.Location = new System.Drawing.Point(885, 238);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(167, 20);
            this.label52.TabIndex = 28;
            this.label52.Text = "Таблица миниумов";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MIN,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(840, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(247, 186);
            this.dataGridView2.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ДВ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // MIN
            // 
            this.MIN.HeaderText = "Abs";
            this.MIN.Name = "MIN";
            this.MIN.ReadOnly = true;
            this.MIN.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "%T";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.Location = new System.Drawing.Point(881, 464);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(200, 20);
            this.label50.TabIndex = 30;
            this.label50.Text = "Последние измерения";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(840, 490);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 186);
            this.listBox1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox13);
            this.groupBox1.Controls.Add(this.dataGridView5);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 430);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с графиком";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(586, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 60);
            this.button3.TabIndex = 33;
            this.button3.Text = "Отметить на графике";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(359, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 60);
            this.button2.TabIndex = 33;
            this.button2.Text = "Отметить на графике";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(206, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 60);
            this.button1.TabIndex = 33;
            this.button1.Text = "Отметить на графике";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.sill);
            this.groupBox13.Controls.Add(this.label4);
            this.groupBox13.Controls.Add(this.OnlyChart);
            this.groupBox13.Controls.Add(this.shoulder);
            this.groupBox13.Controls.Add(this.MaxMin);
            this.groupBox13.Controls.Add(this.MaximumRadio);
            this.groupBox13.Controls.Add(this.MinimumRadio);
            this.groupBox13.Location = new System.Drawing.Point(15, 26);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(243, 167);
            this.groupBox13.TabIndex = 32;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Минимумы Или Максимумы";
            // 
            // sill
            // 
            this.sill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sill.Location = new System.Drawing.Point(65, 131);
            this.sill.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sill.Name = "sill";
            this.sill.Size = new System.Drawing.Size(43, 22);
            this.sill.TabIndex = 34;
            this.sill.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sill.ValueChanged += new System.EventHandler(this.sill_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Порог";
            // 
            // OnlyChart
            // 
            this.OnlyChart.AutoSize = true;
            this.OnlyChart.Location = new System.Drawing.Point(6, 111);
            this.OnlyChart.Name = "OnlyChart";
            this.OnlyChart.Size = new System.Drawing.Size(102, 17);
            this.OnlyChart.TabIndex = 26;
            this.OnlyChart.Text = "Только график";
            this.OnlyChart.UseVisualStyleBackColor = true;
            this.OnlyChart.CheckedChanged += new System.EventHandler(this.OnlyChart_CheckedChanged);
            // 
            // shoulder
            // 
            this.shoulder.AutoSize = true;
            this.shoulder.Location = new System.Drawing.Point(6, 88);
            this.shoulder.Name = "shoulder";
            this.shoulder.Size = new System.Drawing.Size(56, 17);
            this.shoulder.TabIndex = 26;
            this.shoulder.Text = "Плечо";
            this.shoulder.UseVisualStyleBackColor = true;
            this.shoulder.CheckedChanged += new System.EventHandler(this.shoulder_CheckedChanged);
            // 
            // MaxMin
            // 
            this.MaxMin.AutoSize = true;
            this.MaxMin.Checked = true;
            this.MaxMin.Location = new System.Drawing.Point(6, 65);
            this.MaxMin.Name = "MaxMin";
            this.MaxMin.Size = new System.Drawing.Size(139, 17);
            this.MaxMin.TabIndex = 26;
            this.MaxMin.TabStop = true;
            this.MaxMin.Text = "Максимум и Минимум";
            this.MaxMin.UseVisualStyleBackColor = true;
            this.MaxMin.CheckedChanged += new System.EventHandler(this.MaxMin_CheckedChanged);
            // 
            // MaximumRadio
            // 
            this.MaximumRadio.AutoSize = true;
            this.MaximumRadio.Location = new System.Drawing.Point(6, 42);
            this.MaximumRadio.Name = "MaximumRadio";
            this.MaximumRadio.Size = new System.Drawing.Size(79, 17);
            this.MaximumRadio.TabIndex = 26;
            this.MaximumRadio.Text = "Максимум";
            this.MaximumRadio.UseVisualStyleBackColor = true;
            this.MaximumRadio.CheckedChanged += new System.EventHandler(this.MaximumRadio_CheckedChanged);
            // 
            // MinimumRadio
            // 
            this.MinimumRadio.AutoSize = true;
            this.MinimumRadio.Location = new System.Drawing.Point(6, 19);
            this.MinimumRadio.Name = "MinimumRadio";
            this.MinimumRadio.Size = new System.Drawing.Size(73, 17);
            this.MinimumRadio.TabIndex = 25;
            this.MinimumRadio.Text = "Минимум";
            this.MinimumRadio.UseVisualStyleBackColor = true;
            this.MinimumRadio.CheckedChanged += new System.EventHandler(this.MinimumRadio_CheckedChanged);
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView5.Location = new System.Drawing.Point(532, 45);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(247, 186);
            this.dataGridView5.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ДВ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Abs";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 65;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "%T";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 65;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView4.Location = new System.Drawing.Point(279, 45);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(247, 186);
            this.dataGridView4.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ДВ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Abs";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "%T";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(528, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ручная разметка максимумов";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView3.Location = new System.Drawing.Point(15, 237);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(185, 186);
            this.dataGridView3.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Левое плечо";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Правое плечо";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(275, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ручная разметка минимумов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Таблица Плечей";
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.Location = new System.Drawing.Point(905, 682);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(136, 36);
            this.Connect.TabIndex = 33;
            this.Connect.Text = "Подключение";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(818, 724);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 29);
            this.button4.TabIndex = 33;
            this.button4.Text = "Новое";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Excel
            // 
            this.Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Excel.Location = new System.Drawing.Point(960, 724);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(136, 29);
            this.Excel.TabIndex = 33;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(818, 759);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 29);
            this.button6.TabIndex = 33;
            this.button6.Text = "Открытие";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(818, 794);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 29);
            this.button7.TabIndex = 33;
            this.button7.Text = "Калибровка";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(960, 794);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 29);
            this.button8.TabIndex = 33;
            this.button8.Text = "Измерить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // GWNew
            // 
            this.GWNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GWNew.Location = new System.Drawing.Point(818, 684);
            this.GWNew.Name = "GWNew";
            this.GWNew.ReadOnly = true;
            this.GWNew.Size = new System.Drawing.Size(83, 29);
            this.GWNew.TabIndex = 84;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(960, 759);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(136, 29);
            this.Save.TabIndex = 33;
            this.Save.Text = "Сохранение";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Ecoview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 859);
            this.Controls.Add(this.GWNew);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ScanChart);
            this.Name = "Ecoview";
            this.Text = "Ecoview Сканирование спектра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ecoview_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ecoview_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ScanChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart ScanChart;
        private System.Windows.Forms.Label label51;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dl_wl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label52;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label50;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton OnlyChart;
        private System.Windows.Forms.RadioButton MaxMin;
        private System.Windows.Forms.RadioButton MaximumRadio;
        private System.Windows.Forms.RadioButton MinimumRadio;
        private System.Windows.Forms.RadioButton shoulder;
        public System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox GWNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sill;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

