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
    public partial class STAFFINFO : Form
    {
        public STAFFINFO()
        {
            InitializeComponent();
            this.Load += STAFFINFO_Load;
            this.dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            //this.FormClosing += STAFFINFO_FormClosing;
        }

        /*void STAFFINFO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ADMIN a = new ADMIN();
                a.Show();
            }
            else
           {
                e.Cancel = true;
            }
        }*/

        void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            object data = this.dataGridView1.Rows[rowIndex].DataBoundItem;
           STAFFTYPE f = (STAFFTYPE)data;
            populate(f);
        }
        void populate(STAFFTYPE f)
        {
            textBox1.Text = f.ID;
            textBox2.Text = f.NAME;
            textBox3.Text = f.AGE;
            textBox4.Text = f.HOMETOWN;
            textBox5.Text = f.DEPARTMENT;


        }

        void STAFFINFO_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            StaffData d = new StaffData();
            dataGridView1.DataSource = d.STAFF();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            STAFFTYPE f = new STAFFTYPE();

            f.ID = textBox1.Text;
            f.NAME = textBox2.Text;
            f.AGE = textBox3.Text;
            f.HOMETOWN = textBox4.Text;
            f.DEPARTMENT = textBox5.Text;
            StaffData d = new StaffData();

            if (d.InsertData(f))
            {
                this.Init();
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            STAFFTYPE f = new STAFFTYPE();

            f.ID = textBox1.Text;
            f.NAME = textBox2.Text;
            f.AGE = textBox3.Text;
            f.HOMETOWN = textBox4.Text;
            f.DEPARTMENT = textBox5.Text;
            StaffData d = new StaffData();

            if (d.DeleteData(f))
            {
                this.Init();
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STAFFTYPE f = new STAFFTYPE();

            f.ID = textBox1.Text;
            f.NAME = textBox2.Text;
            f.AGE = textBox3.Text;
            f.HOMETOWN = textBox4.Text;
            f.DEPARTMENT = textBox5.Text;
            StaffData d = new StaffData();

            if (d.UpdateData(f))
            {
                this.Init();
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
            populate(new STAFFTYPE());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMIN a = new ADMIN();
            a.Show();
        }
    }
}
