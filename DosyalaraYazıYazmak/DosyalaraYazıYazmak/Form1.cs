using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyalaraYazıYazmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;

        }
        Color renk;
        private void btn_renkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }


        Bitmap bmp; // üzerinde değişiklik yapacağımız dosyalar için kullandığımız uzantı
        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(txt_metin.Text, new Font("Tahoma", Convert.ToInt16(txt_boyut.Text), FontStyle.Bold), new SolidBrush(renk), 50, 50);
            pictureBox1.Image = bmp;    
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
