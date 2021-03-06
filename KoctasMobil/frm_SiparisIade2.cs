using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SiparisIade2 : Form
    {

        public bool ShouldSerializeZTime()
        {
            return false;
        }
        
        public frm_SiparisIade2()
        {
            InitializeComponent();
        }

        KoctasMobil.WS_Satis.ZktmobilSIadeItems[] _items = new KoctasMobil.WS_Satis.ZktmobilSIadeItems[0];
        
        private void frm_SiparisIade2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lst_items.Columns[0].Width = 95;
            lst_items.Columns[1].Width = 140;
            lst_items.Columns[2].Width = 40;
            lst_items.Columns[3].Width = 44;
            lst_items.Columns[4].Width = 1;
            foreach (KoctasMobil.WS_Satis.ZktmobilSIadeItems item in _items)
	        {
                try
                {
                    ListViewItem li = new ListViewItem(new string[] { item.Matnr, item.Maktx, "0", item.Menge.ToString("0.##"), item.Posnr});
                    lst_items.Items.Add(li);
                }
                catch (Exception ex)
                {
                    
                }        		
	        }            
        }

        public KoctasMobil.WS_Satis.ZktmobilSIadeItems[] Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private void lst_items_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                frm_IadeTipi frm = new frm_IadeTipi();
                frm.Location = new Point(60, 88);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (frm.Iade > _items[e.Index].Menge )
                        {
                            MessageBox.Show("İade miktarı satış miktarından büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            e.NewValue = CheckState.Unchecked;
                            return;
                        }
                        _items[e.Index].Iade = frm.Iade;
                        lst_items.Items[e.Index].SubItems[2].Text = frm.Iade.ToString("0.##");
                        _items[e.Index].Sel = "X";
                        _items[e.Index].CancelDate = DateTime.Now.ToString("yyyy-MM-dd");
                        _items[e.Index].CancelTime = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")); //WS içindeki CancelTime değeri Refence.cs içinde string olarak ezilmiştir.

                        switch (frm.Iadetipi)
                        {
                            case "S":
                                _items[e.Index].S = "X";
                                break;
                            case  "R":
                                _items[e.Index].R = "X";
                                break;
                            case "T":
                                _items[e.Index].T = "X";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {                        
                    }
                }
                else
                {
                    e.NewValue = CheckState.Unchecked ;
                    try
                    {
                        _items[e.Index].Sel = "";
                    }
                    catch { }
                }
                try
                {
                    CalculateTotal();
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                try
                {
                    _items[e.Index].Sel = "";
                }
                catch { }
            }
        }

        private void CalculateTotal()
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
            WS_Satis.ZktmobilCalcTotalAmount amount = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmount();
            WS_Satis.ZktmobilCalcTotalAmountResponse response = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmountResponse();
            SRV.Url = Utility.getWsUrl("zktmobil_satis");SRV.Credentials = ProgramGlobalData.g_credential;
            int i = 0;
            amount.TiList = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate[lst_items.Items.Count];
            foreach (ListViewItem  item in lst_items.Items)
            {
                amount.TiList[i] = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate();
                amount.TiList[i].Matnr = item.Text;
                amount.TiList[i].Menge = Convert.ToDecimal(item.SubItems[2].Text);
                i++;
            }
            response = SRV.ZktmobilCalcTotalAmount(amount);
            txt_toplamTutar.Text = response.ETotal.ToString() + " TL";
            Cursor.Current = Cursors.Default;
        }

        private void btn_SatisIade_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
                WS_Satis.ZktmobilIade iade = new KoctasMobil.WS_Satis.ZktmobilIade();
                WS_Satis.ZktmobilIadeResponse response = new KoctasMobil.WS_Satis.ZktmobilIadeResponse();
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                iade.TeList = _items;
                iade.IVbeln = _items[0].Vbeln;
                response = SRV.ZktmobilIade(iade);
                Cursor.Current = Cursors.Default;
                if (response.EReturn.RcCode == "S")
                {
                    this.DialogResult = DialogResult.OK;  
                }
                else
                {
                    throw new Exception(response.EReturn.RcText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_toplamTutar_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void lst_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}