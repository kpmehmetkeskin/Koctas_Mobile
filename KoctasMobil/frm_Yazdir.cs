using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_Yazdir : Form
    {
        public frm_Yazdir()
        {
            InitializeComponent();
        }
        DataTable dt_siparis = new DataTable();
        private void frm_Yazdir_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
            WS_Satis.ZktmobilGetOrdersListPrint printlist = new KoctasMobil.WS_Satis.ZktmobilGetOrdersListPrint();
            WS_Satis.ZktmobilGetOrdersListPrintResponse response = new KoctasMobil.WS_Satis.ZktmobilGetOrdersListPrintResponse();
            try
            {
                WS_Satis.ZktmobilOrders[] orders = new KoctasMobil.WS_Satis.ZktmobilOrders[0];
                printlist.TeOrders = orders;
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                response = SRV.ZktmobilGetOrdersListPrint(printlist);

                foreach (WS_Satis.ZktmobilOrders var in response.TeOrders)
                {
                    lv_siparis.Items.Add(new ListViewItem(new string[] { var.Vbeln, var.Auzeit.ToString("HH:mm") }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            WS_Satis.service SRV = new KoctasMobil.WS_Satis.service();
            WS_Satis.ZktmobilPrintOrders orders = new KoctasMobil.WS_Satis.ZktmobilPrintOrders();
            WS_Satis.ZktmobilPrintOrdersResponse response = new KoctasMobil.WS_Satis.ZktmobilPrintOrdersResponse();
            try
            {
                orders.TiOrders = new KoctasMobil.WS_Satis.ZktmobilOrders[lv_siparis.Items.Count];

                int sayac = 0;
                for (int i = 0; i < lv_siparis.Items.Count; i++)
                {
                    if (lv_siparis.Items[i].Checked)
                    {
                        orders.TiOrders[sayac] = new KoctasMobil.WS_Satis.ZktmobilOrders();
                        orders.TiOrders[sayac].Vbeln = lv_siparis.Items[i].SubItems[0].Text;
                        sayac++;
                    }
                }

                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                response = SRV.ZktmobilPrintOrders(orders);
                MessageBox.Show("Siparişler yazıcıya gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }            
        }
    }
}