namespace KoctasMobil
{
    partial class frm_SarfFireDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SarfFireDegistir));
            this.txt_FormNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_SarfFire = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtAdt = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Degistir = new KoctasMobil.PictureButton();
            this.btn_Iptal = new KoctasMobil.PictureButton();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_Getir = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txt_FormNo
            // 
            this.txt_FormNo.BackColor = System.Drawing.Color.White;
            this.txt_FormNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txt_FormNo.ForeColor = System.Drawing.Color.Black;
            this.txt_FormNo.Location = new System.Drawing.Point(73, 3);
            this.txt_FormNo.MaxLength = 18;
            this.txt_FormNo.Name = "txt_FormNo";
            this.txt_FormNo.Size = new System.Drawing.Size(142, 20);
            this.txt_FormNo.TabIndex = 63;
            this.txt_FormNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FormNo_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.Text = "Form no :";
            // 
            // grd_SarfFire
            // 
            this.grd_SarfFire.BackColor = System.Drawing.Color.White;
            this.grd_SarfFire.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_SarfFire.Location = new System.Drawing.Point(1, 27);
            this.grd_SarfFire.Name = "grd_SarfFire";
            this.grd_SarfFire.Size = new System.Drawing.Size(315, 160);
            this.grd_SarfFire.TabIndex = 66;
            this.grd_SarfFire.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_SarfFire.Click += new System.EventHandler(this.grd_SarfFire_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malzeme";
            this.dataGridTextBoxColumn1.MappingName = "Matnr";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 80;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Depo";
            this.dataGridTextBoxColumn2.MappingName = "Lgort";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 40;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Açýklama";
            this.dataGridTextBoxColumn3.MappingName = "Aciklama";
            this.dataGridTextBoxColumn3.Width = 105;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Miktar";
            this.dataGridTextBoxColumn4.MappingName = "Menge";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Birim";
            this.dataGridTextBoxColumn5.MappingName = "Meins";
            this.dataGridTextBoxColumn5.Width = 0;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Sarf";
            this.dataGridTextBoxColumn6.MappingName = "Sarf";
            this.dataGridTextBoxColumn6.Width = 0;
            // 
            // txtAdt
            // 
            this.txtAdt.BackColor = System.Drawing.Color.Tomato;
            this.txtAdt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdt.ForeColor = System.Drawing.Color.White;
            this.txtAdt.Location = new System.Drawing.Point(135, 212);
            this.txtAdt.MaxLength = 18;
            this.txtAdt.Name = "txtAdt";
            this.txtAdt.Size = new System.Drawing.Size(36, 22);
            this.txtAdt.TabIndex = 98;
            this.txtAdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdt_KeyPress);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtMiktar.Location = new System.Drawing.Point(73, 213);
            this.txtMiktar.MaxLength = 18;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(61, 20);
            this.txtMiktar.TabIndex = 97;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtAciklama.ForeColor = System.Drawing.Color.Black;
            this.txtAciklama.Location = new System.Drawing.Point(73, 190);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(242, 20);
            this.txtAciklama.TabIndex = 96;
            this.txtAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAciklama_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.Text = "Miktar :";
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Degistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Degistir.BackgroundImage")));
            this.btn_Degistir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Degistir.ForeColor = System.Drawing.Color.White;
            this.btn_Degistir.Location = new System.Drawing.Point(225, 213);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Degistir.PressedImage")));
            this.btn_Degistir.Size = new System.Drawing.Size(90, 26);
            this.btn_Degistir.TabIndex = 107;
            this.btn_Degistir.Text = "   Değiştir";
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_Iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.BackgroundImage")));
            this.btn_Iptal.ForeColor = System.Drawing.Color.White;
            this.btn_Iptal.Location = new System.Drawing.Point(3, 240);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.PressedImage")));
            this.btn_Iptal.Size = new System.Drawing.Size(99, 26);
            this.btn_Iptal.TabIndex = 106;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click_1);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(225, 240);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(90, 26);
            this.btn_Kaydet.TabIndex = 102;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Getir
            // 
            this.btn_Getir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Getir.BackgroundImage = null;
            this.btn_Getir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Getir.ForeColor = System.Drawing.Color.White;
            this.btn_Getir.Location = new System.Drawing.Point(224, 3);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(90, 21);
            this.btn_Getir.TabIndex = 65;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // frm_SarfFireDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.btn_Degistir);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdt);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grd_SarfFire);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.txt_FormNo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SarfFireDegistir";
            this.Text = "Sarf Fire Değişiklik";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FormNo;
        private System.Windows.Forms.Label label1;
        private PictureButton btn_Getir;
        private System.Windows.Forms.DataGrid grd_SarfFire;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TextBox txtAdt;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PictureButton btn_Kaydet;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private PictureButton btn_Iptal;
        private PictureButton btn_Degistir;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;

    }
}

