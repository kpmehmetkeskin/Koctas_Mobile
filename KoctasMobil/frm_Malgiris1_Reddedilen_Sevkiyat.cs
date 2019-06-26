using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_Malgiris1_Reddedilen_Sevkiyat : Form
    {
        public frm_Malgiris1_Reddedilen_Sevkiyat()
        {
            InitializeComponent();
        }

        private void redSiparisEkle_Click(object sender, EventArgs e)
        {
            try{
                WS_Sevkiyat.ZmmFSaveReddSevkLog sevkiyat = new KoctasMobil.WS_Sevkiyat.ZmmFSaveReddSevkLog();
                if (siparisTextBox.Text.ToString() == "" || siparisTextBox.Text.ToString() == null)
                {
                    return;
                }
                else
                {
                    sevkiyat.IEbeln = siparisTextBox.Text.ToString();
                }

                if (saticiTextBox.Text.ToString() == "" || saticiTextBox.Text.ToString() == null)
                {
                    return;
                }
                else
                {
                    sevkiyat.ILifnr = saticiTextBox.Text.ToString();
                }
                 
                if (irsaliyeTextBox.Text.ToString() == "" || irsaliyeTextBox.Text.ToString()== null)
                {
                    return;
                }
                else
                {
                    sevkiyat.IXblnr = irsaliyeTextBox.Text.ToString();
                }

                KoctasMobil.WS_Sevkiyat.ZmmFSaveReddSevkLogResponse resp = new KoctasMobil.WS_Sevkiyat.ZmmFSaveReddSevkLogResponse();

                if (resp.EtReturn.Length > 0)
                {
                    MessageBox.Show("İşlem tamamlandı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resp.EtReturn[0].Message);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }
    }
}