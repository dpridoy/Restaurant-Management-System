using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using DATABASE;

namespace RESTAURANT_MANAGEMENT_SYSTEMS
{
    public partial class PROCESS : Form
    {
        public PROCESS()
        {
            InitializeComponent();
            this.Load += new EventHandler(PROCESS_Load);
            this.dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
           // this.FormClosing += PROCESS_FormClosing;
        }

       // void PROCESS_FormClosing(object sender, FormClosingEventArgs e)
       // {

           // if (MessageBox.Show(this, "Are you sure", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
               // Environment.Exit(0);
            //else
            //{
               // e.Cancel = true;
           // }
       // }

        void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            object data = this.dataGridView1.Rows[rowIndex].DataBoundItem;
           ORDERSTYPE f = (ORDERSTYPE)data;
           
            populate(f);
        }

        void PROCESS_Load(object sender, EventArgs e)
        {

            this.Init();

        }

        void populate(ORDERSTYPE f)
        {
            textBox1.Text = f.ITEM;
            textBox2.Text = f.NAME;
            textBox3.Text = f.PRICE;
           
        }
        private void Init()
        {
           OrdersData d = new OrdersData();
           
            dataGridView1.DataSource = d.ORDER();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WAIT JUST A MINUTE!,YOUR ORDER WILL BE PROCESSING");

        }

    }

}