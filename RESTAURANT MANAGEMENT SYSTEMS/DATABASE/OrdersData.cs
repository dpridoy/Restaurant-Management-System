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
    public class OrdersData
    {
        string sqlConnectionString = @"Data Source=FORTUNE\SQLEXPRESS;Initial Catalog=DATA;Integrated Security=True";

        public List<ORDERSTYPE> ORDER()
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);

            SqlCommand d = new SqlCommand("Select * from ORDERS", con);
            con.Open();
            SqlDataReader r = d.ExecuteReader();

            var orderslist = new List<ORDERSTYPE>();


            while (r.Read())
            {
                var s = new ORDERSTYPE();

                s.ITEM = r["ITEM"].ToString();
                s.NAME = r["NAME"].ToString();
                s.PRICE = r["PRICE"].ToString();


                orderslist.Add(s);
            }
            con.Close();



            return orderslist;

        }
    }
}