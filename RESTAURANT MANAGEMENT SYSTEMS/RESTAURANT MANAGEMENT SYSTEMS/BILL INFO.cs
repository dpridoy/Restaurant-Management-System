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
    public partial class BILL_INFO : Form
    {
        public struct ORDERS
        {
            public string item;
            public double price;


        }
        const double tax = 0.075;
        ORDERS d = new ORDERS();
        static double subtotal;
        static double totaltaxes;
        static double total;
        
             
        public BILL_INFO()
        {
            InitializeComponent();
            this.FormClosing += BILL_INFO_FormClosing;
        }

        void BILL_INFO_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        
        }
        private void getvalues(string memberorders)
        {
            d.item = memberorders.Split('$')[0];
            d.price = Convert.ToDouble(memberorders.Split('$')[1]);
            
            listBox1.Items.Add("ITEM NO  :" + "  "+   d.item);
            listBox1.Items.Add("...............................................................................");

           

            listBox1.Items.Add("PRICE IN $:" +"  " +d.price.ToString());

            listBox1.Items.Add("...............................................................................");

           
           
            subtotal += d.price;
            listBox1.Items.Add("SUBTOTAL IN $  :" +"   "+ subtotal.ToString(""));
            listBox1.Items.Add("...............................................................................");

           
            totaltaxes += d.price * tax;

           
            listBox1.Items.Add("TAX IN $  :-  " +" "+ totaltaxes.ToString(""));
            listBox1.Items.Add("................................................................................");
            total += d.price + (d.price * tax);

            listBox1.Items.Add("................................................................................");
            listBox1.Items.Add("TOTAL IN $ :-   " + "  "+total.ToString(""));

            listBox1.Items.Add("OUR GOVERMENT INCLUDED IN TAX 7.5%");
            listBox1.Items.Add("FOR THIS RESON IF YOU CAN BUY FOOD THEN YOU GIVE MUST 7.5% VAT ");
            listBox1.Items.Add(".................................................................");
            listBox1.Items.Add(" ...............................THNX FOR BUYING FOODS...............        ");
          
           // listBox1.Items.Clear();

            }
        
        private void putdown(object sender, EventArgs e)
        {

            if (sender == comboBox3)
            {
                getvalues(comboBox3.SelectedItem.ToString());

            }
           
            
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //ADMIN a = new ADMIN();
            //a.Show();
        }

        
    }
}
