namespace KoctasMobil
{
    partial class frm_Etiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Etiket));
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.grd_Etiket = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoyut = new System.Windows.Forms.ComboBox();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_Temizle = new KoctasMobil.PictureButton();
            this.btn_iptal = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.MappingName = "Adet";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.MappingName = "Adres";
            this.dataGridTextBoxColumn3.Width = 100;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.MappingName = "Barkod";
            this.dataGridTextBoxColumn1.Width = 90;
            // 
            // grd_Etiket
            // 
            this.grd_Etiket.BackColor = System.Drawing.Color.White;
            this.grd_Etiket.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Etiket.ColumnHeadersVisible = false;
            this.grd_Etiket.Location = new System.Drawing.Point(3, 132);
            this.grd_Etiket.Name = "grd_Etiket";
            this.grd_Etiket.Size = new System.Drawing.Size(315, 111);
            this.grd_Etiket.TabIndex = 64;
            this.grd_Etiket.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.MappingName = "Boyut";
            this.dataGridTextBoxColumn4.Width = 30;
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
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.Text = "Barkod :";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı   :";
            // 
            // txtAdet
            // 
            this.txtAdet.BackColor = System.Drawing.Color.White;
            this.txtAdet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtAdet.ForeColor = System.Drawing.Color.Black;
            this.txtAdet.Location = new System.Drawing.Point(74, 51);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(85, 20);
            this.txtAdet.TabIndex = 76;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.Text = "Adet :";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.White;
            this.txtAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.Location = new System.Drawing.Point(211, 52);
            this.txtAdres.MaxLength = 18;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(106, 20);
            this.txtAdres.TabIndex = 75;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(160, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.Text = "Büyüt :";
            // 
            // cmbBoyut
            // 
            this.cmbBoyut.Items.Add("1");
            this.cmbBoyut.Items.Add("2");
            this.cmbBoyut.Items.Add("3");
            this.cmbBoyut.Items.Add("4");
            this.cmbBoyut.Location = new System.Drawing.Point(74, 74);
            this.cmbBoyut.Name = "cmbBoyut";
            this.cmbBoyut.Size = new System.Drawing.Size(42, 23);
            this.cmbBoyut.TabIndex = 84;
            this.cmbBoyut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoyut_KeyPress);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(221, 244);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(97, 25);
            this.btn_Kaydet.TabIndex = 69;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.BackgroundImage")));
            this.btn_Temizle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(163, 102);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.PressedImage")));
            this.btn_Temizle.Size = new System.Drawing.Size(76, 25);
            this.btn_Temizle.TabIndex = 68;
            this.btn_Temizle.Text = "    Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.BackgroundImage")));
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(242, 102);
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
            this.btn_Sil.Location = new System.Drawing.Point(84, 102);
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
            this.btn_Ekle.Location = new System.Drawing.Point(4, 102);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(76, 25);
            this.btn_Ekle.TabIndex = 65;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // frm_Etiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.cmbBoyut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.grd_Etiket);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Etiket";
            this.Text = "Etiket Basımı";
            this.Load += new System.EventHandler(this.frm_Etiket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private PictureButton btn_Kaydet;
        private PictureButton btn_Temizle;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private PictureButton btn_iptal;
        private PictureButton btn_Sil;
        private System.Windows.Forms.DataGrid grd_Etiket;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private PictureButton btn_Ekle;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoyut;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;

    }
}