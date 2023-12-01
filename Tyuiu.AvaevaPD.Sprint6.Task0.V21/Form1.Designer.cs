
namespace Tyuiu.AvaevaPD.Sprint6.Task0.V21
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDONE_APD = new System.Windows.Forms.Button();
            this.groupBoxOne_APD = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_APD = new System.Windows.Forms.GroupBox();
            this.groupBoxThree_APD = new System.Windows.Forms.GroupBox();
            this.pictureBoxOne_APD = new System.Windows.Forms.PictureBox();
            this.textBoxAnswer_APD = new System.Windows.Forms.TextBox();
            this.textBoxResult_APD = new System.Windows.Forms.TextBox();
            this.buttonHELP_APD = new System.Windows.Forms.Button();
            this.groupBoxOne_APD.SuspendLayout();
            this.groupBoxTwo_APD.SuspendLayout();
            this.groupBoxThree_APD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_APD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDONE_APD
            // 
            this.buttonDONE_APD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDONE_APD.Location = new System.Drawing.Point(606, 379);
            this.buttonDONE_APD.Name = "buttonDONE_APD";
            this.buttonDONE_APD.Size = new System.Drawing.Size(171, 44);
            this.buttonDONE_APD.TabIndex = 0;
            this.buttonDONE_APD.Text = "Выполнить";
            this.buttonDONE_APD.UseVisualStyleBackColor = true;
            this.buttonDONE_APD.Click += new System.EventHandler(this.buttonDONE_APD_Click);
            // 
            // groupBoxOne_APD
            // 
            this.groupBoxOne_APD.Controls.Add(this.pictureBoxOne_APD);
            this.groupBoxOne_APD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOne_APD.Name = "groupBoxOne_APD";
            this.groupBoxOne_APD.Size = new System.Drawing.Size(776, 207);
            this.groupBoxOne_APD.TabIndex = 1;
            this.groupBoxOne_APD.TabStop = false;
            this.groupBoxOne_APD.Text = "Вычислить значение выражения при х = 2.";
            // 
            // groupBoxTwo_APD
            // 
            this.groupBoxTwo_APD.Controls.Add(this.textBoxAnswer_APD);
            this.groupBoxTwo_APD.Location = new System.Drawing.Point(12, 225);
            this.groupBoxTwo_APD.Name = "groupBoxTwo_APD";
            this.groupBoxTwo_APD.Size = new System.Drawing.Size(246, 160);
            this.groupBoxTwo_APD.TabIndex = 0;
            this.groupBoxTwo_APD.TabStop = false;
            this.groupBoxTwo_APD.Text = "Ввод данных";
            // 
            // groupBoxThree_APD
            // 
            this.groupBoxThree_APD.Controls.Add(this.textBoxResult_APD);
            this.groupBoxThree_APD.Location = new System.Drawing.Point(277, 225);
            this.groupBoxThree_APD.Name = "groupBoxThree_APD";
            this.groupBoxThree_APD.Size = new System.Drawing.Size(236, 160);
            this.groupBoxThree_APD.TabIndex = 0;
            this.groupBoxThree_APD.TabStop = false;
            this.groupBoxThree_APD.Text = "Вывод данных";
            // 
            // pictureBoxOne_APD
            // 
            this.pictureBoxOne_APD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOne_APD.Image")));
            this.pictureBoxOne_APD.Location = new System.Drawing.Point(41, 73);
            this.pictureBoxOne_APD.Name = "pictureBoxOne_APD";
            this.pictureBoxOne_APD.Size = new System.Drawing.Size(714, 60);
            this.pictureBoxOne_APD.TabIndex = 2;
            this.pictureBoxOne_APD.TabStop = false;
            // 
            // textBoxAnswer_APD
            // 
            this.textBoxAnswer_APD.Location = new System.Drawing.Point(41, 92);
            this.textBoxAnswer_APD.Name = "textBoxAnswer_APD";
            this.textBoxAnswer_APD.Size = new System.Drawing.Size(154, 22);
            this.textBoxAnswer_APD.TabIndex = 3;
            this.textBoxAnswer_APD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswer_APD_KeyPress);
            // 
            // textBoxResult_APD
            // 
            this.textBoxResult_APD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxResult_APD.Location = new System.Drawing.Point(50, 92);
            this.textBoxResult_APD.Name = "textBoxResult_APD";
            this.textBoxResult_APD.Size = new System.Drawing.Size(134, 22);
            this.textBoxResult_APD.TabIndex = 4;
            // 
            // buttonHELP_APD
            // 
            this.buttonHELP_APD.Location = new System.Drawing.Point(535, 379);
            this.buttonHELP_APD.Name = "buttonHELP_APD";
            this.buttonHELP_APD.Size = new System.Drawing.Size(65, 44);
            this.buttonHELP_APD.TabIndex = 5;
            this.buttonHELP_APD.Text = "?";
            this.buttonHELP_APD.UseVisualStyleBackColor = true;
            this.buttonHELP_APD.Click += new System.EventHandler(this.buttonHELP_APD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHELP_APD);
            this.Controls.Add(this.groupBoxThree_APD);
            this.Controls.Add(this.groupBoxTwo_APD);
            this.Controls.Add(this.groupBoxOne_APD);
            this.Controls.Add(this.buttonDONE_APD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 21 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOne_APD.ResumeLayout(false);
            this.groupBoxTwo_APD.ResumeLayout(false);
            this.groupBoxTwo_APD.PerformLayout();
            this.groupBoxThree_APD.ResumeLayout(false);
            this.groupBoxThree_APD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_APD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDONE_APD;
        private System.Windows.Forms.GroupBox groupBoxOne_APD;
        private System.Windows.Forms.PictureBox pictureBoxOne_APD;
        private System.Windows.Forms.GroupBox groupBoxTwo_APD;
        private System.Windows.Forms.TextBox textBoxAnswer_APD;
        private System.Windows.Forms.GroupBox groupBoxThree_APD;
        private System.Windows.Forms.TextBox textBoxResult_APD;
        private System.Windows.Forms.Button buttonHELP_APD;
    }
}

