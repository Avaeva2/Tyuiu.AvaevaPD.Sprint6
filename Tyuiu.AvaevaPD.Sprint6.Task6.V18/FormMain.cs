using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AvaevaPD.Sprint6.Task6.V18.Lib;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonFail_APD_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask_APD.ShowDialog();
            openFilePath = openFileDialogTask_APD.FileName;
            textBoxIN_APD.Text = File.ReadAllText(openFilePath);
            groupBoxVuvod_APD.Text = groupBoxVuvod_APD.Text + " " + openFileDialogTask_APD.FileName;
            buttonFail_APD.Enabled = true;
        }

        private void buttonOUT_APD_Click(object sender, EventArgs e)
        {
            string str = "n";
            textBoxOut_APD.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_APD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
