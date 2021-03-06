namespace KoctasMobil
{
    partial class frm_UrunTutanak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UrunTutanak));
            this.txt_Tedarikci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SipNo = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.dtp_IrsTar = new System.Windows.Forms.DateTimePicker();
            this.txt_IrsNo = new System.Windows.Forms.TextBox();
            this.btn_Iptal = new KoctasMobil.PictureButton();
            this.btn_Yazdir = new KoctasMobil.PictureButton();
            this.btn_imzalar = new KoctasMobil.PictureButton();
            this.btn_malzemeler = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txt_Tedarikci
            // 
            this.txt_Tedarikci.ForeColor = System.Drawing.Color.Black;
            this.txt_Tedarikci.Location = new System.Drawing.Point(102, 6);
            this.txt_Tedarikci.MaxLength = 10;
            this.txt_Tedarikci.Name = "txt_Tedarikci";
            this.txt_Tedarikci.Size = new System.Drawing.Size(213, 23);
            this.txt_Tedarikci.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.Text = "Tedarikçi :";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.Text = "İrsaliye Trh/No :";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.Text = "Siparis No :";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.Text = "Açıklama :";
            // 
            // txt_SipNo
            // 
            this.txt_SipNo.ForeColor = System.Drawing.Color.Black;
            this.txt_SipNo.Location = new System.Drawing.Point(102, 57);
            this.txt_SipNo.MaxLength = 10;
            this.txt_SipNo.Name = "txt_SipNo";
            this.txt_SipNo.Size = new System.Drawing.Size(213, 23);
            this.txt_SipNo.TabIndex = 4;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.ForeColor = System.Drawing.Color.Black;
            this.txt_Aciklama.Location = new System.Drawing.Point(102, 81);
            this.txt_Aciklama.MaxLength = 255;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(213, 75);
            this.txt_Aciklama.TabIndex = 5;
            // 
            // dtp_IrsTar
            // 
            this.dtp_IrsTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_IrsTar.Location = new System.Drawing.Point(102, 31);
            this.dtp_IrsTar.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtp_IrsTar.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.dtp_IrsTar.Name = "dtp_IrsTar";
            this.dtp_IrsTar.Size = new System.Drawing.Size(101, 24);
            this.dtp_IrsTar.TabIndex = 2;
            // 
            // txt_IrsNo
            // 
            this.txt_IrsNo.ForeColor = System.Drawing.Color.Black;
            this.txt_IrsNo.Location = new System.Drawing.Point(204, 31);
            this.txt_IrsNo.MaxLength = 16;
            this.txt_IrsNo.Name = "txt_IrsNo";
            this.txt_IrsNo.Size = new System.Drawing.Size(111, 23);
            this.txt_IrsNo.TabIndex = 3;
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_Iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.BackgroundImage")));
            this.btn_Iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Iptal.ForeColor = System.Drawing.Color.White;
            this.btn_Iptal.Location = new System.Drawing.Point(3, 211);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.PressedImage")));
            this.btn_Iptal.Size = new System.Drawing.Size(145, 48);
            this.btn_Iptal.TabIndex = 13;
            this.btn_Iptal.Text = "      İptal";
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Yazdir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Yazdir.BackgroundImage")));
            this.btn_Yazdir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Yazdir.ForeColor = System.Drawing.Color.White;
            this.btn_Yazdir.Location = new System.Drawing.Point(170, 211);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Yazdir.PressedImage")));
            this.btn_Yazdir.Size = new System.Drawing.Size(145, 48);
            this.btn_Yazdir.TabIndex = 14;
            this.btn_Yazdir.Text = "         Tamam";
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // btn_imzalar
            // 
            this.btn_imzalar.BackColor = System.Drawing.Color.Tomato;
            this.btn_imzalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imzalar.BackgroundImage")));
            this.btn_imzalar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_imzalar.ForeColor = System.Drawing.Color.White;
            this.btn_imzalar.Location = new System.Drawing.Point(170, 162);
            this.btn_imzalar.Name = "btn_imzalar";
            this.btn_imzalar.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_imzalar.PressedImage")));
            this.btn_imzalar.Size = new System.Drawing.Size(145, 48);
            this.btn_imzalar.TabIndex = 12;
            this.btn_imzalar.Text = "         İmzalar";
            this.btn_imzalar.Click += new System.EventHandler(this.btn_imzalar_Click);
            // 
            // btn_malzemeler
            // 
            this.btn_malzemeler.BackColor = System.Drawing.Color.Tomato;
            this.btn_malzemeler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_malzemeler.BackgroundImage")));
            this.btn_malzemeler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_malzemeler.ForeColor = System.Drawing.Color.White;
            this.btn_malzemeler.Location = new System.Drawing.Point(3, 162);
            this.btn_malzemeler.Name = "btn_malzemeler";
            this.btn_malzemeler.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_malzemeler.PressedImage")));
            this.btn_malzemeler.Size = new System.Drawing.Size(145, 48);
            this.btn_malzemeler.TabIndex = 11;
            this.btn_malzemeler.Text = "         Malzemeler";
            this.btn_malzemeler.Click += new System.EventHandler(this.btn_malzemeler_Click);
            // 
            // frm_UrunTutanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.txt_IrsNo);
            this.Controls.Add(this.btn_imzalar);
            this.Controls.Add(this.btn_malzemeler);
            this.Controls.Add(this.dtp_IrsTar);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.txt_SipNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Tedarikci);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UrunTutanak";
            this.Text = "Eksik/Fazla/Arızalı Ürün Tutanağı";
            this.Load += new System.EventHandler(this.frm_UrunTutanak_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Tedarikci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SipNo;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.DateTimePicker dtp_IrsTar;
        private PictureButton btn_malzemeler;
        private PictureButton btn_imzalar;
        private System.Windows.Forms.TextBox txt_IrsNo;
        private PictureButton btn_Yazdir;
        private PictureButton btn_Iptal;
    }
}