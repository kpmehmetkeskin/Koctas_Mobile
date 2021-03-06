using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_NormalSiparisYarat2 : Form
    {
        
        
        public frm_NormalSiparisYarat2(KoctasMobil.frm_NormalSiparisYarat.Title Title)
        {
            InitializeComponent();
            this._title = Title;
            SetTitle();
        }
        public DataTable dt_urun;
        public string teslim_tarih;
        public string  transferli = "";
        public string mVBELN = "";
        private datatocopy _copyingdata;
        private bool ftpError = false;
        private string hataliBelge = "";
        private KoctasMobil.frm_NormalSiparisYarat.Title _title;

        private void frm_NormalSiparisYarat2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            rb_metrajli.Checked = true;
            this.AutoValidate = AutoValidate.Inherit;
            if (transferli == "X")
            {   
                rb_metrajli.Visible = false;
                rb_depodan.Checked = true;
                rb_depodan.Location = new Point(rb_depodan.Location.X, 32);
                rb_hizmetbanko.Location = new Point(rb_hizmetbanko.Location.X, 58);
                this.Text = "Transferli Satış Yarat";
            }
            txt_musteriAdi.Text = Copyingdata.musteri;
            txt_Semt.Text = Copyingdata.semt;
            txt_note.Text = Copyingdata.not;
            txt_ÝsTlf.Text = Copyingdata.istel;
            txt_EvTlf.Text = Copyingdata.evtel;
            txt_CepTlf.Text = Copyingdata.ceptel;
            if (Copyingdata.siparistipi == "A")
            {
                rb_hizmetbanko.Checked = false;
                rb_depodan.Checked = false;
                rb_metrajli.Checked = true;
            }
            else if (Copyingdata.siparistipi == "B")
            {
                rb_metrajli.Checked = false;
                rb_hizmetbanko.Checked = false;
                rb_depodan.Checked = true;
            }
            else if (Copyingdata.siparistipi == "C")
            {
                rb_metrajli.Checked = false;
                rb_depodan.Checked = false;
                rb_hizmetbanko.Checked = true;
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ftpError = false;
            WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
            WS_Satis.ZktmobilCreateOrderResponse response = new KoctasMobil.WS_Satis.ZktmobilCreateOrderResponse();
            try
            {
                WS_Satis.ZktmobilCreateOrder siparis = new KoctasMobil.WS_Satis.ZktmobilCreateOrder();
                siparis.IFOzel = transferli;
                siparis.ICepTelefonu = txt_CepTlf.Text.Trim();
                siparis.IEvTelefonu = txt_EvTlf.Text.Trim();
                siparis.IIsTelefonu = txt_ÝsTlf.Text.Trim();
                siparis.IMusteri = txt_musteriAdi.Text.Trim();
                siparis.INote = txt_note.Text.Trim();
                siparis.ISemt = txt_Semt.Text.Trim();
                if (rb_metrajli.Checked)
                {
                    siparis.ISiparisTipi = "A";
                }
                if (rb_depodan.Checked)
                {
                    siparis.ISiparisTipi = "B";
                }
                if (rb_hizmetbanko.Checked)
                {
                    siparis.ISiparisTipi = "C";
                }
                
                siparis.ITeslimTarih = teslim_tarih;
                siparis.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                siparis.TiKalemler = new KoctasMobil.WS_Satis.Zsd002[dt_urun.Rows.Count];

                if (mVBELN != "")
                {
                    siparis.IFChange = "X";
                    siparis.IVbeln = mVBELN;
                }

                for (int i = 0; i < dt_urun.Rows.Count; i++)
			    {
    			    siparis.TiKalemler[i] = new KoctasMobil.WS_Satis.Zsd002();
                    siparis.TiKalemler[i].Matnr = dt_urun.Rows[i]["MATNR"].ToString();
                    siparis.TiKalemler[i].Menge = Convert.ToDecimal(dt_urun.Rows[i]["MENGE"].ToString());
                    siparis.TiKalemler[i].Meins = dt_urun.Rows[i]["MEINS"].ToString();
                    //siparis.TiKalemler[i].CancelTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    siparis.TiKalemler[i].CancelDate = DateTime.Now.ToString("yyyy-MM-dd");
			    }
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                response = SRV.ZktmobilCreateOrder(siparis);

                if (response.TeReturn[0].RcCode == "S")
                {
                    MessageBox.Show(response.TeReturn[0].RcText, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    this.DialogResult = DialogResult.OK;
                    ftpError = false;
                    this.Close();
                }
                else
                {
                    //this.DialogResult = DialogResult.Cancel;
                    if (response.TeReturn[0].RcCode == "F") //FTPye gödnerilemedi hatasý.
                    {
                        ftpError = true;
                        hataliBelge = response.TiKalemler[0].Vbeln.ToString();
                        MessageBox.Show(response.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show(response.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        ftpError = false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                //this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);               
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ýnputPanel1.Enabled)
            {
                ýnputPanel1.Enabled = false;
            }
            else
            {                
                ýnputPanel1.Enabled = true;
                ýnputPanel1.Bounds.Offset(32 - ýnputPanel1.Bounds.X, 20 - ýnputPanel1.Bounds.Y); //???
            }
        }
        public datatocopy Copyingdata
        {
            get { return _copyingdata; }
            set { _copyingdata = value; }
        }

        private void frm_NormalSiparisYarat2_Closing(object sender, CancelEventArgs e)
        {
            if (ftpError)
            {
                if (MessageBox.Show("Sipariş FTPye gönderilemedi. Çıkarsanız sipariş tamamen silinecek. Devam etmek istiyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        /*
                        25.12.2012 - Özgür Bey'in isteiði ile kaldýrýldý - by brksnmz
                        WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
                        WS_Satis.ZktmobilDeleteOrder deleteorder = new KoctasMobil.WS_Satis.ZktmobilDeleteOrder();
                        WS_Satis.ZktmobilDeleteOrderResponse response = new KoctasMobil.WS_Satis.ZktmobilDeleteOrderResponse();
                        deleteorder.IVbeln = hataliBelge;
                        deleteorder.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                        SRV.Url = Utility.getWsUrl("zktmobil_satis");
                        SRV.Credentials = ProgramGlobalData.g_credential;

                        response = SRV.ZktmobilDeleteOrder(deleteorder);
                        if (response.TeReturn[0].RcCode == "S")
                        {
                            MessageBox.Show("Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            throw new Exception(response.TeReturn[0].RcText);
                        }*/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void SetTitle()
        {
            switch (_title)
            {
                case KoctasMobil.frm_NormalSiparisYarat.Title.birlestir:
                    this.Text = "Sipariş Birleştir";
                    break;
                case KoctasMobil.frm_NormalSiparisYarat.Title.degistir:
                    this.Text = "Sipariş Değiştir";
                    break;
                case KoctasMobil.frm_NormalSiparisYarat.Title.kopyala:
                    this.Text = "Sipariş Kopyala";
                    break;
                case KoctasMobil.frm_NormalSiparisYarat.Title.normal:
                    this.Text = "Normal Sipariş Yarat";
                    break;
                case KoctasMobil.frm_NormalSiparisYarat.Title.transferli:
                    this.Text = "Transferli Sipariş Yarat";
                    break;
            }
        }
    }
}