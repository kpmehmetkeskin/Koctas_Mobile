namespace KoctasMobil
{
    partial class frm_SayimMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SayimMenu));
            this.btn_cikis = new KoctasMobil.PictureButton();
            this.btn_SayimGirisi = new KoctasMobil.PictureButton();
            this.btn_EkSayimGirisi = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Tomato;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(44, 226);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.PressedImage")));
            this.btn_cikis.Size = new System.Drawing.Size(230, 39);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "Geri";
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_SayimGirisi
            // 
            this.btn_SayimGirisi.BackColor = System.Drawing.Color.Tomato;
            this.btn_SayimGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SayimGirisi.BackgroundImage")));
            this.btn_SayimGirisi.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_SayimGirisi.ForeColor = System.Drawing.Color.White;
            this.btn_SayimGirisi.Location = new System.Drawing.Point(44, 29);
            this.btn_SayimGirisi.Name = "btn_SayimGirisi";
            this.btn_SayimGirisi.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_SayimGirisi.PressedImage")));
            this.btn_SayimGirisi.Size = new System.Drawing.Size(230, 48);
            this.btn_SayimGirisi.TabIndex = 10;
            this.btn_SayimGirisi.Text = "Sayım Girişi";
            this.btn_SayimGirisi.Click += new System.EventHandler(this.btn_SayimGirisi_Click);
            // 
            // btn_EkSayimGirisi
            // 
            this.btn_EkSayimGirisi.BackColor = System.Drawing.Color.Tomato;
            this.btn_EkSayimGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EkSayimGirisi.BackgroundImage")));
            this.btn_EkSayimGirisi.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_EkSayimGirisi.ForeColor = System.Drawing.Color.White;
            this.btn_EkSayimGirisi.Location = new System.Drawing.Point(44, 83);
            this.btn_EkSayimGirisi.Name = "btn_EkSayimGirisi";
            this.btn_EkSayimGirisi.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_EkSayimGirisi.PressedImage")));
            this.btn_EkSayimGirisi.Size = new System.Drawing.Size(230, 48);
            this.btn_EkSayimGirisi.TabIndex = 12;
            this.btn_EkSayimGirisi.Text = "Ek Sayım Girişi";
            this.btn_EkSayimGirisi.Click += new System.EventHandler(this.btn_EkSayimGirisi_Click);
            // 
            // frm_SayimMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_EkSayimGirisi);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_SayimGirisi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SayimMenu";
            this.Text = "Sayım";
            this.Load += new System.EventHandler(this.frm_SayimMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_cikis;
        private PictureButton btn_SayimGirisi;
        private PictureButton btn_EkSayimGirisi;
    }
}