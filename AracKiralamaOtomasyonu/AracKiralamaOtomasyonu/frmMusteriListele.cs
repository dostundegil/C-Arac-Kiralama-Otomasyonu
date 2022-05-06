﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    public partial class frmMusteriListele : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            string girdi = "select * from musteri_bilgileri";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr3, girdi);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "ADRES";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string girdi = "select * from musteri_bilgileri where tc like '%" + textBox1.Text + "%' ";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr3, girdi);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try { 
            string cümle = "update musteri_bilgileri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arackiralama.güncelle_sil_ekle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Listele();
            MessageBox.Show("Müşteri Başarıyla Güncellendi.");
            }
            catch
            {
                ;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtAdres.Text = satır.Cells[3].Value.ToString();
            txtEmail.Text = satır.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from musteri_bilgileri where tc='"+satır.Cells["tc"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.güncelle_sil_ekle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Listele();
            MessageBox.Show("Müşteri Başarıyla Silindi.");

        }
    }
}
