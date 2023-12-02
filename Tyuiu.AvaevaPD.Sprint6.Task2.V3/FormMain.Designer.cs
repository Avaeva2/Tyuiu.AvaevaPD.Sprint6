
namespace Tyuiu.AvaevaPD.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_APD = new System.Windows.Forms.GroupBox();
            this.labelUslovie_APD = new System.Windows.Forms.Label();
            this.groupBoxVvod_APD = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_APD = new System.Windows.Forms.TextBox();
            this.textBoxStart_APD = new System.Windows.Forms.TextBox();
            this.labelStop_APD = new System.Windows.Forms.Label();
            this.labelStart_APD = new System.Windows.Forms.Label();
            this.groupBoxVuvod_APD = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_APD = new System.Windows.Forms.Label();
            this.buttonDone_APD = new System.Windows.Forms.Button();
            this.buttonSpravka_APD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_APD.SuspendLayout();
            this.groupBoxVvod_APD.SuspendLayout();
            this.groupBoxVuvod_APD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Controls.Add(this.labelUslovie_APD);
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(570, 289);
            this.groupBoxUslovie_APD.TabIndex = 0;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие";
            // 
            // labelUslovie_APD
            // 
            this.labelUslovie_APD.AutoSize = true;
            this.labelUslovie_APD.Location = new System.Drawing.Point(6, 21);
            this.labelUslovie_APD.Name = "labelUslovie_APD";
            this.labelUslovie_APD.Size = new System.Drawing.Size(435, 34);
            this.labelUslovie_APD.TabIndex = 1;
            this.labelUslovie_APD.Text = "       Произвести табулирование на заданном диапазоне.\r\nРезультат вывести в DataG" +
    "ridView и построить график функции.\r\n";
            // 
            // groupBoxVvod_APD
            // 
            this.groupBoxVvod_APD.Controls.Add(this.textBoxEnd_APD);
            this.groupBoxVvod_APD.Controls.Add(this.textBoxStart_APD);
            this.groupBoxVvod_APD.Controls.Add(this.labelStop_APD);
            this.groupBoxVvod_APD.Controls.Add(this.labelStart_APD);
            this.groupBoxVvod_APD.Location = new System.Drawing.Point(12, 307);
            this.groupBoxVvod_APD.Name = "groupBoxVvod_APD";
            this.groupBoxVvod_APD.Size = new System.Drawing.Size(345, 131);
            this.groupBoxVvod_APD.TabIndex = 1;
            this.groupBoxVvod_APD.TabStop = false;
            this.groupBoxVvod_APD.Text = "Ввод данных";
            // 
            // textBoxEnd_APD
            // 
            this.textBoxEnd_APD.Location = new System.Drawing.Point(211, 96);
            this.textBoxEnd_APD.Name = "textBoxEnd_APD";
            this.textBoxEnd_APD.Size = new System.Drawing.Size(105, 22);
            this.textBoxEnd_APD.TabIndex = 2;
            // 
            // textBoxStart_APD
            // 
            this.textBoxStart_APD.Location = new System.Drawing.Point(9, 96);
            this.textBoxStart_APD.Name = "textBoxStart_APD";
            this.textBoxStart_APD.Size = new System.Drawing.Size(105, 22);
            this.textBoxStart_APD.TabIndex = 3;
            // 
            // labelStop_APD
            // 
            this.labelStop_APD.AutoSize = true;
            this.labelStop_APD.Location = new System.Drawing.Point(208, 57);
            this.labelStop_APD.Name = "labelStop_APD";
            this.labelStop_APD.Size = new System.Drawing.Size(89, 17);
            this.labelStop_APD.TabIndex = 2;
            this.labelStop_APD.Text = "Конец шага:";
            this.labelStop_APD.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelStart_APD
            // 
            this.labelStart_APD.AutoSize = true;
            this.labelStart_APD.Location = new System.Drawing.Point(6, 57);
            this.labelStart_APD.Name = "labelStart_APD";
            this.labelStart_APD.Size = new System.Drawing.Size(87, 17);
            this.labelStart_APD.TabIndex = 1;
            this.labelStart_APD.Text = "Старт шага:";
            // 
            // groupBoxVuvod_APD
            // 
            this.groupBoxVuvod_APD.Controls.Add(this.chartFunction);
            this.groupBoxVuvod_APD.Controls.Add(this.dataGridViewFunction);
            this.groupBoxVuvod_APD.Controls.Add(this.labelResult_APD);
            this.groupBoxVuvod_APD.Location = new System.Drawing.Point(595, 12);
            this.groupBoxVuvod_APD.Name = "groupBoxVuvod_APD";
            this.groupBoxVuvod_APD.Size = new System.Drawing.Size(673, 425);
            this.groupBoxVuvod_APD.TabIndex = 2;
            this.groupBoxVuvod_APD.TabStop = false;
            this.groupBoxVuvod_APD.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(314, 59);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(340, 354);
            this.chartFunction.TabIndex = 5;
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.RowHeadersWidth = 70;
            this.dataGridViewFunction.RowTemplate.Height = 24;
            this.dataGridViewFunction.Size = new System.Drawing.Size(278, 354);
            this.dataGridViewFunction.TabIndex = 1;
            this.dataGridViewFunction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // labelResult_APD
            // 
            this.labelResult_APD.AutoSize = true;
            this.labelResult_APD.Location = new System.Drawing.Point(21, 29);
            this.labelResult_APD.Name = "labelResult_APD";
            this.labelResult_APD.Size = new System.Drawing.Size(80, 17);
            this.labelResult_APD.TabIndex = 0;
            this.labelResult_APD.Text = "Результат:";
            // 
            // buttonDone_APD
            // 
            this.buttonDone_APD.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_APD.Location = new System.Drawing.Point(464, 364);
            this.buttonDone_APD.Name = "buttonDone_APD";
            this.buttonDone_APD.Size = new System.Drawing.Size(125, 62);
            this.buttonDone_APD.TabIndex = 3;
            this.buttonDone_APD.Text = "Выполнить";
            this.buttonDone_APD.UseVisualStyleBackColor = false;
            this.buttonDone_APD.Click += new System.EventHandler(this.buttonDone_APD_Click);
            this.buttonDone_APD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_APD_MouseDown);
            this.buttonDone_APD.MouseEnter += new System.EventHandler(this.buttonDone_APD_MouseEnter);
            this.buttonDone_APD.MouseLeave += new System.EventHandler(this.buttonDone_APD_MouseLeave);
            // 
            // buttonSpravka_APD
            // 
            this.buttonSpravka_APD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSpravka_APD.Location = new System.Drawing.Point(369, 364);
            this.buttonSpravka_APD.Name = "buttonSpravka_APD";
            this.buttonSpravka_APD.Size = new System.Drawing.Size(84, 61);
            this.buttonSpravka_APD.TabIndex = 4;
            this.buttonSpravka_APD.Text = "Справка";
            this.buttonSpravka_APD.UseVisualStyleBackColor = false;
            this.buttonSpravka_APD.Click += new System.EventHandler(this.buttonSpravka_APD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 450);
            this.Controls.Add(this.buttonSpravka_APD);
            this.Controls.Add(this.buttonDone_APD);
            this.Controls.Add(this.groupBoxVuvod_APD);
            this.Controls.Add(this.groupBoxVvod_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUslovie_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.PerformLayout();
            this.groupBoxVvod_APD.ResumeLayout(false);
            this.groupBoxVvod_APD.PerformLayout();
            this.groupBoxVuvod_APD.ResumeLayout(false);
            this.groupBoxVuvod_APD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.Label labelUslovie_APD;
        private System.Windows.Forms.GroupBox groupBoxVvod_APD;
        private System.Windows.Forms.Label labelStop_APD;
        private System.Windows.Forms.Label labelStart_APD;
        private System.Windows.Forms.GroupBox groupBoxVuvod_APD;
        private System.Windows.Forms.Label labelResult_APD;
        private System.Windows.Forms.TextBox textBoxEnd_APD;
        private System.Windows.Forms.TextBox textBoxStart_APD;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.Button buttonDone_APD;
        private System.Windows.Forms.Button buttonSpravka_APD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

