namespace KoctasMobil
{
    partial class frm_AcikSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AcikSiparis));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd_sip = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_matnr = new System.Windows.Forms.TextBox();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_getir = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(156, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Barkod :";
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
            this.txt_maktx.Location = new System.Drawing.Point(68, 28);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(251, 22);
            this.txt_maktx.TabIndex = 3;
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
            // grd_sip
            // 
            this.grd_sip.BackColor = System.Drawing.Color.White;
            this.grd_sip.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_sip.Location = new System.Drawing.Point(2, 83);
            this.grd_sip.Name = "grd_sip";
            this.grd_sip.RowHeadersVisible = false;
            this.grd_sip.Size = new System.Drawing.Size(315, 181);
            this.grd_sip.TabIndex = 30;
            this.grd_sip.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Belge";
            this.dataGridTextBoxColumn6.MappingName = "ebeln";
            this.dataGridTextBoxColumn6.Width = 88;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Tarih";
            this.dataGridTextBoxColumn7.MappingName = "bedat";
            this.dataGridTextBoxColumn7.Width = 66;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "Miktar";
            this.dataGridTextBoxColumn9.MappingName = "menge";
            this.dataGridTextBoxColumn9.Width = 66;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "TÖB";
            this.dataGridTextBoxColumn8.MappingName = "meins";
            this.dataGridTextBoxColumn8.Width = 44;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "AR";
            this.dataGridTextBoxColumn1.MappingName = "ear";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // txt_matnr
            // 
            this.txt_matnr.Location = new System.Drawing.Point(68, 2);
            this.txt_matnr.Name = "txt_matnr";
            this.txt_matnr.Size = new System.Drawing.Size(88, 23);
            this.txt_matnr.TabIndex = 2;
            this.txt_matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matnr_KeyPress);
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.Location = new System.Drawing.Point(207, 2);
            this.txt_Barkod.MaxLength = 18;
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(112, 23);
            this.txt_Barkod.TabIndex = 1;
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barkod_KeyPress);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(242, 54);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(76, 25);
            this.btn_Geri.TabIndex = 5;
            this.btn_Geri.Text = "  Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.Color.Tomato;
            this.btn_getir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_getir.BackgroundImage")));
            this.btn_getir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_getir.ForeColor = System.Drawing.Color.White;
            this.btn_getir.Location = new System.Drawing.Point(4, 54);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_getir.PressedImage")));
            this.btn_getir.Size = new System.Drawing.Size(76, 25);
            this.btn_getir.TabIndex = 4;
            this.btn_getir.Text = "   Göster";
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // frm_AcikSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.txt_matnr);
            this.Controls.Add(this.grd_sip);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AcikSiparis";
            this.Text = "Açık Siparişler";
            this.Load += new System.EventHandler(this.frm_UrunKontrol3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGrid grd_sip;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.TextBox txt_matnr;
        private System.Windows.Forms.TextBox txt_Barkod;
        private PictureButton btn_Geri;
        private PictureButton btn_getir;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
    }
}