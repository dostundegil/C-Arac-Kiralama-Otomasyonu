
namespace AracKiralamaOtomasyonu
{
    partial class frmAraçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayıt));
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.PlakaTxt = new System.Windows.Forms.TextBox();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.RenkTxt = new System.Windows.Forms.TextBox();
            this.KmTxt = new System.Windows.Forms.TextBox();
            this.Yakıtcombo = new System.Windows.Forms.ComboBox();
            this.ÜcretTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.İndirimTxt = new System.Windows.Forms.TextBox();
            this.btnIndirim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Markacombo.Location = new System.Drawing.Point(321, 124);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(191, 28);
            this.Markacombo.TabIndex = 0;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sericombo
            // 
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(321, 158);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(191, 28);
            this.Sericombo.TabIndex = 1;
            // 
            // PlakaTxt
            // 
            this.PlakaTxt.Location = new System.Drawing.Point(321, 91);
            this.PlakaTxt.Name = "PlakaTxt";
            this.PlakaTxt.Size = new System.Drawing.Size(191, 27);
            this.PlakaTxt.TabIndex = 2;
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(321, 192);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(191, 27);
            this.ModelTxt.TabIndex = 3;
            // 
            // RenkTxt
            // 
            this.RenkTxt.Location = new System.Drawing.Point(321, 225);
            this.RenkTxt.Name = "RenkTxt";
            this.RenkTxt.Size = new System.Drawing.Size(191, 27);
            this.RenkTxt.TabIndex = 4;
            // 
            // KmTxt
            // 
            this.KmTxt.Location = new System.Drawing.Point(321, 258);
            this.KmTxt.Name = "KmTxt";
            this.KmTxt.Size = new System.Drawing.Size(191, 27);
            this.KmTxt.TabIndex = 5;
            // 
            // Yakıtcombo
            // 
            this.Yakıtcombo.FormattingEnabled = true;
            this.Yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Lpg",
            "Elektrik"});
            this.Yakıtcombo.Location = new System.Drawing.Point(321, 291);
            this.Yakıtcombo.Name = "Yakıtcombo";
            this.Yakıtcombo.Size = new System.Drawing.Size(191, 28);
            this.Yakıtcombo.TabIndex = 6;
            // 
            // ÜcretTxt
            // 
            this.ÜcretTxt.Location = new System.Drawing.Point(321, 325);
            this.ÜcretTxt.Name = "ÜcretTxt";
            this.ÜcretTxt.Size = new System.Drawing.Size(191, 27);
            this.ÜcretTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(221, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Araç Ekle";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(273, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(239, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(276, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(286, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(277, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Yakıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(273, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ücret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(267, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(283, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Seri";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "araç ekle.png");
            this.imageList1.Images.SetKeyName(1, "vazgeç.png");
            this.imageList1.Images.SetKeyName(2, "resim ekle.png");
            this.imageList1.Images.SetKeyName(3, "indirim.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(420, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(194, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Vazgeç";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(102, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 25;
            this.button3.Text = "Resim Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(239, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "İndirim(%)";
            // 
            // İndirimTxt
            // 
            this.İndirimTxt.Location = new System.Drawing.Point(321, 358);
            this.İndirimTxt.Name = "İndirimTxt";
            this.İndirimTxt.Size = new System.Drawing.Size(191, 27);
            this.İndirimTxt.TabIndex = 26;
            // 
            // btnIndirim
            // 
            this.btnIndirim.BackColor = System.Drawing.Color.White;
            this.btnIndirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndirim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndirim.ImageIndex = 3;
            this.btnIndirim.ImageList = this.imageList1;
            this.btnIndirim.Location = new System.Drawing.Point(293, 398);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.Size = new System.Drawing.Size(121, 41);
            this.btnIndirim.TabIndex = 28;
            this.btnIndirim.Text = "İndirim Yap";
            this.btnIndirim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIndirim.UseVisualStyleBackColor = false;
            this.btnIndirim.Click += new System.EventHandler(this.btnIndirim_Click);
            // 
            // frmAraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracKiralamaOtomasyonu.Properties.Resources.LinearGradientBrush_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 465);
            this.Controls.Add(this.btnIndirim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.İndirimTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ÜcretTxt);
            this.Controls.Add(this.Yakıtcombo);
            this.Controls.Add(this.KmTxt);
            this.Controls.Add(this.RenkTxt);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.PlakaTxt);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Name = "frmAraçKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAraçKayıt";
            this.Load += new System.EventHandler(this.frmAraçKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.TextBox PlakaTxt;
        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.TextBox RenkTxt;
        private System.Windows.Forms.TextBox KmTxt;
        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.TextBox ÜcretTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox İndirimTxt;
        private System.Windows.Forms.Button btnIndirim;
    }
}