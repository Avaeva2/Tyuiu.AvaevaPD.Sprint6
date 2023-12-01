using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task0.V21.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task0.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDONE_APD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_APD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxAnswer_APD.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_APD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 10 || e.KeyChar >= 70) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHELP_APD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение");
        }
    }
}
