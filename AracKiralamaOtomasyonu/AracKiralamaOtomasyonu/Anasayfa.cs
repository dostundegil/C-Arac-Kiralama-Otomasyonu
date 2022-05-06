using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteriListele musteri_listele = new frmMusteriListele();
            musteri_listele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAraçKayıt kayıt = new frmAraçKayıt();
            kayıt.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmAraçListele listele = new frmAraçListele();
            listele.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            frmSözleşme sözleşme = new frmSözleşme();
            sözleşme.ShowDialog();
            }
            catch
            {
                ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSatış satış = new frmSatış();
            satış.ShowDialog();
        }
    }
}
