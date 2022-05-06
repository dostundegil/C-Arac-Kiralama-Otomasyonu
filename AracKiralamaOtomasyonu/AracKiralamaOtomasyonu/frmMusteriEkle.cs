using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    
    public partial class frmMusteriEkle : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtAdSoyad.Text == "" || txtTelefon.Text == "" || txtAdres.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Alan/Alanlar Boş Bırakılamaz.");
            }
            else { 
            string girdi = "insert into musteri_bilgileri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_kiralama.güncelle_sil_ekle(komut2, girdi);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Müşteri Başarıyla Eklendi.");
        }
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
