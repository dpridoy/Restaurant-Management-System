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
     public class FoodData
    {
         string sqlConnectionString = @"Data Source=FORTUNE\SQLEXPRESS;Initial Catalog=DATA;Integrated Security=True";

        public List<FOODTYPE> FOODS()
        {
            SqlConnection con = new SqlConnection( sqlConnectionString);
            //LOGIN l = new LOGIN();
            SqlCommand d = new SqlCommand("Select * from FOODS", con);
            con.Open();
            SqlDataReader r = d.ExecuteReader();

            var foodlist = new List<FOODTYPE>();

            //String FOODNAME = null;
            //String PRICE= null;
            //string QUANTITY = null;
            //string DISCOUNT = null;
            //string INFORMATION = null;
            while (r.Read())
            {
                var foods = new FOODTYPE();

                foods.FOODNAME = r["FOODNAME"].ToString();
                foods.PRICE = r["PRICE"].ToString();
                foods.QUANTITY = r["QUANTITY"].ToString();
                foods.DISCOUNT = r["DISCOUNT"].ToString();
                foods.INFORMATION = r["INFORMATION"].ToString();

                foodlist.Add(foods);
            }
            con.Close();



            return foodlist;
            
        }

        public bool InsertData(FOODTYPE obj)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);

                string insertCommand = "INSERT INTO FOODS " +
                    "(FOODNAME,PRICE,QUANTITY,DISCOUNT,INFORMATION)"
                    + "VALUES (@FOODNAME,@PRICE,@QUANTITY,@DISCOUNT,@INFORMATION)";
                SqlCommand command = new SqlCommand(insertCommand, connection);

                SqlParameter p1 = new SqlParameter("@FOODNAME", SqlDbType.NVarChar, 50);
                p1.Value = obj.FOODNAME;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
                p2.Value = obj.PRICE;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@QUANTITY", SqlDbType.NVarChar, 50);
                p3.Value = obj.QUANTITY;
                command.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@DISCOUNT", SqlDbType.NVarChar, 50);
                p4.Value = obj.DISCOUNT;
                command.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@INFORMATION", SqlDbType.NVarChar, 50);
                p5.Value = obj.INFORMATION;
                command.Parameters.Add(p5);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }
        public bool UpdateData(FOODTYPE f)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

            string updateCommand = "UPDATE FOODS SET  PRICE=@PRICE,QUANTITY=@QUANTITY,DISCOUNT=@DISCOUNT,INFORMATION=@INFORMATION WHERE FOODNAME=@FOODNAME";
            SqlCommand command = new SqlCommand(updateCommand, con);


            SqlParameter p1 = new SqlParameter("@FOODNAME", SqlDbType.NVarChar, 50);
           p1.Value = f.FOODNAME;
            command.Parameters.Add(p1);
           
            SqlParameter p2 = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            p2.Value = f.PRICE;
            command.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter("@QUANTITY", SqlDbType.NVarChar, 50);
            p3.Value =f.QUANTITY;
            command.Parameters.Add(p3);

             SqlParameter p4 = new SqlParameter("@DISCOUNT", SqlDbType.NVarChar, 50);
            p4.Value =f.DISCOUNT;
            command.Parameters.Add(p4);

             SqlParameter p5= new SqlParameter("@INFORMATION", SqlDbType.NVarChar, 50);
            p5.Value =f.INFORMATION;
            command.Parameters.Add(p5);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            }
           
                 catch (Exception ex)
            {
                return false;
            }
            return true;
            }

        public bool DeleteData(FOODTYPE f)
        {

              try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

            string DeleteCommand = "delete from FOODS where FOODNAME=@FOODNAME";
            SqlCommand command = new SqlCommand(DeleteCommand, con);
            SqlParameter p1 = new SqlParameter("@FOODNAME", SqlDbType.NVarChar, 50);
            p1.Value = f.FOODNAME;
            command.Parameters.Add(p1);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            }
           
                 catch (Exception ex)
            {
                return false;
            }
            return true;
            }


        }
        }
    
