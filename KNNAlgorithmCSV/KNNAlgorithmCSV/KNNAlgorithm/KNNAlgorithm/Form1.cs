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

namespace KNNAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] result = new double[2, 2];
        private int maxbul(double[] benzerlik)
        {
            int yeri=0; double gecici=double.MinValue;
            for (int i = 0; i < benzerlik.Length; i++)
            {
                if (gecici <benzerlik[i])
                {
                    gecici = benzerlik[i];
                    yeri = i; 
                }
            }
            benzerlik[yeri] = -1;
            return yeri;
        } 
        private void matrisiSifirla()
        {
            for (int i = 0; i < 4; i++)
                result[i / 2, i % 2] = 0;
        }
        private void SonuclariYorumla()
        {
            kesin.Text = (result[0, 0] / (result[0, 0] + result[0, 1])).ToString();
            duyarlilik.Text = (result[1, 1] / (result[1, 0] + result[1, 1])).ToString();
            dogruluk.Text = ((result[0, 0] + result[1, 1]) / (result[0, 0] + result[0, 1] + result[1, 0] + result[1, 1])).ToString();
            folcum.Text = ((2 * result[0, 0]) / (2 * result[0, 0] + result[0, 1] + result[1, 0])).ToString();
            hataOrani.Text = (1 - double.Parse(dogruluk.Text)).ToString();
            matrisiSifirla();
        }
        private void KNNBelirle(double[] benzerlik,int knn,int eleman)
        {
            int _sutun = Information.dt.Columns.Count - 1;
            for (int i = 0; i < knn; i++)
            {
                int yeri = maxbul(benzerlik);
                if (Information.dt.Rows[yeri][_sutun].ToString() == "Yes")
                    Information.yes++;
                if (Information.dt.Rows[yeri][_sutun].ToString() == "No")
                    Information.no++;
            }
            if (Information.yes >= Information.no && Information.dt.Rows[eleman][_sutun].ToString() == "Yes") result[0, 0]++;
            else if (Information.yes >= Information.no && Information.dt.Rows[eleman][_sutun].ToString() == "No") result[1, 0]++;
            else if (Information.no > Information.yes && Information.dt.Rows[eleman][_sutun].ToString() == "Yes") result[0, 1]++;
            else result[1, 1]++;

            //MessageBox.Show($"Yes :  {Information.yes}  No : {Information.no}");
            Information.yes = 0;Information.no = 0;
       //     MessageBox.Show((result[0, 0] + " -- " + result[0, 1] + "--  " + result[1, 0] + " --  " + result[1, 1]));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sutun = double.Parse(Information.dt.Columns.Count.ToString())-2;
            double[] benzerlik = new double[Information.dt.Rows.Count];
            int knn = int.Parse(txtKnnSayi.Text);

            double geciciSay = 0;      
            for (int eleman = 0; eleman < Information.dt.Rows.Count; eleman++) // 5 eleman seçtim
            {
                for (int i = 0; i < Information.dt.Rows.Count; i++) // Satır boyunca ilerle
                {
                    if (!(eleman == i))
                    {
                        for (int j = 1; j <=sutun; j++) // Sutun Boyunca ilerle
                        {
                                if (Information.dt.Rows[i][j].Equals(Information.dt.Rows[eleman][j]))
                                    geciciSay++;
                        } 
                        benzerlik[i] = geciciSay / sutun; //Benzerlik Ölçülerini diziye aktariyor
                        geciciSay = 0;
                    }  
                }
                KNNBelirle(benzerlik,knn,eleman); // Hangi Sınıfa ait olduğunu bulan fonksiyondur.
            }
            SonuclariYorumla();  // Sonuçları Label'lara aktaran br fonksiyondur
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName.ToString();
            dataGridView1.DataSource = Information.VerileriDoldur(txtFilePath.Text);

        }
    }
}
