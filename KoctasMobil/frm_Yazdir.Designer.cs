namespace KoctasMobil
{
    partial class frm_Yazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Yazdir));
            this.lv_siparis = new System.Windows.Forms.ListView();
            this.clm_siparis = new System.Windows.Forms.ColumnHeader();
            this.clm_saat = new System.Windows.Forms.ColumnHeader();
            this.btn_Iptal = new KoctasMobil.PictureButton();
            this.btn_Yazdir = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // lv_siparis
            // 
            this.lv_siparis.CheckBoxes = true;
            this.lv_siparis.Columns.Add(this.clm_siparis);
            this.lv_siparis.Columns.Add(this.clm_saat);
            this.lv_siparis.Location = new System.Drawing.Point(0, 0);
            this.lv_siparis.Name = "lv_siparis";
            this.lv_siparis.Size = new System.Drawing.Size(318, 196);
            this.lv_siparis.TabIndex = 3;
            this.lv_siparis.View = System.Windows.Forms.View.Details;
            // 
            // clm_siparis
            // 
            this.clm_siparis.Text = "Sipariş No";
            this.clm_siparis.Width = 99;
            // 
            // clm_saat
            // 
            this.clm_saat.Text = "Saat";
            this.clm_saat.Width = 77;
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_Iptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.BackgroundImage")));
            this.btn_Iptal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Iptal.ForeColor = System.Drawing.Color.White;
            this.btn_Iptal.Location = new System.Drawing.Point(166, 197);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Iptal.PressedImage")));
            this.btn_Iptal.Size = new System.Drawing.Size(150, 48);
            this.btn_Iptal.TabIndex = 2;
            this.btn_Iptal.Text = "     İptal";
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Yazdir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Yazdir.BackgroundImage")));
            this.btn_Yazdir.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Yazdir.ForeColor = System.Drawing.Color.White;
            this.btn_Yazdir.Location = new System.Drawing.Point(3, 197);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Yazdir.PressedImage")));
            this.btn_Yazdir.Size = new System.Drawing.Size(150, 48);
            this.btn_Yazdir.TabIndex = 1;
            this.btn_Yazdir.Text = "     Yazdır";
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // frm_Yazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.lv_siparis);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Yazdir);
            this.ForeColor = System.Drawing.Color.Tomato;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Yazdir";
            this.Text = "Sipariş Yazdır";
            this.Load += new System.EventHandler(this.frm_Yazdir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Yazdir;
        private PictureButton btn_Iptal;
        private System.Windows.Forms.ListView lv_siparis;
        private System.Windows.Forms.ColumnHeader clm_siparis;
        private System.Windows.Forms.ColumnHeader clm_saat;
    }
}