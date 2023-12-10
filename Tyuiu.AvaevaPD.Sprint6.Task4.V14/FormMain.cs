using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task4.V14.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVupolnit_APD_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_APD.Text);
                int stopValue = Convert.ToInt32(textBoxStop_APD.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;

                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartOne_APD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOne_APD.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxVuvod_APD.Text = "";

                chartOne_APD.Series[0].Points.Clear();
                for (int i =0; i <= len - 1; i++)
                {
                    this.chartOne_APD.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxVuvod_APD.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_APD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSohranit_APD_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V14.txt";
                File.WriteAllText(path, textBoxVuvod_APD.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
