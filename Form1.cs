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

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbFolder.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(tbFolder.Text);
            //var directory = dir.GetDirectories();
            var images = Directory.GetFiles(tbFolder.Text, "*.jpg");
            pbPicture.Image = Image.FromFile(images[0]);
            bLeft.Image = Image.FromFile(images[1]);
            bRight.Image = Image.FromFile(images[2]);
        }

        private void bLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
