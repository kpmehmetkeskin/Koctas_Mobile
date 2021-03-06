using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Web.Services.Protocols;

namespace KoctasMobil
{
    public partial class frm_malgiris : Form
    {
        public DataTable tbl_Irsaliye;
        public DataTable tbl_Siparisler;
        public DataTable tbl_Malzeme;
        public DataTable tbl_Topla;
        
        
        public frm_malgiris()
        {
            InitializeComponent();
        }
        private void FIT_GoodsIssue_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtp_belge.Format = DateTimePickerFormat.Custom;
            dtp_belge.CustomFormat = "dd-MM-yyyy";

            dtp_kayit.Format = DateTimePickerFormat.Custom;
            dtp_kayit.CustomFormat = "dd-MM-yyyy";


            //Tablo tanımlamaları yapılıyor
            tbl_Irsaliye = new DataTable();

            DataColumn autoColumn1 = new DataColumn("ID", typeof(Int32));
            autoColumn1.AutoIncrement = true;
            autoColumn1.AutoIncrementSeed = 1;
            autoColumn1.AutoIncrementStep = 1;

            tbl_Irsaliye.Columns.Add(autoColumn1);
            tbl_Irsaliye.Columns.Add("irsaliyeNo");
            tbl_Irsaliye.Columns.Add("belgeTarihi", typeof(DateTime));
            tbl_Irsaliye.Columns.Add("kayitTarihi", typeof(DateTime));
            tbl_Irsaliye.Columns.Add("sapAktar");

            
            tbl_Malzeme = new DataTable();
            DataColumn autoColumn2 = new DataColumn("ID", typeof(Int32));
            autoColumn2.AutoIncrement = true;
            autoColumn2.AutoIncrementSeed = 1;
            autoColumn2.AutoIncrementStep = 1;

            tbl_Malzeme.Columns.Add("siparisNo");
            tbl_Malzeme.Columns.Add("irsaliyeNo");
            tbl_Malzeme.Columns.Add("Amenge", typeof(decimal));
            tbl_Malzeme.Columns.Add("Ean11");
            tbl_Malzeme.Columns.Add("Ean112");
            tbl_Malzeme.Columns.Add("Ebeln");
            tbl_Malzeme.Columns.Add("Ebelp");
            tbl_Malzeme.Columns.Add("Lgort");
            tbl_Malzeme.Columns.Add("Maktx");
            tbl_Malzeme.Columns.Add("Matnr");
            tbl_Malzeme.Columns.Add("Meins");
            tbl_Malzeme.Columns.Add("Menge", typeof(decimal));
            tbl_Malzeme.Columns.Add("Werks");
            tbl_Malzeme.Columns.Add("Umrez", typeof(decimal));
            tbl_Malzeme.Columns.Add("Umren", typeof(decimal));
            tbl_Malzeme.Columns.Add("Lmein");



            tbl_Siparisler = new DataTable();

            DataColumn autoColumn3 = new DataColumn("ID", typeof(Int32));
            autoColumn3.AutoIncrement = true;
            autoColumn3.AutoIncrementSeed = 1;
            autoColumn3.AutoIncrementStep = 1;

            tbl_Siparisler.Columns.Add(autoColumn3);
            tbl_Siparisler.Columns.Add("irsaliyeNo");
            tbl_Siparisler.Columns.Add("siparisNo");

            tbl_Topla = new DataTable();

            DataColumn autoColumn4 = new DataColumn("ID", typeof(Int32));
            autoColumn4.AutoIncrement = true;
            autoColumn4.AutoIncrementSeed = 1;
            autoColumn4.AutoIncrementStep = 1;

            tbl_Topla.Columns.Add(autoColumn4);
            tbl_Topla.Columns.Add("matnr");
            tbl_Topla.Columns.Add("maktx");
            tbl_Topla.Columns.Add("S");
            tbl_Topla.Columns.Add("menge", typeof(decimal));
            tbl_Topla.Columns.Add("meins");
            tbl_Topla.Columns.Add("ebeln");
            tbl_Topla.Columns.Add("werks");
            tbl_Topla.Columns.Add("ebelp");
            tbl_Topla.Columns.Add("lgort");
            tbl_Topla.Columns.Add("Amenge");
            tbl_Topla.Columns.Add("irsaliyeNo");
            tbl_Topla.Columns.Add("irsaliyeMiktar");
            tbl_Topla.Columns.Add("hasarMiktar");
            tbl_Topla.Columns.Add("eksikMiktar");
   

            cmb_IrsNo.Focus();

        }

        
        
        ArrayList materials = new ArrayList();
        WS_Satis.ZkmobilMatlist[] sas_fs = new KoctasMobil.WS_Satis.ZkmobilMatlist[1000];
        int lenght = 0;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            int kayitSay = 0;

            if (tbl_Irsaliye.Rows.Count > 0)
            {
                DataRow[] rows = tbl_Irsaliye.Select("sapAktar = '0'");
                kayitSay = rows.Length;
                
            }
            if (kayitSay > 0)
            {
                if (MessageBox.Show("SAP'ye göndermediğiniz irsaliye tanımınız var, yine de çıkmak istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Siparis_Click(object sender, EventArgs e)
        {

            string irsaliyeNo = cmb_IrsNo.Text;
            dt_IrsaliyeKaydiGuncelle(irsaliyeNo);
            
            if (lst_Siparis.Items.Count == 0 || cmb_IrsNo.Text.Trim() == "")
            {
                return;
            }
            try
            {
                frm_Malgiris1 frm = new frm_Malgiris1();
                frm.tbl_Irsaliye = tbl_Irsaliye;
                frm.tbl_Siparisler = tbl_Siparisler;
                frm.tbl_Malzeme = tbl_Malzeme;
                frm.tbl_Topla = tbl_Topla;
                frm.gecerliIrsaliyeNo = irsaliyeNo;
                frm.gecerliBelgeTarihi = dtp_belge.Value;
                frm.gecerliKayitTarihi = dtp_kayit.Value;
                
                frm.ShowDialog();

                //Formdan dönen değerler alınıyor
                tbl_Topla = frm.tbl_Topla;
                tbl_Irsaliye = frm.tbl_Irsaliye;

                irsaliyeListesiDoldur(irsaliyeNo);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dt_IrsaliyeKaydiGoster(cmb_IrsNo.Text);

            DataRow[] rows = tbl_Irsaliye.Select("sapAktar = '0'");
            int kayitSay = rows.Length;
            if (kayitSay == 0) this.Close();
             
        }

        private void btn_SiparisEkle_Click(object sender, EventArgs e)
        {
            string irsaliyeNo = cmb_IrsNo.Text;
            string siparisNo = txt_sas.Text.Trim();

            dt_IrsaliyeKaydiGuncelle(irsaliyeNo);

            if (siparisNo == "") return;

            if (irsaliyeNo == "")
            {
                MessageBox.Show("Sipariş no girişi yapmadan önce irsaliye eklemelisiniz");
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                WS_Satis.service srv = new KoctasMobil.WS_Satis.service();
                WS_Satis.ZkmobilMatlist[] matlist = new KoctasMobil.WS_Satis.ZkmobilMatlist[0];
                WS_Satis.ZkmobilReturn[] ret = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                WS_Satis.ZktmobilMgCheckSas sas = new KoctasMobil.WS_Satis.ZktmobilMgCheckSas();
                WS_Satis.ZktmobilMgCheckSasResponse resp = new KoctasMobil.WS_Satis.ZktmobilMgCheckSasResponse();

                
                sas.TeMatlist = matlist;
                sas.TeReturn = ret;
                sas.IEbeln = siparisNo; 

                //System.Net.NetworkCredential cr = new System.Net.NetworkCredential("berk", "Burak980");
                //srv.Credentials = cr;

                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_satis");
                resp = srv.ZktmobilMgCheckSas(sas);

          

                // Eger SAS kontrolu sonrasında siparis kaydi DEPO'ya ait bir 
                // kayıt ise, depo formu üzerinden giriş yapılması bekleniyor
                
                if (resp.ExType1 == "1")
                {
                    MessageBox.Show("Bu sipariş için 'Depo Lojistik' formunu kullanmalısınız.", "HATA");
                } 
                else  if (resp.TeReturn.Length > 0)
                {
                    if (resp.TeReturn[0].RcCode.ToUpper() == "S" && resp.TeMatlist.Length > 0)
                    {
                        
                        //Sipariş No ilgili irsaliyeye ekleniyor
                        //Sipariş daha önce ilgili irsaliyeye eklenmiş mi?
                        if (dt_SiparisIrsaliyedeVarMi(irsaliyeNo, siparisNo) == false)
                        {
                            DataRow rowS = tbl_Siparisler.NewRow();
                            rowS["irsaliyeNo"] = irsaliyeNo;
                            rowS["siparisNo"] = siparisNo;
                            tbl_Siparisler.Rows.Add(rowS);
                        }
                        else
                        {
                            MessageBox.Show("Bu sipariş ilgili irsaliyede zaten var.", "HATA");
                        }
                        
                        
                        //Bulunan malzemeler tabloya alınıyor
                        //Daha önce alınmış mı?
                        if (dt_SiparisMalzemeleriAlindiMi(irsaliyeNo, siparisNo) == false)
                        {
                            for (int i = 0; i < resp.TeMatlist.Length; i++)
                            {
                                DataRow row = tbl_Malzeme.NewRow();
                                row["siparisNo"] = resp.TeMatlist[i].Ebeln.ToString();
                                row["irsaliyeNo"] = irsaliyeNo;
                                row["Amenge"] = resp.TeMatlist[i].Amenge;
                                row["Ean11"] = resp.TeMatlist[i].Ean11.ToString();
                                row["Ean112"] = resp.TeMatlist[i].Ean112.ToString();
                                row["Ebeln"] = resp.TeMatlist[i].Ebeln.ToString();
                                row["Ebelp"] = resp.TeMatlist[i].Ebelp.ToString();
                                row["Lgort"] = resp.TeMatlist[i].Lgort.ToString();
                                row["Maktx"] = resp.TeMatlist[i].Maktx.ToString();
                                row["Matnr"] = resp.TeMatlist[i].Matnr.ToString();
                                row["Meins"] = resp.TeMatlist[i].Meins.ToString();
                                row["Menge"] = resp.TeMatlist[i].Menge;
                                row["Werks"] = resp.TeMatlist[i].Werks.ToString();
                                //row["Ckats"] = resp.TeMatlist[i].Ckats;
                                row["Lmein"] = resp.TeMatlist[i].Lmein.ToString();
                                row["Umrez"] = resp.TeMatlist[i].Umrez;
                                row["Umren"] = resp.TeMatlist[i].Umren;


                                tbl_Malzeme.Rows.Add(row);

                                

                            }
                        }

                        tbl_Malzeme.AcceptChanges();
                        txt_sas.Text = "";
                        siparisListesiDoldur(irsaliyeNo);
                    }
                    else
                    {
                        txt_sas.Text = "";
                        MessageBox.Show(resp.TeReturn[0].RcText, "HATA");
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "HATA");
            }
        }

        private void txt_sas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_SiparisEkle_Click(new object(), new EventArgs());
            }
        }

        private void txt_irsNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        

        private void pictureButton1_Click(object sender, EventArgs e)
        {

            string irsaliyeNo = cmb_IrsNo.Text;
            dt_IrsaliyeKaydiGuncelle(irsaliyeNo);

            frm_InputBox frm = new frm_InputBox();
            frm.title = "İrsaliye No Girişi";
            frm.msg = "Eklemek istediğiniz irsaliye numarasını giriniz";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                irsaliyeNo = frm.deger;
                if (cmb_IrsNo.Items.Contains(irsaliyeNo))
                {
                    MessageBox.Show("Girmiş olduğunuz irsaliye numarası zaten listede var.");
                    return;
                }
                else
                {
                    dt_IrsaliyeKaydiEkle(irsaliyeNo);
                    irsaliyeListesiDoldur(irsaliyeNo);
                   
                    

                    txt_sas.Focus();
                }

            }
        }

        private void irsaliyeListesiDoldur(string irsaliyeNo)
        {
            cmb_IrsNo.Items.Clear();
            if (tbl_Irsaliye.Rows.Count > 0)
            {
                for (int i = 0; i < tbl_Irsaliye.Rows.Count; i++)
                {
                    if (tbl_Irsaliye.Rows[i]["sapAktar"].ToString() == "0")
                    {
                        cmb_IrsNo.Items.Add(tbl_Irsaliye.Rows[i]["irsaliyeNo"].ToString());
                    }
                }
            }

            if (irsaliyeNo != "") 
            {
                cmb_IrsNo.SelectedValue = irsaliyeNo;
                cmb_IrsNo.SelectedItem = irsaliyeNo;
            }
        }
        //sapAktar



        //DataTable fonksiyonları
        /*
        private int dt_SonIdGetir(DataTable dt)
        {
            int sonKayitId = 0;

            if (dt.Rows.Count > 0)
            {
                DataRow sonSatir = dt.Rows[dt.Rows.Count - 1];
                sonKayitId = (int)sonSatir["ID"];
            }

            return sonKayitId;
        }*/
        
        //DataTable'a irsaliye kaydını ekler
        private void dt_IrsaliyeKaydiEkle(string irsaliyeNo)
        {
            try
            {
                DataRow row = tbl_Irsaliye.NewRow();
                row["irsaliyeNo"] = irsaliyeNo;
                row["belgeTarihi"] = DateTime.Today;
                row["kayitTarihi"] = DateTime.Today;
                row["sapAktar"] = "0";
                tbl_Irsaliye.Rows.Add(row);
                tbl_Irsaliye.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DataTable'a irsaliye kaydını günceller
        private void dt_IrsaliyeKaydiGuncelle(string irsaliyeNo)
        {
            if (irsaliyeNo == "") return;
            try
            {
                if (tbl_Irsaliye.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Irsaliye.Rows.Count; i++)
                    {
                        if (tbl_Irsaliye.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo)
                        {
                            tbl_Irsaliye.Rows[i]["belgeTarihi"] = dtp_belge.Value;
                            tbl_Irsaliye.Rows[i]["kayitTarihi"] = dtp_kayit.Value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //irsaliye numarası verilen kaydın tablo kayıt id'sini döndürür
        private int dt_IrsaliyeKayitIdGetir(string irsaliyeNo)
        {
            int ret = 0;
            if (irsaliyeNo == "") return ret;
            try
            {
                if (tbl_Irsaliye.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Irsaliye.Rows.Count; i++)
                    {
                        if (tbl_Irsaliye.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo)
                        {
                            ret = Convert.ToInt32(tbl_Irsaliye.Rows[i]["ID"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ret;
        }

        //Seçilen irsaliye kaydını formda gösterir.
        private void dt_IrsaliyeKaydiGoster(string irsaliyeNo)
        {
            try
            {
                txt_sas.Enabled = false;
                btn_SiparisEkle.Enabled = false;

                if (tbl_Irsaliye.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Irsaliye.Rows.Count; i++)
                    {
                        if (tbl_Irsaliye.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo)
                        {
                            //dtp_belge.Value = DateTime.Today;
                            //dtp_kayit.Value = DateTime.Today;
                            if (tbl_Irsaliye.Rows[i]["belgeTarihi"].ToString() != "")
                                dtp_belge.Value = Convert.ToDateTime(tbl_Irsaliye.Rows[i]["belgeTarihi"].ToString());
                            if (tbl_Irsaliye.Rows[i]["kayitTarihi"].ToString() != "")
                                dtp_kayit.Value = Convert.ToDateTime(tbl_Irsaliye.Rows[i]["kayitTarihi"].ToString());
                            

                            //Sipariş listesi gösteriliyor
                            siparisListesiDoldur(irsaliyeNo);

                            //Seçilen irsaliye geçerli ise butonlar sipariş ekleme aktif ediliyor
                            txt_sas.Enabled = true;
                            btn_SiparisEkle.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmb_IrsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string irsaliyeNo = cmb_IrsNo.Text;
            dt_IrsaliyeKaydiGoster(irsaliyeNo);
        }

        //Seçilen irsaliye numarasına göre irsaliye listesini doldurur.
        private void siparisListesiDoldur(string irsaliyeNo)
        {
            try
            {
                lst_Siparis.Items.Clear();

                
                if (tbl_Siparisler.Rows.Count > 0)
                {
                    DataRow[] rows = tbl_Siparisler.Select("irsaliyeNo = '" + irsaliyeNo + "'");

                    foreach (DataRow row in rows)
                    {
                        if (lst_Siparis.Items.Contains(row["siparisNo"].ToString()) == false)
                        {
                            lst_Siparis.Items.Insert(0, row["siparisNo"].ToString());
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
                
        }



        //İrsaliye ile Sipariş No daha önce ilişkilendirilmiş mi?
        private bool dt_SiparisIrsaliyedeVarMi(string irsaliyeNo, string siparisNo)
        {
            bool ret = false;

            try
            {
                
                if (tbl_Siparisler.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Siparisler.Rows.Count; i++)
                    {
                        if ((tbl_Siparisler.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo) && (tbl_Siparisler.Rows[i]["siparisNo"].ToString() == siparisNo))
                        {
                            ret = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        //Sipariş No'daki malzemeler daha önce malzeme tablosuna eklenmiş mi?
        private bool dt_SiparisMalzemeleriAlindiMi(string irsaliyeNo, string siparisNo)
        {
            bool ret = false;

            try
            {

                if (tbl_Malzeme.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Malzeme.Rows.Count; i++)
                    {
                        //if (tbl_Malzeme.Rows[i]["siparisNo"].ToString() == siparisNo)
                        if ((tbl_Malzeme.Rows[i]["siparisNo"].ToString() == siparisNo) && (tbl_Malzeme.Rows[i]["irsaliyeNo"].ToString() == siparisNo))
                        {
                            ret = true;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }



        private void frm_malgiris_Closing(object sender, CancelEventArgs e)
        {
            
            
        }

        private void dtp_belge_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp_kayit_ValueChanged(object sender, EventArgs e)
        {
            
        }



    }
}