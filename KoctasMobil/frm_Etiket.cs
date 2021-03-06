using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_Etiket : Form
    {
        public frm_Etiket()
        {
            InitializeComponent();
        }

        bool matChecked = false;
        bool adrChecked = false;
        DataTable dtEtiket = new DataTable();
        private void frm_Etiket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cmbBoyut.SelectedIndex = 0;
            dtEtiket.Columns.Add("Barkod");
            dtEtiket.Columns.Add("Adet");
            dtEtiket.Columns.Add("Adres");
            dtEtiket.Columns.Add("Boyut");
            dtEtiket.PrimaryKey = new DataColumn[] { dtEtiket.Columns["Barkod"] };
        }

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {              
              btn_getir_Click(txt_Barkod);
            }
        }

        private void btn_getir_Click(object sender)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
               if (sender == txt_Barkod)
                {
                    mtnr.IMatnr = txt_Barkod.Text.Trim();
                }
                else
                {
                    if (!String.IsNullOrEmpty(txt_Barkod.Text))
                    {
                        mtnr.IMatnr = txt_Barkod.Text.Trim();
                    }                   
                    else
                    {
                        return;
                    }
                }
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;

                matresp = srv.ZktmobilChckMtnr(mtnr);

                if (matresp.EReturn.RcCode == "E")
                {
                    throw new Exception(matresp.EReturn.RcText);
                }

                txt_Barkod.Text = matresp.EEan11;
                txt_maktx.Text = matresp.EMaktx;
                if (matresp.EMaktx != "")
                {
                    matChecked = true;
                    txtAdet.Focus();
                }
                else
                    txt_Barkod.Focus();
            }
            catch (Exception ex)
            {
                txt_Barkod.Text = "";
                txt_maktx.Text = "";
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtAdet.Text.Trim() != "")
                    txtAdres.Focus();
            }
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtAdres.Text.Trim() != "" && !adrChecked)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        WS_Kontrol.service SRV = new WS_Kontrol.service();

                        SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                        SRV.Credentials = ProgramGlobalData.g_credential;

                        WS_Kontrol.ZktmobilChckAdr Adr = new KoctasMobil.WS_Kontrol.ZktmobilChckAdr();
                        Adr.IAddress = txtAdres.Text.ToUpper().Trim();
                        Adr.EReturn = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                        WS_Kontrol.ZktmobilChckAdrResponse Response = new KoctasMobil.WS_Kontrol.ZktmobilChckAdrResponse();
                        Response = SRV.ZktmobilChckAdr(Adr);

                        if (Response.EReturn.RcCode == "E")
                        {
                            MessageBox.Show(Response.EReturn.RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            Cursor.Current = Cursors.Default;
                            return;
                        }
                        else
                            this.adrChecked = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }         

                    cmbBoyut.Focus();
                }
            }
        }

        private void cmbBoyut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (matChecked)
                    btn_Ekle_Click(cmbBoyut, EventArgs.Empty);
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!matChecked) btn_getir_Click(btn_Ekle);
            if (!matChecked) return;

            if ( !adrChecked) txtAdres_KeyPress(btn_Ekle,new KeyPressEventArgs((char)13));
            if (!adrChecked) return;

            if (txt_Barkod.Text == "") return;
            DataRow fRow = dtEtiket.Rows.Find(txt_Barkod.Text.Trim());
            if (fRow == null)
                dtEtiket.Rows.Add(txt_Barkod.Text.Trim(),
                                     txtAdet.Text.Trim(),
                                     txtAdres.Text.Trim().ToUpper(),
                                     cmbBoyut.SelectedItem.ToString()                                     
                                     );
            else
                fRow["Adet"] = int.Parse(fRow["Adet"].ToString())
                                                +
                                    int.Parse(txtAdet.Text.Trim());
               

            grd_Etiket.DataSource = dtEtiket;
            txt_Barkod.Text = txt_maktx.Text = txtAdet.Text = txtAdres.Text = "";
            cmbBoyut.SelectedIndex = 0;
            txt_Barkod.Focus();
        }

        private void txt_Barkod_TextChanged(object sender, EventArgs e)
        {
            matChecked = false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtEtiket.Rows.Count - 1; i >= 0; i--)
                if (grd_Etiket.IsSelected(i))
                    dtEtiket.Rows.RemoveAt(i);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = dtEtiket.Rows.Count - 1; i >= 0; i--)
                dtEtiket.Rows.RemoveAt(i);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service SRV = new WS_Kontrol.service();

                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZktmobilSaveTag Tag = new WS_Kontrol.ZktmobilSaveTag();

                WS_Kontrol.ZktmobilTag[] items = new WS_Kontrol.ZktmobilTag[dtEtiket.Rows.Count];
                for (int i = 0; i < dtEtiket.Rows.Count; i++)
                {
                    WS_Kontrol.ZktmobilTag item = new WS_Kontrol.ZktmobilTag();

                    item.IAdet = Convert.ToInt16(dtEtiket.Rows[i]["Adet"].ToString());
                    item.IBarkod = dtEtiket.Rows[i]["Barkod"].ToString();
                    item.IBoyut = dtEtiket.Rows[i]["Boyut"].ToString();
                    item.IRaf = dtEtiket.Rows[i]["Adres"].ToString();
                    items[i] = item;
                }
                Tag.ItTag = items;
                Tag.EReturn = new WS_Kontrol.ZkmobilReturn[1];

                WS_Kontrol.ZktmobilSaveTagResponse Response = SRV.ZktmobilSaveTag(Tag);

                if (Response.EReturn.Length > 0)
                {
                    if (Response.EReturn[0].RcCode == "S")
                    {
                        MessageBox.Show(Response.EReturn[0].RcText, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        Cursor.Current = Cursors.Default;
                        txt_Barkod.Text = txt_maktx.Text = txtAdet.Text = txtAdres.Text = "";
                        cmbBoyut.SelectedIndex = 0;
                        dtEtiket.Rows.Clear();
                        txt_Barkod.Focus();
                    }
                    else
                    {
                        MessageBox.Show("İşlem Tamamlanamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            } 
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            adrChecked = false;
        }
    }
}