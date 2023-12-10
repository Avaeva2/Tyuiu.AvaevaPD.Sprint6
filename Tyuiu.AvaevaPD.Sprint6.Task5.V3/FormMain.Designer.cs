
namespace Tyuiu.AvaevaPD.Sprint6.Task5.V3
{
    partial class FormMain_APD
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_APD = new System.Windows.Forms.GroupBox();
            this.labelUslovie_APD = new System.Windows.Forms.Label();
            this.buttonVupolnit_APD = new System.Windows.Forms.Button();
            this.buttonFail_APD = new System.Windows.Forms.Button();
            this.buttonSpravka_APD = new System.Windows.Forms.Button();
            this.groupBoxVuvod_APD = new System.Windows.Forms.GroupBox();
            this.dataGridView_APD = new System.Windows.Forms.DataGridView();
            this.chartOne_APD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_APD.SuspendLayout();
            this.groupBoxVuvod_APD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_APD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Controls.Add(this.labelUslovie_APD);
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(2, 3);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(517, 93);
            this.groupBoxUslovie_APD.TabIndex = 0;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие:";
            // 
            // labelUslovie_APD
            // 
            this.labelUslovie_APD.AutoSize = true;
            this.labelUslovie_APD.Location = new System.Drawing.Point(6, 29);
            this.labelUslovie_APD.Name = "labelUslovie_APD";
            this.labelUslovie_APD.Size = new System.Drawing.Size(502, 51);
            this.labelUslovie_APD.TabIndex = 1;
            this.labelUslovie_APD.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. \r\nВывести" +
    " все вещественные числа. \r\n Построить диаграмму по этим значениям. ";
            this.labelUslovie_APD.Click += new System.EventHandler(this.labelUslovie_APD_Click);
            // 
            // buttonVupolnit_APD
            // 
            this.buttonVupolnit_APD.BackColor = System.Drawing.Color.Lime;
            this.buttonVupolnit_APD.Location = new System.Drawing.Point(536, 12);
            this.buttonVupolnit_APD.Name = "buttonVupolnit_APD";
            this.buttonVupolnit_APD.Size = new System.Drawing.Size(92, 83);
            this.buttonVupolnit_APD.TabIndex = 1;
            this.buttonVupolnit_APD.Text = "Выполнить";
            this.buttonVupolnit_APD.UseVisualStyleBackColor = false;
            this.buttonVupolnit_APD.Click += new System.EventHandler(this.buttonVupolnit_APD_Click);
            // 
            // buttonFail_APD
            // 
            this.buttonFail_APD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFail_APD.Location = new System.Drawing.Point(681, 13);
            this.buttonFail_APD.Name = "buttonFail_APD";
            this.buttonFail_APD.Size = new System.Drawing.Size(92, 83);
            this.buttonFail_APD.TabIndex = 2;
            this.buttonFail_APD.Text = "Открыть файл";
            this.buttonFail_APD.UseVisualStyleBackColor = false;
            this.buttonFail_APD.Click += new System.EventHandler(this.buttonFail_APD_Click);
            // 
            // buttonSpravka_APD
            // 
            this.buttonSpravka_APD.BackColor = System.Drawing.Color.Blue;
            this.buttonSpravka_APD.Location = new System.Drawing.Point(822, 13);
            this.buttonSpravka_APD.Name = "buttonSpravka_APD";
            this.buttonSpravka_APD.Size = new System.Drawing.Size(92, 83);
            this.buttonSpravka_APD.TabIndex = 3;
            this.buttonSpravka_APD.Text = "Справка";
            this.buttonSpravka_APD.UseVisualStyleBackColor = false;
            this.buttonSpravka_APD.Click += new System.EventHandler(this.buttonSpravka_APD_Click);
            // 
            // groupBoxVuvod_APD
            // 
            this.groupBoxVuvod_APD.Controls.Add(this.dataGridView_APD);
            this.groupBoxVuvod_APD.Location = new System.Drawing.Point(2, 102);
            this.groupBoxVuvod_APD.Name = "groupBoxVuvod_APD";
            this.groupBoxVuvod_APD.Size = new System.Drawing.Size(198, 409);
            this.groupBoxVuvod_APD.TabIndex = 4;
            this.groupBoxVuvod_APD.TabStop = false;
            this.groupBoxVuvod_APD.Text = "Вывод данных:";
            // 
            // dataGridView_APD
            // 
            this.dataGridView_APD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_APD.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_APD.Name = "dataGridView_APD";
            this.dataGridView_APD.RowHeadersWidth = 51;
            this.dataGridView_APD.RowTemplate.Height = 24;
            this.dataGridView_APD.Size = new System.Drawing.Size(186, 382);
            this.dataGridView_APD.TabIndex = 5;
            // 
            // chartOne_APD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOne_APD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOne_APD.Legends.Add(legend1);
            this.chartOne_APD.Location = new System.Drawing.Point(206, 102);
            this.chartOne_APD.Name = "chartOne_APD";
            this.chartOne_APD.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOne_APD.Series.Add(series1);
            this.chartOne_APD.Size = new System.Drawing.Size(708, 397);
            this.chartOne_APD.TabIndex = 5;
            // 
            // FormMain_APD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 511);
            this.Controls.Add(this.chartOne_APD);
            this.Controls.Add(this.groupBoxVuvod_APD);
            this.Controls.Add(this.buttonSpravka_APD);
            this.Controls.Add(this.buttonFail_APD);
            this.Controls.Add(this.buttonVupolnit_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.Name = "FormMain_APD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 0 | Аваева П. Д.";
            this.groupBoxUslovie_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.PerformLayout();
            this.groupBoxVuvod_APD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne_APD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.Label labelUslovie_APD;
        private System.Windows.Forms.Button buttonVupolnit_APD;
        private System.Windows.Forms.Button buttonFail_APD;
        private System.Windows.Forms.Button buttonSpravka_APD;
        private System.Windows.Forms.GroupBox groupBoxVuvod_APD;
        private System.Windows.Forms.DataGridView dataGridView_APD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOne_APD;
    }
}

