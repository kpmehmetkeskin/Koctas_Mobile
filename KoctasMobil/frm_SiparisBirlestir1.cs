using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SiparisBirlestir1 : Form
    {
        public frm_SiparisBirlestir1()
        {
            InitializeComponent();
            dt_sip = new DataTable();
            dt_sip.Columns.Add("SIPARISNO");
        }
        DataTable dt_sip;
        private void txt_siparisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_ekle_Click(txt_siparisNo, new EventArgs());
            }
        }
        WS_Satis.ZktmobilSItemslist[] list_all = new KoctasMobil.WS_Satis.ZktmobilSItemslist[255];
        int listlenght = 0;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
            WS_Satis.ZktmobilItemsGet items = new KoctasMobil.WS_Satis.ZktmobilItemsGet();
            WS_Satis.ZktmobilItemsGetResponse itemsresponse = new KoctasMobil.WS_Satis.ZktmobilItemsGetResponse();
            WS_Satis.ZktmobilSItemslist[] list = new KoctasMobil.WS_Satis.ZktmobilSItemslist[1];
            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                items.IVbeln = txt_siparisNo.Text.Trim();
                items.TiKalemler = list;
                itemsresponse = SRV.ZktmobilItemsGet(items);
                if (itemsresponse.TiKalemler.Length == 0)
                {
                    MessageBox.Show("Siparişin kalemleri bulunamadı, girdiğiniz sipariş numarasını kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                grd_Siparisler.DataSource = null;
                DataRow row = dt_sip.NewRow();
                row["SIPARISNO"] = txt_siparisNo.Text.Trim();
                dt_sip.Rows.Add(row);
                grd_Siparisler.DataSource = dt_sip;
                itemsresponse.TiKalemler.CopyTo(list_all, listlenght);
                listlenght += itemsresponse.TiKalemler.Length;
                txt_siparisNo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SiparisBirlestir_Click(object sender, EventArgs e)
        {
             WS_Satis.ZktmobilSItemslist[] itemslist;
            try
            {
                itemslist = new KoctasMobil.WS_Satis.ZktmobilSItemslist[listlenght];
                for (int i = 0; i < listlenght; i++)
                {
                    itemslist[i] = list_all[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            frm_NormalSiparisYarat frm = new frm_NormalSiparisYarat(itemslist, "",frm_NormalSiparisYarat.Title.birlestir);
            if (rdb_Transferli.Checked) 
            {
                frm.Transferli = "X";
            }
            else if (rdb_Normal.Checked)
            {
                frm.Transferli = "";
            }

            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                grd_Siparisler.DataSource = null;
                dt_sip.Clear();
                grd_Siparisler.DataSource = dt_sip;
            }            
        }

        private void frm_SiparisBirlestir1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}