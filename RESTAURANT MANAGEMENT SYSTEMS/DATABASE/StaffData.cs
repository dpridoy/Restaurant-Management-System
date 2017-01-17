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
   public class StaffData
    {
       string sqlConnectionString = @"Data Source=FORTUNE\SQLEXPRESS;Initial Catalog=DATA;Integrated Security=True";

        public List<STAFFTYPE> STAFF()
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);
            
            SqlCommand d = new SqlCommand("Select * from STAFF", con);
            con.Open();
            SqlDataReader r = d.ExecuteReader();

            var stafflist = new List<STAFFTYPE>();

            
            while (r.Read())
            {
                var s = new STAFFTYPE();

                s.ID = r["ID"].ToString();
                s.NAME = r["NAME"].ToString();
                s.AGE = r["AGE"].ToString();
                s.HOMETOWN = r["HOMETOWN"].ToString();
                s.DEPARTMENT = r["DEPARTMENT"].ToString();

                stafflist.Add(s);
            }
            con.Close();



            return stafflist;

        }

        public bool InsertData(STAFFTYPE obj)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);

                string insertCommand = "INSERT INTO STAFF " +
                    "(ID,NAME,AGE,HOMETOWN,DEPARTMENT)"
                    + "VALUES (@ID,@NAME,@AGE,@HOMETOWN,@DEPARTMENT)";
                SqlCommand command = new SqlCommand(insertCommand, connection);

                SqlParameter p1 = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                p1.Value = obj.ID;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                p2.Value = obj.NAME;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@AGE", SqlDbType.NVarChar, 50);
                p3.Value = obj.AGE;
                command.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@HOMETOWN", SqlDbType.NVarChar, 50);
                p4.Value = obj.HOMETOWN;
                command.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@DEPARTMENT", SqlDbType.NVarChar, 50);
                p5.Value = obj.DEPARTMENT;
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
        public bool UpdateData(STAFFTYPE obj)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                string updateCommand = "UPDATE STAFF SET  NAME=@NAME,AGE=@AGE,HOMETOWN=@HOMETOWN,DEPARTMENT=@DEPARTMENT WHERE ID=@ID";
                SqlCommand command = new SqlCommand(updateCommand, con);


                SqlParameter p1 = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                p1.Value = obj.ID;
                command.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                p2.Value = obj.NAME;
                command.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@AGE", SqlDbType.NVarChar, 50);
                p3.Value = obj.AGE;
                command.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@HOMETOWN", SqlDbType.NVarChar, 50);
                p4.Value = obj.HOMETOWN;
                command.Parameters.Add(p4);

                SqlParameter p5 = new SqlParameter("@DEPARTMENT", SqlDbType.NVarChar, 50);
                p5.Value = obj.DEPARTMENT;
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

        public bool DeleteData(STAFFTYPE f)
        {

            try
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                string DeleteCommand = "delete from STAFF where ID=@ID";
                SqlCommand command = new SqlCommand(DeleteCommand, con);
                SqlParameter p1 = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                p1.Value = f.ID;
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

