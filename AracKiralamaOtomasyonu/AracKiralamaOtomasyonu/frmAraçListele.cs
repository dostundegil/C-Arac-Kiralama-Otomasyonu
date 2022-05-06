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
    public partial class frmAraçListele : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            PlakaTxt.Text=satır.Cells["plaka"].Value.ToString();
            Markacombo.Text = satır.Cells["marka"].Value.ToString();
            Sericombo.Text = satır.Cells["seri"].Value.ToString();
            ModelTxt.Text = satır.Cells["yil"].Value.ToString();
            RenkTxt.Text = satır.Cells["renk"].Value.ToString();
            KmTxt.Text = satır.Cells["km"].Value.ToString();
            Yakıtcombo.Text = satır.Cells["yakit"].Value.ToString();
            ÜcretTxt.Text = satır.Cells["ucret"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();

        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            try
            {
                ComboAraçlar.SelectedIndex = 0;
            }
            catch
            {
                ;
            }

        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource= arac_kiralama.listele(adtr2, cümle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try { 
            string cümle = "update arac set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,ucret=@ucret,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", PlakaTxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", ModelTxt.Text);
            komut2.Parameters.AddWithValue("@renk", RenkTxt.Text);
            komut2.Parameters.AddWithValue("@km", KmTxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@ucret", Convert.ToInt32(ÜcretTxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arac_kiralama.güncelle_sil_ekle(komut2, cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Araç Başarıyla Güncellendi.");
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
            }
            catch {
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from arac where plaka ='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arac_kiralama.güncelle_sil_ekle(komut2, cümle);
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Araç Başarıyla Silindi.");
        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Sericombo.Items.Clear();
                if (Markacombo.SelectedIndex == 0)
                {
                    Sericombo.Items.Add("A3");
                    Sericombo.Items.Add("A4");
                    Sericombo.Items.Add("A5");
                    Sericombo.Items.Add("A6");
                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Sericombo.Items.Add("Fiesta");
                    Sericombo.Items.Add("Focus");
                    Sericombo.Items.Add("Ranger");
                    Sericombo.Items.Add("Puma");
                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("Doblo");
                    Sericombo.Items.Add("Panda");
                    Sericombo.Items.Add("Egea");
                    Sericombo.Items.Add("Linea");
                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Corsa");
                    Sericombo.Items.Add("Astra");
                    Sericombo.Items.Add("Combo");
                    Sericombo.Items.Add("Omega");
                }
                else if (Markacombo.SelectedIndex == 4)
                {
                    Sericombo.Items.Add("X6");
                    Sericombo.Items.Add("X5");
                    Sericombo.Items.Add("X2");
                    Sericombo.Items.Add("M");
                }
                else if (Markacombo.SelectedIndex == 5)
                {
                    Sericombo.Items.Add("CR-Z");
                    Sericombo.Items.Add("CR-V");
                    Sericombo.Items.Add("Civic");
                    Sericombo.Items.Add("Jazz");
                }
                else if (Markacombo.SelectedIndex == 6)
                {
                    Sericombo.Items.Add("208");
                    Sericombo.Items.Add("301");
                    Sericombo.Items.Add("3008");
                    Sericombo.Items.Add("Rifter");
                }
                else if (Markacombo.SelectedIndex == 7)
                {
                    Sericombo.Items.Add("Clio");
                    Sericombo.Items.Add("Megane");
                    Sericombo.Items.Add("Talisman");
                    Sericombo.Items.Add("Kangoo");
                }



            }
            catch
            {
                ;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (ComboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select * from arac where durumu = 'BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arac_kiralama.listele(adtr2, cümle);
                }
                if (ComboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select * from arac where durumu = 'DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arac_kiralama.listele(adtr2, cümle);
                }
            }
            catch
            {
                ;
            }
        }
    }
}
