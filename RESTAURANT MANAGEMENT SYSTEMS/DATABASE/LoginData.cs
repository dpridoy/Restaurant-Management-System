using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;
using System.Data;

namespace DATABASE
{
    public class LoginData
    {
        string sqlConnectionString = @"Data Source=FORTUNE\SQLEXPRESS;Initial Catalog=DATA;Integrated Security=True";





        public string LOGIN(LOGINTYPE l)
        {

            SqlConnection con = new SqlConnection( sqlConnectionString);
            //LOGIN l = new LOGIN();
            SqlCommand d = new SqlCommand("Select * from LOGIN WHERE USERNAME= '" + l.USERNAME + "' and PASSWORD='" + l.PASSWORD + "'", con);
            con.Open();
            SqlDataReader r = d.ExecuteReader();
            String username = null;
            String password = null;
            String type = null;
            while (r.Read())
            {
                username = r["USERNAME"].ToString();
                password = r["PASSWORD"].ToString();
                type = r["TYPE"].ToString();
            }
           
            con.Close();

            if (type == null)
            {
                return "error";
            }
            else
            {
                return type;
            }

        }




    }
}


     
