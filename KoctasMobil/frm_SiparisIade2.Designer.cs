namespace KoctasMobil
{
    partial class frm_SiparisIade2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SiparisIade2));
            this.lst_items = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btn_SatisIade = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.txt_toplamTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_items
            // 
            this.lst_items.CheckBoxes = true;
            this.lst_items.Columns.Add(this.columnHeader1);
            this.lst_items.Columns.Add(this.columnHeader2);
            this.lst_items.Columns.Add(this.columnHeader3);
            this.lst_items.Columns.Add(this.columnHeader4);
            this.lst_items.Columns.Add(this.columnHeader5);
            this.lst_items.Dock = System.Windows.Forms.DockStyle.Top;
            this.lst_items.Location = new System.Drawing.Point(0, 0);
            this.lst_items.Name = "lst_items";
            this.lst_items.Size = new System.Drawing.Size(318, 185);
            this.lst_items.TabIndex = 0;
            this.lst_items.View = System.Windows.Forms.View.Details;
            this.lst_items.SelectedIndexChanged += new System.EventHandler(this.lst_items_SelectedIndexChanged);
            this.lst_items.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lst_items_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Kodu";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İade";
            this.columnHeader3.Width = 48;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Satış";
            this.columnHeader4.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 1;
            // 
            // btn_SatisIade
            // 
            this.btn_SatisIade.BackColor = System.Drawing.Color.Tomato;
            this.btn_SatisIade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SatisIade.BackgroundImage")));
            this.btn_SatisIade.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_SatisIade.ForeColor = System.Drawing.Color.White;
            this.btn_SatisIade.Location = new System.Drawing.Point(160, 219);
            this.btn_SatisIade.Name = "btn_SatisIade";
            this.btn_SatisIade.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_SatisIade.PressedImage")));
            this.btn_SatisIade.Size = new System.Drawing.Size(155, 48);
            this.btn_SatisIade.TabIndex = 17;
            this.btn_SatisIade.Text = "      Satış İade";
            this.btn_SatisIade.Click += new System.EventHandler(this.btn_SatisIade_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(3, 219);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(155, 48);
            this.btn_Geri.TabIndex = 18;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // txt_toplamTutar
            // 
            this.txt_toplamTutar.BackColor = System.Drawing.Color.Tomato;
            this.txt_toplamTutar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_toplamTutar.ForeColor = System.Drawing.Color.White;
            this.txt_toplamTutar.Location = new System.Drawing.Point(210, 191);
            this.txt_toplamTutar.Name = "txt_toplamTutar";
            this.txt_toplamTutar.Size = new System.Drawing.Size(105, 22);
            this.txt_toplamTutar.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(130, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.Text = "İade Tutarı :";
            // 
            // frm_SiparisIade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.txt_toplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_SatisIade);
            this.Controls.Add(this.lst_items);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SiparisIade2";
            this.Text = "Sipariş/Satış İade";
            this.Load += new System.EventHandler(this.frm_SiparisIade2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private PictureButton btn_SatisIade;
        private PictureButton btn_Geri;
        private System.Windows.Forms.TextBox txt_toplamTutar;
        private System.Windows.Forms.Label label6;


    }
}