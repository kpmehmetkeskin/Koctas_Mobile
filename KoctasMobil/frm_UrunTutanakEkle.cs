using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunTutanakEkle : Form
    {        
        public frm_UrunTutanakEkle()
        {
            InitializeComponent();
            if (_dt_urun == null)
            {
                _dt_urun = new DataTable();
                _dt_urun.Columns.Add("MATNR");
                _dt_urun.Columns.Add("MAKTX");
                _dt_urun.Columns.Add("MENGE");
                _dt_urun.Columns.Add("TIP");
            }
        }
     
        DataTable _dt_urun;
        public DataTable Dt_urun
        {
            get { return _dt_urun; }
            set { _dt_urun = value; }
        }

        string _tedarikci;
        public string tTedarikci
        {
            get { return _tedarikci; }
            set { _tedarikci = value; }
        }


        Bitmap imza1, imza2, imza3;
        public bool Change;
        WS_Tutanak.ZKTMOBIL_S_SATICI[] saticilar;

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
                WS_Satis.ZktmobilGetMaterialInfo Matinfo = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfo();
                WS_Satis.ZktmobilGetMaterialInfoResponse response = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfoResponse();
                try
                {
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;
                    Matinfo.IBarkod = txt_Barkod.Text.Trim();
                    response = SRV.ZktmobilGetMaterialInfo(Matinfo);
                    txt_matnr.Text = response.EMatnr;
                    txt_maktx.Text = response.EMaktx;
                    txt_birim.Text = response.EMeins;
                    //matkl = response.EMatkl;
                    //mtart = response.EMtart;
                    txt_miktar.Focus();
                    if (string.IsNullOrEmpty(response.EMatnr))
                    {
                        txt_Barkod.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    txt_Barkod.Focus();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {               
            if (String.IsNullOrEmpty(txt_maktx.Text))
            {
                if (!string.IsNullOrEmpty(txt_Barkod.Text))
                {
                    txt_Barkod_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
                }
                else if (!string.IsNullOrEmpty(txt_matnr.Text))
                {
                    txt_matnr_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
                }
            }
            if (String.IsNullOrEmpty(txt_maktx.Text))
            {
                return;
            }

            try
            {
                decimal.Parse(txt_miktar.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("Miktar alanına yalnız sayısal değer girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            if (cmb_Tip.SelectedItem == null)
            {
                MessageBox.Show("Tip seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            if (!CheckSatici())
            {
                MessageBox.Show("Farklı satıcılara ait ürünler giremezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            } 

            try
            {
                DataRow row = _dt_urun.NewRow();
                row["MATNR"] = txt_matnr.Text.Trim();
                row["MAKTX"] = txt_maktx.Text.Trim();
                row["MENGE"] = txt_miktar.Text.Trim();
                row["TIP"] = cmb_Tip.SelectedItem.ToString();
                _dt_urun.Rows.Add(row);
                Change = true;
                grd_Urun.DataSource = null;
                grd_Urun.DataSource = _dt_urun;                
                txt_birim.Text = string.Empty;
                txt_maktx.Text = string.Empty;
                txt_matnr.Text = string.Empty;
                txt_Barkod.Text = string.Empty;
                txt_miktar.Text = string.Empty;
                txt_Barkod.Focus();
             }            
             catch (Exception ex)
             {
                 txt_miktar.Focus();
                 MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
             } 
             finally
             {
                 Cursor.Current = Cursors.Default;
             }
        }

        private bool CheckSatici()
        {
            try
            {
                WS_Tutanak.service srv = new KoctasMobil.WS_Tutanak.service();
                srv.Url = Utility.getWsUrl("ZKTMOBIL_URTUT");
                srv.Credentials = ProgramGlobalData.g_credential;
                WS_Tutanak.ZKTMOBIL_GET_MAT_SATICIResponse resp = new KoctasMobil.WS_Tutanak.ZKTMOBIL_GET_MAT_SATICIResponse();
                WS_Tutanak.ZKTMOBIL_GET_MAT_SATICI sat = new KoctasMobil.WS_Tutanak.ZKTMOBIL_GET_MAT_SATICI();
                sat.TE_LIST = new KoctasMobil.WS_Tutanak.ZKTMOBIL_S_SATICI[0];
                sat.I_MATNR = txt_matnr.Text.Trim();

                resp = srv.ZKTMOBIL_GET_MAT_SATICI(sat);

                saticilar = resp.TE_LIST;
                foreach (WS_Tutanak.ZKTMOBIL_S_SATICI satici in saticilar)
                {
                    // Webservice'den gelen tedarikçi alanı uzunluğu hesaplanıp, form alanından girilen 
                    // tedarikçi kodunun başına gerekli miktarda '0' karakteri ekleniyor
                    tTedarikci = tTedarikci.PadLeft(satici.LIFNR.Length, '0');
                    
                    if (satici.LIFNR == tTedarikci)
                    {
                        return true;
                    }
                }

                /*
                if (saticilar == null)
                {
                    saticilar = resp.TE_LIST;
                    return true;
                }
                else
                {
                    foreach (WS_Tutanak.ZKTMOBIL_S_SATICI satici in saticilar)
                    {
                        foreach (WS_Tutanak.ZKTMOBIL_S_SATICI gelensatici in resp.TE_LIST)
                        {
                            if (satici.LIFNR == gelensatici.LIFNR)
                            {
                                return true;
                            }
                        }
                    }
                }
                 */
                Cursor.Current = Cursors.Default;
                return false;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                throw ex;
            }            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (grd_Urun.CurrentRowIndex >= 0)
                {
                    _dt_urun.Rows.RemoveAt(grd_Urun.CurrentRowIndex);
                    Change = true;
                    //grd_Urun.DataSource = null;
                    //grd_Urun.DataSource = _dt_urun;
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

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
                WS_Satis.ZktmobilGetMaterialInfo Matinfo = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfo();
                WS_Satis.ZktmobilGetMaterialInfoResponse response = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfoResponse();
                try
                {
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;
                    Matinfo.IMatnr = txt_matnr.Text.Trim();
                    response = SRV.ZktmobilGetMaterialInfo(Matinfo);
                    txt_Barkod.Text = response.EEan11;
                    txt_maktx.Text = response.EMaktx;
                    txt_birim.Text = response.EMeins;
                    txt_miktar.Focus();
                    if (string.IsNullOrEmpty(response.EEan11))
                    {
                        txt_matnr.Focus();
                    }
                }
                catch (Exception ex)
                {
                    txt_matnr.Focus();
                    MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void grd_Urun_DoubleClick(object sender, EventArgs e)
        {
            txt_matnr.Text = _dt_urun.Rows[grd_Urun.CurrentCell.RowNumber]["MATNR"].ToString();
            //txt_miktar.Text = _dt_urun.Rows[grd_Urun.CurrentCell.RowNumber]["MENGE"].ToString();
            txt_matnr_KeyPress(grd_Urun, new KeyPressEventArgs((char)13));
        } 

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_ekle_Click(txt_miktar, new EventArgs());
            }
        }

        private void ClearScrean()
        {
            foreach (Control var in this.Controls)
            {
                if (var is TextBox && var.Name != "txt_toplamTutar")
                {
                    var.Text = "";
                }
            }
        }

        private void txt_toplamTutar_KeyDown(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_birim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_maktx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            ClearScrean();
        }

        private void frm_UrunTutanakEkle_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (_dt_urun != null)
            {
                grd_Urun.DataSource = _dt_urun;
            }
        }

        private void cmb_Tip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_ekle_Click(txt_miktar, new EventArgs());
            }
        }
    }
}

