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
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Arac_Kiralama arac = new Arac_Kiralama();

        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            Boş_araçlar();
            Yenile();
        }

        private void Boş_araçlar()
        {
            string komut2 = "select * from arac where durumu='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, komut2);
        }

        private void Yenile()
        {
            string komut3 = "select * from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, komut3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string komut2 = "select * from arac where plaka like '" + comboAraçlar.SelectedItem + "' ";
            arac.Combo(comboAraçlar,txtMarka,txtSeri,txtModel,txtRenk, komut2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDönüş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gunler = gun.Days;
            txtGün.Text = gunler.ToString();
            txtTutar.Text = (gunler * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateÇıkış.Text = DateTime.Now.ToShortDateString();
            dateDönüş.Text = DateTime.Now.ToShortDateString();
            comboKira.Text = "";
            txtKiraÜcreti.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try{

            
           
            string sorgu = "insert into sözleşme(tc, adsoyad, telefon, ehliyetno, e_tarih, e_yer, plaka, marka, seri, yil, renk, kirasekli, kiraucreti, gun, tutar, ctarih, dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_no.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_yer.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", txtKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar",int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.güncelle_sil_ekle(komut2, sorgu);
            string sorgu3 = "update arac set durumu='DOLU' where plaka='"+comboAraçlar.Text+"' ";
            SqlCommand komut3 = new SqlCommand();
            arac.güncelle_sil_ekle(komut3, sorgu3);
            comboAraçlar.Items.Clear();
            Boş_araçlar();
            Yenile();
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            if (txtTc.Text == "") foreach (Control item in Aracgroup.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Başarıyla Oluşturuldu.");
            }
             catch
            {
                ;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string komut2 = "select * from musteri_bilgileri where tc like '" + txtTcAra.Text + "' ";
            arac.TC_Bul(txtTcAra,txtTc, txtAdSoyad, txtTelefon, komut2);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into sözleşme(tc, adsoyad, telefon, ehliyetno, e_tarih, e_yer, plaka, marka, seri, yil, renk, kirasekli, kiraucreti, gun, tutar, ctarih, dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();
            try { 
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_no.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_yer.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtModel.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", txtKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.güncelle_sil_ekle(komut2, sorgu);
            string sorgu3 = "update arac set durumu='DOLU' where plaka='" + comboAraçlar.Text + "' ";
            SqlCommand komut3 = new SqlCommand();
            arac.güncelle_sil_ekle(komut3, sorgu3);
            comboAraçlar.Items.Clear();
            Boş_araçlar();
            Yenile();
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            if (txtTc.Text == "") foreach (Control item in Aracgroup.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Başarıyla Güncellendi.");
            }
            catch {
                ;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtE_no.Text = satır.Cells[3].Value.ToString();
            txtE_tarih.Text = satır.Cells[4].Value.ToString();
            txtE_yer.Text = satır.Cells[5].Value.ToString();
            comboAraçlar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtModel.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKira.Text = satır.Cells[11].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[12].Value.ToString();
            txtGün.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateÇıkış.Text = satır.Cells[15].Value.ToString();
            dateDönüş.Text = satır.Cells[16].Value.ToString();


        }

        private void btnAraçTeslim_Click(object sender, EventArgs e)
        {
            try { 
            

            DataGridViewRow satır = dataGridView1.CurrentRow;
            DateTime şuan = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
            DateTime çıkış = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
            TimeSpan gun = şuan - çıkış;
            int _gun = gun.Days;
            int toplamtutar = _gun * ucret;
            string sorgu1 = "delete from sözleşme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand();
            arac.güncelle_sil_ekle(komut, sorgu1);
            string sorgu2= "update arac set durumu = 'BOŞ' where plaka='"+satır.Cells["plaka"].Value.ToString()+"' ";
            SqlCommand komut3 = new SqlCommand();
            arac.güncelle_sil_ekle(komut3, sorgu2);
            string sorgu3 = "insert into satış(tc, adsoyad,plaka, marka, seri, yil, renk, gun, tutar, tarih1, tarih2,fiyat) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
            komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
            komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
            komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
            komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
            komut2.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
            komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
            komut2.Parameters.AddWithValue("@gun", _gun);
            komut2.Parameters.AddWithValue("@tutar", toplamtutar);
            komut2.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
            komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
            komut2.Parameters.AddWithValue("@fiyat", ucret);
            arac.güncelle_sil_ekle(komut2, sorgu3);
            MessageBox.Show("Araç Teslim Edildi.");
            comboAraçlar.Items.Clear();
            Boş_araçlar();
            Yenile();
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            if (txtTc.Text == "") foreach (Control item in Aracgroup.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            }
            catch {
                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
