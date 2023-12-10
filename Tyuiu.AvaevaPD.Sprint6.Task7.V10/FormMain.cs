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
using Tyuiu.AvaevaPD.Sprint6.Task7.V10.Lib;
namespace Tyuiu.AvaevaPD.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_APD.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix_APD.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewVvod_APD.ColumnCount = 50;
            dataGridViewVuvod_APD.ColumnCount = 50;

            dataGridViewVvod_APD.RowCount = 50;
            dataGridViewVuvod_APD.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewVvod_APD.Columns[i].Width = 25;
                dataGridViewVuvod_APD.Columns[i].Width = 25;
            }
        }

        private void labelUslovie_APD_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxFils_APD_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFileCopy_APD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_APD.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_APD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_APD.ShowDialog();

            string path = saveFileDialogMatrix_APD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewVuvod_APD.RowCount;
            int columns = dataGridViewVuvod_APD.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewVuvod_APD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewVuvod_APD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFileCopy_APD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_APD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonWhite_APD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_APD.ToolTipTitle = "Открыть файл";
        }

        private void buttonYellow_APD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_APD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonYellow_APD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVuvod_APD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonFileCopy_APD.Enabled = true;
        }

        private void buttonHelp_APD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonWhite_APD_Click(object sender, EventArgs e)
        {

        }
    }
}
