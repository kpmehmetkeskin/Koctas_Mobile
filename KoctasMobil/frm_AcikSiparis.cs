using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_AcikSiparis : Form
    {
        public frm_AcikSiparis()
        {
            InitializeComponent();            
        }

        private void frm_UrunKontrol3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
        }

        private void GeneralKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
               btn_getir_Click(txt_matnr, new EventArgs()); 
            }            
        }


        private void btn_getir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt_sip = new DataTable();
            dt_sip.Columns.Add("ebeln");
            dt_sip.Columns.Add("bedat");
            dt_sip.Columns.Add("menge");
            dt_sip.Columns.Add("meins");
            dt_sip.Columns.Add("ear");

            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilGetOpnPo po = new KoctasMobil.WS_Kontrol.ZktmobilGetOpnPo();
            WS_Kontrol.ZktmobilGetOpnPoResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilGetOpnPoResponse();
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
                if (sender == txt_matnr)
                {
                    po.IMatnr = txt_matnr.Text.Trim();
                }
                else if (sender == txt_Barkod)
                {
                    po.IMatnr = txt_Barkod.Text.Trim();
                }
                else
                {
                    if (!String.IsNullOrEmpty(txt_Barkod.Text))
                    {
                        po.IMatnr = txt_Barkod.Text.Trim();
                    }
                    else if (!String.IsNullOrEmpty(txt_matnr.Text))
                    {
                        po.IMatnr = txt_matnr.Text.Trim();
                    }
                    else
                    {
                        return;
                    }
                }
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;

                mtnr.IMatnr = po.IMatnr;

                matresp = srv.ZktmobilChckMtnr(mtnr);
                if (String.IsNullOrEmpty(matresp.EMaktx.Trim()))
                {
                    dt_sip.Clear();
                    grd_sip.DataSource = dt_sip;
                    txt_maktx.Text = "";
                    return;
                }
                txt_maktx.Text = matresp.EMaktx;
                po.IMatnr = matresp.EMatnr;
                po.ItOpnpo = new KoctasMobil.WS_Kontrol.ZktmobilOpnPo[0];

                resp = srv.ZktmobilGetOpnPo(po);

                if (resp.ItOpnpo.Length == 0)
                {
                    MessageBox.Show("Ürüne ait açık sipariş bulunamadı");
                    dt_sip.Clear();
                    grd_sip.DataSource = dt_sip;
                    return;
                }
                foreach (WS_Kontrol.ZktmobilOpnPo opn in resp.ItOpnpo)
                {
                    DataRow row = dt_sip.NewRow();
                    row["ebeln"] = opn.EEbeln;
                    row["bedat"] = Convert.ToDateTime(opn.EBedat).ToString("dd/MM/yyyy");
                    row["menge"] = opn.EMenge;
                    row["meins"] = opn.EMeins;
                    if (opn.EAr == "X") 
                        row["ear"] = opn.EAr;
                    else
                        row["ear"] = "";
                    
                    dt_sip.Rows.Add(row);
                }
                grd_sip.DataSource = dt_sip;

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

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_getir_Click(txt_Barkod, new EventArgs());
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }                       
    }
}

