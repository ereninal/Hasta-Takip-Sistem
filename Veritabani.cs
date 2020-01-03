using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaglikOcagiSistem
{
    public class Veritabani
    {
        private static Veritabani veritabani;
        private static string  baglantiCumlesi = "Data Source=EREN-LAPTOP\\SQLEXPRESS;Initial Catalog=SaglikOcagi;Integrated Security=True";
        public static SqlConnection baglanti= new SqlConnection(baglantiCumlesi);

        protected Veritabani()
        {

        }
        public static void Ac()
        {
            try
            {

                baglanti = new SqlConnection(baglantiCumlesi);


                if (baglanti != null && baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }
            }
            catch(SqlException sql)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı.");
            }
           
        }
        public static void Kapa()
        {
            if (baglanti.State.ToString() == "Open")
                baglanti.Close();
            baglanti = null;

        }
    }
}
