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
  public  class MemberData
    {
      string sqlConnectionString = @"Data Source=FORTUNE\SQLEXPRESS;Initial Catalog=DATA;Integrated Security=True";

        public List<MEMBERTYPE> MEMBER()
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);
            //LOGIN l = new LOGIN();
            SqlCommand d = new SqlCommand("Select * from MEMBERS", con);
            con.Open();
            SqlDataReader r = d.ExecuteReader();

            var memberlist = new List<MEMBERTYPE>();

            //String FOODNAME = null;
            //String PRICE= null;
            //string QUANTITY = null;
            //string DISCOUNT = null;
            //string INFORMATION = null;
            while (r.Read())
            {
                var m = new MEMBERTYPE();

                m.NAME = r["NAME"].ToString();
                m.AGE= r["AGE"].ToString();
                m.CARDNO = r["CARDNO"].ToString();
                m.ADDRESS = r["ADDRESS"].ToString();
                m.OCCUPATION= r["OCCUPATION"].ToString();

                memberlist.Add(m);
            }
            con.Close();



            return memberlist;

        }

        public bool InsertData(MEMBERTYPE obj)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);

                string insertCommand = "INSERT INTO MEMBERS " +
                    "(NAME,AGE,CARDNO,ADDRESS,OCCUPATION)"
                    + "VALUES (@NAME,@AGE,@CARDNO,@ADDRESS,@OCCUPATION)";
                SqlCommand command = new SqlCommand(insertCommand, connection);

                SqlParameter p1 = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                p1.Value = obj.NAME;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@AGE", SqlDbType.NVarChar, 50);
                p2.Value = obj.AGE;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@CARDNO", SqlDbType.NVarChar, 50);
                p3.Value = obj.CARDNO;
                command.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50);
                p4.Value = obj.ADDRESS;
                command.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@OCCUPATION", SqlDbType.NVarChar, 50);
                p5.Value = obj.OCCUPATION;
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


        public bool UpdateData(MEMBERTYPE f)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                string updateCommand = "UPDATE MEMBERS SET  AGE=@AGE,CARDNO=@CARDNO,ADDRESS=@ADDRESS,OCCUPATION=@OCCUPATION WHERE NAME=@NAME";
                SqlCommand command = new SqlCommand(updateCommand, con);


              SqlParameter p1 = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
               p1.Value = f.NAME;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@AGE", SqlDbType.NVarChar, 50);
                p2.Value = f.AGE;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@CARDNO", SqlDbType.NVarChar, 50);
                p3.Value = f.CARDNO;
                command.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50);
                p4.Value = f.ADDRESS;
                command.Parameters.Add(p4);

                SqlParameter p5= new SqlParameter("@OCCUPATION", SqlDbType.NVarChar, 50);
                p5.Value = f.OCCUPATION;
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

       
        public bool DeleteData(MEMBERTYPE  m)
        {

            try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                string DeleteCommand = "delete from MEMBERS where NAME=@NAME";
                SqlCommand command = new SqlCommand(DeleteCommand, con);
                SqlParameter p1 = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                p1.Value = m.NAME;
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
    

