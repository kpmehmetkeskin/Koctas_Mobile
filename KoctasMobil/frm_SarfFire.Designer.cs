namespace KoctasMobil
{
    partial class frm_SarfFire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SarfFire));
            this.grd_SarfFire = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepoYeri = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdt = new System.Windows.Forms.TextBox();
            this.rbSarfFire = new System.Windows.Forms.RadioButton();
            this.rbMasraf = new System.Windows.Forms.RadioButton();
            this.rbSarfFireKayip = new System.Windows.Forms.RadioButton();
            this.rbAnhTesMasraf = new System.Windows.Forms.RadioButton();
            this.rbKayip = new System.Windows.Forms.RadioButton();
            this.rbFazla = new System.Windows.Forms.RadioButton();
            this.lblMatnr = new System.Windows.Forms.Label();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_iptal = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.SuspendLayout();
            // 
            // grd_SarfFire
            // 
            this.grd_SarfFire.BackColor = System.Drawing.Color.White;
            this.grd_SarfFire.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_SarfFire.Location = new System.Drawing.Point(3, 144);
            this.grd_SarfFire.Name = "grd_SarfFire";
            this.grd_SarfFire.Size = new System.Drawing.Size(315, 99);
            this.grd_SarfFire.TabIndex = 64;
            this.grd_SarfFire.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Malzeme ";
            this.dataGridTextBoxColumn5.MappingName = "Matnr";
            this.dataGridTextBoxColumn5.Width = 70;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Açıklama";
            this.dataGridTextBoxColumn6.MappingName = "Aciklama";
            this.dataGridTextBoxColumn6.Width = 100;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Miktar";
            this.dataGridTextBoxColumn7.MappingName = "Miktar";
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "İşlem";
            this.dataGridTextBoxColumn8.MappingName = "rB";
            this.dataGridTextBoxColumn8.Width = 60;
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(74, 26);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(242, 22);
            this.txt_maktx.TabIndex = 63;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maktx_KeyPress);
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.BackColor = System.Drawing.Color.White;
            this.txt_Barkod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_Barkod.ForeColor = System.Drawing.Color.Black;
            this.txt_Barkod.Location = new System.Drawing.Point(74, 4);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(142, 20);
            this.txt_Barkod.TabIndex = 61;
            this.txt_Barkod.TextChanged += new System.EventHandler(this.txt_Barkod_TextChanged);
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barkod_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "Malzeme  :";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı   :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtAciklama.ForeColor = System.Drawing.Color.Black;
            this.txtAciklama.Location = new System.Drawing.Point(74, 51);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(242, 20);
            this.txtAciklama.TabIndex = 76;
            this.txtAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAciklama_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "Açıklama  :";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.Text = "Depo Yeri :";
            // 
            // txtDepoYeri
            // 
            this.txtDepoYeri.BackColor = System.Drawing.Color.White;
            this.txtDepoYeri.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtDepoYeri.ForeColor = System.Drawing.Color.Black;
            this.txtDepoYeri.Location = new System.Drawing.Point(74, 75);
            this.txtDepoYeri.MaxLength = 4;
            this.txtDepoYeri.Name = "txtDepoYeri";
            this.txtDepoYeri.Size = new System.Drawing.Size(75, 20);
            this.txtDepoYeri.TabIndex = 90;
            this.txtDepoYeri.TextChanged += new System.EventHandler(this.txtDepoYeri_TextChanged);
            this.txtDepoYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepoYeri_KeyPress);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtMiktar.Location = new System.Drawing.Point(212, 76);
            this.txtMiktar.MaxLength = 18;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(65, 20);
            this.txtMiktar.TabIndex = 92;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(155, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.Text = "Miktar :";
            // 
            // txtAdt
            // 
            this.txtAdt.BackColor = System.Drawing.Color.Tomato;
            this.txtAdt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdt.ForeColor = System.Drawing.Color.White;
            this.txtAdt.Location = new System.Drawing.Point(279, 75);
            this.txtAdt.MaxLength = 18;
            this.txtAdt.Name = "txtAdt";
            this.txtAdt.Size = new System.Drawing.Size(36, 22);
            this.txtAdt.TabIndex = 94;
            this.txtAdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdt_KeyPress);
            // 
            // rbSarfFire
            // 
            this.rbSarfFire.Location = new System.Drawing.Point(4, 98);
            this.rbSarfFire.Name = "rbSarfFire";
            this.rbSarfFire.Size = new System.Drawing.Size(100, 20);
            this.rbSarfFire.TabIndex = 100;
            this.rbSarfFire.Text = "Sarf Fire";
            this.rbSarfFire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbSarfFire.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMasraf
            // 
            this.rbMasraf.Location = new System.Drawing.Point(229, 103);
            this.rbMasraf.Name = "rbMasraf";
            this.rbMasraf.Size = new System.Drawing.Size(72, 20);
            this.rbMasraf.TabIndex = 102;
            this.rbMasraf.Text = "Masraf";
            this.rbMasraf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbMasraf.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSarfFireKayip
            // 
            this.rbSarfFireKayip.Location = new System.Drawing.Point(110, 101);
            this.rbSarfFireKayip.Name = "rbSarfFireKayip";
            this.rbSarfFireKayip.Size = new System.Drawing.Size(113, 20);
            this.rbSarfFireKayip.TabIndex = 101;
            this.rbSarfFireKayip.Text = "Bilinen Kayıp";
            this.rbSarfFireKayip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbSarfFireKayip.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAnhTesMasraf
            // 
            this.rbAnhTesMasraf.Location = new System.Drawing.Point(196, 121);
            this.rbAnhTesMasraf.Name = "rbAnhTesMasraf";
            this.rbAnhTesMasraf.Size = new System.Drawing.Size(120, 20);
            this.rbAnhTesMasraf.TabIndex = 103;
            this.rbAnhTesMasraf.Text = "Anh Tes Masraf";
            this.rbAnhTesMasraf.Visible = false;
            this.rbAnhTesMasraf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbAnhTesMasraf.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbKayip
            // 
            this.rbKayip.Location = new System.Drawing.Point(4, 121);
            this.rbKayip.Name = "rbKayip";
            this.rbKayip.Size = new System.Drawing.Size(100, 20);
            this.rbKayip.TabIndex = 104;
            this.rbKayip.Text = "Kayıp";
            this.rbKayip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbKayip.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbFazla
            // 
            this.rbFazla.Location = new System.Drawing.Point(110, 121);
            this.rbFazla.Name = "rbFazla";
            this.rbFazla.Size = new System.Drawing.Size(63, 20);
            this.rbFazla.TabIndex = 105;
            this.rbFazla.Text = "Fazla";
            this.rbFazla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_KeyPress);
            this.rbFazla.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lblMatnr
            // 
            this.lblMatnr.Location = new System.Drawing.Point(283, 4);
            this.lblMatnr.Name = "lblMatnr";
            this.lblMatnr.Size = new System.Drawing.Size(32, 20);
            this.lblMatnr.Visible = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(240, 244);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(78, 25);
            this.btn_Kaydet.TabIndex = 69;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.BackgroundImage")));
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(160, 244);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.PressedImage")));
            this.btn_iptal.Size = new System.Drawing.Size(76, 25);
            this.btn_iptal.TabIndex = 67;
            this.btn_iptal.Text = "     Vazgeç";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(82, 244);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.PressedImage")));
            this.btn_Sil.Size = new System.Drawing.Size(76, 25);
            this.btn_Sil.TabIndex = 66;
            this.btn_Sil.Text = "   Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(4, 244);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(76, 25);
            this.btn_Ekle.TabIndex = 65;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Ýþlem";
            this.dataGridTextBoxColumn4.MappingName = "rB";
            this.dataGridTextBoxColumn4.Width = 60;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridTextBoxColumn3.MappingName = "Miktar";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Açýklama";
            this.dataGridTextBoxColumn2.MappingName = "Aciklama";
            this.dataGridTextBoxColumn2.Width = 100;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malzeme ";
            this.dataGridTextBoxColumn1.MappingName = "Matnr";
            this.dataGridTextBoxColumn1.Width = 70;
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // frm_SarfFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.lblMatnr);
            this.Controls.Add(this.rbFazla);
            this.Controls.Add(this.rbKayip);
            this.Controls.Add(this.rbAnhTesMasraf);
            this.Controls.Add(this.rbSarfFireKayip);
            this.Controls.Add(this.rbMasraf);
            this.Controls.Add(this.rbSarfFire);
            this.Controls.Add(this.txtAdt);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepoYeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.grd_SarfFire);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SarfFire";
            this.Text = "Sarf Fire İşlemleri";
            this.Load += new System.EventHandler(this.frm_Etiket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Kaydet;
        private PictureButton btn_iptal;
        private PictureButton btn_Sil;
        private System.Windows.Forms.DataGrid grd_SarfFire;
        private PictureButton btn_Ekle;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepoYeri;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdt;
        private System.Windows.Forms.RadioButton rbSarfFire;
        private System.Windows.Forms.RadioButton rbMasraf;
        private System.Windows.Forms.RadioButton rbSarfFireKayip;
        private System.Windows.Forms.RadioButton rbAnhTesMasraf;
        private System.Windows.Forms.RadioButton rbKayip;
        private System.Windows.Forms.RadioButton rbFazla;
        private System.Windows.Forms.Label lblMatnr;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;

    }
}