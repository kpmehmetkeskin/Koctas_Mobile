namespace KoctasMobil
{
    partial class frm_malgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_malgiris));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt_sas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Siparis = new System.Windows.Forms.ListBox();
            this.dtp_belge = new System.Windows.Forms.DateTimePicker();
            this.dtp_kayit = new System.Windows.Forms.DateTimePicker();
            this.cmb_IrsNo = new System.Windows.Forms.ComboBox();
            this.pictureButton1 = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_siparis = new KoctasMobil.PictureButton();
            this.btn_SiparisEkle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.Text = "Kayıt Tarihi    :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "Belge Tarihi   :";
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(4, 6);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(132, 20);
            this.lbl3.Text = "İrsaliye no     :";
            // 
            // txt_sas
            // 
            this.txt_sas.Enabled = false;
            this.txt_sas.Location = new System.Drawing.Point(91, 84);
            this.txt_sas.MaxLength = 40;
            this.txt_sas.Name = "txt_sas";
            this.txt_sas.Size = new System.Drawing.Size(130, 23);
            this.txt_sas.TabIndex = 125;
            this.txt_sas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sas_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.Text = "Sipariş           :";
            // 
            // lst_Siparis
            // 
            this.lst_Siparis.Location = new System.Drawing.Point(91, 112);
            this.lst_Siparis.Name = "lst_Siparis";
            this.lst_Siparis.Size = new System.Drawing.Size(224, 114);
            this.lst_Siparis.TabIndex = 128;
            // 
            // dtp_belge
            // 
            this.dtp_belge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_belge.Location = new System.Drawing.Point(93, 29);
            this.dtp_belge.Name = "dtp_belge";
            this.dtp_belge.Size = new System.Drawing.Size(222, 24);
            this.dtp_belge.TabIndex = 133;
            this.dtp_belge.ValueChanged += new System.EventHandler(this.dtp_belge_ValueChanged);
            // 
            // dtp_kayit
            // 
            this.dtp_kayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kayit.Location = new System.Drawing.Point(93, 55);
            this.dtp_kayit.Name = "dtp_kayit";
            this.dtp_kayit.Size = new System.Drawing.Size(222, 24);
            this.dtp_kayit.TabIndex = 134;
            this.dtp_kayit.ValueChanged += new System.EventHandler(this.dtp_kayit_ValueChanged);
            // 
            // cmb_IrsNo
            // 
            this.cmb_IrsNo.Location = new System.Drawing.Point(93, 3);
            this.cmb_IrsNo.Name = "cmb_IrsNo";
            this.cmb_IrsNo.Size = new System.Drawing.Size(162, 23);
            this.cmb_IrsNo.TabIndex = 166;
            this.cmb_IrsNo.SelectedIndexChanged += new System.EventHandler(this.cmb_IrsNo_SelectedIndexChanged);
            // 
            // pictureButton1
            // 
            this.pictureButton1.BackColor = System.Drawing.Color.Tomato;
            this.pictureButton1.BackgroundImage = null;
            this.pictureButton1.ForeColor = System.Drawing.Color.White;
            this.pictureButton1.Location = new System.Drawing.Point(261, 3);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.Size = new System.Drawing.Size(54, 23);
            this.pictureButton1.TabIndex = 160;
            this.pictureButton1.Text = "Ekle";
            this.pictureButton1.Click += new System.EventHandler(this.pictureButton1_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(216, 235);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 141;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_siparis
            // 
            this.btn_siparis.BackColor = System.Drawing.Color.Tomato;
            this.btn_siparis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.BackgroundImage")));
            this.btn_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_siparis.Location = new System.Drawing.Point(3, 235);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.PressedImage")));
            this.btn_siparis.Size = new System.Drawing.Size(178, 48);
            this.btn_siparis.TabIndex = 140;
            this.btn_siparis.Text = "   Malzeme Giriş";
            this.btn_siparis.Click += new System.EventHandler(this.btn_Siparis_Click);
            // 
            // btn_SiparisEkle
            // 
            this.btn_SiparisEkle.BackColor = System.Drawing.Color.Tomato;
            this.btn_SiparisEkle.BackgroundImage = null;
            this.btn_SiparisEkle.Enabled = false;
            this.btn_SiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btn_SiparisEkle.Location = new System.Drawing.Point(224, 83);
            this.btn_SiparisEkle.Name = "btn_SiparisEkle";
            this.btn_SiparisEkle.PressedImage = null;
            this.btn_SiparisEkle.Size = new System.Drawing.Size(91, 24);
            this.btn_SiparisEkle.TabIndex = 139;
            this.btn_SiparisEkle.Text = "  Ekle";
            this.btn_SiparisEkle.Click += new System.EventHandler(this.btn_SiparisEkle_Click);
            // 
            // frm_malgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_IrsNo);
            this.Controls.Add(this.pictureButton1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.btn_SiparisEkle);
            this.Controls.Add(this.dtp_kayit);
            this.Controls.Add(this.dtp_belge);
            this.Controls.Add(this.lst_Siparis);
            this.Controls.Add(this.txt_sas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_malgiris";
            this.Text = "Belge Başlık Bilgileri";
            this.Load += new System.EventHandler(this.FIT_GoodsIssue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt_sas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Siparis;
        private System.Windows.Forms.DateTimePicker dtp_belge;
        private System.Windows.Forms.DateTimePicker dtp_kayit;
        private PictureButton btn_SiparisEkle;
        private PictureButton btn_siparis;
        private PictureButton btn_Geri;
        private PictureButton pictureButton1;
        private System.Windows.Forms.ComboBox cmb_IrsNo;
    }
}