
namespace Tyuiu.AvaevaPD.Sprint6.Task6.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxIcon_APD = new System.Windows.Forms.GroupBox();
            this.groupBoxUslovie_APD = new System.Windows.Forms.GroupBox();
            this.groupBoxVvod_APD = new System.Windows.Forms.GroupBox();
            this.groupBoxVuvod_APD = new System.Windows.Forms.GroupBox();
            this.labelUslovie_APD = new System.Windows.Forms.Label();
            this.buttonHelp_APD = new System.Windows.Forms.Button();
            this.buttonFail_APD = new System.Windows.Forms.Button();
            this.buttonOUT_APD = new System.Windows.Forms.Button();
            this.textBoxIN_APD = new System.Windows.Forms.TextBox();
            this.textBoxOut_APD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_APD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_APD = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxIcon_APD.SuspendLayout();
            this.groupBoxUslovie_APD.SuspendLayout();
            this.groupBoxVvod_APD.SuspendLayout();
            this.groupBoxVuvod_APD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIcon_APD
            // 
            this.groupBoxIcon_APD.Controls.Add(this.buttonOUT_APD);
            this.groupBoxIcon_APD.Controls.Add(this.buttonFail_APD);
            this.groupBoxIcon_APD.Controls.Add(this.buttonHelp_APD);
            this.groupBoxIcon_APD.Location = new System.Drawing.Point(2, 3);
            this.groupBoxIcon_APD.Name = "groupBoxIcon_APD";
            this.groupBoxIcon_APD.Size = new System.Drawing.Size(978, 84);
            this.groupBoxIcon_APD.TabIndex = 0;
            this.groupBoxIcon_APD.TabStop = false;
            // 
            // groupBoxUslovie_APD
            // 
            this.groupBoxUslovie_APD.Controls.Add(this.labelUslovie_APD);
            this.groupBoxUslovie_APD.Location = new System.Drawing.Point(2, 93);
            this.groupBoxUslovie_APD.Name = "groupBoxUslovie_APD";
            this.groupBoxUslovie_APD.Size = new System.Drawing.Size(978, 87);
            this.groupBoxUslovie_APD.TabIndex = 1;
            this.groupBoxUslovie_APD.TabStop = false;
            this.groupBoxUslovie_APD.Text = "Условие:";
            // 
            // groupBoxVvod_APD
            // 
            this.groupBoxVvod_APD.Controls.Add(this.textBoxIN_APD);
            this.groupBoxVvod_APD.Location = new System.Drawing.Point(2, 182);
            this.groupBoxVvod_APD.Name = "groupBoxVvod_APD";
            this.groupBoxVvod_APD.Size = new System.Drawing.Size(487, 359);
            this.groupBoxVvod_APD.TabIndex = 2;
            this.groupBoxVvod_APD.TabStop = false;
            this.groupBoxVvod_APD.Text = "Ввод:";
            // 
            // groupBoxVuvod_APD
            // 
            this.groupBoxVuvod_APD.Controls.Add(this.textBoxOut_APD);
            this.groupBoxVuvod_APD.Location = new System.Drawing.Point(495, 182);
            this.groupBoxVuvod_APD.Name = "groupBoxVuvod_APD";
            this.groupBoxVuvod_APD.Size = new System.Drawing.Size(487, 359);
            this.groupBoxVuvod_APD.TabIndex = 3;
            this.groupBoxVuvod_APD.TabStop = false;
            this.groupBoxVuvod_APD.Text = "Вывод:";
            // 
            // labelUslovie_APD
            // 
            this.labelUslovie_APD.AutoSize = true;
            this.labelUslovie_APD.Location = new System.Drawing.Point(10, 27);
            this.labelUslovie_APD.Name = "labelUslovie_APD";
            this.labelUslovie_APD.Size = new System.Drawing.Size(953, 34);
            this.labelUslovie_APD.TabIndex = 0;
            this.labelUslovie_APD.Text = resources.GetString("labelUslovie_APD.Text");
            // 
            // buttonHelp_APD
            // 
            this.buttonHelp_APD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_APD.Image")));
            this.buttonHelp_APD.Location = new System.Drawing.Point(843, 20);
            this.buttonHelp_APD.Name = "buttonHelp_APD";
            this.buttonHelp_APD.Size = new System.Drawing.Size(120, 58);
            this.buttonHelp_APD.TabIndex = 0;
            this.toolTip_APD.SetToolTip(this.buttonHelp_APD, "Сведение о программе");
            this.buttonHelp_APD.UseVisualStyleBackColor = true;
            this.buttonHelp_APD.Click += new System.EventHandler(this.buttonHelp_APD_Click);
            // 
            // buttonFail_APD
            // 
            this.buttonFail_APD.Image = ((System.Drawing.Image)(resources.GetObject("buttonFail_APD.Image")));
            this.buttonFail_APD.ImageKey = "(none)";
            this.buttonFail_APD.Location = new System.Drawing.Point(10, 20);
            this.buttonFail_APD.Name = "buttonFail_APD";
            this.buttonFail_APD.Size = new System.Drawing.Size(84, 58);
            this.buttonFail_APD.TabIndex = 1;
            this.toolTip_APD.SetToolTip(this.buttonFail_APD, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonFail_APD.UseVisualStyleBackColor = true;
            this.buttonFail_APD.Click += new System.EventHandler(this.buttonFail_APD_Click);
            // 
            // buttonOUT_APD
            // 
            this.buttonOUT_APD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOUT_APD.Image")));
            this.buttonOUT_APD.Location = new System.Drawing.Point(100, 20);
            this.buttonOUT_APD.Name = "buttonOUT_APD";
            this.buttonOUT_APD.Size = new System.Drawing.Size(84, 58);
            this.buttonOUT_APD.TabIndex = 2;
            this.buttonOUT_APD.UseVisualStyleBackColor = true;
            this.buttonOUT_APD.Click += new System.EventHandler(this.buttonOUT_APD_Click);
            // 
            // textBoxIN_APD
            // 
            this.textBoxIN_APD.Location = new System.Drawing.Point(10, 21);
            this.textBoxIN_APD.Multiline = true;
            this.textBoxIN_APD.Name = "textBoxIN_APD";
            this.textBoxIN_APD.Size = new System.Drawing.Size(471, 332);
            this.textBoxIN_APD.TabIndex = 0;
            // 
            // textBoxOut_APD
            // 
            this.textBoxOut_APD.Location = new System.Drawing.Point(6, 21);
            this.textBoxOut_APD.Multiline = true;
            this.textBoxOut_APD.Name = "textBoxOut_APD";
            this.textBoxOut_APD.Size = new System.Drawing.Size(471, 332);
            this.textBoxOut_APD.TabIndex = 1;
            // 
            // openFileDialogTask_APD
            // 
            this.openFileDialogTask_APD.FileName = "openFileDialogTask_APD";
            // 
            // toolTip_APD
            // 
            this.toolTip_APD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 542);
            this.Controls.Add(this.groupBoxVuvod_APD);
            this.Controls.Add(this.groupBoxVvod_APD);
            this.Controls.Add(this.groupBoxUslovie_APD);
            this.Controls.Add(this.groupBoxIcon_APD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Аваева П. Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxIcon_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.ResumeLayout(false);
            this.groupBoxUslovie_APD.PerformLayout();
            this.groupBoxVvod_APD.ResumeLayout(false);
            this.groupBoxVvod_APD.PerformLayout();
            this.groupBoxVuvod_APD.ResumeLayout(false);
            this.groupBoxVuvod_APD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIcon_APD;
        private System.Windows.Forms.Button buttonOUT_APD;
        private System.Windows.Forms.Button buttonFail_APD;
        private System.Windows.Forms.Button buttonHelp_APD;
        private System.Windows.Forms.GroupBox groupBoxUslovie_APD;
        private System.Windows.Forms.Label labelUslovie_APD;
        private System.Windows.Forms.GroupBox groupBoxVvod_APD;
        private System.Windows.Forms.TextBox textBoxIN_APD;
        private System.Windows.Forms.GroupBox groupBoxVuvod_APD;
        private System.Windows.Forms.TextBox textBoxOut_APD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_APD;
        private System.Windows.Forms.ToolTip toolTip_APD;
    }
}

