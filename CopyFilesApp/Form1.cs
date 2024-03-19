using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFilesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilesUtilities.CopyAllFiles(textBoxSourceFolder.Text, textBoxTargetFolder.Text, ShowMessageBox);
        }

        public bool ShowMessageBox(string filePath)
        {
           var res = MessageBox.Show("The file " + filePath + " already exist copy anyway? (The exist file will override)", "File exist warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
