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
using System.Data.SqlClient;
namespace RESTAURANT_MANAGEMENT_SYSTEMS
{
    public partial class LOGIN_FORM : Form
    {
       // private Form1 f;
        public LOGIN_FORM()
        {
            InitializeComponent();
            //this.FormClosing += LOGIN_FORM_FormClosing;
        }

        
       

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            if (name.Equals("")) { MessageBox.Show("USERNAME required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
             if (pass.Equals("")) { MessageBox.Show("PASSWORD required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string type;
            LOGINTYPE l = new LOGINTYPE();

            l.USERNAME = textBox1.Text;
            l.PASSWORD = textBox2.Text;

            LoginData b = new LoginData();
         
            type = b.LOGIN(l);
            

          if (type == "ADMIN")
            {
                this.Close();
                 ADMIN a = new ADMIN();
                  a.Show();   
                    MessageBox.Show("LOGIN SUCCESSFUL", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
             
            else if (type == "MEMBER")
            {
                this.Close();
                MEMBER m = new MEMBER();
                m.Show();
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Username or Password Error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
          
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

   
    }
}