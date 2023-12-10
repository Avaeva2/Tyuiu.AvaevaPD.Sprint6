using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task5.V3.Lib;
using System.IO;

namespace Tyuiu.AvaevaPD.Sprint6.Task5.V3
{
    public partial class FormMain_APD : Form
    {
        


        public FormMain_APD()
        {
            InitializeComponent();
        }

        private void labelUslovie_APD_Click(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint6\Tyuiu.AvaevaPD.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";

        private void buttonVupolnit_APD_Click(object sender, EventArgs e)
        {
            dataGridView_APD.ColumnCount = 2;
            dataGridView_APD.Columns[0].Width = 20;
            dataGridView_APD.Columns[1].Width = 50;

            this.chartOne_APD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartOne_APD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartOne_APD.Series[0].Points.Clear();
            dataGridView_APD.Rows.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_APD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartOne_APD.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonFail_APD_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_APD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
