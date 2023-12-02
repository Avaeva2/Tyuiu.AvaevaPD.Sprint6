
namespace Tyuiu.AvaevaPD.Sprint6.Task3.V11
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
            this.groupBoxUslovie_APD = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_APD = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.buttonDone_APD = new System.Windows.Forms.Button();
            this.buttonSpravka_APD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_APD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Controls.Add(this.textBoxUslovie_APD);
            this.groupBoxUslovie_APD.Controls.Add(this.dataGridViewFunction);
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(575, 426);
            this.groupBoxUslovie_APD.TabIndex = 0;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие";
            // 
            // textBoxUslovie_APD
            // 
            this.textBoxUslovie_APD.Location = new System.Drawing.Point(6, 28);
            this.textBoxUslovie_APD.Multiline = true;
            this.textBoxUslovie_APD.Name = "textBoxUslovie_APD";
            this.textBoxUslovie_APD.ReadOnly = true;
            this.textBoxUslovie_APD.Size = new System.Drawing.Size(247, 352);
            this.textBoxUslovie_APD.TabIndex = 2;
            this.textBoxUslovie_APD.Text = "Дана матрица 5 на 5\r\n27 -15 14 2 27\r\n-8 14 -10 33 0\r\n1 7 -11 -11 23\r\n-13 -20 15 -" +
    "16 34\r\n-3 1 -1 5 1 \r\nВыполнить сортировку по возрастанию в первом столбце\r\n";
            this.textBoxUslovie_APD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Location = new System.Drawing.Point(273, 28);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersWidth = 51;
            this.dataGridViewFunction.RowTemplate.Height = 24;
            this.dataGridViewFunction.Size = new System.Drawing.Size(296, 264);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // buttonDone_APD
            // 
            this.buttonDone_APD.Location = new System.Drawing.Point(677, 353);
            this.buttonDone_APD.Name = "buttonDone_APD";
            this.buttonDone_APD.Size = new System.Drawing.Size(111, 39);
            this.buttonDone_APD.TabIndex = 2;
            this.buttonDone_APD.Text = "Выполнить";
            this.buttonDone_APD.UseVisualStyleBackColor = true;
            this.buttonDone_APD.Click += new System.EventHandler(this.buttonDone_APD_Click);
            // 
            // buttonSpravka_APD
            // 
            this.buttonSpravka_APD.Location = new System.Drawing.Point(593, 353);
            this.buttonSpravka_APD.Name = "buttonSpravka_APD";
            this.buttonSpravka_APD.Size = new System.Drawing.Size(56, 39);
            this.buttonSpravka_APD.TabIndex = 3;
            this.buttonSpravka_APD.Text = "?";
            this.buttonSpravka_APD.UseVisualStyleBackColor = true;
            this.buttonSpravka_APD.Click += new System.EventHandler(this.buttonSpravka_APD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSpravka_APD);
            this.Controls.Add(this.buttonDone_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUslovie_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.Button buttonDone_APD;
        private System.Windows.Forms.Button buttonSpravka_APD;
        private System.Windows.Forms.TextBox textBoxUslovie_APD;
    }
}

