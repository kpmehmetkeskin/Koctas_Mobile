namespace KoctasMobil
{
    partial class frm_GapRaf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GapRaf));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRafAdresi = new System.Windows.Forms.TextBox();
            this.btn_Vazgec = new KoctasMobil.PictureButton();
            this.btn_Malzeme = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.Text = "Raf Adresi :";
            // 
            // txtRafAdresi
            // 
            this.txtRafAdresi.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.txtRafAdresi.ForeColor = System.Drawing.Color.Black;
            this.txtRafAdresi.Location = new System.Drawing.Point(148, 76);
            this.txtRafAdresi.MaxLength = 8;
            this.txtRafAdresi.Name = "txtRafAdresi";
            this.txtRafAdresi.Size = new System.Drawing.Size(147, 31);
            this.txtRafAdresi.TabIndex = 1;
            this.txtRafAdresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRafAdresi_KeyPress);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.BackColor = System.Drawing.Color.Tomato;
            this.btn_Vazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.BackgroundImage")));
            this.btn_Vazgec.ForeColor = System.Drawing.Color.White;
            this.btn_Vazgec.Location = new System.Drawing.Point(21, 128);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.PressedImage")));
            this.btn_Vazgec.Size = new System.Drawing.Size(135, 54);
            this.btn_Vazgec.TabIndex = 6;
            this.btn_Vazgec.Text = "     Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.bntVazgec_Click);
            // 
            // btn_Malzeme
            // 
            this.btn_Malzeme.BackColor = System.Drawing.Color.Tomato;
            this.btn_Malzeme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Malzeme.BackgroundImage")));
            this.btn_Malzeme.ForeColor = System.Drawing.Color.White;
            this.btn_Malzeme.Location = new System.Drawing.Point(162, 128);
            this.btn_Malzeme.Name = "btn_Malzeme";
            this.btn_Malzeme.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Malzeme.PressedImage")));
            this.btn_Malzeme.Size = new System.Drawing.Size(135, 54);
            this.btn_Malzeme.TabIndex = 5;
            this.btn_Malzeme.Text = "         Malzeme Girişi";
            this.btn_Malzeme.Click += new System.EventHandler(this.btn_Sayim_Click);
            // 
            // frm_GapRaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Malzeme);
            this.Controls.Add(this.txtRafAdresi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_GapRaf";
            this.Text = "Raf Adresi";
            this.Load += new System.EventHandler(this.frm_SayimRaf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRafAdresi;
        private PictureButton btn_Malzeme;
        private PictureButton btn_Vazgec;
    }
}