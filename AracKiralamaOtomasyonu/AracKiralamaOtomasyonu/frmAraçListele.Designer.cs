
namespace AracKiralamaOtomasyonu
{
    partial class frmAraçListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçListele));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ÜcretTxt = new System.Windows.Forms.TextBox();
            this.Yakıtcombo = new System.Windows.Forms.ComboBox();
            this.KmTxt = new System.Windows.Forms.TextBox();
            this.RenkTxt = new System.Windows.Forms.TextBox();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.PlakaTxt = new System.Windows.Forms.TextBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ComboAraçlar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.Location = new System.Drawing.Point(847, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 33);
            this.button3.TabIndex = 48;
            this.button3.Text = "Resmi Değiştir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(958, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 47;
            this.button2.Text = "Vazgeç";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh.png");
            this.imageList1.Images.SetKeyName(1, "vazgeç.png");
            this.imageList1.Images.SetKeyName(2, "sil.png");
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.White;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 0;
            this.btnGüncelle.ImageList = this.imageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(1069, 593);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(105, 41);
            this.btnGüncelle.TabIndex = 46;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(945, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(929, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(935, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(939, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Yakıt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(948, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(938, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Renk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(901, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Model(Yıl)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(935, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Plaka";
            // 
            // ÜcretTxt
            // 
            this.ÜcretTxt.Location = new System.Drawing.Point(983, 330);
            this.ÜcretTxt.Name = "ÜcretTxt";
            this.ÜcretTxt.Size = new System.Drawing.Size(191, 27);
            this.ÜcretTxt.TabIndex = 36;
            // 
            // Yakıtcombo
            // 
            this.Yakıtcombo.FormattingEnabled = true;
            this.Yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Lpg",
            "Elektrik"});
            this.Yakıtcombo.Location = new System.Drawing.Point(983, 296);
            this.Yakıtcombo.Name = "Yakıtcombo";
            this.Yakıtcombo.Size = new System.Drawing.Size(191, 28);
            this.Yakıtcombo.TabIndex = 35;
            // 
            // KmTxt
            // 
            this.KmTxt.Location = new System.Drawing.Point(983, 263);
            this.KmTxt.Name = "KmTxt";
            this.KmTxt.Size = new System.Drawing.Size(191, 27);
            this.KmTxt.TabIndex = 34;
            // 
            // RenkTxt
            // 
            this.RenkTxt.Location = new System.Drawing.Point(983, 230);
            this.RenkTxt.Name = "RenkTxt";
            this.RenkTxt.Size = new System.Drawing.Size(191, 27);
            this.RenkTxt.TabIndex = 33;
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(983, 197);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(191, 27);
            this.ModelTxt.TabIndex = 32;
            // 
            // PlakaTxt
            // 
            this.PlakaTxt.Location = new System.Drawing.Point(983, 96);
            this.PlakaTxt.Name = "PlakaTxt";
            this.PlakaTxt.Size = new System.Drawing.Size(191, 27);
            this.PlakaTxt.TabIndex = 31;
            // 
            // Sericombo
            // 
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(983, 163);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(191, 28);
            this.Sericombo.TabIndex = 30;
            // 
            // Markacombo
            // 
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "Audi",
            "Ford",
            "Fiat",
            "Opel",
            "BMW",
            "Honda",
            "Peugeot",
            "Renault"});
            this.Markacombo.Location = new System.Drawing.Point(983, 129);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(191, 28);
            this.Markacombo.TabIndex = 29;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.Markacombo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(771, 538);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(438, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 41);
            this.label11.TabIndex = 54;
            this.label11.Text = "Araç Listele / Güncelle / Sil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(847, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(847, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 56;
            this.button1.Text = "Aracı Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ComboAraçlar
            // 
            this.ComboAraçlar.FormattingEnabled = true;
            this.ComboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.ComboAraçlar.Location = new System.Drawing.Point(43, 55);
            this.ComboAraçlar.Name = "ComboAraçlar";
            this.ComboAraçlar.Size = new System.Drawing.Size(181, 28);
            this.ComboAraçlar.TabIndex = 57;
            this.ComboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmAraçListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AracKiralamaOtomasyonu.Properties.Resources.LinearGradientBrush_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 646);
            this.Controls.Add(this.ComboAraçlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ÜcretTxt);
            this.Controls.Add(this.Yakıtcombo);
            this.Controls.Add(this.KmTxt);
            this.Controls.Add(this.RenkTxt);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.PlakaTxt);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Name = "frmAraçListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAraçListele";
            this.Load += new System.EventHandler(this.frmAraçListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ÜcretTxt;
        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.TextBox KmTxt;
        private System.Windows.Forms.TextBox RenkTxt;
        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.TextBox PlakaTxt;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox ComboAraçlar;
    }
}