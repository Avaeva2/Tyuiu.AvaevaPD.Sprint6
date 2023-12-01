
namespace Tyuiu.AvaevaPD.Sprint6.Task1.V2
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
            this.groupBoxAnswer_APD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_APD = new System.Windows.Forms.RichTextBox();
            this.labelResult_APD = new System.Windows.Forms.Label();
            this.groupBoxDannye_APD = new System.Windows.Forms.GroupBox();
            this.labelStop_APD = new System.Windows.Forms.Label();
            this.labelStart_APD = new System.Windows.Forms.Label();
            this.textBoxEnd_APD = new System.Windows.Forms.TextBox();
            this.textBoxStart_APD = new System.Windows.Forms.TextBox();
            this.buttonDone_APD = new System.Windows.Forms.Button();
            this.buttonSpravka_APD = new System.Windows.Forms.Button();
            this.groupBoxAnswer_APD.SuspendLayout();
            this.groupBoxDannye_APD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(6, 12);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(616, 269);
            this.groupBoxUslovie_APD.TabIndex = 0;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие. Протабулировать функцию F(x) на заданном диапозоне. Результат вывести в " +
    "виде таблицы.";
            // 
            // groupBoxAnswer_APD
            // 
            this.groupBoxAnswer_APD.Controls.Add(this.textBoxResult_APD);
            this.groupBoxAnswer_APD.Controls.Add(this.labelResult_APD);
            this.groupBoxAnswer_APD.Location = new System.Drawing.Point(628, 0);
            this.groupBoxAnswer_APD.Name = "groupBoxAnswer_APD";
            this.groupBoxAnswer_APD.Size = new System.Drawing.Size(300, 409);
            this.groupBoxAnswer_APD.TabIndex = 0;
            this.groupBoxAnswer_APD.TabStop = false;
            this.groupBoxAnswer_APD.Text = "Вывод данных";
            // 
            // textBoxResult_APD
            // 
            this.textBoxResult_APD.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_APD.Location = new System.Drawing.Point(6, 46);
            this.textBoxResult_APD.Name = "textBoxResult_APD";
            this.textBoxResult_APD.ReadOnly = true;
            this.textBoxResult_APD.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxResult_APD.Size = new System.Drawing.Size(279, 343);
            this.textBoxResult_APD.TabIndex = 2;
            this.textBoxResult_APD.Text = "";
            this.textBoxResult_APD.TextChanged += new System.EventHandler(this.textBoxResult_APD_TextChanged);
            // 
            // labelResult_APD
            // 
            this.labelResult_APD.AutoSize = true;
            this.labelResult_APD.Location = new System.Drawing.Point(19, 26);
            this.labelResult_APD.Name = "labelResult_APD";
            this.labelResult_APD.Size = new System.Drawing.Size(80, 17);
            this.labelResult_APD.TabIndex = 0;
            this.labelResult_APD.Text = "Результат:";
            this.labelResult_APD.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxDannye_APD
            // 
            this.groupBoxDannye_APD.Controls.Add(this.labelStop_APD);
            this.groupBoxDannye_APD.Controls.Add(this.labelStart_APD);
            this.groupBoxDannye_APD.Controls.Add(this.textBoxEnd_APD);
            this.groupBoxDannye_APD.Controls.Add(this.textBoxStart_APD);
            this.groupBoxDannye_APD.Location = new System.Drawing.Point(6, 287);
            this.groupBoxDannye_APD.Name = "groupBoxDannye_APD";
            this.groupBoxDannye_APD.Size = new System.Drawing.Size(311, 122);
            this.groupBoxDannye_APD.TabIndex = 1;
            this.groupBoxDannye_APD.TabStop = false;
            this.groupBoxDannye_APD.Text = "Ввод данных";
            // 
            // labelStop_APD
            // 
            this.labelStop_APD.AutoSize = true;
            this.labelStop_APD.Location = new System.Drawing.Point(178, 67);
            this.labelStop_APD.Name = "labelStop_APD";
            this.labelStop_APD.Size = new System.Drawing.Size(89, 17);
            this.labelStop_APD.TabIndex = 0;
            this.labelStop_APD.Text = "Конец шага:";
            // 
            // labelStart_APD
            // 
            this.labelStart_APD.AutoSize = true;
            this.labelStart_APD.Location = new System.Drawing.Point(23, 67);
            this.labelStart_APD.Name = "labelStart_APD";
            this.labelStart_APD.Size = new System.Drawing.Size(87, 17);
            this.labelStart_APD.TabIndex = 0;
            this.labelStart_APD.Text = "Старт шага:";
            // 
            // textBoxEnd_APD
            // 
            this.textBoxEnd_APD.Location = new System.Drawing.Point(158, 94);
            this.textBoxEnd_APD.Name = "textBoxEnd_APD";
            this.textBoxEnd_APD.Size = new System.Drawing.Size(132, 22);
            this.textBoxEnd_APD.TabIndex = 1;
            // 
            // textBoxStart_APD
            // 
            this.textBoxStart_APD.Location = new System.Drawing.Point(6, 94);
            this.textBoxStart_APD.Name = "textBoxStart_APD";
            this.textBoxStart_APD.Size = new System.Drawing.Size(132, 22);
            this.textBoxStart_APD.TabIndex = 0;
            // 
            // buttonDone_APD
            // 
            this.buttonDone_APD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_APD.Location = new System.Drawing.Point(473, 299);
            this.buttonDone_APD.Name = "buttonDone_APD";
            this.buttonDone_APD.Size = new System.Drawing.Size(149, 73);
            this.buttonDone_APD.TabIndex = 2;
            this.buttonDone_APD.Text = "Выполнить";
            this.buttonDone_APD.UseVisualStyleBackColor = false;
            this.buttonDone_APD.Click += new System.EventHandler(this.buttonDone_APD_Click);
            // 
            // buttonSpravka_APD
            // 
            this.buttonSpravka_APD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSpravka_APD.Location = new System.Drawing.Point(335, 299);
            this.buttonSpravka_APD.Name = "buttonSpravka_APD";
            this.buttonSpravka_APD.Size = new System.Drawing.Size(110, 72);
            this.buttonSpravka_APD.TabIndex = 3;
            this.buttonSpravka_APD.Text = "Справка";
            this.buttonSpravka_APD.UseVisualStyleBackColor = false;
            this.buttonSpravka_APD.Click += new System.EventHandler(this.buttonSpravka_APD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 421);
            this.Controls.Add(this.buttonSpravka_APD);
            this.Controls.Add(this.buttonDone_APD);
            this.Controls.Add(this.groupBoxDannye_APD);
            this.Controls.Add(this.groupBoxAnswer_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxAnswer_APD.ResumeLayout(false);
            this.groupBoxAnswer_APD.PerformLayout();
            this.groupBoxDannye_APD.ResumeLayout(false);
            this.groupBoxDannye_APD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.GroupBox groupBoxAnswer_APD;
        private System.Windows.Forms.Label labelResult_APD;
        private System.Windows.Forms.GroupBox groupBoxDannye_APD;
        private System.Windows.Forms.Label labelStop_APD;
        private System.Windows.Forms.Label labelStart_APD;
        private System.Windows.Forms.TextBox textBoxEnd_APD;
        private System.Windows.Forms.TextBox textBoxStart_APD;
        private System.Windows.Forms.Button buttonDone_APD;
        private System.Windows.Forms.Button buttonSpravka_APD;
        private System.Windows.Forms.RichTextBox textBoxResult_APD;
    }
}

