namespace tugasweek14
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
            this.masukkankalimat = new System.Windows.Forms.Label();
            this.masukkanhuruf = new System.Windows.Forms.Label();
            this.menjadi = new System.Windows.Forms.Label();
            this.tombolkonversi = new System.Windows.Forms.Button();
            this.tekshasil = new System.Windows.Forms.Label();
            this.hasilbeneran = new System.Windows.Forms.Label();
            this.textboxkalimat = new System.Windows.Forms.TextBox();
            this.textboxhuruf = new System.Windows.Forms.TextBox();
            this.textboxmenjadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // masukkankalimat
            // 
            this.masukkankalimat.AutoSize = true;
            this.masukkankalimat.Location = new System.Drawing.Point(23, 30);
            this.masukkankalimat.Name = "masukkankalimat";
            this.masukkankalimat.Size = new System.Drawing.Size(138, 20);
            this.masukkankalimat.TabIndex = 0;
            this.masukkankalimat.Text = "Masukkan Kalimat";
            // 
            // masukkanhuruf
            // 
            this.masukkanhuruf.AutoSize = true;
            this.masukkanhuruf.Location = new System.Drawing.Point(29, 89);
            this.masukkanhuruf.Name = "masukkanhuruf";
            this.masukkanhuruf.Size = new System.Drawing.Size(126, 20);
            this.masukkanhuruf.TabIndex = 1;
            this.masukkanhuruf.Text = "Masukkan Huruf";
            this.masukkanhuruf.Click += new System.EventHandler(this.masukkanhuruf_Click);
            // 
            // menjadi
            // 
            this.menjadi.AutoSize = true;
            this.menjadi.Location = new System.Drawing.Point(295, 89);
            this.menjadi.Name = "menjadi";
            this.menjadi.Size = new System.Drawing.Size(64, 20);
            this.menjadi.TabIndex = 2;
            this.menjadi.Text = "Menjadi";
            // 
            // tombolkonversi
            // 
            this.tombolkonversi.Location = new System.Drawing.Point(183, 134);
            this.tombolkonversi.Name = "tombolkonversi";
            this.tombolkonversi.Size = new System.Drawing.Size(295, 33);
            this.tombolkonversi.TabIndex = 3;
            this.tombolkonversi.Text = "Konversi!";
            this.tombolkonversi.UseVisualStyleBackColor = true;
            this.tombolkonversi.Click += new System.EventHandler(this.tombolkonversi_Click);
            // 
            // tekshasil
            // 
            this.tekshasil.AutoSize = true;
            this.tekshasil.Location = new System.Drawing.Point(29, 197);
            this.tekshasil.Name = "tekshasil";
            this.tekshasil.Size = new System.Drawing.Size(52, 20);
            this.tekshasil.TabIndex = 4;
            this.tekshasil.Text = "Hasil :";
            // 
            // hasilbeneran
            // 
            this.hasilbeneran.AutoSize = true;
            this.hasilbeneran.Location = new System.Drawing.Point(185, 197);
            this.hasilbeneran.Name = "hasilbeneran";
            this.hasilbeneran.Size = new System.Drawing.Size(13, 20);
            this.hasilbeneran.TabIndex = 5;
            this.hasilbeneran.Text = " ";
            this.hasilbeneran.Click += new System.EventHandler(this.hasilbeneran_Click);
            // 
            // textboxkalimat
            // 
            this.textboxkalimat.Location = new System.Drawing.Point(185, 32);
            this.textboxkalimat.Name = "textboxkalimat";
            this.textboxkalimat.Size = new System.Drawing.Size(293, 26);
            this.textboxkalimat.TabIndex = 6;
            this.textboxkalimat.TextChanged += new System.EventHandler(this.textboxkalimat_TextChanged);
            // 
            // textboxhuruf
            // 
            this.textboxhuruf.Location = new System.Drawing.Point(185, 86);
            this.textboxhuruf.Name = "textboxhuruf";
            this.textboxhuruf.Size = new System.Drawing.Size(100, 26);
            this.textboxhuruf.TabIndex = 7;
            this.textboxhuruf.TextChanged += new System.EventHandler(this.textboxhuruf_TextChanged);
            // 
            // textboxmenjadi
            // 
            this.textboxmenjadi.Location = new System.Drawing.Point(378, 86);
            this.textboxmenjadi.Name = "textboxmenjadi";
            this.textboxmenjadi.Size = new System.Drawing.Size(100, 26);
            this.textboxmenjadi.TabIndex = 8;
            this.textboxmenjadi.TextChanged += new System.EventHandler(this.textboxmenjadi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxmenjadi);
            this.Controls.Add(this.textboxhuruf);
            this.Controls.Add(this.textboxkalimat);
            this.Controls.Add(this.hasilbeneran);
            this.Controls.Add(this.tekshasil);
            this.Controls.Add(this.tombolkonversi);
            this.Controls.Add(this.menjadi);
            this.Controls.Add(this.masukkanhuruf);
            this.Controls.Add(this.masukkankalimat);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masukkankalimat;
        private System.Windows.Forms.Label masukkanhuruf;
        private System.Windows.Forms.Label menjadi;
        private System.Windows.Forms.Button tombolkonversi;
        private System.Windows.Forms.Label tekshasil;
        private System.Windows.Forms.Label hasilbeneran;
        private System.Windows.Forms.TextBox textboxkalimat;
        private System.Windows.Forms.TextBox textboxhuruf;
        private System.Windows.Forms.TextBox textboxmenjadi;
    }
}

