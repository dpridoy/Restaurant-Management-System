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
    public partial class FOOD : Form
    {
        
        public FOOD()
        {
            InitializeComponent();
            this.Load +=new EventHandler( FOOD_Load);
            this.dataGridView1.CellMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_CellMouseClick);
            //this.FormClosing += FOOD_FormClosing;
            
           this.button2.Click+=new EventHandler(button2_Click);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           FOODTYPE f = new FOODTYPE();

           f.FOODNAME = textBox1.Text;
           f.PRICE = textBox2.Text;
           f.QUANTITY = textBox3.Text;
           f.DISCOUNT = textBox4.Text;
           f.INFORMATION = textBox5.Text;
           FoodData d = new FoodData();

           if (d.UpdateData(f))
           {
               this.Init();
           }
           else
           {
               MessageBox.Show("Something Wrong");
           }

           populate(new FOODTYPE());

        }


        void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            object data = this.dataGridView1.Rows[rowIndex].DataBoundItem;
            FOODTYPE f = (FOODTYPE)data;
            populate(f);

        }

        void populate(FOODTYPE f)
        {
            textBox1.Text = f.FOODNAME;
            textBox2.Text = f.PRICE;
            textBox3.Text = f.QUANTITY;
            textBox4.Text = f.DISCOUNT;
            textBox5.Text = f.INFORMATION;


        }

         
        void FOOD_Load(object sender, EventArgs e)
        {
            this.Init();   
        }

        private void Init()
       {
            FoodData d = new FoodData();
            dataGridView1.DataSource = d.FOODS();
     }

      

        private void button1_Click(object sender, EventArgs e)
        {
           
            string FOODNAME = textBox1.Text;
            string PRICE = textBox2.Text;
            string QUANTITY = textBox3.Text;
            string DISCOUNT = textBox4.Text;
            string INFORMATION = textBox5.Text;

            FOODTYPE f = new FOODTYPE();

            f.FOODNAME = textBox1.Text;
            f.PRICE = textBox2.Text;
            f.QUANTITY = textBox3.Text;
            f.DISCOUNT = textBox4.Text;
            f.INFORMATION = textBox5.Text;
            FoodData d = new FoodData();

            if (d.InsertData(f))
            {
                this.Init();
            }
            else 
            {
                MessageBox.Show("Something Wrong");
            }
            

        }

        private void FOOD_Load_1(object sender, EventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            string FOODNAME = textBox1.Text;
            string PRICE = textBox2.Text;
            string QUANTITY = textBox3.Text;
            string DISCOUNT = textBox4.Text;
            string INFORMATION = textBox5.Text;

            FOODTYPE f = new FOODTYPE();

            f.FOODNAME = textBox1.Text;
            f.PRICE = textBox2.Text;
            f.QUANTITY = textBox3.Text;
            f.DISCOUNT = textBox4.Text;
            f.INFORMATION = textBox5.Text;
            FoodData d = new FoodData();
            if (d.DeleteData(f))
            {

                this.Init();
            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
