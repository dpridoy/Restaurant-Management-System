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
    public partial class MEMBERS : Form
    {
        public MEMBERS()
        {
            InitializeComponent();
            this.Load += new EventHandler(MEMBERS_Load);
            this.dataGridView1.CellMouseClick +=new DataGridViewCellMouseEventHandler(dataGridView1_CellMouseClick);
            this.button3.Click +=new EventHandler(button3_Click);
           // this.FormClosing += MEMBERS_FormClosing;
        }

        //void MEMBERS_FormClosing(object sender, FormClosingEventArgs e)
        //{
           // if (MessageBox.Show(this, "Are you sure", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
             //   Environment.Exit(0);
            //else
           // {
              //  e.Cancel = true;
            //}
      //  }

        

        void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            object data = this.dataGridView1.Rows[rowIndex].DataBoundItem;
            MEMBERTYPE M = (MEMBERTYPE)data;
            
            populate(M);
        }
        void populate(MEMBERTYPE f)
        {
            textBox1.Text = f.NAME;
            textBox2.Text = f.AGE;
            textBox3.Text = f.CARDNO;
            textBox4.Text = f.ADDRESS;
            textBox5.Text = f.OCCUPATION;


        }
        void MEMBERS_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            MemberData m= new MemberData();
           dataGridView1.DataSource = m.MEMBER();
          // populate(new MEMBERTYPE());
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MEMBERTYPE M = new MEMBERTYPE();
            M.NAME = textBox1.Text;
            M.AGE= textBox2.Text;
            M.CARDNO = textBox3.Text;
            M.ADDRESS = textBox4.Text;
            M.OCCUPATION = textBox5.Text;

            MemberData m1 = new MemberData();
            if (m1.InsertData(M))
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
            MEMBERTYPE M = new MEMBERTYPE();
            M.NAME = textBox1.Text;
            M.AGE = textBox2.Text;
            M.CARDNO = textBox3.Text;
            M.ADDRESS = textBox4.Text;
            M.OCCUPATION = textBox5.Text;

            MemberData m1 = new MemberData();
            if (m1.DeleteData(M))
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
            MEMBERTYPE M = new MEMBERTYPE();
            M.NAME = textBox1.Text;
            M.AGE = textBox2.Text;
            M.CARDNO = textBox3.Text;
            M.ADDRESS = textBox4.Text;
            M.OCCUPATION = textBox5.Text;

            MemberData m1 = new MemberData();
            if (m1.UpdateData(M))
            {

                this.Init();
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
            populate(new MEMBERTYPE());

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMIN a = new ADMIN();
            a.Show();

        }
    }
}
