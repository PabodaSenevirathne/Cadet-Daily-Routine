using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace CadetSystem
{
   public class DataAccessLayer
    {

        static SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadetSystemConnection"].ToString());


        public static DataTable ExecuteQuery(string query, SqlCommand sqlCmd)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                sqlCmd.Connection = Conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                da.SelectCommand = sqlCmd;
                Conn.Open();
                da.Fill(dt);
                Conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Conn.Close();
                throw ex;
            }
        }

        public static void ExecuteNonQuery(string query, SqlCommand sqlCmd)
        {
            try
            {
                sqlCmd.Connection = Conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                Conn.Open();
                sqlCmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                Conn.Close();
                throw ex;
            }
        }


        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, string value)
        {
            msc.Parameters.Add(param, dtype).Value = ((value == string.Empty) || (value == null)) ? (object)DBNull.Value : value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, int length, string value)
        {
            msc.Parameters.Add(param, dtype, length).Value = ((value == string.Empty) || (value == null)) ? (object)DBNull.Value : value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, int value)
        {
            msc.Parameters.Add(param, dtype).Value =  value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, long value)
        {
            msc.Parameters.Add(param, dtype).Value =  value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, Decimal value)
        {
            msc.Parameters.Add(param, dtype).Value =  value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, bool value)
        {
            msc.Parameters.Add(param, dtype).Value = value;
        }

        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, byte value)
        {
            msc.Parameters.Add(param, dtype).Value = value;
        }


        public static void AddParameters(SqlCommand msc, string param, SqlDbType dtype, DateTime value)
        {
            msc.Parameters.Add(param, dtype).Value = value;
        }

    }
}
