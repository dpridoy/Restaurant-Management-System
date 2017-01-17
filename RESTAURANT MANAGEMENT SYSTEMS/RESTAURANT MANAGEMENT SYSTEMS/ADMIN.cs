using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT_SYSTEMS
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
          //this.FormClosing += ADMIN_FormClosing;
        }

     //void ADMIN_FormClosing(object sender, FormClosingEventArgs e)
       //
            //if (MessageBox.Show(this, "Are you sure", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
               // Environment.Exit(0);
            //else
            //{
               // e.Cancel = true;
           // }
      // }

        private void fOODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOOD f = new FOOD();
            f.Show();
        }

        private void mEMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEMBERS m = new MEMBERS();
            m.Show();
        }

        private void sTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STAFFINFO F = new STAFFINFO();
            F.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LOGIN_FORM l = new LOGIN_FORM();
            l.Show();
        }

        private void pRICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOOD_PRICE_LIST fpl = new FOOD_PRICE_LIST();
            //this.Hide();
            fpl.Show();
        }

        private void bILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BILL_INFO bl = new BILL_INFO();
            //this.Hide();
            bl.Show();
        }

        /*private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROCESS p = new PROCESS();
            p.Show();
            this.Close();
        }*/
    }
}
