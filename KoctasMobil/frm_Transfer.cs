using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_Transfer : Form
    {
        public frm_Transfer()
        {
            InitializeComponent();
        }

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRafAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Transfer_Click(txtBelgeNo, new EventArgs());
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text.Trim() == "")
                return;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service SRV = new WS_Stok.service();

                SRV.Url = Utility.getWsUrl("zktmobil_stok");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Stok.ZktmobilChckPo Po = new WS_Stok.ZktmobilChckPo();
                Po.ImEbeln = txtBelgeNo.Text.Trim();
                Po.ItTrns =new WS_Stok.ZktmobilTrans[0];

                WS_Stok.ZktmobilChckPoResponse Response = SRV.ZktmobilChckPo(Po);


                if (Response.EReturn.Length > 0)
                {
                    if (Response.EReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(Response.EReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                else if (Response.ItTrns.Length == 0)
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
                else
                {
                    DataTable dt_mal = new DataTable();
                    dt_mal.Columns.Add("Ebeln");
                    dt_mal.Columns.Add("Ebelp");
                    dt_mal.Columns.Add("Maktx");
                    dt_mal.Columns.Add("Matnr");
                    dt_mal.Columns.Add("Meins");
                    dt_mal.Columns.Add("Menge");
                    dt_mal.Columns.Add("Tmenge");

                    foreach (WS_Stok.ZktmobilTrans trans in Response.ItTrns)
                    {
                        DataRow row = dt_mal.NewRow();
                        row["Ebeln"] = trans.Ebeln;
                        row["Ebelp"] = trans.Ebelp;
                        row["Maktx"] = trans.Maktx;
                        row["Matnr"] = trans.Matnr;
                        row["Meins"] = trans.Meins;
                        row["Menge"] = trans.Menge;
                        row["Tmenge"] = trans.Tmenge;

                        dt_mal.Rows.Add(row);
                    }
                    
                    
                    
                    Cursor.Current = Cursors.Default;
                    frm_Transfer2 frm = new frm_Transfer2(dt_mal);
                    frm.ShowDialog();
                    
                    if (frm.DialogResult == DialogResult.OK)
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

        private void frm_Transfer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        
    }
}