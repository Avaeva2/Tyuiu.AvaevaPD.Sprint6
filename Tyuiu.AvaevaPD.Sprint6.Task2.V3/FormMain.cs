using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task2.V3.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task2.V3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_APD_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_APD.Text);
                int stopValue = Convert.ToInt32(textBoxEnd_APD.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] result = new double[len];
                 

                result = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction.Titles.Add("График функции F(X)= sin(x)/(x + 1.2) + cos(x) * 7 * x - 2");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startValue), Convert.ToString(result[i]));
                    this.chartFunction.Series[0].Points.AddXY(startValue, result[i]);
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
            MessageBox.Show("Таск 2 выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение");
        }

        private void buttonDone_APD_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_APD.BackColor = Color.Red;
        }

        private void buttonDone_APD_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_APD.BackColor = Color.Green;
        }

        private void buttonDone_APD_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_APD.BackColor = Color.Blue;
        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
