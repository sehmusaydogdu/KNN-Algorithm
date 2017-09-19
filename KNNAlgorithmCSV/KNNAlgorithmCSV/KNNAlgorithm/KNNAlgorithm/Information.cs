using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNNAlgorithm
{
    class Information
    {
        public static DataTable dt;
        public static int yes = 0;
        public static int no = 0;
        public static DataTable VerileriDoldur(string path)
        {
            int i = 0;
            string[] satirDizi;
            string rLine;
            DataRow dRow;
            dt = new DataTable();
            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                rLine = reader.ReadLine();
                satirDizi = rLine.Split(',');
                for (int m = 0; m < satirDizi.Length; m++)
                    dt.Columns.Add(satirDizi[m]);
                while (rLine != null)
                {
                    rLine = reader.ReadLine();
                    if (rLine != null)
                    {
                        dRow = dt.NewRow();
                        dt.Rows.Add(dRow);
                        satirDizi = rLine.Split(',');
                        for (int j = 0; j < satirDizi.Length; j++)
                            dt.Rows[i][j] = satirDizi[j].ToString();
                        i++;
                    }
                }
                reader.Close();
            }
            return dt;
        }
    }
}

        
