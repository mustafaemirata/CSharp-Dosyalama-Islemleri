using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
       
        Color renk;
        private void renkSecBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        private void resimSecBtn_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }
        Bitmap bmp;
        private void yazdirBtn_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr=Graphics.FromImage(bmp);
            gr.DrawString(txtMetin.Text,new Font("Segoe UI",Convert.ToInt16(txtBoyut.Text),FontStyle.Bold),
                new SolidBrush(renk),20,30);
            pictureBox1.Image = bmp;    
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim| .jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
