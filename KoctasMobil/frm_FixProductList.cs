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

        public FixProductList()
        {
            InitializeComponent();
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
            this.WindowState = FormWindowState.Maximized;
  
      }
   }

    

}