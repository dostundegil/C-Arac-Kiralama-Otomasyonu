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
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satış";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView2.DataSource = arac.listele(adtr2,sorgu2);
            arac.Satışhesapla(tutar);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
