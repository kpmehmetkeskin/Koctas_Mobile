namespace KoctasMobil
{
    partial class frm_MatIade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MatIade));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.txt_matnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_Urun = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_toplamTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.rdb_Raf = new System.Windows.Forms.RadioButton();
            this.rdb_Sarf = new System.Windows.Forms.RadioButton();
            this.rdb_Tedarikci = new System.Windows.Forms.RadioButton();
            this.btn_Temizle = new KoctasMobil.PictureButton();
            this.btn_iptal = new KoctasMobil.PictureButton();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Barkod :";
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.Location = new System.Drawing.Point(53, 2);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(106, 23);
            this.txt_Barkod.TabIndex = 1;
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barkod_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(162, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.Text = "Miktar    :";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(224, 2);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(59, 23);
            this.txt_miktar.TabIndex = 4;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // txt_matnr
            // 
            this.txt_matnr.Location = new System.Drawing.Point(75, 26);
            this.txt_matnr.Name = "txt_matnr";
            this.txt_matnr.Size = new System.Drawing.Size(84, 23);
            this.txt_matnr.TabIndex = 8;
            this.txt_matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matnr_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Ürün Kodu :";
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(75, 52);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(240, 22);
            this.txt_maktx.TabIndex = 13;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maktx_KeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı    :";
            // 
            // grd_Urun
            // 
            this.grd_Urun.BackColor = System.Drawing.Color.White;
            this.grd_Urun.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Urun.Location = new System.Drawing.Point(2, 113);
            this.grd_Urun.Name = "grd_Urun";
            this.grd_Urun.Size = new System.Drawing.Size(315, 128);
            this.grd_Urun.TabIndex = 30;
            this.grd_Urun.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_Urun.DoubleClick += new System.EventHandler(this.grd_Urun_DoubleClick);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Ürün Kodu";
            this.dataGridTextBoxColumn1.MappingName = "MATNR";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 60;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Ürün Adý";
            this.dataGridTextBoxColumn2.MappingName = "MAKTX";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 130;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridTextBoxColumn3.MappingName = "MENGE";
            this.dataGridTextBoxColumn3.NullText = "";
            this.dataGridTextBoxColumn3.Width = 30;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Ö.B.";
            this.dataGridTextBoxColumn4.MappingName = "MEINS";
            this.dataGridTextBoxColumn4.NullText = "";
            this.dataGridTextBoxColumn4.Width = 35;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Ýade";
            this.dataGridTextBoxColumn5.MappingName = "IADE";
            this.dataGridTextBoxColumn5.NullText = "";
            this.dataGridTextBoxColumn5.Width = 33;
            // 
            // txt_toplamTutar
            // 
            this.txt_toplamTutar.BackColor = System.Drawing.Color.Tomato;
            this.txt_toplamTutar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_toplamTutar.ForeColor = System.Drawing.Color.White;
            this.txt_toplamTutar.Location = new System.Drawing.Point(211, 247);
            this.txt_toplamTutar.Name = "txt_toplamTutar";
            this.txt_toplamTutar.Size = new System.Drawing.Size(105, 22);
            this.txt_toplamTutar.TabIndex = 35;
            this.txt_toplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_toplamTutar_KeyDown);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(120, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Toplam Tutar :";
            // 
            // txt_birim
            // 
            this.txt_birim.BackColor = System.Drawing.Color.Tomato;
            this.txt_birim.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_birim.ForeColor = System.Drawing.Color.White;
            this.txt_birim.Location = new System.Drawing.Point(283, 2);
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(34, 22);
            this.txt_birim.TabIndex = 6;
            this.txt_birim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_birim_KeyPress);
            // 
            // rdb_Raf
            // 
            this.rdb_Raf.Checked = true;
            this.rdb_Raf.Location = new System.Drawing.Point(171, 29);
            this.rdb_Raf.Name = "rdb_Raf";
            this.rdb_Raf.Size = new System.Drawing.Size(39, 20);
            this.rdb_Raf.TabIndex = 59;
            this.rdb_Raf.Text = "R";
            // 
            // rdb_Sarf
            // 
            this.rdb_Sarf.Location = new System.Drawing.Point(220, 29);
            this.rdb_Sarf.Name = "rdb_Sarf";
            this.rdb_Sarf.Size = new System.Drawing.Size(39, 20);
            this.rdb_Sarf.TabIndex = 60;
            this.rdb_Sarf.TabStop = false;
            this.rdb_Sarf.Text = "S";
            // 
            // rdb_Tedarikci
            // 
            this.rdb_Tedarikci.Location = new System.Drawing.Point(266, 29);
            this.rdb_Tedarikci.Name = "rdb_Tedarikci";
            this.rdb_Tedarikci.Size = new System.Drawing.Size(39, 20);
            this.rdb_Tedarikci.TabIndex = 61;
            this.rdb_Tedarikci.TabStop = false;
            this.rdb_Tedarikci.Text = "T";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.BackgroundImage")));
            this.btn_Temizle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(161, 82);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.PressedImage")));
            this.btn_Temizle.Size = new System.Drawing.Size(76, 25);
            this.btn_Temizle.TabIndex = 52;
            this.btn_Temizle.Text = "    Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.BackgroundImage")));
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(239, 82);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.PressedImage")));
            this.btn_iptal.Size = new System.Drawing.Size(76, 25);
            this.btn_iptal.TabIndex = 45;
            this.btn_iptal.Text = "     Vazgeç";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(3, 245);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(97, 25);
            this.btn_Kaydet.TabIndex = 44;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(82, 82);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.PressedImage")));
            this.btn_Sil.Size = new System.Drawing.Size(76, 25);
            this.btn_Sil.TabIndex = 43;
            this.btn_Sil.Text = "   Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(2, 82);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(76, 25);
            this.btn_Ekle.TabIndex = 42;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // frm_MatIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.rdb_Tedarikci);
            this.Controls.Add(this.rdb_Sarf);
            this.Controls.Add(this.rdb_Raf);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.txt_toplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grd_Urun);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_matnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MatIade";
            this.Text = "Sipariş İade";
            this.Load += new System.EventHandler(this.frm_NormalSiparisYarat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.TextBox txt_matnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGrid grd_Urun;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.TextBox txt_toplamTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_birim;
        private PictureButton btn_Ekle;
        private PictureButton btn_Sil;
        private PictureButton btn_Kaydet;
        private PictureButton btn_iptal;
        private PictureButton btn_Temizle;
        private System.Windows.Forms.RadioButton rdb_Raf;
        private System.Windows.Forms.RadioButton rdb_Sarf;
        private System.Windows.Forms.RadioButton rdb_Tedarikci;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
    }
}