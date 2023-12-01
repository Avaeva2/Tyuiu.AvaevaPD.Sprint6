using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task1.V2.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_APD_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_APD.Text);
                int stopValue = Convert.ToInt32(textBoxEnd_APD.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_APD.Text = "";
                textBoxResult_APD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_APD.AppendText("|    X     +    f(x)  |" + Environment.NewLine);
                textBoxResult_APD.AppendText("+----------+----------+" + Environment.NewLine);

                for(int i = 0; i <= len - 1; i ++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 5:f2}    |", startValue, valueArray[i]);
                    textBoxResult_APD.AppendText(strLine + Environment.NewLine);
                    startValue++;

                }
                textBoxResult_APD.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_APD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск  1 выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение");
        }

        private void groupBoxResult_APD_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_APD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
