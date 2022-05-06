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
    public partial class frmAraçKayıt : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAraçKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {

                Sericombo.Items.Clear();
                if (Markacombo.SelectedIndex== 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (PlakaTxt.Text==""|| Markacombo.Text==""|| Sericombo.Text==""|| ModelTxt.Text==""|| RenkTxt.Text==""|| KmTxt.Text==""|| Yakıtcombo.Text==""|| ÜcretTxt.Text==""|| pictureBox1.ImageLocation=="")
            {
                MessageBox.Show("Alan/Alanlar boş bırakılamaz.");
            }
            else { 
            string girdi = "insert into arac(plaka,marka,seri,yil,renk,km,yakit,ucret,resim,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@ucret,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            int ücret= Convert.ToInt32(ÜcretTxt.Text);
            komut2.Parameters.AddWithValue("@plaka", PlakaTxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", ModelTxt.Text);
            komut2.Parameters.AddWithValue("@renk", RenkTxt.Text);
            komut2.Parameters.AddWithValue("@km", KmTxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@ucret", Convert.ToInt32(ÜcretTxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arac_kiralama.güncelle_sil_ekle(komut2, girdi);
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Araç Başarıyla Eklendi.");
            pictureBox1.ImageLocation = "";
            }
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            int indirim,ücret,indirimli,miktar;
            string indirimliucret;
            try{ 
            indirim = Convert.ToInt32(İndirimTxt.Text);
            ücret = Convert.ToInt32(ÜcretTxt.Text);
            miktar = ücret;
            
            miktar = (miktar * indirim)/100;
            
            indirimli = ücret - miktar;
            indirimliucret=indirimli.ToString();
            ÜcretTxt.Text = indirimliucret;
            MessageBox.Show("İndirim başarıyla yapıldı yeni ücret: "+indirimliucret+"TL");
            }
            catch
            {
                ;
            }
            }
    }
}
