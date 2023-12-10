
namespace Tyuiu.AvaevaPD.Sprint6.Task4.V14
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_APD = new System.Windows.Forms.GroupBox();
            this.labelUslovie_APD = new System.Windows.Forms.Label();
            this.groupBoxVuvod_APD = new System.Windows.Forms.GroupBox();
            this.textBoxStart_APD = new System.Windows.Forms.TextBox();
            this.textBoxStop_APD = new System.Windows.Forms.TextBox();
            this.labelStart_APD = new System.Windows.Forms.Label();
            this.labelStop_APD = new System.Windows.Forms.Label();
            this.buttonSohranit_APD = new System.Windows.Forms.Button();
            this.buttonVupolnit_APD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartOne_APD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxVuvod_APD = new System.Windows.Forms.TextBox();
            this.buttonSpravka_APD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_APD.SuspendLayout();
            this.groupBoxVuvod_APD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_APD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Controls.Add(this.labelUslovie_APD);
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(12, 3);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(507, 105);
            this.groupBoxUslovie_APD.TabIndex = 0;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие";
            // 
            // labelUslovie_APD
            // 
            this.labelUslovie_APD.AutoSize = true;
            this.labelUslovie_APD.Location = new System.Drawing.Point(17, 22);
            this.labelUslovie_APD.Name = "labelUslovie_APD";
            this.labelUslovie_APD.Size = new System.Drawing.Size(451, 68);
            this.labelUslovie_APD.TabIndex = 1;
            this.labelUslovie_APD.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести" +
    " в textBox.\r\n Построить график функции и сохранить в файл\r\n OutPutFileTask4V14.t" +
    "xt по нажатию кнопки.  ";
            // 
            // groupBoxVuvod_APD
            // 
            this.groupBoxVuvod_APD.Controls.Add(this.buttonSpravka_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.buttonVupolnit_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.buttonSohranit_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.labelStop_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.labelStart_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.textBoxStop_APD);
            this.groupBoxVuvod_APD.Controls.Add(this.textBoxStart_APD);
            this.groupBoxVuvod_APD.Location = new System.Drawing.Point(544, 13);
            this.groupBoxVuvod_APD.Name = "groupBoxVuvod_APD";
            this.groupBoxVuvod_APD.Size = new System.Drawing.Size(785, 94);
            this.groupBoxVuvod_APD.TabIndex = 1;
            this.groupBoxVuvod_APD.TabStop = false;
            this.groupBoxVuvod_APD.Text = "Ввод данных";
            // 
            // textBoxStart_APD
            // 
            this.textBoxStart_APD.Location = new System.Drawing.Point(24, 61);
            this.textBoxStart_APD.Name = "textBoxStart_APD";
            this.textBoxStart_APD.Size = new System.Drawing.Size(149, 22);
            this.textBoxStart_APD.TabIndex = 0;
            // 
            // textBoxStop_APD
            // 
            this.textBoxStop_APD.Location = new System.Drawing.Point(254, 61);
            this.textBoxStop_APD.Name = "textBoxStop_APD";
            this.textBoxStop_APD.Size = new System.Drawing.Size(149, 22);
            this.textBoxStop_APD.TabIndex = 1;
            // 
            // labelStart_APD
            // 
            this.labelStart_APD.AutoSize = true;
            this.labelStart_APD.Location = new System.Drawing.Point(30, 41);
            this.labelStart_APD.Name = "labelStart_APD";
            this.labelStart_APD.Size = new System.Drawing.Size(87, 17);
            this.labelStart_APD.TabIndex = 2;
            this.labelStart_APD.Text = "Старт шага:";
            // 
            // labelStop_APD
            // 
            this.labelStop_APD.AutoSize = true;
            this.labelStop_APD.Location = new System.Drawing.Point(261, 41);
            this.labelStop_APD.Name = "labelStop_APD";
            this.labelStop_APD.Size = new System.Drawing.Size(89, 17);
            this.labelStop_APD.TabIndex = 3;
            this.labelStop_APD.Text = "Конец шага:";
            // 
            // buttonSohranit_APD
            // 
            this.buttonSohranit_APD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSohranit_APD.Location = new System.Drawing.Point(541, 21);
            this.buttonSohranit_APD.Name = "buttonSohranit_APD";
            this.buttonSohranit_APD.Size = new System.Drawing.Size(102, 62);
            this.buttonSohranit_APD.TabIndex = 4;
            this.buttonSohranit_APD.Text = "Сохранить";
            this.buttonSohranit_APD.UseVisualStyleBackColor = false;
            this.buttonSohranit_APD.Click += new System.EventHandler(this.buttonSohranit_APD_Click);
            // 
            // buttonVupolnit_APD
            // 
            this.buttonVupolnit_APD.BackColor = System.Drawing.Color.Lime;
            this.buttonVupolnit_APD.Location = new System.Drawing.Point(418, 21);
            this.buttonVupolnit_APD.Name = "buttonVupolnit_APD";
            this.buttonVupolnit_APD.Size = new System.Drawing.Size(102, 62);
            this.buttonVupolnit_APD.TabIndex = 5;
            this.buttonVupolnit_APD.Text = "Выполнить";
            this.buttonVupolnit_APD.UseVisualStyleBackColor = false;
            this.buttonVupolnit_APD.Click += new System.EventHandler(this.buttonVupolnit_APD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxVuvod_APD);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // chartOne_APD
            // 
            chartArea5.Name = "ChartArea1";
            this.chartOne_APD.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOne_APD.Legends.Add(legend5);
            this.chartOne_APD.Location = new System.Drawing.Point(442, 108);
            this.chartOne_APD.Name = "chartOne_APD";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartOne_APD.Series.Add(series5);
            this.chartOne_APD.Size = new System.Drawing.Size(887, 405);
            this.chartOne_APD.TabIndex = 0;
            this.chartOne_APD.Text = "chart1";
            // 
            // textBoxVuvod_APD
            // 
            this.textBoxVuvod_APD.Location = new System.Drawing.Point(6, 25);
            this.textBoxVuvod_APD.Multiline = true;
            this.textBoxVuvod_APD.Name = "textBoxVuvod_APD";
            this.textBoxVuvod_APD.Size = new System.Drawing.Size(390, 383);
            this.textBoxVuvod_APD.TabIndex = 0;
            // 
            // buttonSpravka_APD
            // 
            this.buttonSpravka_APD.BackColor = System.Drawing.Color.Blue;
            this.buttonSpravka_APD.Location = new System.Drawing.Point(664, 21);
            this.buttonSpravka_APD.Name = "buttonSpravka_APD";
            this.buttonSpravka_APD.Size = new System.Drawing.Size(102, 62);
            this.buttonSpravka_APD.TabIndex = 6;
            this.buttonSpravka_APD.Text = "Справка";
            this.buttonSpravka_APD.UseVisualStyleBackColor = false;
            this.buttonSpravka_APD.Click += new System.EventHandler(this.buttonSpravka_APD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 525);
            this.Controls.Add(this.chartOne_APD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVuvod_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 14 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUslovie_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.PerformLayout();
            this.groupBoxVuvod_APD.ResumeLayout(false);
            this.groupBoxVuvod_APD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_APD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.Label labelUslovie_APD;
        private System.Windows.Forms.GroupBox groupBoxVuvod_APD;
        private System.Windows.Forms.Button buttonVupolnit_APD;
        private System.Windows.Forms.Button buttonSohranit_APD;
        private System.Windows.Forms.Label labelStop_APD;
        private System.Windows.Forms.Label labelStart_APD;
        private System.Windows.Forms.TextBox textBoxStop_APD;
        private System.Windows.Forms.TextBox textBoxStart_APD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSpravka_APD;
        private System.Windows.Forms.TextBox textBoxVuvod_APD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOne_APD;
    }
}

