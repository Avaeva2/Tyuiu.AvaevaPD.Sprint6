using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task3.V11.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }
        
        int[,] matrix = new int [5,5] { {27,-15, 14 ,2 ,27},
                                      {-8,14, -10, 33, 0},
                                      {1,7,-11 , -11, 23},
                                      {-13,-20,15,-16,34},
                                      {-3,1,-1,5,1}};
        private void Form1_Load(object sender, EventArgs e)
        {

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewFunction.ColumnCount = columns;
            dataGridViewFunction.RowCount = rows;

            //задаем ширину столбцов
            for (int i = 0; i < columns; i++)
            {

                dataGridViewFunction.Columns[i].Width = 25;
            }

            // заполняем сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewFunction.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonDone_APD_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for (int i = 0; i < rows; i ++)
            {
                for (int j = 0; j < columns; j ++)
                {
                    dataGridViewFunction.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonSpravka_APD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСПБ-23-1 Аваева Полина Дмитриевна", "Сообщение");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
