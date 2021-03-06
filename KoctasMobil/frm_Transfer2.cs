using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_Transfer2 : Form
    {
        DataTable m_grdTransfer;
        int sonSatirIndex = 0;
        
        public frm_Transfer2()
        {
            InitializeComponent();
        }

        public frm_Transfer2(DataTable Dt)
        {
            InitializeComponent();
            m_grdTransfer = Dt;

        }

        
        private void frm_Transfer2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            grd_Transfer.DataSource = m_grdTransfer;

        }

        private void grd_Transfer_Click(object sender, EventArgs e)
        {            
            if (grd_Transfer.CurrentRowIndex > -1)
            {
                sonSatirIndex = grd_Transfer.CurrentRowIndex;
                grd_Transfer.Select(grd_Transfer.CurrentRowIndex);
                txtMiktar.Text = grd_Transfer[grd_Transfer.CurrentRowIndex, 3].ToString();
                txtAdt.Text = grd_Transfer[grd_Transfer.CurrentRowIndex, 6].ToString();
                //txtAdt.Text = (grd_Transfer.DataSource as WS_Stok.ZktmobilTrans[])[grd_Transfer.CurrentRowIndex].Meins;

                txtMiktar.Focus();
                txtMiktar.SelectAll();
            }
        }       

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (grd_Transfer.VisibleRowCount == 0)
                    return;
                
                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service SRV = new WS_Stok.service();

                SRV.Url = Utility.getWsUrl("zktmobil_stok");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Stok.ZktmobilSaveTrsf SaveTrsf = new WS_Stok.ZktmobilSaveTrsf();

                
                //int Length = (grd_Transfer.DataSource as WS_Stok.ZktmobilTrans[]).Length;
                WS_Stok.ZktmobilTrans[] Trans = new WS_Stok.ZktmobilTrans[m_grdTransfer.Rows.Count];

                for(int i=0; i<m_grdTransfer.Rows.Count; i++)
                {
                    WS_Stok.ZktmobilTrans item = new WS_Stok.ZktmobilTrans();
                    item.Ebeln = m_grdTransfer.Rows[i]["Ebeln"].ToString();
                    item.Ebelp = m_grdTransfer.Rows[i]["Ebelp"].ToString();
                    item.Maktx = m_grdTransfer.Rows[i]["Maktx"].ToString();
                    item.Matnr = m_grdTransfer.Rows[i]["Matnr"].ToString();
                    item.Meins = m_grdTransfer.Rows[i]["Meins"].ToString();
                    item.Menge = Convert.ToDecimal(m_grdTransfer.Rows[i]["Menge"].ToString());
                    item.Tmenge = Convert.ToDecimal(m_grdTransfer.Rows[i]["Tmenge"].ToString());

                    Trans[i] = item;

                }

                SaveTrsf.ItSave = Trans;

                WS_Stok.ZktmobilSaveTrsfResponse Response = SRV.ZktmobilSaveTrsf(SaveTrsf);

                if (Response.EReturn != null && Response.EReturn.Length > 0 && Response.EReturn[0].RcCode == "E")
                    throw new Exception(Response.EReturn[0].RcText);
                else
                {
                    MessageBox.Show("Başarıyla kayıt edilmiştir.");
                    DialogResult = DialogResult.OK;
                }
                                
                grd_Transfer.UnSelect(grd_Transfer.CurrentRowIndex);
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

        private void txtAdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (grd_Transfer.VisibleRowCount == 0)
                        return;

                    if (!grd_Transfer.IsSelected(grd_Transfer.CurrentRowIndex))
                        throw new Exception("Lütfen bir kayıt seçiniz!");
                  
                    try { decimal.Parse(txtMiktar.Text.Trim()); }
                    catch { throw new Exception("Miktar alanına sayısal bir değer giriniz!"); }

                    string[] mStr = m_grdTransfer.Rows[grd_Transfer.CurrentRowIndex]["Menge"].ToString().Split('.');
                    if (Convert.ToInt32(txtMiktar.Text.Trim()) > (Convert.ToInt32(mStr[0])))
                        throw new Exception("Toplanan miktar sipariş miktarından fazla olamaz!");

                    m_grdTransfer.Rows[grd_Transfer.CurrentRowIndex]["Tmenge"] = Convert.ToDecimal(txtMiktar.Text.Trim().Replace('.', ','));
                    grd_Transfer.DataSource = null;
                    grd_Transfer.DataSource = m_grdTransfer;
                    txtMiktar.Text = "";

                    //Değiştirilen son satır seçiliyor
                    grd_Transfer.Select(sonSatirIndex);
                    sonSatirIndex = 0;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}