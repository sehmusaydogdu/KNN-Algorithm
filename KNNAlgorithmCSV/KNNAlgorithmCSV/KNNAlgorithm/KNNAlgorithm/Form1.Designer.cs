namespace KNNAlgorithm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKnnSayi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hataOrani = new System.Windows.Forms.Label();
            this.HataOranı = new System.Windows.Forms.Label();
            this.folcum = new System.Windows.Forms.Label();
            this.FDeğeri = new System.Windows.Forms.Label();
            this.dogruluk = new System.Windows.Forms.Label();
            this.duyarlilik = new System.Windows.Forms.Label();
            this.Doğruluk = new System.Windows.Forms.Label();
            this.Duyarlılık = new System.Windows.Forms.Label();
            this.Kesinlik = new System.Windows.Forms.Label();
            this.kesin = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(465, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çalıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(478, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "KNN Değerini Giriniz";
            // 
            // txtKnnSayi
            // 
            this.txtKnnSayi.Location = new System.Drawing.Point(465, 93);
            this.txtKnnSayi.Name = "txtKnnSayi";
            this.txtKnnSayi.Size = new System.Drawing.Size(200, 20);
            this.txtKnnSayi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hataOrani);
            this.groupBox1.Controls.Add(this.HataOranı);
            this.groupBox1.Controls.Add(this.folcum);
            this.groupBox1.Controls.Add(this.FDeğeri);
            this.groupBox1.Controls.Add(this.dogruluk);
            this.groupBox1.Controls.Add(this.duyarlilik);
            this.groupBox1.Controls.Add(this.Doğruluk);
            this.groupBox1.Controls.Add(this.Duyarlılık);
            this.groupBox1.Controls.Add(this.Kesinlik);
            this.groupBox1.Controls.Add(this.kesin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(465, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
            // 
            // hataOrani
            // 
            this.hataOrani.AutoSize = true;
            this.hataOrani.Location = new System.Drawing.Point(110, 180);
            this.hataOrani.Name = "hataOrani";
            this.hataOrani.Size = new System.Drawing.Size(29, 20);
            this.hataOrani.TabIndex = 10;
            this.hataOrani.Text = "hd";
            // 
            // HataOranı
            // 
            this.HataOranı.AutoSize = true;
            this.HataOranı.Location = new System.Drawing.Point(7, 180);
            this.HataOranı.Name = "HataOranı";
            this.HataOranı.Size = new System.Drawing.Size(96, 20);
            this.HataOranı.TabIndex = 9;
            this.HataOranı.Text = "Hata Oranı";
            // 
            // folcum
            // 
            this.folcum.AutoSize = true;
            this.folcum.Location = new System.Drawing.Point(109, 146);
            this.folcum.Name = "folcum";
            this.folcum.Size = new System.Drawing.Size(25, 20);
            this.folcum.TabIndex = 8;
            this.folcum.Text = "fd";
            // 
            // FDeğeri
            // 
            this.FDeğeri.AutoSize = true;
            this.FDeğeri.Location = new System.Drawing.Point(6, 146);
            this.FDeğeri.Name = "FDeğeri";
            this.FDeğeri.Size = new System.Drawing.Size(80, 20);
            this.FDeğeri.TabIndex = 7;
            this.FDeğeri.Text = "F Ölçüm ";
            // 
            // dogruluk
            // 
            this.dogruluk.AutoSize = true;
            this.dogruluk.Location = new System.Drawing.Point(107, 109);
            this.dogruluk.Name = "dogruluk";
            this.dogruluk.Size = new System.Drawing.Size(29, 20);
            this.dogruluk.TabIndex = 6;
            this.dogruluk.Text = "dd";
            // 
            // duyarlilik
            // 
            this.duyarlilik.AutoSize = true;
            this.duyarlilik.Location = new System.Drawing.Point(109, 71);
            this.duyarlilik.Name = "duyarlilik";
            this.duyarlilik.Size = new System.Drawing.Size(29, 20);
            this.duyarlilik.TabIndex = 3;
            this.duyarlilik.Text = "dd";
            // 
            // Doğruluk
            // 
            this.Doğruluk.AutoSize = true;
            this.Doğruluk.Location = new System.Drawing.Point(6, 109);
            this.Doğruluk.Name = "Doğruluk";
            this.Doğruluk.Size = new System.Drawing.Size(81, 20);
            this.Doğruluk.TabIndex = 5;
            this.Doğruluk.Text = "Doğruluk";
            // 
            // Duyarlılık
            // 
            this.Duyarlılık.AutoSize = true;
            this.Duyarlılık.Location = new System.Drawing.Point(6, 71);
            this.Duyarlılık.Name = "Duyarlılık";
            this.Duyarlılık.Size = new System.Drawing.Size(81, 20);
            this.Duyarlılık.TabIndex = 2;
            this.Duyarlılık.Text = "Duyarlılık";
            // 
            // Kesinlik
            // 
            this.Kesinlik.AutoSize = true;
            this.Kesinlik.Location = new System.Drawing.Point(6, 35);
            this.Kesinlik.Name = "Kesinlik";
            this.Kesinlik.Size = new System.Drawing.Size(70, 20);
            this.Kesinlik.TabIndex = 1;
            this.Kesinlik.Text = "Kesinlik";
            // 
            // kesin
            // 
            this.kesin.AutoSize = true;
            this.kesin.Location = new System.Drawing.Point(109, 35);
            this.kesin.Name = "kesin";
            this.kesin.Size = new System.Drawing.Size(28, 20);
            this.kesin.TabIndex = 0;
            this.kesin.Text = "kd";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 21);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(310, 20);
            this.txtFilePath.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(328, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKnnSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "KNN Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKnnSayi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dogruluk;
        private System.Windows.Forms.Label duyarlilik;
        private System.Windows.Forms.Label Doğruluk;
        private System.Windows.Forms.Label Duyarlılık;
        private System.Windows.Forms.Label Kesinlik;
        private System.Windows.Forms.Label kesin;
        private System.Windows.Forms.Label folcum;
        private System.Windows.Forms.Label FDeğeri;
        private System.Windows.Forms.Label hataOrani;
        private System.Windows.Forms.Label HataOranı;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

