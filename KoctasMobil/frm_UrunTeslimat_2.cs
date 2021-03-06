using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunTeslimat_2 : Form
    {
        private String PARVW;
        private String ISMKL;

        public frm_UrunTeslimat_2()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        WS_UrunTeslim.ZKTMOBIL_S005[] redNedenleri;

        public string redNedeniDegeriGetir(string redNedeni)
        {
            string deger = "";

            try
            {
                if (redNedenleri.Length > 0)
                {
                    for (int i = 0; i < redNedenleri.Length; i++)
                    {
                        if (redNedeni.Trim() == redNedenleri[i].NEDEN_TANIM.Trim())
                        {
                            deger = redNedenleri[i].NEDEN_CODE.ToString().Trim();
                        }
                    }
                }
            }
            catch
            {
            }

            return deger;
        }
        public void eksikNedenleriDoldur()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                ComboboxItem item1 = new ComboboxItem();
                item1.Text = "";
                item1.Value = "";

                cmbRedNeden.Items.Add(item1);

                WS_UrunTeslim.SERVICE srv = new KoctasMobil.WS_UrunTeslim.SERVICE();
                srv.Url = Utility.getWsUrl("zktmobil_urunteslim");
                srv.Credentials = ProgramGlobalData.g_credential;

                WS_UrunTeslim.ZKTMOBIL_EKSIKNEDENLERI ItNeden = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_EKSIKNEDENLERI();
                WS_UrunTeslim.ZKTMOBIL_S005 etNeden = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S005();
                //WS_UrunTeslim.ZKTMOBIL_T001 etNeden = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_T001();

                ItNeden.ET_NEDEN = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S005[0];
                //ItNeden.ET_NEDEN = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_T001[0];

                WS_UrunTeslim.ZKTMOBIL_EKSIKNEDENLERIResponse resp = srv.ZKTMOBIL_EKSIKNEDENLERI(ItNeden);

                if (resp.ET_NEDEN.Length > 0)
                {
                    redNedenleri = resp.ET_NEDEN;
                    for (int i = 0; i < resp.ET_NEDEN.Length; i++)
                    {
                        string nedenCode = resp.ET_NEDEN[i].NEDEN_CODE.ToString();
                        string nedenAciklama = resp.ET_NEDEN[i].NEDEN_TANIM.ToString();

                        ComboboxItem item = new ComboboxItem();
                        item.Text = nedenAciklama;
                        item.Value = nedenCode;

                        cmbRedNeden.Items.Add(item);
                    }
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

        DataTable dtTeslimat = new DataTable();
        private void frm_Etiket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            dtTeslimat.Columns.Add("VBELN");
            dtTeslimat.Columns.Add("POSNR");
            dtTeslimat.Columns.Add("PSTYV");
            dtTeslimat.Columns.Add("MATNR");
            dtTeslimat.Columns.Add("MAKTX");
            dtTeslimat.Columns.Add("MENGE");
            dtTeslimat.Columns.Add("EMENGE");
            dtTeslimat.Columns.Add("NEDEN_CODE");
            dtTeslimat.Columns.Add("I_SET");
            //dtTeslimat.PrimaryKey = new DataColumn[] { dtTeslimat.Columns["MATNR"] };

            this.Text += " (" + ProgramGlobalData.sunucuTip.ToString() + ")";

            eksikNedenleriDoldur();

        }

        private bool isINT(string value)
        {
            try
            {
                //int.Parse(value);
                decimal.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        WS_UrunTeslim.ZKTMOBIL_S001[] ZodendiBlg;
        WS_UrunTeslim.ZSET[] ZodendiSet;

        string formNo = "";
        string Matnr = "";


        public bool bilesenMalzemeKontrol(WS_UrunTeslim.ZKTMOBIL_S001[] malzemeler, WS_UrunTeslim.ZSET[] setler)
        {
            string setMatnr = "";
            string matnr = "";
            if (setler.Length > 0)
            {
                for (int i = 0; i < setler.Length; i++)
                {
                    setMatnr = setler[i].IDNRK.ToString().TrimStart('0');
                    bool buldum = false;
                    if (malzemeler.Length > 0)
                    {
                        for (int j = 0; j < malzemeler.Length; j++)
                        {
                            matnr = malzemeler[j].MATNR.ToString().TrimStart('0');
                            if (matnr == setMatnr)
                            {
                                buldum = true;
                                break;
                            }
                        }
                    }
                    if (buldum == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void txtFormNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    txtFormNo.Text = txtFormNo.Text.Trim().PadLeft(10, '0');
                    Cursor.Current = Cursors.WaitCursor;
                    WS_UrunTeslim.SERVICE srv = new KoctasMobil.WS_UrunTeslim.SERVICE();
                    srv.Url = Utility.getWsUrl("zktmobil_urunteslim");
                    srv.Credentials = ProgramGlobalData.g_credential;

                    WS_UrunTeslim.ZKTMOBIL_ODENDIDETAY odendi = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_ODENDIDETAY();
                    WS_UrunTeslim.ZKTMOBIL_S001 ItOdendi = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S001();
                    WS_UrunTeslim.ZKMOBIL_RETURN TeReturn = new KoctasMobil.WS_UrunTeslim.ZKMOBIL_RETURN();
                    WS_UrunTeslim.ZSET ItSet = new KoctasMobil.WS_UrunTeslim.ZSET();

                    odendi.IV_VBELN = txtFormNo.Text;
                    odendi.ET_ODENDI = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S001[0];
                    odendi.ET_SET = new KoctasMobil.WS_UrunTeslim.ZSET[0];
                    odendi.ET_RETURN = new KoctasMobil.WS_UrunTeslim.ZKMOBIL_RETURN[0];

                    WS_UrunTeslim.ZKTMOBIL_ODENDIDETAYResponse rsp = srv.ZKTMOBIL_ODENDIDETAY(odendi);

                    if (rsp.ET_ODENDI != null)
                    {
                        ZodendiBlg = rsp.ET_ODENDI;
                        ZodendiSet = rsp.ET_SET;
                        formNo = txtFormNo.Text.Trim();
                        this.PARVW = rsp.ET_ODENDI[0].PARVW;
                        this.ISMKL = rsp.ET_ODENDI[0].ISMKL;

                        
                        //Bileşen kalemlerinin hepsi ana kalem tablosunda gelmiş mi?
                        if (bilesenMalzemeKontrol(ZodendiBlg, ZodendiSet) == false)
                        {
                            MessageBox.Show("SET ürünlere ait bileşen malzemelerin hepsi ana malzeme tablosunda gelmedi. SET ürünün bileşenleri düzgün parçalanmamış. SAP tarafından kontrol ediniz.", "HATA");
                            return;
                        }
                        
                        
                        //İçerisinde hizmet ve set olan kalemler tabloya ekleniyor
                        if (rsp.ET_ODENDI.Length > 0)
                        {
                            for (int i = 0; i < rsp.ET_ODENDI.Length; i++)
                            {

                                if ((rsp.ET_ODENDI[i].PSTYV.ToString() != "") || (rsp.ET_ODENDI[i].I_SET.ToString() == "X"))
                                {

                                    bool ekle = true;
                                    string hizmetMatnr = rsp.ET_ODENDI[i].MATNR.ToString().TrimStart('0');

                                    //Matnr daha önce eklenmiş ise eklenen satıra ekle
                                    
                                    for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                                    {
                                        if (dtTeslimat.Rows[j]["MATNR"].ToString().TrimStart('0') == hizmetMatnr)
                                        {
                                            ekle = false;
                                            decimal mevcutMiktar = Convert.ToDecimal(dtTeslimat.Rows[j]["MENGE"].ToString());
                                            dtTeslimat.Rows[j]["MENGE"] = (mevcutMiktar + rsp.ET_ODENDI[i].MENGE).ToString();
                                        }
                                    }

                                    if (ekle)
                                    {

                                        DataRow dr = dtTeslimat.NewRow();
                                        dr["VBELN"] = formNo.ToString();
                                        dr["POSNR"] = getMatnrPosNr(hizmetMatnr);
                                        dr["MATNR"] = hizmetMatnr.TrimStart('0');
                                        dr["MAKTX"] = getMaktx(hizmetMatnr);
                                        dr["EMENGE"] = "0";
                                        dr["MENGE"] = rsp.ET_ODENDI[i].MENGE.ToString();
                                        dr["NEDEN_CODE"] = "";
                                        dr["I_SET"] = rsp.ET_ODENDI[i].I_SET.ToString();
                                        dr["PSTYV"] = rsp.ET_ODENDI[i].PSTYV.ToString();
                                        dtTeslimat.Rows.Add(dr);
                                    }
                                }
                            }
                            grdUrunTeslimat.DataSource = dtTeslimat;
                        }


                        txtMatnrEan11.Focus();
                    }

                    if (rsp.ET_RETURN.Length > 0)
                    {
                        if (rsp.ET_RETURN[0].RC_CODE == "E")
                        {
                            MessageBox.Show(rsp.ET_RETURN[0].RC_TEXT, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            txtFormNo.Focus();
                        }
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
        }

        private void txtMenge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!isINT(txtMenge.Text.Trim()))
                {
                    MessageBox.Show("Toplanan miktar alanına sayısal bir değer giriniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }

                if (Convert.ToDecimal(txtMenge.Text.Trim()) < 0)
                {
                    MessageBox.Show("Toplanan miktar alanına - bir değer giremezsiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }

                //Eksik ürün miktarı hespalanıyor
                decimal txtMengeCount = Convert.ToDecimal(txtMenge.Text.Trim());
                decimal TotalCount = getMatnrCount(Matnr);
                decimal eklenenMiktar = eklenenMiktarBul(Matnr);
                decimal eksikMiktar = Convert.ToDecimal((TotalCount - (txtMengeCount + eklenenMiktar)));
                if (eksikMiktar < 0)
                {
                    MessageBox.Show("Fazla ürün girişi yapılamaz! Daha Önce Eklenen Miktar: " + eklenenMiktar.ToString() + ", Mak. Eklenebilir Miktar:" + (TotalCount - eklenenMiktar).ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            
                    txtEMenge.Text = "0";
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }
                txtEMenge.Text = eksikMiktar.ToString();
                decimal txtEMengeCount = Convert.ToDecimal(txtEMenge.Text.Trim());


                if ((txtMengeCount + txtEMengeCount + eklenenMiktar) > TotalCount)
                {
                    MessageBox.Show("Fazla ürün girişi yapılamaz! + Eklenebilir Miktar:" + TotalCount.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    txtEMenge.Text = "0";
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }


                cmbRedNeden.Focus();
                //txtEMenge.SelectAll();
            }
        }

        private decimal getMatnrCount(string Matnr)
        {
            decimal toplamMiktar = 0;

            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if (ZodendiBlg[i].MATNR.TrimStart('0') == Matnr)
                    toplamMiktar += (decimal)ZodendiBlg[i].MENGE;
            }
            return toplamMiktar;
        }

        private bool malzemeHizmetMi(string Matnr)
        {
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if ((ZodendiBlg[i].MATNR.TrimStart('0') == Matnr) && (ZodendiBlg[i].PSTYV != ""))
                {
                    return true;
                }

            }
            return false;
        }


        private bool malzemeSetMi(string Matnr)
        {
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if ((ZodendiBlg[i].MATNR.TrimStart('0') == Matnr) && (ZodendiBlg[i].I_SET == "X"))
                {
                    return true;
                }

            }
            return false;
        }

        private string getMatnrPosNr(string Matnr)
        {
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if (ZodendiBlg[i].MATNR.TrimStart('0') == Matnr)
                    return (string)ZodendiBlg[i].POSNR.ToString();
            }
            return "";
        }

        private string getMatnrFromSet(string Matnr)
        {
            for (int i = 0; i < ZodendiSet.Length; i++)
            {
                if (ZodendiSet[i].IDNRK.TrimStart('0') == Matnr)
                    return (string)ZodendiSet[i].MATNR.ToString().TrimStart('0');
            }
            return "";
        }

        private decimal getSetMatnrCount(string Matnr)
        {
            for (int i = 0; i < ZodendiSet.Length; i++)
            {
                if (ZodendiSet[i].IDNRK.TrimStart('0') == Matnr)
                    return (decimal)ZodendiSet[i].MENGE;
            }
            return 0;
        }

        private string getMaktx(string MatnrEan11)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            srv.Url = Utility.getWsUrl("zktmobil_kontrol");
            srv.Credentials = ProgramGlobalData.g_credential;

            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            mtnr.IMatnr = MatnrEan11;
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
                matresp = srv.ZktmobilChckMtnr(mtnr);

                if (matresp.EReturn.RcCode == "E")
                {
                    throw new Exception(matresp.EReturn.RcText);
                }
                return matresp.EMaktx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return "";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private string getMatnr(string MatnrEan11)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            srv.Url = Utility.getWsUrl("zktmobil_kontrol");
            srv.Credentials = ProgramGlobalData.g_credential;

            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            mtnr.IMatnr = MatnrEan11;
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
                matresp = srv.ZktmobilChckMtnr(mtnr);

                if (matresp.EReturn.RcCode == "E")
                {
                    throw new Exception(matresp.EReturn.RcText);
                }
                txtMalzemeAdi.Text = matresp.EMaktx;
                return matresp.EMatnr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return "";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            txtEMenge_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtTeslimat.Rows.Count - 1; i >= 0; i--)
            {
                if (grdUrunTeslimat.IsSelected(i))
                {
                    if (dtTeslimat.Rows[i]["PSTYV"].ToString() != "")
                    {
                        MessageBox.Show("Hizmet kalemini silemezsiniz.");
                        return;
                    }
                    else if (dtTeslimat.Rows[i]["I_SET"].ToString() == "X")
                    {
                        MessageBox.Show("SET ürün kalemini silemezsiniz.");
                        return;
                    }
                    
                    dtTeslimat.Rows.RemoveAt(i);

                }
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = dtTeslimat.Rows.Count - 1; i >= 0; i--)
            {

                bool bos = true;

                if (dtTeslimat.Rows[i]["PSTYV"].ToString() != "")
                {
                    bos = false;
                }
                else if (dtTeslimat.Rows[i]["I_SET"].ToString() == "X")
                {
                    bos = false;
                }
                else
                {
                    dtTeslimat.Rows.RemoveAt(i);
                }
                
                
                
                
            }

            cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
            txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = "";
            txtEMenge.Text = "0";
        }

        private decimal toplamMiktarGetir(string Matnr)
        {
            decimal eklenenMiktar = 0;

            if (dtTeslimat.Rows.Count > 0)
            {
                for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                {
                    if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                    {
                        eklenenMiktar += Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]) + Convert.ToDecimal(dtTeslimat.Rows[i]["EMENGE"]);
                    }
                }
            }
            return eklenenMiktar;
        }
        
        
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            //Eklenen urunler kontrol ediliyor
            if (dtTeslimat.Rows.Count > 0)
            {
                try
                {

                    Cursor.Current = Cursors.WaitCursor;

                    WS_UrunTeslim.ZKTMOBIL_S002[] dtUrunler = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S002[ZodendiBlg.Length];

                    for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                    {
                        if (dtTeslimat.Rows[j]["MATNR"].ToString() != "")
                        {
                            //decimal toplanan = Convert.ToDecimal(dtTeslimat.Rows[j]["MENGE"].ToString()); ;
                            //decimal eksik = Convert.ToDecimal(dtTeslimat.Rows[j]["EMENGE"].ToString());
                            decimal olmasiGereken = getMatnrCount(dtTeslimat.Rows[j]["MATNR"].ToString());

                            if (toplamMiktarGetir(dtTeslimat.Rows[j]["MATNR"].ToString()) != olmasiGereken)
                            {
                                MessageBox.Show("Sipariş miktarında uyumsuzluk var. Lütfen ürün miktarı ve toplanan miktar alanlarını kontrol ediniz. Malzeme No: " + dtTeslimat.Rows[j]["MATNR"].ToString() + "- Olması Gereken Toplam: " + olmasiGereken.ToString());
                                Cursor.Current = Cursors.Default;
                                return;
                            }

                            /*
                            dtUrunler[j] = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S002();
                            dtUrunler[j].MATNR = dtTeslimat.Rows[j]["MATNR"].ToString();
                            dtUrunler[j].TMENGE = toplanan;
                            dtUrunler[j].EMENGE = eksik;

                            dtUrunler[j].POSNR = dtTeslimat.Rows[j]["POSNR"].ToString();
                            dtUrunler[j].VBELN = dtTeslimat.Rows[j]["VBELN"].ToString();
                            byte nedenKod = 0;
                            if (dtTeslimat.Rows[j]["NEDEN_CODE"].ToString() != "")
                            {
                                nedenKod = Convert.ToByte(redNedeniDegeriGetir(dtTeslimat.Rows[j]["NEDEN_CODE"].ToString()));
                            }
                            dtUrunler[j].NEDEN_CODE = nedenKod;
                            dtUrunler[j].I_SET = dtTeslimat.Rows[j]["I_SET"].ToString();
                            */

                        }
                    }

                   


                    //Ürünler ilk tablodan referans alınarak gidecek urun listesine aktarılıyor
                    for (int i = 0; i < ZodendiBlg.Length; i++)
                    {
                        dtUrunler[i] = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_S002();
                        dtUrunler[i].EMENGE = 0;
                        dtUrunler[i].TMENGE = 0;
                        dtUrunler[i].I_SET = ZodendiBlg[i].I_SET.ToString();
                        dtUrunler[i].MATNR = ZodendiBlg[i].MATNR.ToString().TrimStart('0');
                        dtUrunler[i].NEDEN_CODE = "0";
                        dtUrunler[i].POSNR = ZodendiBlg[i].POSNR.ToString();
                        dtUrunler[i].VBELN = ZodendiBlg[i].VBELN.ToString();
                    }



                    //kontrolden geçen malzemeler ekleniyor
                    for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                    {
                        if (dtTeslimat.Rows[j]["MATNR"].ToString() != "")
                        {
                            decimal toplanan = Convert.ToDecimal(dtTeslimat.Rows[j]["MENGE"].ToString()); ;
                            decimal eksik = Convert.ToDecimal(dtTeslimat.Rows[j]["EMENGE"].ToString());


                            for (int i = 0; i < dtUrunler.Length; i++)
                            {
                                if (dtTeslimat.Rows[j]["MATNR"].ToString() == dtUrunler[i].MATNR.ToString())
                                {
                                    dtUrunler[i].TMENGE = toplanan;
                                    dtUrunler[i].EMENGE = eksik;
                                    string nedenKod = "0";
                                    if (dtTeslimat.Rows[j]["NEDEN_CODE"].ToString() != "")
                                    {
                                        nedenKod = redNedeniDegeriGetir(dtTeslimat.Rows[j]["NEDEN_CODE"].ToString());
                                    }
                                    dtUrunler[i].NEDEN_CODE = nedenKod;
                                    break;
                                }
                            }
                            
                        }
                    }

                    WS_UrunTeslim.SERVICE srv = new KoctasMobil.WS_UrunTeslim.SERVICE();
                    srv.Url = Utility.getWsUrl("zktmobil_urunteslim");
                    srv.Credentials = ProgramGlobalData.g_credential;

                    WS_UrunTeslim.ZKTMOBIL_ODENDIKAYIT odendiKayit = new KoctasMobil.WS_UrunTeslim.ZKTMOBIL_ODENDIKAYIT();

                    odendiKayit.IT_TESLIMAT = dtUrunler;
                    odendiKayit.ET_RETURN = new KoctasMobil.WS_UrunTeslim.ZKMOBIL_RETURN[0];

                    String sevkTimestampTemp = "";
                    if ((this.PARVW.IndexOf("ZX") != -1 || this.PARVW.IndexOf("ZY") != -1) && this.ISMKL.Trim().Equals("1"))
                    {
                        frm_UrunTeslimat_2_Timestamp frm = new frm_UrunTeslimat_2_Timestamp();
                        frm.ShowDialog();
                        sevkTimestampTemp = frm.timestamp;
                    } else {
                        sevkTimestampTemp = "19800101000000";
                    }

                    if (odendiKayit.IT_TESLIMAT != null && odendiKayit.IT_TESLIMAT.Length > 0)   // Eirsaliye mükellefiyse popup açtırıcaz ISMKL 1 donerse popup aç
                    {
                        for (int i = 0; i < odendiKayit.IT_TESLIMAT.Length; i++)
                        {
                            odendiKayit.IT_TESLIMAT[i].SEVKTIMESTAMP = Convert.ToDecimal(sevkTimestampTemp);
                        }
                    }
                    

                    WS_UrunTeslim.ZKTMOBIL_ODENDIKAYITResponse rsp = srv.ZKTMOBIL_ODENDIKAYIT(odendiKayit);

                    if (rsp.ET_RETURN[0].RC_CODE.ToString() == "E")
                    {
                        MessageBox.Show(rsp.ET_RETURN[0].RC_TEXT.ToString(), "HATA - SAP", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    MessageBox.Show("İşlem tamamlandı.", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

                    txtMalzemeAdi.Text = "";
                    txtEMenge.Text = "0";
                    cmbRedNeden.Text = "";
                    txtFormNo.Text = txtMatnrEan11.Text = txtMenge.Text = "";
                    dtTeslimat.Rows.Clear();
                    ZodendiBlg = null;
                    txtFormNo.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Formu kaydetmeden önce malzemeleri ekleyiniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }


            /*
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                bool FindIt = false;
                for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                {
                    if (dtTeslimat.Rows[j]["MATNR"].ToString() == ZodendiBlg[i].Matnr.TrimStart('0') &&
                        dtTeslimat.Rows[j]["MENGE"].ToString() == Convert.ToInt32(ZodendiBlg[i].Menge).ToString()
                        )
                        FindIt = true;
                }
                if (!FindIt)
                {
                    MessageBox.Show("Eksik ürün girişi yaptınız!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            */
        }

        private void txtMatnrEan11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Matnr = getMatnr(txtMatnrEan11.Text.Trim());

                if (Matnr == string.Empty)
                {
                    MessageBox.Show("Malzeme No bulunamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    return;
                }

                if (malzemeHizmetMi(Matnr) == true)
                {
                    MessageBox.Show("Eklemek istediğiniz malzeme hizmet olduğu için toplamanıza gerek yoktur.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    return;
                }

                if (malzemeSetMi(Matnr) == true)
                {
                    MessageBox.Show("Eklemek istediğiniz malzeme SET olduğu için bileşenlerini toplamalısınız. ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    return;
                }


                

                //Malzeme kalemi hizmet ise direkt olarak 
                txtMenge.Focus();
                txtMenge.SelectAll();
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private decimal eklenenMiktarBul(string Matnr)
        {
            decimal eklenenMiktar = 0;

            if (dtTeslimat.Rows.Count > 0)
            {
                for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                {
                    if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                    {
                        eklenenMiktar += Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]);
                        
                    }
                }
            }
            return eklenenMiktar;
        }

        private void txtEMenge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtFormNo.Text.Trim() == string.Empty && ZodendiBlg == null)
                {
                    MessageBox.Show("Form No alanı boş geçilemez.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtFormNo.Focus();
                    return;
                }

                if (txtMatnrEan11.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Malzeme No alanı boş geçilemez.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMatnrEan11.Focus();
                    return;
                }

                if (!isINT(txtMenge.Text.Trim()))
                {
                    MessageBox.Show("Miktar alanına sayısal bir değer giriniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }

                if (Convert.ToDecimal(txtMenge.Text.Trim()) < 0)
                {
                    MessageBox.Show("Toplanan miktar alanına - bir değer giremezsiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }

                if (!isINT(txtEMenge.Text.Trim()))
                {
                    MessageBox.Show("Eksik miktar alanına sayısal bir değer giriniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtEMenge.Text = "0";
                    txtEMenge.Focus();
                    txtEMenge.SelectAll();
                    return;
                }

                if (Convert.ToDecimal(txtEMenge.Text.Trim()) < 0)
                {
                    MessageBox.Show("Eksik miktar alanına - bir değer giremezsiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtEMenge.Text = "0";
                    txtMenge.Focus();
                    txtMenge.SelectAll();
                    return;
                }

                if (Convert.ToDecimal(txtEMenge.Text) > 0)
                {
                    if (cmbRedNeden.Text == "")
                    {
                        MessageBox.Show("Eksik miktar için red nedeni seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        cmbRedNeden.Focus();
                        return;
                    }
                }

                //normal sipariş tablosu kontrol edilyor
                if (ZodendiBlg != null)
                {
                    bool isExists = false;
                    bool isSet = false;
                    string setMatnr = "";

                    //Normal ürünler içerisinde aranıyor
                    for (int i = 0; i < ZodendiBlg.Length; i++)
                    {
                        if (ZodendiBlg[i].MATNR.TrimStart('0') == Matnr)
                        {
                            isExists = true;
                        }

                    }

                    //Eğer normal sipariş listesinde yok ise, set ürünler listesinde aranıyor
                    if (!isExists)
                    {
                        for (int i = 0; i < ZodendiSet.Length; i++)
                        {
                            if (ZodendiSet[i].IDNRK.TrimStart('0') == Matnr)
                            {
                                isSet = true;
                                setMatnr = ZodendiSet[i].MATNR.TrimStart('0');
                            }

                        }
                    }

                    if (isExists)
                    {
                        //int txtMengeCount = Convert.ToInt32(txtMenge.Text.Trim());
                        decimal txtMengeCount = Convert.ToDecimal(txtMenge.Text.Trim());
                        decimal txtEMengeCount = Convert.ToDecimal(txtEMenge.Text.Trim());
                        decimal eklenenMiktar = eklenenMiktarBul(Matnr);
                        decimal TotalCount = getMatnrCount(Matnr);



                        if ((txtMengeCount + txtEMengeCount + eklenenMiktar) > TotalCount)
                        {
                            MessageBox.Show("Fazla ürün girişi yapılamaz! Daha Önce Eklenen Miktar: " + eklenenMiktar.ToString() + ", Mak. Eklenebilir Miktar:" + (TotalCount - eklenenMiktar).ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            txtEMenge.Text = "0";
                            txtMenge.Text = "";
                            txtMenge.Focus();
                            txtMenge.SelectAll();
                            return;
                        }

                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                            {
                                decimal dtTeslimatCount = Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]);
                                decimal dtTeslimatECount = Convert.ToDecimal(dtTeslimat.Rows[i]["EMENGE"]);

                                dtTeslimat.Rows[i]["MENGE"] = dtTeslimatCount + txtMengeCount;
                                
                                //Eğer toplanan malzeme adedi tamam ise, eksik sıfırlanır.
                                if ((dtTeslimatCount + txtMengeCount) == TotalCount)
                                {
                                    dtTeslimat.Rows[i]["EMENGE"] = "0";
                                    dtTeslimat.Rows[i]["NEDEN_CODE"] = "";
                                }
                                else
                                {
                                    dtTeslimat.Rows[i]["EMENGE"] = txtEMengeCount;
                                    string nedenKodTanim = "";
                                    if (Convert.ToDecimal(txtEMenge.Text) > 0)
                                    {
                                        nedenKodTanim = cmbRedNeden.Items[cmbRedNeden.SelectedIndex].ToString();
                                    }
                                    dtTeslimat.Rows[i]["NEDEN_CODE"] = nedenKodTanim;
                                }

                                /*
                                if ((dtTeslimatCount + dtTeslimatECount) + (txtMengeCount + txtEMengeCount) > TotalCount)
                                {
                                    MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                                    txtEMenge.Text = "0";
                                    txtMenge.Text = ""; txtMenge.Focus(); txtMenge.SelectAll(); return;
                                }
                                else
                                {
                                    dtTeslimat.Rows[i]["MENGE"] = dtTeslimatCount + txtMengeCount;
                                    dtTeslimat.Rows[i]["EMENGE"] = dtTeslimatECount + txtEMengeCount;
                                }*/

                                txtEMenge.Text = "0";
                                txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                                cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                                return;
                            }
                        }

                        DataRow dr = dtTeslimat.NewRow();
                        dr["VBELN"] = formNo.ToString();
                        dr["POSNR"] = getMatnrPosNr(Matnr);
                        dr["MATNR"] = Matnr;
                        dr["MAKTX"] = txtMalzemeAdi.Text;
                        dr["EMENGE"] = txtEMenge.Text.Trim();
                        dr["MENGE"] = txtMenge.Text.Trim();
                        string nedenKod = "";
                        if (Convert.ToDecimal(txtEMenge.Text) > 0)
                        {
                            nedenKod = cmbRedNeden.Items[cmbRedNeden.SelectedIndex].ToString();
                        }
                        dr["NEDEN_CODE"] = nedenKod;
                        dr["I_SET"] = "";
                        dr["PSTYV"] = ""; //Sonradan kontrol edilecek....
                        dtTeslimat.Rows.Add(dr);

                        grdUrunTeslimat.DataSource = dtTeslimat;
                        cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                        Matnr = txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = "";
                        txtEMenge.Text = "0"; 
                        txtMatnrEan11.Focus();
                    }
                    //Eger urun set urun ise
                    else if (isSet)
                    {

                        bool setMasterOk = false;

                        //Urun set olarak gelmiş ve set master urunu listeye eklenmiş mi kontrol ediliyor
                        //setMatnr
                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == setMatnr)
                            {
                                setMasterOk = true;
                            }
                        }
                        if (!setMasterOk)
                        {
                            MessageBox.Show("Set ürüne ait bir kalem eklemeden önce set ürünün kendisini eklemelisiniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                            txtMalzemeAdi.Text = txtMatnrEan11.Text = "";
                            txtEMenge.Text = "0";
                            txtMenge.Text = ""; txtMatnrEan11.Focus();
                            return;
                        }

                        decimal txtMengeCount = Convert.ToDecimal(txtMenge.Text.Trim());
                        decimal txtEMengeCount = Convert.ToDecimal(txtEMenge.Text.Trim());
                        //set içindeki malzemenin birim miktarı
                        decimal TotalCount = getSetMatnrCount(Matnr);

                        if ((txtMengeCount + txtEMengeCount) > TotalCount)
                        {
                            MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            txtEMenge.Text = "0";
                            txtMenge.Text = "";
                            txtMenge.Focus();
                            txtMenge.SelectAll();
                            return;
                        }



                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                            {
                                decimal dtTeslimatCount = Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]);
                                decimal dtTeslimatECount = Convert.ToDecimal(dtTeslimat.Rows[i]["EMENGE"]);

                                if ((dtTeslimatCount + dtTeslimatECount) + (txtMengeCount + txtEMengeCount) > TotalCount)
                                {
                                    MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                                    txtEMenge.Text = "0";
                                    txtMenge.Text = "";
                                    txtMenge.Focus();
                                    txtMenge.SelectAll();
                                    return;
                                }
                                else
                                {
                                    dtTeslimat.Rows[i]["MENGE"] = dtTeslimatCount + txtMengeCount;
                                    dtTeslimat.Rows[i]["EMENGE"] = dtTeslimatECount + txtEMengeCount;

                                }
                                cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                                txtMalzemeAdi.Text = txtMatnrEan11.Text = "";

                                txtEMenge.Text = "";
                                txtMenge.Text = ""; txtMatnrEan11.Focus();
                                return;
                            }
                        }

                        DataRow dr = dtTeslimat.NewRow();
                        dr["VBELN"] = formNo.ToString();
                        dr["MATNR"] = Matnr;
                        dr["MAKTX"] = txtMalzemeAdi.Text;
                        dr["EMENGE"] = txtEMenge.Text.Trim();
                        dr["MENGE"] = txtMenge.Text.Trim();
                        string nedenKod = "";
                        if (Convert.ToDecimal(txtEMenge.Text) > 0)
                        {
                            nedenKod = cmbRedNeden.Items[cmbRedNeden.SelectedIndex].ToString();
                        }
                        dr["NEDEN_CODE"] = nedenKod;
                        dr["I_SET"] = "X";
                        dr["PSTYV"] = "";  //Sonradan kontrol edilecek
                        string setMaster = getMatnrFromSet(Matnr);
                        dr["POSNR"] = getMatnrPosNr(setMaster);

                        dtTeslimat.Rows.Add(dr);

                        grdUrunTeslimat.DataSource = dtTeslimat;
                        cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                        txtMalzemeAdi.Text = txtMatnrEan11.Text = "";
                        txtEMenge.Text = "0";
                        txtMenge.Text = ""; txtMatnrEan11.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ürün listede mevcut değil!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        cmbRedNeden.SelectedValue = cmbRedNeden.Text = cmbRedNeden.Text = "";
                        txtMalzemeAdi.Text = txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    }
                }
            }
        }

        private void txtEMenge_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRedNeden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtEMenge_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
            }
        }

        private void txtFormNo_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}