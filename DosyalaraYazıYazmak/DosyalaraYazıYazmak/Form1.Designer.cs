namespace DosyalaraYazıYazmak
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.btn_renkSec = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_metin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_boyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(22, 78);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(216, 38);
            this.btn_resimSec.TabIndex = 0;
            this.btn_resimSec.Text = "RESİM SEÇ";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // btn_renkSec
            // 
            this.btn_renkSec.Location = new System.Drawing.Point(22, 138);
            this.btn_renkSec.Name = "btn_renkSec";
            this.btn_renkSec.Size = new System.Drawing.Size(216, 38);
            this.btn_renkSec.TabIndex = 1;
            this.btn_renkSec.Text = "RENK SEÇ";
            this.btn_renkSec.UseVisualStyleBackColor = true;
            this.btn_renkSec.Click += new System.EventHandler(this.btn_renkSec_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(22, 199);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(216, 38);
            this.btn_yazdir.TabIndex = 2;
            this.btn_yazdir.Text = "YAZDIR";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(22, 259);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(216, 38);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metin :";
            // 
            // txt_metin
            // 
            this.txt_metin.Location = new System.Drawing.Point(95, 340);
            this.txt_metin.Name = "txt_metin";
            this.txt_metin.Size = new System.Drawing.Size(143, 32);
            this.txt_metin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boyut :";
            // 
            // txt_boyut
            // 
            this.txt_boyut.Location = new System.Drawing.Point(95, 401);
            this.txt_boyut.Name = "txt_boyut";
            this.txt_boyut.Size = new System.Drawing.Size(143, 32);
            this.txt_boyut.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_resimSec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(829, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_boyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_metin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_renkSec);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.btn_resimSec);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.Button btn_renkSec;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_metin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_boyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

