namespace Ecoview_Сканирование_спектра
{
    partial class SettingPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NamePort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connection = new System.Windows.Forms.Button();
            this.selectPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NamePort
            // 
            this.NamePort.AutoSize = true;
            this.NamePort.Location = new System.Drawing.Point(12, 21);
            this.NamePort.Name = "NamePort";
            this.NamePort.Size = new System.Drawing.Size(61, 13);
            this.NamePort.TabIndex = 10;
            this.NamePort.Text = "Имя порта";
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(51, 65);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(118, 23);
            this.connection.TabIndex = 12;
            this.connection.Text = "Подключить";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // selectPort
            // 
            this.selectPort.FormattingEnabled = true;
            this.selectPort.Location = new System.Drawing.Point(90, 18);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(121, 21);
            this.selectPort.TabIndex = 11;
            // 
            // SettingPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 118);
            this.Controls.Add(this.NamePort);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.selectPort);
            this.Name = "SettingPort";
            this.Text = "Выбор порта";
            this.Load += new System.EventHandler(this.SettingPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamePort;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button connection;
        private System.Windows.Forms.ComboBox selectPort;
    }
}