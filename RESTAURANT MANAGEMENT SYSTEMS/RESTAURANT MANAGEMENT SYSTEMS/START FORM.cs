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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Environment.Exit(0);
            else
            {
                e.Cancel = true;
            }
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN_FORM F = new LOGIN_FORM() ;
            F.Show();
        }

        private void aDDFOODToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEW_RESTAURANT F = new VIEW_RESTAURANT();
            F.Show();
        }

       
    }
}
