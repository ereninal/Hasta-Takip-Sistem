using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
namespace SaglikOcagiSistem
{
    public class Kontrol :Veritabani
    {
        //Veritabani v = Veritabani.Ac();
        public static void TextboxKontrol(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Focus();
                Kontrol.Mesaj("Bu Alan Boş Girilemez.", textBox);
            }
        }
        public static void UsernameKontrol(TextBox textBox)
        {
            if(textBox.Text != "")
            {
                if (!textBox.Text.Contains("@hastane.com"))
                {
                    textBox.Focus();
                    Kontrol.Mesaj("Lütfen sonu '@hastane.com' Uzantılı Kullanıcı Adını Giriniz.", textBox);
                }
            }
            
        }
        public static string KullaniciKontrol(string kAdi,string kSifre)
        {
            string yetki="";
            Veritabani.Ac();
            SqlCommand cmd = new SqlCommand("KullaniciKontrol", Veritabani.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", kAdi);
            cmd.Parameters.AddWithValue("@sifre", kSifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                yetki = dr["YETKİ"].ToString();
            Veritabani.Kapa();
            return yetki;
        }
        public static bool TcKimlikKontrol(TextBox text)
        {
            bool durum = false;
            int toplam = 0; int toplam2 = 0; int toplam3 = 0;
            if (text.Text.Length == 11)
            {
                if (Convert.ToInt32(text.Text[0].ToString()) != 0) //tc kimlik numaranın ilk hanesi 0 değilse
                {
                    for (int i = 0; i < 10; i++)
                    {
                        toplam = toplam + Convert.ToInt32(text.Text[i].ToString());
                        if (i % 2 == 0)
                        {
                            if (i != 10)
                            {
                                toplam2 = toplam2 + Convert.ToInt32(text.Text[i].ToString()); // 7 ile çarpılacak sayıları topluyoruz
                            }

                        }
                        else
                        {
                            if (i != 9)
                            {
                                toplam3 = toplam3 + Convert.ToInt32(text.Text[i].ToString());
                            }
                        }
                    }
                    if (((toplam2 * 7) - toplam3) % 10 == Convert.ToInt32(text.Text[9].ToString()) && toplam % 10 == Convert.ToInt32(text.Text[10].ToString()))
                    {
                        durum = true;
                    }
                    else
                    {
                        durum = false;
                    }
                }
                else
                {
                    Kontrol.Mesaj("Tc Kimlik Numaranızın ilk hanesi 0 olamaz.", text);
                }
            }
            
            return durum;
        }
        public static void TextboxSadeceHarf(KeyPressEventArgs e)
        {
            //string metin = "";
            e.Handled= !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
            //return metin =;
        }
        public static void TextboxSadeceRakam(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public static void FormTemizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
                if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.MaxDate = DateTime.Now;
                    dt.Value = DateTime.Now;
                }
                if(item is CheckBox)
                {
                    CheckBox c = (CheckBox)item;
                    c.Checked = false;
                }
                    
            }
        }
        public static void Mesaj(string aciklama, Control cntrl)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show(aciklama, cntrl,6000);
        }
    }
}
