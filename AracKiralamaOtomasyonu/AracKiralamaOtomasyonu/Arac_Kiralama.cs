using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    class Arac_Kiralama
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4NSTPSE;Initial Catalog=Arac_Kiralama_Otomasyon;Integrated Security=True");
        DataTable tablo;
        public void güncelle_sil_ekle(SqlCommand komut,string sorgu)
        {
            
            connection.Open();
            komut.Connection = connection;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            connection.Close();
            
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, connection);
            adtr.Fill(tablo);
            connection.Close();
            return tablo;
        }
        public void Boş_Araçlar(ComboBox combo, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            connection.Close();
        }

        public void TC_Bul(TextBox tcra,TextBox tc,TextBox adsoyad,TextBox telefon, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text= read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            connection.Close();
        }

        public void Hesapla(ComboBox kirasekli,TextBox ücret, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (kirasekli.SelectedIndex == 0) ücret.Text = (int.Parse(read["ucret"].ToString()) * 1).ToString();
                if (kirasekli.SelectedIndex == 1) ücret.Text = (int.Parse(read["ucret"].ToString()) * 0.80).ToString();
                if (kirasekli.SelectedIndex == 2) ücret.Text = (int.Parse(read["ucret"].ToString()) * 0.70).ToString();
            }
            connection.Close();
        }

        public void Combo(ComboBox araclar,TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            connection.Close();
        }
        public void Satışhesapla(Label lbl)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satış",connection);
            lbl.Text = "Toplam Tutar= " + komut.ExecuteScalar() + "TL";
            connection.Close();

        }

    }
}
