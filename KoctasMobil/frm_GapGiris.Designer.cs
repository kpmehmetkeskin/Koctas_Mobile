namespace KoctasMobil
{
    partial class frm_GapGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GapGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.txt_matnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_GAP = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_Temizle = new KoctasMobil.PictureButton();
            this.btn_iptal = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(159, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.Text = "Barkod :";
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.BackColor = System.Drawing.Color.White;
            this.txt_Barkod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_Barkod.ForeColor = System.Drawing.Color.Black;
            this.txt_Barkod.Location = new System.Drawing.Point(210, 3);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(106, 20);
            this.txt_Barkod.TabIndex = 1;
            this.txt_Barkod.TextChanged += new System.EventHandler(this.malzChanged);
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barkod_KeyPress);
            // 
            // txt_matnr
            // 
            this.txt_matnr.BackColor = System.Drawing.Color.White;
            this.txt_matnr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_matnr.ForeColor = System.Drawing.Color.Black;
            this.txt_matnr.Location = new System.Drawing.Point(73, 3);
            this.txt_matnr.Name = "txt_matnr";
            this.txt_matnr.Size = new System.Drawing.Size(85, 20);
            this.txt_matnr.TabIndex = 8;
            this.txt_matnr.TextChanged += new System.EventHandler(this.malzChanged);
            this.txt_matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matnr_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.Text = "Ürün Kodu:";
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(73, 28);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(242, 22);
            this.txt_maktx.TabIndex = 13;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı   :";
            // 
            // grd_GAP
            // 
            this.grd_GAP.BackColor = System.Drawing.Color.White;
            this.grd_GAP.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_GAP.ColumnHeadersVisible = false;
            this.grd_GAP.Location = new System.Drawing.Point(2, 78);
            this.grd_GAP.Name = "grd_GAP";
            this.grd_GAP.Size = new System.Drawing.Size(315, 154);
            this.grd_GAP.TabIndex = 30;
            this.grd_GAP.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.MappingName = "ean11";
            this.dataGridTextBoxColumn1.Width = 90;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.MappingName = "matnr";
            this.dataGridTextBoxColumn2.Width = 80;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.MappingName = "maktx";
            this.dataGridTextBoxColumn3.Width = 130;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(217, 233);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(97, 25);
            this.btn_Kaydet.TabIndex = 57;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.BackgroundImage")));
            this.btn_Temizle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(162, 52);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.PressedImage")));
            this.btn_Temizle.Size = new System.Drawing.Size(76, 25);
            this.btn_Temizle.TabIndex = 56;
            this.btn_Temizle.Text = "    Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.BackgroundImage")));
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Location = new System.Drawing.Point(241, 52);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.PressedImage")));
            this.btn_iptal.Size = new System.Drawing.Size(76, 25);
            this.btn_iptal.TabIndex = 55;
            this.btn_iptal.Text = "     Vazgeç";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(83, 52);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.PressedImage")));
            this.btn_Sil.Size = new System.Drawing.Size(76, 25);
            this.btn_Sil.TabIndex = 54;
            this.btn_Sil.Text = "   Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(3, 52);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(76, 25);
            this.btn_Ekle.TabIndex = 53;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // frm_GapGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.grd_GAP);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.txt_matnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_GapGiris";
            this.Text = "GAP Girişi";
            this.Load += new System.EventHandler(this.frm_UrunKontrol3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.TextBox txt_matnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGrid grd_GAP;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private PictureButton btn_Temizle;
        private PictureButton btn_iptal;
        private PictureButton btn_Sil;
        private PictureButton btn_Ekle;
        private PictureButton btn_Kaydet;
    }
}