
namespace Tyuiu.AvaevaPD.Sprint6.Task6.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox_APD = new System.Windows.Forms.PictureBox();
            this.labelText_APD = new System.Windows.Forms.Label();
            this.buttonOK_APD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_APD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_APD
            // 
            this.pictureBox_APD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_APD.Image")));
            this.pictureBox_APD.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_APD.Name = "pictureBox_APD";
            this.pictureBox_APD.Size = new System.Drawing.Size(132, 179);
            this.pictureBox_APD.TabIndex = 0;
            this.pictureBox_APD.TabStop = false;
            // 
            // labelText_APD
            // 
            this.labelText_APD.AutoSize = true;
            this.labelText_APD.Location = new System.Drawing.Point(159, 12);
            this.labelText_APD.Name = "labelText_APD";
            this.labelText_APD.Size = new System.Drawing.Size(363, 136);
            this.labelText_APD.TabIndex = 1;
            this.labelText_APD.Text = resources.GetString("labelText_APD.Text");
            this.labelText_APD.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOK_APD
            // 
            this.buttonOK_APD.Location = new System.Drawing.Point(426, 163);
            this.buttonOK_APD.Name = "buttonOK_APD";
            this.buttonOK_APD.Size = new System.Drawing.Size(79, 28);
            this.buttonOK_APD.TabIndex = 2;
            this.buttonOK_APD.Text = "Ok";
            this.buttonOK_APD.UseVisualStyleBackColor = true;
            this.buttonOK_APD.Click += new System.EventHandler(this.buttonOK_APD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 203);
            this.Controls.Add(this.buttonOK_APD);
            this.Controls.Add(this.labelText_APD);
            this.Controls.Add(this.pictureBox_APD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_APD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_APD;
        private System.Windows.Forms.Label labelText_APD;
        private System.Windows.Forms.Button buttonOK_APD;
    }
}