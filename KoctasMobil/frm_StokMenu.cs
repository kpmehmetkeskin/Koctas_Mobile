using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_StokMenu : Form
    {
        public frm_StokMenu()
        {
            InitializeComponent();
        }

        private void btn_MalGirisi_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Depo mal giriş işlemi yapmak istiyorsanız EVET (Yes) seçimi ile devam edin. Aksi taktirde HAYIR (No) seçerek mal girişi yapabilirsiniz.", "BİLGİ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                frm_malgiris frm = new frm_malgiris();
                frm.ShowDialog();
            }
            else if (result == DialogResult.Yes)
            {
                frm_malgirisDepo frm = new frm_malgirisDepo();
                frm.ShowDialog();
            }
        }

        private void frm_StokMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iade_Click(object sender, EventArgs e)
        {
            frm_StokIadeMenu frm = new frm_StokIadeMenu();
            frm.ShowDialog();
        }

        private void btn_SarfFire_Click(object sender, EventArgs e)
        {
            frm_SarfFire frm = new frm_SarfFire();
            frm.ShowDialog();
        }

        private void bnt_SarfFireDegistir_Click(object sender, EventArgs e)
        {
            frm_SarfFireDegistir frm = new frm_SarfFireDegistir();
            frm.ShowDialog();
        }


        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            frm_Transfer frm = new frm_Transfer();
            frm.ShowDialog();
        }

        private void btn_tutanak_Click(object sender, EventArgs e)
        {
            new frm_UrunTutanak().ShowDialog();
        }

        private void btn_Paketleme_Click(object sender, EventArgs e)
        {
            frm_PaketlemeMenu frm = new frm_PaketlemeMenu();
            frm.ShowDialog();
        }

        private void btn_TeslimatHazirlama_Click(object sender, EventArgs e)
        {

            
            //if ((ProgramGlobalData.loginWerks == "1001") || (ProgramGlobalData.loginWerks == "2040") || (ProgramGlobalData.loginWerks == "2022"))
            if (ProgramGlobalData.loginMagnet == "X")
            {

                frm_UrunTeslimat_2 frm = new frm_UrunTeslimat_2();
                frm.ShowDialog();
            }
            else
            {
                frm_UrunTeslimat frm = new frm_UrunTeslimat();
                frm.ShowDialog();
            }
        }

        private void btn_FixMalGirisi_Click(object sender, EventArgs e)
        {
            FixProductList form = new FixProductList();
            form.ShowDialog();
        }
    }
}