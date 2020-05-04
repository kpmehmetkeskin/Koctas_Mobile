using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class FixProductList : Form
    {
        private DataTable dt_fix_mal;
        private String sevkNo, kayitTarihi;

        public FixProductList(String sevkNo,String kayitTarihi)
        {
            InitializeComponent();
            this.sevkNo = sevkNo;
            this.kayitTarihi = kayitTarihi;
        }

        private void FIX_Malgiris_Load(object sender, EventArgs e)
        {
            dt_fix_mal = new DataTable();
            dt_fix_mal.Columns.Add("EBELN");
            dt_fix_mal.Columns.Add("EBELP");
            dt_fix_mal.Columns.Add("MATNR");
            dt_fix_mal.Columns.Add("SMENGE");
            dt_fix_mal.Columns.Add("AMENGE");
            dt_fix_mal.Columns.Add("MEINS");
            dt_fix_mal.Columns.Insert(0, checkBoxColumn);
            this.WindowState = FormWindowState.Maximized;
                 
        }

        private void paletMalKabulVerileriniGetir(){
            WS_Palet.Z_EWM_PALETLI_MAL_KABUL_OKU paletMalKabulOkuServis = new WS_Palet.Z_EWM_PALETLI_MAL_KABUL_OKU();
            WS_Palet.ZEWM_ST_PALET_MAL_KABUL paletMalKabul = WS_Palet.ZEWM_ST_PALET_MAL_KABUL();
            paletMalKabul.I_SEVKNO = sevkNo;
            WS_Palet.Z_EWM_PALETLI_MAL_KABUL_OKUResponse paletMalKabulOkuResponse = WS_Palet.Z_EWM_PALETLI_MAL_KABUL_OKUResponse();
            if (resp.TeReturn.Length > 0)
            {
                if (paletMalKabulOkuResponse.ET_RETURN[0].GetType.ToUpper() == "S")
                {
                    foreach (WS_Palet.ZEWM_ST_PALET_MAL_KABUL mal in paletMalKabulOkuResponse.ET_LIST){
                            DataRow row = dt_fix_mal.NewRow();
                            row["EBELN"] = mal.EBELN;
                            row["EBELP"] = mal.EBELP;
                            row["MATNR"] = mal.MATNR;
                            row["SMENGE"] = mal.SMENGE;
                            row["AMENGE"] = mal.AMENGE;
                            row["MEINS"] = mal.MEINS;
                            dt_fix_mal.Rows.Add(row);
                         }
                }
                else
                {
                    MessageBox.Show(resp.TeReturn[0].RcText);
                    this.Close();
                }
            }

        }

        private void btn_Cikis_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            string miktar = dt_fix_mal.SelectedRows.Cells[4].Value.ToString();
            FixMalMiktarDegistirmeDialog form = new FixMalMiktarDegistirmeDialog(miktar);
            form.ShowDialog();
            if ( == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else
            {
                this.txtResult.Text = "Cancelled";
            }
        }


   }
    
}