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
    public partial class MEMBER : Form
    {
        public MEMBER()
        {
            InitializeComponent();
            this.FormClosing += MEMBER_FormClosing;
        }

        void MEMBER_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (MessageBox.Show(this, "Are you sure?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LOGIN_FORM a = new LOGIN_FORM();
                a.Show();
            }

            else
            {
                e.Cancel = true;
            }
        
        }

        private void mEMBERSHIPSTATUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEMBERSHIP_DETAILS M = new MEMBERSHIP_DETAILS();
            M.Show();

        }

        private void dUEFINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOOD_PRICE_LIST F = new FOOD_PRICE_LIST();
            F.Show();
        }

        private void MEMBER_Load(object sender, EventArgs e)
        {

        }

        private void pROCESSSYSTEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROCESS P = new PROCESS();
            P.Show();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bILLSYSTEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BILL_INFO B = new BILL_INFO();
            B.Show();
        }

 
       

       
    }
}
