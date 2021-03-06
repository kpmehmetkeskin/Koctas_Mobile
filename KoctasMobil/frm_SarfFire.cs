using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_SarfFire : Form
    {
        public frm_SarfFire()
        {
            InitializeComponent();
        }

        bool matChecked = false;
        bool depoChecked = false;
        string sMiktar = "";
        DataTable dtSarfFire = new DataTable();
        private void frm_Etiket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtSarfFire.Columns.Add("Barkod");
            dtSarfFire.Columns.Add("Aciklama");
            dtSarfFire.Columns.Add("Miktar");
            dtSarfFire.Columns.Add("rB");
            dtSarfFire.Columns.Add("Lgort");
            dtSarfFire.Columns.Add("Matnr");
            dtSarfFire.Columns.Add("rbValue");
            dtSarfFire.PrimaryKey = new DataColumn[] { dtSarfFire.Columns["Barkod"] };
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
                lblMatnr.Text = matresp.EMatnr;
                txt_maktx.Text = matresp.EMaktx;
                txtAdt.Text = matresp.EMeins;
                if (matresp.EMaktx != "")
                {
                    matChecked = true;
                    txtAciklama.Focus();
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
        
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            if (rbValue == 0)
            {
                MessageBox.Show("Lütfen sarf işlemi seçiniz!");
                return;
            }

            /*
            if (txtAciklama.Text.Trim() == "")
            {
                MessageBox.Show("Açýklama alaný boþ geçilemez!");
                return;
            }
             */

            if (!matChecked) btn_getir_Click(btn_Ekle);
            if (!matChecked)
            {
                MessageBox.Show("Malzeme kontrolü yapılamadı!");
                return;
            }

            if (!depoChecked) txtDepoYeri_KeyPress(null,new KeyPressEventArgs((char)13));
            if (!depoChecked) 
            {
                MessageBox.Show("Depo yeri kontrolü yapılamadı!");
                return; 
            }

            try
            {
                //int.Parse(txtMiktar.Text.Trim());
                decimal miktar = decimal.Parse(txtMiktar.Text.Trim());
                if (!(miktar > 0))
                {
                    MessageBox.Show("Miktar alanına 0'dan büyük bir değer giriniz!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Miktar alanına sayısal bir değer giriniz!");
                return;
            }
            
            DataRow fRow = dtSarfFire.Rows.Find(txt_Barkod.Text.Trim());
            if (fRow == null)
            {

                sMiktar = txtMiktar.Text.Trim();
                sMiktar = sMiktar.Replace(',', '.');


                dtSarfFire.Rows.Add(txt_Barkod.Text.Trim(),
                                     txtAciklama.Text.Trim(),
                                     sMiktar,
                                     rbText,// rbValue,
                                     txtDepoYeri.Text.Trim(),
                                     lblMatnr.Text.Trim(),
                                     rbValue
                                     );
            }
            else
            {
                fRow["Miktar"] = decimal.Parse(fRow["Miktar"].ToString())
                                                +
                                    decimal.Parse(txtMiktar.Text.Trim());

            }
            grd_SarfFire.DataSource = dtSarfFire;            
            txt_Barkod.Text = txt_maktx.Text = txtAciklama.Text = txtDepoYeri.Text =
                txtMiktar.Text = txtAdt.Text = lblMatnr.Text =  "";
            //rbAnhTesMasraf.Checked =  //by Ali Görkem Gönen Revizeleri tarafından kaldırıldı - 28.04.2015
            rbFazla.Checked = rbKayip.Checked = rbMasraf.Checked =
                rbSarfFire.Checked = rbSarfFireKayip.Checked = false;
            rbValue = 0;
            rbText = "";
            txt_Barkod.Focus();
        }

        private void txt_Barkod_TextChanged(object sender, EventArgs e)
        {
            matChecked = false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtSarfFire.Rows.Count - 1; i >= 0; i--)
                if (grd_SarfFire.IsSelected(i))
                    dtSarfFire.Rows.RemoveAt(i);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = dtSarfFire.Rows.Count - 1; i >= 0; i--)
                dtSarfFire.Rows.RemoveAt(i);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //by Ali Görkem Gönen Revizeleri tarafından kaldırıldı - 28.04.2015
                //!rbAnhTesMasraf.Checked &&
                //if ( !rbFazla.Checked && !rbKayip.Checked && !rbMasraf.Checked && !rbSarfFire.Checked && !rbSarfFireKayip.Checked) { throw new Exception("İşlem tipi seçiniz!"); }    
                if (dtSarfFire.Rows.Count == 0) { throw new Exception("Sarf fire tablosu boş ike işlem yapılamaz!"); } 

                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service SRV = new WS_Stok.service();

                SRV.Url = Utility.getWsUrl("zktmobil_stok");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Stok.ZktmobilSarfFormCrt Sarf = new WS_Stok.ZktmobilSarfFormCrt();

                WS_Stok.ZktmobilSarf[] items = new WS_Stok.ZktmobilSarf[dtSarfFire.Rows.Count];
                for (int i = 0; i < dtSarfFire.Rows.Count; i++)
                {
                    WS_Stok.ZktmobilSarf item = new WS_Stok.ZktmobilSarf();

                    item.Aciklama = dtSarfFire.Rows[i]["Aciklama"].ToString();
                    item.Lgort = dtSarfFire.Rows[i]["Lgort"].ToString();
                    item.Matnr = dtSarfFire.Rows[i]["Matnr"].ToString();
                    item.Menge = Convert.ToDecimal(dtSarfFire.Rows[i]["Miktar"].ToString());
                    item.Sarf = dtSarfFire.Rows[i]["rbValue"].ToString();
                    items[i] = item;
                }
                Sarf.ItSarf = items;
                WS_Stok.ZkmobilReturn[] RET = new WS_Stok.ZkmobilReturn[1];
                Sarf.EReturn = RET;
                WS_Stok.ZktmobilSarfReturn[] fRET = new WS_Stok.ZktmobilSarfReturn[1];
                Sarf.ItReturn = fRET;

                WS_Stok.ZktmobilSarfFormCrtResponse Response = SRV.ZktmobilSarfFormCrt(Sarf);

                if (Response.EReturn.Length > 0)                
                    MessageBox.Show(Response.EReturn[0].RcText, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                

                StringBuilder sbFormNumbers = new StringBuilder();
                if (Response.ItReturn.Length > 0)                
                    foreach (WS_Stok.ZktmobilSarfReturn var in Response.ItReturn)                    
                        sbFormNumbers.Append(var.SarfNo + " ,");
                
                if (sbFormNumbers.Length > 0)
                {
                    sbFormNumbers.Insert(0, "Oluşan Form Numaraları :\n ");
                    MessageBox.Show(sbFormNumbers.ToString().TrimEnd(','));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void txt_maktx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDepoYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtDepoYeri.Text.Trim() == "")
                {
                    MessageBox.Show("Depo yeri boş geçilemez!");
                    return;
                }

                if (!depoChecked)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        WS_Stok.service SRV = new WS_Stok.service();

                        SRV.Url = Utility.getWsUrl("zktmobil_stok");
                        SRV.Credentials = ProgramGlobalData.g_credential;

                        WS_Stok.ZktmobilChckStore Str = new WS_Stok.ZktmobilChckStore();
                        WS_Stok.ZkmobilReturn[] Return = new KoctasMobil.WS_Stok.ZkmobilReturn[0];
                        Str.EReturn = Return;
                        Str.IMatnr = lblMatnr.Text;
                        Str.ILgort = txtDepoYeri.Text.Trim();

                        WS_Stok.ZktmobilChckStoreResponse Response =
                            new WS_Stok.ZktmobilChckStoreResponse();
                        Response = SRV.ZktmobilChckStore(Str);

                        if (Response.EReturn.Length > 0 && Response.EReturn[0].RcCode == "E")
                        {
                            MessageBox.Show(Response.EReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            Cursor.Current = Cursors.Default;
                            return;
                        }
                        txtMiktar.Focus();
                        depoChecked = true;
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
                else
                    txtMiktar.Focus();
            }
        }

        private void txtDepoYeri_TextChanged(object sender, EventArgs e)
        {
            depoChecked = false;
        }

        private void txtAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)13)
            {
                /*
                if (txtAciklama.Text.Trim() == "")
                {
                    MessageBox.Show("Açıklama alanı boş geçilemez!");
                    return;
                }*/

                txtDepoYeri.Focus();
            }
        }

        int rbValue=0;
        string rbText = "";
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            switch (rb.Name)
            {
                case "rbSarfFire":
                    rbValue = 1;
                    rbText = rb.Text;
                    break;
                case "rbSarfFireKayip":
                    rbValue = 2;
                    rbText = "Sarf Kayıp";
                    break;
                case "rbMasraf":
                    rbText = rb.Text;
                    rbValue = 3;
                    break;
                case "rbKayip":
                    rbText = rb.Text;
                    rbValue = 4;
                    break;
                case "rbFazla":
                    rbText = rb.Text;
                    rbValue = 5;
                    break;
                case "rbAnhTesMasraf":
                    rbValue = 6;
                    rbText = "Anh Masraf";
                    break;                
            }            
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    decimal.Parse(txtMiktar.Text.Trim());            
                }
                catch
                {
                    MessageBox.Show("Miktar alanına sayısal bir değer giriniz!");
                    return;
                }
                rbSarfFire.Focus();
            }
        }

        private void rb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (rbValue == 0) return;
            if (e.KeyChar == (char)13)
            {
                btn_Ekle_Click(null, null);               
            }
        }       
    }
}